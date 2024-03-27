CREATE TABLE [dbo].[MembersList] (
    [CodeMem]     INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [LastName]    NVARCHAR (MAX) NOT NULL,
    [Id]          INT            NOT NULL,
    [Address]     NVARCHAR (MAX) NOT NULL,
    [Dob]         DATETIME2 (7)  NOT NULL,
    [Phone]       NVARCHAR (MAX) NOT NULL,
    [MobilePhone] NVARCHAR (MAX) NOT NULL,
    [Ill]         DATETIME2 (7)  NULL,
    [Recovery]    DATETIME2 (7)  NULL,
    [countVac]    INT            NOT NULL,
    CONSTRAINT [PK_MembersList] PRIMARY KEY CLUSTERED ([CodeMem] ASC)
);

