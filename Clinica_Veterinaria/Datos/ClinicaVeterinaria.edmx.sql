
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/29/2023 15:58:21
-- Generated from EDMX file: C:\Users\Jhearvis\Desktop\Ejer3_Dalexa-Guillermo\Clinica_Veterinaria\Clinica_Veterinaria\Datos\ClinicaVeterinaria.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Clinica_Veterinaria];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UsuarioBitacora]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bitacoras] DROP CONSTRAINT [FK_UsuarioBitacora];
GO
IF OBJECT_ID(N'[dbo].[FK_FamiliaPersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personas] DROP CONSTRAINT [FK_FamiliaPersona];
GO
IF OBJECT_ID(N'[dbo].[FK_PacientePersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personas] DROP CONSTRAINT [FK_PacientePersona];
GO
IF OBJECT_ID(N'[dbo].[FK_VacunaHistorialMedico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HistorialMedicoSet] DROP CONSTRAINT [FK_VacunaHistorialMedico];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteHistorialMedico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HistorialMedicoSet] DROP CONSTRAINT [FK_PacienteHistorialMedico];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[Bitacoras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bitacoras];
GO
IF OBJECT_ID(N'[dbo].[Personas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personas];
GO
IF OBJECT_ID(N'[dbo].[Familias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Familias];
GO
IF OBJECT_ID(N'[dbo].[Vacunas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vacunas];
GO
IF OBJECT_ID(N'[dbo].[HistorialMedicoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HistorialMedicoSet];
GO
IF OBJECT_ID(N'[dbo].[Pacientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pacientes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [User] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Bitacoras'
CREATE TABLE [dbo].[Bitacoras] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fecha] nvarchar(max)  NOT NULL,
    [Accion] nvarchar(max)  NOT NULL,
    [UsuarioId] int  NOT NULL
);
GO

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [DNI] nvarchar(max)  NOT NULL,
    [FamiliaId] int  NOT NULL,
    [PacienteId] int  NOT NULL
);
GO

-- Creating table 'Familias'
CREATE TABLE [dbo].[Familias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Apellido1] nvarchar(max)  NOT NULL,
    [Property1] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Vacunas'
CREATE TABLE [dbo].[Vacunas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FechaVacunacion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HistorialMedicoSet'
CREATE TABLE [dbo].[HistorialMedicoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombreEnfermedad] nvarchar(max)  NOT NULL,
    [FechaEnfermedad] nvarchar(max)  NOT NULL,
    [PacienteId] int  NOT NULL,
    [VacunaId] int  NOT NULL
);
GO

-- Creating table 'Pacientes'
CREATE TABLE [dbo].[Pacientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Property1] nvarchar(max)  NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Alias] nvarchar(max)  NOT NULL,
    [Especie] nvarchar(max)  NOT NULL,
    [Raza] nvarchar(max)  NOT NULL,
    [ColorDePelo] nvarchar(max)  NOT NULL,
    [FechaNacimiento] nvarchar(max)  NOT NULL,
    [PesoMedio] nvarchar(max)  NOT NULL,
    [PesoActual] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bitacoras'
ALTER TABLE [dbo].[Bitacoras]
ADD CONSTRAINT [PK_Bitacoras]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [PK_Personas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Familias'
ALTER TABLE [dbo].[Familias]
ADD CONSTRAINT [PK_Familias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Vacunas'
ALTER TABLE [dbo].[Vacunas]
ADD CONSTRAINT [PK_Vacunas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HistorialMedicoSet'
ALTER TABLE [dbo].[HistorialMedicoSet]
ADD CONSTRAINT [PK_HistorialMedicoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pacientes'
ALTER TABLE [dbo].[Pacientes]
ADD CONSTRAINT [PK_Pacientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UsuarioId] in table 'Bitacoras'
ALTER TABLE [dbo].[Bitacoras]
ADD CONSTRAINT [FK_UsuarioBitacora]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioBitacora'
CREATE INDEX [IX_FK_UsuarioBitacora]
ON [dbo].[Bitacoras]
    ([UsuarioId]);
GO

-- Creating foreign key on [FamiliaId] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [FK_FamiliaPersona]
    FOREIGN KEY ([FamiliaId])
    REFERENCES [dbo].[Familias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FamiliaPersona'
CREATE INDEX [IX_FK_FamiliaPersona]
ON [dbo].[Personas]
    ([FamiliaId]);
GO

-- Creating foreign key on [PacienteId] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [FK_PacientePersona]
    FOREIGN KEY ([PacienteId])
    REFERENCES [dbo].[Pacientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacientePersona'
CREATE INDEX [IX_FK_PacientePersona]
ON [dbo].[Personas]
    ([PacienteId]);
GO

-- Creating foreign key on [VacunaId] in table 'HistorialMedicoSet'
ALTER TABLE [dbo].[HistorialMedicoSet]
ADD CONSTRAINT [FK_VacunaHistorialMedico]
    FOREIGN KEY ([VacunaId])
    REFERENCES [dbo].[Vacunas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VacunaHistorialMedico'
CREATE INDEX [IX_FK_VacunaHistorialMedico]
ON [dbo].[HistorialMedicoSet]
    ([VacunaId]);
GO

-- Creating foreign key on [PacienteId] in table 'HistorialMedicoSet'
ALTER TABLE [dbo].[HistorialMedicoSet]
ADD CONSTRAINT [FK_PacienteHistorialMedico]
    FOREIGN KEY ([PacienteId])
    REFERENCES [dbo].[Pacientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteHistorialMedico'
CREATE INDEX [IX_FK_PacienteHistorialMedico]
ON [dbo].[HistorialMedicoSet]
    ([PacienteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------