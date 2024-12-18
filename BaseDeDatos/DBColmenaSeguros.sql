USE [master]
GO
/****** Object:  Database [ColmenaSeguros]    Script Date: 18/11/2024 12:20:37 a. m. ******/
CREATE DATABASE [ColmenaSeguros]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ColmenaSeguros', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ColmenaSeguros.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ColmenaSeguros_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ColmenaSeguros_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ColmenaSeguros] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ColmenaSeguros].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ColmenaSeguros] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET ARITHABORT OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ColmenaSeguros] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ColmenaSeguros] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ColmenaSeguros] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ColmenaSeguros] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ColmenaSeguros] SET  MULTI_USER 
GO
ALTER DATABASE [ColmenaSeguros] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ColmenaSeguros] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ColmenaSeguros] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ColmenaSeguros] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ColmenaSeguros] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ColmenaSeguros] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ColmenaSeguros] SET QUERY_STORE = ON
GO
ALTER DATABASE [ColmenaSeguros] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ColmenaSeguros]
GO
/****** Object:  Table [dbo].[Adquisiciones]    Script Date: 18/11/2024 12:20:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adquisiciones](
	[Id] [int] NOT NULL,
	[IdCliente] [int] NULL,
	[IdPoliza] [int] NULL,
	[FechaAdquisicion] [date] NULL,
	[Estado] [varchar](250) NULL,
 CONSTRAINT [PK_Adquisiciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 18/11/2024 12:20:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NULL,
	[Email] [varchar](250) NULL,
	[Usuario] [varchar](250) NULL,
	[Contraseña] [varchar](250) NULL,
	[Telefono] [varchar](250) NULL,
	[Direccion] [varchar](250) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cotizaciones]    Script Date: 18/11/2024 12:20:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cotizaciones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[IdPoliza] [int] NULL,
	[FechaCotizacion] [date] NULL,
	[Monto] [varchar](250) NULL,
 CONSTRAINT [PK_Cotizaciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Polizas]    Script Date: 18/11/2024 12:20:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Polizas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdSeguro] [int] NULL,
	[Nombre] [varchar](250) NULL,
	[Descripcion] [varchar](250) NULL,
	[Prima] [varchar](250) NULL,
	[Cobertura] [varchar](250) NULL,
	[Condiciones] [varchar](250) NULL,
 CONSTRAINT [PK_Polizas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seguros]    Script Date: 18/11/2024 12:20:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seguros](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varbinary](250) NULL,
	[Descripcion] [varchar](250) NULL,
 CONSTRAINT [PK_Seguros] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siniestros]    Script Date: 18/11/2024 12:20:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siniestros](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdAdquisicion] [int] NULL,
	[FechaSiniestro] [date] NULL,
	[Descripcion] [varchar](250) NULL,
	[Estado] [varchar](250) NULL,
 CONSTRAINT [PK_Siniestros] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 18/11/2024 12:20:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NULL,
	[Email] [varchar](250) NULL,
	[Telefono] [varchar](250) NULL,
	[Usuario] [varchar](250) NULL,
	[Contaseña] [varchar](250) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([Id], [Nombre], [Email], [Usuario], [Contraseña], [Telefono], [Direccion]) VALUES (1, N'Nicolas', N'nico52105@gmail.com', N'1070916486', N'123456', N'3017289211', N'casa')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
ALTER TABLE [dbo].[Adquisiciones]  WITH CHECK ADD  CONSTRAINT [FK_Adquisiciones_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Adquisiciones] CHECK CONSTRAINT [FK_Adquisiciones_Cliente]
GO
ALTER TABLE [dbo].[Adquisiciones]  WITH CHECK ADD  CONSTRAINT [FK_Adquisiciones_Polizas] FOREIGN KEY([IdPoliza])
REFERENCES [dbo].[Polizas] ([Id])
GO
ALTER TABLE [dbo].[Adquisiciones] CHECK CONSTRAINT [FK_Adquisiciones_Polizas]
GO
ALTER TABLE [dbo].[Cotizaciones]  WITH CHECK ADD  CONSTRAINT [FK_Cotizaciones_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Cotizaciones] CHECK CONSTRAINT [FK_Cotizaciones_Cliente]
GO
ALTER TABLE [dbo].[Cotizaciones]  WITH CHECK ADD  CONSTRAINT [FK_Cotizaciones_Polizas] FOREIGN KEY([IdPoliza])
REFERENCES [dbo].[Polizas] ([Id])
GO
ALTER TABLE [dbo].[Cotizaciones] CHECK CONSTRAINT [FK_Cotizaciones_Polizas]
GO
ALTER TABLE [dbo].[Polizas]  WITH CHECK ADD  CONSTRAINT [FK_Polizas_Seguros] FOREIGN KEY([IdSeguro])
REFERENCES [dbo].[Seguros] ([Id])
GO
ALTER TABLE [dbo].[Polizas] CHECK CONSTRAINT [FK_Polizas_Seguros]
GO
ALTER TABLE [dbo].[Siniestros]  WITH CHECK ADD  CONSTRAINT [FK_Siniestros_Adquisiciones] FOREIGN KEY([IdAdquisicion])
REFERENCES [dbo].[Adquisiciones] ([Id])
GO
ALTER TABLE [dbo].[Siniestros] CHECK CONSTRAINT [FK_Siniestros_Adquisiciones]
GO
USE [master]
GO
ALTER DATABASE [ColmenaSeguros] SET  READ_WRITE 
GO
