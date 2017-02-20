-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDependencySearch]

AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
		
	'

	DECLARE @Query NVARCHAR(MAX) = '
	SELECT *
	FROM [dbo].[AppDependency]
	WHERE 1 = 1
	'


	--execute the sql
	EXECUTE sp_executesql	@Query
							,@Parameters

END