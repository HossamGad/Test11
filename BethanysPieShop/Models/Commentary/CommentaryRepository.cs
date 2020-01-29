using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    
    public class CommentaryRepository : ICommentary
    {
        
        private readonly AppDbContext database;

      
        public CommentaryRepository(AppDbContext appDbContext)
        {
            database = appDbContext;
        }

        // hämta alla kommentarer
        public IEnumerable<Commentary> AllCommentaries
        {
            get { return database.DbCommentary.Include(a =>a.CommentMessage); }
            
        }

        // hämta alla kommentarer för angiven produkt
        public IEnumerable<Commentary> GetAllcommentary()
        {
            return database.DbCommentary;
                           
        }
        public IEnumerable<Commentary> GetCommentaryByPieId(int PieId)
        {
            return database.DbCommentary.Where(c => c.PieId == PieId);
        }

        // lägg till ny kommentar
        public void CreateCommentAndAddToDatabase(Commentary newCommentary)
        {
            database.DbCommentary.Add(newCommentary);
            database.SaveChanges();

        }

        public void CreateCommentUpdateDatabase(Commentary newCommentary)
        {
            database.DbCommentary.Update(newCommentary);
            database.SaveChanges();

        }

        public IEnumerable<Commentary> GetCommentaryByProductId(int id)
        {
            return database.DbCommentary.Where(p => p.Id == id);
        }

        public IEnumerable<Commentary> GetCommentaryByCommentaryId(int commentId)
        {
            return database.DbCommentary.Where(c => c.CommentId == commentId);
        }
    }
}
