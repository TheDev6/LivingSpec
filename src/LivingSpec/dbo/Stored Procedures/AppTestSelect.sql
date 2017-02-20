-- =============================================
-- Author:  HPCPC
-- Create date: 2/9/2017 11:21:50 AM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppTestSelect] @AppTestGuid UNIQUEIDENTIFIER

AS
BEGIN
	SET NOCOUNT ON

	SELECT
		*
	FROM [dbo].[AppTest]
	WHERE ([AppTestGuid] = @AppTestGuid)

END