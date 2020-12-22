-- =========================================
-- Create FileTable template
-- =========================================
CREATE TABLE [dbo].[StockMarkettbl](  
    [Id] [int] IDENTITY(1,1) NOT NULL,  
    [CompanyName] [varchar](50) NULL,  
    [StockPrice] [varchar](50) NULL,  
PRIMARY KEY CLUSTERED   
(  
    [Id] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY]  
GO  
SET ANSI_PADDING OFF  
GO  
SET IDENTITY_INSERT [dbo].[StockMarkettbl] ON   
GO  
INSERT [dbo].[StockMarkettbl] ([Id], [CompanyName], [StockPrice]) VALUES (1, N'Google', N'59000')  
GO  
INSERT [dbo].[StockMarkettbl] ([Id], [CompanyName], [StockPrice]) VALUES (2, N'Microsoft', N'19000')  
GO  
INSERT [dbo].[StockMarkettbl] ([Id], [CompanyName], [StockPrice]) VALUES (3, N'Amazon', N'79000')  
GO  
INSERT [dbo].[StockMarkettbl] ([Id], [CompanyName], [StockPrice]) VALUES (4, N'Netflix', N'99000')  
GO  
INSERT [dbo].[StockMarkettbl] ([Id], [CompanyName], [StockPrice]) VALUES (5, N'Facebook', N'119000')  
GO  
INSERT [dbo].[StockMarkettbl] ([Id], [CompanyName], [StockPrice]) VALUES (6, N'Walmart', N'9000')  
GO  
INSERT [dbo].[StockMarkettbl] ([Id], [CompanyName], [StockPrice]) VALUES (7, N'Atlassian', N'51000')  
GO  
INSERT [dbo].[StockMarkettbl] ([Id], [CompanyName], [StockPrice]) VALUES (8, N'Intuit', N'11000')  
GO  
INSERT [dbo].[StockMarkettbl] ([Id], [CompanyName], [StockPrice]) VALUES (9, N'Apple', N'4000')  
GO  
INSERT [dbo].[StockMarkettbl] ([Id], [CompanyName], [StockPrice]) VALUES (10, N'Uber', N'9000')  
GO  
INSERT [dbo].[StockMarkettbl] ([Id], [CompanyName], [StockPrice]) VALUES (11, N'LinkedIn', N'5000')  
GO  
SET IDENTITY_INSERT [dbo].[StockMarkettbl] OFF  
GO
