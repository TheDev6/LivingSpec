-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDependencySelect] @AppDependencyGuid UNIQUEIDENTIFIER

AS
BEGIN
	SET NOCOUNT ON

	SELECT
		*
	FROM [dbo].[AppDependency]
	WHERE ([AppDependencyGuid] = @AppDependencyGuid)

END