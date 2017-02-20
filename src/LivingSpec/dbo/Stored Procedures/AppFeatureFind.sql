-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppFeatureFind] @AppFeatureGuid UNIQUEIDENTIFIER
, @AppGuid UNIQUEIDENTIFIER
, @FeatureGuid UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@AppFeatureGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@FeatureGuid UNIQUEIDENTIFIER
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[AppFeature]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

	IF (@AppFeatureGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppFeatureGuid] = @AppFeatureGuid)';

	IF (@AppGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppGuid] = @AppGuid)';

	IF (@FeatureGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([FeatureGuid] = @FeatureGuid)';


	--execute the sql
	EXECUTE sp_executesql	@Query
							,@Parameters
							,@AppFeatureGuid
							,@AppGuid
							,@FeatureGuid
END