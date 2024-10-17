-- Crear base de datos
 CREATE DATABASE gymbd;
USE gymbd;
DELETE FROM Persona WHERE id_persona = @id_persona; DELETE FROM Personal WHERE cuil = @cuil;

truncate table Persona;
select * from Membresia;

create table Persona(
	id_persona int not null auto_increment primary key,
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	f_nacim varchar(25) not null,
	f_inicio varchar(25) not null,
	email varchar(75),
	direccion varchar(255),
	genero char not null,
	telefono varchar(15)
);

create table Membresia(
	id_membresia int primary key not null auto_increment,
	nombre varchar(50) not null
);

create table Miembro(
	dni varchar(15) primary key not null,
	horariogym varchar(50),
	id_membresia int not null,
	id_persona int not null,

	foreign key (id_membresia) references Membresia(id_membresia),
	foreign key (id_persona) references Persona(id_persona)
);

create table Personal(
	cuil varchar(19) primary key not null,
	id_persona int not null,
	
	foreign key (id_persona) references Persona(id_persona)
);

drop database gymbd;
truncate Persona;
use gymbd;
select * from Persona p
inner join Miembro m on p.id_persona = m.id_persona 
;

SELECT * FROM Miembro WHERE dni = "44617444";
DELETE FROM Persona WHERE id_persona = 16; DELETE FROM Miembro WHERE dni = "44617444";

ALTER TABLE miembro
ADD CONSTRAINT miembro_ibfk_2 FOREIGN KEY (id_persona) REFERENCES persona(id_persona);

update Miembro, Persona
set 
nombre = @nombre,
apellido = @apellido,
f_nacim = @f_nacim,
f_inicio = @f_inicio,
email = email,
direccion = @direccion,
genero = @genero;


insert into Membresia(nombre) values ("PERSONALIZADO");

DELETE p, pers 
FROM Persona pers 
JOIN miembro p 
ON p.id_persona = pers.id_persona 
WHERE p.dni = "";

ALTER TABLE miembro
DROP FOREIGN KEY id_persona,
ADD CONSTRAINT (id_persona) FOREIGN KEY (id_persona)
REFERENCES persona(id_persona) ON DELETE CASCADE;


insert into Persona(nombre, apellido, f_nacim, f_inicio, email, direccion, genero, telefono) values(
	@nombre,
	@apellido,
	@f_nacim,
	@f_inicio,
	@email, 
	@direccion,
	@genero,
	@telefono
);

insert into Miembro(dni, horariogym, id_membresia, id_persona) values(
	@dni,
	@horariogym,
	@id_membresia,
	(select maxvalue(id_persona) from Persona)
);
