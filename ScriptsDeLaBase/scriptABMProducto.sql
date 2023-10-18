

/*REGISTRAR PRODUCTO */
CREATE PROC SP_REGISTRARPRODUCTO(
/*parametros de entrada (que necesitamos para registrar un producto) que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar un producto*/
	@nombre_producto VARCHAR(50),
	@cod_barra_producto INT,
	@descripcion_producto VARCHAR(100),
	@precio_compra DECIMAL(10, 2),
	@precio_venta DECIMAL(10, 2),
	@imagen_producto VARCHAR(100),
	@stock_producto INT,
	@estado_producto BIT,
	@Id_Marca INT,
	@Id_Categoria INT,
	/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
	@Id_Producto_Resultado INT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS 
BEGIN --el begin se utiliza para delimitar un bloque de codigo que contiene varias declaraciones, este Begin delimita el cuerpo de lprocedimiento almacenado

	/*aca seteo con un valor inicial mi var de salida*/
	SET @Id_Producto_Resultado = 0
	set @mensaje=''

	 -- Validación de datos
	  IF @nombre_producto IS NULL OR @cod_barra_producto IS NULL OR @nombre_producto = '' OR @precio_compra IS NULL OR @precio_venta IS NULL OR @stock_producto IS NULL OR @Id_Marca IS NULL
    BEGIN --este begin agrupa o delimitar las delcaraciones de este if
        SET @mensaje = 'Los datos proporcionados no son válidos.'
    END
	ELSE
	BEGIN

		 -- Comprobar que nose inserten Productos Duplicados 
		 --tiene dos condiciones,La primera condición verifica si hay un producto con el mismo cod_barra_producto. Si existe un producto con el mismo código de barras, se considera un producto duplicado y no se permite la inserción.
		 --La segunda condición verifica si hay un producto con el mismo nombre_producto y la misma Id_Marca. Si existe un producto con el mismo nombre y la misma marca, también se considera un producto duplicado y no se permite la inserción.
		 --pero si no se encuentra ningún producto existente que coincida con el código de barras o el nombre y la marca entra al if y se inserta
		IF NOT EXISTS(SELECT * FROM producto WHERE  cod_barra_producto=@cod_barra_producto OR (nombre_producto=@nombre_producto AND Id_Marca=@Id_Marca) )
		BEGIN                                
		  -- Iniciar una transacción(secuencia de una o más operaciones de base de datos que se ejecutan como una unidad atómica. Esto significa que todas las operaciones dentro de la transacción se ejecutan o bien se deshacen por completo si algo sale mal.) si entro al if,
				BEGIN TRANSACTION --si sale mal la trasacion durante la isnerte se piede revertir con un roolback y si ningun cambio se raliza esto me adyuda a manetner la integridad y evitar tener probelmas con el entity por ej

			-- Insertar en la tabla Producto con los datos que recibi de mi form de registrar como parametro de entrada
		    INSERT INTO producto (nombre_producto, descripcion_producto, precio_compra, precio_venta, imagen_producto, stock_producto, estado_producto, Id_Marca, Id_Categoria, cod_barra_producto)
			VALUES (@nombre_producto, @descripcion_producto, @precio_compra, @precio_venta, @imagen_producto, @stock_producto, @estado_producto, @Id_Marca, @Id_Categoria, @cod_barra_producto)

			-- Obtener el ID del producto insertado
			set @Id_Producto_Resultado = SCOPE_IDENTITY()/*si se inserto esta funcion me alamcena el id del prodcuto que se inserto o genero correctamente*/

			 -- Confirmar la transacción si treien exito la insercion, al commitear esto los cambios se vuelven permanentes en la BD
				COMMIT TRANSACTION

			SET @mensaje = 'El Producto se registro correctamente'

		END
		ELSE
		BEGIN
		SET @mensaje = 'No se puede ingresar un producto con el mismo nombre y marca o el mismo código de barras. Debe ser único.'
		END
	END
END

 /*declaro var que voy a usar para ahcer la prueba de insertar*/
declare @Id_Producto_Resultado int
declare @mensaje varchar (500)

/*ejecuto mi procedimiento que cree para hacer la prueba de insertar datos  */
exec SP_REGISTRARPRODUCTO 'fruta',072,'frances',20,25,'pan.png',10,1,1,2,@Id_Producto_Resultado output,@mensaje output

/*aca me mostraria el resultado de la operacion de insertar que realice anteriometne el id_usuario que se inserto y el mensaje de si se inserto o no correctamente*/
select @Id_Producto_Resultado

select @mensaje

select * from producto

								/*EDITAR PRODUCTO */
 CREATE PROC SP_EDITARPRODUCTO(
/*parametros de entrada (que necesitamos para registrar un producto) que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar un producto*/
	@id_producto INT,
	@cod_barra_producto INT,
	@nombre_producto VARCHAR(50),
	@descripcion_producto VARCHAR(100),
	@precio_compra DECIMAL(10, 2),
	@precio_venta DECIMAL(10, 2),
	@imagen_producto VARCHAR(100),
	@stock_producto INT,
	@estado_producto BIT,
	@Id_Marca INT,
	@Id_Categoria INT,
	/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
	@respuesta BIT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS 
BEGIN --el begin se utiliza para delimitar un bloque de codigo que contiene varias declaraciones, este Begin delimita el cuerpo de lprocedimiento almacenado

	/*aca seteo con un valor inicial mi var de salida*/
	SET @respuesta = 0 --aca seteo con un valor inicial mi var de salida ,0 es false 1 true, Inicialmente asumimos que la edición fallará.
	SET @mensaje=''  --Proporciona informacion sobre la oepracion

	 -- Validación de datos,verifica que no se produzca una colisión con otro producto ya existente.
	 --Esta condición verifica si no existe ningún otro producto con el mismo código de barras (cod_barra_producto) o si existe otro producto con el mismo nombre (nombre_producto) y la misma marca (Id_Marca) que no sea el producto que se está editando (identificado por id_producto != @id_producto). 
	 --Si esta condición se cumple, significa que no hay colisiones con otros productos en la base de datos y permite la actualización. De lo contrario, si se encuentra un producto con el mismo código de barras o un producto con el mismo nombre y marca, se establece un mensaje de error indicando que no se puede repetir el producto de la misma marca. Esto asegura que los productos sigan siendo únicos según tus criterios de codificación de barras y combinación de nombre y marca.
	IF NOT EXISTS (select * from producto where ( cod_barra_producto=@cod_barra_producto OR (nombre_producto=@nombre_producto AND Id_Marca=@Id_Marca)) AND id_producto != @id_producto) 
	BEGIN 
	-- Actualización del producto
		update producto set
		nombre_producto = @nombre_producto,
		cod_barra_producto=@cod_barra_producto,
		descripcion_producto = @descripcion_producto,
		precio_compra = @precio_compra,
		precio_venta = @precio_venta,
		imagen_producto = @imagen_producto,
		stock_producto = @stock_producto,
		estado_producto = @estado_producto,
		Id_Marca = @Id_Marca,
		id_Categoria=@Id_Categoria 
		where id_producto=@id_producto

		set @mensaje = 'el producto se edito correctamente'
		set @respuesta=1/* Cambiamos la variable de respuesta a 1, lo que equivale a "true" */
	end
	else
		SET @mensaje = 'No se puede editar un producto Y Usar el mismo nombre y marca o el mismo código de barras que otro Producto Registrado. Debe ser único.'

end

								/*DAR BAJA PRODUCTO */
 CREATE PROC SP_DARBAJAPRODUCTO(
/*parametros de entrada (que necesitamos para registrar un producto) que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar un producto*/
	@id_producto INT,
	/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
	@respuesta BIT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS 
BEGIN --el begin se utiliza para delimitar un bloque de codigo que contiene varias declaraciones, este Begin delimita el cuerpo de lprocedimiento almacenado

	/*aca seteo con un valor inicial mi var de salida*/
	SET @respuesta = 0 --aca seteo con un valor inicial mi var de salida ,0 es false 1 true, Inicialmente asumimos que la edición fallará.
	SET @mensaje=''  --Proporciona informacion sobre la oepracion
	declare @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	--sino existe ese Producto en la base de datos(no esta registrado ese id_producto) va a entrar al if y me devolvera ese mensaje
	IF NOT EXISTS (SELECT * FROM producto p
	 WHERE p.id_producto=@id_producto 
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL Producto NO EXISTE en la Base de Datos\n' 
	END

	--si existe ese producto en la base de datos y su estado_producto ya es 0(ya esta dado de baja) va a entrar al if y me va a devovler ese mensaje
	if EXISTS (SELECT * FROM producto p
	  WHERE p.id_producto=@id_producto AND p.estado_producto=0
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL Producto YA SE ENCUENTRA DADO DE BAJA No se puede dar de baja nuevamente \n' 
	END

	

	--si paso todas las anteriroes valdiaciones entonces entra en este if y se da de baja ese usuario que existe en la abse de datos y su estado era dadod e alta 
	IF(@validacion = 1)
	BEGIN
	-- busca el registro en la tabla usuario cuyo id_usuario coincide con el valor que proporcionas en el parámetro @id_usuario, y luego actualiza ese registro estableciendo su estado_usuario en 0
		update producto SET
		estado_producto=0
		WHERE id_producto = @id_producto; 
		SET @respuesta=1 /*la BAJA del usuario fue correcta */
		SET @mensaje = 'EL Producto se dio de BAJA correctamente.'
	END
	ELSE
    BEGIN
         SET @mensaje = 'Error al realizar la baja del producto. Intente nuevamente.'
          
    END

END

 /*otra forma de dar de baja mas optimiada seria asi pero es un poc omenos legible 
 ALTER PROC SP_DARBAJAPRODUCTO (
    @id_producto INT,
    @respuesta BIT OUTPUT,
    @mensaje VARCHAR(500) OUTPUT
)
AS 
BEGIN
    SET @respuesta = 0
    SET @mensaje = ''

    -- Comprobar si el producto existe y no está dado de baja
    IF EXISTS (
        SELECT 1
        FROM producto
        WHERE id_producto = @id_producto
          AND estado_producto = 1
    )
    BEGIN
        -- Dar de baja el producto
        UPDATE producto
        SET estado_producto = 0
        WHERE id_producto = @id_producto;

        SET @respuesta = 1
        SET @mensaje = 'El producto se dio de baja correctamente.'
    END
    ELSE IF EXISTS (
        SELECT 1
        FROM producto
        WHERE id_producto = @id_producto
    )
    BEGIN
        SET @mensaje = 'El producto ya se encuentra dado de baja. No se puede dar de baja nuevamente.'
    END
    ELSE
    BEGIN
        SET @mensaje = 'El producto no existe en la base de datos.'
    END
END
*/

								/*DAR ALTA PRODUCTO */
CREATE PROC SP_DARALTAPRODUCTO(
/*parametros de entrada (que necesitamos para registrar un producto) que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar un producto*/
	@id_producto INT,
	/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
	@respuesta BIT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS 
BEGIN --el begin se utiliza para delimitar un bloque de codigo que contiene varias declaraciones, este Begin delimita el cuerpo de lprocedimiento almacenado

	/*aca seteo con un valor inicial mi var de salida*/
	SET @respuesta = 0 --aca seteo con un valor inicial mi var de salida ,0 es false 1 true, Inicialmente asumimos que la edición fallará.
	SET @mensaje=''  --Proporciona informacion sobre la oepracion
	declare @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	--sino existe ese Producto en la base de datos(no esta registrado ese id_producto) va a entrar al if y me devolvera ese mensaje
	IF NOT EXISTS (SELECT * FROM producto p
	 WHERE p.id_producto=@id_producto 
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL Producto NO EXISTE en la Base de Datos\n' 
	END

	--si existe ese producto en la base de datos y su estado_producto ya es 0(ya esta dado de baja) va a entrar al if y me va a devovler ese mensaje
	if EXISTS (SELECT * FROM producto p
	  WHERE p.id_producto=@id_producto AND p.estado_producto=1
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL Producto YA SE ENCUENTRA DADO DE ALTA No se puede dar de baja nuevamente \n' 
	END

	

	--si paso todas las anteriroes valdiaciones entonces entra en este if y se da de baja ese usuario que existe en la abse de datos y su estado era dadod e alta 
	IF(@validacion = 1)
	BEGIN
	-- busca el registro en la tabla usuario cuyo id_usuario coincide con el valor que proporcionas en el parámetro @id_usuario, y luego actualiza ese registro estableciendo su estado_usuario en 0
		update producto SET
		estado_producto=1
		WHERE id_producto = @id_producto; 
		SET @respuesta=1 /*la ALTA del usuario fue correcta */
		SET @mensaje = 'EL Producto se dio de ALTA correctamente.'
	END
	ELSE
    BEGIN
         SET @mensaje = 'Error al realizar la ALTA del producto. Intente nuevamente.'
          
    END

END
