USE [master]
GO
/****** Object:  Database [BD_CeliMarket]    Script Date: 14/10/2023 12:53:11 ******/
CREATE DATABASE [BD_CeliMarket]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_CeliMarket', FILENAME = N'C:\SQLData\MSSQL16.MSSQLSERVER\MSSQL\DATA\BD_CeliMarket.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD_CeliMarket_log', FILENAME = N'C:\SQLData\MSSQL16.MSSQLSERVER\MSSQL\DATA\BD_CeliMarket_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BD_CeliMarket] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_CeliMarket].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_CeliMarket] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_CeliMarket] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_CeliMarket] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BD_CeliMarket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_CeliMarket] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET RECOVERY FULL 
GO
ALTER DATABASE [BD_CeliMarket] SET  MULTI_USER 
GO
ALTER DATABASE [BD_CeliMarket] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_CeliMarket] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_CeliMarket] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_CeliMarket] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD_CeliMarket] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_CeliMarket] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BD_CeliMarket', N'ON'
GO
ALTER DATABASE [BD_CeliMarket] SET QUERY_STORE = ON
GO
ALTER DATABASE [BD_CeliMarket] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BD_CeliMarket]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre_categoria] [varchar](200) NOT NULL,
	[descripcion_categoria] [varchar](200) NULL,
	[estado_categoria] [bit] NOT NULL,
	[fecha_creacion] [date] NOT NULL,
 CONSTRAINT [PK_id_categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[estado_cliente] [bit] NOT NULL,
	[id_persona] [int] NOT NULL,
	[fecha_creacion_cliente] [date] NOT NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compra]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compra](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[fecha_registro] [date] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[fecha_creacion_compra] [date] NOT NULL,
 CONSTRAINT [PK_compra] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_compra]    Script Date: 14/10/2023 12:53:11 ******/
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
	[fecha_creacion_detalle_compra] [date] NOT NULL,
 CONSTRAINT [PK_detalle_compra] PRIMARY KEY CLUSTERED 
