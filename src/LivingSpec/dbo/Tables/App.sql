CREATE TABLE [dbo].[App] (
    [AppGuid]       UNIQUEIDENTIFIER NOT NULL,
    [AppDomainGuid] UNIQUEIDENTIFIER NOT NULL,
    [Name]          NVARCHAR (50)    NOT NULL,
    [Description]   NVARCHAR (200)   NOT NULL,
    [IsThirdParty]  BIT              NOT NULL,
    CONSTRAINT [PK_App] PRIMARY KEY CLUSTERED ([AppGuid] ASC),
    CONSTRAINT [FK_App_AppDomain] FOREIGN KEY ([AppDomainGuid]) REFERENCES [dbo].[AppDomain] ([AppDomainGuid])
);

