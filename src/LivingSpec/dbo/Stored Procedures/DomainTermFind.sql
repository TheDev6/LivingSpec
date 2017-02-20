-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[DomainTermFind] @DomainTermGuid UNIQUEIDENTIFIER
, @AppDomainGuid UNIQUEIDENTIFIER
, @Name NVARCHAR(50)
, @Definition NVARCHAR(200)
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@DomainTermGuid UNIQUEIDENTIFIER
				,@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Definition NVARCHAR(200)
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[DomainTerm]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

	IF (@DomainTermGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([DomainTermGuid] = @DomainTermGuid)';

	IF (@AppDomainGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppDomainGuid] = @AppDomainGuid)';

	IF (@Name IS NOT NULL)
		SET @Query = @Query + ' AND ([Name] = @Name)';

	IF (@Definition IS NOT NULL)
		SET @Query = @Query + ' AND ([Definition] = @Definition)';


	--execute the sql
	EXECUTE sp_executesql	@Query
							,@Parameters
							,@DomainTermGuid
							,@AppDomainGuid
							,@Name
							,@Definition
END