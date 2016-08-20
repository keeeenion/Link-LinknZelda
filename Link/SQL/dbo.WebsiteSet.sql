CREATE TABLE [dbo].[WebsiteSet] (
    [Id]          SMALLINT       IDENTITY (1, 1) NOT NULL,
    [Owner]       NVARCHAR (50) NOT NULL DEFAULT Eraisik,
    [URL]         NVARCHAR (50) NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    [Score]       SMALLINT  NOT NULL,
    [Title]       NVARCHAR (50) NOT NULL,
    [Category]    DATE NOT NULL,
    CONSTRAINT [PK_WebsiteSet] PRIMARY KEY CLUSTERED ([Id] ASC)
);

