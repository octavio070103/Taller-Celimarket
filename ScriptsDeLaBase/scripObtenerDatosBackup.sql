CREATE PROCEDURE SP_OBTENERINFO_DB(
--var de entrada del proc almacenado 
@nameBaseDatos VARCHAR(100),
--var de salida del proc almacenado
@ruta_DB_Backup VARCHAR(500) OUTPUT,
@fecha_DB_Backup DATETIME OUTPUT,
@tipo_Backup VARCHAR(100) OUTPUT,
@totalTablas INT OUTPUT,
@NombresTablas NVARCHAR(MAX) OUTPUT,
@size_DB INT OUTPUT,
@serverName VARCHAR(150) OUTPUT
)
AS 
 BEGIN
	declare @cant_backups INT=0	

	SELECT
    @cant_backups=COUNT(*) 
	FROM msdb.dbo.backupset
	WHERE type IN ('D', 'I', 'L') -- Filtra por respaldos completos, diferenciales y de registro de transacciones
	GROUP BY database_name;
	

		 -- Obtener la ruta del archivo de respaldo más reciente si se realizo un backup en la base alguna vez
    if(@cant_backups >0)
	BEGIN
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
		WHERE bs.database_name = @nameBaseDatos -- ACA LE PASO LA BD QUE quiero obtener esos datos
		ORDER BY bs.backup_finish_date DESC;
	
	END
	ELSE
		BEGIN
		--si nunca hubo un backup debo devolver valores vacios en esos campos
		SET @ruta_DB_Backup = '';
		SET @fecha_DB_Backup = GETDATE();
		SET @tipo_Backup = '';
		END

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
	
	--obtner el nombre del servidor de mi base de datos
	SELECT @serverName=@@SERVERNAME ;
 END

 		

