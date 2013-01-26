﻿using System.Collections.Generic;

namespace SocialRecipesMVC4.Domain
{
    public class User 
    {
        public User()
        {
            Groups = new HashSet<Group>();
            Recipes = new HashSet<Recipe>();
            Comments = new HashSet<Comment>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; } 
    }
}