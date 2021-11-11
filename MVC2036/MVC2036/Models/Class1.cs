using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace MVC2036.Models {
    public class Category{
        [Key]
        [Display(Name = "Cat Id")]
        public int CatId { get; set; }

        [Required]
        [Display(Name = "Cat Title")]
        public string CatTitle { get; set; }

        [Display(Name = "Cat Description")]
        public string CatDesc{ get; set; }


        public virtual ICollection<Item> Items { get; set; }
    }

    public class Item {
        [Key]
        [Display(Name = "Item Id")]
        public int ItemId { get; set; }

        [Required]
        [Display(Name = "Cat Id")]
        public int CatId { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string ItemTitle { get; set; }

        [Required]
        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public double ItemPrice { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string ItemDesc { get; set; }

        [Display(Name = "Image")]
        public string ItemImage { get; set; }

        [Display(Name = "Category")]
        public virtual Category Cat { get; set; }
    }

    public class MyShopContext : DbContext {
        public MyShopContext(DbContextOptions<MyShopContext> options): base(options) {

        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Item> Items { get; set; }

    }
}
