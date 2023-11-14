/*REGISTRAR PERMISO */
CREATE PROCEDURE SP_REGISTRARPERMISO(
	/*parametros de entrada (que necesitamos para registrar un permiso) que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar un permiso*/
	@fecha_inicio date,
	@fecha_finalizacion date, 
	@comentario_justificacion VARCHAR(200),
	@estado_aprobacion VARCHAR(20),
	@estado_permiso BIT,
	@id_usuario INT,
	@id_motivo_permiso INT,
	/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
	@id_resultado_permiso INT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS 
BEGIN --el begin se utiliza para delimitar un bloque de codigo que contiene varias declaraciones, este Begin delimita el cuerpo de lprocedimiento almacenado
	/*aca seteo con un valor inicial mi var de salida*/
	SET @id_resultado_permiso = 0
	set @mensaje=''

									 -- Validación de datos
     --aca valido que los datos que recibo como parametros de entrada no sean nulos si alguno es nulo entra la if y NO registro el permiso
    IF( @fecha_inicio IS NULL OR @fecha_finalizacion IS NULL OR @comentario_justificacion IS NULL OR @estado_aprobacion IS NULL OR @estado_permiso IS NULL OR @id_usuario IS NULL OR @id_motivo_permiso IS NULL)
	BEGIN
		SET @mensaje= 'Datos nulos no se puede Registrar el Permiso'
	END
	ELSE
	--aca valido que para poder registro un permiso se cumpla que no exista en la base de datos un permiso con en el campo id_usuario =a mi parametro @id_usuario y que el valor de ese registro en estado_permiso=1 
	--es decir aca me aseguro que un usuario no tenga dos permisos activos (puede tener un sol opermiso activo por usuario)
		IF NOT EXISTS(select * from permiso where (id_usuario=@id_usuario AND estado_permiso = 1))
		 BEGIN
			 INSERT INTO permiso(fecha_inicio,fecha_finalizacion,comentario_justificacion,estado_permiso,id_usuario,id_motivo_permiso) 
			 VALUES(@fecha_inicio,@fecha_finalizacion,@comentario_justificacion,@estado_permiso,@id_usuario,@id_motivo_permiso)
			 
			 --obtener el Id del permiso recien insertado	 
			 SET @id_resultado_permiso=SCOPE_IDENTITY()
			 SET @mensaje = 'se registro correctmente el Permiso'
		 END
		 ELSE
		  BEGIN
			SET @mensaje = 'NO se registro el permiso ya que este Usuario ya tiene un permiso activo'
		  END
END
GO

	/*EDITAR PERMISO */
CREATE PROCEDURE SP_EDITARPERMISO(
@id_permiso INT,
@fecha_inicio date,
@fecha_finalizacion date, 
@comentario_justificacion VARCHAR(200),
@estado_aprobacion VARCHAR(20),
@estado_permiso BIT,
@id_usuario INT,
@id_motivo_permiso INT,

/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
@respuesta BIT OUTPUT,
@mensaje VARCHAR(500) OUTPUT
)
AS 
BEGIN --el begin se utiliza para delimitar un bloque de codigo que contiene varias declaraciones, este Begin delimita el cuerpo de lprocedimiento almacenado	
	
	/*aca seteo con un valor inicial mi var de salida*/
	SET @respuesta = 0 --aca seteo con un valor inicial mi var de salida ,0 es false 1 true, Inicialmente asumimos que la edición fallará.
	SET @mensaje=''  --Proporciona informacion sobre la oepracion

												-- Validación de datos
     --aca valido que los datos que recibo como parametros de entrada no sean nulos si alguno es nulo entra la if y NO edito el permiso
	IF(@id_permiso IS NULL OR @fecha_inicio IS NULL OR @fecha_finalizacion IS NULL OR @comentario_justificacion IS NULL OR @estado_permiso IS NULL OR @id_usuario IS NULL OR @id_motivo_permiso IS NULL)
	 BEGIN
		SET @mensaje='Datos Nulos No se puede Editar el Permiso'
	 END
	ELSE
	  BEGIN
	--aca valido que para poder editar un permiso se cumpla que no exista en la base de datos un permiso con en el campo id_usuario =a mi parametro @id_usuario y que el valor de ese registro en estado_permiso=1  y esto sea en otro registro distinto al que se esta editando
	--es decir aca me aseguro que un usuario no tenga dos permisos activos (puede tener un sol opermiso activo por usuario) y esto sea en un registro distinto al que se esta editando omito el permiso que estoy eidtando(ya que debo de tener en cuaenta esto pq sino lo hago wl where me encontrara un registro que no cumple siempre que va a ser el mismo que estoy editando por eso digo que lo omita)
		IF NOT EXISTS( select * from permiso where (id_usuario=@id_usuario AND estado_permiso=1) AND id_permiso!=@id_permiso)
		BEGIN
		--actualizacion del permiso
			UPDATE permiso SET
			fecha_inicio=@fecha_inicio,
			fecha_finalizacion=@fecha_finalizacion,
			comentario_justificacion=@comentario_justificacion,
			estado_aprobacion= @estado_aprobacion ,
			estado_permiso=@estado_permiso,
			id_usuario=@id_usuario,
			id_motivo_permiso=@id_motivo_permiso
			WHERE id_permiso=@id_permiso

			SET @mensaje=  'el permiso se edito correctamente'
			SET @respuesta=1/* Cambiamos la variable de respuesta a 1, lo que equivale a "true" */
		END
		ELSE
		BEGIN
			SET @mensaje='Error No se puede editar el permiso ya que Un usuario no Puede tener Dos Permisos Activos'
			
		END
	  END
END
GO

/*ACTUALIZAR EL ESTADO DEL PERMISO */
CREATE PROCEDURE SP_ACTUALIZARESTADO(
	/*parametros de entrada (que necesitamos para actulizar el estadi de un permiso) que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar un producto*/
	@id_permiso INT,
	@estado_aprobacion VARCHAR(20),
	/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
	@respuesta INT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS 
BEGIN
	SET @respuesta=0
	SET @mensaje=''
	DECLARE @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	IF NOT EXISTS(SELECT id_permiso FROM permiso  WHERE id_permiso=@id_permiso)
		BEGIN
			SET @mensaje='El Permiso que se quiere actualizar el estado no existe'
			SET @validacion=0
		END
	IF EXISTS(SELECT estado_aprobacion FROM permiso  WHERE id_permiso=@id_permiso AND estado_aprobacion='aprobado')
		BEGIN
			SET @mensaje='El permiso que se quiere Actulizar ya esta aprobado'
			SET @validacion=0
		END

	IF EXISTS(SELECT estado_aprobacion FROM permiso  WHERE id_permiso=@id_permiso AND estado_aprobacion='rechazado')
		BEGIN
		SET @mensaje='El permiso que se quiere Actulizar ya esta rechazado'
			SET @validacion=0
		END

	IF(@validacion=1)
	BEGIN
		--actualizacion del estado del permiso,lo damos de baja cambiamos a 0 el estado
		UPDATE permiso SET
		estado_aprobacion=@estado_aprobacion
		WHERE id_permiso=@id_permiso
		SET @mensaje=  'el Permiso se Actulizo correctamente'
		SET @respuesta=1/* Cambiamos la variable de respuesta a 1, lo que equivale a "true" */
	END
END
GO
