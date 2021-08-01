CREATE TABLE [dbo].[Users] (
    [Mellicode] INT            NOT NULL,
    [Email]  NVARCHAR (100) NOT NULL,
    [Password]  NVARCHAR (100) NOT NULL,
    [BirthDate] DATE           NOT NULL,
    [Gender]    NVARCHAR (20)  NOT NULL,
    [UAddress]   NVARCHAR (300) NOT NULL,
    [FullName]      NVARCHAR (200) NOT NULL,
    
    PRIMARY KEY CLUSTERED ([Mellicode] ASC),
    CHECK ([BirthDate]>='1900-01-01' AND [BirthDate]<='2020-01-01'),
    CHECK ([Gender]='F' OR [Gender]='M')
);
