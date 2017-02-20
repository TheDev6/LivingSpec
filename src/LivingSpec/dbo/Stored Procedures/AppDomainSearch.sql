-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDomainSearch] @NameStartsWith NVARCHAR(50)
, @NameContains NVARCHAR(50)
, @DescriptionStartsWith NVARCHAR(200)
, @DescriptionContains NVARCHAR(200)

AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
		@NameStartsWith NVARCHAR(50)
				,@NameContains NVARCHAR(50)
				,@DescriptionStartsWith NVARCHAR(200)
				,@DescriptionContains NVARCHAR(200)
				
	'

	DECLARE @Query NVARCHAR(MAX) = '
	SELECT *
	FROM [dbo].[AppDomain]
	WHERE 1 = 1
	'

	IF (@NameStartsWith IS NOT NULL)
		SET @Query = @Query + 'AND ([Name] LIKE (@NameStartsWith + ''%''))'

	IF (@NameContains IS NOT NULL)
		SET @Query = @Query + 'AND ([Name] LIKE (''%'' + @NameContains + ''%''))'

	IF (@DescriptionStartsWith IS NOT NULL)
		SET @Query = @Query + 'AND ([Description] LIKE (@DescriptionStartsWith + ''%''))'

	IF (@DescriptionContains IS NOT NULL)
		SET @Query = @Query + 'AND ([Description] LIKE (''%'' + @DescriptionContains + ''%''))'


	--execute the sql
	EXECUTE sp_executesql	@Query
							,@Parameters
							,@NameStartsWith
							,@NameContains
							,@DescriptionStartsWith
							,@DescriptionContains

END