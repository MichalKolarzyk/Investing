﻿CREATE PROCEDURE [dbo].[Companies_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM Companies
END