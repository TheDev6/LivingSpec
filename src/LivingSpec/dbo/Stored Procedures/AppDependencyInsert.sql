-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDependencyInsert] @AppDependencyGuid UNIQUEIDENTIFIER
, @AppGuid UNIQUEIDENTIFIER
, @DependsOnAppGuid UNIQUEIDENTIFIER

AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[AppDependency] ([AppDependencyGuid]
	, [AppGuid]
	, [DependsOnAppGuid])
		VALUES (@AppDependencyGuid, @AppGuid, @DependsOnAppGuid)
END