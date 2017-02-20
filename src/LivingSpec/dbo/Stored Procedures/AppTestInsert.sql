-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppTestInsert] @AppTestGuid UNIQUEIDENTIFIER
, @AppGuid UNIQUEIDENTIFIER
, @Date DATETIME
, @TargetEnvironment NVARCHAR(50)
, @TypeKey NVARCHAR(50)
, @JsonValue NVARCHAR(4000)

AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[AppTest] ([AppTestGuid]
	, [AppGuid]
	, [DATE]
	, [TargetEnvironment]
	, [TypeKey]
	, [JsonValue])
		VALUES (@AppTestGuid, @AppGuid, @Date, @TargetEnvironment, @TypeKey, @JsonValue)
END