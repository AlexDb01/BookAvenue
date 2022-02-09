CREATE TABLE [dbo].[Books] (
    [bookID]       INT           IDENTITY (1, 1) NOT NULL,
    [title]        VARCHAR (100) NOT NULL,
    [year]         INT          NOT NULL,
    [author]       VARCHAR (60)  NOT NULL,
    [pages]        INT           NOT NULL,
    [type]         VARCHAR (MAX) NOT NULL,
    [availability] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([bookID] ASC)
);

