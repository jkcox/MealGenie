CREATE TABLE [dbo].[Ingredient](
	[IngredientId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[MeasurementTypeId] [int] NOT NULL,
	[Created] [datetime] NOT NULL,
 CONSTRAINT [PK_Ingredient] PRIMARY KEY CLUSTERED 
(
	[IngredientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ingredient]  WITH CHECK ADD  CONSTRAINT [FK_Ingredient_MeasurementType] FOREIGN KEY([MeasurementTypeId])
REFERENCES [dbo].[MeasurementType] ([MeasurementTypeId])
GO

ALTER TABLE [dbo].[Ingredient] CHECK CONSTRAINT [FK_Ingredient_MeasurementType]