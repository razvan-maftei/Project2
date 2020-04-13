using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Project2ObjectWCF.DTO;

namespace Project2Client {
    public partial class PropertiesWindow : Form {
        public FileDTO file;
        private FileMetadataTagClient FileService = new FileMetadataTagClient();

        public PropertiesWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            Process.Start(file.Path);
        }

        public void UpdateTreeView()
        {
            PictureBox.Image = Image.FromFile(file.Path);
            PropertyTreeView.SelectedNode = PropertyTreeView.Nodes.Add("Name");
            PropertyTreeView.SelectedNode.Nodes.Add(file.Path.Split('\\').Last());
            PropertyTreeView.SelectedNode = PropertyTreeView.Nodes.Add("Date");
            PropertyTreeView.SelectedNode.Nodes.Add(file.Metadata.CreationDate.ToString());
            foreach (var tag in file.Tags.GroupBy(x => x.Key).Select(x => x.First()))
            {
                var key = tag.Key;
                PropertyTreeView.SelectedNode = PropertyTreeView.Nodes.Add(key);
                foreach (var value in file.Tags.Where(x => x.Key == key).Select(x => x.Value))
                {
                    PropertyTreeView.SelectedNode.Nodes.Add(value);
                }
            }

            PropertyTreeView.ExpandAll();
        }

        private void AddTagBtn_Click(object sender, EventArgs e)
        {
            if (TagInputKey.Text.Length > 0 && TagInputValue.Text.Length > 0)
            {
                var tag = new TagDTO() {Key = TagInputKey.Text, Value = TagInputValue.Text, File = file};
                var fileTags = file.Tags.ToList();
                fileTags.Add(tag);
                file.Tags = fileTags.ToArray();
                FileService.AddFile(file);
            }
        }
    }
}