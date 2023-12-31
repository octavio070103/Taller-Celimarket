CREATE DATABASE BD_CeliMarket;

USE BD_CeliMarket;

--esta tabla va a contener los datos basicos de mi negocio para pdoer usarlo a lo largo del programa ya sea para crear facturas,informes o comprobantes
CREATE TABLE Negocio(
	id_negocio INT NOT NULL, --no le pongo el atributo identity ya que no es necesario como solo vamos a tener un solo registro
	nombre_negocio VARCHAR(50) NOT NULL,
	direccion VARCHAR(100) NOT NULL,
	CUIT VARCHAR(50) NOT NULL,
	logo VARBINARY(MAX) NULL, --como va a ser una imagen lo defino como varbynary ya que esto me va a permitir maneteer el logotipo del negocio directamente en la bd y no la ruta como en el caso de los productos
	telefono VARCHAR(50) NOT NULL,
	email_negocio VARCHAR(100) NOT NULL,

	--CONSTRAINTS
	CONSTRAINT PK_id_negocio PRIMARY KEY (id_negocio),
		--correo
	CONSTRAINT UQ_email_Negocio_unico UNIQUE (email_negocio),
	CONSTRAINT CK_email_Negocio_correcto CHECK (email_negocio LIKE '%@%.%') --ACA VERFICIO QUE EL EMAIL TENGA @ Y UN . para que tenga el formato correcto de email,con LIKE verifica si un valor cumple con un patr�n especificado.
)

CREATE TABLE categoria(
	id_categoria INT IDENTITY(1,1) NOT NULL,
	nombre_categoria VARCHAR(200)  NOT NULL,
	descripcion_categoria VARCHAR(200) NULL, -- campo opcional
	estado_categoria BIT NOT NULL,
	fecha_creacion DATE NOT NULL, 

	--CONSTRAINT
	CONSTRAINT PK_id_categoria PRIMARY KEY (id_categoria),
	CONSTRAINT UQ_nombre_categoria UNIQUE(nombre_categoria), --hago que el nombre de las categorias sea unica que nose pueda repetir 
    CONSTRAINT CK_categoria_nombre_soloLetras CHECK(nombre_categoria NOT LIKE '%[^a-zA-Z ]%'), --costraint para Permitir letras solamente y un espacio por palabra,expresion regular(regex) '%[^a-zA-Z]%', que busca cualquier car�cter que no sea una letra, Entonces la restriccion CHECK permitira solo letras en el campo nombre
);

ALTER TABLE categoria 
ADD CONSTRAINT DF_categoria_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion;

CREATE TABLE Marca(
	Id_Marca INT IDENTITY(1,1) NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	fecha_creacion DATE NOT NULL,

	--CONSTRAINT
	CONSTRAINT PK_Id_Marca PRIMARY KEY(Id_Marca),
	CONSTRAINT UQ_Nombre UNIQUE(Nombre),
);

ALTER TABLE Marca 
ADD CONSTRAINT DF_Marca_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion;

CREATE TABLE tipo_metodo_pago(
	id_tipo_metodo_pago INT IDENTITY(1,1)NOT NULL,
	nombre_tipo_pago VARCHAR(50) NOT NULL, --efectivo,credito,debito,billetera virtual

	CONSTRAINT PK_tipo_metodo_pago PRIMARY KEY (id_tipo_metodo_pago),
);

CREATE TABLE metodo_pago(
	id_metodo_pago INT IDENTITY(1,1) NOT NULL,
	nombre_metodo_pago VARCHAR(50) NOT NULL, --visa,mastercard,mp,dinero,personal pay
	cuota_posible INT NOT NULL, --aca pondre el numero de cuota que tiene esa tarjeta
	recargo_por_cuota DECIMAL(10,2) NOT NULL, --este campo me va a permitir calcular el recargo que llevara sobre el precio por cuota
	estado_metodo_pago BIT NOT NULL,
	fecha_creacion DATE NOT NULL, 
	id_tipo_metodo_pago INT NOT NULL,

	--CONSTRAINT
	CONSTRAINT PK_Metodo_pago PRIMARY KEY (id_metodo_pago),
	CONSTRAINT CK_nombre_metodo_pago_soloLetras CHECK(nombre_metodo_pago NOT LIKE '%[^a-zA-Z ]%'), --expresion regular(regex) '%[^a-zA-Z ]%', que busca cualquier car�cter que no sea una letra, Entonces la restriccion CHECK permitira solo letras en el campo nombre
	CONSTRAINT FK_metodo_pago_tipo_metodo_pago FOREIGN KEY(id_tipo_metodo_pago) REFERENCES tipo_metodo_pago(id_tipo_metodo_pago)
);


