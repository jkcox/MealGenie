using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MealGenieMVC.Models
{
    public class Ingredient
    {
        public Ingredient()
        {
            var list = new List<SelectListItem>();
        }

        public int IngredientId { get; set; }

        [StringLength(200, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }

        [Required]
        public int MeasurementTypeId { get; set; }

        public IList<SelectListItem> MeasurementTypes { get; set; }
        //select list item
        //[Required]
        //public DateTime Created { get; set; }
    }
}
