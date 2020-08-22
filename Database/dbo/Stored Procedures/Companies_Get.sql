
CREATE PROCEDURE [dbo].[Companies_Get]
	@ID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	--DECLARE @Sql NVarchar(MAX)
	--SET @Sql = 'SELECT * FROM ' + QUOTENAME(@ParmTableName) + ' WHERE ID = @ID'
	--DECLARE @ParmDefinition nvarchar(100) = N'@ID varchar(20)'
	--EXECUTE sp_executesql @Sql, @ParmDefinition, @ID = @ParmID

	SELECT * FROM Companies WHERE ID = @ID
END
