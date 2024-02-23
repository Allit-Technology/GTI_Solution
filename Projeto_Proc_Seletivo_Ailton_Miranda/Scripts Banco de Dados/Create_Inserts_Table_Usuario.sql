USE [StoreDB]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 23/02/2024 11:03:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](80) NOT NULL,
	[Email] [varchar](80) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
	[PerfilId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [Nome], [Email], [Senha], [PerfilId]) VALUES (1, N'AILTON DE MIRANDA', N'ailton.prg@gmail.com', N'isa72LEK*202301', 2)
INSERT [dbo].[Usuario] ([Id], [Nome], [Email], [Senha], [PerfilId]) VALUES (2, N'DAMARES GOMES', N'damares@gmail.com', N'1234', 1)
INSERT [dbo].[Usuario] ([Id], [Nome], [Email], [Senha], [PerfilId]) VALUES (3, N'GEIZA', N'geiza@gmail.com', N'1234', 1)
INSERT [dbo].[Usuario] ([Id], [Nome], [Email], [Senha], [PerfilId]) VALUES (4, N'KIANE', N'kiane@gmail.com', N'1234', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Usuario_dbo.Perfil_PerfilId] FOREIGN KEY([PerfilId])
REFERENCES [dbo].[Perfil] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_dbo.Usuario_dbo.Perfil_PerfilId]
GO
