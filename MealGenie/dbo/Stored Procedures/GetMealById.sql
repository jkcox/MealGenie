CREATE PROCEDURE [dbo].[GetMealById]
	@MealId int
AS
BEGIN
	SET NOCOUNT ON;
	
	-- TODO: need to flag ingredients that are missing

	SELECT [MealId]
		  ,[Name]
		  ,[Created]
	FROM [dbo].[Meal]
	WHERE [MealId] = @MealId

END