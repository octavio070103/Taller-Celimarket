---------------------------------------------------------------------------- DOMICILIO ABM
/*CREATE PROC SP_REGISTRARDOMICILIO(
@codigo_postal int,
@localidad varchar(100),
@provincia varchar(100),
@numero int,
@calle varchar(200),
@descripcion_domicilio varchar(100),
@estado_domicilio bit ,
@id_domicilio_resultado int output,/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
@mensaje varchar(500) output
)
AS
BEGIN 
	SET @id_domicilio_resultado=0
	SET @mensaje=''

	--verificamos si el domicilio que se quiere ingresar ya no existe en la base de datos
	--aca selecciono la tabla domciilio y busco la calle que se ingreso y el numero que se ingreso ,si esta en la base de datos cargada , si esto es asi que no entre en el if ya que sino existen esos datos ahi entraria al if
	IF NOT EXISTS(SELECT * FROM domicilio WHERE calle=@calle AND numero=@numero)
	BEGIN
	--Insertamos el nuevo domicilio en la tabla Domicilio
	INSERT INTO domicilio(codigo_postal,localidad,provincia,numero,calle,descripcion_domicilio,estado_domicilio)
	VALUES(@codigo_postal,@localidad,@provincia,@numero,@calle,@descripcion_domicilio,@estado_domicilio)

	--obtenemos el ID del domicilio registrado 
	SET @id_domicilio_resultado=SCOPE_IDENTITY()

	--mensaje de exito si se inserto correctamente
	SET @mensaje='Domicilio registrado correctamente'
	END
	ELSE
	BEGIN
	--Mensaje de error en caso de que el domicilio ya exista en la base de datos
		SET @mensaje='el domicilio ya existe, ya esta registrado'
	END

END*/