ALTER TABLE metodo_pago 
ADD CONSTRAINT DF_metodo_pago_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion;

CREATE TABLE persona(
	id_persona INT IDENTITY(1,1),
	dni VARCHAR(8) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(50) NOT NULL,
	fecha_nacimiento DATE NOT NULL,
	telefono VARCHAR(50) NOT NULL,
	fecha_creacion DATE NOT NULL, 

	--CONSTRAINT
	CONSTRAINT PK_id_persona PRIMARY KEY (id_persona),
	CONSTRAINT CK_persona_nombre_soloLetras CHECK(nombre NOT LIKE '%[^a-zA-Z]%'), --costraint para Permitir letras solamente
	CONSTRAINT CK_persona_apellido_soloLetras CHECK(apellido NOT LIKE '%[^a-zA-Z]%'), --costraint para Permitir letras solamente,
	--fecha
	CONSTRAINT CK_persona_noMayorA100a�os CHECK (fecha_nacimiento >= DATEADD(YEAR, -100, GETDATE()) AND fecha_nacimiento <= GETDATE()),--aseguramos que la fecha de nacimiento no sea mayor a 100 a�os en el pasado y que no sea una fecha mayor a al fecha actual es decir una fecha futura																																	
	--dni
	CONSTRAINT UQ_dni_persona UNIQUE (dni),
	CONSTRAINT CK_Dni_Longitud CHECK(LEN(dni)=8),
	CONSTRAINT CK_Dni_persona_Solo_numeros CHECK (dni  NOT LIKE '%[^0-9]%'),--verificamos que no hay ning�n car�cter(valor que no cumple con el patron especificaco) que no sea un n�mero del 0 al 9 si hay alguno no ccumple y salta la cosntraint																															
);

ALTER TABLE persona 
ADD CONSTRAINT DF_persona_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion;

--al proveedor lo tomamos como la empresa que provee y no como una persona en si sino como una empresa(ej coca cola,el dorado,pepsi)
CREATE TABLE proveedor(
	id_proveedor INT IDENTITY(1,1),
	nombre VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	telefono VARCHAR(100) NOT NULL,
	estado_proveedor BIT NOT NULL,
	fecha_creacion DATE NOT NULL,

	--CONSTRAINT
	CONSTRAINT PK_proveedor PRIMARY KEY (id_proveedor),

	 CONSTRAINT UQ_nombre_proveedor UNIQUE (nombre), --hago que el nombre del proveedor sea unico ya que como me voy a manejar como si fuera que el proveedor es la empresa no puede haber dos proveedores coca cola en mi bd por ej,
	CONSTRAINT CK_proveedor_nombre CHECK(nombre NOT LIKE '%[^a-zA-Z]%'), --costraint para Permitir letras solamente, con NOT LIKE, por otro lado, verifica si un valor no cumple con un patr�n espec�fico. En otras palabras, se asegura de que el valor no contenga ciertos caracteres o no coincida con el patr�n especificado.
	--correo
	CONSTRAINT UQ_Censista_correo_unico UNIQUE (email),
	CONSTRAINT CK_email_correcto CHECK (email LIKE '%@%.%') --ACA VERFICIO QUE EL EMAIL TENGA @ Y UN . para que tenga el formato correcto de email,con LIKE verifica si un valor cumple con un patr�n especificado.
);

ALTER TABLE proveedor 
ADD CONSTRAINT DF_proveedor_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion;

