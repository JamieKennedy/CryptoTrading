CREATE TABLE [dbo].[Positions] (
    [pkId]              BIGINT           IDENTITY (1, 1) NOT NULL,
    [fkTraderId]        BIGINT           NOT NULL,
    [Direction]         VARCHAR (5)      NOT NULL,
    [Opened]            DATETIME         NOT NULL,
    [Closed]            DATETIME         NULL,
    [IsOpen]            BIT              NOT NULL,
    [FiatCurrency]      VARCHAR (3)      NOT NULL,
    [CryptoCurrency]    VARCHAR (3)      NOT NULL,
    [OpeningFiatAmount] DECIMAL (10, 2)  NOT NULL,
    [ClosingFiatAmount] DECIMAL (10, 2)  NULL,
    [CryptoAmount]      DECIMAL (20, 10) NOT NULL,
    [Result]            DECIMAL (10, 2)  NULL,
    CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED ([pkId] ASC)
);

