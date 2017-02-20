-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppResourceLinkFind] @AppResourceLinkGuid UNIQUEIDENTIFIER
, @AppGuid UNIQUEIDENTIFIER
, @LinkUrl NVARCHAR(4000)
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@AppResourceLinkGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@LinkUrl NVARCHAR(4000)
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[AppResourceLink]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

	IF (@AppResourceLinkGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppResourceLinkGuid] = @AppResourceLinkGuid)';

	IF (@AppGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppGuid] = @AppGuid)';

	IF (@LinkUrl IS NOT NULL)
		SET @Query = @Query + ' AND ([LinkUrl] = @LinkUrl)';


	--execute the sql
	EXECUTE sp_executesql	@Query
							,@Parameters
							,@AppResourceLinkGuid
							,@AppGuid
							,@LinkUrl
END