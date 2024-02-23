USE [StoreDB]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 23/02/2024 11:03:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodigoStatus] [varchar](4) NULL,
	[DescricaoStatus] [varchar](30) NULL,
	[FinalizaCliente] [varchar](3) NULL,
	[ContabilizaVenda] [varchar](3) NULL,
 CONSTRAINT [PK_dbo.Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([Id], [CodigoStatus], [DescricaoStatus], [FinalizaCliente], [ContabilizaVenda]) VALUES (1, N'0001', N'ATIVO', N'SIM', N'SIM')
INSERT [dbo].[Status] ([Id], [CodigoStatus], [DescricaoStatus], [FinalizaCliente], [ContabilizaVenda]) VALUES (2, N'0002', N'INATIVO', N'SIM', N'NÃO')
INSERT [dbo].[Status] ([Id], [CodigoStatus], [DescricaoStatus], [FinalizaCliente], [ContabilizaVenda]) VALUES (3, N'0003', N'EXCLUIDO', N'SIM', N'NÃO')
INSERT [dbo].[Status] ([Id], [CodigoStatus], [DescricaoStatus], [FinalizaCliente], [ContabilizaVenda]) VALUES (4, N'0004', N'INADIPLENTE', N'SIM', N'SIM')
INSERT [dbo].[Status] ([Id], [CodigoStatus], [DescricaoStatus], [FinalizaCliente], [ContabilizaVenda]) VALUES (5, N'0005', N'Selecione ...', N'SIM', N'SIM')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
