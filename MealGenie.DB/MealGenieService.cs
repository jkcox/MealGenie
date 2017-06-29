using MealGenie.DB.Responses;
using System;
using MealGenie.DB.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace MealGenie.DB
{
    public class MealGenieService : IMealGenieService
    {
        protected readonly string _connectionString;

        private MealGenieService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static IMealGenieService GetService(string connectionString)
        {
            return new MealGenieService(connectionString);
        }

        public AddIngredientResponse AddIngredient(string name, int measurementTypeId)
        {
            var result = new AddIngredientResponse();

            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    using (var sqlCommand = new SqlCommand("[dbo].[AddIngredient]", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@Name", name);
                        sqlCommand.Parameters.AddWithValue("@MeasurementTypeId", measurementTypeId);
                        sqlCommand.Parameters.AddWithValue("@IngredientId", 0);

                        sqlConnection.Open();

                        using (var sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.HasRows && sqlDataReader.Read())
                            {
                           
                                result.IngredientTypeEntitys.Add(new IngredientEntity
                                {
                                    IngredientId = Convert.ToInt32(sqlDataReader["IngredientId"]),
                                    Name = sqlDataReader["Name"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Error = ex.Message;
                result.IngredientTypeEntitys = new List<IngredientEntity>();
            }

            return result;
        }

        public GetMeasurementTypesResponse GetMeasurementTypes()
        {
            var result = new GetMeasurementTypesResponse();

            try
            {
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    using (var sqlCommand = new SqlCommand("[dbo].[GetMeasurementTypes]", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        //sqlCommand.Parameters.AddWithValue("@Id", id);
                        sqlConnection.Open();

                        using (var sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.HasRows && sqlDataReader.Read())
                            {
                                result.MeasurementTypeEntities.Add(new MeasurementTypeEntity
                                {
                                    MeasurementTypeId = Convert.ToInt32(sqlDataReader["MeasurementTypeId"]),
                                    Name = sqlDataReader["Name"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Error = ex.Message;
                result.MeasurementTypeEntities = new List<MeasurementTypeEntity>();
            }
            
            return result;
            
        }
    }
}
