--- HECHO

CREATE PROC SP_DASHBOARDDATOS
--defino parametros de salida en los cuales voy a guardar el resultado de la consulta a cada tab;la sobre la cantidad de elementos de mi tabla para mi dashboard y el total de la venta en el dia

@numeroDeProducto int out,
@numeroDeCategoria int out,
@numeroDeCliente int out,
@numeroDeProveedor int out,
@numeroDeEmpleado int out,

@mensaje varchar(500) output/*estE parametrO me vana  servir para devolver un salida a mi procediiento almecenado(resultado de la op) un mensaje de salida*/

as
BEGIN
	BEGIN TRY
		--con set asigno ese valor de la consulta a mi varibale de salida o parametro de salida que defini anteriormente

		 -- Obtener la cantidad de productos
		set @numeroDeProducto=(select count(id_producto) as cantidadProducto from producto) --con el count obtengo la cantidad de registro que tiene ese campo es decri la cantidad de elemento que posee dicho cmpo
 
		-- Obtener la cantidad de categorías
		set @numeroDeCategoria=(select count(id_categoria) as cantidadCategoria from categoria)

		 -- Obtener la cantidad de clientes
		set @numeroDeCliente=(select count(id_cliente) as cantidadCliente from cliente)

		 -- Obtener la cantidad de proveedores
		set @numeroDeProveedor=(select count(id_proveedor) as cantidadProveedor from proveedor)

		 -- Obtener la cantidad de empleados
		set @numeroDeEmpleado=(select count(id_usuario) as cantidadEmpleado from usuario)
	END TRY
	BEGIN CATCH
			set @mensaje = 'No se puedo obtener los datos para el inicio'
	END CATCH;
END;