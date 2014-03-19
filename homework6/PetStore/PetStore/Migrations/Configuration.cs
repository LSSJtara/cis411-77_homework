namespace PetStore.Migrations
{
    using PetStore.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PetStore.Models.PetDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PetStore.Models.PetDBContext context)
        {
            context.Pets.AddOrUpdate(i => i.Animal,
                new Pet
                {
                    ImageURL = "http://static2.businessinsider.com/image/4f3433986bb3f7b67a00003c/a-parasite-found-in-cats-could-be-manipulating-our-brains.jpg",
                    Animal = "Cat",
                    ShortDescription = "this is a cat",
                    Description = "this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat ",
                    DateReceieved = DateTime.Parse("2014-1-11"),
                    Quantity = 6,
                    Price = 7.99M
                },

                new Pet
                {
                    ImageURL = "http://www.petfinder.com/wp-content/uploads/2012/11/AA031824-best-dog-foster-care-632x475.jpg",
                    Animal = "Dog",
                    ShortDescription = "this is a dog",
                    Description = "this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat this is a cat ",
                    DateReceieved = DateTime.Parse("2014-3-15"),
                    Quantity = 8,
                    Price = 9.99M
                }
           );

        }
    }
}
