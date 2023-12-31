USE [master]
GO
/****** Object:  Database [BD_Prueba]    Script Date: 11/10/2023 11:38:32 ******/
CREATE DATABASE [BD_Prueba]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_Prueba', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BD_Prueba.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD_Prueba_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BD_Prueba_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BD_Prueba] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_Prueba].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_Prueba] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_Prueba] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_Prueba] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_Prueba] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_Prueba] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_Prueba] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BD_Prueba] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_Prueba] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_Prueba] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_Prueba] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_Prueba] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_Prueba] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_Prueba] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_Prueba] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_Prueba] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BD_Prueba] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_Prueba] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_Prueba] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_Prueba] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_Prueba] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_Prueba] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_Prueba] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_Prueba] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BD_Prueba] SET  MULTI_USER 
GO
ALTER DATABASE [BD_Prueba] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_Prueba] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_Prueba] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_Prueba] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD_Prueba] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_Prueba] SET QUERY_STORE = OFF
GO
USE [BD_Prueba]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 11/10/2023 11:38:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre_categoria] [varchar](200) NOT NULL,
	[estado_categoria] [bit] NOT NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[fecha_registro] [date] NOT NULL,
	[estado_cliente] [bit] NOT NULL,
	[id_persona] [int] NOT NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compra]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compra](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[fecha_registro] [date] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
 CONSTRAINT [PK_compra] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_compra]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_compra](
	[id_detalle_compra] [int] IDENTITY(1,1) NOT NULL,
	[nombre_producto] [varchar](100) NOT NULL,
	[precio_compra] [float] NOT NULL,
	[cantidad] [int] NOT NULL,
	[total] [float] NOT NULL,
	[id_compra] [int] NOT NULL,
 CONSTRAINT [PK_detalle_compra] PRIMARY KEY CLUSTERED 
(
	[id_detalle_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_venta]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_venta](
	[id_detalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[cantidad_detalle_venta] [int] NOT NULL,
	[precio_detalle_venta] [float] NOT NULL,
	[subtotal_detalle_venta] [float] NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_venta] [int] NOT NULL,
 CONSTRAINT [PK_detalle_venta] PRIMARY KEY CLUSTERED 
(
	[id_detalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[domicilio]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[domicilio](
	[id_domicilio] [int] IDENTITY(1,1) NOT NULL,
	[calle] [varchar](200) NOT NULL,
	[codigo_postal] [int] NOT NULL,
	[numero] [int] NOT NULL,
	[localidad] [varchar](100) NOT NULL,
	[provincia] [varchar](100) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[estado_domicilio] [bit] NOT NULL,
 CONSTRAINT [PK_domicilio] PRIMARY KEY CLUSTERED 
(
	[id_domicilio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[metodo_pago]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[metodo_pago](
	[id_metodo_pago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_metodo_pago] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Metodo_pago] PRIMARY KEY CLUSTERED 
(
	[id_metodo_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso](
	[id_permiso] [int] IDENTITY(1,1) NOT NULL,
	[tipo_permiso] [varchar](100) NOT NULL,
	[fecha_inicio] [date] NOT NULL,
	[fecha_finalizacion] [date] NOT NULL,
	[comentario_justificacion] [varchar](200) NOT NULL,
	[estado_permiso] [varchar](50) NOT NULL,
	[id_usuario] [int] NOT NULL,
 CONSTRAINT [PK_permiso] PRIMARY KEY CLUSTERED 
(
	[id_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persona]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona](
	[id_persona] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](100) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[telefono] [varchar](100) NOT NULL,
 CONSTRAINT [PK_persona] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_producto] [varchar](50) NOT NULL,
	[descripcion_producto] [varchar](100) NOT NULL,
	[precio_compra] [float] NOT NULL,
	[precio_venta] [float] NOT NULL,
	[imagen_producto] [varchar](100) NOT NULL,
	[marca_producto] [varchar](50) NOT NULL,
	[stock_producto] [int] NOT NULL,
	[fecha_registro_producto] [date] NOT NULL,
	[estado_producto] [bit] NOT NULL,
	[id_categoria] [int] NOT NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](100) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[estado_proveedor] [bit] NOT NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_rol] [varchar](100) NOT NULL,
	[estado_rol] [bit] NOT NULL,
 CONSTRAINT [PK_rol] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](200) NOT NULL,
	[password] [varchar](150) NOT NULL,
	[fecha_registro] [date] NOT NULL,
	[estado_usuario] [bit] NOT NULL,
	[id_persona] [int] NOT NULL,
	[id_rol] [int] NOT NULL,
	[id_domicilio] [int] NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[venta_fecha] [date] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_metodo_pago] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
 CONSTRAINT [PK_venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[categoria] ON 

INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [estado_categoria]) VALUES (1, N'Frutas', 0)
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [estado_categoria]) VALUES (2, N'Verduras', 0)
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [estado_categoria]) VALUES (3, N'Carnes', 0)
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [estado_categoria]) VALUES (4, N'Pescados y Mariscos', 0)
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [estado_categoria]) VALUES (5, N'Lácteos', 0)
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [estado_categoria]) VALUES (6, N'Panadería', 0)
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [estado_categoria]) VALUES (7, N'Bebidas', 0)
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [estado_categoria]) VALUES (8, N'Cuidado Personal', 0)
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [estado_categoria]) VALUES (9, N'Limpieza del Hogar', 0)
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [estado_categoria]) VALUES (10, N'Productos Congelados', 0)
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [estado_categoria]) VALUES (11, N'prueba', 1)
SET IDENTITY_INSERT [dbo].[categoria] OFF
SET IDENTITY_INSERT [dbo].[cliente] ON 

