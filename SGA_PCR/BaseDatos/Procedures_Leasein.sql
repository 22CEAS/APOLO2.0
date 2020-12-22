DROP PROCEDURE IF EXISTS `bd_leasein`.`anular_cambio`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`anular_devolucion`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`anular_devolucion_detalle`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`anular_devolucion_observacion_deudas`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`anular_ingreso`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`anular_reparacion`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`anular_salida`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`anular_salida_detalle`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_LC_ingreso`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_cuota`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_det_accesorios_ingreso`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_det_ingreso`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_devolucion_detalle`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_disco_LC`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_disco_LC_ingreso`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_licencia_LC`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_licencia_LC_ingreso`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_memoria_LC`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_memoria_LC_ingreso`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_observacion_deudas_cambio`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_salida_detalle`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`delete_salida_detalle_idDetalle`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_cambio`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_categoria`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_cliente`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_cliente_sucursal`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_cuota`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_devolucion`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_devolucion_det`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_disco_LC`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_disco_LC_SinAfectarCantidad`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_disco_LC_ingreso`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_disco_duro`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_factura`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_ingreso`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_ingreso_det`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_ingreso_det_accesorios`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_laptop_cpu`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_licencia_LC`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_licencia`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_licencia_det`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_licencia_det_accesorios`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_marca`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_memoria_LC`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_memoria_LC_SinAfectarCantidad`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_memoria_LC_ingreso`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_memoria`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_modelo`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_observacion_deudas`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_observacion_deudas_cambio`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_orden_compra`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_pedido`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_pre_salida`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_procesador`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_proveedor`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_reparacion`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_requerimiento_compra`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_salida_det`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_usuario`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`insert_video`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`mostrar_componente_modelos`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_cambio`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_cliente`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_cliente_sucursal`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_devolucion`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_disco_cantidad`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_disco_cantidad_menos`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_disco_duro`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_ingreso`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_laptop_disponibilidad`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_laptop_memoria`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_licencia_LC`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_memoria`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_memoria_cantidad`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_memoria_cantidad_menos`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_observacion`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_procesador`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_proveedor`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_reparacion`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_salida`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_salida_det_devuelto`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_salida_det_estado_cambiado`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_salida_det_fechaFinalPlazo`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_seguro_laptop_cpu`;
DROP PROCEDURE IF EXISTS `bd_leasein`.`update_video`;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_categoria`(
	IN _nombre NVARCHAR(80),
	IN _subCategoria NVARCHAR(80),
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO categoria (nombre,subCategoria,estado,usuario_ins) values
	(_nombre,_subCategoria,1,_usuario_ins);
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_marca`(
	IN _nombre NVARCHAR(80),
	IN _idCategoria INT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO marca (nombre,idCategoria,estado,usuario_ins) values
	(_nombre,_idCategoria,1,_usuario_ins);
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_modelo`(
	IN _nombre NVARCHAR(80),
	IN _idMarca INT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO modelo (nombre,idMarca,estado,usuario_ins) values
	(_nombre,_idMarca,1,_usuario_ins);
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_procesador`(
	IN _idModelo INT,
	IN _idGeneracion INT,
	IN _generacion INT,
	IN _idVelocidad INT,
	IN _velocidad NVARCHAR(20),
	IN _idVelocidadMax INT,
	IN _velocidadMax DOUBLE,
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	OUT _idProcesador INT
)
BEGIN
	
	SET @codigo=(SELECT CONCAT("PRO-",MAX(idProcesador)+1) from procesador);
	INSERT INTO procesador (codigo,idModelo,idGeneracion,generacion,idVelocidad,velocidad,idVelocidadMax,velocidadMax,observacion,estado,usuario_ins) values
	(@codigo,_idModelo,_idGeneracion,_generacion,_idVelocidad,_velocidad,_idVelocidadMax,_velocidadMax,_observacion,1,_usuario_ins);
	COMMIT;
    SET _idProcesador = last_insert_id();
	
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_procesador`(
	IN _idModelo INT,
	IN _idGeneracion INT,
	IN _generacion INT,
	IN _idVelocidad INT,
	IN _velocidad NVARCHAR(20),
	IN _idVelocidadMax INT,
	IN _velocidadMax DOUBLE,
	IN _estado INT,
	IN _usuario_mod NVARCHAR(100), 
	IN _idProcesador INT
)
BEGIN
	SET @fec_mod=(SELECT now());
	UPDATE procesador
	SET idModelo=_idModelo,
		idGeneracion=_idGeneracion,
		generacion=_generacion,
		idVelocidad=_idVelocidad,
		velocidad=_velocidad,
		idVelocidadMax=_idVelocidadMax,
		velocidadMax=_velocidadMax,
		estado=_estado,
		fec_mod=@fec_mod,
		usuario_mod=_usuario_mod
	WHERE idProcesador=_idProcesador;
	COMMIT;
END
$$
DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_video`(
	IN _idModelo INT,
	IN _idTipo INT,
	IN _tipo NVARCHAR(20),
	IN _idCapacidad INT,
	IN _capacidad DOUBLE,
	IN _cantidad INT,
	IN _ubicacion NVARCHAR(80),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	OUT _idVideo INT
)
BEGIN
	SET @codigo=(SELECT CONCAT("VID-",MAX(idVideo)+1) from video);
	INSERT INTO video (codigo,idModelo,idTipo,tipo,idCapacidad,capacidad,cantidad,ubicacion,observacion,estado,usuario_ins) values
	(@codigo,_idModelo,_idTipo,_tipo,_idCapacidad,_capacidad,_cantidad,_ubicacion,_observacion,1,_usuario_ins);
	COMMIT;
    SET _idVideo = last_insert_id();
END
$$ 
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_video`(
	IN _idVideo INT,
	IN _idModelo INT,
	IN _idTipo INT,
	IN _tipo NVARCHAR(20),
	IN _idCapacidad INT,
	IN _capacidad DOUBLE,
	IN _estado INT,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fec_mod=(SELECT now());
	UPDATE video
	SET idModelo=_idModelo,
		idTipo=_idTipo,
		tipo=_tipo,
		idCapacidad=_idCapacidad,
		capacidad=_capacidad,
		estado=_estado,
		fec_mod=@fec_mod,
		usuario_mod=_usuario_mod
	WHERE idVideo=_idVideo;
	COMMIT;
END
$$ 
DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_memoria`(
	IN _idModelo INT,
	IN _idBusFrecuencia INT,
	IN _busFrecuencia DOUBLE,
	IN _idCapacidad INT,
	IN _capacidad DOUBLE,
	IN _cantidad INT,
	IN _ubicacion NVARCHAR(80),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	IN _idTipo INT,
	IN _tipo NVARCHAR(80),
	OUT _idMemoria INT
)
BEGIN
	SET @codigo=(SELECT CONCAT("MEM-",MAX(idMemoria)+1) from memoria);
	INSERT INTO memoria (codigo,idModelo,idTipo,tipo,idBusFrecuencia,busFrecuencia,idCapacidad,capacidad,cantidad,ubicacion,observacion,estado,usuario_ins) values
	(@codigo,_idModelo,_idTipo,_tipo,_idBusFrecuencia,_busFrecuencia,_idCapacidad,_capacidad,_cantidad,_ubicacion,_observacion,1,_usuario_ins);
	COMMIT;
    SET _idMemoria = last_insert_id();
END
$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_memoria`(
	IN _idModelo INT,
	IN _idBusFrecuencia INT,
	IN _busFrecuencia DOUBLE,
	IN _idCapacidad INT,
	IN _capacidad DOUBLE,
	IN _estado INT,
	IN _usuario_mod NVARCHAR(100), 
	IN _idTipo INT,
	IN _tipo NVARCHAR(80),
	IN _idMemoria INT
)
BEGIN
	SET @fec_mod=(SELECT now());
	UPDATE memoria
	SET idModelo=_idModelo,
		idTipo=_idTipo,
		tipo=_tipo,
		idBusFrecuencia=_idBusFrecuencia,
		busFrecuencia=_busFrecuencia,
		idCapacidad=_idCapacidad,
		capacidad=_capacidad,
		estado=_estado,
		fec_mod=@fec_mod,
		usuario_mod=_usuario_mod
	WHERE idMemoria=_idMemoria;
	COMMIT;
END
$$
DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_disco_duro`(
	IN _idModelo INT,
	IN _idTamano INT,
	IN _tamano  NVARCHAR(80),
	IN _idCapacidad INT,
	IN _capacidad DOUBLE,
	IN _cantidad INT,
	IN _ubicacion NVARCHAR(80),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	OUT _idDiscoDuro INT
)
BEGIN
	SET @codigo=(SELECT CONCAT("DIS-",MAX(idDisco)+1) from disco_duro);
	INSERT INTO disco_duro (codigo,idModelo,idTamano,tamano,idCapacidad,capacidad,cantidad,ubicacion,observacion,estado,usuario_ins) values
	(@codigo,_idModelo,_idTamano,_tamano,_idCapacidad,_capacidad,_cantidad,_ubicacion,_observacion,1,_usuario_ins);
	COMMIT;
    SET _idDiscoDuro = last_insert_id();
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_disco_duro`(
	IN _idDisco INT,
	IN _idModelo INT,
	IN _idTamano INT,
	IN _tamano  NVARCHAR(80),
	IN _idCapacidad INT,
	IN _capacidad DOUBLE,
	IN _estado INT,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fec_mod=(SELECT now());
	UPDATE disco_duro
	SET idModelo=_idModelo,
		idTamano=_idTamano,
		tamano=_tamano,
		idCapacidad=_idCapacidad,
		capacidad=_capacidad,
		estado=_estado,
		fec_mod=@fec_mod,
		usuario_mod=_usuario_mod
	WHERE idDisco=_idDisco;
	COMMIT;
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_laptop_cpu`(
	IN _idIngreso INT,
	IN _idIngresoDet INT,
	IN _idModelo INT,
	IN _descripcion NVARCHAR(250),
	IN _tamanoPantalla DOUBLE,
	IN _idProcesador INT,
	IN _idVideo INT,
	IN _partNumber NVARCHAR(80),
	IN _serieFabrica NVARCHAR(80),
	IN _garantia TINYINT,
	IN _fecInicioSeguro DATETIME,
	IN _fecFinSeguro DATETIME,
	IN _ubicacion NVARCHAR(80),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	IN _compraSubarriendo TINYINT, 
	OUT _idLC INT
)
BEGIN
	SET @codigo=(SELECT CONCAT("PCR-LAP",IFNULL( MAX( idLC ) , 0 )+1) from laptop_cpu);
	SET @_idLC=(SELECT IFNULL( MAX( idLC ) , 0 )+1 FROM laptop_cpu);
	INSERT INTO laptop_cpu (idLC,codigo,idIngreso,idIngresoDet,idModelo,descripcion,tamanoPantalla,idProcesador,idVideo,partNumber,serieFabrica,garantia,fecInicioSeguro,fecFinSeguro,ubicacion,observacion,estado,usuario_ins,compraSubarriendo) values
	(@_idLC,@codigo,_idIngreso,_idIngresoDet,_idModelo,_descripcion,_tamanoPantalla,_idProcesador,_idVideo,_partNumber,_serieFabrica,_garantia,_fecInicioSeguro,_fecFinSeguro,_ubicacion,_observacion,2,_usuario_ins,_compraSubarriendo);
	COMMIT;
    SET _idLC = @_idLC;
END
$$
DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_memoria_LC_ingreso`(
	IN _idMemoria INT,
	IN _idLC INT,
	IN _cantidad INT,
	IN _idIngreso INT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO memoria_lc (idMemoria, idLC, cantidad,idIngreso, usuario_ins) VALUES (_idMemoria, _idLC, _cantidad,_idIngreso, _usuario_ins) ; 
END
$$
DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_disco_LC_ingreso`(
	IN _idDisco INT,
	IN _idLC INT,
	IN _cantidad INT,
	IN _idIngreso INT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO disco_LC (idDisco,idLC,cantidad,idIngreso,usuario_ins) values	(_idDisco,_idLC,_cantidad,_idIngreso,_usuario_ins);
END
$$
DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_seguro_laptop_cpu`(
	IN _idLC INT,
	IN _fecInicioSeguro DATETIME,
	IN _fecFinSeguro DATETIME,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fec_mod=(NOW());
	INSERT INTO laptop_cpu (idLC,fecInicioSeguro,fecFinSeguro,fec_mod,usuario_mod) values
	(_idLC,_fecInicioSeguro,_fecFinSeguro,@fec_mod,_usuario_mod);
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_memoria_LC`(
	IN _idMemoria INT,
	IN _idLC INT,
	IN _cantidad INT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	UPDATE memoria SET cantidad=cantidad-_cantidad WHERE idMemoria=_idMemoria; 
	INSERT INTO memoria_lc (idMemoria, idLC, cantidad, usuario_ins) VALUES (_idMemoria, _idLC, _cantidad, _usuario_ins) ; 
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_memoria_LC_SinAfectarCantidad`(
	IN _idMemoria INT,
	IN _idLC INT,
	IN _cantidad INT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO memoria_lc (idMemoria, idLC, cantidad, usuario_ins) VALUES (_idMemoria, _idLC, _cantidad, _usuario_ins) ; 
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_memoria_LC`(
	IN _idLC INT
)
BEGIN
	DELETE FROM memoria_LC where idLC=_idLC; 
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_memoria_cantidad`(
	IN _idMemoria INT,
	IN _cantidad INT
)
BEGIN
	UPDATE memoria SET cantidad=cantidad+_cantidad WHERE idMemoria=_idMemoria; 
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_disco_LC`(
	IN _idDisco INT,
	IN _idLC INT,
	IN _cantidad INT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	UPDATE disco_duro SET cantidad=cantidad-_cantidad WHERE idDisco=_idDisco; 
	INSERT INTO disco_LC (idDisco,idLC,cantidad,usuario_ins) values	(_idDisco,_idLC,_cantidad,_usuario_ins);
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_disco_LC_SinAfectarCantidad`(
	IN _idDisco INT,
	IN _idLC INT,
	IN _cantidad INT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO disco_LC (idDisco,idLC,cantidad,usuario_ins) values	(_idDisco,_idLC,_cantidad,_usuario_ins);
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_disco_LC`(
	IN _idLC INT
)
BEGIN
	DELETE FROM disco_LC where idLC=_idLC; 
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_disco_cantidad`(
	IN _idDisco INT,
	IN _cantidad INT
)
BEGIN
	UPDATE disco_duro SET cantidad=cantidad+_cantidad WHERE idDisco=_idDisco; 
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_licencia`(
	IN _idModelo INT,
	IN _idLC INT,
	IN _clave NVARCHAR(80), 
	IN _fechaActivacion DATETIME, 
	IN _ubicacion NVARCHAR(80),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	SET @_codigo=(SELECT CONCAT("LIC-",IFNULL( MAX(idLicencia) , 0 )+1) from licencia);
	SET @_idLicencia=(SELECT IFNULL( MAX(idLicencia) , 0 )+1 FROM licencia);
	INSERT INTO licencia (idLicencia,codigo,idModelo,idLC,clave,fechaActivacion,ubicacion,observacion,estado,usuario_ins) values
	(@_idLicencia,@_codigo,_idModelo,_idLC,_clave,_fechaActivacion,_ubicacion,_observacion,2,_usuario_ins);
END
$$ DELIMITER ;
	
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_licencia_det`(
	IN _idIngreso INT,
	IN _idIngresoDet INT,
	IN _idModelo INT,
	IN _idLC INT,
	IN _clave NVARCHAR(80), 
	IN _fechaActivacion DATETIME, 
	IN _ubicacion NVARCHAR(80),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	SET @_codigo=(SELECT CONCAT("LIC-",IFNULL( MAX(idLicencia) , 0 )+1) from licencia);
	SET @_idLicencia=(SELECT IFNULL( MAX(idLicencia) , 0 )+1 FROM licencia);
	INSERT INTO licencia (idLicencia,codigo,idIngreso,idIngresoDet,idModelo,idLC,clave,fechaActivacion,ubicacion,observacion,estado,usuario_ins) values
	(@_idLicencia,@_codigo,_idIngreso,_idIngresoDet,_idModelo,_idLC,_clave,_fechaActivacion,_ubicacion,_observacion,1,_usuario_ins);
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_licencia_det_accesorios`(
	IN _idIngreso INT,
	IN _idIngresoDetAccesorios INT,
	IN _idModelo INT,
	IN _idLC INT,
	IN _clave NVARCHAR(80), 
	IN _fechaActivacion DATETIME, 
	IN _ubicacion NVARCHAR(80),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	SET @_codigo=(SELECT CONCAT("LIC-",IFNULL( MAX(idLicencia) , 0 )+1) from licencia);
	SET @_idLicencia=(SELECT IFNULL( MAX(idLicencia) , 0 )+1 FROM licencia);
	INSERT INTO licencia (idLicencia,codigo,idIngreso,idIngresoDetAccesorios,idModelo,idLC,clave,fechaActivacion,ubicacion,observacion,estado,usuario_ins) values
	(@_idLicencia,@_codigo,_idIngreso,_idIngresoDetAccesorios,_idModelo,_idLC,_clave,_fechaActivacion,_ubicacion,_observacion,2,_usuario_ins);
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_licencia_LC`(
	IN _idLicencia INT,
	IN _idLC INT,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fechaActivacion=(SELECT now());
	UPDATE licencia 
	SET idLC=_idLC,
		estado=1,
		fechaActivacion=@fechaActivacion,
		usuario_mod=_usuario_mod
	WHERE idLicencia=_idLicencia; 
	
END
$$ DELIMITER ;


/*Esta procedimiento se hace solamente cuando se ha equivocado en escoger una licencia y todavía no lo has usado*/
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_licencia_LC`(
	IN _idLicencia INT,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE licencia 
	SET idLC=NULL,
		estado=2,
		fec_mod=@fechaModificacion,
		usuario_mod=_usuario_mod
	WHERE idLicencia=_idLicencia; 
END
$$ DELIMITER ;

/*Esta procedimiento se hace cuando una licencia ya vence y tienen que cambiar de licencia, entonces esa licencia queda en estado 0 porque ya esta inutilizable*/
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_licencia_LC`(
	IN _idLicencia INT,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE licencia 
	SET estado=0,
		fec_mod=@fechaModificacion,
		usuario_mod=_usuario_mod
	WHERE idLicencia=_idLicencia; 
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_cliente`(
	IN _tipoDocumento INT,
	IN _nroDocumento NVARCHAR(20),
	IN _nombre_razonSocial NVARCHAR(255),
	IN _telefono NVARCHAR(20),
	IN _email NVARCHAR(255),
	IN _idKAM INT,
	IN _nombreKam NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	OUT _idCliente INT
)
BEGIN
	SET @idCliente=(SELECT IFNULL( MAX( idCliente ) , 0 )+1 FROM cliente);
	INSERT INTO cliente (idCliente,tipoDocumento,nroDocumento,nombre_razonSocial,telefono,email,idKAM,nombreKam,estado,usuario_ins) values
	(@idCliente,_tipoDocumento,_nroDocumento,_nombre_razonSocial,_telefono,_email,_idKAM,_nombreKam,1,_usuario_ins);
	COMMIT;
    SET _idCliente = @idCliente;
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_cliente`(
	IN _idCliente INT,
	IN _tipoDocumento INT,
	IN _nroDocumento NVARCHAR(20),
	IN _nombre_razonSocial NVARCHAR(255),
	IN _telefono NVARCHAR(20),
	IN _email NVARCHAR(255),
	IN _idKAM INT,
	IN _nombreKam NVARCHAR(255),
	IN _estado INT,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fec_mod=(SELECT now());
	UPDATE cliente
	SET tipoDocumento=_tipoDocumento,
		nroDocumento=_nroDocumento,
		nombre_razonSocial=_nombre_razonSocial,
		telefono=_telefono,
		email=_email,
		idKAM=_idKAM,
		nombreKam=_nombreKam,
		estado=_estado,
		fec_mod=@fec_mod,
		usuario_mod=_usuario_mod
	WHERE idCliente=_idCliente;
	COMMIT;
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_cliente_sucursal`(
	IN _idCliente INT,
	IN _nroDocumento NVARCHAR(100),
	IN _nombreContacto NVARCHAR(100),
	IN _direccion NVARCHAR(255),
	IN _telefono NVARCHAR(20),
	IN _email NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	OUT _idSucursal INT
)
BEGIN
	SET @idSucursal=(SELECT IFNULL( MAX( idSucursal ) , 0 )+1 FROM cliente_sucursal);
	INSERT INTO cliente_sucursal (idSucursal,idCliente,nroDocumento,nombreContacto,direccion,telefono,email,observacion,estado,usuario_ins) values
	(@idSucursal,_idCliente,_nroDocumento,_nombreContacto,_direccion,_telefono,_email,_observacion,1,_usuario_ins);
	COMMIT;
    SET _idSucursal = @idSucursal;
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_cliente_sucursal`(
	IN _idSucursal INT,
	IN _nroDocumento NVARCHAR(100),
	IN _nombreContacto NVARCHAR(100),
	IN _direccion NVARCHAR(255),
	IN _telefono NVARCHAR(20),
	IN _email NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _estado INT,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fec_mod=(SELECT now());
	UPDATE cliente_sucursal
	SET nroDocumento=_nroDocumento,
		nombreContacto=_nombreContacto,
		direccion=_direccion,
		telefono=_telefono,
		email=_email,
		observacion=_observacion,
		estado=_estado,
		fec_mod=@fec_mod,
		usuario_mod=_usuario_mod
	WHERE idSucursal=_idSucursal;
	COMMIT;
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_proveedor`(
	IN _ruc NVARCHAR(11),
	IN _razonSocial NVARCHAR(255),
	IN _nombreComercial NVARCHAR(255),
	IN _abreviacion NVARCHAR(11),
	IN _direccion NVARCHAR(255),
	IN _telefono NVARCHAR(20),
	IN _fax NVARCHAR(20),
	IN _email NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _nombreContacto NVARCHAR(255),
	IN _telefonoContacto NVARCHAR(255),
	IN _emailContacto NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	OUT _idProveedor INT
)
BEGIN
	SET @idProveedor=(SELECT IFNULL( MAX( idProveedor ) , 0 )+1 FROM proveedor);
	INSERT INTO proveedor (idProveedor,ruc,razonSocial,nombreComercial,abreviacion,direccion,telefono,fax,email,observacion,nombreContacto,telefonoContacto,emailContacto,estado,usuario_ins) values
	(@idProveedor,_ruc,_razonSocial,_nombreComercial,_abreviacion,_direccion,_telefono,_fax,_email,_observacion,_nombreContacto,_telefonoContacto,_emailContacto,1,_usuario_ins);
	COMMIT;
    SET _idProveedor = @idProveedor;
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_proveedor`(
	IN _idProveedor INT,
	IN _ruc NVARCHAR(11),
	IN _razonSocial NVARCHAR(255),
	IN _nombreComercial NVARCHAR(255),
	IN _abreviacion NVARCHAR(11),
	IN _direccion NVARCHAR(255),
	IN _telefono NVARCHAR(20),
	IN _fax NVARCHAR(20),
	IN _email NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _nombreContacto NVARCHAR(255),
	IN _telefonoContacto NVARCHAR(255),
	IN _emailContacto NVARCHAR(255),
	IN _estado INT,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fec_mod=(SELECT now());
	UPDATE proveedor
	SET ruc=_ruc,
		razonSocial=_razonSocial,
		nombreComercial=_nombreComercial,
		abreviacion=_abreviacion,
		direccion=_direccion,
		telefono=_telefono,
		fax=_fax,
		email=_email,
		observacion=_observacion,
		nombreContacto=_nombreContacto,
		telefonoContacto=_telefonoContacto,
		emailContacto=_emailContacto,
		estado=_estado,
		fec_mod=@fec_mod,
		usuario_mod=_usuario_mod
	WHERE idProveedor=_idProveedor;
	COMMIT;
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_usuario`(
	IN _dni NVARCHAR(8),
	IN _nombre NVARCHAR(255),
	IN _usuario NVARCHAR(20),
	IN _password NVARCHAR(255),
    IN _perfil INT,
	IN _email NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO usuario (dni,nombre,usuario,password,perfil,estado,email,usuario_ins) values
	(_dni,_nombre,_usuario,_password,_perfil,1,_email,_usuario_ins);
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_requerimiento_compra`(
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO requerimiento_compra (observacion,estado,usuario_ins) values
	(_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_orden_compra`(
	IN _idRO INT,
	IN _idProveedor INT,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO orden_compra (idRO,idProveedor,observacion,estado,usuario_ins) values
	(_idRO,_idProveedor,_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_pedido`(
	IN _fecPedido DATETIME,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO pedido (fecPedido,observacion,estado,usuario_ins) values
	(_fecPedido,_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_pre_salida`(
	IN _idCliente INT,
	IN _idSucursal INT,
	IN _rucDni NVARCHAR(100),
	IN _nroContrato NVARCHAR(100),
	IN _nroOC NVARCHAR(100),
	IN _idPedido INT,
	IN _fecSalida DATETIME,
	IN _fecIniContrato DATETIME,
	IN _fecFinContrato DATETIME,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	OUT _idSalida INT
)
BEGIN
	SET @_idSalida=(SELECT IFNULL( MAX( idSalida ) , 0 )+1 FROM salida);
	INSERT INTO salida (idSalida,idCliente,idSucursal,rucDni,nroContrato,nroOC,idPedido,fecSalida,fecIniContrato,fecFinContrato,observacion,estado,usuario_ins) values
	(@_idSalida,_idCliente,_idSucursal,_rucDni,_nroContrato,_nroOC,_idPedido,_fecSalida,_fecIniContrato,_fecFinContrato,_observacion,_estado,_usuario_ins);
	COMMIT;
    SET _idSalida = @_idSalida;
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_salida_det`(
	IN _idSalida INT,
	IN _idLC INT,
	IN _idProcesador INT,
	IN _idVideo INT,
	IN _idDisco1 INT,
	IN _cantidadDisco1 INT,
	IN _idDisco2 INT,
	IN _cantidadDisco2 INT,
	IN _idMemoria1 INT,
	IN _cantidadMemoria1 INT,
	IN _idMemoria2 INT,
	IN _cantidadMemoria2 INT,
	IN _idWindows INT,
	IN _idOffice INT,
	IN _idAntivirus INT,
	IN _caracteristicas NVARCHAR(255),
	IN _guiaSalida NVARCHAR(255),
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	IN _fecIniContrato DATETIME,
	IN _fecFinContrato DATETIME,
	OUT _idSalidaDet INT
)
BEGIN
	SET @idSalidaDet=(SELECT IFNULL( MAX( idSalidaDet ) , 0 )+1 FROM salida_det);
	INSERT INTO salida_det (idSalidaDet,idSalida,idLC,fecIniContrato,fecFinContrato,idProcesador,idVideo,idDisco1,cantidadDisco1,idDisco2,cantidadDisco2,idMemoria1,cantidadMemoria1,idMemoria2,cantidadMemoria2,idWindows,idOffice,idAntivirus,caracteristicas,guiaSalida,motivoNoRecojo,observacion,estado,fueDevuelto,usuario_ins) values
	(@idSalidaDet,_idSalida,_idLC,_fecIniContrato,_fecFinContrato,_idProcesador,_idVideo,_idDisco1,_cantidadDisco1,_idDisco2,_cantidadDisco2,_idMemoria1,_cantidadMemoria1,_idMemoria2,_cantidadMemoria2,_idWindows,_idOffice,_idAntivirus,_caracteristicas,_guiaSalida,"",_observacion,_estado,0,_usuario_ins);
	COMMIT;
    SET _idSalidaDet = @idSalidaDet;
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_cambio`(
	IN _idLCAntiguo INT,
	IN _codigoLCAntiguo NVARCHAR(80),
	IN _estadoLCAntiguo INT,
	IN _idCliente INT,
	IN _nombreCliente NVARCHAR(255),
	IN _rucDni NVARCHAR(11),
	IN _guiaCambio NVARCHAR(50),
	IN _fechaCambio DATETIME,
	IN _ticketTecnico NVARCHAR(255),
	IN _idLCNuevo INT,
	IN _codigoLCNuevo NVARCHAR(80),
	IN _fueDevuelto TINYINT,
	IN _pagaraCliente TINYINT,
	IN _danoLC TINYINT,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	IN _idSalida INT,
	IN _idSalidaDet INT,
	IN _idSucursal INT,
	IN _fecIniContrato DATETIME,
	IN _fecFinContrato DATETIME,
	OUT _idCambio INT
)
BEGIN
	SET @idCambio=(SELECT IFNULL( MAX(idCambio) , 0 )+1 FROM cambio);
	INSERT INTO cambio (idCambio,idSalida,idSalidaDet,idLCAntiguo,codigoLCAntiguo,estadoLCAntiguo,idCliente,idSucursal,nombreCliente,rucDni,guiaCambio,fechaCambio,ticketTecnico,idLCNuevo, codigoLCNuevo,fueDevuelto,pagaraCliente,danoLC,observacion,estado,usuario_ins,fecIniContrato,fecFinContrato) values
	(@idCambio,_idSalida,_idSalidaDet,_idLCAntiguo,_codigoLCAntiguo,_estadoLCAntiguo,_idCliente,_idSucursal,_nombreCliente,_rucDni,_guiaCambio,_fechaCambio,_ticketTecnico,_idLCNuevo, _codigoLCNuevo,_fueDevuelto,_pagaraCliente,_danoLC,_observacion,_estado,_usuario_ins,_fecIniContrato,_fecFinContrato);
	COMMIT;
    SET _idCambio = @idCambio;
END
$$ DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_devolucion`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_devolucion`(
	IN _idCliente INT,
	IN _rucDni NVARCHAR(11),
	IN _guiaDevolucion NVARCHAR(50),
	IN _fechaDevolucion DATETIME,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	OUT _idDevolucion INT
)
BEGIN
	SET @_idDevolucion=(SELECT IFNULL( MAX(idDevolucion) , 0 )+1 FROM devolucion);
	INSERT INTO devolucion (idDevolucion,idCliente,rucDni,guiaDevolucion,fechaDevolucion,observacion,estado,usuario_ins) values
	(@_idDevolucion,_idCliente,_rucDni,_guiaDevolucion,_fechaDevolucion,_observacion,_estado,_usuario_ins);
	COMMIT;
    SET _idDevolucion = @_idDevolucion;
END
$$ DELIMITER ;

DROP PROCEDURE IF EXISTS `insert_devolucion_det`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_devolucion_det`(
	IN _idDevolucion INT,
	IN _idLC INT,
	IN _codigoLC NVARCHAR(255),
	IN _marcaLC NVARCHAR(255),
	IN _modeloLC NVARCHAR(255),
	IN _pagaraCliente INT,
	IN _danoLC INT,
	IN _caracteristicas NVARCHAR(255),
    IN _estadoLC TINYINT,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100),
	IN _idSalidaDet INT,
	IN _idSucursal INT,
	OUT _idDevolucionDet INT
)
BEGIN
	SET @idDevolucionDet=(SELECT IFNULL( MAX( idDevolucionDet ) , 0 )+1 FROM devolucion_det);
	INSERT INTO devolucion_det (idDevolucionDet,idDevolucion,idLC,codigoLC,marcaLC,modeloLC,pagaraCliente,danoLC,caracteristicas,estadoLC,observacion,estado,usuario_ins,idSalidaDet,idSucursal) values
	(@idDevolucionDet,_idDevolucion,_idLC,_codigoLC,_marcaLC,_modeloLC,_pagaraCliente,_danoLC,_caracteristicas,_estadoLC,_observacion,_estado,_usuario_ins,_idSalidaDet,_idSucursal);
	COMMIT;
    SET _idDevolucionDet = @idDevolucionDet;
END
$$ DELIMITER ;



DROP PROCEDURE IF EXISTS `insert_observacion_deudas`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_observacion_deudas`(
	IN _idCliente INT,
	IN _idLC INT,
	IN _idSalidaDet INT,
	IN _idDevolucion INT,
	IN _observacionDeuda NVARCHAR(255),
	IN _KAM NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	SET @idObservacionDeudas=(SELECT IFNULL( MAX( idObservacionDeudas ) , 0 )+1 FROM observacion_deudas);
	INSERT INTO observacion_deudas (idObservacionDeudas,idCliente,idLC,idSalidaDet,idDevolucion,observacionDeuda,KAM,estado,usuario_ins) values
	(@idObservacionDeudas,_idCliente,_idLC,_idSalidaDet,_idDevolucion,_observacionDeuda,_KAM,_estado,_usuario_ins);
	COMMIT;
END
$$ DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_observacion_deudas_cambio`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_observacion_deudas_cambio`(
	IN _idCliente INT,
	IN _idLC INT,
	IN _idSalidaDet INT,
	IN _idCambio INT,
	IN _observacionDeuda NVARCHAR(255),
	IN _KAM NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	SET @idObservacionDeudas=(SELECT IFNULL( MAX( idObservacionDeudas ) , 0 )+1 FROM observacion_deudas);
	INSERT INTO observacion_deudas (idObservacionDeudas,idCliente,idLC,idSalidaDet,idCambio,observacionDeuda,KAM,estado,usuario_ins) values
	(@idObservacionDeudas,_idCliente,_idLC,_idSalidaDet,_idCambio,_observacionDeuda,_KAM,_estado,_usuario_ins);
	COMMIT;
END
$$ DELIMITER ;



DROP PROCEDURE IF EXISTS `mostrar_componente_modelos`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrar_componente_modelos`(
	IN _idMarca INT
)
BEGIN
	Select idModelo, nombre
	from modelo
	where idMarca=_idMarca and estado=1;
END
$$ DELIMITER ;

/*este procedure no se usará pero quedará provisional para saber como se hace, nada más)*/
DROP PROCEDURE IF EXISTS `update_laptop_memoria`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_laptop_memoria`(
	IN	_idLC int,
    IN  _idMemoria int,
    IN  _cantidad int,
    IN _usuario_ins VARCHAR(100)
)
BEGIN


		IF EXISTS(Select Cantidad from vista_laptops_memorias where idLC=_idLC and idMemoria=_idMemoria) THEN
			SET @cantidad=(Select * from vista_laptops_memorias where idLC=_idLC and idMemoria=_idMemoria);
			UPDATE memoria SET cantidad=cantidad+@cantidad WHERE idMemoria=_idMemoria; 
			DELETE FROM memoria_lc where idLC=_idLC and idMemoria=_idMemoria; 
			UPDATE memoria SET cantidad=cantidad-_cantidad WHERE idMemoria=_idMemoria; 
			INSERT INTO memoria_lc (idMemoria, idLC, cantidad, usuario_ins) VALUES (_idMemoria, _idLC, _cantidad, _usuario_ins) ; 
		ELSE 
			UPDATE memoria SET cantidad=cantidad-_cantidad WHERE idMemoria=_idMemoria; 
			INSERT INTO memoria_lc (idMemoria, idLC, cantidad, usuario_ins) VALUES (_idMemoria, _idLC, _cantidad, _usuario_ins) ; 
		END IF;
    COMMIT;
END
$$
DELIMITER ;



/*Esta procedimiento se hace solamente cuando se ha equivocado en escoger una licencia y todavía no lo has usado*/
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_laptop_disponibilidad`(
	IN _idLC INT,
	IN _estado INT,
	IN _ubicacion NVARCHAR(250),
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE laptop_cpu 
	SET estado=_estado,
		ubicacion=_ubicacion,
		fec_mod=@fechaModificacion,
		usuario_mod=_usuario_mod
	WHERE idLC=_idLC; 
END
$$ 
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_salida_detalle`(
	IN _idSalida INT
)
BEGIN
	DELETE FROM salida_det where idSalida=_idSalida; 
END
$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_salida_detalle_idDetalle`(
	IN _idCambio INT
)
BEGIN
	DELETE FROM salida_det where caracteristicas=_idCambio; 
END
$$
DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_observacion_deudas_cambio`(
	IN _idCambio INT
)
BEGIN
	DELETE FROM observacion_deudas where idCambio=_idCambio; 
END
$$
DELIMITER ;



/*Esta procedimiento se hace solamente cuando se ha equivocado en escoger una licencia y todavía no lo has usado*/
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_salida`(
	IN _idCliente INT,
	IN _idSucursal INT,
	IN _rucDni NVARCHAR(100),
	IN _nroContrato NVARCHAR(100),
	IN _nroOC NVARCHAR(100),
	IN _idPedido INT,
	IN _fecSalida DATETIME,
	IN _fecIniContrato DATETIME,
	IN _fecFinContrato DATETIME,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100),
	IN _idSalida INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE salida 
	SET idCliente=_idCliente,
		idSucursal=_idSucursal,
		rucDni=_rucDni,
		nroContrato=_nroContrato,
		nroOC=_nroOC,
		idPedido=_idPedido,
		fecSalida=_fecSalida,
		fecIniContrato=_fecIniContrato,
		fecFinContrato=_fecFinContrato,
		observacion=_observacion,
		estado=_estado,
		fec_mod=@fechaModificacion,
		usuario_mod=_usuario_mod
	WHERE idSalida=_idSalida; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `update_devolucion`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_devolucion`(
	IN _idCliente INT,
	IN _rucDni NVARCHAR(11),
	IN _guiaDevolucion NVARCHAR(50),
	IN _fechaDevolucion DATETIME,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100), 
	IN _idDevolucion INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE devolucion 
	SET idCliente=_idCliente,
	rucDni=_rucDni,
	guiaDevolucion=_guiaDevolucion,
	fechaDevolucion=_fechaDevolucion,
	fec_mod=@fechaModificacion,
	observacion=_observacion,
	estado=_estado,
	usuario_mod=_usuario_mod
	where idDevolucion=_idDevolucion;
END
$$ DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_devolucion_detalle`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_devolucion_detalle`(
	IN _idDevolucion INT
)
BEGIN
	DELETE FROM devolucion_det where idDevolucion=_idDevolucion; 
END
$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_salida_det_devuelto`(
	IN _idSalidaDet INT,
    IN _fueDevuelto TINYINT,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE salida_det
	SET fueDevuelto=_fueDevuelto,
		fec_mod=@fechaModificacion,
		usuario_mod=_usuario_mod
	WHERE idSalidaDet=_idSalidaDet; 
END
$$ 
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_salida_det_estado_cambiado`(
	IN _idSalidaDet INT,
    IN _estadoDet TINYINT,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE salida_det
	SET estado=_estadoDet,
		fec_mod=@fechaModificacion,
		usuario_mod=_usuario_mod
	WHERE idSalidaDet=_idSalidaDet; 
END
$$ 
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `anular_devolucion`(
	IN _observacion NVARCHAR(100),
    IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100),
    IN _idDevolucion INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE devolucion
	SET observacion=_observacion,
		fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idDevolucion=_idDevolucion; 
END
$$ 
DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `anular_devolucion_detalle`(
    IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100),
    IN _idDevolucionDet INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE devolucion_det
	SET fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idDevolucionDet=_idDevolucionDet; 
END
$$ 
DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `anular_salida`(
	IN _observacion NVARCHAR(100),
    IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100),
    IN _idSalida INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE salida
	SET observacion=_observacion,
		fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idSalida=_idSalida; 
END
$$ 
DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `anular_salida_detalle`(
    IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100),
    IN _idSalidaDet INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE salida_det
	SET fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idSalidaDet=_idSalidaDet; 
END
$$ 
DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `anular_devolucion_observacion_deudas`(
    IN _idDevolucion INT
)
BEGIN
	DELETE FROM observacion_deudas where idDevolucion=_idDevolucion;
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `update_cambio`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_cambio`(
	IN _idLCAntiguo INT,
	IN _codigoLCAntiguo NVARCHAR(80),
	IN _estadoLCAntiguo INT,
	IN _idCliente INT,
	IN _nombreCliente NVARCHAR(255),
	IN _rucDni NVARCHAR(11),
	IN _guiaCambio NVARCHAR(50),
	IN _fechaCambio DATETIME,
	IN _ticketTecnico NVARCHAR(255),
	IN _idLCNuevo INT,
	IN _codigoLCNuevo NVARCHAR(80),
	IN _fueDevuelto TINYINT,
	IN _pagaraCliente TINYINT,
	IN _danoLC TINYINT,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100), 
	IN _idSalida INT,
	IN _idSalidaDet INT,
	IN _idSucursal INT,
	IN _idCambio INT,
	IN _fecIniContrato DATETIME,
	IN _fecFinContrato DATETIME
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE cambio 
	SET idSalida=_idSalida,
	idSalidaDet=_idSalidaDet,
	idLCAntiguo=_idLCAntiguo,
	codigoLCAntiguo=_codigoLCAntiguo,
	estadoLCAntiguo=_estadoLCAntiguo,
	idCliente=_idCliente,
	idSucursal=_idSucursal,
	nombreCliente=_nombreCliente,
	rucDni=_rucDni,
	guiaCambio=_guiaCambio,
	fechaCambio=_fechaCambio,
	ticketTecnico=_ticketTecnico,
	idLCNuevo=_idLCNuevo, 
	codigoLCNuevo=_codigoLCNuevo,
	fueDevuelto=_fueDevuelto,
	pagaraCliente=_pagaraCliente,
	danoLC=_danoLC,
	observacion=_observacion,
	estado=_estado,
	fec_mod=@fechaModificacion,
	usuario_mod=_usuario_mod,
	fecIniContrato=_fecIniContrato,
	fecFinContrato=_fecFinContrato
	where idCambio=_idCambio;
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `anular_cambio`(
	IN _observacion NVARCHAR(100),
    IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100),
    IN _idCambio INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE cambio
	SET observacion=_observacion,
		fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idCambio=_idCambio; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ingreso`(
	IN _idOC INT,
	IN _idTipoIngreso INT,
	IN _tipoIngreso NVARCHAR(255),
	IN _idProveedor INT,
	IN _razonSocial NVARCHAR(255),
	IN _ruc NVARCHAR(11),
	IN _facturaIngreso NVARCHAR(255),
	IN _guiaIngreso NVARCHAR(255),
	IN _fecIngresa DATETIME,
	IN _idTipoMoneda INT,
	IN _tipoMoneda NVARCHAR(255),
	IN _montoCambio DOUBLE ,
	IN _total DOUBLE,
	IN _observacion NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	OUT _idIngreso INT
)
BEGIN
	SET @_idIngreso=(SELECT IFNULL( MAX(idIngreso) , 0 )+1 FROM ingreso);
	INSERT INTO ingreso (idIngreso,idOC,idTipoIngreso,tipoIngreso,idProveedor,razonSocial,ruc,facturaIngreso,guiaIngreso,fecIngresa,idTipoMoneda,tipoMoneda,montoCambio,total,observacion,estado,usuario_ins) values
	(@_idIngreso,_idOC,_idTipoIngreso,_tipoIngreso,_idProveedor,_razonSocial,_ruc,_facturaIngreso,_guiaIngreso,_fecIngresa,_idTipoMoneda,_tipoMoneda,_montoCambio,_total,_observacion,_estado,_usuario_ins);
	COMMIT;
    SET _idIngreso = @_idIngreso;
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_ingreso_det`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ingreso_det`(
	IN _idIngreso INT,
	IN _idMarcaLC INT,
	IN _idModeloLC INT,
	IN _partNumber NVARCHAR(255),
	IN _pantalla DOUBLE,
	IN _garantia TINYINT,
	IN _cantidad INT,
	IN _subTotal DOUBLE,
	IN _idProcesador INT,
	IN _idVideo INT,
	IN _idDisco1 INT,
	IN _cantidadDisco1 INT,
	IN _idDisco2 INT,
	IN _cantidadDisco2 INT,
	IN _idMemoria1 INT,
	IN _cantidadMemoria1 INT,
	IN _idMemoria2 INT,
	IN _cantidadMemoria2 INT,
	IN _idMemoria3 INT,
	IN _cantidadMemoria3 INT,
	IN _idModeloWindows INT,
	IN _idModeloOffice INT,
	IN _idModeloAntivirus INT,
	IN _caracteristicas NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	OUT _idIngresoDet INT
)
BEGIN
	SET @_idIngresoDet=(SELECT IFNULL( MAX(idIngresoDet) , 0 )+1 FROM ingreso_det);
	INSERT INTO ingreso_det (idIngresoDet,idIngreso,idMarcaLC,idModeloLC,partNumber,pantalla,garantia,cantidad,subTotal,idProcesador,idVideo,idDisco1,cantidadDisco1,idDisco2,cantidadDisco2,idMemoria1,cantidadMemoria1,idMemoria2,cantidadMemoria2,idMemoria3,cantidadMemoria3,idModeloWindows,idModeloOffice,idModeloAntivirus,caracteristicas,observacion,estado,usuario_ins) values
	(@_idIngresoDet,_idIngreso,_idMarcaLC,_idModeloLC,_partNumber,_pantalla,_garantia,_cantidad,_subTotal,_idProcesador,_idVideo,_idDisco1,_cantidadDisco1,_idDisco2,_cantidadDisco2,_idMemoria1,_cantidadMemoria1,_idMemoria2,_cantidadMemoria2,_idMemoria3,_cantidadMemoria3,_idModeloWindows,_idModeloOffice,_idModeloAntivirus,_caracteristicas,_observacion,_estado,_usuario_ins);
	COMMIT;
    SET _idIngresoDet = @_idIngresoDet;
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_ingreso_det_accesorios`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ingreso_det_accesorios`(
	IN _idIngreso INT,
	IN _idCategoria INT,
	IN _idModeloLicencia INT,
	IN _clave NVARCHAR(255),
	IN _idDisco INT,
	IN _idMemoria INT,
	IN _cantidad INT,
	IN _subTotal DOUBLE,
	IN _observacion NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	OUT _idIngresoDetAccesorios INT
)
BEGIN
	SET @_idIngresoDetAccesorios=(SELECT IFNULL( MAX(idIngresoDetAccesorios) , 0 )+1 FROM ingreso_det_accesorios);
	INSERT INTO ingreso_det_accesorios (idIngresoDetAccesorios,idIngreso,idCategoria,idModeloLicencia,clave,idDisco,idMemoria,cantidad,subTotal,observacion,estado,usuario_ins) values
	(@_idIngresoDetAccesorios,_idIngreso,_idCategoria,_idModeloLicencia,_clave,_idDisco,_idMemoria,_cantidad,_subTotal,_observacion,_estado,_usuario_ins);
	COMMIT;
    SET _idIngresoDetAccesorios = @_idIngresoDetAccesorios;
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_licencia_LC_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_licencia_LC_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM licencia where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;



DROP PROCEDURE IF EXISTS `delete_disco_LC_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_disco_LC_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM disco_LC where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;



DROP PROCEDURE IF EXISTS `delete_memoria_LC_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_memoria_LC_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM memoria_LC where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_LC_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_LC_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM laptop_cpu where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_det_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_det_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM ingreso_det where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_det_accesorios_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_det_accesorios_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM ingreso_det_accesorios where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `update_memoria_cantidad_menos`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_memoria_cantidad_menos`(
	IN _idMemoria INT,
	IN _cantidad INT
)
BEGIN
	UPDATE memoria SET cantidad=cantidad-_cantidad WHERE idMemoria=_idMemoria; 
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `update_disco_cantidad_menos`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_disco_cantidad_menos`(
	IN _idDisco INT,
	IN _cantidad INT
)
BEGIN
	UPDATE disco_duro SET cantidad=cantidad-_cantidad WHERE idDisco=_idDisco; 
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `update_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_ingreso`(
	IN _idOC INT,
	IN _idTipoIngreso INT,
	IN _tipoIngreso NVARCHAR(255),
	IN _idProveedor INT,
	IN _razonSocial NVARCHAR(255),
	IN _ruc NVARCHAR(11),
	IN _facturaIngreso NVARCHAR(255),
	IN _guiaIngreso NVARCHAR(255),
	IN _fecIngresa DATETIME,
	IN _idTipoMoneda INT,
	IN _tipoMoneda NVARCHAR(255),
	IN _montoCambio DOUBLE ,
	IN _total DOUBLE,
	IN _observacion NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100), 
	IN _idIngreso INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE ingreso 
	SET idOC=_idOC,
	idTipoIngreso=_idTipoIngreso,
	tipoIngreso=_tipoIngreso,
	idProveedor=_idProveedor,
	razonSocial=_razonSocial,
	ruc=_ruc,
	facturaIngreso=_facturaIngreso,
	fecIngresa=_fecIngresa,
	idTipoMoneda=_idTipoMoneda,
	tipoMoneda=_tipoMoneda,
	montoCambio=_montoCambio,
	total=_total,
	observacion=_observacion,
	estado=_estado,
	fec_mod=@fechaModificacion,
	usuario_mod=_usuario_mod
	where idIngreso=_idIngreso;
END
$$
DELIMITER ;



DROP PROCEDURE IF EXISTS `anular_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `anular_ingreso`(
	IN _observacion NVARCHAR(100),
    IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100),
    IN _idIngreso INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE ingreso
	SET observacion=_observacion,
		fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idIngreso=_idIngreso; 
	
	SET @fechaModificacion=(SELECT now());
	UPDATE ingreso_det
	SET observacion=_observacion,
		fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idIngreso=_idIngreso; 
	
	SET @fechaModificacion=(SELECT now());
	UPDATE ingreso_det_accesorios
	SET observacion=_observacion,
		fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idIngreso=_idIngreso; 
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_factura`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_factura`(
	IN _idSalida INT,
	IN _numFactura NVARCHAR(20),
	IN _fecIniPago DATETIME,
	IN _fecFinPago DATETIME,
	IN _fecEmisiom DATETIME,
	IN _ruc NVARCHAR(11),
	IN _codigoLC NVARCHAR(80),
	IN _guiaSalida NVARCHAR(255),
	IN _totalSoles DOUBLE,
	IN _totalDolares DOUBLE,
	IN _costoSoles DOUBLE,
	IN _costoDolares DOUBLE,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100),
	OUT _idFactura INT
)
BEGIN
	SET @_idFactura=(SELECT IFNULL( MAX(idFactura) , 0 )+1 FROM factura);
	INSERT INTO factura (idFactura,idSalida,numFactura,fecIniPago,fecFinPago,fecEmisiom,ruc,codigoLC,guiaSalida,totalSoles,totalDolares,costoSoles,costoDolares,observacion,estado,usuario_ins) values
	(@_idFactura,_idSalida,_numFactura,_fecIniPago,_fecFinPago,_fecEmisiom,_ruc,_codigoLC,_guiaSalida,_totalSoles,_totalDolares,_costoSoles,_costoDolares,_observacion,_estado,_usuario_ins);
	COMMIT;
    SET _idFactura = @_idFactura;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_cuota`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_cuota`(
	IN _idFactura INT,
	IN _idSalida INT,
	IN _idLC INT,
	IN _numFactura NVARCHAR(20),
	IN _fecInicioPago DATETIME,
	IN _fecFinPago DATETIME,
	IN _fecEmisiom DATETIME,
	IN _ruc NVARCHAR(11),
	IN _codigoLC NVARCHAR(80),
	IN _guiaSalida NVARCHAR(255),
	IN _totalSoles DOUBLE,
	IN _totalDolares DOUBLE,
	IN _costoSoles DOUBLE,
	IN _costoDolares DOUBLE,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT
)
BEGIN
	INSERT INTO cuota (idFactura,idSalida,idLC,numFactura,fecInicioPago,fecFinPago,fecEmisiom,ruc,codigoLC,guiaSalida,totalSoles,totalDolares,costoSoles,costoDolares,observacion,estado) values
	(_idFactura,_idSalida,_idLC,_numFactura,_fecInicioPago,_fecFinPago,_fecEmisiom,_ruc,_codigoLC,_guiaSalida,_totalSoles,_totalDolares,_costoSoles,_costoDolares,_observacion,_estado);
	COMMIT;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_cuota`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_cuota`(
	IN _idSalida INT,
	IN _idLC INT
)
BEGIN
	DELETE FROM cuota where idSalida=_idSalida and idLC=_idLC; 
	COMMIT;
END
$$



DROP PROCEDURE IF EXISTS `update_salida_det_fechaFinalPlazo`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_salida_det_fechaFinalPlazo`(
	IN _idSalidaDet INT,
	IN _fecFinContrato DATETIME,
	IN _documentoRenovacion NVARCHAR(255),
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE salida_det 
	SET fecFinContrato=_fecFinContrato,
		fec_mod=@fechaModificacion,
		documentoRenovacion=_documentoRenovacion,
		usuario_mod=_usuario_mod
	WHERE idSalidaDet=_idSalidaDet; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_reparacion`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_reparacion`(
	IN _idLC INT,
	IN _codigoLC NVARCHAR(80),
	IN _fechaReparacion DATETIME,
	IN _estadoLCAct INT,
	IN _estadoLCAnt INT,
	IN _observacionActual NVARCHAR(1000),
	IN _observacionReparacion NVARCHAR(1000),
	IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	OUT _idReparacion INT
)
BEGIN
	SET @_idReparacion=(SELECT IFNULL( MAX(idReparacion) , 0 )+1 FROM reparacion);
	INSERT INTO reparacion (idReparacion,idLC,codigoLC,fechaReparacion,estadoLCAct,estadoLCAnt,observacionActual,observacionReparacion,estado,usuario_ins) values
	(@_idReparacion,_idLC,_codigoLC,_fechaReparacion,_estadoLCAct,_estadoLCAnt,_observacionActual,_observacionReparacion,_estado,_usuario_ins);
	COMMIT;
    SET _idReparacion = @_idReparacion;
END
$$
DELIMITER ;



DROP PROCEDURE IF EXISTS `update_reparacion`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_reparacion`(
	IN _idLC INT,
	IN _codigoLC NVARCHAR(80),
	IN _fechaReparacion DATETIME,
	IN _estadoLCAct INT,
	IN _estadoLCAnt INT,
	IN _observacionActual NVARCHAR(1000),
	IN _observacionReparacion NVARCHAR(1000),
	IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100), 
	IN _idReparacion INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE reparacion 
	SET idLC=_idLC,
	codigoLC=_codigoLC,
	fechaReparacion=_fechaReparacion,
	estadoLCAct=_estadoLCAct,
	estadoLCAnt=_estadoLCAnt,
	observacionActual=_observacionActual,
	observacionReparacion=_observacionReparacion,
	estado=_estado,
	fec_mod=@fechaModificacion,
	usuario_mod=_usuario_mod
	where idReparacion=_idReparacion;
END
$$
DELIMITER ;



DROP PROCEDURE IF EXISTS `anular_reparacion`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `anular_reparacion`(
    IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100),
    IN _idReparacion INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE reparacion
	SET fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idReparacion=_idReparacion; 
END
$$ 
DELIMITER ;



DROP PROCEDURE IF EXISTS `update_observacion`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_observacion`(
	IN _guiaLevantamiento NVARCHAR(80),
	IN _observacionLevantamiento NVARCHAR(1000),
	IN _fechaLevantamiento DATETIME,
	IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100), 
	IN _idObservacionDeudas INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE observacion_deudas 
	SET guiaLevantamiento=_guiaLevantamiento,
	observacionLevantamiento=_observacionLevantamiento,
	fechaLevantamiento=_fechaLevantamiento,
	estado=_estado,
	fec_mod=@fechaModificacion,
	usuario_mod=_usuario_mod
	where idObservacionDeudas=_idObservacionDeudas;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_auxiliar`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_auxiliar`(
	IN _cod_tabla NVARCHAR(255),
	IN _descripcion NVARCHAR(255),
	IN _activo TINYINT,
	OUT _idAuxiliar INT
)
BEGIN
	SET _idAuxiliar=(SELECT IFNULL( MAX(idAuxiliar) , 0 )+1 FROM auxiliar where cod_tabla=_cod_tabla);
	INSERT INTO auxiliar (idAuxiliar,cod_tabla,descripcion,activo) values
	(_idAuxiliar,_cod_tabla,_descripcion,_activo);
	COMMIT;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `update_auxiliar`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_auxiliar`(
	IN _cod_tabla NVARCHAR(255),
	IN _descripcion NVARCHAR(255),
	IN _activo TINYINT,
	IN _idAuxiliar INT
)
BEGIN
	UPDATE auxiliar 
	SET descripcion=_descripcion,
	activo=_activo
	where cod_tabla=_cod_tabla and idAuxiliar=_idAuxiliar;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `insert_marca`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_marca`(
	IN _idCategoria INT,
	IN _nombre NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	OUT _idMarca INT
)
BEGIN
	SET _idMarca=(SELECT IFNULL( MAX(idMarca) , 0 )+1 FROM marca);
	INSERT INTO marca (idMarca,idCategoria,nombre,estado,usuario_ins) values
	(_idMarca,_idCategoria,_nombre,_estado,_usuario_ins);
	COMMIT;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `update_marca`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_marca`(
	IN _idCategoria INT,
	IN _nombre NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100), 
	IN _idMarca INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE marca 
	SET nombre=_nombre,
	fec_mod=@fechaModificacion,
	usuario_mod=_usuario_mod,
	estado=_estado
	where idMarca=_idMarca ;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_modelo`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_modelo`(
	IN _idMarca INT,
	IN _nombre NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	OUT _idModelo INT
)
BEGIN
	SET _idModelo=(SELECT IFNULL( MAX(idModelo) , 0 )+1 FROM modelo);
	INSERT INTO modelo (idModelo,idMarca,nombre,estado,usuario_ins) values
	(_idModelo,_idMarca,_nombre,_estado,_usuario_ins);
	COMMIT;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `update_modelo`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_modelo`(
	IN _idMarca INT,
	IN _nombre NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100), 
	IN _idModelo INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE modelo 
	SET nombre=_nombre,
	fec_mod=@fechaModificacion,
	usuario_mod=_usuario_mod,
	estado=_estado
	where idModelo=_idModelo ;
END
$$
DELIMITER ;




DROP PROCEDURE IF EXISTS `insert_ingresos_salidas_internas`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ingresos_salidas_internas`(
	IN _idLC INT ,
	IN _codigoLC NVARCHAR(80) ,
	IN _estadoLCAnt TINYINT ,
	IN _estadoLCAct TINYINT ,
	IN _fechaIngresoSalida DATE ,
	IN _documentoIdentidad NVARCHAR(255),
	IN _nombrePersona NVARCHAR(1000),
	IN _documentoReferencial NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	IN _ubicacion NVARCHAR(1000), 
	IN _tipoIngresoSalida TINYINT,
	OUT _idIngresoSalida INT
)
BEGIN
	SET _idIngresoSalida=(SELECT IFNULL( MAX(idIngresoSalida) , 0 )+1 FROM ingresos_salidas_internas);
	INSERT INTO ingresos_salidas_internas (idIngresoSalida,idLC,codigoLC,estadoLCAnt,estadoLCAct,fechaIngresoSalida,documentoIdentidad,nombrePersona,documentoReferencial,tipoIngresoSalida,estado,usuario_ins) values
	(_idIngresoSalida,_idLC,_codigoLC,_estadoLCAnt,_estadoLCAct,_fechaIngresoSalida,_documentoIdentidad,_nombrePersona,_documentoReferencial,_tipoIngresoSalida,_estado,_usuario_ins);
	COMMIT;
	
	SET @fechaModificacion=(SELECT now());
	UPDATE laptop_cpu 
	SET 
	fec_mod=@fechaModificacion,
	usuario_mod=_usuario_ins,
	estado=_estadoLCAct,
	ubicacion=_ubicacion
	where idLC=_idLC ;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `update_salida_det_corte_alquiler`;
DELIMITER $$
CREATE DEFINER=`root`@`%` PROCEDURE `update_salida_det_corte_alquiler`(
		IN _idSalidaDet INT,
		IN _fecIniContrato DATETIME,
		IN _fecFinContrato DATETIME,
		IN _idSalidaTipo INT,
		IN _nombreSalidaTipo NVARCHAR(255),
		IN _documentoRenovacion NVARCHAR(255),
		IN _usuario_mod NVARCHAR(100),
		IN _corteAlquiler INT
	)
BEGIN
		SET @fechaModificacion=(SELECT now());
		UPDATE salida_det 
		SET fecIniContrato=_fecIniContrato,
			fecFinContrato=_fecFinContrato,
			fec_mod=@fechaModificacion,
			idSalidaTipo=_idSalidaTipo,
			nombreSalidaTipo=_nombreSalidaTipo,
			documentoSalidaTipo=_documentoRenovacion,
			usuario_mod=_usuario_mod,
			corteAlquiler=_corteAlquiler
		WHERE idSalidaDet=_idSalidaDet; 
END
$$
DELIMITER ;



DROP PROCEDURE IF EXISTS `update_salida_det_fechaFinalPlazoEvento`;
DELIMITER $$
CREATE PROCEDURE update_salida_det_fechaFinalPlazoEvento(
	)
BEGIN
		SET @fechaModificacion=(SELECT now());
		UPDATE salida_det 
		SET fecFinContrato=DATE(DATE_ADD(fecFinContrato, INTERVAL 1 MONTH))
		WHERE corteAlquiler=0 and fueDevuelto=0 and estado=4 and cast(fecFinContrato as date)<cast(@fechaModificacion as date); 
END
$$
DELIMITER ;


CREATE EVENT update_salida_det_fechaFinalPlazoEvento
ON SCHEDULE EVERY 1 DAY STARTS '2020-12-02 00:01:00'
DO call update_salida_det_fechaFinalPlazoEvento();


--==============================================================================================

DROP PROCEDURE IF EXISTS `insert_ingreso_det_impresora`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ingreso_det_impresora`(
	IN _idIngreso INT,
	IN _idMarca INT,
	IN _idModelo INT,
	IN _idCaracteristica INT,
	IN _caracteristica NVARCHAR(255),
	IN _partNumber NVARCHAR(255),
	IN _garantia TINYINT,
	IN _cantidad INT,
	IN _subTotal DOUBLE,
	IN _observacion NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(255), 
	IN _multifuncional TINYINT,
	OUT _idIngresoDet INT
)
BEGIN
	SET _idIngresoDet=(SELECT IFNULL( MAX(idIngresoDet) , 0 )+1 FROM ingreso_det_impresora);
	INSERT INTO ingreso_det_impresora (idIngresoDet,idIngreso,idMarca,idModelo,idCaracteristica,caracteristica,multifuncional,partNumber,garantia,cantidad,subTotal, observacion,estado,usuario_ins) values
	(_idIngresoDet,_idIngreso,_idMarca,_idModelo,_idCaracteristica,_caracteristica,_multifuncional,_partNumber,_garantia,_cantidad,_subTotal,_observacion,_estado,_usuario_ins);
	COMMIT;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_ingreso_det_monitor`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ingreso_det_monitor`(
	IN _idIngreso INT,
	IN _idMarca INT,
	IN _idModelo INT,
	IN _idTipo INT ,
	IN _tipo NVARCHAR(255) ,
	IN _pantalla DOUBLE,
	IN _partNumber NVARCHAR(255),
	IN _garantia TINYINT,
	IN _cantidad INT,
	IN _subTotal DOUBLE,
	IN _observacion NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(255), 
	IN _hdmi TINYINT,
	IN _vga TINYINT,
	IN _displayPort TINYINT,
	OUT _idIngresoDet INT
)
BEGIN
	SET _idIngresoDet=(SELECT IFNULL( MAX(idIngresoDet) , 0 )+1 FROM ingreso_det_monitor);
	INSERT INTO ingreso_det_monitor (idIngresoDet,idIngreso,idMarca,idModelo,idTipo,tipo,hdmi,vga,displayPort,partNumber,pantalla,garantia,cantidad,subTotal, observacion,estado,usuario_ins) values
	(_idIngresoDet,_idIngreso,_idMarca,_idModelo,_idTipo,_tipo,_hdmi,_vga,_displayPort,_partNumber,_pantalla,_garantia,_cantidad,_subTotal,_observacion,_estado,_usuario_ins);
	COMMIT;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_ingreso_det_tablet`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ingreso_det_tablet`(
	IN _idIngreso INT,
	IN _idMarca INT,
	IN _idModelo INT,
	IN _idProcesador INT ,
	IN _idSO INT ,
	IN _idRam INT ,
	IN _idRom INT ,
	IN _pantalla DOUBLE,
	IN _partNumber NVARCHAR(255),
	IN _garantia TINYINT,
	IN _cantidad INT,
	IN _subTotal DOUBLE,
	IN _observacion NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(255), 
	OUT _idIngresoDet INT
)
BEGIN
	SET _idIngresoDet=(SELECT IFNULL( MAX(idIngresoDet) , 0 )+1 FROM ingreso_det_tablet);
	INSERT INTO ingreso_det_tablet (idIngresoDet,idIngreso,idMarca,idModelo,idProcesador,idSO,idRam,idRom,partNumber,pantalla,garantia,cantidad,subTotal, observacion,estado,usuario_ins) values
	(_idIngresoDet,_idIngreso,_idMarca,_idModelo,_idProcesador,_idSO,_idRam,_idRom,_partNumber,_pantalla,_garantia,_cantidad,_subTotal,_observacion,_estado,_usuario_ins);
	COMMIT;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_ingreso_det_proyectorEcram`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ingreso_det_proyectorEcram`(
	IN _idIngreso INT,
	IN _idMarca INT,
	IN _idModelo INT,
	IN _idTipoEquipo INT,
	IN _idCaracteristica INT,
	IN _caracteristica NVARCHAR(255),
	IN _tamanoEcram DOUBLE,
	IN _partNumber NVARCHAR(255),
	IN _garantia TINYINT,
	IN _cantidad INT,
	IN _subTotal DOUBLE,
	IN _observacion NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	IN _idResolucion INT ,
	IN _idLuminen INT ,
	OUT _idIngresoDet INT
)
BEGIN
	SET _idIngresoDet=(SELECT IFNULL( MAX(idIngresoDet) , 0 )+1 FROM ingreso_det_proyectorEcram);
	INSERT INTO ingreso_det_proyectorEcram (idIngresoDet,idIngreso,idMarca,idModelo,idTipoEquipo,idCaracteristica,caracteristica,idResolucion,idLuminen,partNumber,tamanoEcram,garantia,cantidad,subTotal, observacion,estado,usuario_ins) values
	(_idIngresoDet,_idIngreso,_idMarca,_idModelo,_idTipoEquipo,_idCaracteristica,_caracteristica,_idResolucion,_idLuminen,_partNumber,_tamanoEcram,_garantia,_cantidad,_subTotal,_observacion,_estado,_usuario_ins);
	COMMIT;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_tablet`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_tablet`(
	IN _idIngreso INT,
	IN _idIngresoDet INT,
	IN _idModelo INT,
	IN _idProcesador INT ,
	IN _idSO INT ,
	IN _idRam INT ,
	IN _idRom INT ,
	IN _pantalla DOUBLE,
	IN _serieFabrica NVARCHAR(255),
	IN _partNumber NVARCHAR(255),
	IN _garantia TINYINT,
	IN _fecInicioSeguro DATETIME,
	IN _fecFinSeguro DATETIME,
	IN _compraSubarriendo TINYINT, 
	IN _ubicacion NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(255), 
	IN _codigo NVARCHAR(255), 
	OUT _idTablet INT
)
BEGIN
	SET _idTablet=(SELECT IFNULL( MAX( idTablet ) , 0 )+1 FROM tablet);
	INSERT INTO tablet (idTablet,codigo,idIngreso,idIngresoDet,idModelo,idProcesador,idSO,idRam,idRom,pantalla,serieFabrica,partNumber,garantia,fecInicioSeguro,fecFinSeguro,compraSubarriendo,ubicacion,observacion,usuario_ins,estado) values
	(_idTablet,_codigo,_idIngreso,_idIngresoDet,_idModelo,_idProcesador,_idSO,_idRam,_idRom,_pantalla,_serieFabrica,_partNumber,_garantia,_fecInicioSeguro,_fecFinSeguro,_compraSubarriendo,_ubicacion,_observacion,_usuario_ins,2);
	COMMIT;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_impresora`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_impresora`(
	IN _idIngreso INT,
	IN _idIngresoDet INT,
	IN _idModelo INT,
	IN _idCaracteristica INT ,
	IN _caracteristica NVARCHAR(255) ,
	IN _serieFabrica NVARCHAR(255),
	IN _partNumber NVARCHAR(255),
	IN _garantia TINYINT,
	IN _fecInicioSeguro DATETIME,
	IN _fecFinSeguro DATETIME,
	IN _compraSubarriendo TINYINT, 
	IN _ubicacion NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(255), 
	IN _codigo NVARCHAR(255), 
	IN _multifuncional TINYINT,
	OUT _idImpresora INT
)
BEGIN
	SET _idImpresora=(SELECT IFNULL( MAX( idImpresora ) , 0 )+1 FROM impresora);
	INSERT INTO impresora (idImpresora,codigo,idIngreso,idIngresoDet,idModelo,idCaracteristica,caracteristica,multifuncional,serieFabrica,partNumber,garantia,fecInicioSeguro,fecFinSeguro,compraSubarriendo,ubicacion,observacion,usuario_ins,estado) values
	(_idImpresora,_codigo,_idIngreso,_idIngresoDet,_idModelo,_idCaracteristica,_caracteristica,_multifuncional,_serieFabrica,_partNumber,_garantia,_fecInicioSeguro,_fecFinSeguro,_compraSubarriendo,_ubicacion,_observacion,_usuario_ins,2);
	COMMIT;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_monitor`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_monitor`(
	IN _idIngreso INT,
	IN _idIngresoDet INT,
	IN _idModelo INT,
	IN _idTipo INT ,
	IN _tipo NVARCHAR(255) ,
	IN _pantalla DOUBLE,
	IN _serieFabrica NVARCHAR(255),
	IN _partNumber NVARCHAR(255),
	IN _garantia TINYINT,
	IN _fecInicioSeguro DATETIME,
	IN _fecFinSeguro DATETIME,
	IN _compraSubarriendo TINYINT, 
	IN _ubicacion NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(255), 
	IN _codigo NVARCHAR(255), 
	IN _hdmi TINYINT,
	IN _vga TINYINT,
	IN _displayPort TINYINT,
	OUT _idMonitor INT
)
BEGIN
	SET _idMonitor=(SELECT IFNULL( MAX( idMonitor ) , 0 )+1 FROM monitor);
	INSERT INTO monitor (idMonitor,codigo,idIngreso,idIngresoDet,idModelo,idTipo,tipo,hdmi,vga,displayPort,pantalla,serieFabrica,partNumber,garantia,fecInicioSeguro,fecFinSeguro,compraSubarriendo,ubicacion,observacion,usuario_ins,estado) values
	(_idMonitor,_codigo,_idIngreso,_idIngresoDet,_idModelo,_idTipo,_tipo,_hdmi,_vga,_displayPort,_pantalla,_serieFabrica,_partNumber,_garantia,_fecInicioSeguro,_fecFinSeguro,_compraSubarriendo,_ubicacion,_observacion,_usuario_ins,2);
	COMMIT;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_proyectorEcram`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_proyectorEcram`(
	IN _idIngreso INT,
	IN _idIngresoDet INT,
	IN _idModelo INT,
	IN _idTipoEquipo INT,
	IN _idCaracteristica INT ,
	IN _caracteristica NVARCHAR(255) ,
	IN _tamanoEcram DOUBLE,
	IN _serieFabrica NVARCHAR(255),
	IN _partNumber NVARCHAR(255),
	IN _garantia TINYINT,
	IN _fecInicioSeguro DATETIME,
	IN _fecFinSeguro DATETIME,
	IN _compraSubarriendo TINYINT, 
	IN _ubicacion NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(255), 
	IN _codigo NVARCHAR(255), 
	IN _idResolucion INT ,
	IN _idLuminen INT ,
	OUT _idProyectorEcram INT
)
BEGIN
	SET _idProyectorEcram=(SELECT IFNULL( MAX( idProyectorEcram ) , 0 )+1 FROM proyectorEcram);
	INSERT INTO proyectorEcram (idProyectorEcram,codigo,idIngreso,idIngresoDet,idModelo,idTipoEquipo,idCaracteristica,caracteristica,idResolucion,idLuminen,tamanoEcram,serieFabrica,partNumber,garantia,fecInicioSeguro,fecFinSeguro,compraSubarriendo,ubicacion,observacion,usuario_ins,estado) values
	(_idProyectorEcram,_codigo,_idIngreso,_idIngresoDet,_idModelo,_idTipoEquipo,_idCaracteristica,_caracteristica,_idResolucion,_idLuminen,_tamanoEcram,_serieFabrica,_partNumber,_garantia,_fecInicioSeguro,_fecFinSeguro,_compraSubarriendo,_ubicacion,_observacion,_usuario_ins,2);
	COMMIT;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_tablet_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_tablet_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM tablet where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_det_tablet_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_det_tablet_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM ingreso_det_tablet where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_impresora_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_impresora_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM impresora where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_det_impresora_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_det_impresora_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM ingreso_det_impresora where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_monitor_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_monitor_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM monitor where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_det_monitor_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_det_monitor_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM ingreso_det_monitor where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_proyectorEcram_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_proyectorEcram_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM proyectorEcram where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `delete_det_proyectorEcram_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_det_proyectorEcram_ingreso`(
	IN _idIngreso INT
)
BEGIN
	DELETE FROM ingreso_det_proyectorEcram where idIngreso=_idIngreso; 
END
$$ 
DELIMITER ;


DROP PROCEDURE IF EXISTS `anular_ingreso`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `anular_ingreso`(
	IN _observacion NVARCHAR(100),
    IN _estado TINYINT,
	IN _usuario_mod NVARCHAR(100),
    IN _idIngreso INT
)
BEGIN
	SET @fechaModificacion=(SELECT now());
	UPDATE ingreso
	SET observacion=_observacion,
		fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idIngreso=_idIngreso; 
	
	SET @fechaModificacion=(SELECT now());
	UPDATE ingreso_det
	SET observacion=_observacion,
		fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idIngreso=_idIngreso; 
	
	SET @fechaModificacion=(SELECT now());
	UPDATE ingreso_det_impresora
	SET observacion=_observacion,
		fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idIngreso=_idIngreso; 
	
	SET @fechaModificacion=(SELECT now());
	UPDATE ingreso_det_monitor
	SET observacion=_observacion,
		fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idIngreso=_idIngreso; 
	
	SET @fechaModificacion=(SELECT now());
	UPDATE ingreso_det_tablet
	SET observacion=_observacion,
		fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idIngreso=_idIngreso; 
	
	SET @fechaModificacion=(SELECT now());
	UPDATE ingreso_det_proyectorEcram
	SET observacion=_observacion,
		fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idIngreso=_idIngreso; 
	
	SET @fechaModificacion=(SELECT now());
	UPDATE ingreso_det_accesorios
	SET observacion=_observacion,
		fec_mod=@fechaModificacion,
		estado=_estado,
		usuario_mod=_usuario_mod
	WHERE idIngreso=_idIngreso; 
END
$$
DELIMITER ;



DROP PROCEDURE IF EXISTS `obtener_codigo_correlativo_impresora`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `obtener_codigo_correlativo_impresora`(
	IN _idProveedor int,
	IN _monthIngreso NVARCHAR(80),
	IN _yearIngreso NVARCHAR(80),
	OUT _proximoCodigo NVARCHAR(80),
	OUT _prefijo NVARCHAR(80)
)
BEGIN

		
	SET _proximoCodigo=(
	SELECT count(*)
	from impresora
	WHERE  
	length(codigo)=15
	and SUBSTRING(codigo, 8, 2) =  _yearIngreso
	and SUBSTRING(codigo, 10, 2) = _monthIngreso
	and SUBSTRING(codigo, 12, 1)  =  (select abreviacion
									from proveedor
									where idProveedor=_idProveedor
									)				
	);
		
	SET @_abreviacion=(select abreviacion from proveedor where idProveedor=_idProveedor);

	#SET DE PREFIJO SEGUN MARCA


	SET @_prefijo = ( CONCAT("PCR-IMP",_yearIngreso,_monthIngreso,@_abreviacion));
	SET _prefijo = @_prefijo;										

	COMMIT;
END
$$
DELIMITER ;



DROP PROCEDURE IF EXISTS `obtener_codigo_correlativo_monitor`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `obtener_codigo_correlativo_monitor`(
	IN _idProveedor int,
	IN _monthIngreso NVARCHAR(80),
	IN _yearIngreso NVARCHAR(80),
	OUT _proximoCodigo NVARCHAR(80),
	OUT _prefijo NVARCHAR(80)
)
BEGIN

	SET _proximoCodigo=(
	SELECT count(*)
	from monitor
	WHERE  
	length(codigo)=15
	and SUBSTRING(codigo, 8, 2) =  _yearIngreso
	and SUBSTRING(codigo, 10, 2) = _monthIngreso
	and SUBSTRING(codigo, 12, 1)  =  (select abreviacion
									From proveedor
									where idProveedor=_idProveedor
									)				
	);
		
	SET @_abreviacion=(select abreviacion from proveedor where idProveedor=_idProveedor);

	#SET DE PREFIJO SEGUN MARCA

	SET @_prefijo = ( CONCAT("PCR-MTR",_yearIngreso,_monthIngreso,@_abreviacion));
	SET _prefijo = @_prefijo;										

	COMMIT;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `obtener_codigo_correlativo_tablet`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `obtener_codigo_correlativo_tablet`(
	IN _idProveedor int,
	IN _monthIngreso NVARCHAR(80),
	IN _yearIngreso NVARCHAR(80),
	OUT _proximoCodigo NVARCHAR(80),
	OUT _prefijo NVARCHAR(80)
)
BEGIN

	SET _proximoCodigo=(
	SELECT count(*)
	from tablet
	WHERE  
	length(codigo)=15
	and SUBSTRING(codigo, 8, 2) =  _yearIngreso
	and SUBSTRING(codigo, 10, 2) = _monthIngreso
	and SUBSTRING(codigo, 12, 1)  =  (select abreviacion	from proveedor
									where idProveedor=_idProveedor
									)				
	);
		
	SET @_abreviacion=(select abreviacion from proveedor where idProveedor=_idProveedor);

	#SET DE PREFIJO SEGUN MARCA

	SET @_prefijo = ( CONCAT("PCR-TAB",_yearIngreso,_monthIngreso,@_abreviacion));
	SET _prefijo = @_prefijo;										

	COMMIT;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `obtener_codigo_correlativo_proy_ecram`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `obtener_codigo_correlativo_proy_ecram`(
	IN _marcaProyEcram NVARCHAR(80),
	IN _idProveedor int,
	IN _monthIngreso NVARCHAR(80),
	IN _yearIngreso NVARCHAR(80),
	OUT _proximoCodigo NVARCHAR(80),
	OUT _prefijo NVARCHAR(80)
)
BEGIN
	IF _marcaProyEcram="PCR-PROY" THEN
		SET _proximoCodigo=(
		SELECT count(*)
		from proyectorecram
		WHERE  SUBSTRING(codigo, 1, 8) = 'PCR-PROY'
		and length(codigo)=16
		and SUBSTRING(codigo, 9, 2) =  _yearIngreso
		and SUBSTRING(codigo, 11, 2) = _monthIngreso
		and SUBSTRING(codigo, 13, 1)  =  (select abreviacion
										from proveedor
										where idProveedor=_idProveedor
										)				
		);
	ELSE
		SET _proximoCodigo=(
		SELECT count(*)
		from proyectorecram
		WHERE  SUBSTRING(codigo, 1, 7) = 'PCR-TRI'
		and length(codigo)=15
		and SUBSTRING(codigo, 8, 2) =  _yearIngreso
		and SUBSTRING(codigo, 10, 2) = _monthIngreso
		and SUBSTRING(codigo, 12, 1)  =  (select abreviacion
										from proveedor
										where idProveedor=_idProveedor
										)				
		);

	END IF;



	SET @_abreviacion=(select abreviacion from proveedor where idProveedor=_idProveedor);

	#SET DE PREFIJO SEGUN MARCA

	IF _marcaProyEcram="PCR-PROY" then
		SET @_prefijo = ( CONCAT("PCR-PROY",_yearIngreso,_monthIngreso,@_abreviacion));
	else
		SET @_prefijo = ( CONCAT("PCR-TRI",_yearIngreso,_monthIngreso,@_abreviacion));
	END IF;

	SET _prefijo = @_prefijo;										
    #SET _proximoCodigo = @_proximoCodigo;
	COMMIT;
END
$$
DELIMITER ;



ALTER TABLE `ingreso_det` 
ADD COLUMN `idTipoEquipoLC` int(0) ZEROFILL NULL AFTER `idIngreso`;
ALTER TABLE `ingreso_det` 
ADD COLUMN `nombreTipoEquipoLC` varchar(255) NULL AFTER `idTipoEquipoLC`;

ALTER TABLE `laptop_cpu` 
ADD COLUMN `idTipoEquipoLC` int NULL AFTER `codigo`;
ALTER TABLE `laptop_cpu` 
ADD COLUMN `nombreTipoEquipoLC` varchar(255) NULL AFTER `idTipoEquipoLC`;



DROP PROCEDURE IF EXISTS `insert_ingreso_det`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ingreso_det`(
	IN _idIngreso INT,
	IN _idMarcaLC INT,
	IN _idModeloLC INT,
	IN _partNumber NVARCHAR(255),
	IN _pantalla DOUBLE,
	IN _garantia TINYINT,
	IN _cantidad INT,
	IN _subTotal DOUBLE,
	IN _idProcesador INT,
	IN _idVideo INT,
	IN _idDisco1 INT,
	IN _cantidadDisco1 INT,
	IN _idDisco2 INT,
	IN _cantidadDisco2 INT,
	IN _idMemoria1 INT,
	IN _cantidadMemoria1 INT,
	IN _idMemoria2 INT,
	IN _cantidadMemoria2 INT,
	IN _idMemoria3 INT,
	IN _cantidadMemoria3 INT,
	IN _idModeloWindows INT,
	IN _idModeloOffice INT,
	IN _idModeloAntivirus INT,
	IN _caracteristicas NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	IN _idTipoEquipoLC INT,
	IN _nombreTipoEquipoLC NVARCHAR(255), 
	OUT _idIngresoDet INT
)
BEGIN
	SET _idIngresoDet=(SELECT IFNULL( MAX(idIngresoDet) , 0 )+1 FROM ingreso_det);
	INSERT INTO ingreso_det (idIngresoDet,idIngreso,idTipoEquipoLC,nombreTipoEquipoLC,idMarcaLC,idModeloLC,partNumber,pantalla,garantia,cantidad,subTotal,idProcesador,idVideo,idDisco1,cantidadDisco1,idDisco2,cantidadDisco2,idMemoria1,cantidadMemoria1,idMemoria2,cantidadMemoria2,idMemoria3,cantidadMemoria3,idModeloWindows,idModeloOffice,idModeloAntivirus,caracteristicas,observacion,estado,usuario_ins) values
	(_idIngresoDet,_idIngreso,_idTipoEquipoLC,_nombreTipoEquipoLC,_idMarcaLC,_idModeloLC,_partNumber,_pantalla,_garantia,_cantidad,_subTotal,_idProcesador,_idVideo,_idDisco1,_cantidadDisco1,_idDisco2,_cantidadDisco2,_idMemoria1,_cantidadMemoria1,_idMemoria2,_cantidadMemoria2,_idMemoria3,_cantidadMemoria3,_idModeloWindows,_idModeloOffice,_idModeloAntivirus,_caracteristicas,_observacion,_estado,_usuario_ins);
	COMMIT;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `insert_laptop_cpu`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_laptop_cpu`(
	IN _idIngreso INT,
	IN _idIngresoDet INT,
	IN _idModelo INT,
	IN _descripcion NVARCHAR(250),
	IN _tamanoPantalla DOUBLE,
	IN _idProcesador INT,
	IN _idVideo INT,
	IN _partNumber NVARCHAR(80),
	IN _serieFabrica NVARCHAR(80),
	IN _garantia TINYINT,
	IN _fecInicioSeguro DATETIME,
	IN _fecFinSeguro DATETIME,
	IN _ubicacion NVARCHAR(80),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	IN _compraSubarriendo TINYINT,
	IN _codigo NVARCHAR(80),
	IN _idTipoEquipoLC INT,
	IN _nombreTipoEquipoLC NVARCHAR(255), 
	OUT _idLC INT
)
BEGIN
	#SET @codigo=(SELECT CONCAT("PCR-LAP",IFNULL( MAX( idLC ) , 0 )+1) from laptop_cpu);
	SET _idLC=(SELECT IFNULL( MAX( idLC ) , 0 )+1 FROM laptop_cpu);
	INSERT INTO laptop_cpu (idLC,codigo,idIngreso,idIngresoDet,idTipoEquipoLC,nombreTipoEquipoLC,idModelo,descripcion,tamanoPantalla,idProcesador,idVideo,partNumber,serieFabrica,garantia,fecInicioSeguro,fecFinSeguro,ubicacion,observacion,estado,usuario_ins,compraSubarriendo) values
	(_idLC,_codigo,_idIngreso,_idIngresoDet,_idTipoEquipoLC,_nombreTipoEquipoLC,_idModelo,_descripcion,_tamanoPantalla,_idProcesador,_idVideo,_partNumber,_serieFabrica,_garantia,_fecInicioSeguro,_fecFinSeguro,_ubicacion,_observacion,2,_usuario_ins,_compraSubarriendo);
	COMMIT;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `obtener_codigo_correlativo`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `obtener_codigo_correlativo`(
	IN _marcaLap NVARCHAR(80), #PCR-LAP o PCR_MAC
	IN _idProveedor int,
	IN _monthIngreso NVARCHAR(80),
	IN _yearIngreso NVARCHAR(80),
	OUT _proximoCodigo NVARCHAR(80),
	OUT _prefijo NVARCHAR(80)
)
BEGIN

		
		SET _proximoCodigo=(
															SELECT count(*)
															from laptop_cpu 
															WHERE  SUBSTRING(codigo, 1, 7) = _marcaLap #AQUI FILTRAR
															and length(codigo)=15
															and SUBSTRING(codigo, 8, 2) =  _yearIngreso
															and SUBSTRING(codigo, 10, 2) = _monthIngreso
															and SUBSTRING(codigo, 12, 1)  =  (select abreviacion	from proveedor
																							where idProveedor=_idProveedor
																							)				
												);
		
SET @_abreviacion=(select abreviacion	from proveedor where idProveedor=_idProveedor);

#SET DE PREFIJO SEGUN MARCA

if _marcaLap="PCR-LAP" then
	SET @_prefijo = ( CONCAT("PCR-LAP",_yearIngreso,_monthIngreso,@_abreviacion));
else
	SET @_prefijo = ( CONCAT("PCR-MAC",_yearIngreso,_monthIngreso,@_abreviacion));
end if;

		SET _prefijo = @_prefijo;										
    #SET _proximoCodigo = @_proximoCodigo;
		COMMIT;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `obtener_codigo_correlativo_cpu`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `obtener_codigo_correlativo_cpu`(	
	IN _marcaLap NVARCHAR(80), #PCR-LAP o PCR_MAC
	IN _idProveedor int,
	IN _monthIngreso NVARCHAR(80),
	IN _yearIngreso NVARCHAR(80),
	OUT _proximoCodigo NVARCHAR(80),
	OUT _prefijo NVARCHAR(80)
)
BEGIN

		
		SET _proximoCodigo=(
															SELECT count(*)
															from laptop_cpu 
															WHERE SUBSTRING(codigo, 1, 7) = _marcaLap
															and length(codigo)=15
															and SUBSTRING(codigo, 8, 2) =  _yearIngreso
															and SUBSTRING(codigo, 10, 2) = _monthIngreso
															and SUBSTRING(codigo, 12, 1)  =  (select abreviacion	from proveedor
																							where idProveedor=_idProveedor
																							)				
												);
		
SET @_abreviacion=(select abreviacion	from proveedor where idProveedor=_idProveedor);

#SET DE PREFIJO SEGUN MARCA

if _marcaLap="PCR-CPU" then
	SET @_prefijo = ( CONCAT("PCR-CPU",_yearIngreso,_monthIngreso,@_abreviacion));
else
	SET @_prefijo = ( CONCAT("PCR-MAC",_yearIngreso,_monthIngreso,@_abreviacion));
end if;

		SET _prefijo = @_prefijo;										
    #SET _proximoCodigo = @_proximoCodigo;
		COMMIT;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `obtener_codigo_correlativo_impresora`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `obtener_codigo_correlativo_impresora`(
	IN _idProveedor int,
	IN _monthIngreso NVARCHAR(80),
	IN _yearIngreso NVARCHAR(80),
	OUT _proximoCodigo NVARCHAR(80),
	OUT _prefijo NVARCHAR(80)
)
BEGIN

		
	SET _proximoCodigo=(
	SELECT count(*)
	from impresora
	WHERE  
	length(codigo)=15
	and SUBSTRING(codigo, 8, 2) =  _yearIngreso
	and SUBSTRING(codigo, 10, 2) = _monthIngreso
	and SUBSTRING(codigo, 12, 1)  =  (select abreviacion
									from proveedor
									where idProveedor=_idProveedor
									)				
	);
		
	SET @_abreviacion=(select abreviacion from proveedor where idProveedor=_idProveedor);

	#SET DE PREFIJO SEGUN MARCA


	SET @_prefijo = ( CONCAT("PCR-IMP",_yearIngreso,_monthIngreso,@_abreviacion));
	SET _prefijo = @_prefijo;										

	COMMIT;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `obtener_codigo_correlativo_monitor`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `obtener_codigo_correlativo_monitor`(
	IN _idProveedor int,
	IN _monthIngreso NVARCHAR(80),
	IN _yearIngreso NVARCHAR(80),
	OUT _proximoCodigo NVARCHAR(80),
	OUT _prefijo NVARCHAR(80)
)
BEGIN

	SET _proximoCodigo=(
	SELECT count(*)
	from monitor
	WHERE  
	length(codigo)=15
	and SUBSTRING(codigo, 8, 2) =  _yearIngreso
	and SUBSTRING(codigo, 10, 2) = _monthIngreso
	and SUBSTRING(codigo, 12, 1)  =  (select abreviacion
									From proveedor
									where idProveedor=_idProveedor
									)				
	);
		
	SET @_abreviacion=(select abreviacion from proveedor where idProveedor=_idProveedor);

	#SET DE PREFIJO SEGUN MARCA

	SET @_prefijo = ( CONCAT("PCR-MTR",_yearIngreso,_monthIngreso,@_abreviacion));
	SET _prefijo = @_prefijo;										

	COMMIT;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `obtener_codigo_correlativo_proy_ecram`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `obtener_codigo_correlativo_proy_ecram`(
	IN _marcaProyEcram NVARCHAR(80),
	IN _idProveedor int,
	IN _monthIngreso NVARCHAR(80),
	IN _yearIngreso NVARCHAR(80),
	OUT _proximoCodigo NVARCHAR(80),
	OUT _prefijo NVARCHAR(80)
)
BEGIN
	IF _marcaProyEcram="PCR-PROY" THEN
		SET _proximoCodigo=(
		SELECT count(*)
		from proyectorecram
		WHERE  SUBSTRING(codigo, 1, 8) = 'PCR-PROY'
		and length(codigo)=16
		and SUBSTRING(codigo, 9, 2) =  _yearIngreso
		and SUBSTRING(codigo, 11, 2) = _monthIngreso
		and SUBSTRING(codigo, 13, 1)  =  (select abreviacion
										from proveedor
										where idProveedor=_idProveedor
										)				
		);
	ELSE
		SET _proximoCodigo=(
		SELECT count(*)
		from proyectorecram
		WHERE  SUBSTRING(codigo, 1, 7) = 'PCR-TRI'
		and length(codigo)=15
		and SUBSTRING(codigo, 8, 2) =  _yearIngreso
		and SUBSTRING(codigo, 10, 2) = _monthIngreso
		and SUBSTRING(codigo, 12, 1)  =  (select abreviacion
										from proveedor
										where idProveedor=_idProveedor
										)				
		);

	END IF;



	SET @_abreviacion=(select abreviacion from proveedor where idProveedor=_idProveedor);

	#SET DE PREFIJO SEGUN MARCA

	IF _marcaProyEcram="PCR-PROY" then
		SET @_prefijo = ( CONCAT("PCR-PROY",_yearIngreso,_monthIngreso,@_abreviacion));
	else
		SET @_prefijo = ( CONCAT("PCR-TRI",_yearIngreso,_monthIngreso,@_abreviacion));
	END IF;

	SET _prefijo = @_prefijo;										
    #SET _proximoCodigo = @_proximoCodigo;
	COMMIT;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `obtener_codigo_correlativo_tablet`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `obtener_codigo_correlativo_tablet`(
	IN _idProveedor int,
	IN _monthIngreso NVARCHAR(80),
	IN _yearIngreso NVARCHAR(80),
	OUT _proximoCodigo NVARCHAR(80),
	OUT _prefijo NVARCHAR(80)
)
BEGIN

	SET _proximoCodigo=(
	SELECT count(*)
	from tablet
	WHERE  
	length(codigo)=15
	and SUBSTRING(codigo, 8, 2) =  _yearIngreso
	and SUBSTRING(codigo, 10, 2) = _monthIngreso
	and SUBSTRING(codigo, 12, 1)  =  (select abreviacion	from proveedor
									where idProveedor=_idProveedor
									)				
	);
		
	SET @_abreviacion=(select abreviacion from proveedor where idProveedor=_idProveedor);

	#SET DE PREFIJO SEGUN MARCA

	SET @_prefijo = ( CONCAT("PCR-TAB",_yearIngreso,_monthIngreso,@_abreviacion));
	SET _prefijo = @_prefijo;										

	COMMIT;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `verificarArrendamiento`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `verificarArrendamiento`(
	IN _codigoLapArrendamiento nvarchar(255),
	OUT _cantidad int,
	OUT _idLC int,
	OUT _idIngreso int
)
BEGIN
	set _idLC=0; #EN CASO NO EXISTA SE PONER COMO 0
	set _idIngreso=0;
	set _cantidad=(select count(*) from laptop_cpu where codigo=_codigoLapArrendamiento and compraSubarriendo=2);

	if _cantidad>0 then
			set _idLC=(select idLC from laptop_cpu where codigo=_codigoLapArrendamiento and compraSubarriendo=2);
			set _idIngreso=(select idIngreso from laptop_cpu where codigo=_codigoLapArrendamiento and compraSubarriendo=2);
			delete from memoria_lc where idLC=_idLC;
			delete from disco_lc where idLC=_idLC;
			UPDATE laptop_cpu set estado=2 where idLC=_idLC;
	end if;
		
	
	commit;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `verificarArrendamiento_impresora`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `verificarArrendamiento_impresora`(
	IN _codigoLapArrendamiento nvarchar(255),
	OUT _cantidad int,
	OUT _idImpresora int,
	OUT _idIngreso int
)
BEGIN
	set _idImpresora=0; #EN CASO NO EXISTA SE PONER COMO 0
	set _idIngreso=0;
	set _cantidad=(select count(*) from impresora where codigo=_codigoLapArrendamiento and compraSubarriendo=2);

	if _cantidad>0 then
			set _idImpresora=(select idImpresora from impresora where codigo=_codigoLapArrendamiento and compraSubarriendo=2);
			set _idIngreso=(select idIngreso from impresora where codigo=_codigoLapArrendamiento and compraSubarriendo=2);
			UPDATE impresora set estado=2 where idImpresora=_idImpresora;
	end if;
		
	
	commit;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `verificarArrendamiento_monitor`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `verificarArrendamiento_monitor`(
	IN _codigoLapArrendamiento nvarchar(255),
	OUT _cantidad int,
	OUT _idMonitor int,
	OUT _idIngreso int
)
BEGIN
	set _idMonitor=0; #EN CASO NO EXISTA SE PONER COMO 0
	set _idIngreso=0;
	set _cantidad=(select count(*) from monitor where codigo=_codigoLapArrendamiento and compraSubarriendo=2);

	if _cantidad>0 then
			set _idMonitor=(select idMonitor from monitor where codigo=_codigoLapArrendamiento and compraSubarriendo=2);
			set _idIngreso=(select idIngreso from monitor where codigo=_codigoLapArrendamiento and compraSubarriendo=2);
			UPDATE monitor set estado=2 where idMonitor=_idMonitor;
	end if;
		
	
	commit;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `verificarArrendamiento_proyector_ecram`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `verificarArrendamiento_proyector_ecram`(
	IN _codigoLapArrendamiento nvarchar(255),
	OUT _cantidad int,
	OUT _idProyectorEcram int,
	OUT _idIngreso int
)
BEGIN
	set _idProyectorEcram=0; #EN CASO NO EXISTA SE PONER COMO 0
	set _idIngreso=0;
	set _cantidad=(select count(*) from proyectorecram where codigo=_codigoLapArrendamiento and compraSubarriendo=2);

	if _cantidad>0 then
			set _idProyectorEcram=(select idProyectorEcram from proyectorecram where codigo=_codigoLapArrendamiento and compraSubarriendo=2);
			set _idIngreso=(select idIngreso from proyectorecram where codigo=_codigoLapArrendamiento and compraSubarriendo=2);
			UPDATE proyectorecram set estado=2 where idProyectorEcram=_idProyectorEcram;
	end if;
		
	
	commit;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `verificarArrendamiento_tablet`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `verificarArrendamiento_tablet`(
	IN _codigoLapArrendamiento nvarchar(255),
	OUT _cantidad int,
	OUT _idTablet int,
	OUT _idIngreso int
)
BEGIN
	set _idTablet=0; #EN CASO NO EXISTA SE PONER COMO 0
	set _idIngreso=0;
	set _cantidad=(select count(*) from tablet where codigo=_codigoLapArrendamiento and compraSubarriendo=2);

	if _cantidad>0 then
			set _idTablet=(select idTablet from tablet where codigo=_codigoLapArrendamiento and compraSubarriendo=2);
			set _idIngreso=(select idIngreso from tablet where codigo=_codigoLapArrendamiento and compraSubarriendo=2);
			UPDATE tablet set estado=2 where idTablet=_idTablet;
	end if;
		
	
	commit;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `actualizarIngresoArrendamiento`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarIngresoArrendamiento`(
	IN _idIngresoAntiguo int,
	IN _idIngresoNuevo int,
	IN _idLC int
)
BEGIN
	
	update laptop_cpu set idIngreso=_idIngresoNuevo where idIngreso=_idIngresoAntiguo and idLC=_idLC;
	#set @idIngresoDet = (select idIngresoDet from laptop_cpu where idIngreso=_idIngresoAntiguo and idLC=_idLC);
	#update ingreso_det set idIngreso=_idIngresoNuevo where idIngresoDet=@idIngresoDet;
	
	commit;
END
$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `actualizarIngresoArrendamiento_impresora`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarIngresoArrendamiento_impresora`(
	IN _idIngresoAntiguo int,
	IN _idIngresoNuevo int,
	IN _idImpresora int
)
BEGIN
	
	update impresora set idIngreso=_idIngresoNuevo where idIngreso=_idIngresoAntiguo and idImpresora=_idImpresora;
	commit;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `actualizarIngresoArrendamiento_monitor`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarIngresoArrendamiento_monitor`(
	IN _idIngresoAntiguo int,
	IN _idIngresoNuevo int,
	IN _idMonitor int
)
BEGIN
	
	update monitor set idIngreso=_idIngresoNuevo where idIngreso=_idIngresoAntiguo and idMonitor=_idMonitor;
	commit;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `actualizarIngresoArrendamiento_proyector_ecram`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarIngresoArrendamiento_proyector_ecram`(
	IN _idIngresoAntiguo int,
	IN _idIngresoNuevo int,
	IN _idProyectorEcram int
)
BEGIN
	
	update proyectorecram set idIngreso=_idIngresoNuevo where idIngreso=_idIngresoAntiguo and idProyectorEcram=_idProyectorEcram;
	commit;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `actualizarIngresoArrendamiento_tablet`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizarIngresoArrendamiento_tablet`(
	IN _idIngresoAntiguo int,
	IN _idIngresoNuevo int,
	IN _idTablet int
)
BEGIN
	
	update tablet set idIngreso=_idIngresoNuevo where idIngreso=_idIngresoAntiguo and idTablet=_idTablet;
	commit;
END
$$
DELIMITER ;

DROP PROCEDURE IF EXISTS `insert_ingreso_det`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ingreso_det`(
	IN _idIngreso INT,
	IN _idMarcaLC INT,
	IN _idModeloLC INT,
	IN _partNumber NVARCHAR(255),
	IN _pantalla DOUBLE,
	IN _garantia TINYINT,
	IN _cantidad INT,
	IN _subTotal DOUBLE,
	IN _idProcesador INT,
	IN _idVideo INT,
	IN _idDisco1 INT,
	IN _cantidadDisco1 INT,
	IN _idDisco2 INT,
	IN _cantidadDisco2 INT,
	IN _idMemoria1 INT,
	IN _cantidadMemoria1 INT,
	IN _idMemoria2 INT,
	IN _cantidadMemoria2 INT,
	IN _idMemoria3 INT,
	IN _cantidadMemoria3 INT,
	IN _idModeloWindows INT,
	IN _idModeloOffice INT,
	IN _idModeloAntivirus INT,
	IN _caracteristicas NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	IN _idTipoEquipoLC INT,
	IN _nombreTipoEquipoLC NVARCHAR(255), 
	OUT _idIngresoDet INT
)
BEGIN
	SET _idIngresoDet=(SELECT IFNULL( MAX(idIngresoDet) , 0 )+1 FROM ingreso_det);
	INSERT INTO ingreso_det (idIngresoDet,idIngreso,idTipoEquipoLC,nombreTipoEquipoLC,idMarcaLC,idModeloLC,partNumber,pantalla,garantia,cantidad,subTotal,idProcesador,idVideo,idDisco1,cantidadDisco1,idDisco2,cantidadDisco2,idMemoria1,cantidadMemoria1,idMemoria2,cantidadMemoria2,idMemoria3,cantidadMemoria3,idModeloWindows,idModeloOffice,idModeloAntivirus,caracteristicas,observacion,estado,usuario_ins) values
	(_idIngresoDet,_idIngreso,_idTipoEquipoLC,_nombreTipoEquipoLC,_idMarcaLC,_idModeloLC,_partNumber,_pantalla,_garantia,_cantidad,_subTotal,_idProcesador,_idVideo,_idDisco1,_cantidadDisco1,_idDisco2,_cantidadDisco2,_idMemoria1,_cantidadMemoria1,_idMemoria2,_cantidadMemoria2,_idMemoria3,_cantidadMemoria3,_idModeloWindows,_idModeloOffice,_idModeloAntivirus,_caracteristicas,_observacion,_estado,_usuario_ins);
	COMMIT;
END
$$
DELIMITER ;



--===========================================================================	

DROP PROCEDURE IF EXISTS `anular_factura`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `anular_factura`(
	IN _idFactura int,
	IN _idSalida int,
	IN _idTipoEquipo int,
	IN _idEquipo int,
	IN _guiaSalida NVARCHAR(255),
	IN _nroNotaCredito NVARCHAR(255),
	IN _codigo NVARCHAR(255),
	IN _usuario_mod NVARCHAR(255), 
	OUT _idNotaCredito INT
)
BEGIN
	
	(select count(*) INTO @cantidad from cuota WHERE idFactura=_idFactura);
	
	SET @fechaModificacion=(SELECT now());
	UPDATE factura SET usuario_mod=_usuario_mod, estado=0, fec_mod=@fechaModificacion WHERE idFactura=_idFactura;
	
	
	if  @cantidad>0 then
	
		DELETE FROM cuota WHERE idFactura=_idFactura; 
		
		
		(SELECT d.observacion  INTO @codigoAntiguo
		FROM salida_det d INNER JOIN laptop_cpu lc ON d.idLC=lc.idLC 
		WHERE d.idSalida=_idSalida AND d.guiaSalida=_guiaSalida AND lc.codigo=_codigo);
								
		(SELECT d.guiaSalida INTO @guiaAntigua
		FROM salida_det d INNER JOIN laptop_cpu lc ON d.idLC=lc.idLC
		WHERE d.IdSalida=_idSalida AND lc.codigo=@codigoAntiguo);


		INSERT INTO cuota (idFactura,idSalida,idLC,numFactura,fecInicioPago,fecFinPago,fecEmisiom,ruc,codigoLC,guiaSalida,totalSoles,totalDolares,costoSoles,costoDolares,observacion,estado) 

		SELECT f.idFactura, f.idSalida,lc.idLC,f.numFactura,f.fecIniPago AS fecInicioPago, f.fecFinPago, f.fecEmisiom, f.ruc, f.codigoLC, f.guiaSalida, f.totalSoles, f.totalDolares, f.costoSoles, f.costoDolares, f.observacion, f.estado
		FROM factura f INNER JOIN laptop_cpu lc ON f.codigoLC=lc.codigo 
		WHERE f.codigoLC=_codigo AND f.guiaSalida=_guiaSalida and f.estado=1 

		UNION

		SELECT f.idFactura, f.idSalida,lc.idLC,f.numFactura,f.fecIniPago AS fecInicioPago, f.fecFinPago, f.fecEmisiom, f.ruc, f.codigoLC, f.guiaSalida, f.totalSoles, f.totalDolares, f.costoSoles, f.costoDolares, f.observacion, f.estado
		FROM factura f INNER JOIN laptop_cpu lc ON f.codigoLC=lc.codigo 
		WHERE f.codigoLC=@codigoAntiguo AND f.guiaSalida=@guiaAntigua AND f.estado=1 

		ORDER BY fecFinPago desc LIMIT 1;
			
	End if;
	
	
	SET _idNotaCredito=(SELECT IFNULL( MAX(idNotaCredito) , 0 )+1 FROM nota_credito);
	INSERT INTO nota_credito (idNotaCredito,idFactura,idSalida,idTipoEquipo,idEquipo,codigo,guiaSalida,nroNotaCredito,observacion,estado,usuario_ins) values
	(_idNotaCredito,_idFactura,_idSalida,_idTipoEquipo,_idEquipo,_codigo,_guiaSalida,_nroNotaCredito,"",1,_usuario_mod);
	
	
	COMMIT;
	
END
$$
DELIMITER ;

