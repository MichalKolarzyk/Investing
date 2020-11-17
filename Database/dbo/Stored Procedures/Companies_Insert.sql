

CREATE PROCEDURE [dbo].[Companies_Insert]
	@ID varchar(20),
	@FullName varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Companies (ID, FullName) VALUES(@ID, @FullName)
END
