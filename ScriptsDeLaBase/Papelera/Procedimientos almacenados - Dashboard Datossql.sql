--- HECHO

CREATE PROC SP_DATOSDELNEGOCIOPORMES
--parametros de entrada
    @mes INT,
--parametros de salidad
    @nroVentas INT OUT,
    @totalRecaudado FLOAT OUT,
    @nroClientes INT OUT,
    @nroEmpleado INT OUT,
    @nroProveedores INT OUT,
    @nroProductos INT OUT,
    @totalStock INT OUT,
    @estadoStock VARCHAR(30) OUT
AS
    SET @nroVentas = (SELECT COUNT(id_venta) AS totalVentas FROM venta WHERE MONTH(venta_fecha) = @mes); --nro de ventas del mes
    SET @totalRecaudado = (SELECT ISNULL(SUM(subtotal_detalle_venta), 0) AS totalRecaudado FROM detalle_venta WHERE MONTH(fecha_creacion_detalle_venta) = @mes); --total recaudado del mes
    SET @nroClientes = (SELECT COUNT(id_cliente) AS numeroClientes FROM cliente WHERE MONTH(fecha_creacion_cliente)=@mes); --clientes de este mes
    SET @nroEmpleado = (SELECT COUNT(id_usuario) AS numeroEmpleados FROM usuario);
    SET @nroProveedores = (SELECT COUNT(id_proveedor) AS numeroProveedores FROM proveedor );
    SET @nroProductos = (SELECT COUNT(id_producto) AS TotalProductos FROM producto);

    -- Calcular la suma total del stock de productos
    SET @totalStock = (SELECT SUM(stock_producto) AS totalStock FROM producto);
    
    -- Determinar el estado del stock
    IF @totalStock > 80
    BEGIN
        SET @estadoStock = 'Stock Alto';
    END
    ELSE
    BEGIN
        IF @totalStock >= 15 AND @totalStock <= 80
        BEGIN
            SET @estadoStock = 'Stock Medio';
        END
        ELSE
        BEGIN
            SET @estadoStock = 'Stock Bajo';
        END
    END
GO