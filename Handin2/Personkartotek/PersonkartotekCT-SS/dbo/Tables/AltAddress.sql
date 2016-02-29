CREATE TABLE [dbo].[AltAddress] (
    [PersonId]    BIGINT         NOT NULL,
    [AddressId]   BIGINT         NOT NULL,
    [AddressType] NVARCHAR (500) NOT NULL,
    CONSTRAINT [pk_AltAddress] PRIMARY KEY CLUSTERED ([PersonId] ASC, [AddressId] ASC),
    CONSTRAINT [fk_AltAddress] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [fk_AltAddress2] FOREIGN KEY ([AddressId]) REFERENCES [dbo].[Address] ([AddressId])
);

