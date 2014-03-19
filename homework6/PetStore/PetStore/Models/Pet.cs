using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class Pet
    {
        public int ID { get; set; }

        [Display(Name = "Image URL")]
        public string ImageURL { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        public string Animal { get; set; }

        [Display(Name = "Short Description")]
        [DataType(DataType.MultilineText)]
        [Required]
        public string ShortDescription { get; set; }

        [DataType(DataType.MultilineText)]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Date Received")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateReceived { get; set; }

        [Range(1, 100)]
        [Required]
        public int Quantity { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }
    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}