INSERT [dbo].[cliente] ([id_cliente], [fecha_registro], [estado_cliente], [id_persona]) VALUES (1, CAST(N'2023-09-01' AS Date), 1, 1)
INSERT [dbo].[cliente] ([id_cliente], [fecha_registro], [estado_cliente], [id_persona]) VALUES (2, CAST(N'2023-09-02' AS Date), 1, 2)
INSERT [dbo].[cliente] ([id_cliente], [fecha_registro], [estado_cliente], [id_persona]) VALUES (6, CAST(N'2023-09-06' AS Date), 1, 6)
INSERT [dbo].[cliente] ([id_cliente], [fecha_registro], [estado_cliente], [id_persona]) VALUES (7, CAST(N'2023-09-07' AS Date), 1, 7)
INSERT [dbo].[cliente] ([id_cliente], [fecha_registro], [estado_cliente], [id_persona]) VALUES (8, CAST(N'2023-09-08' AS Date), 1, 8)
INSERT [dbo].[cliente] ([id_cliente], [fecha_registro], [estado_cliente], [id_persona]) VALUES (9, CAST(N'2023-09-09' AS Date), 1, 9)
INSERT [dbo].[cliente] ([id_cliente], [fecha_registro], [estado_cliente], [id_persona]) VALUES (10, CAST(N'2023-09-10' AS Date), 1, 10)
SET IDENTITY_INSERT [dbo].[cliente] OFF
SET IDENTITY_INSERT [dbo].[detalle_venta] ON 

INSERT [dbo].[detalle_venta] ([id_detalle_venta], [cantidad_detalle_venta], [precio_detalle_venta], [subtotal_detalle_venta], [id_producto], [id_venta]) VALUES (22, 3, 2, 6, 1, 21)
INSERT [dbo].[detalle_venta] ([id_detalle_venta], [cantidad_detalle_venta], [precio_detalle_venta], [subtotal_detalle_venta], [id_producto], [id_venta]) VALUES (23, 2, 3.5, 7, 2, 21)
INSERT [dbo].[detalle_venta] ([id_detalle_venta], [cantidad_detalle_venta], [precio_detalle_venta], [subtotal_detalle_venta], [id_producto], [id_venta]) VALUES (24, 4, 1.75, 7, 3, 22)
INSERT [dbo].[detalle_venta] ([id_detalle_venta], [cantidad_detalle_venta], [precio_detalle_venta], [subtotal_detalle_venta], [id_producto], [id_venta]) VALUES (28, 3, 2, 6, 1, 25)
INSERT [dbo].[detalle_venta] ([id_detalle_venta], [cantidad_detalle_venta], [precio_detalle_venta], [subtotal_detalle_venta], [id_producto], [id_venta]) VALUES (29, 2, 3.5, 7, 2, 25)
INSERT [dbo].[detalle_venta] ([id_detalle_venta], [cantidad_detalle_venta], [precio_detalle_venta], [subtotal_detalle_venta], [id_producto], [id_venta]) VALUES (30, 4, 1.75, 7, 3, 26)
INSERT [dbo].[detalle_venta] ([id_detalle_venta], [cantidad_detalle_venta], [precio_detalle_venta], [subtotal_detalle_venta], [id_producto], [id_venta]) VALUES (31, 1, 1, 1, 4, 22)
INSERT [dbo].[detalle_venta] ([id_detalle_venta], [cantidad_detalle_venta], [precio_detalle_venta], [subtotal_detalle_venta], [id_producto], [id_venta]) VALUES (35, 2, 1.5, 3, 1, 21)
INSERT [dbo].[detalle_venta] ([id_detalle_venta], [cantidad_detalle_venta], [precio_detalle_venta], [subtotal_detalle_venta], [id_producto], [id_venta]) VALUES (36, 2, 1.5, 3, 5, 21)
INSERT [dbo].[detalle_venta] ([id_detalle_venta], [cantidad_detalle_venta], [precio_detalle_venta], [subtotal_detalle_venta], [id_producto], [id_venta]) VALUES (37, 3, 4, 12, 10, 31)
SET IDENTITY_INSERT [dbo].[detalle_venta] OFF
SET IDENTITY_INSERT [dbo].[domicilio] ON 

INSERT [dbo].[domicilio] ([id_domicilio], [calle], [codigo_postal], [numero], [localidad], [provincia], [descripcion], [estado_domicilio]) VALUES (1, N'garica de cossio', 3400, 2310, N'corrientes', N'corrientes', N'es un departamento,domicilio en el primer piso', 1)
INSERT [dbo].[domicilio] ([id_domicilio], [calle], [codigo_postal], [numero], [localidad], [provincia], [descripcion], [estado_domicilio]) VALUES (2, N'honduras', 3400, 2111, N'itati', N'corrientes', N'casa azul', 1)
INSERT [dbo].[domicilio] ([id_domicilio], [calle], [codigo_postal], [numero], [localidad], [provincia], [descripcion], [estado_domicilio]) VALUES (3, N'garica de cossio', 3400, 2310, N'corrientes', N'corrientes', N'es un departamento,domicilio en el primer piso', 1)
INSERT [dbo].[domicilio] ([id_domicilio], [calle], [codigo_postal], [numero], [localidad], [provincia], [descripcion], [estado_domicilio]) VALUES (4, N'honduras', 3400, 2111, N'itati', N'corrientes', N'casa azul', 1)
INSERT [dbo].[domicilio] ([id_domicilio], [calle], [codigo_postal], [numero], [localidad], [provincia], [descripcion], [estado_domicilio]) VALUES (5, N'honduras', 3400, 2111, N'itati', N'corrientes', N'casa azul', 1)
INSERT [dbo].[domicilio] ([id_domicilio], [calle], [codigo_postal], [numero], [localidad], [provincia], [descripcion], [estado_domicilio]) VALUES (6, N'Belgrano', 3409, 1238, N'Corrientes', N'Corrientes', N'', 1)
INSERT [dbo].[domicilio] ([id_domicilio], [calle], [codigo_postal], [numero], [localidad], [provincia], [descripcion], [estado_domicilio]) VALUES (7, N'Cordoba', 3409, 1238, N'Corrientes', N'Corrientes', N'', 1)
INSERT [dbo].[domicilio] ([id_domicilio], [calle], [codigo_postal], [numero], [localidad], [provincia], [descripcion], [estado_domicilio]) VALUES (8, N'Mendoza', 3409, 1237, N'Corrientes', N'Corrientes', N'', 1)
SET IDENTITY_INSERT [dbo].[domicilio] OFF
SET IDENTITY_INSERT [dbo].[metodo_pago] ON 

