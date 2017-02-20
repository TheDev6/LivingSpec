





----------------------|||*****Begin Feature Select*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[FeatureSelect]') IS NOT NULL
BEGIN
	PRINT 'Deleting [dbo].[FeatureSelect]'
    DROP PROC [dbo].[FeatureSelect]
END    
GO
PRINT 'Creating [dbo].[FeatureSelect]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[FeatureSelect]

@FeatureGuid UNIQUEIDENTIFIER

AS
BEGIN
SET NOCOUNT ON

SELECT *
FROM [dbo].[Feature]
WHERE ([FeatureGuid] = @FeatureGuid)
	
END
GO
----------------------|||*****End Feature Select*****|||----------------------



----------------------|||*****Begin Feature Find*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[FeatureFind]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[FeatureFind]'
	DROP PROC [dbo].[FeatureFind] 
END
GO
PRINT 'Creating [dbo].[FeatureFind]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[FeatureFind]
@FeatureGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(200)
				,@GherkinText NVARCHAR(MAX)
				AS
BEGIN
SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@FeatureGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(200)
				,@GherkinText NVARCHAR(MAX)
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[Feature]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

		IF(@FeatureGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([FeatureGuid] = @FeatureGuid)';

	IF(@Name IS NOT NULL)
		SET @Query = @Query + ' AND ([Name] = @Name)';

	IF(@GherkinText IS NOT NULL)
		SET @Query = @Query + ' AND ([GherkinText] = @GherkinText)';

	    
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@FeatureGuid
   		,@Name
   		,@GherkinText
   END
GO
----------------------|||*****END Feature Find*****|||----------------------







----------------------|||*****BEGIN Feature Search*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[FeatureSearch]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[FeatureSearch]'
	DROP PROC [dbo].[FeatureSearch] 
END
GO
PRINT 'Deleting [dbo].[FeatureSearch]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[FeatureSearch]
	@NameStartsWith NVARCHAR(200)
				,@NameContains NVARCHAR(200)
				,@GherkinTextStartsWith NVARCHAR(MAX)
				,@GherkinTextContains NVARCHAR(MAX)
				
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
		@NameStartsWith NVARCHAR(200)
				,@NameContains NVARCHAR(200)
				,@GherkinTextStartsWith NVARCHAR(MAX)
				,@GherkinTextContains NVARCHAR(MAX)
				
	'

	Declare @Query nvarchar(MAX) = '
	SELECT *
	FROM [dbo].[Feature]
	WHERE 1 = 1
	'

					if(@NameStartsWith IS NOT NULL)
				SET @Query = @Query + 'AND ([Name] LIKE (@NameStartsWith + ''%''))'

					if(@NameContains IS NOT NULL)
				SET @Query = @Query + 'AND ([Name] LIKE (''%'' + @NameContains + ''%''))'

					if(@GherkinTextStartsWith IS NOT NULL)
				SET @Query = @Query + 'AND ([GherkinText] LIKE (@GherkinTextStartsWith + ''%''))'

					if(@GherkinTextContains IS NOT NULL)
				SET @Query = @Query + 'AND ([GherkinText] LIKE (''%'' + @GherkinTextContains + ''%''))'

		
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@NameStartsWith  
    		,@NameContains  
    		,@GherkinTextStartsWith  
    		,@GherkinTextContains  
    
END
GO
----------------------|||*****END Feature Search*****|||----------------------



----------------------|||*****BEGIN Feature Update*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[FeatureUpdate]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[FeatureUpdate]'
	DROP PROC [dbo].[FeatureUpdate] 
END
GO
PRINT 'Creating [dbo].[FeatureUpdate]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[FeatureUpdate]

@FeatureGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(200)
				,@GherkinText NVARCHAR(MAX)
				

AS
BEGIN
SET NOCOUNT ON

UPDATE [dbo].[Feature]
SET
  [FeatureGuid] = @FeatureGuid  
  ,[Name] = @Name  
  ,[GherkinText] = @GherkinText  
WHERE [FeatureGuid] = @FeatureGuid

END
GO
----------------------|||*****END Feature Update*****|||----------------------



----------------------|||*****BEGIN Feature Insert*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[FeatureInsert]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[FeatureInsert]'
	DROP PROC [dbo].[FeatureInsert] 
END
GO
PRINT 'Creating [dbo].[FeatureInsert]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[FeatureInsert]
@FeatureGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(200)
				,@GherkinText NVARCHAR(MAX)
				
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [dbo].[Feature]
(
[FeatureGuid]
,[Name]
,[GherkinText]
)
VALUES
(
@FeatureGuid
,@Name
,@GherkinText
)
END
GO
----------------------|||*****END Feature Insert*****|||----------------------


----------------------|||*****BEGIN Feature Delete*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[FeatureDelete]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[FeatureDelete]'
	DROP PROC [dbo].[FeatureDelete] 
END
GO
PRINT 'Creating [dbo].[FeatureDelete]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[FeatureDelete]
 @FeatureGuid UNIQUEIDENTIFIER
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[Feature]
WHERE [FeatureGuid] = @FeatureGuid

END
GO
----------------------|||*****END Feature Delete*****|||----------------------





----------------------|||*****Begin AppFeature Select*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppFeatureSelect]') IS NOT NULL
BEGIN
	PRINT 'Deleting [dbo].[AppFeatureSelect]'
    DROP PROC [dbo].[AppFeatureSelect]
