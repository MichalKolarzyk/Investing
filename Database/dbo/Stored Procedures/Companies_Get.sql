
CREATE PROCEDURE [dbo].[Companies_Get]
	@ID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Companies WHERE ID = @ID
END
