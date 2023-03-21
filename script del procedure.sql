create database capadedatos
use capadedatos

CREATE TABLE Usuarios(
ID int identity(1,1) primary key,
Nombre VARCHAR(30),
Apellido VARCHAR(30),
Nom_Usuario VARCHAR(30),
Contrasenia VARCHAR(30)
);


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