CREATE TABLE rol(
	id_rol INT IDENTITY(1,1),
	nombre_rol VARCHAR(100) NOT NULL,
	estado_rol BIT NOT NULL,
	fecha_creacion DATE NOT NULL,

	--CONSTRAINT
	CONSTRAINT PK_rol PRIMARY KEY (id_rol),

	CONSTRAINT CK_nombre_rol CHECK(nombre_rol NOT LIKE '%[^a-zA-Z]%') --costraint para Permitir letras solamente, con NOT LIKE, por otro lado, verifica si un valor no cumple con un patr�n espec�fico. En otras palabras, se asegura de que el valor no contenga ciertos caracteres o no coincida con el patr�n especificado.
);
ALTER TABLE rol 
ADD CONSTRAINT DF_rol_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion;

CREATE TABLE domicilio(
	id_domicilio INT IDENTITY(1,1),
	codigo_postal INT NOT NULL,
	localidad VARCHAR(100) NOT NULL,
	provincia VARCHAR(100) NOT NULL,
	numero INT NOT NULL,
	calle VARCHAR(200) NOT NULL,
	descripcion_domicilio VARCHAR(100) NULL,--campo opcional es una descripcion del domicilio 
	estado_domicilio BIT NOT NULL,
	fecha_creacion DATE NOT NULL,

	--CONSTRAINT
	CONSTRAINT PK_domicilio PRIMARY KEY (id_domicilio),
	CONSTRAINT CK_domicilio_calle CHECK(calle NOT LIKE '%[^a-zA-Z ]%') --costraint para Permitir letras solamente,
);
ALTER TABLE domicilio 
ADD CONSTRAINT DF_domicilio_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion;

CREATE TABLE producto(
	id_producto INT IDENTITY(1,1),
	cod_barra_producto INT NOT NULL,
	nombre_producto VARCHAR(50) NOT NULL,
	descripcion_producto VARCHAR(100) NOT NULL,
	precio_compra DECIMAL(10, 2) NOT NULL,
	precio_venta DECIMAL(10, 2) NOT NULL,
	imagen_producto VARCHAR(200) NOT NULL,
	stock_producto INT NOT NULL,
	estado_producto BIT NOT NULL,
	Id_Marca INT NOT NULL,
	id_categoria INT NOT NULL,
	fecha_creacion_producto DATE NOT NULL,

	--CONSTRAINT
	CONSTRAINT PK_producto PRIMARY KEY (id_producto),
	CONSTRAINT FK_producto_categoria FOREIGN KEY (id_categoria) REFERENCES categoria(id_categoria),
	CONSTRAINT FK_producto_Marca FOREIGN KEY(Id_Marca) REFERENCES Marca(Id_Marca),
	CONSTRAINT UQ_cod_barra_producto UNIQUE(cod_barra_producto),

);

ALTER TABLE producto 
ADD CONSTRAINT DF_producto_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion_producto;

CREATE TABLE cliente(
	id_cliente INT IDENTITY(1,1),
	estado_cliente BIT NOT NULL,
	id_persona INT NOT NULL,
	fecha_creacion_cliente DATE NOT NULL,

	--CONSTRAINT
	CONSTRAINT PK_cliente PRIMARY KEY (id_cliente),
	CONSTRAINT FK_cliente_persona FOREIGN KEY (id_persona) REFERENCES persona(id_persona),
	
);

ALTER TABLE cliente 
ADD CONSTRAINT DF_cliente_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion_cliente;


CREATE TABLE usuario(
	id_usuario INT IDENTITY(1,1),
	email VARCHAR(200) NOT NULL, -- unico --
	password VARCHAR(150) NOT NULL,
	estado_usuario BIT NOT NULL,
	id_persona INT NOT NULL,
	id_rol INT NOT NULL,
	id_domicilio INT NOT NULL,
	fecha_creacion_usuario DATE NOT NULL,

	--CONSTRAINT
	CONSTRAINT PK_usuario PRIMARY KEY (id_usuario),
	CONSTRAINT FK_usuario_persona FOREIGN KEY (id_persona) REFERENCES persona(id_persona),
	CONSTRAINT FK_usuario_rol FOREIGN KEY (id_rol) REFERENCES rol(id_rol),
	CONSTRAINT FK_usuario_domicilio FOREIGN KEY (id_domicilio) REFERENCES domicilio(id_domicilio),
	CONSTRAINT UQ_email UNIQUE (email)
);
ALTER TABLE usuario 
ADD CONSTRAINT DF_usuario_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion_usuario;

