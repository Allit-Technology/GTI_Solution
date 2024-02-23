USE [StoreDB]
GO
/****** Object:  Table [dbo].[ClientesEndereco]    Script Date: 23/02/2024 11:03:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientesEndereco](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cep] [varchar](9) NOT NULL,
	[Logradouro] [varchar](50) NOT NULL,
	[Numero] [varchar](6) NOT NULL,
	[Complemento] [varchar](30) NOT NULL,
	[Bairro] [varchar](20) NULL,
	[Cidade] [varchar](20) NULL,
	[ClienteId] [int] NOT NULL,
	[UFId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ClientesEndereco] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ClientesEndereco] ON 

INSERT [dbo].[ClientesEndereco] ([Id], [Cep], [Logradouro], [Numero], [Complemento], [Bairro], [Cidade], [ClienteId], [UFId]) VALUES (1, N'03951090', N'RUA DR. PAULO QUEIROZ', N'741', N'APTO. 92 TORRE 1', N'JARDIM 9 DE JULHO', N'SAO PAULO', 2, 4)
INSERT [dbo].[ClientesEndereco] ([Id], [Cep], [Logradouro], [Numero], [Complemento], [Bairro], [Cidade], [ClienteId], [UFId]) VALUES (2, N'03951090', N'RUA DOUTOR PAULO QUEIROZ', N'741', N'APTO. 92 T1', N'JARDIM NOVE DE JULHO', N'SAO PAULO', 3, 4)
INSERT [dbo].[ClientesEndereco] ([Id], [Cep], [Logradouro], [Numero], [Complemento], [Bairro], [Cidade], [ClienteId], [UFId]) VALUES (13, N'03311090', N'RUA LUIZ VICENTE PRADO FREIRE', N'60', N'CASA', N'JARDIM IGUATEMI', N'SAO PAULO', 4, 4)
SET IDENTITY_INSERT [dbo].[ClientesEndereco] OFF
GO
ALTER TABLE [dbo].[ClientesEndereco]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ClientesEndereco_dbo.Cliente_ClienteId] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Cliente] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ClientesEndereco] CHECK CONSTRAINT [FK_dbo.ClientesEndereco_dbo.Cliente_ClienteId]
GO
ALTER TABLE [dbo].[ClientesEndereco]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ClientesEndereco_dbo.UnidadeFederativa_Id] FOREIGN KEY([UFId])
REFERENCES [dbo].[UnidadeFederativa] ([Id])
GO
ALTER TABLE [dbo].[ClientesEndereco] CHECK CONSTRAINT [FK_dbo.ClientesEndereco_dbo.UnidadeFederativa_Id]
GO
