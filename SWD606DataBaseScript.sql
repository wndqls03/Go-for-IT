USE [master]
GO
/****** Object:  Database [Customer]    Script Date: 23/11/2023 1:47:43 pm ******/
CREATE DATABASE [Customer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Customer', FILENAME = N'C:\Users\HWACHAN LEE\Customer.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Customer_log', FILENAME = N'C:\Users\HWACHAN LEE\Customer_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Customer] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Customer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Customer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Customer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Customer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Customer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Customer] SET ARITHABORT OFF 
GO
ALTER DATABASE [Customer] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Customer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Customer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Customer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Customer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Customer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Customer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Customer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Customer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Customer] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Customer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Customer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Customer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Customer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Customer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Customer] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Customer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Customer] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Customer] SET  MULTI_USER 
GO
ALTER DATABASE [Customer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Customer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Customer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Customer] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Customer] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Customer] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Customer] SET QUERY_STORE = OFF
GO
USE [Customer]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 23/11/2023 1:47:43 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[id] [int] NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 23/11/2023 1:47:43 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] NOT NULL,
	[CustomerName] [nvarchar](255) NULL,
	[Age] [int] NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Address] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([id], [Username], [Password]) VALUES (1, N'noel1', N'noellee1')
INSERT [dbo].[Admin] ([id], [Username], [Password]) VALUES (2, N'joel1', N'jongeun1')
INSERT [dbo].[Admin] ([id], [Username], [Password]) VALUES (3, N'alex1', N'whang1')
INSERT [dbo].[Admin] ([id], [Username], [Password]) VALUES (4, N'james1', N'kingdom1')
INSERT [dbo].[Admin] ([id], [Username], [Password]) VALUES (5, N'lee2151', N'chan123')
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Age], [Username], [Password], [Address]) VALUES (1, N'John Doe', 30, N'johndoe123', N'password123', N'123 Main St')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Age], [Username], [Password], [Address]) VALUES (2, N'Jane Smith', 25, N'janesmith456', N'securepass', N'456 Elm St')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Age], [Username], [Password], [Address]) VALUES (3, N'Michael Johnson', 40, N'mikej', N'mysecret', N'789 Oak St')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Age], [Username], [Password], [Address]) VALUES (4, N'Emily Brown', 35, N'emilyb', N'pwd987', N'567 Maple Ave')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Age], [Username], [Password], [Address]) VALUES (5, N'David Lee', 50, N'davidl', N'mysecurepass', N'321 Birch Rd')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Age], [Username], [Password], [Address]) VALUES (6, N'Sophia Wilson', 22, N'sophiaw', N'pass456', N'987 Cedar Ln')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Age], [Username], [Password], [Address]) VALUES (7, N'William Davis', 28, N'williamd', N'davispass', N'654 Pine St')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Age], [Username], [Password], [Address]) VALUES (8, N'Olivia Martinez', 48, N'oliviam', N'olivia123', N'234 Redwood Dr')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Age], [Username], [Password], [Address]) VALUES (9, N'James Miller', 55, N'jamesm', N'millerpass', N'876 Cypress Ave')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Age], [Username], [Password], [Address]) VALUES (10, N'Ava Taylor', 32, N'avat', N'taylorpwd', N'543 Sequoia Rd')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Age], [Username], [Password], [Address]) VALUES (11, N'James', 37, N'jameking', N'imking', N'Auckland')
GO
USE [master]
GO
ALTER DATABASE [Customer] SET  READ_WRITE 
GO
