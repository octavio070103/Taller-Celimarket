
-- LISTAR CLIENTES: Este procedimiento se utiliza para listar todos los clientes registrados

CREATE PROCEDURE SP_ListarClientes
AS
SELECT cliente.id_cliente, persona.dni, persona.apellido, persona.nombre, persona.fecha_nacimiento, persona.telefono, fecha_creacion 
	FROM cliente

 	INNER JOIN persona on persona.id_persona = cliente.id_persona
	WHERE cliente.estado_cliente = 1
GO


-- REGISTRAR CLIENTE: Este procedimiento se utiliza para registrar un nuevo cliente

CREATE PROCEDURE SP_RegistrarCliente
(
  @dni VARCHAR(8),
  @nombre VARCHAR(50),
  @apellido VARCHAR(50),
  @fecha_nacimiento DATE,
  @telefono VARCHAR(50),
  @estado_cliente BIT,
  @mensaje VARCHAR(500) output
)
AS
BEGIN
  SET @mensaje = '';

  IF NOT EXISTS (SELECT * FROM persona WHERE dni = @dni)
    -- Si la persona que intentamos registrar no se encuentra registrada ya, se ejecutara este codigo
    BEGIN
	  
	  -- Realizamos una insercion en la tabla persona que sera utilizada para la insercion en la tabla cliente.
	  INSERT persona(dni, nombre, apellido, fecha_nacimiento, telefono, fecha_creacion)
	  VALUES (@dni, @nombre, @apellido, @fecha_nacimiento, @telefono, GETDATE());

	  -- Obtenemos el id de la persona que acabamos de insertar
	  DECLARE @aux_id_persona INT;
	  SET @aux_id_persona = SCOPE_IDENTITY();

	  INSERT INTO cliente(estado_cliente, id_persona, fecha_creacion_cliente)
	  VALUES (@estado_cliente, @aux_id_persona, GETDATE());

	  SET @mensaje = 'Se registro al cliente correctamente.';
	END;

  ELSE
    BEGIN
	  SET @mensaje = 'Este cliente ya ha sido registrado previamente.';
	END

END

GO


/*
--drop PROCEDURE SP_RegistrarCliente;


SELECT * from cliente
SELECT * from persona

-- **** PROBANDO EL PROCEDIMIENTO ALMACENADO: SP_RegistrarCliente
DECLARE  @mensaje VARCHAR(500);

-- Ejecutamos el procedimiento
EXEC SP_RegistrarCliente '42433566', 'Joaquin','Gomez', '2003-04-23', '4040404', 1, @mensaje output;

PRINT @mensaje;

*/

