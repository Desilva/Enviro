USE [master]
GO
/****** Object:  Database [star_energy_enviro]    Script Date: 1/15/2014 11:18:25 AM ******/
CREATE DATABASE [star_energy_enviro] ON  PRIMARY 
( NAME = N'star_energy_enviro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\star_energy_enviro.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'star_energy_enviro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\star_energy_enviro_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [star_energy_enviro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [star_energy_enviro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [star_energy_enviro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [star_energy_enviro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [star_energy_enviro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [star_energy_enviro] SET ARITHABORT OFF 
GO
ALTER DATABASE [star_energy_enviro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [star_energy_enviro] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [star_energy_enviro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [star_energy_enviro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [star_energy_enviro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [star_energy_enviro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [star_energy_enviro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [star_energy_enviro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [star_energy_enviro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [star_energy_enviro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [star_energy_enviro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [star_energy_enviro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [star_energy_enviro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [star_energy_enviro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [star_energy_enviro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [star_energy_enviro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [star_energy_enviro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [star_energy_enviro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [star_energy_enviro] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [star_energy_enviro] SET  MULTI_USER 
GO
ALTER DATABASE [star_energy_enviro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [star_energy_enviro] SET DB_CHAINING OFF 
GO
USE [star_energy_enviro]
GO
/****** Object:  Table [dbo].[graphic_data]    Script Date: 1/15/2014 11:18:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[graphic_data](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [date] NULL,
	[id_lokasi] [int] NULL,
	[id_parameter] [int] NULL,
	[hasil_analisis] [float] NULL,
	[type] [tinyint] NULL,
	[is_galat] [tinyint] NULL,
 CONSTRAINT [PK_graphic_data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[graphic_parameter]    Script Date: 1/15/2014 11:18:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[graphic_parameter](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[parameter] [varchar](255) NULL,
	[type] [int] NULL,
 CONSTRAINT [PK_graphic_parameter] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[graphic_type]    Script Date: 1/15/2014 11:18:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[graphic_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[peraturan] [varchar](255) NULL,
 CONSTRAINT [PK_graphic_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[graphics_unit]    Script Date: 1/15/2014 11:18:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[graphics_unit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[unit] [varchar](255) NULL,
 CONSTRAINT [PK_graphics_unit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hazardous_record]    Script Date: 1/15/2014 11:18:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hazardous_record](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [date] NULL,
	[id_waste] [int] NULL,
	[id_source] [int] NULL,
	[no_kemasan] [varchar](100) NULL,
	[kemasan] [varchar](255) NULL,
	[volume_weight] [float] NULL,
	[internal_document] [varchar](50) NULL,
	[type] [tinyint] NULL,
	[tujuan] [varchar](255) NULL,
	[external_document] [varchar](255) NULL,
	[id_satuan] [int] NULL,
	[max_penyimpanan] [date] NULL,
 CONSTRAINT [PK_hazardous_record] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[lokasi_sampling]    Script Date: 1/15/2014 11:18:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lokasi_sampling](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[lokasi_sampling] [varchar](255) NULL,
	[type] [tinyint] NULL,
 CONSTRAINT [PK_lokasi_sampling] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[non_hazardous_record]    Script Date: 1/15/2014 11:18:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[non_hazardous_record](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [date] NULL,
	[id_type] [int] NULL,
	[waste_in] [float] NULL,
	[waste_out] [float] NULL,
	[recycle_rate] [float] NULL,
 CONSTRAINT [PK_non_hazardous_record] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[satuan_unit]    Script Date: 1/15/2014 11:18:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[satuan_unit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[satuan] [varchar](50) NULL,
	[unit_conversion] [float] NULL,
 CONSTRAINT [PK_satuan_unit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[source_of_waste]    Script Date: 1/15/2014 11:18:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[source_of_waste](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[source] [varchar](255) NULL,
 CONSTRAINT [PK_source_of_waste] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[type_of_waste]    Script Date: 1/15/2014 11:18:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[type_of_waste](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
 CONSTRAINT [PK_type_of_waste] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[waste_hazardous]    Script Date: 1/15/2014 11:18:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[waste_hazardous](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[waste_code] [varchar](255) NULL,
 CONSTRAINT [PK_waste_hazardous] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[graphic_data] ON 

INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (1, CAST(0xB5370B00 AS Date), 1, 4, 38, 1, NULL)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (19, CAST(0xB5370B00 AS Date), 2, 2, 15, 2, NULL)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (20, CAST(0xB6370B00 AS Date), 3, 1, 9, 1, NULL)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (21, CAST(0xB6370B00 AS Date), 7, 1, 6.5, 1, NULL)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (22, CAST(0xB6370B00 AS Date), 8, 1, 5.55, 1, NULL)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (23, CAST(0xB6370B00 AS Date), 9, 1, 7.03, 1, NULL)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (24, CAST(0xB6370B00 AS Date), 7, 4, 37, 1, NULL)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (25, CAST(0xD5370B00 AS Date), 7, 4, 37.54, 1, NULL)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (26, CAST(0xD6370B00 AS Date), 1, 4, 38, 1, NULL)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (27, CAST(0xF3370B00 AS Date), 1, 4, 38, 1, NULL)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (28, CAST(0x12380B00 AS Date), 1, 4, 38, 1, NULL)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (29, CAST(0x12380B00 AS Date), 7, 4, 36.3, 1, NULL)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (1029, CAST(0xBA370B00 AS Date), 8, 16, 3, 1, NULL)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (1032, CAST(0xDF370B00 AS Date), 7, 1, 2, 1, 1)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (1033, CAST(0xD7370B00 AS Date), 9, 7, 123, 1, 0)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (1034, CAST(0xD7370B00 AS Date), 9, 8, 121, 1, 0)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (1035, CAST(0xD7370B00 AS Date), 9, 5, 12, 1, 0)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (1036, CAST(0xD7370B00 AS Date), 7, 7, 12, 1, 0)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (1037, CAST(0xD7370B00 AS Date), 7, 1, 7, 1, 0)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (2033, CAST(0xF2370B00 AS Date), 18, 31, 12, 3, 0)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (2034, CAST(0xF2370B00 AS Date), 24, 40, 12, 5, 0)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (2035, CAST(0xF2370B00 AS Date), 31, 43, 12, 6, 0)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (2036, CAST(0xF2370B00 AS Date), 33, 47, 12, 7, 0)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (2037, CAST(0xF2370B00 AS Date), 40, 51, 12, 8, 0)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (2038, CAST(0xF2370B00 AS Date), 59, 56, 12, 9, 0)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (2039, CAST(0xF2370B00 AS Date), 73, 63, 12, 10, 0)
INSERT [dbo].[graphic_data] ([id], [date], [id_lokasi], [id_parameter], [hasil_analisis], [type], [is_galat]) VALUES (2040, CAST(0xF3370B00 AS Date), 8, 8, 12, 1, 0)
SET IDENTITY_INSERT [dbo].[graphic_data] OFF
SET IDENTITY_INSERT [dbo].[graphic_parameter] ON 

INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (1, N'pH', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (2, N'Minyak dan Lemak', 2)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (3, N'TOC', 2)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (4, N'Suhu', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (5, N'Air Raksa', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (6, N'Arsen', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (7, N'Barium', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (8, N'Besi', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (9, N'BOD', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (10, N'Cadmium', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (11, N'Cobalt', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (12, N'COD', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (13, N'Cuprum', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (14, N'Fenol Total', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (15, N'Krom Heksavalen', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (16, N'Krom Total', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (17, N'Mangan', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (18, N'MBAS', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (19, N'Merkuri', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (20, N'Minyak dan Lemak', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (21, N'Nikel', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (22, N'Phenol', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (23, N'Selenium', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (24, N'Seng', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (25, N'Stannum', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (26, N'TDS', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (27, N'Tembaga', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (28, N'Timah Hitam', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (29, N'Timbal', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (30, N'TSS', 1)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (31, N'Air Raksa Total', 3)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (32, N'Ammonia', 3)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (33, N'Arsen Total', 3)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (34, N'Klorida', 3)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (35, N'pH', 3)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (36, N'Sulfida Terlarut', 3)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (37, N'TDS', 3)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (38, N'Temperatur', 3)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (39, N'Klorida', 5)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (40, N'TDS', 5)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (41, N'TS', 5)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (42, N'TSS', 5)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (43, N'Klorida', 6)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (44, N'TDS', 6)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (45, N'TSS', 6)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (46, N'TS', 6)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (47, N'BOD', 7)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (48, N'Minyak dan Lemak', 7)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (49, N'pH', 7)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (50, N'TSS', 7)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (51, N'CO2', 8)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (52, N'H2S', 8)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (53, N'NH3', 8)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (54, N'NO2', 8)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (55, N'SO2', 8)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (56, N'CO', 9)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (57, N'CO2', 9)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (58, N'H2S', 9)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (59, N'NH3', 9)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (60, N'NO2', 9)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (61, N'SO2', 9)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (62, N'TSP', 9)
INSERT [dbo].[graphic_parameter] ([id], [parameter], [type]) VALUES (63, N'Kebisingan (Lsm)', 10)
SET IDENTITY_INSERT [dbo].[graphic_parameter] OFF
SET IDENTITY_INSERT [dbo].[graphic_type] ON 

INSERT [dbo].[graphic_type] ([id], [name], [peraturan]) VALUES (1, N'Monitoring Wells', N'Surat dari Kementerian Negara LH Nomor : B-7993/Dep.IV/LH/10/2007 tentang Surat Tidak Keberatan Penempatan Limbah Drilling Cutting di Landfill WWQ Magma Nusantara, Ltd')
INSERT [dbo].[graphic_type] ([id], [name], [peraturan]) VALUES (2, N'Drainage Effluent', N'PerMenLH No 19/2010 ')
INSERT [dbo].[graphic_type] ([id], [name], [peraturan]) VALUES (3, N'Produced Water', N'PerMenLH No 4/2007')
INSERT [dbo].[graphic_type] ([id], [name], [peraturan]) VALUES (5, N'Surface Water', N'PP No.82, tahun 2001 kualitas air kelas tiga, PP No.82, tahun 2001 kualitas air kelas dua')
INSERT [dbo].[graphic_type] ([id], [name], [peraturan]) VALUES (6, N'Groundwater', N'PerMenKes RI No: 416/MenKes/Per/IX/1990 ')
INSERT [dbo].[graphic_type] ([id], [name], [peraturan]) VALUES (7, N'Waste Water', N'KepMenLH No 112 Tahun 2003 ttg Baku Mutu Air Limbah Domestik')
INSERT [dbo].[graphic_type] ([id], [name], [peraturan]) VALUES (8, N'Air Emissions', N'PermenLH no. 21 tahun 2008 tentang Baku Mutu Emisi Sumber Tidak Bergerak Bagi Usaha dan/atau Kegiatan Pembangkit Tenaga Listrik Termal')
INSERT [dbo].[graphic_type] ([id], [name], [peraturan]) VALUES (9, N'Air Ambient', N'KEP-50 /MENLH/11/1996 ttg Baku Tingkat Kebauan, PP 41/1999 ttg Pengendalian Pencemaran Udara')
INSERT [dbo].[graphic_type] ([id], [name], [peraturan]) VALUES (10, N'Noise', N'KEP - 48/MENLH/11/1996 ttg Baku Tingkat Kebisingan')
SET IDENTITY_INSERT [dbo].[graphic_type] OFF
SET IDENTITY_INSERT [dbo].[graphics_unit] ON 

INSERT [dbo].[graphics_unit] ([id], [unit]) VALUES (1, N'mg/l')
SET IDENTITY_INSERT [dbo].[graphics_unit] OFF
SET IDENTITY_INSERT [dbo].[hazardous_record] ON 

INSERT [dbo].[hazardous_record] ([id], [date], [id_waste], [id_source], [no_kemasan], [kemasan], [volume_weight], [internal_document], [type], [tujuan], [external_document], [id_satuan], [max_penyimpanan]) VALUES (1, CAST(0x9F370B00 AS Date), 1, 10, N'1 - 2', N'20 drums', 1000, N'wwwwwwwwwwww', 0, NULL, NULL, 1, NULL)
INSERT [dbo].[hazardous_record] ([id], [date], [id_waste], [id_source], [no_kemasan], [kemasan], [volume_weight], [internal_document], [type], [tujuan], [external_document], [id_satuan], [max_penyimpanan]) VALUES (3, CAST(0x9F370B00 AS Date), 1, NULL, NULL, N'sadasdas', 1250, N'erterte', 1, N'retertret ert', N'ertert', 1, NULL)
INSERT [dbo].[hazardous_record] ([id], [date], [id_waste], [id_source], [no_kemasan], [kemasan], [volume_weight], [internal_document], [type], [tujuan], [external_document], [id_satuan], [max_penyimpanan]) VALUES (4, CAST(0xA4370B00 AS Date), 1, 10, N'3 - 4', N'30 drums', 3000, N'wadawdwae', 0, NULL, NULL, 1, CAST(0xED370B00 AS Date))
INSERT [dbo].[hazardous_record] ([id], [date], [id_waste], [id_source], [no_kemasan], [kemasan], [volume_weight], [internal_document], [type], [tujuan], [external_document], [id_satuan], [max_penyimpanan]) VALUES (5, CAST(0xA6370B00 AS Date), 1, 10, N'5 - 6', N'10 drums', 500, N'asdas', 0, NULL, NULL, 1, CAST(0xF1370B00 AS Date))
INSERT [dbo].[hazardous_record] ([id], [date], [id_waste], [id_source], [no_kemasan], [kemasan], [volume_weight], [internal_document], [type], [tujuan], [external_document], [id_satuan], [max_penyimpanan]) VALUES (6, CAST(0x9F370B00 AS Date), 2, 10, N'7-8', N'10 drums', 750, N'adadasdsad', 0, NULL, NULL, 1, CAST(0xED370B00 AS Date))
INSERT [dbo].[hazardous_record] ([id], [date], [id_waste], [id_source], [no_kemasan], [kemasan], [volume_weight], [internal_document], [type], [tujuan], [external_document], [id_satuan], [max_penyimpanan]) VALUES (7, CAST(0xD7370B00 AS Date), 1, 10, N'sdsad', N'asdsad', 100, N'sadad', 0, NULL, NULL, 1, CAST(0x31380B00 AS Date))
INSERT [dbo].[hazardous_record] ([id], [date], [id_waste], [id_source], [no_kemasan], [kemasan], [volume_weight], [internal_document], [type], [tujuan], [external_document], [id_satuan], [max_penyimpanan]) VALUES (8, CAST(0xD7370B00 AS Date), 1, 10, N'asdasd', N'asdas', 100, N'dfdfgd', 0, NULL, NULL, 1, CAST(0x31380B00 AS Date))
INSERT [dbo].[hazardous_record] ([id], [date], [id_waste], [id_source], [no_kemasan], [kemasan], [volume_weight], [internal_document], [type], [tujuan], [external_document], [id_satuan], [max_penyimpanan]) VALUES (9, CAST(0xD7370B00 AS Date), 1, 10, N'dfgdf', N'dfgdfg', 200, N'sdfdsfs', 0, NULL, NULL, 1, CAST(0x31380B00 AS Date))
SET IDENTITY_INSERT [dbo].[hazardous_record] OFF
SET IDENTITY_INSERT [dbo].[lokasi_sampling] ON 

INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (1, N'Baku Mutu', 1)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (2, N'Baku Mutu', 2)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (3, N'Baku Mutu Atas', 1)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (6, N'Settling Pond', 2)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (7, N'Hulu', 1)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (8, N'Hilir 1', 1)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (9, N'Hilir 2', 1)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (10, N'Baku Mutu Bawah', 1)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (11, N'Batas Alarm', 2)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (12, N'U-seal Pit 1', 2)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (13, N'U-seal Pit 2', 2)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (14, N'Oil Catcher WH-1', 2)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (15, N'Oil Separator SS-1', 2)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (16, N'Oil Separator WH-1', 2)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (17, N'SS 1 Pump Area', 2)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (18, N'Baku Mutu', 3)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (19, N'Baku Mutu Atas', 3)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (20, N'Baku Mutu Bawah', 3)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (21, N'Brine Water', 3)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (22, N'Kondensat', 3)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (23, N'Thermal Pond', 3)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (24, N'Baku Mutu', 5)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (25, N'Hot Spring Cibolang', 5)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (26, N'Kali Hulu Villa', 5)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (27, N'Kali Hilir Villa', 5)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (28, N'Kali SS-1', 5)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (29, N'Kali Warehouse', 5)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (30, N'Baku Mutu', 6)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (31, N'Sumur Cibolang', 6)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (32, N'Sumur Sukaratu', 6)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (33, N'Baku Mutu', 7)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (34, N'Baku Mutu Atas', 7)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (35, N'Baku Mutu Bawah', 7)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (36, N'Air Olahan STP', 7)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (37, N'Batas Alarm', 7)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (38, N'Efisiensi STP', 7)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (39, N'Influent STP', 7)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (40, N'Baku Mutu', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (41, N'Batas Alarm', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (42, N'Cooling Tower A', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (43, N'Cooling Tower A-2', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (44, N'Cooling Tower B', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (45, N'Cooling Tower B-2', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (46, N'Cooling Tower C', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (47, N'Cooling Tower C-2', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (48, N'Cooling Tower D', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (49, N'Cooling Tower D-2', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (50, N'Cooling Tower E', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (51, N'Cooling Tower E-2', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (52, N'Cooling Tower F', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (53, N'Cooling Tower F-2', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (54, N'Cooling Tower G', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (55, N'Cooling Tower G-2', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (56, N'Cooling Tower H', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (57, N'Cooling Tower H-2', 8)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (58, N'Baku Mutu', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (59, N'Kp Cibitung', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (60, N'Kp Kertamanah', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (61, N'Kp Kertasari', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (62, N'Kp Sukaratu', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (63, N'Power Station', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (64, N'Power Station U-2', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (65, N'PS Utara', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (66, N'PS Barat', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (67, N'PS Selatan', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (68, N'PS Timur', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (69, N'Rock Muffler', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (70, N'WW Villa', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (71, N'WWS', 9)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (72, N'Baku Mutu Industri', 10)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (73, N'Baku Mutu Pemukiman', 10)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (74, N'Kp Cibitung', 10)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (75, N'Kp Kertasari', 10)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (76, N'Kp Kertamanah', 10)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (77, N'Kp Sukaratu', 10)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (78, N'Power Station', 10)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (79, N'Power Station U-2', 10)
INSERT [dbo].[lokasi_sampling] ([id], [lokasi_sampling], [type]) VALUES (80, N'WW Villa', 10)
SET IDENTITY_INSERT [dbo].[lokasi_sampling] OFF
SET IDENTITY_INSERT [dbo].[non_hazardous_record] ON 

INSERT [dbo].[non_hazardous_record] ([id], [date], [id_type], [waste_in], [waste_out], [recycle_rate]) VALUES (16, CAST(0xA6370B00 AS Date), 2, 150, 50, 20)
INSERT [dbo].[non_hazardous_record] ([id], [date], [id_type], [waste_in], [waste_out], [recycle_rate]) VALUES (18, CAST(0xA5370B00 AS Date), 1, 100, 80, 80)
INSERT [dbo].[non_hazardous_record] ([id], [date], [id_type], [waste_in], [waste_out], [recycle_rate]) VALUES (19, CAST(0x9D370B00 AS Date), 1, 50, 10, 10)
INSERT [dbo].[non_hazardous_record] ([id], [date], [id_type], [waste_in], [waste_out], [recycle_rate]) VALUES (20, CAST(0xA6370B00 AS Date), 1, 100, 80, 32)
INSERT [dbo].[non_hazardous_record] ([id], [date], [id_type], [waste_in], [waste_out], [recycle_rate]) VALUES (27, CAST(0x9D370B00 AS Date), 1, 50, 10, 10)
INSERT [dbo].[non_hazardous_record] ([id], [date], [id_type], [waste_in], [waste_out], [recycle_rate]) VALUES (31, CAST(0xBA370B00 AS Date), 2, 20, 5, 25)
INSERT [dbo].[non_hazardous_record] ([id], [date], [id_type], [waste_in], [waste_out], [recycle_rate]) VALUES (32, CAST(0xD7370B00 AS Date), 2, 123, 12, 0.81190798376184026)
INSERT [dbo].[non_hazardous_record] ([id], [date], [id_type], [waste_in], [waste_out], [recycle_rate]) VALUES (38, CAST(0xD7370B00 AS Date), 1, 123, 123123, 8330.3788903924233)
SET IDENTITY_INSERT [dbo].[non_hazardous_record] OFF
SET IDENTITY_INSERT [dbo].[satuan_unit] ON 

INSERT [dbo].[satuan_unit] ([id], [satuan], [unit_conversion]) VALUES (1, N'litres', 1)
SET IDENTITY_INSERT [dbo].[satuan_unit] OFF
SET IDENTITY_INSERT [dbo].[source_of_waste] ON 

INSERT [dbo].[source_of_waste] ([id], [source]) VALUES (10, N'Laboratorium')
INSERT [dbo].[source_of_waste] ([id], [source]) VALUES (11, N'Testing Unit asdweq w')
SET IDENTITY_INSERT [dbo].[source_of_waste] OFF
SET IDENTITY_INSERT [dbo].[type_of_waste] ON 

INSERT [dbo].[type_of_waste] ([id], [name]) VALUES (1, N'Organik')
INSERT [dbo].[type_of_waste] ([id], [name]) VALUES (2, N'Kertas')
SET IDENTITY_INSERT [dbo].[type_of_waste] OFF
SET IDENTITY_INSERT [dbo].[waste_hazardous] ON 

INSERT [dbo].[waste_hazardous] ([id], [name], [waste_code]) VALUES (1, N'asdsd asda sd', N'D 123112')
INSERT [dbo].[waste_hazardous] ([id], [name], [waste_code]) VALUES (2, N'erertvfdfd', N'D 45454')
SET IDENTITY_INSERT [dbo].[waste_hazardous] OFF
ALTER TABLE [dbo].[graphic_data]  WITH CHECK ADD  CONSTRAINT [FK_graphic_data_graphic_parameter] FOREIGN KEY([id_parameter])
REFERENCES [dbo].[graphic_parameter] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[graphic_data] CHECK CONSTRAINT [FK_graphic_data_graphic_parameter]
GO
ALTER TABLE [dbo].[graphic_data]  WITH CHECK ADD  CONSTRAINT [FK_graphic_data_lokasi_sampling] FOREIGN KEY([id_lokasi])
REFERENCES [dbo].[lokasi_sampling] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[graphic_data] CHECK CONSTRAINT [FK_graphic_data_lokasi_sampling]
GO
ALTER TABLE [dbo].[hazardous_record]  WITH CHECK ADD  CONSTRAINT [FK_hazardous_record_satuan_unit] FOREIGN KEY([id_satuan])
REFERENCES [dbo].[satuan_unit] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[hazardous_record] CHECK CONSTRAINT [FK_hazardous_record_satuan_unit]
GO
ALTER TABLE [dbo].[hazardous_record]  WITH CHECK ADD  CONSTRAINT [FK_hazardous_record_source_of_waste] FOREIGN KEY([id_source])
REFERENCES [dbo].[source_of_waste] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[hazardous_record] CHECK CONSTRAINT [FK_hazardous_record_source_of_waste]
GO
ALTER TABLE [dbo].[hazardous_record]  WITH CHECK ADD  CONSTRAINT [FK_hazardous_record_waste_hazardous] FOREIGN KEY([id_waste])
REFERENCES [dbo].[waste_hazardous] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[hazardous_record] CHECK CONSTRAINT [FK_hazardous_record_waste_hazardous]
GO
ALTER TABLE [dbo].[non_hazardous_record]  WITH CHECK ADD  CONSTRAINT [FK_non_hazardous_record_type_of_waste] FOREIGN KEY([id_type])
REFERENCES [dbo].[type_of_waste] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[non_hazardous_record] CHECK CONSTRAINT [FK_non_hazardous_record_type_of_waste]
GO
USE [master]
GO
ALTER DATABASE [star_energy_enviro] SET  READ_WRITE 
GO
