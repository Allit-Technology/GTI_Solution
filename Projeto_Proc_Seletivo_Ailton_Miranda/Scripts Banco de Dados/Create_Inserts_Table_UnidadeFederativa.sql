USE [StoreDB]
GO
/****** Object:  Table [dbo].[UnidadeFederativa]    Script Date: 23/02/2024 11:03:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnidadeFederativa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Uf] [varchar](2) NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
 CONSTRAINT [PK_dbo.UnidadeFederativa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UnidadeFederativa] ON 

INSERT [dbo].[UnidadeFederativa] ([Id], [Uf], [Descricao]) VALUES (4, N'SP', N'SÃO PAULO')
INSERT [dbo].[UnidadeFederativa] ([Id], [Uf], [Descricao]) VALUES (5, N'RJ', N'RIO DE JANEIRO')
INSERT [dbo].[UnidadeFederativa] ([Id], [Uf], [Descricao]) VALUES (6, N'BA', N'BAHIA')
INSERT [dbo].[UnidadeFederativa] ([Id], [Uf], [Descricao]) VALUES (7, N'SC', N'SANTA CATARINA')
SET IDENTITY_INSERT [dbo].[UnidadeFederativa] OFF
GO
