
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/23/2022 06:20:39
-- Generated from EDMX file: C:\Users\erolo\OneDrive\C# Dersleri Üsküdar Üniversitesi\Form Büyük Projeler\Alışveriş Uygulaması 22-04\Alışveriş Uygulaması\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GoturUygulama];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Satislar_Kuryeler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Satislar] DROP CONSTRAINT [FK_Satislar_Kuryeler];
GO
IF OBJECT_ID(N'[dbo].[FK_Satislar_Musteriler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Satislar] DROP CONSTRAINT [FK_Satislar_Musteriler];
GO
IF OBJECT_ID(N'[dbo].[FK_Satislar_Urunler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Satislar] DROP CONSTRAINT [FK_Satislar_Urunler];
GO
IF OBJECT_ID(N'[dbo].[FK_Urunler_Kategori]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Urunler] DROP CONSTRAINT [FK_Urunler_Kategori];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Kategori]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kategori];
GO
IF OBJECT_ID(N'[dbo].[Kullanicilar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kullanicilar];
GO
IF OBJECT_ID(N'[dbo].[Kuryeler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kuryeler];
GO
IF OBJECT_ID(N'[dbo].[Musteriler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Musteriler];
GO
IF OBJECT_ID(N'[dbo].[Satislar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Satislar];
GO
IF OBJECT_ID(N'[dbo].[Urunler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Urunler];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Kategori'
CREATE TABLE [dbo].[Kategori] (
    [KategoriID] int IDENTITY(1,1) NOT NULL,
    [Kategori_Adi] nvarchar(max)  NOT NULL,
    [Kategori_Tanim] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Kullanicilar'
CREATE TABLE [dbo].[Kullanicilar] (
    [KullaniciID] int IDENTITY(1,1) NOT NULL,
    [Kullanici_Adi] nvarchar(max)  NOT NULL,
    [Sifre] nvarchar(max)  NOT NULL,
    [Mail_Adresi] nvarchar(max)  NOT NULL,
    [Kullanici_Kontrol] bit  NULL
);
GO

-- Creating table 'Kuryeler'
CREATE TABLE [dbo].[Kuryeler] (
    [KuryeID] int IDENTITY(1,1) NOT NULL,
    [Kurye_Sirketi] nvarchar(max)  NOT NULL,
    [Kurye_Adi] nvarchar(max)  NOT NULL,
    [Kurye_Telefon] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Musteriler'
CREATE TABLE [dbo].[Musteriler] (
    [MusteriID] int IDENTITY(1,1) NOT NULL,
    [Musteri_Adi] nvarchar(max)  NOT NULL,
    [Musteri_Adres] nvarchar(max)  NOT NULL,
    [Musteri_Telefon] nvarchar(max)  NOT NULL,
    [Musteri_Sehir] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Satislar'
CREATE TABLE [dbo].[Satislar] (
    [SatisID] int IDENTITY(1,1) NOT NULL,
    [MusteriID] int  NOT NULL,
    [Satis_Tarihi] nvarchar(max)  NOT NULL,
    [Satis_OdenenTutar] nvarchar(max)  NOT NULL,
    [Satis_KuryeUcreti] nvarchar(max)  NOT NULL,
    [Satis_Adresi] nvarchar(max)  NOT NULL,
    [UrunID] int  NOT NULL,
    [KuryeID] int  NOT NULL
);
GO

-- Creating table 'Urunler'
CREATE TABLE [dbo].[Urunler] (
    [UrunID] int IDENTITY(1,1) NOT NULL,
    [Urun_Adi] nvarchar(max)  NOT NULL,
    [KategoriID] int  NOT NULL,
    [Urun_Fiyati] int  NOT NULL,
    [Urun_StokDuzeyi] int  NOT NULL,
    [UrunAciklama] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [KategoriID] in table 'Kategori'
ALTER TABLE [dbo].[Kategori]
ADD CONSTRAINT [PK_Kategori]
    PRIMARY KEY CLUSTERED ([KategoriID] ASC);
GO

-- Creating primary key on [KullaniciID] in table 'Kullanicilar'
ALTER TABLE [dbo].[Kullanicilar]
ADD CONSTRAINT [PK_Kullanicilar]
    PRIMARY KEY CLUSTERED ([KullaniciID] ASC);
GO

-- Creating primary key on [KuryeID] in table 'Kuryeler'
ALTER TABLE [dbo].[Kuryeler]
ADD CONSTRAINT [PK_Kuryeler]
    PRIMARY KEY CLUSTERED ([KuryeID] ASC);
GO

-- Creating primary key on [MusteriID] in table 'Musteriler'
ALTER TABLE [dbo].[Musteriler]
ADD CONSTRAINT [PK_Musteriler]
    PRIMARY KEY CLUSTERED ([MusteriID] ASC);
GO

-- Creating primary key on [SatisID] in table 'Satislar'
ALTER TABLE [dbo].[Satislar]
ADD CONSTRAINT [PK_Satislar]
    PRIMARY KEY CLUSTERED ([SatisID] ASC);
GO

-- Creating primary key on [UrunID] in table 'Urunler'
ALTER TABLE [dbo].[Urunler]
ADD CONSTRAINT [PK_Urunler]
    PRIMARY KEY CLUSTERED ([UrunID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [KategoriID] in table 'Urunler'
ALTER TABLE [dbo].[Urunler]
ADD CONSTRAINT [FK_Urunler_Kategori]
    FOREIGN KEY ([KategoriID])
    REFERENCES [dbo].[Kategori]
        ([KategoriID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Urunler_Kategori'
CREATE INDEX [IX_FK_Urunler_Kategori]
ON [dbo].[Urunler]
    ([KategoriID]);
GO

-- Creating foreign key on [KuryeID] in table 'Satislar'
ALTER TABLE [dbo].[Satislar]
ADD CONSTRAINT [FK_Satislar_Kuryeler]
    FOREIGN KEY ([KuryeID])
    REFERENCES [dbo].[Kuryeler]
        ([KuryeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Satislar_Kuryeler'
CREATE INDEX [IX_FK_Satislar_Kuryeler]
ON [dbo].[Satislar]
    ([KuryeID]);
GO

-- Creating foreign key on [MusteriID] in table 'Satislar'
ALTER TABLE [dbo].[Satislar]
ADD CONSTRAINT [FK_Satislar_Musteriler]
    FOREIGN KEY ([MusteriID])
    REFERENCES [dbo].[Musteriler]
        ([MusteriID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Satislar_Musteriler'
CREATE INDEX [IX_FK_Satislar_Musteriler]
ON [dbo].[Satislar]
    ([MusteriID]);
GO

-- Creating foreign key on [UrunID] in table 'Satislar'
ALTER TABLE [dbo].[Satislar]
ADD CONSTRAINT [FK_Satislar_Urunler]
    FOREIGN KEY ([UrunID])
    REFERENCES [dbo].[Urunler]
        ([UrunID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Satislar_Urunler'
CREATE INDEX [IX_FK_Satislar_Urunler]
ON [dbo].[Satislar]
    ([UrunID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------