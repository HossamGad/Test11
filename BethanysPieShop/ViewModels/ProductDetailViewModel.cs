using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    public class ProductDetailViewModel
    {
        public Pie ProductDetail { get; set; }

        public Pie PieId { get; set; }
        public List<Commentary> CommentaryList { get; set; }

       
        public string GradeAverage { get; set; }
    }
}
