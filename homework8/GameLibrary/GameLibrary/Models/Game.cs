using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameLibrary.Models
{
    public class Game
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Image URL")]
        public string ImageURL { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string System { get; set; }
        
        public string Genre { get; set; }
        
        public int Year { get; set; }

        [Display(Name = "User Name")]
        public virtual string UserName { get; set; }

    }
    
    public class GameDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }

}