END    
GO
PRINT 'Creating [dbo].[AppFeatureSelect]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppFeatureSelect]

@AppFeatureGuid UNIQUEIDENTIFIER

AS
BEGIN
SET NOCOUNT ON

SELECT *
FROM [dbo].[AppFeature]
WHERE ([AppFeatureGuid] = @AppFeatureGuid)
	
END
GO
----------------------|||*****End AppFeature Select*****|||----------------------



----------------------|||*****Begin AppFeature Find*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[AppFeatureFind]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppFeatureFind]'
	DROP PROC [dbo].[AppFeatureFind] 
END
GO
PRINT 'Creating [dbo].[AppFeatureFind]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppFeatureFind]
@AppFeatureGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@FeatureGuid UNIQUEIDENTIFIER
				AS
BEGIN
SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@AppFeatureGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@FeatureGuid UNIQUEIDENTIFIER
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[AppFeature]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

		IF(@AppFeatureGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppFeatureGuid] = @AppFeatureGuid)';

	IF(@AppGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppGuid] = @AppGuid)';

	IF(@FeatureGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([FeatureGuid] = @FeatureGuid)';

	    
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@AppFeatureGuid
   		,@AppGuid
   		,@FeatureGuid
   END
GO
----------------------|||*****END AppFeature Find*****|||----------------------







----------------------|||*****BEGIN AppFeature Search*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[AppFeatureSearch]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppFeatureSearch]'
	DROP PROC [dbo].[AppFeatureSearch] 
END
GO
PRINT 'Deleting [dbo].[AppFeatureSearch]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppFeatureSearch]
	
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
		
	'

	Declare @Query nvarchar(MAX) = '
	SELECT *
	FROM [dbo].[AppFeature]
	WHERE 1 = 1
	'

		
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
	
END
GO
----------------------|||*****END AppFeature Search*****|||----------------------



----------------------|||*****BEGIN AppFeature Update*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppFeatureUpdate]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppFeatureUpdate]'
	DROP PROC [dbo].[AppFeatureUpdate] 
END
GO
PRINT 'Creating [dbo].[AppFeatureUpdate]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppFeatureUpdate]

@AppFeatureGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@FeatureGuid UNIQUEIDENTIFIER
				

AS
BEGIN
SET NOCOUNT ON

UPDATE [dbo].[AppFeature]
SET
  [AppFeatureGuid] = @AppFeatureGuid  
  ,[AppGuid] = @AppGuid  
  ,[FeatureGuid] = @FeatureGuid  
WHERE [AppFeatureGuid] = @AppFeatureGuid

END
GO
----------------------|||*****END AppFeature Update*****|||----------------------



----------------------|||*****BEGIN AppFeature Insert*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppFeatureInsert]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppFeatureInsert]'
	DROP PROC [dbo].[AppFeatureInsert] 
END
GO
PRINT 'Creating [dbo].[AppFeatureInsert]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppFeatureInsert]
@AppFeatureGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@FeatureGuid UNIQUEIDENTIFIER
				
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [dbo].[AppFeature]
(
[AppFeatureGuid]
,[AppGuid]
,[FeatureGuid]
)
VALUES
(
@AppFeatureGuid
,@AppGuid
,@FeatureGuid
)
END
GO
----------------------|||*****END AppFeature Insert*****|||----------------------


----------------------|||*****BEGIN AppFeature Delete*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppFeatureDelete]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppFeatureDelete]'
	DROP PROC [dbo].[AppFeatureDelete] 
END
GO
PRINT 'Creating [dbo].[AppFeatureDelete]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppFeatureDelete]
 @AppFeatureGuid UNIQUEIDENTIFIER
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[AppFeature]
WHERE [AppFeatureGuid] = @AppFeatureGuid

END
GO
----------------------|||*****END AppFeature Delete*****|||----------------------





----------------------|||*****Begin AppResourceLink Select*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppResourceLinkSelect]') IS NOT NULL
BEGIN
	PRINT 'Deleting [dbo].[AppResourceLinkSelect]'
    DROP PROC [dbo].[AppResourceLinkSelect]
END    
GO
PRINT 'Creating [dbo].[AppResourceLinkSelect]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppResourceLinkSelect]

@AppResourceLinkGuid UNIQUEIDENTIFIER

AS
BEGIN
SET NOCOUNT ON

SELECT *
FROM [dbo].[AppResourceLink]
WHERE ([AppResourceLinkGuid] = @AppResourceLinkGuid)
	
END
GO
----------------------|||*****End AppResourceLink Select*****|||----------------------



----------------------|||*****Begin AppResourceLink Find*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[AppResourceLinkFind]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppResourceLinkFind]'
	DROP PROC [dbo].[AppResourceLinkFind] 
END
GO
PRINT 'Creating [dbo].[AppResourceLinkFind]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppResourceLinkFind]
@AppResourceLinkGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@LinkUrl NVARCHAR(4000)
				AS
BEGIN
SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@AppResourceLinkGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@LinkUrl NVARCHAR(4000)
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[AppResourceLink]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

		IF(@AppResourceLinkGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppResourceLinkGuid] = @AppResourceLinkGuid)';

	IF(@AppGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppGuid] = @AppGuid)';

	IF(@LinkUrl IS NOT NULL)
		SET @Query = @Query + ' AND ([LinkUrl] = @LinkUrl)';

	    
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@AppResourceLinkGuid
   		,@AppGuid
   		,@LinkUrl
   END
