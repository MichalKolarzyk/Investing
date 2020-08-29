
CREATE PROCEDURE [dbo].[Prices_GetByCompanyId]
	@ID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM Prices WHERE CompanyID = @ID
END