CREATE TABLE AperturaCaja (
    id_apertura_caja INT IDENTITY(1,1) NOT NULL,
    fecha_apertura DATETIME NOT NULL, --lo hago unique ya que no puedo tener dos caja en el mismo dia abierto,no puede tener la misma fecha_apertura
    monto_inicial DECIMAL(10, 2) NOT NULL, --este campo me va a permitir guardar el monto con el que se abre la caja
    id_usuario INT NOT NULL,
    estado_apertura BIT NOT NULL, -- 1: Abierta, 0: Cerrada

    -- CONSTRAINTS
    CONSTRAINT PK_AperturaCaja PRIMARY KEY (id_apertura_caja),
    CONSTRAINT FK_AperturaCaja_Usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario),
	CONSTRAINT UQ_fecha_apertura UNIQUE(fecha_apertura)
);

ALTER TABLE AperturaCaja
ADD CONSTRAINT DF_AperturaCaja_fecha_apertura DEFAULT GETDATE() FOR fecha_apertura;

ALTER TABLE AperturaCaja
ADD CONSTRAINT UQ_fecha_apertura UNIQUE(fecha_apertura);

CREATE TABLE CierreCaja (
    id_cierre_caja INT IDENTITY(1,1) NOT NULL,
    id_apertura_caja INT NOT NULL,
    fecha_cierre DATETIME NOT NULL,
    id_usuario INT NOT NULL,
    monto_final DECIMAL(10, 2) NOT NULL, --este campo me va a permitir guardar el monto con el que se cierra la caja
    diferencia DECIMAL(10, 2) NOT NULL, -- Diferencia entre el monto final y el esperado
    estado_cierre BIT NOT NULL, -- 1: Cerrada correctamente, 0: Con diferencia
    
    -- CONSTRAINTS
    CONSTRAINT PK_CierreCaja PRIMARY KEY (id_cierre_caja),
    CONSTRAINT FK_CierreCaja_AperturaCaja FOREIGN KEY (id_apertura_caja) REFERENCES AperturaCaja(id_apertura_caja),
    CONSTRAINT FK_CierreCaja_Usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario)
);

ALTER TABLE CierreCaja
ADD CONSTRAINT DF_CierreCaja_fecha_cierre DEFAULT GETDATE() FOR fecha_cierre;

CREATE TABLE venta(
	id_venta INT IDENTITY(1,1),
	venta_fecha DATE NOT NULL,
	tipoFactura VARCHAR(1) NOT NULL, -- va a ser tipo a,b,c,o d
	id_cliente INT NOT NULL,
	id_metodo_pago INT NOT NULL,
	id_usuario INT NOT NULL,
	--cada venta completa (factura) estar�a asociada directamente a una apertura de caja. Esto tiene sentido si consideras que todas las ventas realizadas durante un periodo de apertura de caja deben ser tratadas como una entidad �nica.
	id_apertura_caja INT NOT NULL, -- Agregamos el campo para asociar con la apertura de caja,asi cada venta va a estar relacionado con una apertura caja pudiendo e tratar cada venta completa como una entidad �nica. Puedes tener informaci�n general sobre la venta total al momento de manejar la caja 
	fecha_creacion_venta DATE NOT NULL,
	
	--CONSTRAINT
	CONSTRAINT PK_venta PRIMARY KEY (id_venta),
	CONSTRAINT FK_venta_usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario),
	CONSTRAINT FK_venta_cliente FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente),
	CONSTRAINT FK_venta_metodo_pago FOREIGN KEY (id_metodo_pago) REFERENCES metodo_pago(id_metodo_pago),
	CONSTRAINT FK_Venta_AperturaCaja FOREIGN KEY (id_apertura_caja) REFERENCES AperturaCaja(id_apertura_caja)
);

ALTER TABLE venta 
ADD CONSTRAINT DF_venta_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion_venta;

