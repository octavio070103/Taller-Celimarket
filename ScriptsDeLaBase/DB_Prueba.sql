CREATE DATABASE BD_Prueba;

USE BD_Prueba;

CREATE TABLE categoria(
	id_categoria INT IDENTITY(1,1) NOT NULL,
	descripcion_categoria VARCHAR(200) NOT NULL,
	estado_categoria BIT NOT NULL

	CONSTRAINT PK_categoria PRIMARY KEY (id_categoria)
);


CREATE TABLE metodo_pago(
	id_metodo_pago INT IDENTITY(1,1) NOT NULL,
	descripcion_metodo_pago VARCHAR(50) NOT NULL,
	estado_metodo_pago BIT NOT NULL

	CONSTRAINT PK_Metodo_pago PRIMARY KEY (id_metodo_pago)
);


CREATE TABLE persona(
	id_persona INT IDENTITY(1,1),
	dni VARCHAR(100) NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	apellido VARCHAR(100) NOT NULL,
	fecha_nacimiento DATE NOT NULL,
	telefono VARCHAR(100) NOT NULL,

	CONSTRAINT PK_persona PRIMARY KEY (id_persona),
	CONSTRAINT UQ_dni_persona UNIQUE (dni)
);


CREATE TABLE proveedor(
	id_proveedor INT IDENTITY(1,1),
	dni VARCHAR(100) NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	telefono VARCHAR(100) NOT NULL,
	estado_proveedor BIT NOT NULL,

	CONSTRAINT PK_proveedor PRIMARY KEY (id_proveedor),
	CONSTRAINT UQ_dni_proveedor UNIQUE (dni)
);


CREATE TABLE rol(
	id_rol INT IDENTITY(1,1),
	descripcion_rol VARCHAR(100) NOT NULL,
	estado_rol BIT NOT NULL,

	CONSTRAINT PK_rol PRIMARY KEY (id_rol)
);


CREATE TABLE domicilio(
	id_domicilio INT IDENTITY(1,1),
	calle VARCHAR(200) NOT NULL,
	codigo_postal INT NOT NULL,
	numero INT NOT NULL,
	localidad VARCHAR(100) NOT NULL,
	provincia VARCHAR(100) NOT NULL,
	descripcion VARCHAR(100) NULL,
	estado_domicilio BIT NOT NULL,

	CONSTRAINT PK_domicilio PRIMARY KEY (id_domicilio),
);


CREATE TABLE producto(
	id_producto INT IDENTITY(1,1),
	nombre_producto VARCHAR(50) NOT NULL,
	descripcion_producto VARCHAR(100) NOT NULL,
	precio_compra FLOAT NOT NULL,
	precio_venta FLOAT NOT NULL,
	imagen_producto VARCHAR(100) NOT NULL,
	marca_producto VARCHAR(50) NOT NULL,
	stock_producto INT NOT NULL,
	fecha_registro_producto DATE NOT NULL,
	estado_producto BIT NOT NULL,
	id_categoria INT NOT NULL,

	CONSTRAINT PK_producto PRIMARY KEY (id_producto),
	CONSTRAINT FK_producto_categoria FOREIGN KEY (id_categoria) REFERENCES categoria(id_categoria)
);


CREATE TABLE cliente(
	id_cliente INT IDENTITY(1,1),
	fecha_registro DATE NOT NULL,
	estado_cliente BIT NOT NULL,
	id_persona INT NOT NULL,

	CONSTRAINT PK_cliente PRIMARY KEY (id_cliente),
	CONSTRAINT FK_cliente_persona FOREIGN KEY (id_persona) REFERENCES persona(id_persona)
);


CREATE TABLE venta(
	id_venta INT IDENTITY(1,1),
	venta_fecha DATE NOT NULL,
	id_cliente INT NOT NULL,
	id_metodo_pago INT NOT NULL,
	id_usuario INT NOT NULL,

	CONSTRAINT PK_venta PRIMARY KEY (id_venta),
	CONSTRAINT FK_venta_usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario),
	CONSTRAINT FK_venta_cliente FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente),
	CONSTRAINT FK_venta_metodo_pago FOREIGN KEY (id_metodo_pago) REFERENCES metodo_pago(id_metodo_pago)
);


CREATE TABLE detalle_venta(
	id_detalle_venta INT IDENTITY(1,1),
	cantidad_detalle_venta INT NOT NULL,
	precio_detalle_venta FLOAT NOT NULL,
	subtotal_detalle_venta FLOAT NOT NULL,
	id_producto INT NOT NULL,
	id_venta INT NOT NULL,

	CONSTRAINT PK_detalle_venta PRIMARY KEY (id_detalle_venta),
	CONSTRAINT FK_detalle_venta_producto FOREIGN KEY (id_producto) REFERENCES producto(id_producto),
	CONSTRAINT FK_detalle_venta_venta FOREIGN KEY (id_venta) REFERENCES venta(id_venta)
);





CREATE TABLE usuario(
	id_usuario INT IDENTITY(1,1),
	email VARCHAR(200) NOT NULL, -- unico --
	pass VARCHAR(150) NOT NULL,
	fecha_registro DATE NOT NULL,
	estado_usuario BIT NOT NULL,
	id_persona INT NOT NULL,
	id_rol INT NOT NULL,
	id_domicilio INT NOT NULL,

	CONSTRAINT PK_usuario PRIMARY KEY (id_usuario),
	CONSTRAINT FK_usuario_persona FOREIGN KEY (id_persona) REFERENCES persona(id_persona),
	CONSTRAINT FK_usuario_rol FOREIGN KEY (id_rol) REFERENCES rol(id_rol),
	CONSTRAINT FK_usuario_domicilio FOREIGN KEY (id_domicilio) REFERENCES domicilio(id_domicilio),
	CONSTRAINT UQ_email UNIQUE (email)
);


CREATE TABLE compra(
	id_compra INT IDENTITY(1,1),
	fecha_registro DATE NOT NULL,
	id_proveedor INT NOT NULL,
	id_usuario INT NOT NULL,

	CONSTRAINT PK_compra PRIMARY KEY (id_compra),
	CONSTRAINT FK_compra_proveedor FOREIGN KEY (id_proveedor) REFERENCES proveedor(id_proveedor),
	CONSTRAINT FK_compra_usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario)
);


CREATE TABLE detalle_compra(
	id_detalle_compra INT IDENTITY(1,1),
	nombre_producto VARCHAR(100) NOT NULL,
	precio_compra FLOAT NOT NULL,
	cantidad INT NOT NULL,
	total FLOAT NOT NULL,
	id_compra INT NOT NULL,

	CONSTRAINT PK_detalle_compra PRIMARY KEY (id_detalle_compra),
	CONSTRAINT FK_detalle_compra_compra FOREIGN KEY (id_compra) REFERENCES compra(id_compra)
);


CREATE TABLE permiso(
	id_permiso INT IDENTITY(1,1),
	tipo_permiso VARCHAR(100) NOT NULL,
	fecha_inicio DATE NOT NULL,
	fecha_finalizacion DATE NOT NULL,
	comentario_justificacion VARCHAR(200) NOT NULL,
	estado_permiso VARCHAR(50) NOT NULL,
	id_usuario INT NOT NULL,

	CONSTRAINT PK_permiso PRIMARY KEY (id_permiso),
	CONSTRAINT FK_permiso_usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario)
);