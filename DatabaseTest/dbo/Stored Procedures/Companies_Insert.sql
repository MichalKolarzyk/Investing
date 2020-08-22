

CREATE PROCEDURE [dbo].[Companies_Insert]
	-- Add the parameters for the stored procedure here
	@ID varchar(20),
	@FullName varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	IF Exists (Select ID From Companies WHERE ID=@ID)
	Begin
		Update Companies SET FullName = @FullName
	END
	ELSE
	BEGIN
		INSERT INTO Companies (ID, FullName) VALUES (@ID, @FullName)
	END
END