CREATE TABLE detalle_venta(
	id_detalle_venta INT IDENTITY(1,1),
	cantidad_detalle_venta INT NOT NULL,
	precio_detalle_venta FLOAT NOT NULL,
	subtotal_detalle_venta FLOAT NOT NULL,
	id_producto INT NOT NULL,
	id_venta INT NOT NULL,
	fecha_creacion_detalle_venta DATE NOT NULL,

	--CONSTRAINT
	CONSTRAINT PK_detalle_venta PRIMARY KEY (id_detalle_venta),
	CONSTRAINT FK_detalle_venta_producto FOREIGN KEY (id_producto) REFERENCES producto(id_producto),
	CONSTRAINT FK_detalle_venta_venta FOREIGN KEY (id_venta) REFERENCES venta(id_venta)	
);

ALTER TABLE detalle_venta 
ADD CONSTRAINT DF_detalle_venta_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion_detalle_venta;

CREATE TABLE compra(
	id_compra INT IDENTITY(1,1),
	fecha_registro DATE NOT NULL,
	id_proveedor INT NOT NULL,
	id_usuario INT NOT NULL,
	fecha_creacion_compra DATE NOT NULL,

	--CONSTRAINT
	CONSTRAINT PK_compra PRIMARY KEY (id_compra),
	CONSTRAINT FK_compra_proveedor FOREIGN KEY (id_proveedor) REFERENCES proveedor(id_proveedor),
	CONSTRAINT FK_compra_usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario)
);
ALTER TABLE compra 
ADD CONSTRAINT DF_compra_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion_compra;

CREATE TABLE detalle_compra(
	id_detalle_compra INT IDENTITY(1,1),
	nombre_producto VARCHAR(100) NOT NULL,
	precio_compra FLOAT NOT NULL,
	cantidad INT NOT NULL,
	total FLOAT NOT NULL,
	id_compra INT NOT NULL,
	fecha_creacion_detalle_compra DATE NOT NULL,

	--CONSTRAINT
	CONSTRAINT PK_detalle_compra PRIMARY KEY (id_detalle_compra),
	CONSTRAINT FK_detalle_compra_compra FOREIGN KEY (id_compra) REFERENCES compra(id_compra)
);
ALTER TABLE detalle_compra 
ADD CONSTRAINT DF_detalle_compra_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion_detalle_compra;

CREATE TABLE Motivo_permiso (
    id_motivo_permiso int IDENTITY(1,1) NOT NULL,
    nombre_motivo_permiso varchar(50) NOT NULL,

	--CONSTRAINT
    CONSTRAINT PK_id_motivo_permiso PRIMARY KEY  (id_motivo_permiso)
);


CREATE TABLE permiso(
	id_permiso INT IDENTITY(1,1),
	fecha_inicio DATE NOT NULL,
	fecha_finalizacion DATE NOT NULL,
	comentario_justificacion VARCHAR(200) NOT NULL,
	estado_aprobacion VARCHAR(20) NOT NULL,--este campo me permite saber si la solicutd de permiso fue aceptada o rechazada por el administrador  pendiente(valor por default),aprobado,rechazado
	estado_permiso BIT NOT NULL,--1=alta,0=baja
	id_usuario INT NOT NULL,
	fecha_creacion_permiso DATE NOT NULL,
	id_motivo_permiso INT NOT NULL,

	--CONSTRAINT
	CONSTRAINT PK_permiso PRIMARY KEY (id_permiso),
	CONSTRAINT FK_permiso_usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario),
	CONSTRAINT FK_permiso_Motivo_permiso FOREIGN KEY(id_motivo_permiso) REFERENCES Motivo_permiso(id_motivo_permiso)
);
ALTER TABLE permiso 
ADD CONSTRAINT DF_permiso_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion_permiso;
--agrego un retriccion de tipo default para cuando se inserte un permiso por defecto el campo estado_aprobacion sea pendiente
ALTER TABLE permiso
ADD CONSTRAINT DF_estado_aprobacion DEFAULT 'pendiente' for estado_aprobacion

--motivo Consulta
CREATE TABLE Motivo_consulta (
    id_motivo_consulta int IDENTITY(1,1) NOT NULL,
    nombre_motivo_consulta varchar(50) NOT NULL,

	--CONSTRAINT
    CONSTRAINT PK_id_motivo_consulta PRIMARY KEY  (id_Motivo_consulta)
)

