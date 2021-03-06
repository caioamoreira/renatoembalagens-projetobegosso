USE [master]
GO
/****** Object:  Database [RenatoEmbalagens]    Script Date: 08/05/2018 10:26:12 ******/
CREATE DATABASE [RenatoEmbalagens]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RenatoEmbalagens', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\RenatoEmbalagens.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RenatoEmbalagens_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\RenatoEmbalagens_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RenatoEmbalagens] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RenatoEmbalagens].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RenatoEmbalagens] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET ARITHABORT OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RenatoEmbalagens] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RenatoEmbalagens] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RenatoEmbalagens] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RenatoEmbalagens] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RenatoEmbalagens] SET  MULTI_USER 
GO
ALTER DATABASE [RenatoEmbalagens] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RenatoEmbalagens] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RenatoEmbalagens] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RenatoEmbalagens] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [RenatoEmbalagens] SET DELAYED_DURABILITY = DISABLED 
GO
USE [RenatoEmbalagens]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 08/05/2018 10:26:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](35) NULL,
	[Endereco] [varchar](50) NULL,
	[Telefone] [char](11) NULL,
	[Celular] [char](11) NULL,
	[Cidade] [varchar](35) NULL,
	[Estado] [char](2) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 08/05/2018 10:26:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[idCompras] [int] IDENTITY(1,1) NOT NULL,
	[idFornecedor] [int] NULL,
	[DataCompra] [date] NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[idCompras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Detalhe_Compras]    Script Date: 08/05/2018 10:26:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalhe_Compras](
	[idCompras] [int] IDENTITY(1,1) NOT NULL,
	[idProdutos] [int] NULL,
	[Qtde] [float] NULL,
	[ValorPago] [float] NULL,
	[Total] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Detalhe_Venda]    Script Date: 08/05/2018 10:26:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalhe_Venda](
	[idVendas] [int] IDENTITY(1,1) NOT NULL,
	[idProdutos] [int] NULL,
	[qtde] [float] NULL,
	[valor] [float] NULL,
	[total] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 08/05/2018 10:26:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[idFornecedor] [int] IDENTITY(1,1) NOT NULL,
	[Empresa] [varchar](30) NULL,
	[Endereco] [varchar](30) NULL,
	[Telefone] [char](11) NULL,
	[Cidade] [varchar](35) NULL,
	[Estado] [char](2) NULL,
 CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED 
(
	[idFornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GastoViagem]    Script Date: 08/05/2018 10:26:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GastoViagem](
	[idGastoViagem] [int] IDENTITY(1,1) NOT NULL,
	[DataViagem] [date] NULL,
	[Destino] [varchar](100) NULL,
	[Despesas] [float] NULL,
 CONSTRAINT [PK_GastoViagem] PRIMARY KEY CLUSTERED 
(
	[idGastoViagem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Login]    Script Date: 08/05/2018 10:26:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[idLogin] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](30) NULL,
	[Senha] [varchar](16) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[idLogin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pagamento]    Script Date: 08/05/2018 10:26:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagamento](
	[idPagamento] [int] IDENTITY(1,1) NOT NULL,
	[idCompras] [int] NULL,
	[Parcela] [numeric](18, 0) NULL,
	[DataVencimento] [date] NULL,
	[Valor] [float] NULL,
	[Pago] [bit] NULL,
 CONSTRAINT [PK_Pagamento] PRIMARY KEY CLUSTERED 
(
	[idPagamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Produtos]    Script Date: 08/05/2018 10:26:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Produtos](
	[idProdutos] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](80) NULL,
	[ValorCompra] [float] NULL,
	[ValorVenda] [float] NULL,
	[Estoque] [float] NULL,
 CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED 
(
	[idProdutos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Recebimento_Vendas]    Script Date: 08/05/2018 10:26:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recebimento_Vendas](
	[idPagamentoVendas] [int] IDENTITY(1,1) NOT NULL,
	[idVendas] [int] NULL,
	[Parcela] [numeric](18, 0) NULL,
	[DataVencimento] [date] NULL,
	[Valor] [float] NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_Recebimento_Vendas] PRIMARY KEY CLUSTERED 
(
	[idPagamentoVendas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vendas]    Script Date: 08/05/2018 10:26:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendas](
	[idVendas] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NULL,
	[DataVenda] [date] NULL,
	[TotalGeral] [float] NULL,
 CONSTRAINT [PK_Vendas] PRIMARY KEY CLUSTERED 
(
	[idVendas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Fornecedor] FOREIGN KEY([idFornecedor])
REFERENCES [dbo].[Fornecedor] ([idFornecedor])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Fornecedor]
GO
ALTER TABLE [dbo].[Detalhe_Compras]  WITH CHECK ADD  CONSTRAINT [FK_Detalhe_Compras_Compras] FOREIGN KEY([idCompras])
REFERENCES [dbo].[Compras] ([idCompras])
GO
ALTER TABLE [dbo].[Detalhe_Compras] CHECK CONSTRAINT [FK_Detalhe_Compras_Compras]
GO
ALTER TABLE [dbo].[Detalhe_Compras]  WITH CHECK ADD  CONSTRAINT [FK_Detalhe_Compras_Produtos] FOREIGN KEY([idProdutos])
REFERENCES [dbo].[Produtos] ([idProdutos])
GO
ALTER TABLE [dbo].[Detalhe_Compras] CHECK CONSTRAINT [FK_Detalhe_Compras_Produtos]
GO
ALTER TABLE [dbo].[Detalhe_Venda]  WITH CHECK ADD  CONSTRAINT [FK_Detalhe_Venda_Produtos] FOREIGN KEY([idProdutos])
REFERENCES [dbo].[Produtos] ([idProdutos])
GO
ALTER TABLE [dbo].[Detalhe_Venda] CHECK CONSTRAINT [FK_Detalhe_Venda_Produtos]
GO
ALTER TABLE [dbo].[Detalhe_Venda]  WITH CHECK ADD  CONSTRAINT [FK_Detalhe_Venda_Vendas] FOREIGN KEY([idVendas])
REFERENCES [dbo].[Vendas] ([idVendas])
GO
ALTER TABLE [dbo].[Detalhe_Venda] CHECK CONSTRAINT [FK_Detalhe_Venda_Vendas]
GO
ALTER TABLE [dbo].[Pagamento]  WITH CHECK ADD  CONSTRAINT [FK_Pagamento_Compras] FOREIGN KEY([idCompras])
REFERENCES [dbo].[Compras] ([idCompras])
GO
ALTER TABLE [dbo].[Pagamento] CHECK CONSTRAINT [FK_Pagamento_Compras]
GO
ALTER TABLE [dbo].[Recebimento_Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Recebimento_Vendas_Vendas] FOREIGN KEY([idVendas])
REFERENCES [dbo].[Vendas] ([idVendas])
GO
ALTER TABLE [dbo].[Recebimento_Vendas] CHECK CONSTRAINT [FK_Recebimento_Vendas_Vendas]
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Cliente]
GO
USE [master]
GO
ALTER DATABASE [RenatoEmbalagens] SET  READ_WRITE 
GO
