--- HECHO

/*REGISTRAR USUARIO */
CREATE PROC SP_REGISTRARUSUARIO(
/*estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar*/
		@dni varchar(100),
		@nombre varchar(100),
		@apellido varchar(100),
		@fecha_nacimiento date,
		@telefono varchar(100),
		@email varchar(200),
		@password varchar(150),
		@estado_usuario bit,
		@id_rol int,
		@id_domicilio int,
		@id_Usuario_resultado int output,/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
		@mensaje varchar(500) output
)
as 
begin 
	set @id_Usuario_resultado = 0 /*aca seteo con un valor inicial mi var de salida*/
	set @mensaje=''

	/*aca digo que sino exitse una persona en la tabla persona con el dni que quiero registrar SINO existe que entre al if ya que significa que ese dni no existe que esta disponible*/
	if not exists (select * from persona where dni =@dni)
	begin 
		 /* Verificar si el correo electrónico ya está en uso ya que este debe de ser unico*/
			IF NOT EXISTS (SELECT * FROM usuario WHERE email = @email)
			BEGIN 
				-- Insertar en la tabla Persona una persona con los datos que recibi de mi form de registrar como parametro
				INSERT INTO Persona ( dni,nombre, apellido, fecha_nacimiento,telefono)
				VALUES (@dni,@nombre, @apellido,@fecha_nacimiento, @telefono)

				-- Obtener el ID de la persona recién insertada
				DECLARE @id_persona INT
				SET @id_persona = SCOPE_IDENTITY()

				--insertar en la tabla usuario relacionando la persona que inserte anteriormente con un usuario
				insert into usuario(email,password,estado_usuario,id_persona,id_rol,id_domicilio) 
				values(@email,@password,@estado_usuario,@id_persona,@id_rol,@id_domicilio)

				set @mensaje = 'el usuario se registro correctamente'
				set @id_Usuario_resultado = SCOPE_IDENTITY()/*si se inserto esta funcion me alamcena el id del usuario que se inserto o genero)*/
			end
			else
				SET @mensaje = 'El correo electrónico ya está en uso, debe ser único'
	end
	else
		set @mensaje = 'No se puede repetir el documento para mas de un usuario debe de ser UNICO'

end

GO 
/*
/*declaro var que voy a usar para ahcer la prueba de insertar*/
declare @id_Usuario_generado int
declare @mensaje varchar (500)

/*ejecuto mi procedimiento que cree para hacer la prueba de insertar datos  */
exec SP_REGISTRARUSUARIO '11','lautaro','romero','2002-09-09','3794212','lautarorome@gmail.com','1',1,1,2,@id_Usuario_generado output,@mensaje output

/*aca me mostraria el resultado de la operacion de insertar que realice anteriometne el id_usuario que se inserto y el mensaje de si se inserto o no correctamente*/
select @id_Usuario_generado

select @mensaje

select * from usuario

GO*/

			/*EDITAR USUARIO */
