USE [master]
GO
/****** Object:  Database [star_energy_enviro]    Script Date: 10/10/2013 10:22:23 AM ******/
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
/****** Object:  Table [dbo].[hazardous_record]    Script Date: 10/10/2013 10:22:24 AM ******/
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
/****** Object:  Table [dbo].[non_hazardous_record]    Script Date: 10/10/2013 10:22:24 AM ******/
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
/****** Object:  Table [dbo].[satuan_unit]    Script Date: 10/10/2013 10:22:24 AM ******/
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
/****** Object:  Table [dbo].[source_of_waste]    Script Date: 10/10/2013 10:22:24 AM ******/
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
/****** Object:  Table [dbo].[type_of_waste]    Script Date: 10/10/2013 10:22:24 AM ******/
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
/****** Object:  Table [dbo].[waste_hazardous]    Script Date: 10/10/2013 10:22:24 AM ******/
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
SET IDENTITY_INSERT [dbo].[hazardous_record] ON 

INSERT [dbo].[hazardous_record] ([id], [date], [id_waste], [id_source], [no_kemasan], [kemasan], [volume_weight], [internal_document], [type], [tujuan], [external_document], [id_satuan], [max_penyimpanan]) VALUES (1, CAST(0x9F370B00 AS Date), 1, 10, N'1 - 2', N'20 drums', 1000, N'wwwwwwwwwwww', 0, NULL, NULL, 1, NULL)
INSERT [dbo].[hazardous_record] ([id], [date], [id_waste], [id_source], [no_kemasan], [kemasan], [volume_weight], [internal_document], [type], [tujuan], [external_document], [id_satuan], [max_penyimpanan]) VALUES (3, CAST(0x9F370B00 AS Date), 1, NULL, NULL, N'sadasdas', 1250, N'erterte', 1, N'retertret ert', N'ertert', 1, NULL)
INSERT [dbo].[hazardous_record] ([id], [date], [id_waste], [id_source], [no_kemasan], [kemasan], [volume_weight], [internal_document], [type], [tujuan], [external_document], [id_satuan], [max_penyimpanan]) VALUES (4, CAST(0xA4370B00 AS Date), 1, 10, N'3 - 4', N'30 drums', 3000, N'wadawdwae', 0, NULL, NULL, 1, CAST(0xED370B00 AS Date))
INSERT [dbo].[hazardous_record] ([id], [date], [id_waste], [id_source], [no_kemasan], [kemasan], [volume_weight], [internal_document], [type], [tujuan], [external_document], [id_satuan], [max_penyimpanan]) VALUES (5, CAST(0xA6370B00 AS Date), 1, 10, N'5 - 6', N'10 drums', 500, N'asdas', 0, NULL, NULL, 1, CAST(0xF1370B00 AS Date))
INSERT [dbo].[hazardous_record] ([id], [date], [id_waste], [id_source], [no_kemasan], [kemasan], [volume_weight], [internal_document], [type], [tujuan], [external_document], [id_satuan], [max_penyimpanan]) VALUES (6, CAST(0x9F370B00 AS Date), 2, 10, N'7-8', N'10 drums', 750, N'adadasdsad', 0, NULL, NULL, 1, CAST(0xED370B00 AS Date))
SET IDENTITY_INSERT [dbo].[hazardous_record] OFF
SET IDENTITY_INSERT [dbo].[non_hazardous_record] ON 

INSERT [dbo].[non_hazardous_record] ([id], [date], [id_type], [waste_in], [waste_out], [recycle_rate]) VALUES (16, CAST(0xA6370B00 AS Date), 2, 150, 50, 33.333333333333329)
INSERT [dbo].[non_hazardous_record] ([id], [date], [id_type], [waste_in], [waste_out], [recycle_rate]) VALUES (18, CAST(0xA5370B00 AS Date), 1, 100, 80, 80)
SET IDENTITY_INSERT [dbo].[non_hazardous_record] OFF
SET IDENTITY_INSERT [dbo].[satuan_unit] ON 

INSERT [dbo].[satuan_unit] ([id], [satuan], [unit_conversion]) VALUES (1, N'litres', 1)
SET IDENTITY_INSERT [dbo].[satuan_unit] OFF
SET IDENTITY_INSERT [dbo].[source_of_waste] ON 

INSERT [dbo].[source_of_waste] ([id], [source]) VALUES (10, N'Laboratorium')
INSERT [dbo].[source_of_waste] ([id], [source]) VALUES (11, N'Testing Unit asdweq w')
INSERT [dbo].[source_of_waste] ([id], [source]) VALUES (12, N'Bla bla bla bla bla')
INSERT [dbo].[source_of_waste] ([id], [source]) VALUES (15, N'asdasdas asds adsa')
INSERT [dbo].[source_of_waste] ([id], [source]) VALUES (17, N'asdasd asdsada sasd')
INSERT [dbo].[source_of_waste] ([id], [source]) VALUES (18, N'Asdadsa asd asd as')
INSERT [dbo].[source_of_waste] ([id], [source]) VALUES (19, N'kjkjkljljkj kjlkj jklj lkj')
INSERT [dbo].[source_of_waste] ([id], [source]) VALUES (20, N'asdasd asd asd qewq qwe qqrqwrq r rwq rq')
SET IDENTITY_INSERT [dbo].[source_of_waste] OFF
SET IDENTITY_INSERT [dbo].[type_of_waste] ON 

INSERT [dbo].[type_of_waste] ([id], [name]) VALUES (1, N'Organik')
INSERT [dbo].[type_of_waste] ([id], [name]) VALUES (2, N'Kertas')
SET IDENTITY_INSERT [dbo].[type_of_waste] OFF
SET IDENTITY_INSERT [dbo].[waste_hazardous] ON 

INSERT [dbo].[waste_hazardous] ([id], [name], [waste_code]) VALUES (1, N'asdsd asda sd', N'D 123112')
INSERT [dbo].[waste_hazardous] ([id], [name], [waste_code]) VALUES (2, N'erertvfdfd', N'D 45454')
SET IDENTITY_INSERT [dbo].[waste_hazardous] OFF
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
