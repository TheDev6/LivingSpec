CREATE TABLE [dbo].[AppFeature] (
    [AppFeatureGuid] UNIQUEIDENTIFIER NOT NULL,
    [AppGuid]        UNIQUEIDENTIFIER NOT NULL,
    [FeatureGuid]    UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_AppFeature] PRIMARY KEY CLUSTERED ([AppFeatureGuid] ASC),
    CONSTRAINT [FK_AppFeature_App] FOREIGN KEY ([AppGuid]) REFERENCES [dbo].[App] ([AppGuid]),
    CONSTRAINT [FK_AppFeature_Feature] FOREIGN KEY ([FeatureGuid]) REFERENCES [dbo].[Feature] ([FeatureGuid])
);

