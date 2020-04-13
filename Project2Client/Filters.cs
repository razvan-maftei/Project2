using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project2ObjectWCF.DTO;

namespace Project2Client {
    public partial class Filters : Form {

        FileMetadataTagClient FileService = new FileMetadataTagClient();

        public Filters()
        {
            InitializeComponent();
        }

        private void Filters_Load(object sender, EventArgs e)
        {
            RefreshTags();
        }

        private void RefreshTags()
        {
            var fileTags = FileService.GetFilesAndMetadata().SelectMany(f => f.Tags);
            if (fileTags.ToList().Count > 0)
            {
                var tagKeys = new List<string>();
                foreach (TagDTO tag in fileTags)
                {
                    tagKeys.Add(tag.Key);
                }
                FiltersCombo.Items.AddRange(tagKeys.ToArray());
                FiltersCombo.SelectedIndex = 0;
                FiltersCombo.Enabled = true;
                ApplyButton.Enabled = true;
                SearchBox.Enabled = true;
                DeleteTagBtn.Enabled = true;
            }
            else
            {
                FiltersCombo.Enabled = false;
                ApplyButton.Enabled = false;
                SearchBox.Enabled = false;
                DeleteTagBtn.Enabled = false;
            }

        }

        private void DeleteFilter(string Key)
        {
            FileService.DeleteCustomTag(Key);
            RefreshTags();
        }

        private void DeleteTagBtn_Click(object sender, EventArgs e)
        {
            DeleteFilter(FiltersCombo.SelectedText);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
