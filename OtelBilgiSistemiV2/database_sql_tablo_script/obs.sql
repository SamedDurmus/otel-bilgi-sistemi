USE [OtelBilgiSistemiDB]
GO
/****** Object:  Table [dbo].[AdminGirisi]    Script Date: 6/4/2020 3:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminGirisi](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](30) NOT NULL,
	[UserPassword] [nvarchar](30) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriBilgileri]    Script Date: 6/4/2020 3:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriBilgileri](
	[MusteriID] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [varchar](30) NULL,
	[Soyadi] [varchar](50) NULL,
	[Cinsiyet] [varchar](6) NULL,
	[Telefon] [varchar](17) NULL,
	[TcNo] [decimal](11, 0) NULL,
	[Email] [varchar](50) NULL,
	[OdaNo] [varchar](10) NULL,
	[GirisTarihi] [date] NULL,
	[CikisTarihi] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OdaBilgileri]    Script Date: 6/4/2020 3:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OdaBilgileri](
	[OdaID] [int] IDENTITY(1,1) NOT NULL,
	[OdaNo] [nvarchar](30) NULL,
	[MusteriAdi] [nvarchar](40) NULL,
	[MusteriSoyadi] [nvarchar](50) NULL,
	[OdaDurumu] [nvarchar](10) NULL,
	[OdaButonu] [nvarchar](25) NULL
) ON [PRIMARY]
GO
