create database capadedatos
use capadedatos

CREATE TABLE Usuarios(
ID int identity(1,1) primary key,
Nombre VARCHAR(30),
Apellido VARCHAR(30),
Nom_Usuario VARCHAR(30),
Contrasenia VARCHAR(30)
);

CREATE TABLE Agenda (
    id INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    FechaNacimiento VARCHAR(50),
    Direccion VARCHAR(100),
    Genero VARCHAR(10),
    EstadoCivil VARCHAR(20),
    Movil VARCHAR(20),
    Telefono VARCHAR(20),
    CorreoElectronico VARCHAR(100)
);

select * from Agenda

--procedure
CREATE PROC SP_CrearUsuario
@Nombre VARCHAR(30),
@Apellido VARCHAR(30),
@Nom_Usuario VARCHAR(30),
@Contrasenia VARCHAR(30)
as
Insert into Usuarios values(@Nombre, @Apellido , @Nom_Usuario , @Contrasenia)
Go

select * from Usuarios