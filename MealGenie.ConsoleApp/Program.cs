using MealGenie.DB;
using System;

namespace MealGenie.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Get the data service
            IMealGenieService service = MealGenieService.GetService(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MealGenie;Integrated Security=True");

            // Step 2: Call a method to get data (GetMeasurementTypes in this case)
            var measurementTypes = service.GetMeasurementTypes();

            // Step 3: Check to see if there are errors
            if (string.IsNullOrEmpty(measurementTypes.Error) && measurementTypes.MeasurementTypeEntities != null)
            {
                foreach (var item in measurementTypes.MeasurementTypeEntities)
                {
                    // Log out the data returned
                    Console.WriteLine($"Id: {item.MeasurementTypeId}, Name: {item.Name}");
                }
            }
            else
            {
                // Log out the error, if any
                Console.WriteLine($"Error: {measurementTypes.Error}");
            }

            // keep the terminal open...
            Console.ReadLine();
        }
    }
}