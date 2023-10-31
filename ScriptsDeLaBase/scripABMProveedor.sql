/*REGISTRAR USUARIO */
CREATE PROC SP_REGISTRARPROVEEDOR(
/*estos son parametros de entrada que le enviaremos valores atraves de mi programa es decir aca recibiria los valores cargados por el usuario a registrar*/
		@nombre VARCHAR(100),
		@email VARCHAR(100),
		@telefono VARCHAR(100),
		@estado_proveedor BIT,
		@id_Proveedor_resultado int output,/*estos dos parametros me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) en este caso el id y un mensaje de salida*/
		@mensaje varchar(500) output
)
as 
begin 
	set @id_Proveedor_resultadoa = 0 /*aca seteo con un valor inicial mi var de salida*/
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