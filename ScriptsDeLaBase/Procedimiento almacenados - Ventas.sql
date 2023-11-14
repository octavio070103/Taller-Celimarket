---------- PRODUCTOS MAS VENDIDOS ----------


ALTER PROCEDURE SP_ProductosMasVendidos
AS
select TOP 5 Marca.Nombre+' - '+ producto.descripcion_producto as Producto, count(detalle_venta.id_producto) as Cantidad_vendida
	from detalle_venta
	inner join producto on detalle_venta.id_producto = producto.id_producto
	inner join categoria on categoria.id_categoria = producto.id_categoria
	inner join marca on marca.Id_Marca = producto.Id_Marca
	group by detalle_venta.id_producto, Marca.Nombre, producto.descripcion_producto
	order by Cantidad_vendida DESC
GO


-- ***** POR PERIODOS *****

CREATE PROCEDURE SP_ProductosMasVendidosPorPeriodo
(
	@fechaInicioPer DATE,
	@fechaFinPer DATE
)
AS
select TOP 5 Marca.Nombre+' - '+ producto.descripcion_producto as Producto, count(detalle_venta.id_producto) as Cantidad_vendida
	from detalle_venta
	inner join producto on detalle_venta.id_producto = producto.id_producto
	inner join categoria on categoria.id_categoria = producto.id_categoria
	inner join marca on marca.Id_Marca = producto.Id_Marca

	WHERE fecha_creacion_detalle_venta BETWEEN @fechaInicioPer AND @fechaFinPer
	group by detalle_venta.id_producto, Marca.Nombre, producto.descripcion_producto
	order by Cantidad_vendida DESC
GO


---------- CATEGORIAS MAS VENDIDAS -----------

ALTER PROCEDURE SP_CategoriasMasVendidas
AS
	select categoria.nombre_categoria, COUNT(categoria.id_categoria) AS CategoriaMasVendida 
		from detalle_venta
		inner join producto ON detalle_venta.id_producto = producto.id_producto
		inner join categoria ON producto.id_categoria = categoria.id_categoria
		group by producto.id_categoria, categoria.nombre_categoria
		order by CategoriaMasVendida DESC
GO


--- ***** POR PERIODO *****

CREATE PROCEDURE SP_CategoriasMasVendidasPorPeriodo
(
	@fechaInicioPer DATETIME,
	@fechaFinPer DATETIME
)
AS
	select categoria.nombre_categoria, COUNT(categoria.id_categoria) AS CategoriaMasVendida 
		from detalle_venta
		inner join producto ON detalle_venta.id_producto = producto.id_producto
		inner join categoria ON producto.id_categoria = categoria.id_categoria

		WHERE fecha_creacion_detalle_venta BETWEEN @fechaInicioPer AND @fechaFinPer
		group by producto.id_categoria, categoria.nombre_categoria
		order by CategoriaMasVendida DESC
GO


---------- DATOS DEL NEGOCIO -----------

ALTER PROCEDURE SP_DatosDelNegocio
	@nroVentas INT OUT,
	@totalRecaudado FLOAT OUT,
	@nroClientes INT OUT,
	@nroEmpleado INT OUT,
	@nroProveedores INT OUT,
	@nroProductos INT OUT
AS
	set @nroVentas = ( select COUNT(id_venta) AS totalVentas FROM venta)
	set @totalRecaudado =(SELECT ISNULL(SUM(subtotal_detalle_venta),0) AS totalRecaudado FROM detalle_venta)--La función ISNULL toma dos argumentos: el primer argumento es el valor que se evalúa y el segundo argumento es el valor que se utiliza si el primer argumento es NULL. En este caso, si SUM(subtotal_detalle_venta) es NULL, se reemplaza por 0.
	set @nroClientes = ( select COUNT(id_cliente) AS numeroClientes FROM cliente )
	set @nroEmpleado = ( select COUNT(id_usuario) AS numeroEmpleados FROM usuario )
	set @nroProveedores = ( select COUNT(id_proveedor) AS numeroProveedores FROM proveedor )
	set @nroProductos = ( select COUNT(id_producto)  AS TotalProductos FROM producto )
GO


--- ***** POR PERIODO *****