INSERT [dbo].[metodo_pago] ([id_metodo_pago], [descripcion_metodo_pago]) VALUES (1, N'Efectivo')
INSERT [dbo].[metodo_pago] ([id_metodo_pago], [descripcion_metodo_pago]) VALUES (2, N'Visa')
INSERT [dbo].[metodo_pago] ([id_metodo_pago], [descripcion_metodo_pago]) VALUES (3, N'Mastercard')
SET IDENTITY_INSERT [dbo].[metodo_pago] OFF
SET IDENTITY_INSERT [dbo].[persona] ON 

INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (1, N'44622119', N'octavio', N'sanchez', CAST(N'2003-01-07' AS Date), N'3795058041')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (2, N'44622120', N'fernando', N'sanchez', CAST(N'2003-01-07' AS Date), N'3795058040')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (6, N'1234567890', N'Juan', N'Pérez', CAST(N'1990-01-15' AS Date), N'123-456-7890')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (7, N'9876543210', N'María', N'González', CAST(N'1985-05-20' AS Date), N'987-654-3210')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (8, N'5555555555', N'Carlos', N'Rodríguez', CAST(N'1993-09-10' AS Date), N'555-555-5555')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (9, N'1111111111', N'Ana', N'López', CAST(N'1988-03-25' AS Date), N'111-111-1111')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (10, N'9999999999', N'Pedro', N'Martínez', CAST(N'1996-07-05' AS Date), N'999-999-9999')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (11, N'7777777777', N'Luis', N'Fernández', CAST(N'1992-11-12' AS Date), N'777-777-7777')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (12, N'4444444444', N'Laura', N'Díaz', CAST(N'1987-06-30' AS Date), N'444-444-4444')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (13, N'2222222222', N'Sofía', N'Sánchez', CAST(N'1995-04-18' AS Date), N'222-222-2222')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (14, N'6666666666', N'Javier', N'Romero', CAST(N'1989-08-08' AS Date), N'666-666-6666')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (15, N'8888888888', N'Elena', N'Torres', CAST(N'1997-12-03' AS Date), N'888-888-8888')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (16, N'43266218', N'Lautaro', N'Romero', CAST(N'2001-04-27' AS Date), N'3794404040')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (17, N'43266219', N'Gerardo', N'Morales', CAST(N'1999-09-24' AS Date), N'3794414141')
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono]) VALUES (18, N'43266220', N'Rodrigo', N'Sosa', CAST(N'1990-09-24' AS Date), N'3794424242')
SET IDENTITY_INSERT [dbo].[persona] OFF
SET IDENTITY_INSERT [dbo].[producto] ON 

INSERT [dbo].[producto] ([id_producto], [nombre_producto], [descripcion_producto], [precio_compra], [precio_venta], [imagen_producto], [marca_producto], [stock_producto], [fecha_registro_producto], [estado_producto], [id_categoria]) VALUES (1, N'Manzanas', N'Manzanas frescas', 1.5, 2, N'manzanas.jpg', N'Manzana Inc.', 100, CAST(N'2023-09-01' AS Date), 1, 1)
INSERT [dbo].[producto] ([id_producto], [nombre_producto], [descripcion_producto], [precio_compra], [precio_venta], [imagen_producto], [marca_producto], [stock_producto], [fecha_registro_producto], [estado_producto], [id_categoria]) VALUES (2, N'Arroz', N'Arroz de grano largo', 2, 3.5, N'arroz.jpg', N'Arroces S.A.', 200, CAST(N'2023-09-01' AS Date), 1, 2)
INSERT [dbo].[producto] ([id_producto], [nombre_producto], [descripcion_producto], [precio_compra], [precio_venta], [imagen_producto], [marca_producto], [stock_producto], [fecha_registro_producto], [estado_producto], [id_categoria]) VALUES (3, N'Leche', N'Leche desnatada', 1, 1.75, N'leche.jpg', N'Productos Lácteos', 150, CAST(N'2023-09-01' AS Date), 1, 5)
INSERT [dbo].[producto] ([id_producto], [nombre_producto], [descripcion_producto], [precio_compra], [precio_venta], [imagen_producto], [marca_producto], [stock_producto], [fecha_registro_producto], [estado_producto], [id_categoria]) VALUES (4, N'Jabón', N'Jabón de manos', 0.5, 1, N'jabon.jpg', N'Productos de Limpieza', 300, CAST(N'2023-09-01' AS Date), 1, 9)
INSERT [dbo].[producto] ([id_producto], [nombre_producto], [descripcion_producto], [precio_compra], [precio_venta], [imagen_producto], [marca_producto], [stock_producto], [fecha_registro_producto], [estado_producto], [id_categoria]) VALUES (5, N'Galletas', N'Galletas de chocolate', 1.2, 2.5, N'galletas.jpg', N'Galletas Inc.', 120, CAST(N'2023-09-01' AS Date), 1, 6)
INSERT [dbo].[producto] ([id_producto], [nombre_producto], [descripcion_producto], [precio_compra], [precio_venta], [imagen_producto], [marca_producto], [stock_producto], [fecha_registro_producto], [estado_producto], [id_categoria]) VALUES (6, N'Pescado', N'Filetes de pescado', 3, 4.5, N'pescado.jpg', N'Pescados S.A.', 80, CAST(N'2023-09-01' AS Date), 1, 4)
INSERT [dbo].[producto] ([id_producto], [nombre_producto], [descripcion_producto], [precio_compra], [precio_venta], [imagen_producto], [marca_producto], [stock_producto], [fecha_registro_producto], [estado_producto], [id_categoria]) VALUES (7, N'Refresco', N'Refresco de cola', 1.25, 2, N'refresco.jpg', N'Bebidas Inc.', 240, CAST(N'2023-09-01' AS Date), 1, 7)
INSERT [dbo].[producto] ([id_producto], [nombre_producto], [descripcion_producto], [precio_compra], [precio_venta], [imagen_producto], [marca_producto], [stock_producto], [fecha_registro_producto], [estado_producto], [id_categoria]) VALUES (8, N'Tomates', N'Tomates frescos', 1, 1.75, N'tomates.jpg', N'Agricultura Orgánica', 180, CAST(N'2023-09-01' AS Date), 1, 1)
INSERT [dbo].[producto] ([id_producto], [nombre_producto], [descripcion_producto], [precio_compra], [precio_venta], [imagen_producto], [marca_producto], [stock_producto], [fecha_registro_producto], [estado_producto], [id_categoria]) VALUES (9, N'Papel Higiénico', N'Papel higiénico de calidad', 0.8, 1.5, N'papel.jpg', N'Productos de Papel', 400, CAST(N'2023-09-01' AS Date), 1, 9)
INSERT [dbo].[producto] ([id_producto], [nombre_producto], [descripcion_producto], [precio_compra], [precio_venta], [imagen_producto], [marca_producto], [stock_producto], [fecha_registro_producto], [estado_producto], [id_categoria]) VALUES (10, N'Cerveza', N'Cerveza artesanal', 2.5, 4, N'cerveza.jpg', N'Cervecería Artesana', 60, CAST(N'2023-09-01' AS Date), 1, 7)
SET IDENTITY_INSERT [dbo].[producto] OFF
SET IDENTITY_INSERT [dbo].[rol] ON 

