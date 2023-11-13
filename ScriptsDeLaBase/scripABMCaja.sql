ALTER PROC SP_REGISTRARAPERTURACAJA(
	--estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar la categoria
	@fecha_apertura date, --paso como parametro la fecha apertura de la caja a registrar para poder validar sino existe una caja ya abierta por media de la fecha apertura ya que no deben de haber dos cajas abiertas en un mismo dia
	@monto_inicial decimal(10,2),
	@id_usuario INT,
	@estado_apertura bit,

	--estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
	@Resultado int output,
	@Mensaje VARCHAR(500) output
)as
begin 
	BEGIN TRY
		SET @Resultado=0 /*aca seteo con un valor inicial mi var de salida*/

		--aca digo que sino exitse una fecha_apertura en la tabla apertura_caja con la misma fecha de @fecha_apertura que quiero registrar SINO existe que entre al if ya que significa que no hay una caja abierta en esta en la fecha que le pase ,es para verficar que no hay una caja ya abierta
		IF NOT EXISTS (SELECT * FROM AperturaCaja WHERE CAST(fecha_apertura AS date)=@fecha_apertura) --lo casteo a fecha_apertura a tipo date ya que es de tipo datetime,y debo de comparar si ya hay una caja en la fecha actual ques e le pase porque si le paso como datetime nunca coincidiria 
		BEGIN 
			--Inserto en mi tabla aperturacaja los valores que el usuario me paso como parametro y que se valdiaron correctamente que no existe en la BD el mismo fecha_apertura es decir una caja ya abierta
			INSERT INTO AperturaCaja(monto_inicial,id_usuario,estado_apertura) 
			VALUES(@monto_inicial,@id_usuario,@estado_apertura)

			SET @Resultado= SCOPE_IDENTITY()-- Obtener el ID de la Apertura_Caja recién insertada y lo asigno o guardo en mi parametro de salida resultado
			SET @Mensaje= 'La Caja se abrio de manera correcta'

		END
		ELSE
			SET @Mensaje= 'NO se puede abrir una nueva caja Ya que ya hay una Caja abierta'
	END TRY
    BEGIN CATCH
        SET @Resultado = -1
        SET @Mensaje = 'Error al procesar la solicitud. Detalles: ' + ERROR_MESSAGE()
    END CATCH	
END

--debo de poner que si el usuario ejecuta el programa en un dia distinto al qeu abrio la caja y esta abierta sin cerrar que se le cierre la caja con la fecha del dia que se abrio para que no ocurran errores
GO