CREATE PROCEDURE SP_DatosDelNegocioPorPeriodo
	@nroVentas INT OUT,
	@totalRecaudado FLOAT OUT,
	@nroClientes INT OUT,
	@nroEmpleado INT OUT,
	@nroProveedores INT OUT,
	@nroProductos INT OUT,
	@fechaInicioPer DATETIME,
	@fechaFinPer DATETIME
AS
	set @nroVentas = ( select COUNT(id_venta) AS totalVentas FROM venta WHERE venta_fecha BETWEEN @fechaInicioPer AND @fechaFinPer)

	set @totalRecaudado = ( SELECT ISNULL(SUM(subtotal_detalle_venta),0) AS totalRecaudado FROM detalle_venta 
							WHERE fecha_creacion_detalle_venta BETWEEN @fechaInicioPer AND @fechaFinPer)--La función ISNULL toma dos argumentos: el primer argumento es el valor que se evalúa y el segundo argumento es el valor que se utiliza si el primer argumento es NULL. En este caso, si SUM(subtotal_detalle_venta) es NULL, se reemplaza por 0.
	
	set @nroClientes = ( select COUNT(id_cliente) AS numeroClientes FROM cliente 
						  WHERE (fecha_creacion_cliente <= @fechaFinPer) AND (estado_cliente = 1) )

	set @nroEmpleado = ( select COUNT(id_usuario) AS numeroEmpleados FROM usuario 
						 WHERE (fecha_creacion_usuario <= @fechaFinPer) AND (estado_usuario = 1) )

	set @nroProveedores = ( select COUNT(id_proveedor) AS numeroProveedores FROM proveedor 
							WHERE (fecha_creacion <= @fechaFinPer) AND (estado_proveedor = 1))

	set @nroProductos = ( select COUNT(id_producto)  AS TotalProductos FROM producto 
						  WHERE (fecha_creacion_producto <= @fechaFinPer) AND (estado_producto = 1) )
GO


/*
FROM venta WHERE MONTH(fecha_venta) = @mes);
@mes INT,*/
--******* LISTAR TODAS LAS VENTAS ******--


ALTER PROCEDURE SP_ListarVentas

AS
SELECT venta.id_venta AS 'ID Venta', 
	   persona.apellido+' '+persona.nombre AS Cliente,
	   venta.venta_fecha AS Fecha, 
	   metodo_pago.nombre_metodo_pago AS 'Metodo de pago',
	   usuario.email AS Vendedor
FROM venta

	inner join cliente on cliente.id_cliente = venta.id_cliente
	inner join persona on persona.id_persona = cliente.id_persona
	inner join usuario on usuario.id_usuario = venta.id_usuario
	inner join metodo_pago on metodo_pago.id_metodo_pago = venta.id_metodo_pago

ORDER BY venta.id_venta

GO

-- ***** POR PERIODOS *****

CREATE PROCEDURE SP_ListarVentasPorPeriodo
(
  @fechaInicioPer DATETIME,
  @fechaFinPer DATETIME
)
AS
SELECT venta.id_venta AS 'ID Venta', 
	   persona.apellido+' '+persona.nombre AS 'Cliente',
	   venta.venta_fecha AS Fecha,
	   metodo_pago.nombre_metodo_pago AS 'Metodo de pago',
	   usuario.email AS Vendedor
FROM venta

	inner join cliente on cliente.id_cliente = venta.id_cliente
	inner join persona on persona.id_persona = cliente.id_persona
	inner join usuario on usuario.id_usuario = venta.id_usuario
	inner join metodo_pago on metodo_pago.id_metodo_pago = venta.id_metodo_pago
	WHERE venta_fecha BETWEEN @fechaInicioPer AND @fechaFinPer

ORDER BY venta.id_venta

GO


-- ***** LISTAR VENTAS POR VENDEDOR *****

CREATE PROCEDURE SP_ListarVentasVendedor
(
	@id_usuario INT
)
AS 
  BEGIN
	SELECT venta.id_venta AS 'ID Venta', persona.apellido +' '+persona.nombre AS 'Cliente',
		   venta.venta_fecha AS 'Fecha', MP.nombre_metodo_pago AS 'Metodo de pago' FROM venta
	INNER JOIN cliente on cliente.id_cliente = venta.id_cliente
	INNER JOIN persona on persona.id_persona = cliente.id_persona
	INNER JOIN metodo_pago AS MP on MP.id_metodo_pago = venta.id_metodo_pago
	WHERE venta.id_usuario = @id_usuario;
  END
