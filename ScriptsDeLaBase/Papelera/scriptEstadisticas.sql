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
    select categoria.descripcion_categoria, COUNT(categoria.id_categoria) AS CategoriaMasVendida 
        from detalle_venta
        inner join producto ON detalle_venta.id_producto = producto.id_producto
        inner join categoria ON producto.id_categoria = categoria.id_categoria
        group by producto.id_categoria, categoria.descripcion_categoria
        order by CategoriaMasVendida DESC
GO