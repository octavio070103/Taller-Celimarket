---------- PRODUCTOS MAS VENDIDOS ----------


CREATE PROCEDURE SP_ProductosMasVendidos
AS
select TOP 5 producto.marca_producto+' - '+ producto.descripcion_producto as Producto, count(detalle_venta.id_producto) as Cantidad_vendida
	from detalle_venta
	inner join producto on detalle_venta.id_producto = producto.id_producto
	inner join categoria on categoria.id_categoria = producto.id_categoria
	group by detalle_venta.id_producto, producto.marca_producto, producto.descripcion_producto
	order by Cantidad_vendida DESC
GO

---------- CATEGORIAS MAS VENDIDAS -----------

CREATE PROCEDURE SP_CategoriasMasVendidas
AS
	select categoria.nombre_categoria, COUNT(categoria.id_categoria) AS CategoriaMasVendida 
		from detalle_venta
		inner join producto ON detalle_venta.id_producto = producto.id_producto
		inner join categoria ON producto.id_categoria = categoria.id_categoria
		group by producto.id_categoria, categoria.nombre_categoria
		order by CategoriaMasVendida DESC
GO


---------- DATOS DEL NEGOCIO -----------

CREATE PROCEDURE SP_DatosDelNegocio
	@nroVentas INT OUT,
	@totalRecaudado FLOAT OUT,
	@nroClientes INT OUT,
	@nroEmpleado INT OUT,
	@nroProveedores INT OUT,
	@nroProductos INT OUT
AS
	set @nroVentas = ( select COUNT(id_venta) AS totalVentas FROM venta )
	set @totalRecaudado = ( select SUM(subtotal_detalle_venta) AS totalRecaudado FROM detalle_venta )
	set @nroClientes = ( select COUNT(id_cliente) AS numeroClientes FROM cliente )
	set @nroEmpleado = ( select COUNT(id_usuario) AS numeroEmpleados FROM usuario )
	set @nroProveedores = ( select COUNT(id_proveedor) AS numeroProveedores FROM proveedor )
	set @nroProductos = ( select COUNT(id_producto)  AS TotalProductos FROM producto )
GO


--******* LISTAR TODAS LAS VENTAS ******--


CREATE PROCEDURE SP_ListarVentas

AS
SELECT venta.id_venta AS ID_Venta, 
	   venta.venta_fecha AS Fecha,
	   persona.apellido+' '+persona.nombre AS Cliente, 
	   metodo_pago.descripcion_metodo_pago AS Metodo_pago,
	   usuario.email AS Vendedor
FROM venta

	inner join cliente on cliente.id_cliente = venta.id_cliente
	inner join persona on persona.id_persona = cliente.id_persona
	inner join usuario on usuario.id_usuario = venta.id_usuario
	inner join metodo_pago on metodo_pago.id_metodo_pago = venta.id_metodo_pago

ORDER BY venta.id_venta

GO