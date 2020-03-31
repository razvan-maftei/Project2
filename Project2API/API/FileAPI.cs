using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2Model;
using System.Data.Entity;

namespace Project2API.API
{
    public static class FileAPI
    {

        public static void AddFile(File file)
        {
            using (var context = new Project2Container())
            {
                var files = context.Files;
                if (!files.Any(f => f.Path == file.Path))
                {
                    files.Add(file);
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (DbEntityValidationException e)
                    {
                        throw;
                    }


                }
            }
        }

        public static List<File> GetFilesAndMetadata()
        {
            using (var context = new Project2Container())
            {
                return context.Files.Include(f => f.Metadata).ToList();
            }
        }

        public static void DeleteFile(string path)
        {
            using (var context = new Project2Container())
            {
                var fileToUpdate = context.Files.SingleOrDefault(f => f.Path == path);
                if (fileToUpdate != null)
                {
                    fileToUpdate.IsDeleted = true;
                    context.SaveChanges();
                }

            }
        }

        public static List<File> FindByFileName(string name)
        {
            using (var context = new Project2Container())
            {
                List<File> fileList = new List<File>();
                fileList.AddRange(context.Files.Include(f => f.Metadata).Where(f => f.Path.ToLower().Contains(name.ToLower())));
                return fileList;
            }
        }
    }
}
