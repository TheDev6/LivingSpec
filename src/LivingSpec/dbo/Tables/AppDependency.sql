CREATE TABLE [dbo].[AppDependency] (
    [AppDependencyGuid] UNIQUEIDENTIFIER NOT NULL,
    [AppGuid]           UNIQUEIDENTIFIER NOT NULL,
    [DependsOnAppGuid]  UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_AppDependency] PRIMARY KEY CLUSTERED ([AppDependencyGuid] ASC),
    CONSTRAINT [FK_AppDependency_App] FOREIGN KEY ([AppGuid]) REFERENCES [dbo].[App] ([AppGuid]),
    CONSTRAINT [FK_AppDependency_App1] FOREIGN KEY ([DependsOnAppGuid]) REFERENCES [dbo].[App] ([AppGuid])
);

