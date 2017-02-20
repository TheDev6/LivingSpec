-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[FeatureSearch] @NameStartsWith NVARCHAR(200)
, @NameContains NVARCHAR(200)
, @GherkinTextStartsWith NVARCHAR(MAX)
, @GherkinTextContains NVARCHAR(MAX)

AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
		@NameStartsWith NVARCHAR(200)
				,@NameContains NVARCHAR(200)
				,@GherkinTextStartsWith NVARCHAR(MAX)
				,@GherkinTextContains NVARCHAR(MAX)
				
	'

	DECLARE @Query NVARCHAR(MAX) = '
	SELECT *
	FROM [dbo].[Feature]
	WHERE 1 = 1
	'

	IF (@NameStartsWith IS NOT NULL)
		SET @Query = @Query + 'AND ([Name] LIKE (@NameStartsWith + ''%''))'

	IF (@NameContains IS NOT NULL)
		SET @Query = @Query + 'AND ([Name] LIKE (''%'' + @NameContains + ''%''))'

	IF (@GherkinTextStartsWith IS NOT NULL)
		SET @Query = @Query + 'AND ([GherkinText] LIKE (@GherkinTextStartsWith + ''%''))'

	IF (@GherkinTextContains IS NOT NULL)
		SET @Query = @Query + 'AND ([GherkinText] LIKE (''%'' + @GherkinTextContains + ''%''))'


	--execute the sql
	EXECUTE sp_executesql	@Query
							,@Parameters
							,@NameStartsWith
							,@NameContains
							,@GherkinTextStartsWith
							,@GherkinTextContains

END