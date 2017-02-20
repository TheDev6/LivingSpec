-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppFind] @AppGuid UNIQUEIDENTIFIER
, @AppDomainGuid UNIQUEIDENTIFIER
, @Name NVARCHAR(50)
, @Description NVARCHAR(200)
, @IsThirdParty BIT
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@AppGuid UNIQUEIDENTIFIER
				,@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Description NVARCHAR(200)
				,@IsThirdParty BIT
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[App]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

	IF (@AppGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppGuid] = @AppGuid)';

	IF (@AppDomainGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppDomainGuid] = @AppDomainGuid)';

	IF (@Name IS NOT NULL)
		SET @Query = @Query + ' AND ([Name] = @Name)';

	IF (@Description IS NOT NULL)
		SET @Query = @Query + ' AND ([Description] = @Description)';

	IF (@IsThirdParty IS NOT NULL)
		SET @Query = @Query + ' AND ([IsThirdParty] = @IsThirdParty)';


	--execute the sql
	EXECUTE sp_executesql	@Query
							,@Parameters
							,@AppGuid
							,@AppDomainGuid
							,@Name
							,@Description
							,@IsThirdParty
END