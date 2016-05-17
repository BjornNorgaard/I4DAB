CREATE TABLE [dbo].[Mesurements] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Timestamp] NVARCHAR (MAX) NOT NULL,
    [Value]     FLOAT (53)     NOT NULL,
    [SensorId]  INT            NOT NULL,
    CONSTRAINT [PK_Mesurements] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SensorMesurement1] FOREIGN KEY ([SensorId]) REFERENCES [dbo].[Sensors] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_SensorMesurement1]
    ON [dbo].[Mesurements]([SensorId] ASC);

