CREATE TABLE [dbo].[DecisionsOfAlgorithms] (
    [AlgorithmID]   INT                NOT NULL,
    [PurchasePrice] REAL               NOT NULL,
    [SellingPrice]  REAL               NOT NULL,
    [Profit]        REAL               NOT NULL,
    [PurchaseDate]  DATETIMEOFFSET (7) NOT NULL,
    [SellingDate]   DATETIMEOFFSET (7) NOT NULL
);