INSERT [dbo].[rol] ([id_rol], [descripcion_rol], [estado_rol]) VALUES (1, N'Administrador', 1)
INSERT [dbo].[rol] ([id_rol], [descripcion_rol], [estado_rol]) VALUES (2, N'Gerente', 1)
INSERT [dbo].[rol] ([id_rol], [descripcion_rol], [estado_rol]) VALUES (3, N'Vendedor', 1)
SET IDENTITY_INSERT [dbo].[rol] OFF
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([id_usuario], [email], [password], [fecha_registro], [estado_usuario], [id_persona], [id_rol], [id_domicilio]) VALUES (1, N'octavio@gmail.com', N'1', CAST(N'2023-09-24' AS Date), 1, 1, 1, 1)
INSERT [dbo].[usuario] ([id_usuario], [email], [password], [fecha_registro], [estado_usuario], [id_persona], [id_rol], [id_domicilio]) VALUES (2, N'lautaro@gmail.com', N'1', CAST(N'2023-09-24' AS Date), 1, 2, 2, 2)
INSERT [dbo].[usuario] ([id_usuario], [email], [password], [fecha_registro], [estado_usuario], [id_persona], [id_rol], [id_domicilio]) VALUES (6, N'romerolautaro@gmail.com', N'$2a$11$mXjOvkUutHcwStg8/Le/WuhuGxWcNzBkAy61u7ew1KyNi2xk7q7eu', CAST(N'2023-10-02' AS Date), 1, 16, 3, 6)
INSERT [dbo].[usuario] ([id_usuario], [email], [password], [fecha_registro], [estado_usuario], [id_persona], [id_rol], [id_domicilio]) VALUES (7, N'gerente@gmail.com', N'$2a$11$AJ0rbFXXf8UDspgMBtJ/Xe5t1ajMzWjGIUFenxVq5Yq1KBV/qqZ36', CAST(N'2023-10-02' AS Date), 1, 17, 2, 7)
INSERT [dbo].[usuario] ([id_usuario], [email], [password], [fecha_registro], [estado_usuario], [id_persona], [id_rol], [id_domicilio]) VALUES (8, N'administrador@gmail.com', N'$2a$11$obRc7vK5Kj53IFcriEa9l..A5BatI1iyTUM.Q.kzenkWtHiXDa9By', CAST(N'2023-10-02' AS Date), 1, 18, 1, 8)
SET IDENTITY_INSERT [dbo].[usuario] OFF
SET IDENTITY_INSERT [dbo].[venta] ON 

