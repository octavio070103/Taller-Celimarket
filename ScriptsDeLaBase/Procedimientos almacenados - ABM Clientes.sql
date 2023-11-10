-- *** ABM CLIENTE ***

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
-- **** PROBANDO EL PROCEDIMIENTO ALMACENADO: SP_RegistrarCliente
DECLARE  @mensaje VARCHAR(500);

-- Ejecutamos el procedimiento
EXEC SP_RegistrarCliente '42433566', 'Joaquin','Gomez', '2003-04-23', '4040404', 1, @mensaje output;

PRINT @mensaje;

*/


-- ELIMINAR CLIENTE: Este procedimiento permite eliminar de forma logica a un cliente del registro

CREATE PROCEDURE SP_EliminarCliente
(
  @id_cliente INT,
  @resultadoEjec INT OUTPUT
)
AS
BEGIN
    SET @resultadoEjec = 0;

	IF EXISTS ( SELECT * FROM cliente WHERE cliente.id_cliente = @id_cliente)
	  BEGIN
	    -- Si el cliente esta registrado, lo dara de baja logicamente al actualizar su estado_cliente a 0
	    UPDATE cliente SET estado_cliente = 0 WHERE cliente.id_cliente = @id_cliente;

		-- Si se dio de baja al cliente correctamente, el resultado de la ejecucion sera igual a 1
	    SET @resultadoEjec = 1;

	  END
END 

GO



-- EDITAR DATOS CLIENTE: Este procedimiento permite modificar los datos de los clientes

CREATE PROCEDURE SP_EditarDatosCliente
(
  @id_cliente int,
  @dni VARCHAR(8),
  @nombre VARCHAR(50),
  @apellido VARCHAR(50),
  @fecha_nacimiento DATE,
  @telefono VARCHAR(50),
  @resultadoEjec INT OUTPUT
)
AS
BEGIN

  SET @resultadoEjec = 0 -- Se asigna el valor 0 al resultado de la ejecucion, en caso de que la operacion no se realice
  -- Obtenemos el id de la persona que esta relacionada al perfil del cliente, la cual contiene todos los datos de este
  DECLARE @aux_id_persona INT;

  SELECT @aux_id_persona = id_persona FROM cliente WHERE (cliente.id_cliente = @id_cliente)

  IF(@aux_id_persona IS NOT NULL)

	BEGIN
	  -- *** Si no existe dentro de los registros una persona con el mismo DNI, y cuyo id_persona sea distinto al del cliente que se desea modificar
	  --*** entonces se puede modificar los datos del cliente, incluyendo el DNI.
	  IF NOT EXISTS (SELECT * FROM persona WHERE (persona.dni = @dni) AND persona.id_persona != @aux_id_persona )
	    BEGIN 
		  
		  -- *** Se actualizan los datos del cliente ***
		  UPDATE persona
		  SET dni = @dni,
			  nombre = @nombre,
			  apellido = @apellido,
			  fecha_nacimiento = @fecha_nacimiento,
			  telefono = @telefono
		  WHERE(id_persona = @aux_id_persona);

		  -- Se asigna el valor 1 al resultado de la ejecucion indicando que la modificacion se realizo con exito
		  SET @resultadoEjec = 1

		END

	END

END
GO

-- **** BUSCAR CLIENTE ****

CREATE PROCEDURE SP_BuscarCliente
(
  @terminoBusqueda VARCHAR,
  @tipoBusqueda INT
)
AS
  BEGIN 

    IF(@tipoBusqueda = 1) -- Busqueda por DNI
	  BEGIN
	    SELECT C.id_cliente, P.dni, P.apellido, P.nombre, P.fecha_nacimiento, P.telefono, fecha_creacion 
		FROM cliente AS C

 		INNER JOIN persona AS P on P.id_persona = C.id_persona
		WHERE P.dni LIKE ('%'+@terminoBusqueda+'%')
	  END

	ELSE IF (@tipoBusqueda = 2) -- Busqueda por apellido
	  BEGIN
		SELECT C.id_cliente, P.dni, P.apellido, P.nombre, P.fecha_nacimiento, P.telefono, fecha_creacion 
		FROM cliente AS C

 		INNER JOIN persona AS P on P.id_persona = C.id_persona
		WHERE upper(P.apellido) LIKE upper('%'+@terminoBusqueda+'%')
	  END

  END
GO