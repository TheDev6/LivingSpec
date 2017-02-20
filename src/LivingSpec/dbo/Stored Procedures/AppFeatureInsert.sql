-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppFeatureInsert] @AppFeatureGuid UNIQUEIDENTIFIER
, @AppGuid UNIQUEIDENTIFIER
, @FeatureGuid UNIQUEIDENTIFIER

AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[AppFeature] ([AppFeatureGuid]
	, [AppGuid]
	, [FeatureGuid])
		VALUES (@AppFeatureGuid, @AppGuid, @FeatureGuid)
END