INSERT [dbo].[venta] ([id_venta], [venta_fecha], [id_cliente], [id_metodo_pago], [id_usuario]) VALUES (21, CAST(N'2023-09-01' AS Date), 1, 1, 1)
INSERT [dbo].[venta] ([id_venta], [venta_fecha], [id_cliente], [id_metodo_pago], [id_usuario]) VALUES (22, CAST(N'2023-09-02' AS Date), 2, 2, 1)
INSERT [dbo].[venta] ([id_venta], [venta_fecha], [id_cliente], [id_metodo_pago], [id_usuario]) VALUES (25, CAST(N'2023-09-05' AS Date), 1, 2, 1)
INSERT [dbo].[venta] ([id_venta], [venta_fecha], [id_cliente], [id_metodo_pago], [id_usuario]) VALUES (26, CAST(N'2023-09-06' AS Date), 2, 1, 1)
INSERT [dbo].[venta] ([id_venta], [venta_fecha], [id_cliente], [id_metodo_pago], [id_usuario]) VALUES (29, CAST(N'2023-09-09' AS Date), 1, 3, 1)
INSERT [dbo].[venta] ([id_venta], [venta_fecha], [id_cliente], [id_metodo_pago], [id_usuario]) VALUES (30, CAST(N'2023-09-10' AS Date), 2, 2, 1)
INSERT [dbo].[venta] ([id_venta], [venta_fecha], [id_cliente], [id_metodo_pago], [id_usuario]) VALUES (31, CAST(N'2023-09-30' AS Date), 7, 1, 2)
SET IDENTITY_INSERT [dbo].[venta] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_dni]    Script Date: 11/10/2023 11:38:33 ******/
ALTER TABLE [dbo].[persona] ADD  CONSTRAINT [UQ_dni] UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_dni_proveedor]    Script Date: 11/10/2023 11:38:33 ******/
ALTER TABLE [dbo].[proveedor] ADD  CONSTRAINT [UQ_dni_proveedor] UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_email]    Script Date: 11/10/2023 11:38:33 ******/
ALTER TABLE [dbo].[usuario] ADD  CONSTRAINT [UQ_email] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK_cliente_persona] FOREIGN KEY([id_persona])
REFERENCES [dbo].[persona] ([id_persona])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_cliente_persona]
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [FK_compra_proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[proveedor] ([id_proveedor])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [FK_compra_proveedor]
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [FK_compra_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [FK_compra_usuario]
GO
ALTER TABLE [dbo].[detalle_compra]  WITH CHECK ADD  CONSTRAINT [FK_detalle_compra_compra] FOREIGN KEY([id_compra])
REFERENCES [dbo].[compra] ([id_compra])
GO
ALTER TABLE [dbo].[detalle_compra] CHECK CONSTRAINT [FK_detalle_compra_compra]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id_producto])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_producto]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_venta] FOREIGN KEY([id_venta])
REFERENCES [dbo].[venta] ([id_venta])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_venta]
GO
ALTER TABLE [dbo].[permiso]  WITH CHECK ADD  CONSTRAINT [FK_permiso_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[permiso] CHECK CONSTRAINT [FK_permiso_usuario]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_categoria]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_domicilio] FOREIGN KEY([id_domicilio])
REFERENCES [dbo].[domicilio] ([id_domicilio])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_domicilio]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_persona] FOREIGN KEY([id_persona])
REFERENCES [dbo].[persona] ([id_persona])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_persona]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_rol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[rol] ([id_rol])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_rol]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_venta_cliente]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_metodo_pago] FOREIGN KEY([id_metodo_pago])
REFERENCES [dbo].[metodo_pago] ([id_metodo_pago])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_venta_metodo_pago]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_venta_usuario]
GO
/****** Object:  StoredProcedure [dbo].[SP_CategoriasMasVendidas]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CategoriasMasVendidas]
AS
	select categoria.nombre_categoria, COUNT(categoria.id_categoria) AS CategoriaMasVendida 
		from detalle_venta
		inner join producto ON detalle_venta.id_producto = producto.id_producto
		inner join categoria ON producto.id_categoria = categoria.id_categoria
		group by producto.id_categoria, categoria.nombre_categoria
		order by CategoriaMasVendida DESC
GO
/****** Object:  StoredProcedure [dbo].[SP_DARALTACATEGORIA]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DARALTACATEGORIA](
--estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a editar la categoria
@Id_Categoria int,

--estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida
@Resultado int output,
@Mensaje VARCHAR(500) output
)
AS
BEGIN 
	SET @Resultado=1	/*aca seteo con un valor inicial mi var de salida ,0 es false 1 true*/
	set @Mensaje='' /*proporciona informacion sobre la oepracion*/
	declare @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	
	IF EXISTS(SELECT * FROM categoria c
	WHERE c.id_categoria=@Id_Categoria AND c.estado_categoria=1
	)
	BEGIN 
		SET @Resultado=0 --seteo el resultado a =0 para que cuando lo reciba en mi programa pueda saber que fallo la validacion com oresultado es una var de salidad output
		SET @Mensaje= ' La Categoria ya se encuentra daba de ALTA'
		SET @validacion=0 --cambio el valor de validacion a 0 ya que asi determino que la validacion fue por el caso false
	END

	IF NOT EXISTS (SELECT * FROM categoria c
	WHERE c.id_categoria= @Id_Categoria)
	BEGIN 
		SET @Resultado=0 --seteo el resultado a =0 para que cuando lo reciba en mi programa pueda saber que fallo la validacion com oresultado es una var de salidad output
		SET @Mensaje= ' La Categoria NO existe en la Base de Datos'
		SET @validacion=0 --cambio el valor de validacion a 0 ya que asi determino que la validacion fue por el caso false
	END


	IF(@validacion=1)
	BEGIN 
		-- busca el registro en la tabla categoria cuyo id_categoria coincide con el valor que proporcionas en el parámetro @id_categoria, y luego actualiza ese registro estableciendo su estado_categoria en 0
		update categoria set
		estado_categoria=0
		WHERE id_categoria = @Id_Categoria; 
		set @Resultado=1 /*la BAJA del usuario fue correcta */
		SET @Mensaje = 'EL USUARIO SE DIO DE alta CORRECTAMENTE.'
	END
	ELSE
    BEGIN
         SET @mensaje = 'Error al realizar la Alta de la categoria. Intente nuevamente.'
          
    END

END

GO
/****** Object:  StoredProcedure [dbo].[SP_DARALTAUSUARIO]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DARALTAUSUARIO](
@id_usuario int,
@respuesta bit output,
@mensaje varchar (500) output
)
as
begin 
	set @respuesta = 0 /*aca seteo con un valor inicial mi var de salida ,0 es false 1 true*/
	set @mensaje='' /*proporciona informacion sobre la oepracion*/
	declare @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	if EXISTS (SELECT * FROM usuario u
	 where u.id_usuario=@id_usuario AND u.estado_usuario=1
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL USUARIO YA SE ENCUENTRA DADO DE ALTA NOSE PUEDE DAR DE ALTA DE NUEVO\n' 
	END

	if NOT EXISTS (SELECT * FROM usuario u
	 where u.id_usuario=@id_usuario 
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL USUARIO NO EXISTE EN LA BASE DE DATOS \n' 
	END

	if(@validacion = 1)
	begin
	-- busca el registro en la tabla usuario cuyo id_usuario coincide con el valor que proporcionas en el parámetro @id_usuario, y luego actualiza ese registro estableciendo su estado_usuario en 0
		update usuario set
		estado_usuario=1
		WHERE id_usuario = @id_usuario; 
		set @respuesta=1 /*la BAJA del usuario fue correcta */
		SET @mensaje = 'EL USUARIO SE DIO DE ALTA CORRECTAMENTE.'
	end
	else
    BEGIN
         SET @mensaje = 'Error al realizar la Alta del usuario. Intente nuevamente.'
          
    end

end

GO
/****** Object:  StoredProcedure [dbo].[SP_DARBAJACATEGORIA]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DARBAJACATEGORIA](
--estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a editar la categoria
@Id_Categoria int,

--estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida
@Resultado int output,
@Mensaje VARCHAR(500) output
)
AS
BEGIN 
	SET @Resultado=1	/*aca seteo con un valor inicial mi var de salida ,0 es false 1 true*/
	set @Mensaje='' /*proporciona informacion sobre la oepracion*/
	declare @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	
	IF EXISTS(SELECT * FROM categoria c
	WHERE c.id_categoria=@Id_Categoria AND c.estado_categoria=0
	)
	BEGIN 
		SET @Resultado=0 --seteo el resultado a =0 para que cuando lo reciba en mi programa pueda saber que fallo la validacion com oresultado es una var de salidad output
		SET @Mensaje= ' La Categoria ya se encuentra daba de BAJA'
		SET @validacion=0 --cambio el valor de validacion a 0 ya que asi determino que la validacion fue por el caso false
	END

	IF NOT EXISTS (SELECT * FROM categoria c
	WHERE c.id_categoria= @Id_Categoria)
	BEGIN 
		SET @Resultado=0 --seteo el resultado a =0 para que cuando lo reciba en mi programa pueda saber que fallo la validacion com oresultado es una var de salidad output
		SET @Mensaje= ' La Categoria NO existe en la Base de Datos'
		SET @validacion=0 --cambio el valor de validacion a 0 ya que asi determino que la validacion fue por el caso false
	END

	IF EXISTS (SELECT * FROM categoria c
	INNER JOIN producto p on p.id_categoria= c.id_categoria
	where c.id_categoria = @Id_Categoria)
	BEGIN 
		SET @Resultado=0 --seteo el resultado a =0 para que cuando lo reciba en mi programa pueda saber que fallo la validacion com oresultado es una var de salidad output
		SET @Mensaje= ' La Categoria Ya esta vinculado a un Producto, No se Puede Dar de Baja'
		SET @validacion=0 --cambio el valor de validacion a 0 ya que asi determino que la validacion fue por el caso false
	END

	IF(@validacion=1)
	BEGIN 
		-- busca el registro en la tabla categoria cuyo id_categoria coincide con el valor que proporcionas en el parámetro @id_categoria, y luego actualiza ese registro estableciendo su estado_categoria en 0
		update categoria set
		estado_categoria=0
		WHERE id_categoria = @Id_Categoria; 
		set @Resultado=1 /*la BAJA del usuario fue correcta */
		SET @Mensaje = 'EL USUARIO SE DIO DE BAJA CORRECTAMENTE.'
	END
	ELSE
    BEGIN
         SET @mensaje = 'Error al realizar la BAJA de la categoria. Intente nuevamente.'
          
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DASHBOARDDATOS]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DASHBOARDDATOS]
--defino parametros de salida en los cuales voy a guardar el resultado de la consulta a cada tab;la sobre la cantidad de elementos de mi tabla para mi dashboard y el total de la venta en el dia

