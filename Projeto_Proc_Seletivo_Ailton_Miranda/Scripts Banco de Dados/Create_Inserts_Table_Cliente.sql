USE [StoreDB]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 23/02/2024 11:03:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Cpf] [varchar](11) NOT NULL,
	[Rg] [varchar](12) NOT NULL,
	[DataExpedicao] [datetime] NOT NULL,
	[OrgaoExpedicao] [varchar](3) NULL,
	[DataNascimento] [datetime] NOT NULL,
	[EstadoCivilId] [int] NOT NULL,
	[UFId] [int] NOT NULL,
	[SexoId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([Id], [Nome], [Cpf], [Rg], [DataExpedicao], [OrgaoExpedicao], [DataNascimento], [EstadoCivilId], [UFId], [SexoId]) VALUES (2, N'MARISA MONTE', N'91785936549', N'345679874', CAST(N'2018-03-23T00:00:00.000' AS DateTime), N'SSP', CAST(N'1976-08-09T00:00:00.000' AS DateTime), 1, 6, 2)
INSERT [dbo].[Cliente] ([Id], [Nome], [Cpf], [Rg], [DataExpedicao], [OrgaoExpedicao], [DataNascimento], [EstadoCivilId], [UFId], [SexoId]) VALUES (3, N'MICHAEL JACKSON', N'93388998884', N'23456765Y', CAST(N'2001-01-03T00:00:00.000' AS DateTime), N'SSP', CAST(N'1957-01-23T00:00:00.000' AS DateTime), 1, 4, 1)
INSERT [dbo].[Cliente] ([Id], [Nome], [Cpf], [Rg], [DataExpedicao], [OrgaoExpedicao], [DataNascimento], [EstadoCivilId], [UFId], [SexoId]) VALUES (4, N'BRAD PITT', N'45320344856', N'345678761', CAST(N'2015-02-01T00:00:00.000' AS DateTime), N'SSP', CAST(N'1965-03-09T00:00:00.000' AS DateTime), 2, 4, 1)
INSERT [dbo].[Cliente] ([Id], [Nome], [Cpf], [Rg], [DataExpedicao], [OrgaoExpedicao], [DataNascimento], [EstadoCivilId], [UFId], [SexoId]) VALUES (5, N'SONIA BRAGA', N'34312354847', N'120987654', CAST(N'2018-01-01T00:00:00.000' AS DateTime), N'SSP', CAST(N'1965-03-08T00:00:00.000' AS DateTime), 1, 4, 2)
INSERT [dbo].[Cliente] ([Id], [Nome], [Cpf], [Rg], [DataExpedicao], [OrgaoExpedicao], [DataNascimento], [EstadoCivilId], [UFId], [SexoId]) VALUES (7, N'CARLA CAMURATTI', N'87098997587', N'1454345631', CAST(N'2001-01-01T00:00:00.000' AS DateTime), N'SSP', CAST(N'1970-05-03T00:00:00.000' AS DateTime), 1, 6, 2)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Cliente_dbo.EstadoCivil_Id] FOREIGN KEY([EstadoCivilId])
REFERENCES [dbo].[EstadoCivil] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_dbo.Cliente_dbo.EstadoCivil_Id]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Cliente_dbo.Sexo_Id] FOREIGN KEY([SexoId])
REFERENCES [dbo].[Sexo] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_dbo.Cliente_dbo.Sexo_Id]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Cliente_dbo.UnidadeFederativa_Id] FOREIGN KEY([UFId])
REFERENCES [dbo].[UnidadeFederativa] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_dbo.Cliente_dbo.UnidadeFederativa_Id]
GO
