using MealGenie.DB.Entities;
using MealGenie.DB.Responses;
using System.Collections.Generic;

namespace MealGenie.DB
{
    public interface IMealGenieService
    {
        AddIngredientResponse AddIngredient(string name, int measurementTypeId);
        GetMeasurementTypesResponse GetMeasurementTypes();
    }
}