@numeroDeProducto int out,
@numeroDeCategoria int out,
@numeroDeCliente int out,
@numeroDeProveedor int out,
@numeroDeEmpleado int out,

@mensaje varchar(500) output/*estE parametrO me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) un mensaje de salida*/

as
BEGIN
	BEGIN TRY
		--con set asigno ese valor de la consulta a mi varibale de salida o parametro de salida que defini anteriormente

		 -- Obtener la cantidad de productos
		set @numeroDeProducto=(select count(id_producto) as cantidadProducto from producto) --con el count obtengo la cantidad de registro que tiene ese campo es decri la cantidad de elemento que posee dicho cmpo
 
		-- Obtener la cantidad de categorías
		set @numeroDeCategoria=(select count(id_categoria) as cantidadCategoria from categoria)

		 -- Obtener la cantidad de clientes
		set @numeroDeCliente=(select count(id_cliente) as cantidadCliente from cliente)

		 -- Obtener la cantidad de proveedores
		set @numeroDeProveedor=(select count(id_proveedor) as cantidadProveedor from proveedor)

		 -- Obtener la cantidad de empleados
		set @numeroDeEmpleado=(select count(id_usuario) as cantidadEmpleado from usuario)
	END TRY
	BEGIN CATCH
			set @mensaje = 'No se puedo obtener los datos para el inicio'
	END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_DatosDelNegocio]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DatosDelNegocio]
	@nroVentas INT OUT,
	@totalRecaudado FLOAT OUT,
	@nroClientes INT OUT,
	@nroEmpleado INT OUT,
	@nroProveedores INT OUT,
	@nroProductos INT OUT
AS
	set @nroVentas = ( select COUNT(id_venta) AS totalVentas FROM venta )
	set @totalRecaudado = ( select SUM(subtotal_detalle_venta) AS totalRecaudado FROM detalle_venta )
	set @nroClientes = ( select COUNT(id_cliente) AS numeroClientes FROM cliente )
	set @nroEmpleado = ( select COUNT(id_usuario) AS numeroEmpleados FROM usuario )
	set @nroProveedores = ( select COUNT(id_proveedor) AS numeroProveedores FROM proveedor )
	set @nroProductos = ( select COUNT(id_producto)  AS TotalProductos FROM producto )
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARCATEGORIA]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_EDITARCATEGORIA](
--estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a editar la categoria
@Id_Categoria int,
@Nombre_categoria VARCHAR(50),
@Estado_categoria bit,

--estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida
@Resultado int output,
@Mensaje VARCHAR(500) output
)
AS
BEGIN 
	SET @Resultado=1
	IF NOT EXISTS(SELECT * FROM categoria WHERE nombre_categoria=@Nombre_categoria AND id_categoria != @Id_Categoria)
		UPDATE categoria SET
		nombre_categoria=@Nombre_categoria,
		estado_categoria=@Estado_categoria
		WHERE id_categoria = @Id_Categoria
	ELSE
	BEGIN
		SET @Resultado=0
		SET @Mensaje= 'No se puede repetir el Nombre de la Categoria debe de ser UNICO'
	END
END

GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARUSUARIO]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_EDITARUSUARIO](
/*definimos los  parametros de entrada que el procedimiento espera recibir,que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a editar*/
		@id_usuario int,
		@dni varchar(100),
		@nombre varchar(100),
		@apellido varchar(100),
		@fecha_nacimiento date,
		@telefono varchar(100),
		@email varchar(200),
		@password varchar(150),
		@estado_usuario bit,
		@id_rol int,
		@id_domicilio int,
		@respuesta bit output,/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso la Rpespuesta que es 1 o 0 y un mensaje de salida*/
		@mensaje varchar(500) output

)
as 
begin 
	set @respuesta = 0 /*aca seteo con un valor inicial mi var de salida ,0 es false 1 true*/
	set @mensaje='' /*proporciona informacion sobre la oepracion*/

	DECLARE @id_persona int --declaro una variable entera llamda id_persona que va a contener el id_persona a editar asi podre acceder a ese registro de la tabla persona
	SELECT @id_persona=id_persona FROM usuario WHERE id_usuario=@id_usuario --aca obtengo el id_persona relacionadop con el uusario que se esta editando por eso digo que el id_persona de ese id_usuairo que se busca que se guarde en esa variable @id_persona

	/*aca verifico que si se encontro un id_persona valido es decir que si ese id_persona no es null que entre al if */
	if (@id_persona IS NOT NULL)-- Verificamos si se encontró un id_persona
		begin 
			/*aca digo que sino exitse una persona en la tabla persona con el dni que quiero editar SINO existe que entre al if ya que significa que ese dni no existe que esta disponible y que sea diferencite el mismo usuario que estoiy editando es decir que mita al usuario que estoy editando para que no me tome el dni del queestoy editando para el error*/
			/*es decir verificar si ya existe una persona en la tabla 'persona' con el mismo 'dni', pero con un 'id_persona' diferente al que se está editando. Esto es importante para asegurarse de que el 'dni' sea único, excepto para cada persona que se está editando. Si la validación es verdadera (es decir, no existe un usuario con el mismo 'dni' que no sea el que se está editando), se procede a realizar la actualización de los datos de la persona y luego del usuario.*/
			if not exists (select * from persona where dni =@dni and id_persona != @id_persona) 
				begin 
				 /* Actualiza la información en la tabla 'persona' */
					update persona 
					set
					nombre = @nombre,
					apellido = @apellido,
					dni = @dni,
					fecha_nacimiento=@fecha_nacimiento,
					telefono = @telefono
					where id_persona=@id_persona

					 /* Actualiza la información en la tabla 'usuario' despues de actualizar la tabla persona*/
					update usuario 
					set
					email = @email,
					password=@password,
					estado_usuario=@estado_usuario,
					id_persona=@id_persona,
					id_rol=@id_rol,
					id_domicilio=@id_domicilio
					where id_usuario=@id_usuario

					set @mensaje = 'el usuario se edito correctamente'
					set @respuesta=1/* Cambiamos la variable de respuesta a 1, lo que equivale a "true" */
				end
			else
				set @mensaje = 'No se puede repetir el documento para mas de un usuario debe de ser UNICO'

			end
	else
		set @mensaje = 'No se encontro ninguna persona con esos datos,No podemos editar el usuario'

end

GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARUSUARIO]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ELIMINARUSUARIO](
@id_usuario int,
@respuesta bit output,
@mensaje varchar (500) output
)
as
begin 
	set @respuesta = 0 /*aca seteo con un valor inicial mi var de salida ,0 es false 1 true*/
	set @mensaje='' /*proporciona informacion sobre la oepracion*/
	declare @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	/*eliminamos un usuario pero solo sino esta relacionado a compras de proveedores o alguna venta ya que si en algun momento quieor ver el historial de esas tablas voy a tener conflictos ya que el usuario que las hizo no existe mas */
	if EXISTS (SELECT * FROM venta v
	INNER JOIN usuario u on u.id_usuario = v.id_usuario
	where u.id_usuario =@id_usuario
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL USUARIO SE ENCUENTRA RELACIONADO A UNA VENTA NOSE PUEDE ELIMINAR\n' 
	END

	/*este seria la validacion para la compra pero como no cree esa tabla la dejo comentado
	if EXISTS (SELECT * FROM compra c
	INNER JOIN usuario u on u.id_usuario = c.id_usuario
	where u.id_usuario =@id_usuario
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0 /*no paso las reglas significa es decir no puedo eliminar */
		set @mensaje='EL USUARIO SE ENCUENTRA RELACIONADO A UNA COMPRA NOSE PUEDE ELIMINAR\' 
	END
	*/

	if(@validacion = 1)
	begin
		delete from usuario where id_usuario = @id_usuario
		set @respuesta=1 /*la eliminacion del usuario fue correcta */
		set @mensaje='El usuario se dio de Baja Correctamente\n' 
	end


end

GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARUSUARIOLOGICO]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ELIMINARUSUARIOLOGICO](
/*definimos los  parametros de entrada que el procedimiento espera recibir,que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a editar*/
	@id_usuario int,
	@respuesta bit output,/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso la Rpespuesta que es 1 o 0 y un mensaje de salida*/
	@mensaje varchar(500) output
)
as 
begin 
	set @respuesta = 0 /*aca seteo con un valor inicial mi var de salida ,0 es false 1 true*/
	set @mensaje='' /*proporciona informacion sobre la oepracion*/
	declare @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	/*aca digo que sino exitse un usuario en la tabla usuario con el dni que quiero editar SINO existe que entre al if ya que significa que ese dni no existe que esta disponible y que sea diferencite el mismo usuario que estoiy editando es decir que mita al usuario que estoy editando para que no me tome el dni del queestoy editando para el error*/
	/*es decir verificar si ya existe un usuario en la tabla 'usuario' con el mismo 'dni', pero con un 'id_usuario' diferente al que se está editando. Esto es importante para asegurarse de que el 'dni' sea único, excepto para el usuario que se está editando. Si la validación es verdadera (es decir, no existe un usuario con el mismo 'dni' que no sea el que se está editando), se procede a realizar la actualización de los datos del usuario.*/
	/*eliminamos un usuario pero solo sino esta relacionado a compras de proveedores o alguna venta ya que si en algun momento quieor ver el historial de esas tablas voy a tener conflictos ya que el usuario que las hizo no existe mas */
	if EXISTS (SELECT * FROM usuario u
	 where u.id_usuario=@id_usuario AND u.estado_usuario=0
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL USUARIO YA SE ENCUENTRA DADO DE BAJA NOSE PUEDE DAR DE BAJA DE NUEVO\n' 
	END

	if NOT EXISTS (SELECT * FROM usuario u
	 where u.id_usuario=@id_usuario 
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL USUARIO NO EXISTE EN LA BASE DE DATOS \n' 
	END

	if(@validacion = 1)
	begin
	-- busca el registro en la tabla usuario cuyo id_usuario coincide con el valor que proporcionas en el parámetro @id_usuario, y luego actualiza ese registro estableciendo su estado_usuario en 0
		update usuario set
		estado_usuario=0
		WHERE id_usuario = @id_usuario; 
		set @respuesta=1 /*la BAJA del usuario fue correcta */
		SET @mensaje = 'EL USUARIO SE DIO DE BAJA CORRECTAMENTE.'
	end
	else
    BEGIN
         SET @mensaje = 'Error al realizar la baja del usuario. Intente nuevamente.'
          
    end

end

GO
/****** Object:  StoredProcedure [dbo].[SP_ListarVentas]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarVentas]

AS
SELECT venta.id_venta AS ID_Venta, 
	   venta.venta_fecha AS Fecha,
	   persona.apellido+' '+persona.nombre AS Cliente, 
	   metodo_pago.descripcion_metodo_pago AS Metodo_pago,
	   usuario.email AS Vendedor
FROM venta

	inner join cliente on cliente.id_cliente = venta.id_cliente
	inner join persona on persona.id_persona = cliente.id_persona
	inner join usuario on usuario.id_usuario = venta.id_usuario
	inner join metodo_pago on metodo_pago.id_metodo_pago = venta.id_metodo_pago

ORDER BY venta.id_venta

GO
/****** Object:  StoredProcedure [dbo].[SP_ProductosMasVendidos]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ProductosMasVendidos]
AS
select TOP 5 producto.marca_producto+' - '+ producto.descripcion_producto as Producto, count(detalle_venta.id_producto) as Cantidad_vendida
	from detalle_venta
	inner join producto on detalle_venta.id_producto = producto.id_producto
	inner join categoria on categoria.id_categoria = producto.id_categoria
	group by detalle_venta.id_producto, producto.marca_producto, producto.descripcion_producto
	order by Cantidad_vendida DESC
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARCATEGORIA]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARCATEGORIA](
--estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar la categoria
@Nombre_categoria VARCHAR(50),
@Estado_categoria bit,

--estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
@Resultado int output,
@Mensaje VARCHAR(500) output
)as
begin 
	SET @Resultado=0 /*aca seteo con un valor inicial mi var de salida*/

	--aca digo que sino exitse un nombre_categoria en la tabla categoria con el mismo nombre_categoria que quiero registrar SINO existe que entre al if ya que significa que ese nombre_categoria todavia no existe 'que esta disponible' 
	IF NOT EXISTS (SELECT * FROM categoria WHERE nombre_categoria=@Nombre_categoria)
	BEGIN 
		--Inserto en mi tabla categoria los valores que el usuario me paso como parametro y que se valdiaron correctamente que no existe en la BD el mismo nombre_categoria
		INSERT INTO categoria(nombre_categoria,estado_categoria) 
		VALUES(@Nombre_categoria,@Estado_categoria)
		SET @Resultado= SCOPE_IDENTITY()-- Obtener el ID de la categoria recién insertada y lo asigno o guardo en mi parametro de salida resultado
		SET @Mensaje= 'La categoria se registro de manera correcta'

	END
	ELSE
		SET @Mensaje= 'No se puede repetir el Nombre de la Categoria debe de ser UNICO'

END

GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARDOMICILIO]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARDOMICILIO](
@calle varchar(200),
@codigo_postal int,
@numero int,
@localidad varchar(100),
@provincia varchar(100),
@descripcion varchar(100),
@estado_domicilio bit ,
@id_domicilio_resultado int output,/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
@mensaje varchar(500) output
)
AS
BEGIN 
	SET @id_domicilio_resultado=0
	SET @mensaje=''

	--verificamos si el domicilio que se quiere ingresar ya no existe en la base de datos
	--aca selecciono la tabla domciilio y busco la calle que se ingreso y el numero que se ingreso ,si esta en la base de datos cargada , si esto es asi que no entre en el if ya que sino existen esos datos ahi entraria al if
	IF NOT EXISTS(SELECT * FROM domicilio WHERE calle=@calle AND numero=@numero)
	BEGIN
	--Insertamos el nuevo domicilio en la tabla Domicilio
	INSERT INTO domicilio(calle,codigo_postal,numero,localidad,provincia,descripcion,estado_domicilio)
	VALUES(@calle,@codigo_postal,@numero,@localidad,@provincia,@descripcion,@estado_domicilio)

	--obtenemos el ID del domicilio registrado 
	SET @id_domicilio_resultado=SCOPE_IDENTITY()

	--mensaje de exito si se inserto correctamente
	SET @mensaje='Domicilio registrado correctamente'
	END
	ELSE
	BEGIN
	--Mensaje de error en caso de que el domicilio ya exista en la base de datos
		SET @mensaje='el domicilio ya existe, ya esta registrado'
	END

