-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppResourceLinkSearch] 

@LinkUrlStartsWith NVARCHAR(4000)
, @LinkUrlContains NVARCHAR(4000)

AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = ' 
		@LinkUrlStartsWith NVARCHAR(4000)
				,@LinkUrlContains NVARCHAR(4000)
				
	'

	DECLARE @Query NVARCHAR(MAX) = '
	SELECT *
	FROM [dbo].[AppResourceLink]
	WHERE 1 = 1
	'

	IF (@LinkUrlStartsWith IS NOT NULL)
		SET @Query = @Query + 'AND ([LinkUrl] LIKE (@LinkUrlStartsWith + ''%''))'

	IF (@LinkUrlContains IS NOT NULL)
		SET @Query = @Query + 'AND ([LinkUrl] LIKE (''%'' + @LinkUrlContains + ''%''))'


	--execute the sql
	EXECUTE sp_executesql	@Query
							,@Parameters
							,@LinkUrlStartsWith
							,@LinkUrlContains

END