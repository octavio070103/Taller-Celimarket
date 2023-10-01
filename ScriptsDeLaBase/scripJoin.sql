SELECT u.id_usuario, u.nombre, u.apellido, u.dni, u.email,u.password,u.telefono,u.estado_usuario, r.id_rol, r.descripcion_rol,d.id_domicilio,d.calle,d.numero,d.provincia
FROM usuario u
INNER JOIN rol r ON u.id_rol = r.id_rol
INNER JOIN domicilio d On u.id_domicilio=d.id_domicilio

update usuario set estado_usuario = 0 where id_usuario = 4