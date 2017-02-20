-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppResourceLinkUpdate] @AppResourceLinkGuid UNIQUEIDENTIFIER
, @AppGuid UNIQUEIDENTIFIER
, @LinkUrl NVARCHAR(4000)


AS
BEGIN
	SET NOCOUNT ON

	UPDATE [dbo].[AppResourceLink]
	SET	[AppResourceLinkGuid] = @AppResourceLinkGuid
		,[AppGuid] = @AppGuid
		,[LinkUrl] = @LinkUrl
	WHERE [AppResourceLinkGuid] = @AppResourceLinkGuid

END