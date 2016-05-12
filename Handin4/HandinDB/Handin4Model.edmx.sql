
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/12/2016 13:52:20
-- Generated from EDMX file: C:\Users\Norgaard\Documents\Git\I4DAB\Handin4\HandinDB\Handin4Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [F16I4DABH4Gr13];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_SensorMesurement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mesurements] DROP CONSTRAINT [FK_SensorMesurement];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Sensors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sensors];
GO
IF OBJECT_ID(N'[dbo].[Mesurements]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mesurements];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Sensors'
CREATE TABLE [dbo].[Sensors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AppartmentId] int  NOT NULL,
    [SensorId] int  NOT NULL
);
GO

-- Creating table 'Mesurements'
CREATE TABLE [dbo].[Mesurements] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Value] float  NOT NULL,
    [Timestamp] nvarchar(max)  NOT NULL,
    [SensorId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Sensors'
ALTER TABLE [dbo].[Sensors]
ADD CONSTRAINT [PK_Sensors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Mesurements'
ALTER TABLE [dbo].[Mesurements]
ADD CONSTRAINT [PK_Mesurements]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SensorId] in table 'Mesurements'
ALTER TABLE [dbo].[Mesurements]
ADD CONSTRAINT [FK_SensorMesurement]
    FOREIGN KEY ([SensorId])
    REFERENCES [dbo].[Sensors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SensorMesurement'
CREATE INDEX [IX_FK_SensorMesurement]
ON [dbo].[Mesurements]
    ([SensorId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------