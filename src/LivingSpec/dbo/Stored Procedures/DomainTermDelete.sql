-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[DomainTermDelete] @DomainTermGuid UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON
	DELETE FROM [dbo].[DomainTerm]
	WHERE [DomainTermGuid] = @DomainTermGuid

END