GO
----------------------|||*****END AppResourceLink Find*****|||----------------------







----------------------|||*****BEGIN AppResourceLink Search*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[AppResourceLinkSearch]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppResourceLinkSearch]'
	DROP PROC [dbo].[AppResourceLinkSearch] 
END
GO
PRINT 'Deleting [dbo].[AppResourceLinkSearch]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppResourceLinkSearch]
	@LinkUrlStartsWith NVARCHAR(4000)
				,@LinkUrlContains NVARCHAR(4000)
				
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
		@LinkUrlStartsWith NVARCHAR(4000)
				,@LinkUrlContains NVARCHAR(4000)
				
	'

	Declare @Query nvarchar(MAX) = '
	SELECT *
	FROM [dbo].[AppResourceLink]
	WHERE 1 = 1
	'

					if(@LinkUrlStartsWith IS NOT NULL)
				SET @Query = @Query + 'AND ([LinkUrl] LIKE (@LinkUrlStartsWith + ''%''))'

					if(@LinkUrlContains IS NOT NULL)
				SET @Query = @Query + 'AND ([LinkUrl] LIKE (''%'' + @LinkUrlContains + ''%''))'

		
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@LinkUrlStartsWith  
    		,@LinkUrlContains  
    
END
GO
----------------------|||*****END AppResourceLink Search*****|||----------------------



----------------------|||*****BEGIN AppResourceLink Update*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppResourceLinkUpdate]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppResourceLinkUpdate]'
	DROP PROC [dbo].[AppResourceLinkUpdate] 
END
GO
PRINT 'Creating [dbo].[AppResourceLinkUpdate]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppResourceLinkUpdate]

@AppResourceLinkGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@LinkUrl NVARCHAR(4000)
				

AS
BEGIN
SET NOCOUNT ON

UPDATE [dbo].[AppResourceLink]
SET
  [AppResourceLinkGuid] = @AppResourceLinkGuid  
  ,[AppGuid] = @AppGuid  
  ,[LinkUrl] = @LinkUrl  
WHERE [AppResourceLinkGuid] = @AppResourceLinkGuid

END
GO
----------------------|||*****END AppResourceLink Update*****|||----------------------



----------------------|||*****BEGIN AppResourceLink Insert*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppResourceLinkInsert]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppResourceLinkInsert]'
	DROP PROC [dbo].[AppResourceLinkInsert] 
END
GO
PRINT 'Creating [dbo].[AppResourceLinkInsert]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppResourceLinkInsert]
@AppResourceLinkGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@LinkUrl NVARCHAR(4000)
				
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [dbo].[AppResourceLink]
(
[AppResourceLinkGuid]
,[AppGuid]
,[LinkUrl]
)
VALUES
(
@AppResourceLinkGuid
,@AppGuid
,@LinkUrl
)
END
GO
----------------------|||*****END AppResourceLink Insert*****|||----------------------


----------------------|||*****BEGIN AppResourceLink Delete*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppResourceLinkDelete]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppResourceLinkDelete]'
	DROP PROC [dbo].[AppResourceLinkDelete] 
END
GO
PRINT 'Creating [dbo].[AppResourceLinkDelete]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppResourceLinkDelete]
 @AppResourceLinkGuid UNIQUEIDENTIFIER
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[AppResourceLink]
WHERE [AppResourceLinkGuid] = @AppResourceLinkGuid

END
GO
----------------------|||*****END AppResourceLink Delete*****|||----------------------





----------------------|||*****Begin AppDependency Select*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppDependencySelect]') IS NOT NULL
BEGIN
	PRINT 'Deleting [dbo].[AppDependencySelect]'
    DROP PROC [dbo].[AppDependencySelect]
END    
GO
PRINT 'Creating [dbo].[AppDependencySelect]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDependencySelect]

@AppDependencyGuid UNIQUEIDENTIFIER

AS
BEGIN
SET NOCOUNT ON

SELECT *
FROM [dbo].[AppDependency]
WHERE ([AppDependencyGuid] = @AppDependencyGuid)
	
END
GO
----------------------|||*****End AppDependency Select*****|||----------------------



----------------------|||*****Begin AppDependency Find*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[AppDependencyFind]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppDependencyFind]'
	DROP PROC [dbo].[AppDependencyFind] 
END
GO
PRINT 'Creating [dbo].[AppDependencyFind]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDependencyFind]
@AppDependencyGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@DependsOnAppGuid UNIQUEIDENTIFIER
				AS
BEGIN
SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@AppDependencyGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@DependsOnAppGuid UNIQUEIDENTIFIER
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[AppDependency]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

		IF(@AppDependencyGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppDependencyGuid] = @AppDependencyGuid)';

	IF(@AppGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppGuid] = @AppGuid)';

	IF(@DependsOnAppGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([DependsOnAppGuid] = @DependsOnAppGuid)';

	    
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@AppDependencyGuid
   		,@AppGuid
   		,@DependsOnAppGuid
   END
GO
----------------------|||*****END AppDependency Find*****|||----------------------







----------------------|||*****BEGIN AppDependency Search*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[AppDependencySearch]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppDependencySearch]'
	DROP PROC [dbo].[AppDependencySearch] 
