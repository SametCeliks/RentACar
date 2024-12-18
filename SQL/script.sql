USE [master]
GO
/****** Object:  Database [kirvem_rentacar]    Script Date: 8.06.2022 12:56:06 ******/
CREATE DATABASE [kirvem_rentacar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'kirvem_rentacar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\kirvem_rentacar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'kirvem_rentacar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\kirvem_rentacar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [kirvem_rentacar] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [kirvem_rentacar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [kirvem_rentacar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET ARITHABORT OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [kirvem_rentacar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [kirvem_rentacar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [kirvem_rentacar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [kirvem_rentacar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [kirvem_rentacar] SET  MULTI_USER 
GO
ALTER DATABASE [kirvem_rentacar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [kirvem_rentacar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [kirvem_rentacar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [kirvem_rentacar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [kirvem_rentacar] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [kirvem_rentacar] SET QUERY_STORE = OFF
GO
USE [kirvem_rentacar]
GO
/****** Object:  Table [dbo].[agreement]    Script Date: 8.06.2022 12:56:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[agreement](
	[tc] [nvarchar](50) NOT NULL,
	[namesurname] [nvarchar](50) NOT NULL,
	[phonenumber] [nvarchar](50) NOT NULL,
	[dlicense] [nvarchar](50) NOT NULL,
	[dl_date] [nvarchar](50) NOT NULL,
	[dl_place] [nvarchar](50) NOT NULL,
	[numberplate] [nvarchar](50) NOT NULL,
	[brand] [nvarchar](50) NOT NULL,
	[serie] [nvarchar](50) NOT NULL,
	[year] [nvarchar](50) NOT NULL,
	[color] [nvarchar](50) NOT NULL,
	[rent_type] [nvarchar](50) NOT NULL,
	[rent_price] [int] NOT NULL,
	[day] [int] NULL,
	[total] [int] NULL,
	[exdate] [nvarchar](50) NULL,
	[returndate] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[car]    Script Date: 8.06.2022 12:56:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[car](
	[numberplate] [nvarchar](50) NOT NULL,
	[brand] [nvarchar](50) NOT NULL,
	[serie] [nvarchar](50) NOT NULL,
	[year] [nvarchar](50) NOT NULL,
	[color] [nvarchar](50) NOT NULL,
	[km] [nvarchar](50) NOT NULL,
	[fuel] [nvarchar](50) NOT NULL,
	[price] [int] NOT NULL,
	[picture] [nvarchar](100) NOT NULL,
	[date] [nvarchar](50) NOT NULL,
	[position] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 8.06.2022 12:56:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[tcno] [nvarchar](50) NOT NULL,
	[namesurname] [nvarchar](50) NOT NULL,
	[phonenumber] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sales]    Script Date: 8.06.2022 12:56:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[tc] [nvarchar](50) NOT NULL,
	[namesurname] [nvarchar](50) NOT NULL,
	[numberplate] [nvarchar](50) NOT NULL,
	[brand] [nvarchar](50) NOT NULL,
	[serie] [nvarchar](50) NOT NULL,
	[year] [nvarchar](50) NOT NULL,
	[color] [nvarchar](50) NOT NULL,
	[day] [int] NOT NULL,
	[price] [int] NOT NULL,
	[total] [int] NOT NULL,
	[date1] [nvarchar](50) NOT NULL,
	[date2] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[agreement] ([tc], [namesurname], [phonenumber], [dlicense], [dl_date], [dl_place], [numberplate], [brand], [serie], [year], [color], [rent_type], [rent_price], [day], [total], [exdate], [returndate]) VALUES (N'50116427', N'SAMETCELİK', N'216544561', N'41651', N'165165', N'1415', N'43ERT150', N'Opel', N'Combo', N'2013', N'RED', N'Daily', 100, 7, 700, N'30.05.2022', N'6.06.2022')
INSERT [dbo].[agreement] ([tc], [namesurname], [phonenumber], [dlicense], [dl_date], [dl_place], [numberplate], [brand], [serie], [year], [color], [rent_type], [rent_price], [day], [total], [exdate], [returndate]) VALUES (N'201', N'Emine çelik', N'0132545898', N'1741', N'1211', N'1010', N'43 AAJ 542', N'Opel', N'Combo', N'2016', N'Blue', N'Weekly', 120, 5, 90, N'30.05.2022', N'30.05.2022')
INSERT [dbo].[agreement] ([tc], [namesurname], [phonenumber], [dlicense], [dl_date], [dl_place], [numberplate], [brand], [serie], [year], [color], [rent_type], [rent_price], [day], [total], [exdate], [returndate]) VALUES (N'50116427994', N'SAMETCELİK', N'216544561', N'11', N'12', N'13', N'43aat486', N'Honda', N'Accord', N'2008', N'grey', N'Weekly', 80, 5, 400, N'30.05.2022', N'4.06.2022')
INSERT [dbo].[agreement] ([tc], [namesurname], [phonenumber], [dlicense], [dl_date], [dl_place], [numberplate], [brand], [serie], [year], [color], [rent_type], [rent_price], [day], [total], [exdate], [returndate]) VALUES (N'201', N'Emine çelik', N'0132545898', N'14', N'14', N'4', N'43 AAJ 542', N'Opel', N'Combo', N'2016', N'Blue', N'Daily', 150, 5, 750, N'31.05.2022', N'5.06.2022')
INSERT [dbo].[agreement] ([tc], [namesurname], [phonenumber], [dlicense], [dl_date], [dl_place], [numberplate], [brand], [serie], [year], [color], [rent_type], [rent_price], [day], [total], [exdate], [returndate]) VALUES (N'17249529346', N'Hatice Demirtaş', N'05350525306', N'121', N'514', N'2222', N'10SH411', N'Nissan ', N'Almera', N'2010', N'Red', N'Monthly', 70, 1, 70, N'31.05.2022', N'1.06.2022')
INSERT [dbo].[agreement] ([tc], [namesurname], [phonenumber], [dlicense], [dl_date], [dl_place], [numberplate], [brand], [serie], [year], [color], [rent_type], [rent_price], [day], [total], [exdate], [returndate]) VALUES (N'201', N'Emine çelik', N'0132545898', N'1', N'84', N'841', N'43ERT150', N'Opel', N'Combo', N'2013', N'RED', N'Weekly', 80, 2, 160, N'31.05.2022', N'2.06.2022')
GO
INSERT [dbo].[car] ([numberplate], [brand], [serie], [year], [color], [km], [fuel], [price], [picture], [date], [position]) VALUES (N'34AZ120', N'Renault', N'Megane', N'2021', N'Black', N'61000', N'Diesel', 120, N'C:\Users\user\OneDrive\Masaüstü\projedöküman\megane.jpeg', N'22.05.2022 19:04:54', N'EMPTY')
INSERT [dbo].[car] ([numberplate], [brand], [serie], [year], [color], [km], [fuel], [price], [picture], [date], [position]) VALUES (N'06EB9875', N'Fiat', N'Egea', N'2013', N'White', N'140000', N'Gasoline+Gas', 500, N'C:\Users\user\OneDrive\Masaüstü\projedöküman\egea.jpeg', N'23.05.2022 20:03:15', N'EMPTY')
INSERT [dbo].[car] ([numberplate], [brand], [serie], [year], [color], [km], [fuel], [price], [picture], [date], [position]) VALUES (N'43 AAJ 542', N'Opel', N'Combo', N'2016', N'Blue', N'200000', N'Gasoline+Gas', 150, N'C:\Users\user\OneDrive\Masaüstü\projedöküman\combo.jpeg', N'24.05.2022 15:46:50', N'EMPTY')
INSERT [dbo].[car] ([numberplate], [brand], [serie], [year], [color], [km], [fuel], [price], [picture], [date], [position]) VALUES (N'43ERT150', N'Opel', N'Combo', N'2013', N'RED', N'12000', N'Diesel', 100, N'C:\Users\user\OneDrive\Masaüstü\projedöküman\combo.jpeg', N'30.05.2022 03:10:46', N'EMPTY')
INSERT [dbo].[car] ([numberplate], [brand], [serie], [year], [color], [km], [fuel], [price], [picture], [date], [position]) VALUES (N'43aat486', N'Honda', N'Accord', N'2008', N'grey', N'80000', N'Gasoline+Gas', 100, N'C:\Users\user\OneDrive\Masaüstü\projedöküman\hondacivic.jpeg', N'30.05.2022 19:39:18', N'EMPTY')
INSERT [dbo].[car] ([numberplate], [brand], [serie], [year], [color], [km], [fuel], [price], [picture], [date], [position]) VALUES (N'10SH411', N'Nissan ', N'Almera', N'2010', N'Red', N'12200', N'Gasoline+Gas', 100, N'C:\Users\user\OneDrive\Masaüstü\projedöküman\corsa.jpeg', N'31.05.2022 17:49:59', N'EMPTY')
INSERT [dbo].[car] ([numberplate], [brand], [serie], [year], [color], [km], [fuel], [price], [picture], [date], [position]) VALUES (N'06NN06', N'Ford', N'Focus', N'2010', N'black', N'10000', N'Diesel', 110, N'C:\Users\user\OneDrive\Masaüstü\projedöküman\fiesta.jpeg', N'1.06.2022 11:21:20', N'FULL')
INSERT [dbo].[car] ([numberplate], [brand], [serie], [year], [color], [km], [fuel], [price], [picture], [date], [position]) VALUES (N'34SHC430', N'Mercedes', N'C180', N'2012', N'White', N'124', N'Gasoline+Gas', 500, N'C:\Users\user\OneDrive\Masaüstü\c180.jpeg', N'4.06.2022 01:10:07', N'EMPTY')
INSERT [dbo].[car] ([numberplate], [brand], [serie], [year], [color], [km], [fuel], [price], [picture], [date], [position]) VALUES (N'fsdxfggfsd', N'Fiat', N'Egea', N'02', N'dsf', N'541', N'Gasoline', 14, N'C:\Users\user\OneDrive\Masaüstü\redstepsL.jpeg', N'4.06.2022 01:35:19', N'EMPTY')
INSERT [dbo].[car] ([numberplate], [brand], [serie], [year], [color], [km], [fuel], [price], [picture], [date], [position]) VALUES (N'34AK414', N'Renault', N'Megane', N'2016', N'Black ', N'12000', N'Diesel', 150, N'C:\Users\user\OneDrive\Masaüstü\projedöküman\megane.jpeg', N'31.05.2022 20:50:07', N'EMPTY')
GO
INSERT [dbo].[customer] ([tcno], [namesurname], [phonenumber], [address], [email]) VALUES (N'651065251', N'Samet çeli', N'05565654', N'Kütahya', N'Samet@gmail.com')
INSERT [dbo].[customer] ([tcno], [namesurname], [phonenumber], [address], [email]) VALUES (N'1998454874', N'Hüseyin Çelilk ', N'05417419622', N'Afyonkarahisar ', N'hüseyin@gmail.com')
INSERT [dbo].[customer] ([tcno], [namesurname], [phonenumber], [address], [email]) VALUES (N'201', N'Emine çelik', N'0132545898', N'Bursa ', N'emine@gmail.com')
INSERT [dbo].[customer] ([tcno], [namesurname], [phonenumber], [address], [email]) VALUES (N'17249529346', N'Hatice Demirtaş', N'05350525306', N'Vefa', N'htcdrr@')
INSERT [dbo].[customer] ([tcno], [namesurname], [phonenumber], [address], [email]) VALUES (N'136', N'nuri', N'0000000', N'ankara', N'nuri@')
INSERT [dbo].[customer] ([tcno], [namesurname], [phonenumber], [address], [email]) VALUES (N'17249529345', N'Hatice Çelik', N'5076080205', N'Mugla/Marmaris', N'zengim@gmail.com')
GO
INSERT [dbo].[sales] ([tc], [namesurname], [numberplate], [brand], [serie], [year], [color], [day], [price], [total], [date1], [date2]) VALUES (N'201', N'Emine çelik', N'34AZ120', N'Renault', N'Megane', N'2021', N'Black', 2, 120, 240, N'30.05.2022', N'1.06.2022')
INSERT [dbo].[sales] ([tc], [namesurname], [numberplate], [brand], [serie], [year], [color], [day], [price], [total], [date1], [date2]) VALUES (N'17249529345', N'Hatice Çelik', N'34SHC430', N'Mercedes', N'C180', N'2012', N'White', 0, 350, 0, N'4.06.2022', N'4.06.2022')
GO
USE [master]
GO
ALTER DATABASE [kirvem_rentacar] SET  READ_WRITE 
GO
