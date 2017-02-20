-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppResourceLinkInsert] @AppResourceLinkGuid UNIQUEIDENTIFIER
, @AppGuid UNIQUEIDENTIFIER
, @LinkUrl NVARCHAR(4000)

AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[AppResourceLink] ([AppResourceLinkGuid]
	, [AppGuid]
	, [LinkUrl])
		VALUES (@AppResourceLinkGuid, @AppGuid, @LinkUrl)
END