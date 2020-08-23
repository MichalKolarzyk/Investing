CREATE PROCEDURE [dbo].[Companies_Remove]
	@ID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM Companies WHERE ID = @ID
END
