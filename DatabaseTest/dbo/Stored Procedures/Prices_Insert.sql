CREATE PROCEDURE [dbo].[Prices_Insert]
	@CompanyID varchar(20),
	@Price real,
	@Date dateTimeOffset(7),
	@TimeScale int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO  dbo.Prices(CompanyID, Value, Date, TimeScale)
	VALUES(@CompanyID, @Price, @Date, @TimeScale);

END
