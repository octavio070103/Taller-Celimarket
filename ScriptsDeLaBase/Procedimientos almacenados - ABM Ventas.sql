
-- **** COMBOBOX METODOS DE PAGO: Este procedimiento se utiliza para listar los metodos de pago en un combobox

CREATE PROCEDURE SP_ObtenerMetodosPago
AS
  BEGIN
	SELECT * FROM tipo_metodo_pago
  END
GO


-- REGISTRAR VENTA:
ALTER PROCEDURE SP_RegistrarVenta
(
  @venta_fecha DATE,
  @id_cliente INT,
  @id_metodo_pago INT,
  @id_usuario INT,
  @fecha_creacion_venta DATE,
  @id_apertura_caja INT,

  @IdNuevaVenta INT OUTPUT,
  @resultadoEjec INT OUTPUT
)
AS
  BEGIN
    INSERT INTO venta(venta_fecha, id_cliente,id_metodo_pago, id_usuario, fecha_creacion_venta,id_apertura_caja )
	VALUES (@venta_fecha, @id_cliente, @id_metodo_pago, @id_usuario, @fecha_creacion_venta,@id_apertura_caja);

	SET @IdNuevaVenta = SCOPE_IDENTITY();
	SET @resultadoEjec = 1;
  END
GO


-- REGISTRAR DETALLE VENTA:
CREATE PROCEDURE SP_RegistrarDetalleVenta
(
  @cantidad_detalle_venta INT,
  @precio_detalle_venta FLOAT,
  @subtotal_detalle_venta FLOAT,
  @id_producto INT,
  @id_venta INT,
  @fecha_creacion_detalle_venta DATE,
  @resultadoEjec VARCHAR(500) OUTPUT
)
AS
  BEGIN
    SET @resultadoEjec = '';

	IF( @id_venta IS NOT NULL )
	  BEGIN
	    
		INSERT INTO detalle_venta(cantidad_detalle_venta, precio_detalle_venta, subtotal_detalle_venta,
									id_producto, id_venta, fecha_creacion_detalle_venta)
		VALUES (@cantidad_detalle_venta, @precio_detalle_venta, @subtotal_detalle_venta, @id_producto,
				@id_venta, @fecha_creacion_detalle_venta);
				
	    UPDATE producto
		SET stock_producto = (stock_producto - @cantidad_detalle_venta)
		WHERE (id_producto = @id_producto);

		SET @resultadoEjec = 'Se registro la venta con exito'

	  END
	ELSE
	  BEGIN
	    SET @resultadoEjec = 'No se pudo registrar la venta'
	  END

  END
GO


-- GENERAR FACTURA:

CREATE PROCEDURE SP_ListarFacturas
(
  @id_vendedor INT
)
AS
  BEGIN
    SELECT * FROM venta AS V
	INNER JOIN cliente AS C on C.id_cliente = V.id_cliente
	INNER JOIN persona AS P on P.id_persona = C.id_persona
	WHERE id_venta = @id_vendedor
  END
GO

CREATE PROCEDURE SP_BuscarDetalleFactura
(
	@id_venta INT
)
AS
  BEGIN 
    select * from venta AS V
	INNER JOIN detalle_venta AS DV on DV.id_venta = V.id_venta

	WHERE V.id_venta = @id_venta;
  END
GO
/*
select * from negocio


select * from producto
select * from marca
select * from categoria

insert into producto(nombre_producto, descripcion_producto, precio_compra, precio_venta, imagen_producto, stock_producto,
					 estado_producto, Id_Marca, id_categoria, fecha_creacion_producto, cod_barra_producto)
values('Harina de maiz', 'harina', 20, 30, 'x', 4, 1, 1, 1, GETDATE(), 3);

select * from usuario*/

