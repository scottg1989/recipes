using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string[] Ingredients { get; set; }
        public string[] Steps { get; set; }
    }
}