CREATE PROC SP_EDITARUSUARIO(
/*definimos los  parametros de entrada que el procedimiento espera recibir,que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a editar*/
		@id_usuario int,
		@dni varchar(100),
		@nombre varchar(100),
		@apellido varchar(100),
		@fecha_nacimiento date,
		@telefono varchar(100),
		@email varchar(200),
		@password varchar(150),
		@estado_usuario bit,
		@id_rol int,
		@id_domicilio int,
	/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso la Rpespuesta que es 1 o 0 y un mensaje de salida*/
		@respuesta bit output,
		@mensaje varchar(500) output
		
)
as 
begin 
	set @respuesta = 0 /*aca seteo con un valor inicial mi var de salida ,0 es false 1 true*/
	set @mensaje='' /*proporciona informacion sobre la oepracion*/

	DECLARE @id_persona int --declaro una variable entera llamda id_persona que va a contener el id_persona a editar asi podre acceder a ese registro de la tabla persona
	SELECT @id_persona=id_persona FROM usuario WHERE id_usuario=@id_usuario --aca obtengo el id_persona relacionadop con el uusario que se esta editando por eso digo que el id_persona de ese id_usuairo que se busca que se guarde en esa variable @id_persona

	/*aca verifico que si se encontro un id_persona valido es decir que si ese id_persona no es null que entre al if */
	if (@id_persona IS NOT NULL)-- Verificamos si se encontró un id_persona
		begin 
			/*aca digo que sino exitse una persona en la tabla persona con el dni que quiero editar SINO existe que entre al if ya que significa que ese dni no existe que esta disponible y que sea diferencite el mismo usuario que estoiy editando es decir que mita al usuario que estoy editando para que no me tome el dni del queestoy editando para el error*/
			/*es decir verificar si ya existe una persona en la tabla 'persona' con el mismo 'dni', pero con un 'id_persona' diferente al que se está editando. Esto es importante para asegurarse de que el 'dni' sea único, excepto para cada persona que se está editando. Si la validación es verdadera (es decir, no existe un usuario con el mismo 'dni' que no sea el que se está editando), se procede a realizar la actualización de los datos de la persona y luego del usuario.*/
			if not exists (select * from persona where dni =@dni and id_persona != @id_persona) 
				begin 
				 /* Actualiza la información en la tabla 'persona' */
					update persona 
					set
					nombre = @nombre,
					apellido = @apellido,
					dni = @dni,
					fecha_nacimiento=@fecha_nacimiento,
					telefono = @telefono
					where id_persona=@id_persona

					 /* Actualiza la información en la tabla 'usuario' despues de actualizar la tabla persona*/
					update usuario 
					set
					email = @email,
					password=@password,
					estado_usuario=@estado_usuario,
					id_persona=@id_persona,
					id_rol=@id_rol,
					id_domicilio=@id_domicilio
					where id_usuario=@id_usuario

					set @mensaje = 'el usuario se edito correctamente'
					set @respuesta=1/* Cambiamos la variable de respuesta a 1, lo que equivale a "true" */
				end
			else
				set @mensaje = 'No se puede repetir el documento para mas de un usuario debe de ser UNICO'

			end
	else
		set @mensaje = 'No se encontro ninguna persona con esos datos,No podemos editar el usuario'

end

GO

/*declaro var que voy a usar para ahcer la prueba de insertar*/
declare @respuesta bit
declare @mensaje varchar (500)

/*ejecuto mi procedimiento que cree para hacer la prueba de editar datos  */
exec SP_EDITARUSUARIO 6,'44004987','alfredo','gomez','2003-09-09','222','prueba2@gmail','1',1,1,1,@respuesta output,@mensaje output

/*aca me mostraria el resultado de la operacion de insertar que realice anteriometne el id_usuario que se inserto y el mensaje de si se inserto o no correctamente*/
select @respuesta

select @mensaje

select * from usuario
select * from persona

GO
					/*Eliminar USUARIO 1ra forma dando de baja a ese usuario solamente */

