using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;

namespace BethanysPieShop.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Pie> DbProduct { get; set; }
       // public DbSet<Contact> DbContact { get; set; }
        public DbSet<Commentary> DbCommentary { get; set; }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Ljusa bröd" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Mörka bröd" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Fikabröd" });

            //seed pies

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "PågenLimpan",
                Price = 12.95M,
                ShortDescription = "Our famous PågenLimpan!",
                LongDescription =
                    "Den klassiska svenska limpan är bakad på vete och siktat rågmjöl som tillsammans med surdeg och sirap ger en härlig mjuk och saftigt limpa. ",
                CategoryId = 1,
                ImageUrl = "https://2.bp.blogspot.com/-d8e2nmOorkE/U_XKWujXRWI/AAAAAAAAHCE/AXGKM61KPPo/s1600/IMG_0144.JPG",
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://2.bp.blogspot.com/-d8e2nmOorkE/U_XKWujXRWI/AAAAAAAAHCE/AXGKM61KPPo/s1600/IMG_0144.JPG",
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name = "Levain ",
                Price = 22.95M,
                ShortDescription = "Our famous Levain !",
                LongDescription =
                     "Fantastiskt gott osötat surdegsbröd bakat på de allra finaste råvarorna. Bakat med solmoget vete och få ingredienser – inga konstigheter. ",
                CategoryId = 1,
                ImageUrl = "https://2.bp.blogspot.com/-F6f8hLhesUQ/VLEnDcjErkI/AAAAAAAALd4/SPi7iPrTvVk/s1600/IMG_0856.JPG",
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://2.bp.blogspot.com/-F6f8hLhesUQ/VLEnDcjErkI/AAAAAAAALd4/SPi7iPrTvVk/s1600/IMG_0856.JPG",
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                Name = "LingonGrova Special  ",
                Price = 28.95M,
                ShortDescription = "Our famous LingonGrova Special  !",
                LongDescription =
                     "Bästa starten på dagen! Mer lingon och mindre socker gör LingonGrova Special till ett lite nyttigare alternativ. ",
                CategoryId = 2,
                ImageUrl = "https://1.bp.blogspot.com/-SGJXsQtWHFk/W1SFb6T2f0I/AAAAAAAATMA/H1t0RpzLGecrylYEEsP0sDJCWBMtU4O1ACLcBGAs/s1600/IMG_0413.JPG",
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://1.bp.blogspot.com/-SGJXsQtWHFk/W1SFb6T2f0I/AAAAAAAATMA/H1t0RpzLGecrylYEEsP0sDJCWBMtU4O1ACLcBGAs/s1600/IMG_0413.JPG",
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 4,
                Name = "Råg Levain ",
                Price = 24.95M,
                ShortDescription = "Our famous Råg Levain !",
                LongDescription =
                     "Smakrikt rustikt surdegsbröd med malt och groddade rågkärnor. Bakat med mjöl från vår egen kvarn och få ingredienser – inga konstigheter. ",
                CategoryId = 2,
                ImageUrl = "https://4.bp.blogspot.com/-v6Pkoxdc39U/Wd9KqNpDbPI/AAAAAAAASpo/0IY_PvBm37EIFYEkLJXFndNQzqIwz93RQCLcBGAs/s1600/IMG_4861.JPG",
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://4.bp.blogspot.com/-v6Pkoxdc39U/Wd9KqNpDbPI/AAAAAAAASpo/0IY_PvBm37EIFYEkLJXFndNQzqIwz93RQCLcBGAs/s1600/IMG_4861.JPG",
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 5,
                Name = "Gifflar Kanel  ",
                Price = 32.95M,
                ShortDescription = "Our famous Gifflar Kanel  !",
                LongDescription =
                     "Originalet! Klassiska Gifflar Kanel är gräddade med en smakrik kanelfyllning som virvlar sig hela vägen in i mitten. ",
                CategoryId = 3,
                ImageUrl = "https://1.bp.blogspot.com/-CUXXI2PSyCY/XSMFkO3UhdI/AAAAAAAATq8/RpuhPwFsZ5giR-AO0T1l-L-8sSLDf5eBgCLcBGAs/s1600/IMG_1086.JPG",
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://1.bp.blogspot.com/-CUXXI2PSyCY/XSMFkO3UhdI/AAAAAAAATq8/RpuhPwFsZ5giR-AO0T1l-L-8sSLDf5eBgCLcBGAs/s1600/IMG_1086.JPG",
            });

            
        }
    }
}
