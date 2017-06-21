using MealGenie.DB.Entities;
using System.Collections.Generic;

namespace MealGenie.DB.Responses
{
    public class GetMeasurementTypesResponse : DBResponseBase
    {
        public GetMeasurementTypesResponse() : base()
        {
            MeasurementTypeEntities = new List<MeasurementTypeEntity>();
        }

        public IList<MeasurementTypeEntity> MeasurementTypeEntities { get; set; }
    }
}