(
	[id_detalle_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_venta]    Script Date: 14/10/2023 12:53:11 ******/
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
	[fecha_creacion_detalle_venta] [date] NOT NULL,
 CONSTRAINT [PK_detalle_venta] PRIMARY KEY CLUSTERED 
(
	[id_detalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[domicilio]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[domicilio](
	[id_domicilio] [int] IDENTITY(1,1) NOT NULL,
	[codigo_postal] [int] NOT NULL,
	[localidad] [varchar](100) NOT NULL,
	[provincia] [varchar](100) NOT NULL,
	[numero] [int] NOT NULL,
	[calle] [varchar](200) NOT NULL,
	[descripcion_domicilio] [varchar](100) NULL,
	[estado_domicilio] [bit] NOT NULL,
	[fecha_creacion] [date] NOT NULL,
 CONSTRAINT [PK_domicilio] PRIMARY KEY CLUSTERED 
(
	[id_domicilio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[Id_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[fecha_creacion] [date] NOT NULL,
 CONSTRAINT [PK_Id_Marca] PRIMARY KEY CLUSTERED 
(
	[Id_Marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[metodo_pago]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[metodo_pago](
	[id_metodo_pago] [int] IDENTITY(1,1) NOT NULL,
	[nombre_metodo_pago] [varchar](50) NOT NULL,
	[cuota_posible] [int] NOT NULL,
	[recargo_por_cuota] [decimal](10, 2) NOT NULL,
	[estado_metodo_pago] [bit] NOT NULL,
	[fecha_creacion] [date] NOT NULL,
	[id_tipo_metodo_pago] [int] NOT NULL,
 CONSTRAINT [PK_Metodo_pago] PRIMARY KEY CLUSTERED 
(
	[id_metodo_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso]    Script Date: 14/10/2023 12:53:11 ******/
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
	[fecha_creacion_permiso] [date] NOT NULL,
 CONSTRAINT [PK_permiso] PRIMARY KEY CLUSTERED 
(
	[id_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persona]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona](
	[id_persona] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](8) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[fecha_creacion] [date] NOT NULL,
 CONSTRAINT [PK_persona] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 14/10/2023 12:53:11 ******/
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
	[stock_producto] [int] NOT NULL,
	[estado_producto] [bit] NOT NULL,
	[Id_Marca] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
	[fecha_creacion_producto] [date] NOT NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[telefono] [varchar](100) NOT NULL,
	[estado_proveedor] [bit] NOT NULL,
	[fecha_creacion] [date] NOT NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[nombre_rol] [varchar](100) NOT NULL,
	[estado_rol] [bit] NOT NULL,
	[fecha_creacion] [date] NOT NULL,
 CONSTRAINT [PK_rol] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_metodo_pago]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_metodo_pago](
	[id_tipo_metodo_pago] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo_pago] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tipo_metodo_pago] PRIMARY KEY CLUSTERED 
(
	[id_tipo_metodo_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](200) NOT NULL,
	[password] [varchar](150) NOT NULL,
	[estado_usuario] [bit] NOT NULL,
	[id_persona] [int] NOT NULL,
	[id_rol] [int] NOT NULL,
	[id_domicilio] [int] NOT NULL,
	[fecha_creacion_usuario] [date] NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta]    Script Date: 14/10/2023 12:53:11 ******/
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
	[fecha_creacion_venta] [date] NOT NULL,
 CONSTRAINT [PK_venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[categoria] ON 

INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [descripcion_categoria], [estado_categoria], [fecha_creacion]) VALUES (1, N'Almacen', N'Aqui se encuentran todas las categorias', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [descripcion_categoria], [estado_categoria], [fecha_creacion]) VALUES (2, N'Frescos', N'Aqui se encuentran Los Lacteos,Pastas y Tapas,Fiambreria', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [descripcion_categoria], [estado_categoria], [fecha_creacion]) VALUES (3, N'Bebidas', N'Aqui se encuentras Aguas,Gaseosas,Jugos,Bebidas energizantes,Aperitivos y Bebidas Alcohilicas', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [descripcion_categoria], [estado_categoria], [fecha_creacion]) VALUES (4, N'Carnes', N'Aqui se encuentran la Carne vacuna,Pollo y granja,Carne de cerdo,Anchuras y embutidos', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [descripcion_categoria], [estado_categoria], [fecha_creacion]) VALUES (5, N'Frutas', N'Aqui se encuentras las Frutas cortadas y Frutos secos', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [descripcion_categoria], [estado_categoria], [fecha_creacion]) VALUES (6, N'Verduras', N'Aqui se encuentras las Verduras cortadas y ensaldas preparadas', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [descripcion_categoria], [estado_categoria], [fecha_creacion]) VALUES (7, N'Panaderia', N'Aqui se encuentras los Panificados,Pan rallado y rebozadores,Pizzas y prepizzas,Sandwiches,Empanadas y Tartas', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [descripcion_categoria], [estado_categoria], [fecha_creacion]) VALUES (8, N'Desayuno', N'Galletitas, Bizcochitos y tostadas, Yerba, Infusiones, Cerales y barritas', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [descripcion_categoria], [estado_categoria], [fecha_creacion]) VALUES (9, N'Congelados', N'Aqui se encuentras las Hamburguesas, Nuggets y reobazados, Papas, Pollos, Verduras y Frutas, Comidas y panificados, Helados y postres', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[categoria] ([id_categoria], [nombre_categoria], [descripcion_categoria], [estado_categoria], [fecha_creacion]) VALUES (10, N'prueba', N'probando', 1, CAST(N'2023-10-13' AS Date))
SET IDENTITY_INSERT [dbo].[categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[cliente] ON 

INSERT [dbo].[cliente] ([id_cliente], [estado_cliente], [id_persona], [fecha_creacion_cliente]) VALUES (1, 1, 3, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[cliente] ([id_cliente], [estado_cliente], [id_persona], [fecha_creacion_cliente]) VALUES (2, 1, 4, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[cliente] ([id_cliente], [estado_cliente], [id_persona], [fecha_creacion_cliente]) VALUES (3, 1, 7, CAST(N'2023-10-12' AS Date))
SET IDENTITY_INSERT [dbo].[cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[domicilio] ON 

INSERT [dbo].[domicilio] ([id_domicilio], [codigo_postal], [localidad], [provincia], [numero], [calle], [descripcion_domicilio], [estado_domicilio], [fecha_creacion]) VALUES (2, 3400, N'Corrientes', N'Corrientes', 2310, N'Garcia de Cossio', N'Casa con porton negro de dos pisos', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[domicilio] ([id_domicilio], [codigo_postal], [localidad], [provincia], [numero], [calle], [descripcion_domicilio], [estado_domicilio], [fecha_creacion]) VALUES (3, 3400, N'Corrientes', N'Itati', 4578, N'Honduras', N'Casa con porton gris de metal', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[domicilio] ([id_domicilio], [codigo_postal], [localidad], [provincia], [numero], [calle], [descripcion_domicilio], [estado_domicilio], [fecha_creacion]) VALUES (4, 3400, N'Corrientes', N'Corrientes', 2111, N'puyreddon', N'proton azul', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[domicilio] ([id_domicilio], [codigo_postal], [localidad], [provincia], [numero], [calle], [descripcion_domicilio], [estado_domicilio], [fecha_creacion]) VALUES (5, 3400, N'corrientes', N'correintes', 4060, N'guayana', N'puerta negra', 1, CAST(N'2023-10-13' AS Date))
SET IDENTITY_INSERT [dbo].[domicilio] OFF
GO
SET IDENTITY_INSERT [dbo].[Marca] ON 

INSERT [dbo].[Marca] ([Id_Marca], [Nombre], [fecha_creacion]) VALUES (1, N'Maizena', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[Marca] ([Id_Marca], [Nombre], [fecha_creacion]) VALUES (2, N'Exquisita', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[Marca] ([Id_Marca], [Nombre], [fecha_creacion]) VALUES (3, N'Matarazzo', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[Marca] ([Id_Marca], [Nombre], [fecha_creacion]) VALUES (4, N'MYK', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[Marca] ([Id_Marca], [Nombre], [fecha_creacion]) VALUES (5, N'Presto Pronta', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[Marca] ([Id_Marca], [Nombre], [fecha_creacion]) VALUES (6, N'Noel', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[Marca] ([Id_Marca], [Nombre], [fecha_creacion]) VALUES (7, N'La huerta', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[Marca] ([Id_Marca], [Nombre], [fecha_creacion]) VALUES (8, N'Arcor', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[Marca] ([Id_Marca], [Nombre], [fecha_creacion]) VALUES (9, N'Carrefour', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[Marca] ([Id_Marca], [Nombre], [fecha_creacion]) VALUES (10, N'Cocinero', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[Marca] ([Id_Marca], [Nombre], [fecha_creacion]) VALUES (11, N'Vicentin', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[Marca] ([Id_Marca], [Nombre], [fecha_creacion]) VALUES (12, N'Coca-Cola', CAST(N'2023-10-12' AS Date))
SET IDENTITY_INSERT [dbo].[Marca] OFF
GO
SET IDENTITY_INSERT [dbo].[metodo_pago] ON 

INSERT [dbo].[metodo_pago] ([id_metodo_pago], [nombre_metodo_pago], [cuota_posible], [recargo_por_cuota], [estado_metodo_pago], [fecha_creacion], [id_tipo_metodo_pago]) VALUES (1, N'Visa', 1, CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2023-10-12' AS Date), 2)
INSERT [dbo].[metodo_pago] ([id_metodo_pago], [nombre_metodo_pago], [cuota_posible], [recargo_por_cuota], [estado_metodo_pago], [fecha_creacion], [id_tipo_metodo_pago]) VALUES (2, N'Visa', 3, CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2023-10-12' AS Date), 2)
INSERT [dbo].[metodo_pago] ([id_metodo_pago], [nombre_metodo_pago], [cuota_posible], [recargo_por_cuota], [estado_metodo_pago], [fecha_creacion], [id_tipo_metodo_pago]) VALUES (3, N'Visa', 6, CAST(14.00 AS Decimal(10, 2)), 1, CAST(N'2023-10-12' AS Date), 2)
INSERT [dbo].[metodo_pago] ([id_metodo_pago], [nombre_metodo_pago], [cuota_posible], [recargo_por_cuota], [estado_metodo_pago], [fecha_creacion], [id_tipo_metodo_pago]) VALUES (4, N'Mastercard', 1, CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2023-10-12' AS Date), 2)
INSERT [dbo].[metodo_pago] ([id_metodo_pago], [nombre_metodo_pago], [cuota_posible], [recargo_por_cuota], [estado_metodo_pago], [fecha_creacion], [id_tipo_metodo_pago]) VALUES (5, N'Mastercard', 3, CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2023-10-12' AS Date), 2)
INSERT [dbo].[metodo_pago] ([id_metodo_pago], [nombre_metodo_pago], [cuota_posible], [recargo_por_cuota], [estado_metodo_pago], [fecha_creacion], [id_tipo_metodo_pago]) VALUES (6, N'Mastercard', 6, CAST(14.00 AS Decimal(10, 2)), 1, CAST(N'2023-10-12' AS Date), 2)
INSERT [dbo].[metodo_pago] ([id_metodo_pago], [nombre_metodo_pago], [cuota_posible], [recargo_por_cuota], [estado_metodo_pago], [fecha_creacion], [id_tipo_metodo_pago]) VALUES (7, N'Personal Pay', 1, CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2023-10-12' AS Date), 3)
INSERT [dbo].[metodo_pago] ([id_metodo_pago], [nombre_metodo_pago], [cuota_posible], [recargo_por_cuota], [estado_metodo_pago], [fecha_creacion], [id_tipo_metodo_pago]) VALUES (8, N'Mercado Pago', 1, CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2023-10-12' AS Date), 3)
INSERT [dbo].[metodo_pago] ([id_metodo_pago], [nombre_metodo_pago], [cuota_posible], [recargo_por_cuota], [estado_metodo_pago], [fecha_creacion], [id_tipo_metodo_pago]) VALUES (9, N'Visa debito', 1, CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2023-10-12' AS Date), 3)
INSERT [dbo].[metodo_pago] ([id_metodo_pago], [nombre_metodo_pago], [cuota_posible], [recargo_por_cuota], [estado_metodo_pago], [fecha_creacion], [id_tipo_metodo_pago]) VALUES (10, N'Pesos', 1, CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2023-10-12' AS Date), 1)
INSERT [dbo].[metodo_pago] ([id_metodo_pago], [nombre_metodo_pago], [cuota_posible], [recargo_por_cuota], [estado_metodo_pago], [fecha_creacion], [id_tipo_metodo_pago]) VALUES (11, N'RapiPago', 1, CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2023-10-12' AS Date), 1)
INSERT [dbo].[metodo_pago] ([id_metodo_pago], [nombre_metodo_pago], [cuota_posible], [recargo_por_cuota], [estado_metodo_pago], [fecha_creacion], [id_tipo_metodo_pago]) VALUES (12, N'PagoFacil', 1, CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2023-10-12' AS Date), 1)
SET IDENTITY_INSERT [dbo].[metodo_pago] OFF
GO
SET IDENTITY_INSERT [dbo].[persona] ON 

INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono], [fecha_creacion]) VALUES (2, N'44622119', N'octavio', N'sanchez', CAST(N'2003-01-07' AS Date), N'3795086351', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono], [fecha_creacion]) VALUES (3, N'44622120', N'fernando', N'sanchez', CAST(N'2003-01-07' AS Date), N'3795086390', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono], [fecha_creacion]) VALUES (4, N'44622121', N'virginia', N'sanchez', CAST(N'1999-06-07' AS Date), N'3794980765', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono], [fecha_creacion]) VALUES (5, N'43266218', N'Lautaro', N'Romero', CAST(N'2001-04-27' AS Date), N'3794404040', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono], [fecha_creacion]) VALUES (6, N'43266219', N'Gerardo', N'Morales', CAST(N'2006-04-27' AS Date), N'3794404041', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono], [fecha_creacion]) VALUES (7, N'43266220', N'Rodrigo', N'Gomez', CAST(N'1998-04-27' AS Date), N'3794404042', CAST(N'2023-10-12' AS Date))
INSERT [dbo].[persona] ([id_persona], [dni], [nombre], [apellido], [fecha_nacimiento], [telefono], [fecha_creacion]) VALUES (8, N'44198422', N'Milagros', N'Escalante', CAST(N'2023-01-07' AS Date), N'3373', CAST(N'2023-10-13' AS Date))
SET IDENTITY_INSERT [dbo].[persona] OFF
GO
SET IDENTITY_INSERT [dbo].[rol] ON 

INSERT [dbo].[rol] ([id_rol], [nombre_rol], [estado_rol], [fecha_creacion]) VALUES (1, N'Administrador', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[rol] ([id_rol], [nombre_rol], [estado_rol], [fecha_creacion]) VALUES (2, N'Gerente', 1, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[rol] ([id_rol], [nombre_rol], [estado_rol], [fecha_creacion]) VALUES (3, N'Vendedor', 1, CAST(N'2023-10-12' AS Date))
SET IDENTITY_INSERT [dbo].[rol] OFF
GO
SET IDENTITY_INSERT [dbo].[tipo_metodo_pago] ON 

INSERT [dbo].[tipo_metodo_pago] ([id_tipo_metodo_pago], [nombre_tipo_pago]) VALUES (1, N'efectivo')
INSERT [dbo].[tipo_metodo_pago] ([id_tipo_metodo_pago], [nombre_tipo_pago]) VALUES (2, N'Tarjeta de credito')
INSERT [dbo].[tipo_metodo_pago] ([id_tipo_metodo_pago], [nombre_tipo_pago]) VALUES (3, N'Tarjeta de debito')
SET IDENTITY_INSERT [dbo].[tipo_metodo_pago] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([id_usuario], [email], [password], [estado_usuario], [id_persona], [id_rol], [id_domicilio], [fecha_creacion_usuario]) VALUES (1, N'octavio@gmail.com', N'123', 1, 2, 1, 2, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[usuario] ([id_usuario], [email], [password], [estado_usuario], [id_persona], [id_rol], [id_domicilio], [fecha_creacion_usuario]) VALUES (3, N'administrador@gmail.com', N'123', 1, 7, 3, 2, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[usuario] ([id_usuario], [email], [password], [estado_usuario], [id_persona], [id_rol], [id_domicilio], [fecha_creacion_usuario]) VALUES (4, N'gerente@gmail.com', N'123', 1, 6, 2, 2, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[usuario] ([id_usuario], [email], [password], [estado_usuario], [id_persona], [id_rol], [id_domicilio], [fecha_creacion_usuario]) VALUES (5, N'vendedor@gmail.com', N'123', 1, 5, 3, 2, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[usuario] ([id_usuario], [email], [password], [estado_usuario], [id_persona], [id_rol], [id_domicilio], [fecha_creacion_usuario]) VALUES (6, N'octi@gmail.com', N'$2a$11$7GzIKnzGNCv6M/4vBHy2BOsoz3tZQ30a/.pUCCsJUyU3nZfar45se', 0, 8, 1, 2, CAST(N'2023-10-13' AS Date))
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_nombre_categoria]    Script Date: 14/10/2023 12:53:11 ******/
ALTER TABLE [dbo].[categoria] ADD  CONSTRAINT [UQ_nombre_categoria] UNIQUE NONCLUSTERED 
(
	[nombre_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Nombre]    Script Date: 14/10/2023 12:53:11 ******/
ALTER TABLE [dbo].[Marca] ADD  CONSTRAINT [UQ_Nombre] UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_dni_persona]    Script Date: 14/10/2023 12:53:11 ******/
ALTER TABLE [dbo].[persona] ADD  CONSTRAINT [UQ_dni_persona] UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Censista_correo_unico]    Script Date: 14/10/2023 12:53:11 ******/
ALTER TABLE [dbo].[proveedor] ADD  CONSTRAINT [UQ_Censista_correo_unico] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_email]    Script Date: 14/10/2023 12:53:11 ******/
ALTER TABLE [dbo].[usuario] ADD  CONSTRAINT [UQ_email] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[categoria] ADD  CONSTRAINT [DF_categoria_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[cliente] ADD  CONSTRAINT [DF_cliente_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion_cliente]
GO
ALTER TABLE [dbo].[compra] ADD  CONSTRAINT [DF_compra_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion_compra]
GO
ALTER TABLE [dbo].[detalle_compra] ADD  CONSTRAINT [DF_detalle_compra_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion_detalle_compra]
GO
ALTER TABLE [dbo].[detalle_venta] ADD  CONSTRAINT [DF_detalle_venta_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion_detalle_venta]
GO
ALTER TABLE [dbo].[domicilio] ADD  CONSTRAINT [DF_domicilio_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[Marca] ADD  CONSTRAINT [DF_Marca_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[metodo_pago] ADD  CONSTRAINT [DF_metodo_pago_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[permiso] ADD  CONSTRAINT [DF_permiso_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion_permiso]
GO
ALTER TABLE [dbo].[persona] ADD  CONSTRAINT [DF_persona_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[producto] ADD  CONSTRAINT [DF_producto_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion_producto]
GO
ALTER TABLE [dbo].[proveedor] ADD  CONSTRAINT [DF_proveedor_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[rol] ADD  CONSTRAINT [DF_rol_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[usuario] ADD  CONSTRAINT [DF_usuario_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion_usuario]
GO
ALTER TABLE [dbo].[venta] ADD  CONSTRAINT [DF_venta_fecha_creacion]  DEFAULT (getdate()) FOR [fecha_creacion_venta]
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
ALTER TABLE [dbo].[metodo_pago]  WITH CHECK ADD  CONSTRAINT [FK_metodo_pago_tipo_metodo_pago] FOREIGN KEY([id_tipo_metodo_pago])
REFERENCES [dbo].[tipo_metodo_pago] ([id_tipo_metodo_pago])
GO
ALTER TABLE [dbo].[metodo_pago] CHECK CONSTRAINT [FK_metodo_pago_tipo_metodo_pago]
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
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_Marca] FOREIGN KEY([Id_Marca])
REFERENCES [dbo].[Marca] ([Id_Marca])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_Marca]
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
ALTER TABLE [dbo].[categoria]  WITH CHECK ADD  CONSTRAINT [CK_categoria_nombre_soloLetras] CHECK  ((NOT [nombre_categoria] like '%[^a-zA-Z ]%'))
GO
ALTER TABLE [dbo].[categoria] CHECK CONSTRAINT [CK_categoria_nombre_soloLetras]
GO
ALTER TABLE [dbo].[domicilio]  WITH CHECK ADD  CONSTRAINT [CK_domicilio_calle] CHECK  ((NOT [calle] like '%[^a-zA-Z ]%'))
GO
ALTER TABLE [dbo].[domicilio] CHECK CONSTRAINT [CK_domicilio_calle]
GO
ALTER TABLE [dbo].[metodo_pago]  WITH CHECK ADD  CONSTRAINT [CK_nombre_metodo_pago_soloLetras] CHECK  ((NOT [nombre_metodo_pago] like '%[^a-zA-Z ]%'))
GO
ALTER TABLE [dbo].[metodo_pago] CHECK CONSTRAINT [CK_nombre_metodo_pago_soloLetras]
GO
ALTER TABLE [dbo].[persona]  WITH CHECK ADD  CONSTRAINT [CK_Dni_Longitud] CHECK  ((len([dni])=(8)))
GO
ALTER TABLE [dbo].[persona] CHECK CONSTRAINT [CK_Dni_Longitud]
GO
ALTER TABLE [dbo].[persona]  WITH CHECK ADD  CONSTRAINT [CK_Dni_persona_Solo_numeros] CHECK  ((NOT [dni] like '%[^0-9]%'))
GO
ALTER TABLE [dbo].[persona] CHECK CONSTRAINT [CK_Dni_persona_Solo_numeros]
GO
ALTER TABLE [dbo].[persona]  WITH CHECK ADD  CONSTRAINT [CK_persona_apellido_soloLetras] CHECK  ((NOT [apellido] like '%[^a-zA-Z]%'))
GO
ALTER TABLE [dbo].[persona] CHECK CONSTRAINT [CK_persona_apellido_soloLetras]
GO
ALTER TABLE [dbo].[persona]  WITH CHECK ADD  CONSTRAINT [CK_persona_noMayorA100años] CHECK  (([fecha_nacimiento]>=dateadd(year,(-100),getdate()) AND [fecha_nacimiento]<=getdate()))
GO
ALTER TABLE [dbo].[persona] CHECK CONSTRAINT [CK_persona_noMayorA100años]
GO
ALTER TABLE [dbo].[persona]  WITH CHECK ADD  CONSTRAINT [CK_persona_nombre_soloLetras] CHECK  ((NOT [nombre] like '%[^a-zA-Z]%'))
GO
ALTER TABLE [dbo].[persona] CHECK CONSTRAINT [CK_persona_nombre_soloLetras]
GO
ALTER TABLE [dbo].[proveedor]  WITH CHECK ADD  CONSTRAINT [CK_email_correcto] CHECK  (([email] like '%@%.%'))
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [CK_email_correcto]
GO
ALTER TABLE [dbo].[proveedor]  WITH CHECK ADD  CONSTRAINT [CK_proveedor_nombre] CHECK  ((NOT [nombre] like '%[^a-zA-Z]%'))
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [CK_proveedor_nombre]
GO
ALTER TABLE [dbo].[rol]  WITH CHECK ADD  CONSTRAINT [CK_nombre_rol] CHECK  ((NOT [nombre_rol] like '%[^a-zA-Z]%'))
GO
ALTER TABLE [dbo].[rol] CHECK CONSTRAINT [CK_nombre_rol]
GO
/****** Object:  StoredProcedure [dbo].[SP_DARALTACATEGORIA]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO PARA DAR DE ALTA UNA CATEGORIA
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
/****** Object:  StoredProcedure [dbo].[SP_DARALTAUSUARIO]    Script Date: 14/10/2023 12:53:11 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_DARBAJACATEGORIA]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO PARA ELIMINAR O DAR DE BAJA UNA CATEGORIA
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
/****** Object:  StoredProcedure [dbo].[SP_DASHBOARDDATOS]    Script Date: 14/10/2023 12:53:11 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_EDITARCATEGORIA]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

					--PROCEDIMIENTO PARA EDITAR O MODIFICAR UNA CATEGORIA
CREATE PROC [dbo].[SP_EDITARCATEGORIA](
--estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a editar la categoria
@Id_Categoria int,
@Nombre_categoria VARCHAR(200),
@Descripcion_categoria VARCHAR(200),
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
		descripcion_categoria=@Descripcion_categoria,
		estado_categoria=@Estado_categoria
		WHERE id_categoria = @Id_Categoria
	ELSE
	BEGIN
		SET @Resultado=0
		SET @Mensaje= 'No se puede repetir el Nombre de la Categoria debe de ser UNICO'
	END
END

GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARUSUARIO]    Script Date: 14/10/2023 12:53:11 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARUSUARIO]    Script Date: 14/10/2023 12:53:11 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARUSUARIOLOGICO]    Script Date: 14/10/2023 12:53:11 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARCATEGORIA]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
				--PROCEDIMIENTO PARA REGISTRAR CATEGORIA
CREATE PROC [dbo].[SP_REGISTRARCATEGORIA](
--estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar la categoria
@Nombre_categoria VARCHAR(200),
@Descripcion_categoria VARCHAR(200),
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
		INSERT INTO categoria(nombre_categoria,descripcion_categoria,estado_categoria) 
		VALUES(@Nombre_categoria,@Descripcion_categoria,@Estado_categoria)

		SET @Resultado= SCOPE_IDENTITY()-- Obtener el ID de la categoria recién insertada y lo asigno o guardo en mi parametro de salida resultado
		SET @Mensaje= 'La categoria se registro de manera correcta'

	END
	ELSE
		SET @Mensaje= 'No se puede repetir el Nombre de la Categoria debe de ser UNICO'

END

GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARDOMICILIO]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARDOMICILIO](
@codigo_postal int,
@localidad varchar(100),
@provincia varchar(100),
@numero int,
@calle varchar(200),
@descripcion_domicilio varchar(100),
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
	INSERT INTO domicilio(codigo_postal,localidad,provincia,numero,calle,descripcion_domicilio,estado_domicilio)
	VALUES(@codigo_postal,@localidad,@provincia,@numero,@calle,@descripcion_domicilio,@estado_domicilio)

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
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARUSUARIO]    Script Date: 14/10/2023 12:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*REGISTRAR USUARIO */
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
				insert into usuario(email,password,estado_usuario,id_persona,id_rol,id_domicilio) 
				values(@email,@password,@estado_usuario,@id_persona,@id_rol,@id_domicilio)

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
ALTER DATABASE [BD_CeliMarket] SET  READ_WRITE 
GO
