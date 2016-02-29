CREATE TABLE [dbo].[Person] (
    [PersonId]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (500) NOT NULL,
    [MiddelName] NVARCHAR (500) NOT NULL,
    [LastName]   NVARCHAR (500) NOT NULL,
    [unnamed]    NVARCHAR (500) NOT NULL,
    [AddressId]  BIGINT         NULL,
    CONSTRAINT [pk_Person] PRIMARY KEY CLUSTERED ([PersonId] ASC),
    CONSTRAINT [fk_Person] FOREIGN KEY ([AddressId]) REFERENCES [dbo].[Address] ([AddressId]) ON UPDATE CASCADE
);

