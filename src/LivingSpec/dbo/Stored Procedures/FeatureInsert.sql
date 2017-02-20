-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[FeatureInsert] @FeatureGuid UNIQUEIDENTIFIER
, @Name NVARCHAR(200)
, @GherkinText NVARCHAR(MAX)

AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[Feature] ([FeatureGuid]
	, [Name]
	, [GherkinText])
		VALUES (@FeatureGuid, @Name, @GherkinText)
END