END
GO
PRINT 'Deleting [dbo].[AppDependencySearch]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDependencySearch]
	
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
		
	'

	Declare @Query nvarchar(MAX) = '
	SELECT *
	FROM [dbo].[AppDependency]
	WHERE 1 = 1
	'

		
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
	
END
GO
----------------------|||*****END AppDependency Search*****|||----------------------



----------------------|||*****BEGIN AppDependency Update*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppDependencyUpdate]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppDependencyUpdate]'
	DROP PROC [dbo].[AppDependencyUpdate] 
END
GO
PRINT 'Creating [dbo].[AppDependencyUpdate]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDependencyUpdate]

@AppDependencyGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@DependsOnAppGuid UNIQUEIDENTIFIER
				

AS
BEGIN
SET NOCOUNT ON

UPDATE [dbo].[AppDependency]
SET
  [AppDependencyGuid] = @AppDependencyGuid  
  ,[AppGuid] = @AppGuid  
  ,[DependsOnAppGuid] = @DependsOnAppGuid  
WHERE [AppDependencyGuid] = @AppDependencyGuid

END
GO
----------------------|||*****END AppDependency Update*****|||----------------------



----------------------|||*****BEGIN AppDependency Insert*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppDependencyInsert]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppDependencyInsert]'
	DROP PROC [dbo].[AppDependencyInsert] 
END
GO
PRINT 'Creating [dbo].[AppDependencyInsert]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDependencyInsert]
@AppDependencyGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@DependsOnAppGuid UNIQUEIDENTIFIER
				
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [dbo].[AppDependency]
(
[AppDependencyGuid]
,[AppGuid]
,[DependsOnAppGuid]
)
VALUES
(
@AppDependencyGuid
,@AppGuid
,@DependsOnAppGuid
)
END
GO
----------------------|||*****END AppDependency Insert*****|||----------------------


----------------------|||*****BEGIN AppDependency Delete*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppDependencyDelete]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppDependencyDelete]'
	DROP PROC [dbo].[AppDependencyDelete] 
END
GO
PRINT 'Creating [dbo].[AppDependencyDelete]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDependencyDelete]
 @AppDependencyGuid UNIQUEIDENTIFIER
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[AppDependency]
WHERE [AppDependencyGuid] = @AppDependencyGuid

END
GO
----------------------|||*****END AppDependency Delete*****|||----------------------





----------------------|||*****Begin AppTest Select*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppTestSelect]') IS NOT NULL
BEGIN
	PRINT 'Deleting [dbo].[AppTestSelect]'
    DROP PROC [dbo].[AppTestSelect]
END    
GO
PRINT 'Creating [dbo].[AppTestSelect]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppTestSelect]

@AppTestGuid UNIQUEIDENTIFIER

AS
BEGIN
SET NOCOUNT ON

SELECT *
FROM [dbo].[AppTest]
WHERE ([AppTestGuid] = @AppTestGuid)
	
END
GO
----------------------|||*****End AppTest Select*****|||----------------------



----------------------|||*****Begin AppTest Find*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[AppTestFind]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppTestFind]'
	DROP PROC [dbo].[AppTestFind] 
END
GO
PRINT 'Creating [dbo].[AppTestFind]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppTestFind]
@AppTestGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@Date DATETIME
				,@TargetEnvironment NVARCHAR(50)
				,@TypeKey NVARCHAR(50)
				,@JsonValue NVARCHAR(4000)
				AS
BEGIN
SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@AppTestGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@Date DATETIME
				,@TargetEnvironment NVARCHAR(50)
				,@TypeKey NVARCHAR(50)
				,@JsonValue NVARCHAR(4000)
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[AppTest]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

		IF(@AppTestGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppTestGuid] = @AppTestGuid)';

	IF(@AppGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppGuid] = @AppGuid)';

	IF(@Date IS NOT NULL)
		SET @Query = @Query + ' AND ([Date] = @Date)';

	IF(@TargetEnvironment IS NOT NULL)
		SET @Query = @Query + ' AND ([TargetEnvironment] = @TargetEnvironment)';

	IF(@TypeKey IS NOT NULL)
		SET @Query = @Query + ' AND ([TypeKey] = @TypeKey)';

	IF(@JsonValue IS NOT NULL)
		SET @Query = @Query + ' AND ([JsonValue] = @JsonValue)';

	    
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@AppTestGuid
   		,@AppGuid
   		,@Date
   		,@TargetEnvironment
   		,@TypeKey
   		,@JsonValue
   END
GO
----------------------|||*****END AppTest Find*****|||----------------------







----------------------|||*****BEGIN AppTest Search*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[AppTestSearch]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppTestSearch]'
	DROP PROC [dbo].[AppTestSearch] 