CREATE PROC SP_ELIMINARUSUARIOLOGICO(
/*definimos los  parametros de entrada que el procedimiento espera recibir,que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a editar*/
	@id_usuario int,
	@respuesta bit output,/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso la Rpespuesta que es 1 o 0 y un mensaje de salida*/
	@mensaje varchar(500) output
)
as 
begin 
	set @respuesta = 0 /*aca seteo con un valor inicial mi var de salida ,0 es false 1 true*/
	set @mensaje='' /*proporciona informacion sobre la oepracion*/
	declare @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	--si existe ese usuario en la base de datos y su estado de usuario ya es 0(ya esta dado de baja) va a entrar al if y me va a devovler ese mensaje
	if EXISTS (SELECT * FROM usuario u
	 where u.id_usuario=@id_usuario AND u.estado_usuario=0
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL USUARIO YA SE ENCUENTRA DADO DE BAJA NOSE PUEDE DAR DE BAJA DE NUEVO\n' 
	END

	--sino existe ese usuario en la base de datos va a entrar al if y me devolvera ese mensaje
	if NOT EXISTS (SELECT * FROM usuario u
	 where u.id_usuario=@id_usuario 
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL USUARIO NO EXISTE EN LA BASE DE DATOS \n' 
	END

	--si paso todas las anteriroes valdiaciones entonces entra en este if y se da de baja ese usuario que existe en la abse de datos y su estado era dadod e alta 
	if(@validacion = 1)
	begin
	-- busca el registro en la tabla usuario cuyo id_usuario coincide con el valor que proporcionas en el parámetro @id_usuario, y luego actualiza ese registro estableciendo su estado_usuario en 0
		update usuario set
		estado_usuario=0
		WHERE id_usuario = @id_usuario; 
		set @respuesta=1 /*la BAJA del usuario fue correcta */
		SET @mensaje = 'EL USUARIO SE DIO DE BAJA CORRECTAMENTE.'
	end
	else
    BEGIN
         SET @mensaje = 'Error al realizar la baja del usuario. Intente nuevamente.'
          
    end

end

GO

--aca pruebo la funcion que cree
/*declaro var que voy a usar para ahcer la prueba de dar de baja*/
declare @respuesta bit
declare @mensaje varchar (500)

/*ejecuto mi procedimiento que cree para hacer la prueba de editar datos  */
exec SP_ELIMINARUSUARIOLOGICO 1,@respuesta output,@mensaje output

/*aca me mostraria el resultado de la operacion de insertar que realice anteriometne el id_usuario que se inserto y el mensaje de si se inserto o no correctamente*/
select @respuesta

select @mensaje

select * from usuario

GO
				/*Eliminar USUARIO 2daa forma eliminando todo baja fisica esto no ejecute todavia,mas adelante lo usare*/
CREATE PROC SP_ELIMINARUSUARIO(
@id_usuario int,
@respuesta bit output,
@mensaje varchar (500) output
)
as
begin 
	set @respuesta = 0 /*aca seteo con un valor inicial mi var de salida ,0 es false 1 true*/
	set @mensaje='' /*proporciona informacion sobre la oepracion*/
	declare @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	/*eliminamos un usuario pero solo sino esta relacionado a compras de proveedores o alguna venta ya que si en algun momento quieor ver el historial de esas tablas voy a tener conflictos ya que el usuario que las hizo no existe mas */
	if EXISTS (SELECT * FROM venta v
	INNER JOIN usuario u on u.id_usuario = v.id_usuario
	where u.id_usuario =@id_usuario
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL USUARIO SE ENCUENTRA RELACIONADO A UNA VENTA NOSE PUEDE ELIMINAR\n' 
	END

	/*este seria la validacion para la compra pero como no cree esa tabla la dejo comentado
	if EXISTS (SELECT * FROM compra c
	INNER JOIN usuario u on u.id_usuario = c.id_usuario
	where u.id_usuario =@id_usuario
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0 /*no paso las reglas significa es decir no puedo eliminar */
		set @mensaje='EL USUARIO SE ENCUENTRA RELACIONADO A UNA COMPRA NOSE PUEDE ELIMINAR\' 
	END
	*/

	if(@validacion = 1)
	begin
		delete from usuario where id_usuario = @id_usuario
		set @respuesta=1 /*la eliminacion del usuario fue correcta */
		set @mensaje='El usuario se dio de Baja Correctamente\n' 
	end


end

GO
								/* DAR ALTA USUARIOS*/
CREATE PROC SP_DARALTAUSUARIO(
@id_usuario int,
@respuesta bit output,
@mensaje varchar (500) output
)
as
begin 
	set @respuesta = 0 /*aca seteo con un valor inicial mi var de salida ,0 es false 1 true*/
	set @mensaje='' /*proporciona informacion sobre la oepracion*/
	declare @validacion bit = 1 /*declaro una var para saber si paso mis validaciones si validacion =1 significa que paso las reglas y si es = 0 significa que no */

	if EXISTS (SELECT * FROM usuario u
	 where u.id_usuario=@id_usuario AND u.estado_usuario=1
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL USUARIO YA SE ENCUENTRA DADO DE ALTA NOSE PUEDE DAR DE ALTA DE NUEVO\n' 
	END

	if NOT EXISTS (SELECT * FROM usuario u
	 where u.id_usuario=@id_usuario 
	)
	BEGIN 
		set @respuesta = 0 
		set @validacion=0
		set @mensaje='EL USUARIO NO EXISTE EN LA BASE DE DATOS \n' 
	END

	if(@validacion = 1)
	begin
	-- busca el registro en la tabla usuario cuyo id_usuario coincide con el valor que proporcionas en el parámetro @id_usuario, y luego actualiza ese registro estableciendo su estado_usuario en 0
		update usuario set
		estado_usuario=1
		WHERE id_usuario = @id_usuario; 
		set @respuesta=1 /*la BAJA del usuario fue correcta */
		SET @mensaje = 'EL USUARIO SE DIO DE ALTA CORRECTAMENTE.'
	end
	else
    BEGIN
         SET @mensaje = 'Error al realizar la Alta del usuario. Intente nuevamente.'
          
    end

end

GO

---------------------------------------------------------------------------- DOMICILIO ABM
ALTER PROC SP_REGISTRARDOMICILIO(
@calle varchar(200),
@codigo_postal int,
@numero int,
@localidad varchar(100),
@provincia varchar(100),
@descripcion varchar(100),
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
	INSERT INTO domicilio(calle,codigo_postal,numero,localidad,provincia,descripcion_domicilio,estado_domicilio)
	VALUES(@calle,@codigo_postal,@numero,@localidad,@provincia,@descripcion,@estado_domicilio)

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

END