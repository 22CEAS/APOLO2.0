DROP TRIGGER IF EXISTS `after_alquiler_detalle_delete`;
DELIMITER $$
CREATE TRIGGER after_alquiler_detalle_delete
AFTER DELETE
ON salida_det FOR EACH ROW
BEGIN

	UPDATE laptop_cpu SET estado = 2 , ubicacion='ALMACEN' where idLC=old.idLC;

END$$    

DELIMITER ;

DROP TRIGGER IF EXISTS `after_devolucion_detalle_delete`;
DELIMITER $$
CREATE TRIGGER after_devolucion_detalle_delete
AFTER DELETE
ON devolucion_det FOR EACH ROW
BEGIN

	UPDATE salida_det SET fueDevuelto = 0 where idSalidaDet=old.idSalidaDet;
	UPDATE laptop_cpu SET estado = 4 , ubicacion=old.idSucursal where idLC=old.idLC;
	DELETE FROM observacion_deudas where idDevolucion=old.idDevolucion;

END$$    

DELIMITER ;


--======================FACTURAS TRANSITO=======================================	


DROP TRIGGER IF EXISTS `after_alquiler_detalle_insert`;
DELIMITER $$
CREATE TRIGGER after_alquiler_detalle_insert
AFTER INSERT
ON salida_det FOR EACH ROW
BEGIN
	IF NEW.estado=4 THEN
	
		(SELECT CONCAT(s.rucDni,'-',lc.codigo),
				CAST(d.fecIniContrato as Date),
				CAST(d.fecFinContrato as DATE),
				d.idSalida, 
				d.idLC, 
				d.guiaSalida,
				lc.codigo INTO 
				@RucCodigo, @FecIniContrato, @FecFinContrato, @IdSalida, @IdLC, @GuiaSalida, @Codigo 
		FROM salida_det d INNER JOIN salida s on d.idSalida=s.idSalida
						  INNER JOIN laptop_cpu lc on d.idLC=lc.idLC
		WHERE d.idSalidaDet=NEW.idSalidaDet);
		
		(SELECT  Count(f.idFacturaTransito), 
				f.idFacturaTransito, 
				CAST(f.fecIniPago as Date), 
				CAST(f.fecFinPago as Date) INTO 
				@Cantidad,@IdFacturaTransito,@FecIniPago,@FecFinPago
		FROM factura_transito f
		WHERE CONCAT(f.ruc,'-',f.codigoEquipo)=@RucCodigo and f.estado=1
		ORDER BY codigoEquipo desc LIMIT 1);
		
		
		IF @FecIniPago IS NULL THEN
		
			UPDATE factura_transito 
			SET observacion = "Error en las fechas de las facturas, no pueden estar vacias"
			where idFacturaTransito=@IdFacturaTransito;
			
		ELSE
			IF (( to_days( @FecIniPago )-  to_days(@FecIniContrato))>3 OR ( to_days( @FecIniPago )-  to_days(@FecIniContrato))<-1) THEN
			
				UPDATE factura_transito 
				SET observacion = CONCAT("Esta factura tiene errores en la fecha. Hay un Salto de fechas de ", to_days( @FecIniPago )-  to_days(@FecIniContrato))
				where idFacturaTransito=@IdFacturaTransito;
				
			ELSE
				
				(SELECT IFNULL( MAX(idFactura) , 0 )+1 INTO @idFactura FROM factura);
				INSERT INTO factura (idFactura,idFacturaTransito,idSalida,numFactura,fecIniPago,fecFinPago,fecEmisiom,ruc,codigoLC,guiaSalida,totalSoles,totalDolares,costoSoles,costoDolares,tipoCambio,observacion,estado,usuario_ins) 				
				SELECT @idFactura AS idFactura,f.idFacturaTransito,@IdSalida AS idSalida, f.numFacturaTransito AS numFactura,f.fecIniPago, f.fecFinPago, f.fecEmisiom, f.ruc, f.codigoEquipo AS codigoLC, @GuiaSalida AS guiaSalida, f.totalSoles, f.totalDolares, f.costoSoles, f.costoDolares, f.tipoCambio, f.observacion, 1 AS estado, f.usuario_ins
				FROM factura_transito f 
				WHERE f.idFacturaTransito=@IdFacturaTransito and f.estado=1;
				
							
						
				INSERT INTO cuota (idFactura,idSalida,idLC,numFactura,fecInicioPago,fecFinPago,fecEmisiom,ruc,codigoLC,guiaSalida,totalSoles,totalDolares,costoSoles,costoDolares,tipoCambio,observacion,estado) 

				SELECT f.idFactura, f.idSalida,lc.idLC,f.numFactura,f.fecIniPago AS fecInicioPago, f.fecFinPago, f.fecEmisiom, f.ruc, f.codigoLC, f.guiaSalida, f.totalSoles, f.totalDolares, f.costoSoles, f.costoDolares, f.tipoCambio, f.observacion, f.estado
				FROM factura f INNER JOIN laptop_cpu lc ON f.codigoLC=lc.codigo 
				WHERE f.codigoLC=@Codigo AND f.guiaSalida=@GuiaSalida and f.estado=1 
				ORDER BY fecFinPago desc LIMIT 1;
				
				
				SET @fechaModificacion=(SELECT now());
				UPDATE factura_transito
				SET estado=14,
					idSalida=@IdSalida,
					fec_mod=@fechaModificacion
				WHERE idFacturaTransito=@IdFacturaTransito;
				
			END IF;
		END IF;
    END IF;

END
$$    

DELIMITER ;


--======================CORTE ALQUILER=======================================	


DROP TRIGGER IF EXISTS `after_corte_alquiler_insert`;
DELIMITER $$
CREATE TRIGGER after_corte_alquiler_insert
AFTER INSERT
ON corte_alquiler FOR EACH ROW
BEGIN
	IF NEW.estado=1 THEN

		SET @fechaModificacion=(SELECT now());
		UPDATE salida_det 
		SET fecFinContrato= NEW.fecFinContratoNew,
		fec_mod=@fechaModificacion,
		idSalidaTipo=4,
		nombreSalidaTipo='CORTE ALQUILER',
		documentoSalidaTipo= NEW.documentoReferencia,
		usuario_mod= NEW.usuario_ins,
		corteAlquiler= 1,
		motivoCorte = NEW.motivoCorte,
		fecRecojo = NEW.fecRecojo,
		direccionRecojo = NEW.direccionRecojo,
		personaContacto = NEW.personaContacto,
		telefono = NEW.telefono
		WHERE idSalidaDet=NEW.idSalidaDet;
			
    END IF;

END
$$    
DELIMITER ;


DROP TRIGGER IF EXISTS `after_corte_alquiler_cancel`;
DELIMITER $$
CREATE TRIGGER after_corte_alquiler_cancel
AFTER UPDATE
ON corte_alquiler FOR EACH ROW
BEGIN
    IF OLD.estado <> new.estado THEN
	
			SET @fechaModificacion=(SELECT now());
			UPDATE salida_det 
			SET fec_mod=@fechaModificacion,
			idSalidaTipo=null,
			nombreSalidaTipo=null,
			documentoSalidaTipo= null,
			usuario_mod= NEW.usuario_mod,
			corteAlquiler= 0,
			motivoCorte = null,
			fecRecojo = null,
			direccionRecojo = null,
			personaContacto = null,
			telefono = null
			WHERE idSalidaDet=NEW.idSalidaDet;
			
    END IF;
END
$$
DELIMITER ;