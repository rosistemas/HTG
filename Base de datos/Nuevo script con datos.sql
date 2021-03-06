/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [HeladeriaTuGusto]    Script Date: 2017-11-13 05:55:57 p. m. ******/
CREATE DATABASE [HeladeriaTuGusto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HeladeriaTuGusto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\HeladeriaTuGusto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HeladeriaTuGusto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\HeladeriaTuGusto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HeladeriaTuGusto] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HeladeriaTuGusto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HeladeriaTuGusto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET ARITHABORT OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HeladeriaTuGusto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HeladeriaTuGusto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HeladeriaTuGusto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HeladeriaTuGusto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HeladeriaTuGusto] SET  MULTI_USER 
GO
ALTER DATABASE [HeladeriaTuGusto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HeladeriaTuGusto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HeladeriaTuGusto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HeladeriaTuGusto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HeladeriaTuGusto] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HeladeriaTuGusto] SET QUERY_STORE = OFF
GO
USE [HeladeriaTuGusto]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [HeladeriaTuGusto]
GO
/****** Object:  Table [dbo].[Barrio]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrio](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[idLocalidad] [int] NULL,
 CONSTRAINT [PK_Barrio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[id] [int] NOT NULL,
	[idProveedor] [int] NOT NULL,
	[idEmpleado] [int] NULL,
	[fecha] [date] NULL,
	[hora] [time](0) NULL,
	[montoTotal] [float] NULL,
	[precioPorUnidad] [float] NULL,
	[cantidad] [int] NULL,
	[idProducto] [int] NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesTurno]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesTurno](
	[idTurno] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[idSupervisor] [int] NULL,
	[idEmpleado1] [int] NULL,
	[idEmpleado2] [int] NULL,
 CONSTRAINT [PK_DetallesTurno] PRIMARY KEY CLUSTERED 
(
	[idTurno] ASC,
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleTicket]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleTicket](
	[numeroTicket] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[cantidad] [int] NULL,
	[precio] [float] NULL,
 CONSTRAINT [PK_DetalleTicket] PRIMARY KEY CLUSTERED 
(
	[numeroTicket] ASC,
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[id] [int] NOT NULL,
	[numDoc] [int] NULL,
	[tipoDoc] [int] NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[fechaNacimiento] [date] NULL,
	[fechaIngreso] [date] NULL,
	[fechaEgreso] [date] NULL,
	[idBarrio] [int] NULL,
	[calle] [varchar](50) NULL,
	[numCalle] [int] NULL,
	[idLocalidad] [int] NULL,
	[idProvincia] [int] NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[idProvincia] [int] NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[idTipo] [int] NULL,
	[precio] [float] NULL,
	[stock] [int] NULL,
	[descripcion] [varchar](max) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[idProveedor] [int] NOT NULL,
	[numDoc] [int] NULL,
	[tipoDoc] [int] NULL,
	[razonSocial] [varchar](50) NULL,
	[mail] [varchar](50) NULL,
	[idBarrio] [int] NULL,
	[calle] [varchar](50) NULL,
	[numCalle] [int] NULL,
	[nombre] [varchar](50) NULL,
	[idLocalidad] [int] NULL,
	[idProducto] [int] NULL,
	[idProvincia] [int] NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TelefonoXEmpleado]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TelefonoXEmpleado](
	[idEmpleado] [int] NOT NULL,
	[idTipoTelefono] [int] NULL,
	[numero] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TelefonoXEmpleado] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC,
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TelefonoXProveedor]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TelefonoXProveedor](
	[idProveedor] [int] NOT NULL,
	[idTipoTelefono] [int] NULL,
	[numero] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TelefonoXProveedor] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC,
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[id] [int] NOT NULL,
	[legajoEmpleado] [int] NULL,
	[fecha] [date] NULL,
	[hora] [time](0) NULL,
	[total] [float] NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDoc]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDoc](
	[id] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TipoDoc] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoProducto](
	[idTipo] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TipoProducto] PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoTelefono]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoTelefono](
	[idTipo] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TipoTelefono] PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 2017-11-13 05:55:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[id] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[horaCominzo] [time](0) NULL,
	[duracion] [time](0) NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Barrio] ([id], [nombre], [idLocalidad]) VALUES (1, N'El Talar', 1)
INSERT [dbo].[Compra] ([id], [idProveedor], [idEmpleado], [fecha], [hora], [montoTotal], [precioPorUnidad], [cantidad], [idProducto]) VALUES (1, 1, 1, CAST(N'2017-11-08' AS Date), CAST(N'22:21:33' AS Time), 2400, 8, 300, 1)
INSERT [dbo].[Compra] ([id], [idProveedor], [idEmpleado], [fecha], [hora], [montoTotal], [precioPorUnidad], [cantidad], [idProducto]) VALUES (2, 2, 1, CAST(N'2017-11-13' AS Date), CAST(N'16:48:50' AS Time), 1600, 8, 200, 2)
INSERT [dbo].[Compra] ([id], [idProveedor], [idEmpleado], [fecha], [hora], [montoTotal], [precioPorUnidad], [cantidad], [idProducto]) VALUES (3, 10, 1, CAST(N'2017-11-13' AS Date), CAST(N'17:12:00' AS Time), 12000, 80, 150, 10)
INSERT [dbo].[Compra] ([id], [idProveedor], [idEmpleado], [fecha], [hora], [montoTotal], [precioPorUnidad], [cantidad], [idProducto]) VALUES (4, 9, 1, CAST(N'2017-11-13' AS Date), CAST(N'17:12:34' AS Time), 8100, 90, 90, 9)
INSERT [dbo].[Compra] ([id], [idProveedor], [idEmpleado], [fecha], [hora], [montoTotal], [precioPorUnidad], [cantidad], [idProducto]) VALUES (5, 15, 1, CAST(N'2017-11-13' AS Date), CAST(N'17:53:13' AS Time), 2800, 7, 400, 15)
INSERT [dbo].[DetalleTicket] ([numeroTicket], [idProducto], [cantidad], [precio]) VALUES (1, 1, 15, 8)
INSERT [dbo].[DetalleTicket] ([numeroTicket], [idProducto], [cantidad], [precio]) VALUES (2, 1, 30, 8)
INSERT [dbo].[DetalleTicket] ([numeroTicket], [idProducto], [cantidad], [precio]) VALUES (3, 2, 23, 8)
INSERT [dbo].[DetalleTicket] ([numeroTicket], [idProducto], [cantidad], [precio]) VALUES (4, 2, 1, 8)
INSERT [dbo].[DetalleTicket] ([numeroTicket], [idProducto], [cantidad], [precio]) VALUES (4, 9, 2, 100)
INSERT [dbo].[DetalleTicket] ([numeroTicket], [idProducto], [cantidad], [precio]) VALUES (5, 1, 1, 8)
INSERT [dbo].[DetalleTicket] ([numeroTicket], [idProducto], [cantidad], [precio]) VALUES (5, 2, 1, 8)
INSERT [dbo].[DetalleTicket] ([numeroTicket], [idProducto], [cantidad], [precio]) VALUES (5, 10, 1, 100)
INSERT [dbo].[DetalleTicket] ([numeroTicket], [idProducto], [cantidad], [precio]) VALUES (5, 15, 3, 18)
INSERT [dbo].[Empleado] ([id], [numDoc], [tipoDoc], [nombre], [apellido], [fechaNacimiento], [fechaIngreso], [fechaEgreso], [idBarrio], [calle], [numCalle], [idLocalidad], [idProvincia]) VALUES (1, 38958462, 1, N'Rodrigo', N'Gomez', CAST(N'1994-03-07' AS Date), CAST(N'2017-11-08' AS Date), NULL, 1, N'Tissera', 4895, 1, 1)
INSERT [dbo].[Localidad] ([id], [nombre], [idProvincia]) VALUES (1, N'Mendiolaza', 1)
INSERT [dbo].[Localidad] ([id], [nombre], [idProvincia]) VALUES (2, N'Villa Allende', 1)
INSERT [dbo].[Localidad] ([id], [nombre], [idProvincia]) VALUES (3, N'Córdoba Capital', 1)
INSERT [dbo].[Localidad] ([id], [nombre], [idProvincia]) VALUES (4, N'Unquillo', 1)
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (1, N'Palito Frutal Frutilla', 4, 8, 254, N'Palito helado de agua de frutilla con pulpa de frutilla.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (2, N'Palito Frutal Limón', 4, 8, 175, N'Palito helado de agua de limón con jugo natural exprimido.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (3, N'Palito Frutal Naranja', 4, 8, 0, N'Palito helado de agua de naranja con jugo natural exprimido.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (4, N'Palito Cremoso Americano', 4, 10, 0, N'Palito de crema helada sabor chantilly.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (5, N'Palito Cremoso Frutilla', 4, 10, 0, N'Palito de crema helada de frutilla con pulpa de frutilla.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (6, N'Palito Bombón', 4, 12, 0, N'Palito de Crema helada sabor chantilly cubierta de baño de repostería.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (7, N'Palito Cremoso Dulce de leche', 4, 10, 0, N'Palito de crema helada sabor dulce de leche.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (8, N'Tentación de Chocolate', 3, 100, 0, N'Crema helada de chocolate y dulce de leche, con base de galleta, decorada con salsa de chocolate.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (9, N'Torta Primavera', 3, 100, 88, N'Crema helada de dulce de leche, frutilla y vainilla, con base de galleta, decorada con cerezas enteras.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (10, N'Selva Helada', 3, 100, 149, N'Crema helada de chocolate y crema americana con base de galleta sabor vainilla, decorada con cerezas naturales enteras.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (11, N'Casatta', 2, 50, 0, N'Helado de crema sabor frutilla, chocolate y crema americana.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (12, N'Almendrado', 2, 50, 0, N'Crema helada sabor americana cubierta con crocante de maní.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (13, N'Bombón', 2, 50, 0, N'Una deliciosa composición de crema helada de chocolate y dulce de leche, con corazón de dulce de leche repostero y delicado bañado de repostería.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (14, N'Cucurucho mini', 1, 12, 0, N'Cucurucho con una bocha de helado, sabor a elección.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (15, N'Cucurucho 2 bochas', 1, 18, 397, N'Cucurucho con dos bochas de helado, sabor a elección.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (16, N'Cucurucho 3 bochas', 1, 24, 0, N'Cucurucho con tres bochas de helado, sabor a elección.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (17, N'Cucurucho crocante 2 bochas', 1, 30, 0, N'Cucurucho con baño de repostería y crocante de maní, con dos bochas de helado, sabores a elección.')
INSERT [dbo].[Producto] ([idProducto], [nombre], [idTipo], [precio], [stock], [descripcion]) VALUES (18, N'Mega cucurucho crocante', 1, 36, 0, N'Cucurucho con baño de repostería y crocante de maní, con tres bochas de helado, sabores a elección.')
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (1, 21354879, 1, N'Palitos fantásticos', N'palitos@frutales.com', 1, N'Tissera', 4500, N'Palitos frutales', 1, 1, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (2, 21354879, 1, N'Palitos fantásticos', N'palitos@frutales.com', 1, N'Tissera', 4500, N'Palitos frutales', 1, 2, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (3, 21354879, 1, N'Palitos fantásticos', N'palitos@frutales.com', 1, N'Tissera', 4500, N'Palitos frutales', 1, 3, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (4, 21354879, 1, N'Palitos fantásticos', N'palitos@frutales.com', 1, N'Tissera', 4500, N'Palitos frutales', 1, 4, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (5, 21354879, 1, N'Palitos fantásticos', N'palitos@frutales.com', 1, N'Tissera', 4500, N'Palitos frutales', 1, 5, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (6, 21354879, 1, N'Palitos fantásticos', N'palitos@frutales.com', 1, N'Tissera', 4500, N'Palitos frutales', 1, 6, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (7, 21354879, 1, N'Palitos fantásticos', N'palitos@frutales.com', 1, N'Tissera', 4500, N'Palitos frutales', 1, 7, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (8, 24985746, 1, N'Paris Patisseries', N'Chocolaterie@Jacques.com', 1, N'Pehuén', 400, N'Jacques Genin', 1, 8, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (9, 24985746, 1, N'Paris Patisseries', N'Chocolaterie@Jacques.com', 1, N'Pehuén', 400, N'Jacques Genin', 1, 9, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (10, 24985746, 1, N'Paris Patisseries', N'Chocolaterie@Jacques.com', 1, N'Pehuén', 400, N'Jacques Genin', 1, 10, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (11, 24985746, 1, N'Paris Patisseries', N'Chocolaterie@Jacques.com', 1, N'Pehuén', 400, N'Jacques Genin', 1, 11, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (12, 24985746, 1, N'Paris Patisseries', N'Chocolaterie@Jacques.com', 1, N'Pehuén', 400, N'Jacques Genin', 1, 12, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (13, 24985746, 1, N'Paris Patisseries', N'Chocolaterie@Jacques.com', 1, N'Pehuén', 400, N'Jacques Genin', 1, 13, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (14, 26713598, 1, N'Cucurucheria los cucuruchos', N'Panificadora@pan.com', 1, N'Chacabuco', 123, N'Panificacadora', 1, 14, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [numDoc], [tipoDoc], [razonSocial], [mail], [idBarrio], [calle], [numCalle], [nombre], [idLocalidad], [idProducto], [idProvincia]) VALUES (15, 26587496, 1, N'Cucuruchería los cucuruchos', N'Panificadora@pan.com', 1, N'Chacabuco', 123, N'Panificadora', 1, 15, 1)
INSERT [dbo].[Provincia] ([id], [nombre]) VALUES (1, N'Córdoba')
INSERT [dbo].[Provincia] ([id], [nombre]) VALUES (2, N'Buenos Aires')
INSERT [dbo].[Provincia] ([id], [nombre]) VALUES (3, N'Mendoza')
INSERT [dbo].[Provincia] ([id], [nombre]) VALUES (4, N'Neuquen')
INSERT [dbo].[TelefonoXProveedor] ([idProveedor], [idTipoTelefono], [numero]) VALUES (15, 2, N'456281')
INSERT [dbo].[Ticket] ([id], [legajoEmpleado], [fecha], [hora], [total]) VALUES (1, 1, CAST(N'2017-11-08' AS Date), CAST(N'22:23:46' AS Time), 120)
INSERT [dbo].[Ticket] ([id], [legajoEmpleado], [fecha], [hora], [total]) VALUES (2, 1, CAST(N'2017-11-08' AS Date), CAST(N'22:23:58' AS Time), 240)
INSERT [dbo].[Ticket] ([id], [legajoEmpleado], [fecha], [hora], [total]) VALUES (3, 1, CAST(N'2017-11-13' AS Date), CAST(N'17:05:01' AS Time), 184)
INSERT [dbo].[Ticket] ([id], [legajoEmpleado], [fecha], [hora], [total]) VALUES (4, 1, CAST(N'2017-11-13' AS Date), CAST(N'17:13:03' AS Time), 208)
INSERT [dbo].[Ticket] ([id], [legajoEmpleado], [fecha], [hora], [total]) VALUES (5, 1, CAST(N'2017-11-13' AS Date), CAST(N'17:53:56' AS Time), 170)
INSERT [dbo].[TipoDoc] ([id], [descripcion]) VALUES (1, N'DNI')
INSERT [dbo].[TipoDoc] ([id], [descripcion]) VALUES (2, N'LE')
INSERT [dbo].[TipoDoc] ([id], [descripcion]) VALUES (3, N'CI')
INSERT [dbo].[TipoDoc] ([id], [descripcion]) VALUES (4, N'LC')
INSERT [dbo].[TipoProducto] ([idTipo], [descripcion]) VALUES (1, N'Cucurucho')
INSERT [dbo].[TipoProducto] ([idTipo], [descripcion]) VALUES (2, N'Postre')
INSERT [dbo].[TipoProducto] ([idTipo], [descripcion]) VALUES (3, N'Torta helada')
INSERT [dbo].[TipoProducto] ([idTipo], [descripcion]) VALUES (4, N'Palito helado')
INSERT [dbo].[TipoTelefono] ([idTipo], [descripcion]) VALUES (1, N'Celular')
INSERT [dbo].[TipoTelefono] ([idTipo], [descripcion]) VALUES (2, N'Fijo')
INSERT [dbo].[Turno] ([id], [descripcion], [horaCominzo], [duracion]) VALUES (1, N'Mañana', CAST(N'08:00:00' AS Time), CAST(N'04:00:00' AS Time))
INSERT [dbo].[Turno] ([id], [descripcion], [horaCominzo], [duracion]) VALUES (2, N'Tarde', CAST(N'12:00:00' AS Time), CAST(N'08:00:00' AS Time))
INSERT [dbo].[Turno] ([id], [descripcion], [horaCominzo], [duracion]) VALUES (3, N'Noche', CAST(N'20:00:00' AS Time), CAST(N'04:00:00' AS Time))
ALTER TABLE [dbo].[Barrio]  WITH CHECK ADD  CONSTRAINT [FK_Barrio_Localidad] FOREIGN KEY([idLocalidad])
REFERENCES [dbo].[Localidad] ([id])
GO
ALTER TABLE [dbo].[Barrio] CHECK CONSTRAINT [FK_Barrio_Localidad]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Empleado]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Producto]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Proveedor] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedor] ([idProveedor])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Proveedor]
GO
ALTER TABLE [dbo].[DetallesTurno]  WITH CHECK ADD  CONSTRAINT [FK_DetallesTurno_Empleado] FOREIGN KEY([idSupervisor])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[DetallesTurno] CHECK CONSTRAINT [FK_DetallesTurno_Empleado]
GO
ALTER TABLE [dbo].[DetallesTurno]  WITH CHECK ADD  CONSTRAINT [FK_DetallesTurno_Empleado1] FOREIGN KEY([idEmpleado2])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[DetallesTurno] CHECK CONSTRAINT [FK_DetallesTurno_Empleado1]
GO
ALTER TABLE [dbo].[DetallesTurno]  WITH CHECK ADD  CONSTRAINT [FK_DetallesTurno_Empleado2] FOREIGN KEY([idEmpleado1])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[DetallesTurno] CHECK CONSTRAINT [FK_DetallesTurno_Empleado2]
GO
ALTER TABLE [dbo].[DetallesTurno]  WITH CHECK ADD  CONSTRAINT [FK_DetallesTurno_Turno] FOREIGN KEY([idTurno])
REFERENCES [dbo].[Turno] ([id])
GO
ALTER TABLE [dbo].[DetallesTurno] CHECK CONSTRAINT [FK_DetallesTurno_Turno]
GO
ALTER TABLE [dbo].[DetalleTicket]  WITH CHECK ADD  CONSTRAINT [FK_DetalleTicket_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleTicket] CHECK CONSTRAINT [FK_DetalleTicket_Producto]
GO
ALTER TABLE [dbo].[DetalleTicket]  WITH CHECK ADD  CONSTRAINT [FK_DetalleTicket_Ticket] FOREIGN KEY([numeroTicket])
REFERENCES [dbo].[Ticket] ([id])
GO
ALTER TABLE [dbo].[DetalleTicket] CHECK CONSTRAINT [FK_DetalleTicket_Ticket]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Barrio] FOREIGN KEY([idBarrio])
REFERENCES [dbo].[Barrio] ([id])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Barrio]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Localidad] FOREIGN KEY([idLocalidad])
REFERENCES [dbo].[Localidad] ([id])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Localidad]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Provincia] FOREIGN KEY([idProvincia])
REFERENCES [dbo].[Provincia] ([id])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Provincia]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_TipoDoc] FOREIGN KEY([tipoDoc])
REFERENCES [dbo].[TipoDoc] ([id])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_TipoDoc]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK_Localidad_Provincia] FOREIGN KEY([idProvincia])
REFERENCES [dbo].[Provincia] ([id])
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK_Localidad_Provincia]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_TipoProducto] FOREIGN KEY([idTipo])
REFERENCES [dbo].[TipoProducto] ([idTipo])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_TipoProducto]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Barrio] FOREIGN KEY([idBarrio])
REFERENCES [dbo].[Barrio] ([id])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Barrio]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Localidad] FOREIGN KEY([idLocalidad])
REFERENCES [dbo].[Localidad] ([id])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Localidad]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Producto]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Provincia] FOREIGN KEY([idProvincia])
REFERENCES [dbo].[Provincia] ([id])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Provincia]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_TipoDoc] FOREIGN KEY([tipoDoc])
REFERENCES [dbo].[TipoDoc] ([id])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_TipoDoc]
GO
ALTER TABLE [dbo].[TelefonoXEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_TelefonoXEmpleado_Empleado1] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[TelefonoXEmpleado] CHECK CONSTRAINT [FK_TelefonoXEmpleado_Empleado1]
GO
ALTER TABLE [dbo].[TelefonoXEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_TelefonoXEmpleado_TipoTelefono1] FOREIGN KEY([idTipoTelefono])
REFERENCES [dbo].[TipoTelefono] ([idTipo])
GO
ALTER TABLE [dbo].[TelefonoXEmpleado] CHECK CONSTRAINT [FK_TelefonoXEmpleado_TipoTelefono1]
GO
ALTER TABLE [dbo].[TelefonoXProveedor]  WITH CHECK ADD  CONSTRAINT [FK_TelefonoXProveedor_TipoTelefono] FOREIGN KEY([idTipoTelefono])
REFERENCES [dbo].[TipoTelefono] ([idTipo])
GO
ALTER TABLE [dbo].[TelefonoXProveedor] CHECK CONSTRAINT [FK_TelefonoXProveedor_TipoTelefono]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Empleado] FOREIGN KEY([legajoEmpleado])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Empleado]
GO
USE [master]
GO
ALTER DATABASE [HeladeriaTuGusto] SET  READ_WRITE 
GO
