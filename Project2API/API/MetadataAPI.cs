using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

        public static void DeleteCustomTag(string columnName)
        {
            using (var context = new Project2Container())
            {
                foreach (var tag in context.Tags)
                {
                    if (String.Equals(tag.Key, columnName, StringComparison.CurrentCultureIgnoreCase))
                    {
                        context.Tags.Remove(tag);
                    }
                }

                context.SaveChanges();
            }
        }

        public static void AddTag(Tag tag)
        {
            using (var context = new Project2Container())
            {
                context.Tags.Add(tag);
                context.SaveChanges();
            }
        }

        public static List<File> GetFilesByTagKey(string key)
        {
            using (var context = new Project2Container())
            {
                List<File> fileList = new List<File>();
                fileList.AddRange(context.Files.Include(f => f.Metadata).Include(f => f.Tags)
                    .Where(f => f.Tags.Any(t => String.Equals(t.Key, key, StringComparison.CurrentCultureIgnoreCase))));
                return fileList;
            }
        }
    }
}
