CREATE PROCEDURE [dbo].[UpdatePantryIngredient] 
	 @PantryIngredientId int
	,@Quantity int
	,@MeasurementTypeId int
AS
BEGIN
	SET NOCOUNT ON;

	-- TODO: need logic to convert the measurement type

	UPDATE [dbo].[PantryIngredient]
		SET [Quantity] = @Quantity
	WHERE [PantryIngredientId] = @PantryIngredientId

END