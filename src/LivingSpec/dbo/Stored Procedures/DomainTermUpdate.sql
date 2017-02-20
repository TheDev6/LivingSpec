-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[DomainTermUpdate] @DomainTermGuid UNIQUEIDENTIFIER
, @AppDomainGuid UNIQUEIDENTIFIER
, @Name NVARCHAR(50)
, @Definition NVARCHAR(200)


AS
BEGIN
	SET NOCOUNT ON

	UPDATE [dbo].[DomainTerm]
	SET	[DomainTermGuid] = @DomainTermGuid
		,[AppDomainGuid] = @AppDomainGuid
		,[Name] = @Name
		,[Definition] = @Definition
	WHERE [DomainTermGuid] = @DomainTermGuid

END