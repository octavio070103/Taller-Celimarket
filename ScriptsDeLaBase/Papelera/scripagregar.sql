/*CREATE TABLE Motivo_permiso(
	id_motivo_permiso INT IDENTITY(1,1) NOT NULL ,
	nombre_motivo_permiso VARCHAR(50) NOT NULL,

	CONSTRAINT PK_id_motivo_permiso PRIMARY KEY(id_motivo_permiso)
)

ALTER TABLE  permiso
DROP COLUMN tipo_permiso 

ALTER TABLE permiso
ADD id_motivo_permiso INT NOT NULL

ALTER TABLE permiso
ADD CONSTRAINT FK_permiso_Motivo_permiso FOREIGN KEY(id_motivo_permiso) REFERENCES Motivo_permiso(id_motivo_permiso)*/