CREATE TABLE consulta(
	id_consulta INT IDENTITY(1,1) NOT NULL,
	comentario_consulta VARCHAR(200) NOT NULL,
	estado_consulta VARCHAR(20) NOT NULL, --este campo me permite saber si la cosulta fue leida o no leido por el administrador  (leido,no leido)
	fecha_consulta DATE NOT NULL,
	id_usuario INT NOT NULL,
	id_motivo_consulta INT NOT NULL,

	--CONSTRAINT
	CONSTRAINT PK_id_cosulta PRIMARY KEY(id_consulta),
	CONSTRAINT FK_Consulta_Usuario FOREIGN KEY(id_usuario) REFERENCES usuario(id_usuario),
	CONSTRAINT FK_Motivo_Consulta FOREIGN KEY(id_motivo_consulta) REFERENCES Motivo_consulta(id_motivo_consulta) 
)
ALTER TABLE consulta
ADD CONSTRAINT DF_fecha_Consulta DEFAULT GETDATE() FOR fecha_consulta;
--agrego un retriccion de tipo default para cuando se inserte una cosnulta por defecto el campo estado_consulta sea no leido
ALTER TABLE consulta
ADD CONSTRAINT DF_estado_consulta DEFAULT 'no leido' for estado_consulta


----------------LOTE DE INSERCIONES
--negocio 
INSERT INTO Negocio (id_negocio,nombre_negocio,direccion,CUIT,telefono,email_negocio)
VALUES(1,'CeliMarket','Puyreedon 2111','30-70717789-2','3795-058041','ventascelimarket@gmail.com')

-- Categor�a
INSERT INTO categoria (nombre_categoria,descripcion_categoria, estado_categoria) VALUES ('Almacen','Aqui se encuentran todas las categorias' ,1);
INSERT INTO categoria (nombre_categoria,descripcion_categoria, estado_categoria) VALUES ('Frescos', 'Aqui se encuentran Los Lacteos,Pastas y Tapas,Fiambreria' ,1);
INSERT INTO categoria (nombre_categoria,descripcion_categoria, estado_categoria) VALUES ('Bebidas', 'Aqui se encuentras Aguas,Gaseosas,Jugos,Bebidas energizantes,Aperitivos y Bebidas Alcohilicas' ,1);
INSERT INTO categoria (nombre_categoria,descripcion_categoria, estado_categoria) VALUES ('Carnes', 'Aqui se encuentran la Carne vacuna,Pollo y granja,Carne de cerdo,Anchuras y embutidos' ,1);
INSERT INTO categoria (nombre_categoria,descripcion_categoria, estado_categoria) VALUES ('Frutas','Aqui se encuentras las Frutas cortadas y Frutos secos',1);
INSERT INTO categoria (nombre_categoria,descripcion_categoria, estado_categoria) VALUES ('Verduras','Aqui se encuentras las Verduras cortadas y ensaldas preparadas',1);
INSERT INTO categoria (nombre_categoria,descripcion_categoria, estado_categoria) VALUES ('Panaderia','Aqui se encuentras los Panificados,Pan rallado y rebozadores,Pizzas y prepizzas,Sandwiches,Empanadas y Tartas',1);
--INSERT INTO categoria (nombre_categoria,descripcion_categoria, estado_categoria) VALUES ('Limpieza', 'Aqui se encuentras las Verduras cortadas y ensaldas preparadas',1);
INSERT INTO categoria (nombre_categoria,descripcion_categoria, estado_categoria) VALUES ('Desayuno', 'Galletitas, Bizcochitos y tostadas, Yerba, Infusiones, Cerales y barritas',1);
INSERT INTO categoria (nombre_categoria,descripcion_categoria, estado_categoria) VALUES ('Congelados','Aqui se encuentras las Hamburguesas, Nuggets y reobazados, Papas, Pollos, Verduras y Frutas, Comidas y panificados, Helados y postres',1);

--MArca
INSERT INTO Marca(Nombre)VALUES('Maizena');
INSERT INTO Marca(Nombre)VALUES('Exquisita');
INSERT INTO Marca(Nombre)VALUES('Matarazzo');
INSERT INTO Marca(Nombre)VALUES('MYK');
INSERT INTO Marca(Nombre)VALUES('Presto Pronta');
INSERT INTO Marca(Nombre)VALUES('Noel');
INSERT INTO Marca(Nombre)VALUES('La huerta');
INSERT INTO Marca(Nombre)VALUES('Arcor');
INSERT INTO Marca(Nombre)VALUES('Carrefour');
INSERT INTO Marca(Nombre)VALUES('Cocinero');
INSERT INTO Marca(Nombre)VALUES('Vicentin');
INSERT INTO Marca(Nombre)VALUES('Coca-Cola');

