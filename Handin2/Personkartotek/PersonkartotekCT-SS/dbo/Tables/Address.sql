CREATE TABLE [dbo].[Address] (
    [AddressId] BIGINT         IDENTITY (1, 1) NOT NULL,
    [Country]   NVARCHAR (500) NOT NULL,
    [Town]      NVARCHAR (500) NOT NULL,
    [Street]    NVARCHAR (500) NOT NULL,
    [unnamed]   NVARCHAR (500) NOT NULL,
    CONSTRAINT [pk_Address] PRIMARY KEY CLUSTERED ([AddressId] ASC)
);

