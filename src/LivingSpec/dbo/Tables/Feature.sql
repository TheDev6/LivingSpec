CREATE TABLE [dbo].[Feature] (
    [FeatureGuid] UNIQUEIDENTIFIER NOT NULL,
    [Name]        NVARCHAR (200)   NOT NULL,
    [GherkinText] NVARCHAR (MAX)   NOT NULL,
    CONSTRAINT [PK_Feature] PRIMARY KEY CLUSTERED ([FeatureGuid] ASC)
);



