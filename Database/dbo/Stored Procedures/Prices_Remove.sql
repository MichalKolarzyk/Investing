

CREATE PROCEDURE [dbo].[Prices_Remove]
	-- Add the parameters for the stored procedure here
	@CompanyID varchar(20),
	@Date dateTimeOffset(7)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Prices WHERE CompanyID = @CompanyID AND Date = @Date

END
