
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/12/2016 13:27:13
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Sensors'
CREATE TABLE [dbo].[Sensors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [sensorId] int  NOT NULL,
    [appartmentId] int  NOT NULL,
    [value] float  NOT NULL,
    [timestamp] nvarchar(max)  NOT NULL
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

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------