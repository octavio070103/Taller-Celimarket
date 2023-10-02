SELECT u.id_usuario, u.email,u.password,u.fecha_registro,u.estado_usuario,p.id_persona,p.dni,p.nombre,p.apellido,p.fecha_nacimiento,p.telefono,r.id_rol, r.descripcion_rol,d.id_domicilio,d.calle,d.numero,d.provincia
                   FROM usuario u
                   INNER JOIN persona p ON u.id_persona = p.id_persona
                   INNER JOIN rol r ON u.id_rol = r.id_rol
                    INNER JOIN domicilio d On u.id_domicilio=d.id_domicilio

INSERT INTO persona(dni,nombre,apellido,fecha_nacimiento,telefono)
VALUES('44622119','octavio','sanchez','2003-01-07','3795058041');

select * from usuario

INSERT INTO rol(descripcion_rol,estado_rol)
VALUES('administrador',1);

INSERT INTO domicilio(calle,codigo_postal,numero,localidad,provincia,descripcion,estado_domicilio)
VALUES('garica de cossio',3400,'2310','corrientes','corrientes','es un departamento,domicilio en el primer piso',1);

INSERT INTO usuario(email,password,fecha_registro,estado_usuario,id_persona,id_rol,id_domicilio)
VALUES('octavio@gmail.com','1','2023-09-24',1,1,1,1);

-----------------------------------------------
INSERT INTO persona(dni,nombre,apellido,fecha_nacimiento,telefono)
VALUES('44622120','fernando','sanchez','2003-01-07','3795058040');

INSERT INTO rol(descripcion_rol,estado_rol)
VALUES('gerente',1);

INSERT INTO domicilio(calle,codigo_postal,numero,localidad,provincia,descripcion,estado_domicilio)
VALUES('honduras',3400,'2111','itati','corrientes','casa azul',1);

INSERT INTO usuario(email,password,fecha_registro,estado_usuario,id_persona,id_rol,id_domicilio)
VALUES('lautaro@gmail.com','1','2023-09-24',1,2,2,2);
--------------------------------------------

select * from domicilio