ALTER PROC SP_REGISTRARCIERRECAJA(
	--estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar la categoria
	@id_apertura_caja INT ,
	@fecha_cierre DATETIME,
	@id_usuario INT,
	@monto_final DECIMAL(10,2),
	@diferencia DECIMAL(10,2),
	@estado_cierre BIT,


	--estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
	@Resultado int output,
	@Mensaje VARCHAR(500) output
)as
begin 
		SET @Resultado=1	/*aca seteo con un valor inicial mi var de salida ,0 es false 1 true*/
		SET @Mensaje='' /*proporciona informacion sobre la oepracion*/
		declare @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */
	 
	 BEGIN TRY
	--aca digo que sino exitse una fecha_apertura en la tabla apertura_caja con la misma fecha de @fecha_apertura que quiero registrar SINO existe que entre al if ya que significa que no hay una caja abierta en esta en la fecha que le pase ,es para verficar que no hay una caja ya abierta
	IF NOT EXISTS (SELECT * FROM AperturaCaja WHERE id_apertura_caja=@id_apertura_caja)
	BEGIN 
		SET @Resultado=0	--devuelve el resultado de la op 0 sinigfica que fallo que nose pudo registrar el cierre
		SET @Mensaje= 'No se encontró una apertura de caja correspondiente al ID proporcionado.'
		Set @validacion  = 0 --aca detemrino que la validacion es 0 entonces significa que fallo que no supero las condiciones para registrar el cierre
		RETURN; -- Terminar el procedimiento si no existe el id_apertura_caja proporcionado
	END

	IF EXISTS (SELECT * FROM CierreCaja WHERE id_apertura_caja = @id_apertura_caja)
	BEGIN
		SET @Resultado=0	--devuelve el resultado de la op 0 sinigfica que fallo que nose pudo registrar el cierre
		Set @validacion  = 0
		SET @Mensaje = 'La caja ya ha sido cerrada previamente.';
		RETURN; -- Terminar el procedimiento si la caja ya está cerrada
	END

	IF @monto_final < 0 --OR @diferencia < 0
	BEGIN
		SET @Resultado=0	--devuelve el resultado de la op 0 sinigfica que fallo que nose pudo registrar el cierre
			Set @validacion  = 0
			SET @Mensaje = 'El monto final debe de ser  un valor no negativo.';
		RETURN; -- Terminar el procedimiento si los valores no son válidos
	END

	IF @validacion =1
		BEGIN 
		   BEGIN TRANSACTION
			--Actualiza el estado de cierre en la tabla AperturaCaja después de realizar el cierre
			UPDATE AperturaCaja
			SET estado_apertura = 0 --aca seteo a 0 singifca que se cerro la caja entonces ,- 1: Abierta, 0: Cerrada
			WHERE id_apertura_caja = @id_apertura_caja;
			 -- Define el estado de cierre según la diferencia
            SET @estado_cierre = CASE WHEN @diferencia >= 0 THEN 1 ELSE 0 END

			-- Inserta en la tabla CierreCaja los valores
			INSERT INTO CierreCaja(id_apertura_caja,id_usuario,monto_final,diferencia,estado_cierre)
			VALUES(@id_apertura_caja,@id_usuario,@monto_final,@diferencia,@estado_cierre)

			SET @Resultado= SCOPE_IDENTITY()-- Obtener el ID de la Apertura_Caja recién insertada y lo asigno o guardo en mi parametro de salida resultado
			SET @Mensaje= 'Caja Cerrada de manera Correcta'
			COMMIT
		END
	END TRY
    BEGIN CATCH
        ROLLBACK
        SET @Resultado = -1
        SET @Mensaje = 'Error al procesar la solicitud. Detalles: ' + ERROR_MESSAGE()
    END CATCH
END

GO

CREATE PROC SP_VERIFICARESTADOCAJA(
--estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar la categoria
	@fecha_apertura date, --paso como parametro la fecha apertura de la caja a registrar para poder validar sino existe una caja ya abierta por media de la fecha apertura ya que no deben de haber dos cajas abiertas en un mismo dia
	@monto_inicial decimal(10,2),
	@id_usuario INT,
	@estado_apertura bit,
	@fecha_cierre DATETIME, --le paso la feha_cierre dependiendo de la hora en la que se ejcuto el programa

	--estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
	@Resultado int output,
	@Mensaje VARCHAR(500) output
)
AS 
BEGIN
	IF EXISTS (SELECT * FROM AperturaCaja WHERE id_usuario = @id_usuario AND estado_apertura = 1 AND CAST(fecha_apertura AS DATE) <> @fecha_apertura)
	BEGIN
		-- Llamar al procedimiento de cierre de caja automáticamente
		DECLARE @id_apertura_caja INT
		SELECT @id_apertura_caja = id_apertura_caja FROM AperturaCaja WHERE id_usuario = @id_usuario AND estado_apertura = 1
		EXEC SP_REGISTRARCIERRECAJA @id_apertura_caja, @fecha_cierre, @id_usuario, 0.00, 0.00, 0, @Resultado, @Mensaje
		-- Ahora puedes abrir la nueva caja con la fecha actual
	END

END
/*Cierre de Caja Automático: En tu comentario mencionas que si el usuario ejecuta el programa en un día distinto al que abrió la caja y esta sigue abierta, deberías cerrar la caja automáticamente. Puedes hacer esto con una verificación adicional y llamando al procedimiento de cierre de caja si es necesario.*/