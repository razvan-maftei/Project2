using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2Model;

namespace Project2API.API
{
    public static class MetadataAPI
    {
        public static void ChangeMetadataForFile(string path, Metadata metadata)
        {
            using (var context = new Project2Container())
            {
                var fileToUpdate = context.Files.SingleOrDefault(f => f.Path == path);
                if (fileToUpdate != null)
                {
                    fileToUpdate.Metadata = metadata;
                    context.SaveChanges();
                }
            }
        }

        public static void DeleteCustomMetadata(string columnName)
        {
            using (var context = new Project2Container())
            {
                foreach (var file in context.Files)
                {
                    var pairs = file.Metadata.CustomFields.Split(';').ToList();
                    foreach (var pair in pairs)
                    {
                        var attribute = pair.Split(':')[0];
                        if (attribute == columnName)
                        {
                            pairs.Remove(pair);
                            break;
                        }
                    }

                    var newMetadata = pairs.Aggregate((a, b) => a + ';' + b);
                    file.Metadata.CustomFields = newMetadata;
                    context.SaveChanges();
                }
            }
        }
    }
}
