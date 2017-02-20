-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[FeatureUpdate] @FeatureGuid UNIQUEIDENTIFIER
, @Name NVARCHAR(200)
, @GherkinText NVARCHAR(MAX)


AS
BEGIN
	SET NOCOUNT ON

	UPDATE [dbo].[Feature]
	SET	[FeatureGuid] = @FeatureGuid
		,[Name] = @Name
		,[GherkinText] = @GherkinText
	WHERE [FeatureGuid] = @FeatureGuid

END