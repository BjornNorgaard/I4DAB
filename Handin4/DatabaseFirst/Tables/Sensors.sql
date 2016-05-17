CREATE TABLE [dbo].[Sensors] (
    [SensorId]          INT IDENTITY (1, 1) NOT NULL,
    [ApartmentId] INT NOT NULL,
    CONSTRAINT [PK_Sensors] PRIMARY KEY CLUSTERED ([SensorId] ASC)
);