CREATE TABLE [dbo].[DomainTerm] (
    [DomainTermGuid] UNIQUEIDENTIFIER NOT NULL,
    [AppDomainGuid]  UNIQUEIDENTIFIER NOT NULL,
    [Name]           NVARCHAR (50)    NOT NULL,
    [Definition]     NVARCHAR (200)   NOT NULL,
    CONSTRAINT [PK_DomainTerm] PRIMARY KEY CLUSTERED ([DomainTermGuid] ASC),
    CONSTRAINT [FK_DomainTerm_AppDomain] FOREIGN KEY ([AppDomainGuid]) REFERENCES [dbo].[AppDomain] ([AppDomainGuid])
);

