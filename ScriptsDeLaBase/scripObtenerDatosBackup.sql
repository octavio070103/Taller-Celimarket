CREATE PROCEDURE SP_OBTENERINFO_DB(

@ruta_DB_Backup VARCHAR(500) OUTPUT,
@fecha_DB_Backup DATETIME OUTPUT,
@tipo_Backup VARCHAR(100) OUTPUT,
@totalTablas INT OUTPUT,
@NombresTablas NVARCHAR(MAX) OUTPUT,
@size_DB INT OUTPUT ,
)
AS 
 BEGIN
		
		 SELECT TOP 1
			bs.database_name AS [Nombre de la Base de Datos],
			bmf.physical_device_name AS [Ruta del Archivo de Respaldo],
			bs.backup_start_date AS [Fecha de Inicio del Respaldo],
			bs.backup_finish_date AS [Fecha de Finalización del Respaldo],
			CASE bs.type
				WHEN 'D' THEN 'Respaldo Completo'
				WHEN 'I' THEN 'Respaldo Diferencial'
				WHEN 'L' THEN 'Respaldo de Registro de Transacciones'
			END AS [Tipo de Respaldo]
		FROM msdb.dbo.backupset bs
		INNER JOIN msdb.dbo.backupmediafamily bmf ON bs.media_set_id = bmf.media_set_id
		WHERE bs.database_name = 'BD_CeliMarket' --aca debo de poner el nom de mi BD
		ORDER BY bs.backup_finish_date DESC;
		
SELECT table_name
FROM information_schema.tables
WHERE table_type = 'BASE TABLE';
 END
