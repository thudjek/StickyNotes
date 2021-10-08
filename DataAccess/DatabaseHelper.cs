using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DatabaseHelper
    {
        public static Note LoadNote()
        {
            using (var dbContext = new NotesDbContext())
            {
                return dbContext.Notes.FirstOrDefault();
            }
        }

        public static bool SaveNote(Note note)
        {
            using (var dbContext = new NotesDbContext())
            {
                if (dbContext.Notes.Any(n => n.Id == note.Id))
                {
                    dbContext.Notes.FirstOrDefault(n => n.Id == note.Id).Content = note.Content;
                }
                else 
                {
                    dbContext.Notes.Add(note);
                }

                return dbContext.SaveChanges() > 0;
            }
        }
    }
}
