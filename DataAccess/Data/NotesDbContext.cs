using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options)
        {
        }

        public NotesDbContext()
        { 
        }

        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var currentDir = Directory.GetCurrentDirectory();
            var path = Path.Combine(currentDir, "NotesDB.db");
            var connString = "Data Source=" + path;
            optionsBuilder.UseSqlite(connString);
        }
    }
}
