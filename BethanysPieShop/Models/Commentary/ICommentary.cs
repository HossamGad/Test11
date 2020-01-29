using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    
    public interface ICommentary
    {
        IEnumerable<Commentary> AllCommentaries { get; }

        IEnumerable<Commentary> GetAllcommentary();
        IEnumerable<Commentary> GetCommentaryByProductId(int id);
        void CreateCommentAndAddToDatabase(Commentary newCommentary);

        void CreateCommentUpdateDatabase(Commentary newCommentary);

        IEnumerable<Commentary> GetCommentaryByCommentaryId(int id);
    }
}
