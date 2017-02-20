CREATE TABLE [dbo].[AppDomain] (
    [AppDomainGuid] UNIQUEIDENTIFIER NOT NULL,
    [Name]          NVARCHAR (50)    NOT NULL,
    [Description]   NVARCHAR (200)   NOT NULL,
    CONSTRAINT [PK_AppDomain] PRIMARY KEY CLUSTERED ([AppDomainGuid] ASC)
);

