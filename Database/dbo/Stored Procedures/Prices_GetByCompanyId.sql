
CREATE PROCEDURE [dbo].[Prices_GetByCompanyId]
	@CompanyId varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Prices WHERE CompanyID = @CompanyId ORDER BY Date DESC
END