END
GO
PRINT 'Deleting [dbo].[AppTestSearch]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppTestSearch]
	@DateAfter DATETIME
				,@DateBefore DATETIME
				,@TargetEnvironmentStartsWith NVARCHAR(50)
				,@TargetEnvironmentContains NVARCHAR(50)
				,@TypeKeyStartsWith NVARCHAR(50)
				,@TypeKeyContains NVARCHAR(50)
				,@JsonValueStartsWith NVARCHAR(4000)
				,@JsonValueContains NVARCHAR(4000)
				
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
		@DateAfter DATETIME
				,@DateBefore DATETIME
				,@TargetEnvironmentStartsWith NVARCHAR(50)
				,@TargetEnvironmentContains NVARCHAR(50)
				,@TypeKeyStartsWith NVARCHAR(50)
				,@TypeKeyContains NVARCHAR(50)
				,@JsonValueStartsWith NVARCHAR(4000)
				,@JsonValueContains NVARCHAR(4000)
				
	'

	Declare @Query nvarchar(MAX) = '
	SELECT *
	FROM [dbo].[AppTest]
	WHERE 1 = 1
	'

					if(@DateAfter IS NOT NULL)
				SET @Query = @Query + 'AND ([Date] >= @DateAfter)'

					if(@DateBefore IS NOT NULL)
				SET @Query = @Query + 'AND ([Date] <= @DateBefore)'

					if(@TargetEnvironmentStartsWith IS NOT NULL)
				SET @Query = @Query + 'AND ([TargetEnvironment] LIKE (@TargetEnvironmentStartsWith + ''%''))'

					if(@TargetEnvironmentContains IS NOT NULL)
				SET @Query = @Query + 'AND ([TargetEnvironment] LIKE (''%'' + @TargetEnvironmentContains + ''%''))'

					if(@TypeKeyStartsWith IS NOT NULL)
				SET @Query = @Query + 'AND ([TypeKey] LIKE (@TypeKeyStartsWith + ''%''))'

					if(@TypeKeyContains IS NOT NULL)
				SET @Query = @Query + 'AND ([TypeKey] LIKE (''%'' + @TypeKeyContains + ''%''))'

					if(@JsonValueStartsWith IS NOT NULL)
				SET @Query = @Query + 'AND ([JsonValue] LIKE (@JsonValueStartsWith + ''%''))'

					if(@JsonValueContains IS NOT NULL)
				SET @Query = @Query + 'AND ([JsonValue] LIKE (''%'' + @JsonValueContains + ''%''))'

		
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@DateAfter  
    		,@DateBefore  
    		,@TargetEnvironmentStartsWith  
    		,@TargetEnvironmentContains  
    		,@TypeKeyStartsWith  
    		,@TypeKeyContains  
    		,@JsonValueStartsWith  
    		,@JsonValueContains  
    
END
GO
----------------------|||*****END AppTest Search*****|||----------------------



----------------------|||*****BEGIN AppTest Update*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppTestUpdate]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppTestUpdate]'
	DROP PROC [dbo].[AppTestUpdate] 
END
GO
PRINT 'Creating [dbo].[AppTestUpdate]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppTestUpdate]

@AppTestGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@Date DATETIME
				,@TargetEnvironment NVARCHAR(50)
				,@TypeKey NVARCHAR(50)
				,@JsonValue NVARCHAR(4000)
				

AS
BEGIN
SET NOCOUNT ON

UPDATE [dbo].[AppTest]
SET
  [AppTestGuid] = @AppTestGuid  
  ,[AppGuid] = @AppGuid  
  ,[Date] = @Date  
  ,[TargetEnvironment] = @TargetEnvironment  
  ,[TypeKey] = @TypeKey  
  ,[JsonValue] = @JsonValue  
WHERE [AppTestGuid] = @AppTestGuid

END
GO
----------------------|||*****END AppTest Update*****|||----------------------



----------------------|||*****BEGIN AppTest Insert*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppTestInsert]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppTestInsert]'
	DROP PROC [dbo].[AppTestInsert] 
END
GO
PRINT 'Creating [dbo].[AppTestInsert]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppTestInsert]
@AppTestGuid UNIQUEIDENTIFIER
				,@AppGuid UNIQUEIDENTIFIER
				,@Date DATETIME
				,@TargetEnvironment NVARCHAR(50)
				,@TypeKey NVARCHAR(50)
				,@JsonValue NVARCHAR(4000)
				
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [dbo].[AppTest]
(
[AppTestGuid]
,[AppGuid]
,[Date]
,[TargetEnvironment]
,[TypeKey]
,[JsonValue]
)
VALUES
(
@AppTestGuid
,@AppGuid
,@Date
,@TargetEnvironment
,@TypeKey
,@JsonValue
)
END
GO
----------------------|||*****END AppTest Insert*****|||----------------------


----------------------|||*****BEGIN AppTest Delete*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppTestDelete]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppTestDelete]'
	DROP PROC [dbo].[AppTestDelete] 
END
GO
PRINT 'Creating [dbo].[AppTestDelete]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppTestDelete]
 @AppTestGuid UNIQUEIDENTIFIER
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[AppTest]
WHERE [AppTestGuid] = @AppTestGuid

END
GO
----------------------|||*****END AppTest Delete*****|||----------------------





----------------------|||*****Begin AppDomain Select*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppDomainSelect]') IS NOT NULL
BEGIN
	PRINT 'Deleting [dbo].[AppDomainSelect]'
    DROP PROC [dbo].[AppDomainSelect]
END    
GO
PRINT 'Creating [dbo].[AppDomainSelect]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDomainSelect]

@AppDomainGuid UNIQUEIDENTIFIER

AS
BEGIN
SET NOCOUNT ON

SELECT *
FROM [dbo].[AppDomain]
WHERE ([AppDomainGuid] = @AppDomainGuid)
	
END
GO
----------------------|||*****End AppDomain Select*****|||----------------------



----------------------|||*****Begin AppDomain Find*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[AppDomainFind]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppDomainFind]'
	DROP PROC [dbo].[AppDomainFind] 
