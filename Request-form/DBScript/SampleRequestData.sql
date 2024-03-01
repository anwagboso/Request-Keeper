USE [CustomerRequestLogDB]
GO
/****** Object:  Table [dbo].[tbl_Request]    Script Date: 2/29/2024 7:51:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Request](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[RequestNote] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[PhoneNo] [nvarchar](50) NULL,
	[RequestDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_Request] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Request] ON 
GO
INSERT [dbo].[tbl_Request] ([Id], [FirstName], [LastName], [RequestNote], [Address], [PhoneNo], [RequestDate]) VALUES (1, N'Ahmed', N'Clay', N'How can I get UK used Laptop', N'No 12 Bob Top Ave IV Lagos', N'09034576543', CAST(N'2024-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tbl_Request] ([Id], [FirstName], [LastName], [RequestNote], [Address], [PhoneNo], [RequestDate]) VALUES (2, N'James', N'Adebayo', N'How Much Is the cost of UK used Phone', N'No 17 Allen  Ave Ikeja Lagos', N'08076686543', CAST(N'2024-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tbl_Request] ([Id], [FirstName], [LastName], [RequestNote], [Address], [PhoneNo], [RequestDate]) VALUES (3, N'Mary', N'Gogo', N'How much is the cost HP keyboard Laptop', N'12 Greek Road Road Apapa Lagos', N'07096758566', CAST(N'2024-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tbl_Request] ([Id], [FirstName], [LastName], [RequestNote], [Address], [PhoneNo], [RequestDate]) VALUES (4, N'Kingsley', N'Ikechukwu', N'What is the cost Laptop Stand S4 pro', N'No 9 Bode Thomos Surulere Lagos', N'09035376463', CAST(N'2024-01-01T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tbl_Request] OFF
GO
