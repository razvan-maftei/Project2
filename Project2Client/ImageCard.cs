using System;
using System.Windows.Forms;
using Project2ObjectWCF.DTO;

namespace Project2Client
{
    public partial class ImageCard : UserControl {
        private FileMetadataTagClient _fileService = new FileMetadataTagClient();
        public FileDTO file { get; set; }
        public Form1 parent { get; set; }
        public ImageCard()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var propertiesWindow = new PropertiesWindow();
            propertiesWindow.file = this.file;
            propertiesWindow.UpdateTreeView();
            propertiesWindow.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to remove this file from your Album?",
                "Remove File", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    _fileService.DeleteFile(file.Path);
                    this.parent.UpdateImageGrid();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
