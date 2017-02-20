-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[DomainTermInsert] @DomainTermGuid UNIQUEIDENTIFIER
, @AppDomainGuid UNIQUEIDENTIFIER
, @Name NVARCHAR(50)
, @Definition NVARCHAR(200)

AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[DomainTerm] ([DomainTermGuid]
	, [AppDomainGuid]
	, [Name]
	, [Definition])
		VALUES (@DomainTermGuid, @AppDomainGuid, @Name, @Definition)
END