END
GO
PRINT 'Creating [dbo].[AppDomainFind]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDomainFind]
@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Description NVARCHAR(200)
				AS
BEGIN
SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Description NVARCHAR(200)
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[AppDomain]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

		IF(@AppDomainGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppDomainGuid] = @AppDomainGuid)';

	IF(@Name IS NOT NULL)
		SET @Query = @Query + ' AND ([Name] = @Name)';

	IF(@Description IS NOT NULL)
		SET @Query = @Query + ' AND ([Description] = @Description)';

	    
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@AppDomainGuid
   		,@Name
   		,@Description
   END
GO
----------------------|||*****END AppDomain Find*****|||----------------------







----------------------|||*****BEGIN AppDomain Search*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[AppDomainSearch]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppDomainSearch]'
	DROP PROC [dbo].[AppDomainSearch] 
END
GO
PRINT 'Deleting [dbo].[AppDomainSearch]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDomainSearch]
	@NameStartsWith NVARCHAR(50)
				,@NameContains NVARCHAR(50)
				,@DescriptionStartsWith NVARCHAR(200)
				,@DescriptionContains NVARCHAR(200)
				
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
		@NameStartsWith NVARCHAR(50)
				,@NameContains NVARCHAR(50)
				,@DescriptionStartsWith NVARCHAR(200)
				,@DescriptionContains NVARCHAR(200)
				
	'

	Declare @Query nvarchar(MAX) = '
	SELECT *
	FROM [dbo].[AppDomain]
	WHERE 1 = 1
	'

					if(@NameStartsWith IS NOT NULL)
				SET @Query = @Query + 'AND ([Name] LIKE (@NameStartsWith + ''%''))'

					if(@NameContains IS NOT NULL)
				SET @Query = @Query + 'AND ([Name] LIKE (''%'' + @NameContains + ''%''))'

					if(@DescriptionStartsWith IS NOT NULL)
				SET @Query = @Query + 'AND ([Description] LIKE (@DescriptionStartsWith + ''%''))'

					if(@DescriptionContains IS NOT NULL)
				SET @Query = @Query + 'AND ([Description] LIKE (''%'' + @DescriptionContains + ''%''))'

		
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@NameStartsWith  
    		,@NameContains  
    		,@DescriptionStartsWith  
    		,@DescriptionContains  
    
END
GO
----------------------|||*****END AppDomain Search*****|||----------------------



----------------------|||*****BEGIN AppDomain Update*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppDomainUpdate]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppDomainUpdate]'
	DROP PROC [dbo].[AppDomainUpdate] 
END
GO
PRINT 'Creating [dbo].[AppDomainUpdate]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDomainUpdate]

@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Description NVARCHAR(200)
				

AS
BEGIN
SET NOCOUNT ON

UPDATE [dbo].[AppDomain]
SET
  [AppDomainGuid] = @AppDomainGuid  
  ,[Name] = @Name  
  ,[Description] = @Description  
WHERE [AppDomainGuid] = @AppDomainGuid

END
GO
----------------------|||*****END AppDomain Update*****|||----------------------



----------------------|||*****BEGIN AppDomain Insert*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppDomainInsert]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppDomainInsert]'
	DROP PROC [dbo].[AppDomainInsert] 
END
GO
PRINT 'Creating [dbo].[AppDomainInsert]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDomainInsert]
@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Description NVARCHAR(200)
				
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [dbo].[AppDomain]
(
[AppDomainGuid]
,[Name]
,[Description]
)
VALUES
(
@AppDomainGuid
,@Name
,@Description
)
END
GO
----------------------|||*****END AppDomain Insert*****|||----------------------


----------------------|||*****BEGIN AppDomain Delete*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppDomainDelete]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppDomainDelete]'
	DROP PROC [dbo].[AppDomainDelete] 
END
GO
PRINT 'Creating [dbo].[AppDomainDelete]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDomainDelete]
 @AppDomainGuid UNIQUEIDENTIFIER
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[AppDomain]
WHERE [AppDomainGuid] = @AppDomainGuid

END
GO
----------------------|||*****END AppDomain Delete*****|||----------------------





----------------------|||*****Begin App Select*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppSelect]') IS NOT NULL
BEGIN
	PRINT 'Deleting [dbo].[AppSelect]'
    DROP PROC [dbo].[AppSelect]
END    
GO
PRINT 'Creating [dbo].[AppSelect]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppSelect]

@AppGuid UNIQUEIDENTIFIER

AS
BEGIN
SET NOCOUNT ON

SELECT *
FROM [dbo].[App]
WHERE ([AppGuid] = @AppGuid)
	
END
GO
----------------------|||*****End App Select*****|||----------------------



----------------------|||*****Begin App Find*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[AppFind]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppFind]'
	DROP PROC [dbo].[AppFind] 
END
GO
PRINT 'Creating [dbo].[AppFind]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppFind]
@AppGuid UNIQUEIDENTIFIER
				,@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Description NVARCHAR(200)
				,@IsThirdParty BIT
				AS
