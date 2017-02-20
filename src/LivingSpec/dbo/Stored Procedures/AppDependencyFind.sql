-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDependencyFind] @AppDependencyGuid UNIQUEIDENTIFIER
, @AppGuid UNIQUEIDENTIFIER
, @DependsOnAppGuid UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@AppDependencyGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@DependsOnAppGuid UNIQUEIDENTIFIER
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[AppDependency]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

	IF (@AppDependencyGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppDependencyGuid] = @AppDependencyGuid)';

	IF (@AppGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppGuid] = @AppGuid)';

	IF (@DependsOnAppGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([DependsOnAppGuid] = @DependsOnAppGuid)';


	--execute the sql
	EXECUTE sp_executesql	@Query
							,@Parameters
							,@AppDependencyGuid
							,@AppGuid
							,@DependsOnAppGuid
END