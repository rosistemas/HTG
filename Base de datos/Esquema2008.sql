/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2008
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [HeladeriaTuGusto]    Script Date: 2017-11-13 05:57:00 p. m. ******/
CREATE DATABASE [HeladeriaTuGusto] ON  PRIMARY 
( NAME = N'HeladeriaTuGusto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\HeladeriaTuGusto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HeladeriaTuGusto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\HeladeriaTuGusto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
USE [HeladeriaTuGusto]
GO
/****** Object:  Table [dbo].[Barrio]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[Compra]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[DetallesTurno]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[DetalleTicket]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[Empleado]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[Localidad]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[Proveedor]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[Provincia]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[TelefonoXEmpleado]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[TelefonoXProveedor]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[Ticket]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[TipoDoc]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[TipoTelefono]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
/****** Object:  Table [dbo].[Turno]    Script Date: 2017-11-13 05:57:00 p. m. ******/
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
