CREATE PROCEDURE [dbo].[GetMeasurementTypes]
AS

	SELECT [MeasurementTypeId] ,[Name]
	FROM [dbo].[MeasurementType]

RETURN 0
