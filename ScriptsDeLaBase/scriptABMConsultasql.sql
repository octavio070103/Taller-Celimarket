/*REGISTRAR CONSULTA */
CREATE PROCEDURE SP_REGISTRARCONSULTA(
	/*parametros de entrada (que necesitamos para registrar un CONSULTA) que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar una consulta*/
	@comentario_consulta VARCHAR(200),
	@id_usuario INT,
	@id_motivo_consulta INT,

	/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
	@id_resultado_consulta INT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS 
BEGIN --el begin se utiliza para delimitar un bloque de codigo que contiene varias declaraciones, este Begin delimita el cuerpo de lprocedimiento almacenado
	/*aca seteo con un valor inicial mi var de salida*/
	SET @id_resultado_consulta = 0
	set @mensaje=''

									 -- Validación de datos
     --aca valido que los datos que recibo como parametros de entrada no sean nulos si alguno es nulo entra la if y NO registro la consulta
    IF( @comentario_consulta IS NULL OR @id_usuario IS NULL OR @id_motivo_consulta IS NULL )
	BEGIN
		SET @mensaje= 'Datos Son nulos no se puede Registrar la Consulta'
	END
	ELSE
	--aca valido que para poder registrar una consulta,que se cumpla que no exista en la base de datos una consulta con en el campo comentario_consulta =a mi parametro @comentario ya que asi le impido al usuario ingresar dos veces la misma consulta que tenga el mismo comentario
	--es decir aca me aseguro que un usuario no pueda ingresar dos consultas con el mismo comentario o consulta escrito(Contenido)
		IF NOT EXISTS(select * from consulta where comentario_consulta=@comentario_consulta )
		 BEGIN
			 INSERT INTO consulta(comentario_consulta,id_usuario,id_motivo_consulta) 
			 VALUES(@comentario_consulta,@id_usuario,@id_motivo_consulta)
			 
			 --obtener el Id del consulta recien insertado	 
			 SET @id_resultado_consulta=SCOPE_IDENTITY()
			 SET @mensaje = 'se registro correctmente el Consulta'
		 END
		 ELSE
		  BEGIN
			SET @mensaje = 'NO se registro el Consulta ya que este Usuario ya tiene una Consulta Con el mismo Contenido'
		  END
END

/*EDITAR Consulta */
CREATE PROCEDURE SP_EDITARCONSULTA(
/*parametros de entrada (que necesitamos para editar una CONSULTA) que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a editar una consulta*/
@id_consulta INT,
@comentario_consulta VARCHAR(200),
@estado_consulta VARCHAR(20),
@id_usuario INT,
@id_motivo_consulta INT,

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
     --aca valido que los datos que recibo como parametros de entrada no sean nulos si alguno es nulo entra la if y NO edito la consulta
	IF(@id_consulta IS NULL OR @comentario_consulta IS NULL OR @estado_consulta IS NULL OR @id_usuario IS NULL OR @id_motivo_consulta IS NULL OR @id_usuario IS NULL )
	 BEGIN
		SET @mensaje='Los Datos Nulos son No se puede Editar La consulta'
	 END
	ELSE
	  BEGIN
		IF EXISTS( select * from consulta where id_consulta=@id_consulta) --aca pregunto si existe una consulta con ese id_consulta que recibo como parametro es decir si existe esa conulta que quiero editar ,si existe lo edito
		BEGIN
		--actualizacion del cosnulta
			UPDATE consulta SET
			comentario_consulta=@comentario_consulta,
			estado_consulta=@estado_consulta,
			id_usuario= @id_usuario ,
			id_motivo_consulta=@id_motivo_consulta
			WHERE id_consulta=@id_consulta

			SET @mensaje=  'La consulta se edito correctamente'
			SET @respuesta=1/* Cambiamos la variable de respuesta a 1, lo que equivale a "true" */
		END
		ELSE
		BEGIN
			SET @mensaje='Error No se puede editar la Consulta ya que esa Consulta no existe en la Base de datos'
			
		END
	  END
END

/*ACTUALIZAR EL ESTADO DE LA CONSULTA */
CREATE PROCEDURE SP_ACTUALIZARESTADOCONSULTA(
	/*parametros de entrada (que necesitamos para actualizar el estado de una consulta) que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar un producto*/
	@id_consulta INT,
	@estado_consulta VARCHAR(20),
	/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
	@respuesta INT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS 
BEGIN
	SET @respuesta=0
	SET @mensaje=''
	DECLARE @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	IF NOT EXISTS(SELECT id_consulta FROM consulta  WHERE id_consulta=@id_consulta)
		BEGIN
			SET @mensaje='La consulta que se quiere actualizar el estado no existe'
			SET @validacion=0
		END
	IF EXISTS(SELECT estado_consulta FROM consulta  WHERE id_consulta=@id_consulta AND estado_consulta='Leido')
		BEGIN
			SET @mensaje='La consulta ya esta Leida'
			SET @validacion=0
		END


	IF(@validacion=1)
	BEGIN
		--actualizacion del estado del consulta,lo marcamos como leido
		UPDATE consulta SET
		estado_consulta=@estado_consulta
		WHERE id_consulta=@id_consulta
		SET @mensaje=  ' La consulta se marco como leida correctamente'
		SET @respuesta=1/* Cambiamos la variable de respuesta a 1, lo que equivale a "true" */
	END
END
