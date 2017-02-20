-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppTestFind] @AppTestGuid UNIQUEIDENTIFIER
, @AppGuid UNIQUEIDENTIFIER
, @Date DATETIME
, @TargetEnvironment NVARCHAR(50)
, @TypeKey NVARCHAR(50)
, @JsonValue NVARCHAR(4000)
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@AppTestGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@Date DATETIME
				,@TargetEnvironment NVARCHAR(50)
				,@TypeKey NVARCHAR(50)
				,@JsonValue NVARCHAR(4000)
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[AppTest]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

	IF (@AppTestGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppTestGuid] = @AppTestGuid)';

	IF (@AppGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppGuid] = @AppGuid)';

	IF (@Date IS NOT NULL)
		SET @Query = @Query + ' AND ([Date] = @Date)';

	IF (@TargetEnvironment IS NOT NULL)
		SET @Query = @Query + ' AND ([TargetEnvironment] = @TargetEnvironment)';

	IF (@TypeKey IS NOT NULL)
		SET @Query = @Query + ' AND ([TypeKey] = @TypeKey)';

	IF (@JsonValue IS NOT NULL)
		SET @Query = @Query + ' AND ([JsonValue] = @JsonValue)';


	--execute the sql
	EXECUTE sp_executesql	@Query
							,@Parameters
							,@AppTestGuid
							,@AppGuid
							,@Date
							,@TargetEnvironment
							,@TypeKey
							,@JsonValue
END