

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

ALTER TABLE venta
ADD id_apertura_caja INT NOT NULL,
    CONSTRAINT FK_Venta_AperturaCaja FOREIGN KEY (id_apertura_caja) REFERENCES AperturaCaja(id_apertura_caja);