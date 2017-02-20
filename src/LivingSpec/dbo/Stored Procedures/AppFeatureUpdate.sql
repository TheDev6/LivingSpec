-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppFeatureUpdate] @AppFeatureGuid UNIQUEIDENTIFIER
, @AppGuid UNIQUEIDENTIFIER
, @FeatureGuid UNIQUEIDENTIFIER


AS
BEGIN
	SET NOCOUNT ON

	UPDATE [dbo].[AppFeature]
	SET	[AppFeatureGuid] = @AppFeatureGuid
		,[AppGuid] = @AppGuid
		,[FeatureGuid] = @FeatureGuid
	WHERE [AppFeatureGuid] = @AppFeatureGuid

END