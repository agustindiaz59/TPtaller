-- Crear base de datos
CREATE DATABASE gymbd;
USE gymbd;

-- Creacion de tablas
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

create table usuario(
	id int auto_increment primary key,
	nombre varchar(50) not null,
	contrasenia varchar(50) not null
);


-- Insert de membresias disponibles

insert into membresia(id_membresia, nombre) values
(1,"STANDARD"),
(2,"PREMIUM"),
(3,"PERSONALIZADO")
;

insert into usuario(nombre, contrasenia) values
("admin", "1234"),
("matias","contrasenia"),
("leo","ejemplo")
;


-- -- -- -- -- -- -- -- -- -- -- otras consultas de prueba

drop schema gymbd;

select count(id)
from usuario
where nombre = "admin"
;

ALTER TABLE miembro
ADD CONSTRAINT miembro_ibfk_2 FOREIGN KEY (id_persona) REFERENCES persona(id_persona);

ALTER TABLE miembro
DROP FOREIGN KEY id_persona,
ADD CONSTRAINT (id_persona) FOREIGN KEY (id_persona)
REFERENCES persona(id_persona) ON DELETE CASCADE;

use gymbd;
show tables;
select * from persona p;
SELECT * FROM Personal WHERE cuil = "20-54617444-5";
DELETE FROM Persona WHERE id_persona = 3; DELETE FROM Personal WHERE cuil = "20-44617444-5";

select *
from personal; 
cross join miembro m ;


select * from miembro m 
inner join persona p
on p.id_persona = m.id_persona 
where p.f_inicio like '%10%';
