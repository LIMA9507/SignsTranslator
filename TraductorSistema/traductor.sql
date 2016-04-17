USE [master]
GO
/****** Object:  Database [Traductor]    Script Date: 17/04/2016 02:29:14 p. m. ******/
CREATE DATABASE [Traductor]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Traductor', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Traductor.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Traductor_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Traductor_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Traductor] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Traductor].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Traductor] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Traductor] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Traductor] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Traductor] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Traductor] SET ARITHABORT OFF 
GO
ALTER DATABASE [Traductor] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Traductor] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Traductor] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Traductor] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Traductor] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Traductor] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Traductor] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Traductor] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Traductor] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Traductor] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Traductor] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Traductor] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Traductor] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Traductor] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Traductor] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Traductor] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Traductor] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Traductor] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Traductor] SET RECOVERY FULL 
GO
ALTER DATABASE [Traductor] SET  MULTI_USER 
GO
ALTER DATABASE [Traductor] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Traductor] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Traductor] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Traductor] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Traductor', N'ON'
GO
USE [Traductor]
GO
/****** Object:  Table [dbo].[Señas]    Script Date: 17/04/2016 02:29:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Señas](
	[idImagen] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Tipo] [int] NOT NULL,
	[Ruta] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Señas] PRIMARY KEY CLUSTERED 
(
	[idImagen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Señas] ON 

INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (1, N'A', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\a.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (2, N'B', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\B.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (3, N'C', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\C.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (4, N'D', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\d.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (5, N'E', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\e.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (6, N'F', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\f.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (7, N'G', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\g.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (8, N'H', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\h.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (9, N'I', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\i.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (10, N'J', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\j.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (11, N'K', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\k.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (12, N'L', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\l.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (13, N'M', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\m.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (14, N'N', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\n.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (15, N'Ñ', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\ñ.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (16, N'O', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\o.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (17, N'P', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\p.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (18, N'Q', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\q.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (19, N'R', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\r.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (20, N'S', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\s.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (21, N'T', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\t.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (22, N'U', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\u.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (23, N'V', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\v.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (24, N'W', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\w.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (25, N'X', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\x.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (26, N'Y', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\y.jpg')
INSERT [dbo].[Señas] ([idImagen], [Descripcion], [Tipo], [Ruta]) VALUES (27, N'Z', 1, N'C:\Users\Alberto Mexia\Desktop\abecedario\z.jpg')
SET IDENTITY_INSERT [dbo].[Señas] OFF
USE [master]
GO
ALTER DATABASE [Traductor] SET  READ_WRITE 
GO
