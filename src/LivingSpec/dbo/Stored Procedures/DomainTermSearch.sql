-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[DomainTermSearch] @NameStartsWith NVARCHAR(50)
, @NameContains NVARCHAR(50)
, @DefinitionStartsWith NVARCHAR(200)
, @DefinitionContains NVARCHAR(200)

AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
		@NameStartsWith NVARCHAR(50)
				,@NameContains NVARCHAR(50)
				,@DefinitionStartsWith NVARCHAR(200)
				,@DefinitionContains NVARCHAR(200)
				
	'

	DECLARE @Query NVARCHAR(MAX) = '
	SELECT *
	FROM [dbo].[DomainTerm]
	WHERE 1 = 1
	'

	IF (@NameStartsWith IS NOT NULL)
		SET @Query = @Query + 'AND ([Name] LIKE (@NameStartsWith + ''%''))'

	IF (@NameContains IS NOT NULL)
		SET @Query = @Query + 'AND ([Name] LIKE (''%'' + @NameContains + ''%''))'

	IF (@DefinitionStartsWith IS NOT NULL)
		SET @Query = @Query + 'AND ([Definition] LIKE (@DefinitionStartsWith + ''%''))'

	IF (@DefinitionContains IS NOT NULL)
		SET @Query = @Query + 'AND ([Definition] LIKE (''%'' + @DefinitionContains + ''%''))'


	--execute the sql
	EXECUTE sp_executesql	@Query
							,@Parameters
							,@NameStartsWith
							,@NameContains
							,@DefinitionStartsWith
							,@DefinitionContains

END