

CREATE PROCEDURE [dbo].[Companies_Insert]
	-- Add the parameters for the stored procedure here
	@ID varchar(20),
	@FullName varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	--DECLARE @Sql NVarchar(MAX)
	--SET @Sql = N'INSERT INTO   ' + QUOTENAME(@ParmTableName) + '(ID, FullName)' + 'VALUES(@ID, @FullName) ON DUPLICATE KEY UPDATE FullName = @FullName'
	--DECLARE @ParmDefinition nvarchar(500) = N'@ID varchar(20), @FullName varchar(50)'
	--EXECUTE sp_executesql @Sql, @ParmDefinition, @ID = @ParmID, @FullName = @ParmFullName

	INSERT INTO Companies (ID, FullName) VALUES(@ID, @FullName)
END
