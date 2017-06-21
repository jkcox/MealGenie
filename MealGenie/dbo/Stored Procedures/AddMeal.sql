CREATE PROCEDURE [dbo].[AddMeal]
	 @Name nvarchar(250)
	,@MealId int out
AS
BEGIN
	SET NOCOUNT ON;

	-- TODO: add a list of ingredient ids and quantities (MealIngredient)

	INSERT INTO [dbo].[Meal]
	([Name] ,[Created]) VALUES
	(@Name, GETDATE())

	SET @MealId = @@IDENTITY

END