CREATE PROCEDURE [dbo].[AddIngredient]
	 @Name nvarchar(250)
	,@MeasurementTypeId int
	,@IngredientId int out
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Ingredient]
	([Name] ,[MeasurementTypeId] ,[Quantity] ,[Created]) VALUES
	(@Name, @MeasurementTypeId, 0, GETDATE())

	SET @IngredientId = @@IDENTITY

END