BEGIN
SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@AppGuid UNIQUEIDENTIFIER
				,@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Description NVARCHAR(200)
				,@IsThirdParty BIT
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[App]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

		IF(@AppGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppGuid] = @AppGuid)';

	IF(@AppDomainGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppDomainGuid] = @AppDomainGuid)';

	IF(@Name IS NOT NULL)
		SET @Query = @Query + ' AND ([Name] = @Name)';

	IF(@Description IS NOT NULL)
		SET @Query = @Query + ' AND ([Description] = @Description)';

	IF(@IsThirdParty IS NOT NULL)
		SET @Query = @Query + ' AND ([IsThirdParty] = @IsThirdParty)';

	    
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@AppGuid
   		,@AppDomainGuid
   		,@Name
   		,@Description
   		,@IsThirdParty
   END
GO
----------------------|||*****END App Find*****|||----------------------







----------------------|||*****BEGIN App Search*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[AppSearch]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppSearch]'
	DROP PROC [dbo].[AppSearch] 
END
GO
PRINT 'Deleting [dbo].[AppSearch]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppSearch]
	@NameStartsWith NVARCHAR(50)
				,@NameContains NVARCHAR(50)
				,@DescriptionStartsWith NVARCHAR(200)
				,@DescriptionContains NVARCHAR(200)
				
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
		@NameStartsWith NVARCHAR(50)
				,@NameContains NVARCHAR(50)
				,@DescriptionStartsWith NVARCHAR(200)
				,@DescriptionContains NVARCHAR(200)
				
	'

	Declare @Query nvarchar(MAX) = '
	SELECT *
	FROM [dbo].[App]
	WHERE 1 = 1
	'

					if(@NameStartsWith IS NOT NULL)
				SET @Query = @Query + 'AND ([Name] LIKE (@NameStartsWith + ''%''))'

					if(@NameContains IS NOT NULL)
				SET @Query = @Query + 'AND ([Name] LIKE (''%'' + @NameContains + ''%''))'

					if(@DescriptionStartsWith IS NOT NULL)
				SET @Query = @Query + 'AND ([Description] LIKE (@DescriptionStartsWith + ''%''))'

					if(@DescriptionContains IS NOT NULL)
				SET @Query = @Query + 'AND ([Description] LIKE (''%'' + @DescriptionContains + ''%''))'

		
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@NameStartsWith  
    		,@NameContains  
    		,@DescriptionStartsWith  
    		,@DescriptionContains  
    
END
GO
----------------------|||*****END App Search*****|||----------------------



----------------------|||*****BEGIN App Update*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppUpdate]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppUpdate]'
	DROP PROC [dbo].[AppUpdate] 
END
GO
PRINT 'Creating [dbo].[AppUpdate]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppUpdate]

@AppGuid UNIQUEIDENTIFIER
				,@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Description NVARCHAR(200)
				,@IsThirdParty BIT
				

AS
BEGIN
SET NOCOUNT ON

UPDATE [dbo].[App]
SET
  [AppGuid] = @AppGuid  
  ,[AppDomainGuid] = @AppDomainGuid  
  ,[Name] = @Name  
  ,[Description] = @Description  
  ,[IsThirdParty] = @IsThirdParty  
WHERE [AppGuid] = @AppGuid

END
GO
----------------------|||*****END App Update*****|||----------------------



----------------------|||*****BEGIN App Insert*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppInsert]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppInsert]'
	DROP PROC [dbo].[AppInsert] 
END
GO
PRINT 'Creating [dbo].[AppInsert]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppInsert]
@AppGuid UNIQUEIDENTIFIER
				,@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Description NVARCHAR(200)
				,@IsThirdParty BIT
				
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [dbo].[App]
(
[AppGuid]
,[AppDomainGuid]
,[Name]
,[Description]
,[IsThirdParty]
)
VALUES
(
@AppGuid
,@AppDomainGuid
,@Name
,@Description
,@IsThirdParty
)
END
GO
----------------------|||*****END App Insert*****|||----------------------


----------------------|||*****BEGIN App Delete*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[AppDelete]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[AppDelete]'
	DROP PROC [dbo].[AppDelete] 
END
GO
PRINT 'Creating [dbo].[AppDelete]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[AppDelete]
 @AppGuid UNIQUEIDENTIFIER
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[App]
WHERE [AppGuid] = @AppGuid

END
GO
----------------------|||*****END App Delete*****|||----------------------





----------------------|||*****Begin DomainTerm Select*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[DomainTermSelect]') IS NOT NULL
BEGIN
	PRINT 'Deleting [dbo].[DomainTermSelect]'
    DROP PROC [dbo].[DomainTermSelect]
END    
GO
PRINT 'Creating [dbo].[DomainTermSelect]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[DomainTermSelect]

@DomainTermGuid UNIQUEIDENTIFIER

AS
BEGIN
SET NOCOUNT ON

SELECT *
FROM [dbo].[DomainTerm]
WHERE ([DomainTermGuid] = @DomainTermGuid)
	
END
GO
----------------------|||*****End DomainTerm Select*****|||----------------------



----------------------|||*****Begin DomainTerm Find*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[DomainTermFind]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[DomainTermFind]'
	DROP PROC [dbo].[DomainTermFind] 
END
GO
PRINT 'Creating [dbo].[DomainTermFind]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[DomainTermFind]
@DomainTermGuid UNIQUEIDENTIFIER
				,@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Definition NVARCHAR(200)
				AS
