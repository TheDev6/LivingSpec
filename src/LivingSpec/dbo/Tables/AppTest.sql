CREATE TABLE [dbo].[AppTest] (
    [AppTestGuid]       UNIQUEIDENTIFIER NOT NULL,
    [AppGuid]           UNIQUEIDENTIFIER NOT NULL,
    [Date]              DATETIME         NOT NULL,
    [TargetEnvironment] NVARCHAR (50)    NOT NULL,
    [TypeKey]           NVARCHAR (50)    NOT NULL,
    [JsonValue]         NVARCHAR (4000)  NOT NULL,
    CONSTRAINT [PK_AppTest] PRIMARY KEY CLUSTERED ([AppTestGuid] ASC),
    CONSTRAINT [FK_AppTest_App] FOREIGN KEY ([AppGuid]) REFERENCES [dbo].[App] ([AppGuid])
);

