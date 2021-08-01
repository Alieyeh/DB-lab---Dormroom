
CREATE TABLE [dbo].[City] (
    [CityCode]    INT            NOT NULL,
    [CityName]    NVARCHAR (100) NOT NULL,
    [Province] NVARCHAR(100)            NOT NULL,
    PRIMARY KEY CLUSTERED ([CityCode] ASC),
    UNIQUE NONCLUSTERED ([CityName] ASC)
);


