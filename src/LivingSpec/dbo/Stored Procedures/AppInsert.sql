-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppInsert] @AppGuid UNIQUEIDENTIFIER
, @AppDomainGuid UNIQUEIDENTIFIER
, @Name NVARCHAR(50)
, @Description NVARCHAR(200)
, @IsThirdParty BIT

AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[App] ([AppGuid]
	, [AppDomainGuid]
	, [Name]
	, [Description]
	, [IsThirdParty])
		VALUES (@AppGuid, @AppDomainGuid, @Name, @Description, @IsThirdParty)
END