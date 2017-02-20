-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppUpdate] @AppGuid UNIQUEIDENTIFIER
, @AppDomainGuid UNIQUEIDENTIFIER
, @Name NVARCHAR(50)
, @Description NVARCHAR(200)
, @IsThirdParty BIT


AS
BEGIN
	SET NOCOUNT ON

	UPDATE [dbo].[App]
	SET	[AppGuid] = @AppGuid
		,[AppDomainGuid] = @AppDomainGuid
		,[Name] = @Name
		,[Description] = @Description
		,[IsThirdParty] = @IsThirdParty
	WHERE [AppGuid] = @AppGuid

END