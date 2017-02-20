-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDomainUpdate] @AppDomainGuid UNIQUEIDENTIFIER
, @Name NVARCHAR(50)
, @Description NVARCHAR(200)


AS
BEGIN
	SET NOCOUNT ON

	UPDATE [dbo].[AppDomain]
	SET	[AppDomainGuid] = @AppDomainGuid
		,[Name] = @Name
		,[Description] = @Description
	WHERE [AppDomainGuid] = @AppDomainGuid

END