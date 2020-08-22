CREATE TABLE [dbo].[Prices] (
    [CompanyID] VARCHAR (20)       NOT NULL,
    [Value]     REAL               NOT NULL,
    [Date]      DATETIMEOFFSET (7) NOT NULL,
    [TimeScale] INT                NOT NULL
);

