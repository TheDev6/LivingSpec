CREATE TABLE [dbo].[AppResourceLink] (
    [AppResourceLinkGuid] UNIQUEIDENTIFIER NOT NULL,
    [AppGuid]             UNIQUEIDENTIFIER NOT NULL,
    [LinkUrl]             NVARCHAR (4000)  NOT NULL,
    CONSTRAINT [PK_AppResourceLink] PRIMARY KEY CLUSTERED ([AppResourceLinkGuid] ASC),
    CONSTRAINT [FK_AppResourceLink_App] FOREIGN KEY ([AppGuid]) REFERENCES [dbo].[App] ([AppGuid])
);

