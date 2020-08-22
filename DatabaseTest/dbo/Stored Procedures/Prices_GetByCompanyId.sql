
CREATE PROCEDURE [dbo].[Prices_GetByCompanyId]
	-- Add the parameters for the stored procedure here
	@CompanyId varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT * FROM Prices WHERE CompanyID = @CompanyId
END
