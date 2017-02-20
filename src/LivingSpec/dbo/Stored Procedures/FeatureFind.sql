-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[FeatureFind] @FeatureGuid UNIQUEIDENTIFIER
, @Name NVARCHAR(200)
, @GherkinText NVARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@FeatureGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(200)
				,@GherkinText NVARCHAR(MAX)
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[Feature]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

	IF (@FeatureGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([FeatureGuid] = @FeatureGuid)';

	IF (@Name IS NOT NULL)
		SET @Query = @Query + ' AND ([Name] = @Name)';

	IF (@GherkinText IS NOT NULL)
		SET @Query = @Query + ' AND ([GherkinText] = @GherkinText)';


	--execute the sql
	EXECUTE sp_executesql	@Query
							,@Parameters
							,@FeatureGuid
							,@Name
							,@GherkinText
END