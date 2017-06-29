using MealGenie.DB.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealGenie.DB.Responses
{
    public class AddIngredientResponse : DBResponseBase
    {
        public AddIngredientResponse() : base()
        {
            IngredientTypeEntitys = new List<IngredientEntity>();
        }

        public IList<IngredientEntity> IngredientTypeEntitys { get; set; }
    }
}