END
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARUSUARIO]    Script Date: 11/10/2023 11:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARUSUARIO](
/*estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar*/
		@dni varchar(100),
		@nombre varchar(100),
		@apellido varchar(100),
		@fecha_nacimiento date,
		@telefono varchar(100),
		@email varchar(200),
		@password varchar(150),
		@estado_usuario bit,
		@id_rol int,
		@id_domicilio int,
		@id_Usuario_resultado int output,/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
		@mensaje varchar(500) output
)
as 
begin 
	set @id_Usuario_resultado = 0 /*aca seteo con un valor inicial mi var de salida*/
	set @mensaje=''

	/*aca digo que sino exitse una persona en la tabla persona con el dni que quiero registrar SINO existe que entre al if ya que significa que ese dni no existe que esta disponible*/
	if not exists (select * from persona where dni =@dni)
	begin 
		 /* Verificar si el correo electrónico ya está en uso ya que este debe de ser unico*/
			IF NOT EXISTS (SELECT * FROM usuario WHERE email = @email)
			BEGIN 
				-- Insertar en la tabla Persona una persona con los datos que recibi de mi form de registrar como parametro
				INSERT INTO Persona ( dni,nombre, apellido, fecha_nacimiento,telefono)
				VALUES (@dni,@nombre, @apellido,@fecha_nacimiento, @telefono)

				-- Obtener el ID de la persona recién insertada
				DECLARE @id_persona INT
				SET @id_persona = SCOPE_IDENTITY()

				--insertar en la tabla usuario relacionando la persona que inserte anteriormente con un usuario
				insert into usuario(email,password,fecha_registro,estado_usuario,id_persona,id_rol,id_domicilio) 
				values(@email,@password,GETDATE(),@estado_usuario,@id_persona,@id_rol,@id_domicilio)

				set @mensaje = 'el usuario se registro correctamente'
				set @id_Usuario_resultado = SCOPE_IDENTITY()/*si se inserto esta funcion me alamcena el id del usuario que se inserto o genero)*/
			end
			else
				SET @mensaje = 'El correo electrónico ya está en uso, debe ser único'
	end
	else
		set @mensaje = 'No se puede repetir el documento para mas de un usuario debe de ser UNICO'

end

GO
USE [master]
GO
ALTER DATABASE [BD_Prueba] SET  READ_WRITE 
GO
