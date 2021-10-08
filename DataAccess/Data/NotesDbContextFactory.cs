using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class NotesDbContextFactory : IDesignTimeDbContextFactory<NotesDbContext>
    {
        public NotesDbContext CreateDbContext(string[] args)
        {
            
            var optionsBuilder = new DbContextOptionsBuilder<NotesDbContext>();

            var currentDir = Directory.GetCurrentDirectory();
            var path = Path.Combine(currentDir, "NotesDB.db");
            var connString = "Data Source=" + path;

            optionsBuilder.UseSqlite(connString);

            return new NotesDbContext(optionsBuilder.Options);
        }
    }
}
