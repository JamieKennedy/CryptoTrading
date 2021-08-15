CREATE TABLE [dbo].[Traders] (
    [pkId]              BIGINT           IDENTITY (1, 1) NOT NULL,
    [fkAccountId]       BIGINT           NOT NULL,
    [Name]              VARCHAR (50)     NULL,
    [FiatCurrency]      VARCHAR (3)      NOT NULL,
    [CryptoCurrency]    VARCHAR (3)      NOT NULL,
    [FiatAmount]        DECIMAL (10, 2)  NOT NULL,
    [InitialFiatAmount] DECIMAL (10, 2)  NULL,
    [CryptoAmount]      DECIMAL (20, 10) NOT NULL,
    [TakeProfit]        DECIMAL (10, 2)  NULL,
    [StopLoss]          DECIMAL (10, 2)  NULL,
    [Result]            DECIMAL (10, 2)  NOT NULL,
    CONSTRAINT [PK_Traders] PRIMARY KEY CLUSTERED ([pkId] ASC),
    CONSTRAINT [FK_Traders_Traders] FOREIGN KEY ([pkId]) REFERENCES [dbo].[Traders] ([pkId])
);

