-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppTestSearch] @DateAfter DATETIME
, @DateBefore DATETIME
, @TargetEnvironmentStartsWith NVARCHAR(50)
, @TargetEnvironmentContains NVARCHAR(50)
, @TypeKeyStartsWith NVARCHAR(50)
, @TypeKeyContains NVARCHAR(50)
, @JsonValueStartsWith NVARCHAR(4000)
, @JsonValueContains NVARCHAR(4000)

AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
		@DateAfter DATETIME
				,@DateBefore DATETIME
				,@TargetEnvironmentStartsWith NVARCHAR(50)
				,@TargetEnvironmentContains NVARCHAR(50)
				,@TypeKeyStartsWith NVARCHAR(50)
				,@TypeKeyContains NVARCHAR(50)
				,@JsonValueStartsWith NVARCHAR(4000)
				,@JsonValueContains NVARCHAR(4000)
				
	'

	DECLARE @Query NVARCHAR(MAX) = '
	SELECT *
	FROM [dbo].[AppTest]
	WHERE 1 = 1
	'

	IF (@DateAfter IS NOT NULL)
		SET @Query = @Query + 'AND ([Date] >= @DateAfter)'

	IF (@DateBefore IS NOT NULL)
		SET @Query = @Query + 'AND ([Date] <= @DateBefore)'

	IF (@TargetEnvironmentStartsWith IS NOT NULL)
		SET @Query = @Query + 'AND ([TargetEnvironment] LIKE (@TargetEnvironmentStartsWith + ''%''))'

	IF (@TargetEnvironmentContains IS NOT NULL)
		SET @Query = @Query + 'AND ([TargetEnvironment] LIKE (''%'' + @TargetEnvironmentContains + ''%''))'

	IF (@TypeKeyStartsWith IS NOT NULL)
		SET @Query = @Query + 'AND ([TypeKey] LIKE (@TypeKeyStartsWith + ''%''))'

	IF (@TypeKeyContains IS NOT NULL)
		SET @Query = @Query + 'AND ([TypeKey] LIKE (''%'' + @TypeKeyContains + ''%''))'

	IF (@JsonValueStartsWith IS NOT NULL)
		SET @Query = @Query + 'AND ([JsonValue] LIKE (@JsonValueStartsWith + ''%''))'

	IF (@JsonValueContains IS NOT NULL)
		SET @Query = @Query + 'AND ([JsonValue] LIKE (''%'' + @JsonValueContains + ''%''))'


	--execute the sql
	EXECUTE sp_executesql	@Query
							,@Parameters
							,@DateAfter
							,@DateBefore
							,@TargetEnvironmentStartsWith
							,@TargetEnvironmentContains
							,@TypeKeyStartsWith
							,@TypeKeyContains
							,@JsonValueStartsWith
							,@JsonValueContains

END