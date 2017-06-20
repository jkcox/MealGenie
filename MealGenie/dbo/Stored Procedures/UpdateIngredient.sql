CREATE PROCEDURE [dbo].[UpdateIngredient] 
	 @IngredientId int
	,@Quantity int
	,@MeasurementTypeId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- TODO: need logic to convert the measurement type

	UPDATE [dbo].[Ingredient]
		SET [Quantity] = @Quantity
	WHERE IngredientId = @IngredientId

END