BEGIN
SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
	@DomainTermGuid UNIQUEIDENTIFIER
				,@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Definition NVARCHAR(200)
					';

	DECLARE @Query NVARCHAR(MAX)

	SET @Query = '
	SELECT *
	FROM [dbo].[DomainTerm]
	WHERE (1=1)'; --this condition is just to make dynamic sql creation easier

		IF(@DomainTermGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([DomainTermGuid] = @DomainTermGuid)';

	IF(@AppDomainGuid IS NOT NULL)
		SET @Query = @Query + ' AND ([AppDomainGuid] = @AppDomainGuid)';

	IF(@Name IS NOT NULL)
		SET @Query = @Query + ' AND ([Name] = @Name)';

	IF(@Definition IS NOT NULL)
		SET @Query = @Query + ' AND ([Definition] = @Definition)';

	    
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@DomainTermGuid
   		,@AppDomainGuid
   		,@Name
   		,@Definition
   END
GO
----------------------|||*****END DomainTerm Find*****|||----------------------







----------------------|||*****BEGIN DomainTerm Search*****|||----------------------

GO
IF OBJECT_ID ('[dbo].[DomainTermSearch]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[DomainTermSearch]'
	DROP PROC [dbo].[DomainTermSearch] 
END
GO
PRINT 'Deleting [dbo].[DomainTermSearch]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[DomainTermSearch]
	@NameStartsWith NVARCHAR(50)
				,@NameContains NVARCHAR(50)
				,@DefinitionStartsWith NVARCHAR(200)
				,@DefinitionContains NVARCHAR(200)
				
AS
BEGIN
	SET NOCOUNT ON

	DECLARE @Parameters NVARCHAR(MAX) = '
		@NameStartsWith NVARCHAR(50)
				,@NameContains NVARCHAR(50)
				,@DefinitionStartsWith NVARCHAR(200)
				,@DefinitionContains NVARCHAR(200)
				
	'

	Declare @Query nvarchar(MAX) = '
	SELECT *
	FROM [dbo].[DomainTerm]
	WHERE 1 = 1
	'

					if(@NameStartsWith IS NOT NULL)
				SET @Query = @Query + 'AND ([Name] LIKE (@NameStartsWith + ''%''))'

					if(@NameContains IS NOT NULL)
				SET @Query = @Query + 'AND ([Name] LIKE (''%'' + @NameContains + ''%''))'

					if(@DefinitionStartsWith IS NOT NULL)
				SET @Query = @Query + 'AND ([Definition] LIKE (@DefinitionStartsWith + ''%''))'

					if(@DefinitionContains IS NOT NULL)
				SET @Query = @Query + 'AND ([Definition] LIKE (''%'' + @DefinitionContains + ''%''))'

		
	--execute the sql
	EXECUTE sp_Executesql @Query
		,@Parameters
			,@NameStartsWith  
    		,@NameContains  
    		,@DefinitionStartsWith  
    		,@DefinitionContains  
    
END
GO
----------------------|||*****END DomainTerm Search*****|||----------------------



----------------------|||*****BEGIN DomainTerm Update*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[DomainTermUpdate]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[DomainTermUpdate]'
	DROP PROC [dbo].[DomainTermUpdate] 
END
GO
PRINT 'Creating [dbo].[DomainTermUpdate]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[DomainTermUpdate]

@DomainTermGuid UNIQUEIDENTIFIER
				,@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Definition NVARCHAR(200)
				

AS
BEGIN
SET NOCOUNT ON

UPDATE [dbo].[DomainTerm]
SET
  [DomainTermGuid] = @DomainTermGuid  
  ,[AppDomainGuid] = @AppDomainGuid  
  ,[Name] = @Name  
  ,[Definition] = @Definition  
WHERE [DomainTermGuid] = @DomainTermGuid

END
GO
----------------------|||*****END DomainTerm Update*****|||----------------------



----------------------|||*****BEGIN DomainTerm Insert*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[DomainTermInsert]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[DomainTermInsert]'
	DROP PROC [dbo].[DomainTermInsert] 
END
GO
PRINT 'Creating [dbo].[DomainTermInsert]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[DomainTermInsert]
@DomainTermGuid UNIQUEIDENTIFIER
				,@AppDomainGuid UNIQUEIDENTIFIER
				,@Name NVARCHAR(50)
				,@Definition NVARCHAR(200)
				
AS
BEGIN
SET NOCOUNT ON
INSERT INTO [dbo].[DomainTerm]
(
[DomainTermGuid]
,[AppDomainGuid]
,[Name]
,[Definition]
)
VALUES
(
@DomainTermGuid
,@AppDomainGuid
,@Name
,@Definition
)
END
GO
----------------------|||*****END DomainTerm Insert*****|||----------------------


----------------------|||*****BEGIN DomainTerm Delete*****|||----------------------
GO
IF OBJECT_ID ('[dbo].[DomainTermDelete]') IS NOT NULL 
BEGIN
	PRINT 'Deleting [dbo].[DomainTermDelete]'
	DROP PROC [dbo].[DomainTermDelete] 
END
GO
PRINT 'Creating [dbo].[DomainTermDelete]'
GO
-- =============================================
-- Author:  HPCPC
-- Create date: 2/20/2017 4:02:41 PM
-- Description: Warning, this is auto-generated and might be over written. Do not edit.
-- =============================================
CREATE PROCEDURE [dbo].[DomainTermDelete]
 @DomainTermGuid UNIQUEIDENTIFIER
AS
BEGIN
SET NOCOUNT ON
DELETE FROM [dbo].[DomainTerm]
WHERE [DomainTermGuid] = @DomainTermGuid

END
GO
----------------------|||*****END DomainTerm Delete*****|||----------------------







