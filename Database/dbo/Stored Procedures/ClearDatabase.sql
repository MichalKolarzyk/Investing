CREATE PROCEDURE [dbo].[ClearDatabase]
AS
	Delete from dbo.Companies
	Delete from dbo.Algorithms
	Delete from dbo.Prices
	Delete from dbo.DecisionsOfAlgorithms
RETURN 0
