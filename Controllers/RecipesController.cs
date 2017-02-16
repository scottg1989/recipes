using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class RecipesController : Controller
    {
        [HttpGet("recipes")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("recipes/{id}")]
        public IActionResult Recipe(Guid id)
        {
            var recipe = new Recipe {
                Name = "Neapolitan Pizza",
                ImageUrl = "https://keep.google.com/media/1d2B8NRkzKcv7-0BUAWxOim72vWiRF3k?accept=image/gif,image/jpeg,image/jpg,image/png,image/webp,audio/aac&sz=600",
                Ingredients = new string[] {
                    "500g strong flour",
                    "5g salt",
                    "10g fresh yeast",
                    "325ml lukewarm water",
                    "150g tinned chopped tomatoes or tomato passata",
                    "Salt & pepper",
                    "1 x tablespoons extra virgin olive oil & extra for drizzling",
                    "1 x tablespoon grated parmesan cheese",
                    "1 x ball mozzarella",
                    "A few fresh basil leaves"
                },
                Steps = new string[] {
                    "First make the dough. Dissolve the yeast in the lukewarm water. Combine flour and salt in a large bowl. Gradually add the yeast mixture, mixing well until you obtain a dough. Place dough on a lightly floured work surface and knead for about 10 minutes. Cover with a cloth or cling film and leave to rest in a warm place for at least 30 minutes until the dough has doubled in size.",
                    "Preheat the oven to 220 degrees centigrade.",
                    "Take the dough, knock it back, then divide into two pieces, cover each with a cloth and leave to rest in a warm place for a further 30 minutes. ",
                    "Meanwhile prepare the toppings. For the Margherita, place tomatoes or passata in a small bowl, season with salt & pepper and stir in 1 tablespoon of extra virgin olive oil. Roughly chop the mozzarella.",
                    "Sprinkle some flour onto a clean work surface and with your fingers spread each piece of dough into a roughly round shape with a border, make the dough as thin as you can but be careful not to tear it. Sprinkle some semolina or flour onto 2 large flat baking trays and place the pizza bases on them.",
                    "Drizzle a little extra virgin olive oil over each base. On one, spread the tomato mixture evenly over, sprinkle with parmesan, scatter a few basil leaves over and top with mozzarella.",
                    "On the other base, arrange mozzarella and parmesan all over, top with Parma ham.",
                    "Place both pizzas into the hot oven and bake for 8 – 10 minutes."
                }
            };
            
            return View(recipe);
        }
    }
}
