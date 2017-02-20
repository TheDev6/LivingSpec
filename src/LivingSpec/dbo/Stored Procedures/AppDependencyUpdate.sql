-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDependencyUpdate] @AppDependencyGuid UNIQUEIDENTIFIER
, @AppGuid UNIQUEIDENTIFIER
, @DependsOnAppGuid UNIQUEIDENTIFIER


AS
BEGIN
	SET NOCOUNT ON

	UPDATE [dbo].[AppDependency]
	SET	[AppDependencyGuid] = @AppDependencyGuid
		,[AppGuid] = @AppGuid
		,[DependsOnAppGuid] = @DependsOnAppGuid
	WHERE [AppDependencyGuid] = @AppDependencyGuid

END