CREATE TABLE [dbo].[CustomerTable] (
    [Id]       INT        NOT NULL,
    [Forename] NCHAR (10) NULL,
    [Surname]  NCHAR (16) NULL,
    [Available] MONEY NULL, 
    [Equity] MONEY NULL, 
    [Maintanence Margin] MONEY NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

