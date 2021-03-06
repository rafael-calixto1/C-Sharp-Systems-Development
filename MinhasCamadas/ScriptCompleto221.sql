USE [master]
GO
/****** Object:  Database [dbDS2]    Script Date: 25/05/2022 19:18:56 ******/
CREATE DATABASE [dbDS2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbDS2', FILENAME = N'c:\Arquivos de programas\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dbDS2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbDS2_log', FILENAME = N'c:\Arquivos de programas\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dbDS2_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbDS2] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbDS2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbDS2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbDS2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbDS2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbDS2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbDS2] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbDS2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbDS2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbDS2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbDS2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbDS2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbDS2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbDS2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbDS2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbDS2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbDS2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbDS2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbDS2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbDS2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbDS2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbDS2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbDS2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbDS2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbDS2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbDS2] SET  MULTI_USER 
GO
ALTER DATABASE [dbDS2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbDS2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbDS2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbDS2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbDS2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbDS2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbDS2] SET QUERY_STORE = OFF
GO
USE [dbDS2]
GO
/****** Object:  Table [dbo].[tblClientes]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblClientes](
	[CodCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](70) NOT NULL,
	[CPF] [char](11) NOT NULL,
	[Nascimento] [datetime] NOT NULL,
 CONSTRAINT [PK_tblClientes] PRIMARY KEY CLUSTERED 
(
	[CodCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTelefone]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTelefone](
	[CodigoCliente] [int] NOT NULL,
	[NumeroTelefone] [varchar](15) NOT NULL,
	[CodigoTelefoneTipo] [int] NOT NULL,
 CONSTRAINT [PK_tblTelefone] PRIMARY KEY CLUSTERED 
(
	[CodigoCliente] ASC,
	[NumeroTelefone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTelefoneTipo]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTelefoneTipo](
	[CodigoTelefoneTipo] [int] IDENTITY(1,1) NOT NULL,
	[DescricaoTelefoneTipo] [varchar](30) NOT NULL,
 CONSTRAINT [PK_tblTelefoneTipo] PRIMARY KEY CLUSTERED 
(
	[CodigoTelefoneTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblTelefone]  WITH CHECK ADD  CONSTRAINT [FK_tblTelefone_tblClientes] FOREIGN KEY([CodigoCliente])
REFERENCES [dbo].[tblClientes] ([CodCliente])
GO
ALTER TABLE [dbo].[tblTelefone] CHECK CONSTRAINT [FK_tblTelefone_tblClientes]
GO
ALTER TABLE [dbo].[tblTelefone]  WITH CHECK ADD  CONSTRAINT [FK_tblTelefone_tblTelefoneTipo] FOREIGN KEY([CodigoTelefoneTipo])
REFERENCES [dbo].[tblTelefoneTipo] ([CodigoTelefoneTipo])
GO
ALTER TABLE [dbo].[tblTelefone] CHECK CONSTRAINT [FK_tblTelefone_tblTelefoneTipo]
GO
/****** Object:  StoredProcedure [dbo].[_uspConsultaCliente_JOIN]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[_uspConsultaCliente_JOIN]
	@CodCliente INT

AS
BEGIN
	
	SELECT
		tblClientes.CodCliente,
		tblClientes.Nome,
		tblTelefone.NumeroTelefone,
		tblTelefoneTipo.DescricaoTelefoneTipo
	FROM
		tblClientes

	JOIN tblTelefone ON tblClientes.CodCliente = tblTelefone.CodigoCliente

	JOIN tblTelefoneTipo ON tblTelefone.CodigoTelefoneTipo = tblTelefoneTipo.CodigoTelefoneTipo

	WHERE
		tblClientes.CodCliente = @CodCliente

END

GO
/****** Object:  StoredProcedure [dbo].[_uspInserirClienteTelefone]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[_uspInserirClienteTelefone]
	@Nome VARCHAR(70),
	@CPF CHAR(11),
	@Nascimento DATE,
	@Telefone VARCHAR(15) = NULL,
	@CodigoTelefoneTipo INT = NULL

AS
BEGIN

	BEGIN TRY
		BEGIN TRAN

			INSERT INTO tblClientes (Nome, CPF, Nascimento)
				VALUES (@Nome, @CPF, @Nascimento)

			DECLARE @IDClienteNovo AS INT = @@IDENTITY

			INSERT INTO tblTelefone (CodigoCliente, NumeroTelefone, CodigoTelefoneTipo)
				VALUES (@IDClienteNovo, @Telefone, @CodigoTelefoneTipo)

			SELECT @IDClienteNovo AS Retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH


END



GO
/****** Object:  StoredProcedure [dbo].[uspAlterarCliente]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspAlterarCliente]
	@CodCliente INT,
	@Nome VARCHAR(70),
	@CPF CHAR(11),
	@Nascimento DATETIME
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			UPDATE tblClientes
				SET Nome = @Nome, CPF = @CPF, Nascimento = @Nascimento
			WHERE
				CodCliente = @CodCliente

			SELECT @CodCliente AS Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspAlterarTelefone]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspAlterarTelefone]
	@CodigoCliente INT,
	@NumeroTelefone VARCHAR(15),
	@TelefoneAntigo VARCHAR(15),
	@CodigoTelefoneTipo INT

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			UPDATE tblTelefone
				SET NumeroTelefone = @NumeroTelefone, CodigoTelefoneTipo = @CodigoTelefoneTipo
			WHERE CodigoCliente = @CodigoCliente AND NumeroTelefone = @TelefoneAntigo

			SELECT @CodigoCliente AS Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspAlterarTelefoneTipo]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspAlterarTelefoneTipo]
	@CodigoTelefoneTipo INT,
	@DescricaoTelefoneTipo VARCHAR(30)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			UPDATE tblTelefoneTipo
				SET DescricaoTelefoneTipo = @DescricaoTelefoneTipo
			WHERE CodigoTelefoneTipo = @CodigoTelefoneTipo

			SELECT @CodigoTelefoneTipo AS Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspConsultaClienteCodigo]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[uspConsultaClienteCodigo]
	@CodigoCliente	INT

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			SELECT * FROM tblClientes WHERE CodCliente = @CodigoCliente

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaClienteNome]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultaClienteNome]
	@Nome VARCHAR(70)

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			SELECT * FROM tblClientes WHERE Nome LIKE '%' +  @Nome + '%'

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaTelefone]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultaTelefone]

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			SELECT
				tblTelefone.CodigoCliente,
				tblTelefone.NumeroTelefone,
				tblTelefone.CodigoTelefoneTipo,
				tblTelefoneTipo.DescricaoTelefoneTipo

			FROM tblTelefone

			JOIN tblTelefoneTipo ON tblTelefone.CodigoTelefoneTipo = tblTelefoneTipo.CodigoTelefoneTipo

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaTelefoneCodigoCliente]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultaTelefoneCodigoCliente]
	@CodigoCliente INT

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			SELECT
				tblTelefone.CodigoCliente,
				tblTelefone.NumeroTelefone,
				tblTelefone.CodigoTelefoneTipo,
				tblTelefoneTipo.DescricaoTelefoneTipo

			FROM tblTelefone

			JOIN tblTelefoneTipo ON tblTelefone.CodigoTelefoneTipo = tblTelefoneTipo.CodigoTelefoneTipo

			WHERE CodigoCliente = @CodigoCliente

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaTelefoneTipo]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultaTelefoneTipo]
	
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			SELECT * FROM tblTelefoneTipo

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[uspExcluirCliente]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspExcluirCliente]
	@CodCliente INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			DELETE FROM tblClientes
				WHERE CodCliente = @CodCliente

			SELECT @CodCliente AS Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspExcluirTelefone]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspExcluirTelefone]
	@CodigoCliente INT,
	@NumeroTelefone VARCHAR(15)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			DELETE FROM tblTelefone
				WHERE CodigoCliente = @CodigoCliente AND NumeroTelefone = @NumeroTelefone

			SELECT @CodigoCliente AS Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[uspExcluirTelefoneTipo]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspExcluirTelefoneTipo]
	@CodigoTelefoneTipo INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			DELETE FROM tblTelefoneTipo
				WHERE CodigoTelefoneTipo = @CodigoTelefoneTipo

			SELECT @CodigoTelefoneTipo AS Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END




GO
/****** Object:  StoredProcedure [dbo].[uspInserirCliente]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspInserirCliente]
	@Nome VARCHAR(70),
	@CPF CHAR(11),
	@Nascimento DATETIME

AS
BEGIN

	BEGIN TRY
		BEGIN TRAN

			INSERT INTO tblClientes (Nome, CPF, Nascimento)
				VALUES (@Nome, @CPF, @Nascimento)

			DECLARE @IDClienteNovo AS INT = @@IDENTITY

			SELECT @IDClienteNovo AS Retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH


END

GO
/****** Object:  StoredProcedure [dbo].[uspInserirTelefone]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspInserirTelefone]
	@CodigoCliente INT,
	@NumeroTelefone VARCHAR(15),
	@CodigoTelefoneTipo INT

AS
BEGIN

	BEGIN TRY
		BEGIN TRAN

			INSERT INTO tblTelefone(CodigoCliente, NumeroTelefone, CodigoTelefoneTipo)
				VALUES (@CodigoCliente, @NumeroTelefone, @CodigoTelefoneTipo)

			SELECT @CodigoCliente AS Retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH


END

GO
/****** Object:  StoredProcedure [dbo].[uspInserirTelefoneTipo]    Script Date: 25/05/2022 19:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspInserirTelefoneTipo]
	/*@CodigoTelefoneTipo INT,*/
	@DescricaoTelefoneTipo VARCHAR(30)

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			INSERT INTO tblTelefoneTipo (DescricaoTelefoneTipo)
				VALUES (@DescricaoTelefoneTipo)

			SELECT @@IDENTITY as Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END




GO
USE [master]
GO
ALTER DATABASE [dbDS2] SET  READ_WRITE 
GO
