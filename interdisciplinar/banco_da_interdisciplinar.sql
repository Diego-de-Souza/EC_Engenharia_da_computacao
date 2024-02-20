USE master
go
--APAGANDO O BANCO DE DADOS COM O MESMO NOME QUE O SEU CASO EXISTA
drop database LancamentoBalistico
go
--CRIANDO O BANCO DE DADOS JÁ DANDO O LOCAL DE CADA ARQUIVO VAI SER SALVO
create database LancamentoBalistico
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LancamentoBalistico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\LancamentoBalistico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LancamentoBalistico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\LancamentoBalistico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
--CHAMANDO O BANCO DE DADOS CRIADO PARA SER USADO
USE [LancamentoBalistico]
GO
--ALGUMAS CONFIGURAÇÕES DO BANCO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
--CRIANDO A TABELA DE USUARIO
CREATE TABLE [dbo].[USUARIO](
	[idUsuario] [int] NOT NULL PRIMARY KEY,
	[nome] [varchar] (20) NOT NULL,
	[email] [varchar] (60) NOT NULL
)
go

CREATE TABLE [dbo].[PROJETIL](
	[idProjetil] [int] NOT NULL PRIMARY KEY,
	[posicaoInicialX] [float],
	[posicaoFinalX] [float],
	[posicaoInicialY] [float],
	[posicaoFinalY] [float],

)
go

CREATE TABLE [dbo].[LANCA](
	[IdLanca] [int] NOT NULL,
	[velInicial] [float] ,
	[angulo] [int],
	[idUsuario] [int],
	[idProjetil] [int],
	CONSTRAINT PK_id_lanca PRIMARY KEY (idUsuario,idProjetil),
	CONSTRAINT FK_id_usuario FOREIGN KEY (idUsuario) REFERENCES [dbo].[USUARIO] (idUsuario),
	CONSTRAINT FK_idProjetil FOREIGN KEY (idProjetil) REFERENCES [dbo].[PROJETIL] (idProjetil)
)
go

CREATE TABLE [dbo].[METEORO](
	[idMeteoro] [int] NOT NULL PRIMARY KEY,
	[posicaoInicialX] [float],
	[posicaoFinalX] [float],
	[posicaoInicialY] [float],
	[posicaoFinalY] [float],
)

CREATE TABLE [DBO].[intercepta](
	[idIntercepta] [int] not null,
	[tempo] [int],
	[pontoX] [float],
	[pontoY] [float],
	[idProjetil] [int],
	[idMeteoro] [int],
	CONSTRAINT PK_id_intercepta PRIMARY KEY (idProjetil,idMeteoro),
	CONSTRAINT FK_id_Projetil FOREIGN KEY (idProjetil) REFERENCES [dbo].[PROJETIL] (idProjetil),
	CONSTRAINT FK_id_Meteoro FOREIGN KEY (idMeteoro) REFERENCES [dbo].[METEORO] (idMeteoro)
)
