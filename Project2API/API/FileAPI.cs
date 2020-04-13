using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2Model;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Project2API.API {
    public static class FileAPI {
        public static void AddFile(File file)
        {
            using (var context = new Project2Container())
            {
                context.Files.AddOrUpdate(file);
                Boolean AlreadyExists = false;
                if (!context.Files.ToList().Exists(f => f.Path == file.Path))
                    context.Entry(file).State = (AlreadyExists ? EntityState.Modified : EntityState.Added);
                context.SaveChanges();
            }
        }

        public static ICollection GetFilesAndMetadata()
        {
            using (var context = new Project2Container())
            {
                return context.Files.Include(f => f.Metadata).Include(f => f.Tags).ToList();
            }
        }

        public static void DeleteFile(string path)
        {
            using (var context = new Project2Container())
            {
                var filesToUpdate = context.Files.Where(f => f.Path == path);
                foreach (var file in filesToUpdate)
                {
                    file.IsDeleted = true;
                }

                context.SaveChanges();
            }
        }

        public static ICollection FindByFileName(string name)
        {
            using (var context = new Project2Container())
            {
                List<File> fileList = new List<File>();
                fileList.AddRange(context.Files.Include(f => f.Metadata).Include(f => f.Tags)
                    .Where(f => f.Path.ToLower().Contains(name.ToLower())));
                return fileList;
            }
        }
    }
}