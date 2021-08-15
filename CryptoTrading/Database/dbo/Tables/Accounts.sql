CREATE TABLE [dbo].[Accounts] (
    [pkId] BIGINT           IDENTITY (1, 1) NOT NULL,
    [GBP]  DECIMAL (10, 2)  NULL,
    [EUR]  DECIMAL (10, 2)  NULL,
    [USD]  DECIMAL (10, 2)  NULL,
    [BTC]  DECIMAL (20, 10) NULL,
    [ETH]  DECIMAL (20, 10) NULL,
    [ChangeTime] TIMESTAMP NOT NULL, 
    [Created] DATETIME NOT NULL, 
    [LastModified] DATETIME NOT NULL, 
    CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([pkId] ASC)
);

