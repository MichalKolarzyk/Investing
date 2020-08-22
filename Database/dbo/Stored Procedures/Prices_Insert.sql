

CREATE PROCEDURE [dbo].[Prices_Insert]
	-- Add the parameters for the stored procedure here
	@CompanyID varchar(20),
	@Price real,
	@Date dateTimeOffset(7),
	@TimeScale int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO  dbo.Prices(CompanyID, Value, Date, TimeScale)
	VALUES(@CompanyID, @Price, @Date, @TimeScale);

END
