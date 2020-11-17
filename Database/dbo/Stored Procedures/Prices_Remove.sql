

CREATE PROCEDURE [dbo].[Prices_Remove]
	@CompanyID varchar(20),
	@Date dateTimeOffset(7)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Prices WHERE CompanyID = @CompanyID AND Date = @Date

END
