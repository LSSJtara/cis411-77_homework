using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string ImageURL { get; set; }
        public string Animal { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime DateReceieved { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}