GO


-- **** POR PERIODO ****

CREATE PROCEDURE SP_ListarVentasVendedorPorPeriodo
(
	@id_usuario INT,
	@fechaInicioPer DATETIME,
	@fechaFinPer DATETIME
)
AS 
  BEGIN
	SELECT venta.id_venta AS 'ID Venta', persona.apellido +' '+persona.nombre AS 'Cliente',
		   venta.venta_fecha AS 'Fecha', MP.nombre_metodo_pago AS 'Metodo de pago' FROM venta
	INNER JOIN cliente on cliente.id_cliente = venta.id_cliente
	INNER JOIN persona on persona.id_persona = cliente.id_persona
	INNER JOIN metodo_pago AS MP on MP.id_metodo_pago = venta.id_metodo_pago
	WHERE (venta.id_usuario = @id_usuario) AND (venta_fecha BETWEEN @fechaInicioPer AND @fechaFinPer);
  END
GO


--DROP PROCEDURE SP_ListarVentasVendedor

-- ***** LISTAR DETALLE VENTA *****

ALTER PROCEDURE SP_ListarDetalleVenta
(
  @id_venta INT
)
AS
  BEGIN
    SELECT P.nombre_producto AS Producto,m.Nombre as MarcaProducto,
		   DV.cantidad_detalle_venta AS Cantidad,
		   DV.precio_detalle_venta AS Precio, DV.subtotal_detalle_venta AS Subtotal FROM detalle_venta AS DV
    INNER JOIN producto AS P on P.id_producto = DV.id_producto
	INNER JOIN Marca m ON  P.Id_Marca=m.Id_Marca
	WHERE DV.id_venta = @id_venta
  END
GO


-- ***** DETALLES FACTURA *****

ALTER PROCEDURE SP_ObtenerDatosFactura
(
  @id_venta INT
)
AS
  BEGIN 
	SELECT V.id_venta AS 'Numero de factura',
		   P.apellido +' '+P.nombre AS 'Cliente',
		   P.dni AS 'DNI',
		   P.telefono AS 'Telefono Cliente',
		   V.venta_fecha AS 'Fecha', 
		   N.nombre_negocio AS 'Nombre',
		   N.CUIT,
		   N.direccion AS 'Direccion',
		   N.email_negocio,
		   N.telefono AS 'Telefono Negocio',
		   perUsua.nombre+' '+perUsua.apellido AS 'Vendedor',
		   perUsua.dni As 'dni Vendedor',
		   met.nombre_metodo_pago,
		   tpMet.nombre_tipo_pago
		   FROM venta AS V
	INNER JOIN cliente AS C on C.id_cliente = V.id_cliente
	INNER JOIN persona AS P on P.id_persona = C.id_persona
	INNER JOIN usuario usua ON V.id_usuario = usua.id_usuario
	INNER JOIN persona perUsua ON usua.id_persona = perUsua.id_persona
	INNER JOIN metodo_pago met ON v.id_metodo_pago=met.id_metodo_pago
	INNER JOIN tipo_metodo_pago tpMet ON met.id_tipo_metodo_pago = tpMet.id_tipo_metodo_pago
	CROSS JOIN Negocio AS N
	WHERE id_venta = @id_venta
  END
GO


-- **** VENDEDORES CON MAS VENTAS ****

CREATE PROCEDURE SP_VendedoresMasVentas
(
  @fechaInicioPer DATETIME,
  @fechaFinPer DATETIME
)
AS
  BEGIN
	SELECT TOP 5 P.apellido+' '+P.nombre AS 'Vendedor', COUNT(V.id_usuario) AS 'Total' FROM venta AS V
	INNER JOIN usuario AS Us on Us.id_usuario = V.id_usuario
	INNER JOIN persona AS P on P.id_persona = Us.id_persona
	WHERE V.venta_fecha BETWEEN @fechaInicioPer AND @fechaFinPer

	GROUP BY P.apellido+' '+P.nombre
	ORDER BY COUNT(V.id_usuario) DESC
  END
GO
--- Este ultimo procedimiento se modifico 14/11 02:58

--select * from usuario