--tipo_metodo_pago
INSERT INTO tipo_metodo_pago(nombre_tipo_pago)VALUES('efectivo');
INSERT INTO tipo_metodo_pago(nombre_tipo_pago)VALUES('Tarjeta de credito');
INSERT INTO tipo_metodo_pago(nombre_tipo_pago)VALUES('Tarjeta de debito');

--metodo de pago 
--id_tipo_metodo_pago 1 =efectivo,2=tarjeta credtio,3=tarjeta debito
--credito
INSERT INTO metodo_pago(nombre_metodo_pago,cuota_posible,recargo_por_cuota,estado_metodo_pago,id_tipo_metodo_pago)VALUES('Visa',1,0.00,1,2);--no tiene recargo en 1 cuotas sobre el precio del producto
INSERT INTO metodo_pago(nombre_metodo_pago,cuota_posible,recargo_por_cuota,estado_metodo_pago,id_tipo_metodo_pago)VALUES('Visa',3,0.00,1,2);--no tiene recargo en 3 cuotas sobre el precio del producto
INSERT INTO metodo_pago(nombre_metodo_pago,cuota_posible,recargo_por_cuota,estado_metodo_pago,id_tipo_metodo_pago)VALUES('Visa',6,14.00,1,2);--tiene un recargo del %14 porciento si es en 6 cuotas

INSERT INTO metodo_pago(nombre_metodo_pago,cuota_posible,recargo_por_cuota,estado_metodo_pago,id_tipo_metodo_pago)VALUES('Mastercard',1,0.00,1,2);--no tiene recargo en 1 cuotas sobre el precio del producto
INSERT INTO metodo_pago(nombre_metodo_pago,cuota_posible,recargo_por_cuota,estado_metodo_pago,id_tipo_metodo_pago)VALUES('Mastercard',3,0.00,1,2);--no tiene recargo en 3 cuotas sobre el precio del producto
INSERT INTO metodo_pago(nombre_metodo_pago,cuota_posible,recargo_por_cuota,estado_metodo_pago,id_tipo_metodo_pago)VALUES('Mastercard',6,14.00,1,2);--tiene un recargo del %14 porciento si es en 6 cuotas

--debito
INSERT INTO metodo_pago(nombre_metodo_pago,cuota_posible,recargo_por_cuota,estado_metodo_pago,id_tipo_metodo_pago)VALUES('Personal Pay',1,0.00,1,3);--no tiene recargo en 1 cuotas sobre el precio del producto porque es debito 
INSERT INTO metodo_pago(nombre_metodo_pago,cuota_posible,recargo_por_cuota,estado_metodo_pago,id_tipo_metodo_pago)VALUES('Mercado Pago',1,0.00,1,3);--no tiene recargo en 3 cuotas sobre el precio del producto
INSERT INTO metodo_pago(nombre_metodo_pago,cuota_posible,recargo_por_cuota,estado_metodo_pago,id_tipo_metodo_pago)VALUES('Visa debito',1,0.00,1,3);--tiene un recargo del %14 porciento si es en 6 cuotas

--efectivo
INSERT INTO metodo_pago(nombre_metodo_pago,cuota_posible,recargo_por_cuota,estado_metodo_pago,id_tipo_metodo_pago)VALUES('Pesos',1,0.00,1,1);--no tiene recargo en 1 cuotas sobre el precio del producto porque es debito 
INSERT INTO metodo_pago(nombre_metodo_pago,cuota_posible,recargo_por_cuota,estado_metodo_pago,id_tipo_metodo_pago)VALUES('RapiPago',1,0.00,1,1);--no tiene recargo en 3 cuotas sobre el precio del producto
INSERT INTO metodo_pago(nombre_metodo_pago,cuota_posible,recargo_por_cuota,estado_metodo_pago,id_tipo_metodo_pago)VALUES('PagoFacil',1,0.00,1,1);--tiene un recargo del %14 porciento si es en 6 cuotas


