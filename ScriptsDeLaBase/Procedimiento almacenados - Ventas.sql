---------- PRODUCTOS MAS VENDIDOS ----------


CREATE PROCEDURE SP_ProductosMasVendidos
AS
select TOP 5 Marca.Nombre+' - '+ producto.descripcion_producto as Producto, count(detalle_venta.id_producto) as Cantidad_vendida
	from detalle_venta
	inner join producto on detalle_venta.id_producto = producto.id_producto
	inner join categoria on categoria.id_categoria = producto.id_categoria
	inner join marca on marca.Id_Marca = producto.Id_Marca
	group by detalle_venta.id_producto, Marca.Nombre, producto.descripcion_producto
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

/* 
ALTER PROCEDURE SP_CategoriasMasVendidas
AS
	select categoria.nombre_categoria, COUNT(categoria.id_categoria) AS CategoriaMasVendida 
		from detalle_venta
		inner join producto ON detalle_venta.id_producto = producto.id_producto
		inner join categoria ON producto.id_categoria = categoria.id_categoria
		group by producto.id_categoria, categoria.nombre_categoria
		order by CategoriaMasVendida DESC
GO
*/

---------- DATOS DEL NEGOCIO -----------

CREATE PROCEDURE SP_DatosDelNegocio
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

FROM venta WHERE MONTH(fecha_venta) = @mes);
@mes INT,
--******* LISTAR TODAS LAS VENTAS ******--


CREATE PROCEDURE SP_ListarVentas

AS
SELECT venta.id_venta AS ID_Venta, 
	   venta.venta_fecha AS Fecha,
	   persona.apellido+' '+persona.nombre AS Cliente, 
	   metodo_pago.nombre_metodo_pago AS Metodo_pago,
	   usuario.email AS Vendedor
FROM venta

	inner join cliente on cliente.id_cliente = venta.id_cliente
	inner join persona on persona.id_persona = cliente.id_persona
	inner join usuario on usuario.id_usuario = venta.id_usuario
	inner join metodo_pago on metodo_pago.id_metodo_pago = venta.id_metodo_pago

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

--DROP PROCEDURE SP_ListarVentasVendedor

-- ***** LISTAR DETALLE VENTA *****

CREATE PROCEDURE SP_ListarDetalleVenta
(
  @id_venta INT
)
AS
  BEGIN
    SELECT P.nombre_producto AS Producto, DV.cantidad_detalle_venta AS Cantidad,
		   DV.precio_detalle_venta AS Precio, DV.subtotal_detalle_venta AS Subtotal FROM detalle_venta AS DV
    INNER JOIN producto AS P on P.id_producto = DV.id_producto
	WHERE DV.id_venta = @id_venta
  END
GO


-- ***** DETALLES FACTURA *****

CREATE PROCEDURE SP_ObtenerDatosFactura
(
  @id_venta INT
)
AS
  BEGIN 
	SELECT V.id_venta AS 'Numero de factura',
		   P.apellido +' '+P.nombre AS 'Cliente',
		   P.dni AS 'DNI',
		   P.telefono AS 'Telefono',
		   V.venta_fecha AS 'Fecha', 
		   N.nombre_negocio AS 'Nombre',
		   N.CUIT,
		   N.direccion AS 'Direccion'
		   FROM venta AS V
	INNER JOIN cliente AS C on C.id_cliente = V.id_cliente
	INNER JOIN persona AS P on P.id_persona = C.id_persona
	CROSS JOIN Negocio AS N
	WHERE id_venta = @id_venta
  END
GO


select * from Negocio
/*
SELECT P.nombre_producto, DV.cantidad_detalle_venta, DV.precio_detalle_venta,
	   DV.subtotal_detalle_venta FROM venta AS V
INNER JOIN detalle_venta AS DV on DV.id_venta = V.id_venta
INNER JOIN producto AS P on P.id_producto = DV.id_producto
WHERE V.id_venta = 5

SELECT * FROM detalle_venta
/*

select venta.id_venta, producto.nombre_producto from venta -- venta.id_venta, producto.nombre_producto
inner join detalle_venta on detalle_venta.id_venta = venta.id_venta
inner join producto on producto.id_producto = detalle_venta.id_producto
where venta.id_venta = 1

*/
/*
select * from cliente
select venta.id_venta, persona.nombre from venta
inner join cliente on cliente.id_cliente = venta.id_cliente
inner join persona on persona.id_persona = cliente.id_persona
*/