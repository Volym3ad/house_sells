CREATE TABLE [dbo].[Flats]
(
	[Адреса] NVARCHAR(MAX) NOT NULL , 
    [Розмір] INT NULL, 
    [Поверх] INT NULL, 
    [Кіл-сть_кімнат] INT NULL, 
    [Рік_побудови] INT NULL, 
    [Ціна] INT NULL, 
    CONSTRAINT [PK_Flats] PRIMARY KEY ([Адреса])
)