---persona
INSERT INTO persona(dni,nombre,apellido,fecha_nacimiento,telefono)VALUES('44622119','octavio','sanchez','2003-01-07','3795086351');
INSERT INTO persona(dni,nombre,apellido,fecha_nacimiento,telefono)VALUES('44622120','fernando','sanchez','2003-01-07','3795086390');
INSERT INTO persona(dni,nombre,apellido,fecha_nacimiento,telefono)VALUES('44622121','virginia','sanchez','1999-06-07','3794980765');

INSERT INTO persona(dni,nombre,apellido,fecha_nacimiento,telefono)VALUES('43266218','Lautaro','Romero','2001-04-27','3794404040');
INSERT INTO persona(dni,nombre,apellido,fecha_nacimiento,telefono)VALUES('43266219','Gerardo','Morales','2006-04-27','3794404041');
INSERT INTO persona(dni,nombre,apellido,fecha_nacimiento,telefono)VALUES('43266220','Rodrigo','Sosa','1998-04-27','3794404042');

--rol
INSERT INTO rol(nombre_rol,estado_rol) VALUES('Administrador',1);
INSERT INTO rol(nombre_rol,estado_rol) VALUES('Gerente',1);
INSERT INTO rol(nombre_rol,estado_rol) VALUES('Vendedor',1);

--domicilio
INSERT INTO domicilio(codigo_postal,localidad,provincia,numero,calle,descripcion_domicilio,estado_domicilio) VALUES(3400,'Corrientes','Corrientes',2310,'Garcia de Cossio','Casa con porton negro de dos pisos',1);
INSERT INTO domicilio(codigo_postal,localidad,provincia,numero,calle,descripcion_domicilio,estado_domicilio) VALUES(3400,'Corrientes','Itati',4578,'Honduras','Casa con porton gris de metal',1);

--producto


--cliente
INSERT INTO cliente(estado_cliente,id_persona)VALUES(1,3);
INSERT INTO cliente(estado_cliente,id_persona)VALUES(1,4);
--INSERT INTO cliente(estado_cliente,id_persona)VALUES(1,7);

--usuario
INSERT INTO usuario(email,password,estado_usuario,id_persona,id_rol,id_domicilio) VALUES('octavio@gmail.com','123',1,2,1,2);

--INSERT INTO usuario(email,password,estado_usuario,id_persona,id_rol,id_domicilio) VALUES('administrador@gmail.com','123',1,7,1,2);

INSERT INTO usuario(email,password,estado_usuario,id_persona,id_rol,id_domicilio) VALUES('gerente@gmail.com','123',1,6,2,2);

INSERT INTO usuario(email,password,estado_usuario,id_persona,id_rol,id_domicilio) VALUES('vendedor@gmail.com','123',1,5,3,2);

--Proveedor
--INSERT INTO proveedor(nombre,email,telefono,estado_proveedor) VALUES();

--venta

--detalleVenta

---motivo_permiso
INSERT INTO Motivo_permiso(nombre_motivo_permiso)VALUES('vacaciones anuales');
INSERT INTO Motivo_permiso(nombre_motivo_permiso)VALUES('Licencia por Enfemedad');
INSERT INTO Motivo_permiso(nombre_motivo_permiso)VALUES('Licencia por Paternidad');
INSERT INTO Motivo_permiso(nombre_motivo_permiso)VALUES('Permiso por Duelo');
INSERT INTO Motivo_permiso(nombre_motivo_permiso)VALUES('Permiso por Otros Motivos');

---motivio_consulta
INSERT INTO Motivo_consulta(nombre_motivo_consulta)VALUES('Sistema');
INSERT INTO Motivo_consulta(nombre_motivo_consulta)VALUES('Particular');
INSERT INTO Motivo_consulta(nombre_motivo_consulta)VALUES('Negocio');
INSERT INTO Motivo_consulta(nombre_motivo_consulta)VALUES('Relaciones laborales');
INSERT INTO Motivo_consulta(nombre_motivo_consulta)VALUES('Beneficio');
INSERT INTO Motivo_consulta(nombre_motivo_consulta)VALUES('Otros');