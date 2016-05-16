
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/16/2016 00:49:25
-- Generated from EDMX file: C:\cygwin64\home\Mr. Derp-lappitoppi\git-repos\I4DAB - Bjørn\Handin4\HandinDB\Handin4Model.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Sensors'
CREATE TABLE [dbo].[Sensors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ApartmentId] int  NOT NULL
);
GO

-- Creating table 'Mesurements'
CREATE TABLE [dbo].[Mesurements] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Timestamp] nvarchar(max)  NOT NULL,
    [Value] float  NOT NULL,
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
ADD CONSTRAINT [FK_SensorMesurement1]
    FOREIGN KEY ([SensorId])
    REFERENCES [dbo].[Sensors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SensorMesurement1'
CREATE INDEX [IX_FK_SensorMesurement1]
ON [dbo].[Mesurements]
    ([SensorId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------