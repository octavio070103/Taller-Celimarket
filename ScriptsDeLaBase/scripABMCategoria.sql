/*-------ABM CATEGORIA CON PROCEDIMIENTO ALMACENADOS-------*/

				--PROCEDIMIENTO PARA REGISTRAR CATEGORIA
ALTER PROC SP_REGISTRARCATEGORIA(
--estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar la categoria
@Nombre_categoria VARCHAR(50),
@Estado_categoria bit,

--estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
@Resultado int output,
@Mensaje VARCHAR(500) output
)as
begin 
	SET @Resultado=0 /*aca seteo con un valor inicial mi var de salida*/

	--aca digo que sino exitse un nombre_categoria en la tabla categoria con el mismo nombre_categoria que quiero registrar SINO existe que entre al if ya que significa que ese nombre_categoria todavia no existe 'que esta disponible' 
	IF NOT EXISTS (SELECT * FROM categoria WHERE nombre_categoria=@Nombre_categoria)
	BEGIN 
		--Inserto en mi tabla categoria los valores que el usuario me paso como parametro y que se valdiaron correctamente que no existe en la BD el mismo nombre_categoria
		INSERT INTO categoria(nombre_categoria,estado_categoria) 
		VALUES(@Nombre_categoria,@Estado_categoria)
		SET @Resultado= SCOPE_IDENTITY()-- Obtener el ID de la categoria recién insertada y lo asigno o guardo en mi parametro de salida resultado
		SET @Mensaje= 'La categoria se registro de manera correcta'

	END
	ELSE
		SET @Mensaje= 'No se puede repetir el Nombre de la Categoria debe de ser UNICO'

END

GO

					--PROCEDIMIENTO PARA EDITAR O MODIFICAR UNA CATEGORIA
ALTER PROC SP_EDITARCATEGORIA(
--estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a editar la categoria
@Id_Categoria int,
@Nombre_categoria VARCHAR(50),
@Estado_categoria bit,

--estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida
@Resultado int output,
@Mensaje VARCHAR(500) output
)
AS
BEGIN 
	SET @Resultado=1
	IF NOT EXISTS(SELECT * FROM categoria WHERE nombre_categoria=@Nombre_categoria AND id_categoria != @Id_Categoria)
		UPDATE categoria SET
		nombre_categoria=@Nombre_categoria,
		estado_categoria=@Estado_categoria
		WHERE id_categoria = @Id_Categoria
	ELSE
	BEGIN
		SET @Resultado=0
		SET @Mensaje= 'No se puede repetir el Nombre de la Categoria debe de ser UNICO'
	END
END

GO

--PROCEDIMIENTO PARA ELIMINAR O DAR DE BAJA UNA CATEGORIA
CREATE PROC SP_DARBAJACATEGORIA(
--estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a editar la categoria
@Id_Categoria int,

--estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida
@Resultado int output,
@Mensaje VARCHAR(500) output
)
AS
BEGIN 
	SET @Resultado=1	/*aca seteo con un valor inicial mi var de salida ,0 es false 1 true*/
	set @Mensaje='' /*proporciona informacion sobre la oepracion*/
	declare @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	
	IF EXISTS(SELECT * FROM categoria c
	WHERE c.id_categoria=@Id_Categoria AND c.estado_categoria=0
	)
	BEGIN 
		SET @Resultado=0 --seteo el resultado a =0 para que cuando lo reciba en mi programa pueda saber que fallo la validacion com oresultado es una var de salidad output
		SET @Mensaje= ' La Categoria ya se encuentra daba de BAJA'
		SET @validacion=0 --cambio el valor de validacion a 0 ya que asi determino que la validacion fue por el caso false
	END

	IF NOT EXISTS (SELECT * FROM categoria c
	WHERE c.id_categoria= @Id_Categoria)
	BEGIN 
		SET @Resultado=0 --seteo el resultado a =0 para que cuando lo reciba en mi programa pueda saber que fallo la validacion com oresultado es una var de salidad output
		SET @Mensaje= ' La Categoria NO existe en la Base de Datos'
		SET @validacion=0 --cambio el valor de validacion a 0 ya que asi determino que la validacion fue por el caso false
	END

	IF EXISTS (SELECT * FROM categoria c
	INNER JOIN producto p on p.id_categoria= c.id_categoria
	where c.id_categoria = @Id_Categoria)
	BEGIN 
		SET @Resultado=0 --seteo el resultado a =0 para que cuando lo reciba en mi programa pueda saber que fallo la validacion com oresultado es una var de salidad output
		SET @Mensaje= ' La Categoria Ya esta vinculado a un Producto, No se Puede Dar de Baja'
		SET @validacion=0 --cambio el valor de validacion a 0 ya que asi determino que la validacion fue por el caso false
	END

	IF(@validacion=1)
	BEGIN 
		-- busca el registro en la tabla categoria cuyo id_categoria coincide con el valor que proporcionas en el parámetro @id_categoria, y luego actualiza ese registro estableciendo su estado_categoria en 0
		update categoria set
		estado_categoria=0
		WHERE id_categoria = @Id_Categoria; 
		set @Resultado=1 /*la BAJA del usuario fue correcta */
		SET @Mensaje = 'EL USUARIO SE DIO DE BAJA CORRECTAMENTE.'
	END
	ELSE
    BEGIN
         SET @mensaje = 'Error al realizar la BAJA de la categoria. Intente nuevamente.'
          
    END
END

--PROCEDIMIENTO PARA DAR DE ALTA UNA CATEGORIA
CREATE PROC SP_DARALTACATEGORIA(
--estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a editar la categoria
@Id_Categoria int,

--estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida
@Resultado int output,
@Mensaje VARCHAR(500) output
)
AS
BEGIN 
	SET @Resultado=1	/*aca seteo con un valor inicial mi var de salida ,0 es false 1 true*/
	set @Mensaje='' /*proporciona informacion sobre la oepracion*/
	declare @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	
	IF EXISTS(SELECT * FROM categoria c
	WHERE c.id_categoria=@Id_Categoria AND c.estado_categoria=1
	)
	BEGIN 
		SET @Resultado=0 --seteo el resultado a =0 para que cuando lo reciba en mi programa pueda saber que fallo la validacion com oresultado es una var de salidad output
		SET @Mensaje= ' La Categoria ya se encuentra daba de ALTA'
		SET @validacion=0 --cambio el valor de validacion a 0 ya que asi determino que la validacion fue por el caso false
	END

	IF NOT EXISTS (SELECT * FROM categoria c
	WHERE c.id_categoria= @Id_Categoria)
	BEGIN 
		SET @Resultado=0 --seteo el resultado a =0 para que cuando lo reciba en mi programa pueda saber que fallo la validacion com oresultado es una var de salidad output
		SET @Mensaje= ' La Categoria NO existe en la Base de Datos'
		SET @validacion=0 --cambio el valor de validacion a 0 ya que asi determino que la validacion fue por el caso false
	END


	IF(@validacion=1)
	BEGIN 
		-- busca el registro en la tabla categoria cuyo id_categoria coincide con el valor que proporcionas en el parámetro @id_categoria, y luego actualiza ese registro estableciendo su estado_categoria en 0
		update categoria set
		estado_categoria=0
		WHERE id_categoria = @Id_Categoria; 
		set @Resultado=1 /*la BAJA del usuario fue correcta */
		SET @Mensaje = 'EL USUARIO SE DIO DE alta CORRECTAMENTE.'
	END
	ELSE
    BEGIN
         SET @mensaje = 'Error al realizar la Alta de la categoria. Intente nuevamente.'
          
    END

END

