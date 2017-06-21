CREATE TABLE [dbo].[MealIngredient](
	[MealIngredientId] [int] IDENTITY(1,1) NOT NULL,
	[MealId] [int] NOT NULL,
	[IngredientId] [int] NOT NULL,
 [Quantity] INT NOT NULL, 
    CONSTRAINT [PK_MealIngredient] PRIMARY KEY CLUSTERED 
(
	[MealIngredientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MealIngredient]  WITH CHECK ADD  CONSTRAINT [FK_MealIngredient_Ingredient] FOREIGN KEY([IngredientId])
REFERENCES [dbo].[Ingredient] ([IngredientId])
GO

ALTER TABLE [dbo].[MealIngredient] CHECK CONSTRAINT [FK_MealIngredient_Ingredient]
GO
ALTER TABLE [dbo].[MealIngredient]  WITH CHECK ADD  CONSTRAINT [FK_MealIngredient_Meal] FOREIGN KEY([MealId])
REFERENCES [dbo].[Meal] ([MealId])
GO

ALTER TABLE [dbo].[MealIngredient] CHECK CONSTRAINT [FK_MealIngredient_Meal]