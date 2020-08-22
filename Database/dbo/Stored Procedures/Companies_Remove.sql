

CREATE PROCEDURE [dbo].[Companies_Remove]
	-- Add the parameters for the stored procedure here
	@ID varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	--DECLARE @Sql NVarchar(MAX)
	--SET @Sql = N'DELETE FROM ' + QUOTENAME(@ParmTableName) + ' WHERE CompanyID = @CompanyID'
	--DECLARE @ParmDefinition nvarchar(500) = N'@CompanyId varchar(20)'
	--EXECUTE sp_executesql @Sql, @ParmDefinition, @CompanyId = @ParmCompanyId

	DELETE FROM Companies WHERE ID = @ID
END
