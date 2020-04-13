using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Project2ObjectWCF.DTO;

namespace Project2Client
{
    public partial class Form1 : Form
    {
        readonly FileMetadataTagClient _fileService = new FileMetadataTagClient();
        private List<FileDTO> _filesInDatabase;
        public Form1()
        {
            InitializeComponent();
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            var filesInDatabase = _fileService.GetFilesAndMetadata();

            var fileBrowser = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png|" +
                         "Video files (*.mp4, *.avi, *.mov, *.wmv) | *.mp4; *.avi; *.mov; *.wmv",
                Multiselect = true
            };
            fileBrowser.ShowDialog();
            foreach (var file in fileBrowser.FileNames)
            {
                if (filesInDatabase.All(f => f.Path != file))
                {
                    _fileService.AddFile(new FileDTO()
                    {
                        Path = file,
                        IsDeleted = false,
                        Metadata = new MetadataDTO()
                        {
                            CreationDate = DateTime.Now
                        }
                    });
                }
                else
                {
                    MessageBox.Show($"File {file} already in Album.");
                }
            }
        }

        public void UpdateImageGrid()
        {
            ImageGridFlow.Controls.Clear();
            this._filesInDatabase = new List<FileDTO>(_fileService.GetFilesAndMetadata());

            foreach (var file in _filesInDatabase)
            {
                if (!file.IsDeleted)
                {
                    var imageCard = new ImageCard
                    {
                        file = file,
                        parent = this
                    };
                    var pictureBox = (PictureBox) imageCard.Controls.Find("Thumbnail", true).FirstOrDefault();
                    pictureBox.Image = Image.FromFile(file.Path);
                    var label = (TextBox) imageCard.Controls.Find("FilenameBox", true).FirstOrDefault();
                    label.Text = file.Path.Split('\\').Last();
                    ImageGridFlow.Controls.Add(imageCard);
                }
            }
        }

        public void SearchMediaByName(string name)
        {
            ImageGridFlow.Controls.Clear();
            this._filesInDatabase = new List<FileDTO>(_fileService.FindFilesByFileName(name));

            foreach (var file in _filesInDatabase)
            {
                if (!file.IsDeleted)
                {
                    var imageCard = new ImageCard {file = file, parent = this};
                    var pictureBox = (PictureBox)imageCard.Controls.Find("Thumbnail", true).FirstOrDefault();
                    pictureBox.Image = Image.FromFile(file.Path);
                    var label = (TextBox)imageCard.Controls.Find("FilenameBox", true).FirstOrDefault();
                    label.Text = file.Path.Split('\\').Last();
                    ImageGridFlow.Controls.Add(imageCard);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UpdateImageGrid();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateImageGrid();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchMediaByName(SearchBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filterWindow = new Filters();
            filterWindow.Show();
        }
    }
}
