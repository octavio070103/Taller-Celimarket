CREATE PROCEDURE SP_OBTENERINFO_DB(
--var de salida del proc almacenado
@ruta_DB_Backup VARCHAR(500) OUTPUT,
@fecha_DB_Backup DATETIME OUTPUT,
@tipo_Backup VARCHAR(100) OUTPUT,
@totalTablas INT OUTPUT,
@NombresTablas NVARCHAR(MAX) OUTPUT,
@size_DB INT OUTPUT 
)
AS 
 BEGIN
		

		 -- Obtener la ruta del archivo de respaldo más reciente
    SELECT TOP 1
	@ruta_DB_Backup = bmf.physical_device_name,
	@fecha_DB_Backup = backup_finish_date,
	@tipo_Backup = 
	CASE bs.type
		WHEN 'D' THEN 'Respaldo Completo' 
		WHEN 'I' THEN 'Respaldo Diferencial' 
		WHEN 'L' THEN 'Respaldo de Registro de Transacciones'
		ELSE 'Desconocido'
	END
    FROM msdb.dbo.backupset bs
	INNER JOIN msdb.dbo.backupmediafamily bmf ON bs.media_set_id = bmf.media_set_id
    WHERE bs.database_name = 'BD_CeliMarket'
    ORDER BY bs.backup_finish_date DESC;

	-- Obtener el total de tablas en la base de datos solo las tablas que yo cree las del sistema o los diagramas no me cuenta con esta funcion
    SELECT @totalTablas = COUNT(TABLE_NAME)
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_TYPE = 'BASE TABLE';

	-- Obtener los nombres de todas las tablas en la base de datos
    SELECT @NombresTablas = STRING_AGG(TABLE_NAME, ', ')
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_TYPE = 'BASE TABLE';

	-- Obtener el tamaño de la base de datos en MB de la base de datos
    SELECT @size_DB = SUM(size * 8 / 1024)
    FROM sys.master_files
    WHERE type = 0;

 END

 		

