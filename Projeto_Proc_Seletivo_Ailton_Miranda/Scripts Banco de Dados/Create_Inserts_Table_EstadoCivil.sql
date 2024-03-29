USE [StoreDB]
GO
/****** Object:  Table [dbo].[EstadoCivil]    Script Date: 23/02/2024 11:03:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoCivil](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
 CONSTRAINT [PK_dbo.EstadoCivil] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EstadoCivil] ON 

INSERT [dbo].[EstadoCivil] ([Id], [Nome]) VALUES (1, N'CASADO')
INSERT [dbo].[EstadoCivil] ([Id], [Nome]) VALUES (2, N'SOLTEIRO')
INSERT [dbo].[EstadoCivil] ([Id], [Nome]) VALUES (3, N'DIVORCIADO')
SET IDENTITY_INSERT [dbo].[EstadoCivil] OFF
GO
