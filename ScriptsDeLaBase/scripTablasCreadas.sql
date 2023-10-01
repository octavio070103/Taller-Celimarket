USE dbSistema
go

create table proveedor(
id_proveedor int primary key identity,
dni int,
email varchar(250),
telefono int,
estado_proveedor bit
)

go

create table domicilio(
id_domicilio int primary key identity,
calle varchar(250),
codigo_postal int,
numero int,
localidad varchar(250),
provincia varchar(250),
estado_domicilio bit
)


go

create table metodo_pago(
id_metodo_pago int primary key identity,
descripcion_metodo_pago varchar(250)
)

go

create table venta(
id_venta int primary key identity,
id_usuario int references usuario(id_usuario),
id_cliente int references cliente(id_cliente),
id_metodo_pago int references metodo_pago(id_metodo_pago),
venta_fecha date,
telefono int,
)

go
create table categoria(
id_categoria int primary key identity,
descripcion_categoria varchar(250),
estado_categoria bit
)

go

create table producto(
id_producto int primary key identity,
id_categoria int references categoria(id_categoria),
nombre_producto varchar(250),
descripcion_producto varchar(250),
precio_compra decimal(10,2) default 0,
precio_venta decimal(10,2) default 0,
producto_stock int,
imagen VARBINARY(MAX),
estado_producto bit
)
go

create table detalle_venta(
id_detalle_venta int primary key identity,
id_venta int references venta(id_venta),
id_producto int references producto(id_producto),
cantidad_detalle_venta int,
precio_detalle_venta decimal(10,2),
subtotal_detalle_venta decimal(10,2)
)





