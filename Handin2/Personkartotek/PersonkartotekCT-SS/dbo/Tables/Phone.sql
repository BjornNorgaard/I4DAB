CREATE TABLE [dbo].[Phone] (
    [PhoneId]     BIGINT         IDENTITY (1, 1) NOT NULL,
    [Phonenumber] NVARCHAR (500) NOT NULL,
    [CountryCode] NVARCHAR (500) NOT NULL,
    [PhoneType]   NVARCHAR (500) NOT NULL,
    [PersonId]    BIGINT         NULL,
    CONSTRAINT [pk_Phone] PRIMARY KEY CLUSTERED ([PhoneId] ASC),
    CONSTRAINT [fk_Phone] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId]) ON UPDATE CASCADE
);

