CREATE PROCEDURE [dbo].[AddIngredient]
	 @Name nvarchar(250)
	,@MeasurementTypeId int
	,@IngredientId int out
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Ingredient]
	([Name] ,[MeasurementTypeId] ,[Created]) VALUES
	(@Name, @MeasurementTypeId, GETDATE())

	-- TODO: this should add a pantry ingredient with a quantity of zero...

	SET @IngredientId = @@IDENTITY

END