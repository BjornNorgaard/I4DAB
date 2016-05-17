CREATE TABLE [dbo].[Sensors] (
    [Id]          INT IDENTITY (1, 1) NOT NULL,
    [ApartmentId] INT NOT NULL,
    CONSTRAINT [PK_Sensors] PRIMARY KEY CLUSTERED ([Id] ASC)
);