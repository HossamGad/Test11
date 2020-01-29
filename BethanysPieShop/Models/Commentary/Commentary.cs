using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class Commentary
    {
        [Key]
        public int Id { get; set; }
        public int PieId { get; set; }

        public int CommentId { get; set; }
        public string CommentMessage { get; set; }
        public int ProductId { get; set; }
        public string Text { get; set; }
        public float Rating { get; set; }
    }
}
