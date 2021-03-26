DROP VIEW IF EXISTS bd_leasein.vista_datos_laptop_por_cambiar;
DROP VIEW IF EXISTS bd_leasein.vista_disco_capacidad;
DROP VIEW IF EXISTS bd_leasein.vista_disco_modelo;
DROP VIEW IF EXISTS bd_leasein.vista_disco_tamano;
DROP VIEW IF EXISTS bd_leasein.vista_documento_tipo;
DROP VIEW IF EXISTS bd_leasein.vista_factura_cv;
DROP VIEW IF EXISTS bd_leasein.vista_facturas_por_vencer;
DROP VIEW IF EXISTS bd_leasein.vista_ingreso_tipo;
DROP VIEW IF EXISTS bd_leasein.vista_ingresos_detalles_accesorios_modificable;
DROP VIEW IF EXISTS bd_leasein.vista_ingresos_detalles_modificable;
DROP VIEW IF EXISTS bd_leasein.vista_inventario_discos;
DROP VIEW IF EXISTS bd_leasein.vista_inventario_laptops;
DROP VIEW IF EXISTS bd_leasein.vista_inventario_memoria;
DROP VIEW IF EXISTS bd_leasein.vista_kam_activos;
DROP VIEW IF EXISTS bd_leasein.vista_laptops_almacen_lista;
DROP VIEW IF EXISTS bd_leasein.vista_laptops_almacen_lista_sin_filtro;
DROP VIEW IF EXISTS bd_leasein.vista_laptops_danados;
DROP VIEW IF EXISTS bd_leasein.vista_laptops_detalle_alquiler_cliente_estado_alquilado;
DROP VIEW IF EXISTS bd_leasein.vista_laptops_detalle_alquiler_plazo_alquiler;
DROP VIEW IF EXISTS bd_leasein.vista_laptops_discos;
DROP VIEW IF EXISTS bd_leasein.vista_laptops_marca;
DROP VIEW IF EXISTS bd_leasein.vista_laptops_memorias;
DROP VIEW IF EXISTS bd_leasein.vista_laptops_modelo;
DROP VIEW IF EXISTS bd_leasein.vista_laptops_por_vencer;
DROP VIEW IF EXISTS bd_leasein.vista_licencia_ingresos;
DROP VIEW IF EXISTS bd_leasein.vista_licencia_lc_lista;
DROP VIEW IF EXISTS bd_leasein.vista_licencia_lista;
DROP VIEW IF EXISTS bd_leasein.vista_licencia_office_tipos;
DROP VIEW IF EXISTS bd_leasein.vista_licencia_windows_tipos;
DROP VIEW IF EXISTS bd_leasein.vista_lista_alquileres;
DROP VIEW IF EXISTS bd_leasein.vista_lista_cambios;
DROP VIEW IF EXISTS bd_leasein.vista_lista_devoluciones;
DROP VIEW IF EXISTS bd_leasein.vista_lista_ingresos;
DROP VIEW IF EXISTS bd_leasein.vista_lista_observaciones;
DROP VIEW IF EXISTS bd_leasein.vista_lista_reparaciones;
DROP VIEW IF EXISTS bd_leasein.vista_maestro_cliente;
DROP VIEW IF EXISTS bd_leasein.vista_maestro_disco;
DROP VIEW IF EXISTS bd_leasein.vista_maestro_laptops;
DROP VIEW IF EXISTS bd_leasein.vista_maestro_licencias;
DROP VIEW IF EXISTS bd_leasein.vista_maestro_memoria;
DROP VIEW IF EXISTS bd_leasein.vista_maestro_procesador;
DROP VIEW IF EXISTS bd_leasein.vista_maestro_sucursal_cliente;
DROP VIEW IF EXISTS bd_leasein.vista_maestro_video;
DROP VIEW IF EXISTS bd_leasein.vista_memoria_capacidad;
DROP VIEW IF EXISTS bd_leasein.vista_memoria_categoria;
DROP VIEW IF EXISTS bd_leasein.vista_memoria_frecuencia;
DROP VIEW IF EXISTS bd_leasein.vista_memoria_modelo;
DROP VIEW IF EXISTS bd_leasein.vista_moneda_tipo;
DROP VIEW IF EXISTS bd_leasein.vista_procesador_generacion;
DROP VIEW IF EXISTS bd_leasein.vista_procesador_marca;
DROP VIEW IF EXISTS bd_leasein.vista_procesador_velocidad;
DROP VIEW IF EXISTS bd_leasein.vista_procesador_velocidad_maxima;
DROP VIEW IF EXISTS bd_leasein.vista_productos_por_facturar;
DROP VIEW IF EXISTS bd_leasein.vista_productos_por_recoger;
DROP VIEW IF EXISTS bd_leasein.vista_proveedor_lista;
DROP VIEW IF EXISTS bd_leasein.vista_stock_disco_lc_almacen;
DROP VIEW IF EXISTS bd_leasein.vista_stock_disco_lc_cliente;
DROP VIEW IF EXISTS bd_leasein.vista_stock_disco_libre;
DROP VIEW IF EXISTS bd_leasein.vista_stock_memoria_lc_almacen;
DROP VIEW IF EXISTS bd_leasein.vista_stock_memoria_lc_cliente;
DROP VIEW IF EXISTS bd_leasein.vista_stock_memoria_libre;
DROP VIEW IF EXISTS bd_leasein.vista_stockdisponible_disco_libre;
DROP VIEW IF EXISTS bd_leasein.vista_stockdisponible_licencia_libre;
DROP VIEW IF EXISTS bd_leasein.vista_stockdisponible_memoria_libre;
DROP VIEW IF EXISTS bd_leasein.vista_usuario_perfil;
DROP VIEW IF EXISTS bd_leasein.vista_video_capacidad;
DROP VIEW IF EXISTS bd_leasein.vista_video_marca;
DROP VIEW IF EXISTS bd_leasein.vista_video_modelo;
DROP VIEW IF EXISTS bd_leasein.vista_video_tipo;
DROP VIEW IF EXISTS bd_leasein.vista_ConSinstockDisponible_memoria_libre;
DROP VIEW IF EXISTS bd_leasein.vista_ConSinstockDisponible_disco_libre;

/*Se mostrará la tabla de discos duros en el maestro de discos*/
create view vista_maestro_disco as
Select 	d.idDisco as idDisco,
		m.idModelo as idTipo,
		m.nombre as tipo,
		d.idTamano as idTamano,
		d.tamano as tamano,
		d.idCapacidad as idCapacidad,
		d.capacidad as capacidad,
		d.estado as estado
From disco_duro d
	inner join modelo m on m.idModelo = d.idModelo ;
	
/*Se mostrará el stock de discos duros libres ubicados en almacen*/
create view vista_stock_disco_libre as
Select 	d.idDisco as idDisco,
		m.nombre as tipo,
		d.tamano as tamano,
		d.capacidad as capacidad,
		d.cantidad as cantidad,
		d.estado as estado
From disco_duro d
	inner join modelo m on m.idModelo = d.idModelo;


/*Se mostrará la lista de discos duros con stock mayor a 1*/
create view vista_stockDisponible_disco_libre as
Select 	d.idDisco as IdDisco,
		m.nombre as TipoDisco,
		d.tamano as Tamano,
		d.capacidad as Capacidad,
		d.cantidad as Cantidad,
		d.estado as Estado
From disco_duro d
	inner join modelo m on m.idModelo = d.idModelo 
where d.cantidad>0 and d.estado=1;

create view vista_ConSinstockDisponible_disco_libre as
Select 	d.idDisco as IdDisco,
		m.nombre as TipoDisco,
		d.tamano as Tamano,
		d.capacidad as Capacidad,
		d.cantidad as Cantidad,
		d.estado as Estado
From disco_duro d
	inner join modelo m on m.idModelo = d.idModelo ;

/*Se mostrará el stock de discos duros en almacen relacionados a una laptop_cpu*/
create view vista_stock_disco_LC_almacen as
Select dlc.idDisco,
		m.nombre as tipo,
		d.tamano as tamano,
		d.capacidad as capacidad,
		sum(dlc.cantidad) as Cantidad
From disco_LC dlc, laptop_cpu lc,
	disco_duro d inner join modelo m on m.idModelo = d.idModelo
where dlc.idDisco=d.idDisco and dlc.idLC=lc.idLC and lc.ubicacion="Almacen" 
group by dlc.idDisco;


/*Se mostrará el stock de discos duros en cliente relacionados a una laptop_cpu*/
create view vista_stock_disco_LC_cliente as
Select dlc.idDisco,
		m.nombre as tipo,
		d.tamano as tamano,
		d.capacidad as capacidad,
		sum(dlc.cantidad) as Cantidad
From disco_LC dlc, laptop_cpu lc,
	disco_duro d inner join modelo m on m.idModelo = d.idModelo
where dlc.idDisco=d.idDisco and dlc.idLC=lc.idLC and Not(lc.ubicacion="Almacen")
group by dlc.idDisco;


/*Se mostrará la tabla de memorias en el maestro de memorias*/
create view vista_maestro_memoria as
Select 	me.idMemoria as idMemoria,
		ma.idMarca as idCategoria,
		ma.nombre as categoria,
		m.idModelo as idTipo,
		m.nombre as tipo,
		me.idTipo as idTipo2,
		me.tipo as tipo2,
		me.idBusFrecuencia as idBusFrecuencia,
		me.busFrecuencia as frecuencia,
		me.idCapacidad as idCapacidad,
		me.capacidad as capacidad,
		me.estado as estado
From memoria me
	inner join modelo m on m.idModelo = me.idModelo
	inner join marca ma on m.idMarca = ma.idMarca ;
	
/*Se mostrará el stock de memorias libres ubicados en almacen*/
create view vista_stock_memoria_libre as
Select 	me.idMemoria as idMemoria,
		ma.nombre as categoria,
		m.nombre as tipo,
		me.busFrecuencia as frecuencia,
		me.capacidad as capacidad,
		me.cantidad as cantidad,
		me.tipo as Tipo2,
		me.estado as estado
From memoria me
	inner join modelo m on m.idModelo = me.idModelo
	inner join marca ma on m.idMarca = ma.idMarca ;

/*Se mostrará la lista de memorias con stock mayor a 1*/
create view vista_stockDisponible_memoria_libre as
Select 	me.idMemoria as IdMemoria,
		ma.nombre as categoria,
		m.nombre as TipoMemoria,
		me.busFrecuencia as frecuencia,
		me.capacidad as Capacidad,
		me.cantidad as Cantidad,
		me.tipo as Tipo2,
		me.estado as estado
From memoria me
	inner join modelo m on m.idModelo = me.idModelo
	inner join marca ma on m.idMarca = ma.idMarca 
where me.cantidad>0 and me.estado=1;

create view vista_ConSinstockDisponible_memoria_libre as
Select 	me.idMemoria as IdMemoria,
		ma.nombre as categoria,
		m.nombre as TipoMemoria,
		me.busFrecuencia as frecuencia,
		me.capacidad as Capacidad,
		me.cantidad as Cantidad,
		me.tipo as Tipo2,
		me.estado as estado
From memoria me
	inner join modelo m on m.idModelo = me.idModelo
	inner join marca ma on m.idMarca = ma.idMarca;
	

/*Se mostrará el stock de memorias en almacen relacionados a una laptop_cpu*/
create view vista_stock_memoria_LC_almacen as
Select mlc.idMemoria,
		ma.nombre as categoria,
		m.nombre as tipo,
		me.busFrecuencia as frecuencia,
		me.capacidad as capacidad,
		me.tipo as Tipo2,
		sum(mlc.cantidad) as Cantidad
From memoria_LC mlc, laptop_cpu lc,
	memoria me
	inner join modelo m on m.idModelo = me.idModelo
	inner join marca ma on m.idMarca = ma.idMarca
where mlc.idMemoria=me.idMemoria and mlc.idLC=lc.idLC and lc.ubicacion="Almacen" 
group by mlc.idMemoria;

/*Se mostrará el stock de memorias en cliente relacionados a una laptop_cpu*/
create view vista_stock_memoria_LC_cliente as
Select mlc.idMemoria,
		ma.nombre as categoria,
		m.nombre as tipo,
		me.busFrecuencia as frecuencia,
		me.capacidad as capacidad,
		me.tipo as Tipo2,
		sum(mlc.cantidad) as Cantidad
From memoria_LC mlc, laptop_cpu lc,
	memoria me
	inner join modelo m on m.idModelo = me.idModelo
	inner join marca ma on m.idMarca = ma.idMarca
where mlc.idMemoria=me.idMemoria and mlc.idLC=lc.idLC and Not(lc.ubicacion="Almacen") 
group by mlc.idMemoria;


/*Se mostrará la tabla de procesador en el maestro de procesador*/
create view vista_maestro_procesador as
Select 	p.idProcesador as idProcesador,
		ma.idMarca as idMarca,
		ma.nombre as marca,
		m.idModelo as idTipo,
		m.nombre as tipo,
		p.idGeneracion as idGeneracion,
		p.generacion as generacion,
		p.idVelocidad as idVelocidad,
		p.velocidad as velocidad,
		p.idVelocidadMax as idVelocidadMax,
		p.velocidadMax as velocidadMax,
		p.estado as estado
From procesador p
	inner join modelo m on m.idModelo = p.idModelo
	inner join marca ma on m.idMarca = ma.idMarca ;

/*Se mostrará la tabla de videos en el maestro de videos*/
create view vista_maestro_video as
Select 	v.idVideo as idVideo,
		ma.idMarca as idMarca,
		ma.nombre as marca,
		m.idModelo as idModelo,
		m.nombre as nombreModelo,
		v.idTipo as idTipo,
		v.tipo as tipo,
		v.idCapacidad as idCapacidad,
		v.capacidad as capacidad,
		v.estado as estado
From video v
	inner join modelo m on m.idModelo = v.idModelo
	inner join marca ma on m.idMarca = ma.idMarca ;
	


/*Se mostrará las capacidades de los discos*/
create view vista_disco_capacidad as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="DISCO_CAPACIDAD" and activo=1;


/*Se mostrará el tamano de los discos*/
create view vista_disco_tamano as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="DISCO_TAMANO" and activo=1;

		
/*Se mostrará los tipos de licencia de ofice*/
create view vista_licencia_office_tipos as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="LICENCIA_OFFICE_TIPO" and activo=1;

		
/*Se mostrará los tipos de licencia de windows*/
create view vista_licencia_windows_tipos as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="LICENCIA_WINDOWS_TIPO" and activo=1;


create view vista_maestro_licencias as
SELECT c.idCategoria as IdCategoria , c.nombre as Categoria, m.idMarca as IdMarca, m.nombre as Tipo, mo.idModelo as IdModelo, mo.nombre as Version
FROM categoria c 
INNER JOIN marca m on m.idCategoria=c.idCategoria 
INNER JOIN modelo mo on m.idMarca=mo.idMarca 
WHERE c.subCategoria='LICENCIAS';

		
/*Se mostrará las capacidades de la memoria*/
create view vista_memoria_capacidad as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="MEMORIA_CAPACIDAD" and activo=1;

		
/*Se mostrará las categorias de la memoria*/
create view vista_memoria_categoria as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="MEMORIA_CATEGORIA" and activo=1;

		
/*Se mostrará las frecuencias de la memoria*/
create view vista_memoria_frecuencia as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="MEMORIA_FRECUENCIA" and activo=1;

		
/*Se mostrará las generaciones de los procesadores*/
create view vista_procesador_generacion as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="PROCESADOR_GENERACION" and activo=1;

		
/*Se mostrará las velocidades de los procesadores*/
create view vista_procesador_velocidad as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="PROCESADOR_VELOCIDAD" and activo=1;

		
/*Se mostrará las velocidades maxima de los procesadores*/
create view vista_procesador_velocidad_maxima as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="PROCESADOR_VELOCIDAD_MAXIMA" and activo=1;

		
/*Se mostrará perfiles de los usuarios*/
create view vista_usuario_perfil as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="USUARIO_PERFIL" and activo=1;

		
/*Se mostrará tipos de tarjeta de video*/
create view vista_video_tipo as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="VIDEO_TIPO" and activo=1;

/*Se mostrará las capacidad de tarjeta de video*/
create view vista_video_capacidad as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="VIDEO_CAPACIDAD" and activo=1;

/*Se mostrará los modelos de los videos*/
create view vista_video_modelo as
SELECT
	ma.idMarca as IdMarca,
	ma.nombre as NombreMarca,
	mo.idModelo as IdModelo,
	mo.nombre as NombreModelo
FROM
	modelo mo
	INNER JOIN marca ma ON mo.idMarca = ma.idMarca 
WHERE
	ma.idCategoria = 11;
		
/*Se mostrará los modelos de los discos SSD, HHD*/
create view vista_disco_modelo as
Select idModelo, nombre
from modelo
where idMarca=10 and estado=1;

		
/*Se mostrará los modelos de memoria DDR3, DDR4*/
create view vista_memoria_modelo as
Select idModelo, nombre
from modelo
where idMarca=7 and estado=1;

		
/*Se mostrará las marcas de los procesadores*/
create view vista_procesador_marca as
Select mo.idModelo, mo.nombre
from marca m INNER JOIN modelo mo on m.idMarca=mo.IdMarca
where m.idCategoria=9 and m.estado=1 ;


		
/*Se mostrará las marcas de las tarjetas de videos*/
create view vista_video_marca as
Select idMarca, nombre
from marca
where idCategoria=11 and estado=1;
		

/*Se mostrará todas las licencias*/
create view vista_licencia_lista as
Select l.idLicencia as IdLicencia,
				c.idCategoria as IdCategoria,
				c.nombre as Categoria,
				ma.idMarca as IdMarca,
				ma.nombre as Marca,
				mo.idModelo as IdModelo,
				mo.nombre as Version,
				l.clave as Clave,
				if(l.idLC is null,"",l.idLC) as IdLC,
				if(l.idLC is null,"",(select codigo from laptop_cpu lc where lc.idLC=l.idLC)) as CodigoLC,
				l.codigo as CodigoLicencia,
				l.ubicacion as Ubicacion,
				(select nombreEstado from estados e where e.idEstado=l.estado) as NombreEstado
from licencia l, modelo mo, marca ma, categoria c
where l.idModelo=mo.idModelo and ma.idMarca=mo.idMarca and c.idCategoria=ma.idCategoria;


/*Este es parecido al vista_licencia_lista, se usará para llamarlo junto a un where y colocar un idLC, pero la diferencia es que solo mostrará las que están actualmente a una laptop y activos, puede que haya licencias relacionadas a una laptop pero el estado este en 0, lo cual quiere decir que ya caduco, 1 es porque está activo*/
create view vista_licencia_lc_lista as
Select l.idLicencia as IdLicencia,
				c.idCategoria as IdCategoria,
				c.nombre as Categoria,
				ma.idMarca as IdMarca,
				ma.nombre as Marca,
				mo.idModelo as IdModelo,
				mo.nombre as Version,
				l.idLC as IdLC,
				l.clave as Clave,
				l.ubicacion as Ubicacion
from licencia l, modelo mo, marca ma, categoria c
where l.idModelo=mo.idModelo and ma.idMarca=mo.idMarca and c.idCategoria=ma.idCategoria and l.estado=1;

/*Se mostrará todas las licencias*/
create view vista_stockDisponible_licencia_libre as
Select l.idLicencia as IdLicencia,
				c.idCategoria as IdCategoria,
				c.nombre as Categoria,
				ma.idMarca as IdMarca,
				ma.nombre as Marca,
				mo.idModelo as IdModelo,
				mo.nombre as Version,
				l.idLC as IdLC,
				l.clave as Clave,
				l.ubicacion as Ubicacion
from licencia l, modelo mo, marca ma, categoria c
where l.idModelo=mo.idModelo and ma.idMarca=mo.idMarca and c.idCategoria=ma.idCategoria and l.estado=2 and l.idLC is null;
		
		
/*Se mostrará todas los proveedor*/
create view vista_proveedor_lista as		
Select 	idProveedor as idProveedor,
		ruc as ruc,
		razonSocial as razonSocial,
		nombreComercial as nombreComercial,
		abreviacion as abreviacion,
		direccion as direccion,
		telefono as telefono,
		fax as fax,
		email as email,
		observacion as observacion,
		nombreContacto as nombreContacto,
		telefonoContacto as telefonoContacto,
		emailContacto as emailContacto,
		estado as estado
From proveedor;
		
/*Se mostrará todos los tipos de documentos*/
create view vista_documento_tipo as	
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="TIPO_DOCUMENTO" and activo=1;
		
/*Se mostrará todos los KAMS activos*/
create view vista_KAM_activos as	
Select idUsuario as idUsuario,
		nombre as nombre
from usuario
where perfil=2 and estado=1 ;

/*Se mostrará la tabla de clientes en el maestro de clientes*/
create view vista_maestro_Cliente as
Select idCliente as idCliente,
		tipoDocumento as tipoDocumento,
		descripcion as nombreTipoDocumento,
		nroDocumento as nroDocumento,
		nombre_razonSocial as nombre_razonSocial,
		telefono as telefono,
		email as email,
		idKAM as idKAM,
		nombreKam as nombreKam,
    estado as estado
from cliente , auxiliar 
where tipoDocumento=idAuxiliar and cod_tabla='TIPO_DOCUMENTO';


/*Se mostrará la tabla de sucursales de un cliente en el maestro de sucursales clientes*/
create view vista_maestro_Sucursal_Cliente as
Select 	cs.idSucursal as idSucursal,
		cs.idCliente as idCliente,
		c.nombre_razonSocial as nombreCliente,
		cs.nroDocumento as nroDocumento,
		cs.nombreContacto as nombreContacto,
		cs.direccion as direccion,
		cs.telefono as telefono,
		cs.email as email,
		cs.observacion as observacion,
		cs.estado as estado
from cliente_sucursal cs , cliente c 
where cs.idCliente=c.idCliente;


/*Se mostrará la tabla de laptops en el maestro de laptops*/
create view vista_maestro_laptops as
Select 	l.idLC as idLC,
		ma.idMarca as idMarca,
		ma.nombre as marca,
		m.idModelo as idModelo,
		m.nombre as nombreModelo,
		l.codigo as codigo,
		l.tamanoPantalla as tamanoPantalla,
		l.idProcesador as idProcesador,
		if(l.idVideo is null,0,l.idVideo) as idVideo,
		l.partNumber as partNumber,
		l.serieFabrica as serieFabrica,
		l.garantia as garantia,
		l.fecInicioSeguro as fecInicioSeguro,
		l.fecFinSeguro as fecFinSeguro,
		l.ubicacion as ubicacion,
		l.observacion as observacion,
		l.estado as estado
From laptop_cpu l
	inner join modelo m on m.idModelo = l.idModelo
	inner join marca ma on m.idMarca = ma.idMarca ;
	

/*En la tabla salida se comparara la fecha final de alquiler con el dia actual.*/

create view vista_productos_por_recoger as
SELECT
	d.idSalidaDet AS IdSalidaDetalle,
	s.idSucursal AS IdSucursal,
	d.idLC AS IdLC,
	d.fecIniContrato AS fecIniContrato,
	d.fecFinContrato AS fecFinContrato,
	s.idCliente AS IdCliente,
	sc.nombreCliente AS Cliente,
	sc.nombreContacto AS Contacto,
	sc.direccion AS DireccionCliente,
	sc.telefono AS TelefonoContacto,
	lc.idMarca AS idMarca,
	lc.marca AS MarcaLC,
	lc.idModelo AS idModelo,
	lc.nombreModelo AS NombreModeloLC,
	lc.codigo AS Codigo,
	lc.tamanoPantalla AS TamanoPantalla,
	p.idProcesador AS idProcesador,
	p.marca AS marcaProcesador,
	p.tipo AS TipoProcesador,
	p.generacion AS GeneracionProcesador,
IF (( v.idVideo IS NULL ), 0, v.idVideo ) AS idVideo,
IF (( v.marca IS NULL ), '', v.marca ) AS marcaVideo,
IF (( v.nombreModelo IS NULL ), '', v.nombreModelo ) AS NombreModeloVideo,
IF (( v.capacidad IS NULL ), 0, v.capacidad ) AS CapacidadVideo,
IF (( v.tipo IS NULL ), '', v.tipo ) AS tipoVideo,
(to_days(curdate()) - to_days( d.fecFinContrato )) AS diasAtrasoRecojo,
	d.guiaSalida AS guia,
	d.motivoNoRecojo AS motivoNoRecojo,(
	SELECT c.nombreKam 
	FROM cliente c 
	WHERE ( c.idCliente = s.idCliente )) AS KAM,
	d.estado AS estado,
IF (( d.observacion IS NULL ), '', d.observacion ) AS CodigoAntiguo,
	'' AS GuiaAntigua,
	0 AS IdSalidaDetAntigua ,
		
	'' AS factura,
	'' AS fecInicioFactura,
	'' AS fecFinFactura,
	0 AS MontoSoles,
	0 AS MontoDolares,
	0 AS TotalDolares
	
FROM
	((((( salida s JOIN salida_det d ON (( s.idSalida = d.idSalida 
)))
LEFT JOIN vista_maestro_sucursal_cliente sc ON (( s.idSucursal = sc.idSucursal  ))) LEFT JOIN vista_maestro_laptops lc ON (( d.idLC = lc.idLC  )))
LEFT JOIN vista_maestro_procesador p ON ((
d.idProcesador = p.idProcesador 
))) LEFT JOIN vista_maestro_video v ON (( d.idVideo = v.idVideo  )))  ,
		cuota cu 
WHERE
	(( d.fueDevuelto = 0  ) AND ((( d.estado = 4 ) AND (( to_days( d.fecFinContrato ) - to_days( curdate())) < 0 )) 
		OR ( d.estado = 9 ))) 
		
		AND
			CASE WHEN d.caracteristicas='' THEN
				CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c)
			ELSE
				CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c) and
				(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c )
			END


UNION 



SELECT
	d.idSalidaDet AS IdSalidaDetalle,
	s.idSucursal AS IdSucursal,
	d.idLC AS IdLC,
	d.fecIniContrato AS fecIniContrato,
	d.fecFinContrato AS fecFinContrato,
	s.idCliente AS IdCliente,
	sc.nombreCliente AS Cliente,
	sc.nombreContacto AS Contacto,
	sc.direccion AS DireccionCliente,
	sc.telefono AS TelefonoContacto,
	lc.idMarca AS idMarca,
	lc.marca AS MarcaLC,
	lc.idModelo AS idModelo,
	lc.nombreModelo AS NombreModeloLC,
	lc.codigo AS Codigo,
	lc.tamanoPantalla AS TamanoPantalla,
	p.idProcesador AS idProcesador,
	p.marca AS marcaProcesador,
	p.tipo AS TipoProcesador,
	p.generacion AS GeneracionProcesador,
IF (( v.idVideo IS NULL ), 0, v.idVideo ) AS idVideo,
IF (( v.marca IS NULL ), '', v.marca ) AS marcaVideo,
IF (( v.nombreModelo IS NULL ), '', v.nombreModelo ) AS NombreModeloVideo,
IF (( v.capacidad IS NULL ), 0, v.capacidad ) AS CapacidadVideo,
IF (( v.tipo IS NULL ), '', v.tipo ) AS tipoVideo,
(to_days(curdate()) - to_days( d.fecFinContrato )) AS diasAtrasoRecojo,
	d.guiaSalida AS guia,
	d.motivoNoRecojo AS motivoNoRecojo,(
	SELECT c.nombreKam 
	FROM cliente c 
	WHERE ( c.idCliente = s.idCliente )) AS KAM,
	d.estado AS estado,
IF (( d.observacion IS NULL ), '', d.observacion ) AS CodigoAntiguo,
	'' AS GuiaAntigua,
	0 AS IdSalidaDetAntigua ,
	
	cu.numFactura AS factura,
	cu.fecInicioPago AS fecInicioFactura,
	cu.fecFinPago AS fecFinFactura,
	cu.totalSoles AS MontoSoles,
	cu.totalDolares AS MontoDolares,
	ROUND((cu.totalDolares+(cu.totalSoles/3.5)),2) AS TotalDolares
	
FROM
	((((( salida s JOIN salida_det d ON (( s.idSalida = d.idSalida 
)))
LEFT JOIN vista_maestro_sucursal_cliente sc ON (( s.idSucursal = sc.idSucursal  ))) LEFT JOIN vista_maestro_laptops lc ON (( d.idLC = lc.idLC  )))
LEFT JOIN vista_maestro_procesador p ON ((
d.idProcesador = p.idProcesador 
))) LEFT JOIN vista_maestro_video v ON (( d.idVideo = v.idVideo  ))) ,
		cuota cu 
WHERE
	(( d.fueDevuelto = 0  ) AND ((( d.estado = 4 ) AND (( to_days( d.fecFinContrato ) - to_days( curdate())) < 0 )) 
		OR ( d.estado = 9 ))) 
		AND
			CASE WHEN d.caracteristicas='' THEN
				CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) 
			ELSE
				CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) or
				(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) = CONCAT( cu.idLC, '-', cu.idSalida )
			END
		
ORDER BY
	IdLC;


create view vista_productos_por_recoger_bk as
Select d.idSalidaDet as IdSalidaDetalle,
		s.idSucursal as IdSucursal,
		d.idLC as IdLC,
		d.fecIniContrato as fecIniContrato,
		d.fecFinContrato as fecFinContrato,
		s.idCliente as IdCliente,
		sc.nombreCliente as Cliente,
		sc.nombreContacto as Contacto,
		sc.direccion as DireccionCliente,
		sc.telefono as TelefonoContacto,
		lc.idMarca as idMarca,
		lc.marca as MarcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as NombreModeloLC,
		lc.codigo as Codigo,
		lc.tamanoPantalla as TamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as TipoProcesador,
		p.generacion as GeneracionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as NombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as CapacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo,
		DATEDIFF(CURDATE(),d.fecFinContrato) as diasAtrasoRecojo,
		d.guiaSalida as guia,
		d.motivoNoRecojo as motivoNoRecojo,
		(Select c.nombreKam from cliente c where c.idCliente=s.idCliente) as KAM,
		d.estado
From salida s INNER JOIN salida_det d on s.idSalida=d.idSalida
		LEFT JOIN vista_maestro_sucursal_cliente sc on s.idSucursal=sc.idSucursal
		left join  vista_maestro_laptops lc on d.idLC=lc.idLC
		left join  vista_maestro_procesador p on d.idProcesador=p.idProcesador 
		left join vista_maestro_video v on d.idVideo=v.idVideo 
where d.fueDevuelto=0 
and ((d.estado=4 and  (DATEDIFF( d.fecFinContrato , CURDATE())<0)) 
		or d.estado=9)
ORDER BY lc.idLC ;


 
/*En la tabla de cuota se va a poner la ultima factura que se tenga de este producto, si se ingresa una nueva, se elimina esta fila y se inserta la nueva factura aqui. Si no hay ninguna factura en cuota significa que a ese producto nunca se ha facturado.*/

DROP VIEW IF EXISTS vista_productos_por_facturar;
create view vista_productos_por_facturar as
SELECT
		(SELECT	c.nombre_razonSocial FROM	cliente c WHERE	( c.idCliente = s.idCliente )) AS cliente,
		(SELECT	c.nroDocumento FROM cliente c WHERE ( c.idCliente = s.idCliente )) AS ruc,
		d.fecIniContrato AS fecIniPlazoAlquiler,
		d.fecFinContrato AS fecFinPlazoAlquiler,
		'' AS factura,
		'' AS fecInicioFactura,
		'' AS fecFinFactura,
		'0' AS TotalSoles,
		'0' AS TotalDolares,
		'0' AS CostoSoles,
		'0' AS CostoDolares,
		'0' AS PendienteFacturarSoles,
		'0' AS PendienteFacturarDolares,
		'0' AS PendienteFacturarUtilidadSoles,
		lc.codigo AS codigoEquipo,
		d.guiaSalida AS guia,
		(to_days(curdate()) - to_days( d.fecIniContrato )) AS diasVencidos,
		(SELECT	c.nombreKam FROM	cliente c WHERE ( c.idCliente = s.idCliente )) AS KAM,
		IF(( d.observacion IS NULL ), '', d.observacion ) AS CodigoAntiguo,
		'' AS GuiaAntigua,
		0 AS IdSalidaDetAntigua 
FROM
		salida s
		INNER JOIN salida_det d ON s.idSalida = d.idSalida
		INNER JOIN laptop_cpu lc ON lc.idLC = d.idLC 
WHERE
		d.estado = 4 
		AND
			CASE WHEN d.caracteristicas='' THEN
				CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c)
			ELSE
				CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c) and
				(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c )
			END
		
UNION

SELECT
		(SELECT	c.nombre_razonSocial FROM	cliente c WHERE	( c.idCliente = s.idCliente )) AS cliente,
		(SELECT	c.nroDocumento FROM	cliente c WHERE	( c.idCliente = s.idCliente )) AS ruc,
		d.fecIniContrato AS fecIniPlazoAlquiler,
		d.fecFinContrato AS fecFinPlazoAlquiler,
		cu.numFactura AS factura,
		cu.fecInicioPago AS fecInicioFactura,
		cu.fecFinPago AS fecFinFactura,
		cu.totalSoles AS TotalSoles,
		cu.totalDolares AS TotalDolares,
		cu.costoSoles AS CostoSoles,
		cu.costoDolares AS CostoDolares,
		(ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30 )) * cu.totalSoles) AS PendienteFacturarSoles,
		(ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30 )) * cu.totalDolares) AS PendienteFacturarDolares,
		(ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30 )) * (((( cu.totalDolares * 3.5 ) - ( cu.costoDolares * 3.5 )) + cu.totalSoles ) - cu.costoSoles )) AS PendienteFacturarUtilidadSoles,
		lc.codigo AS codigoEquipo,
		d.guiaSalida AS guia,
		(to_days(curdate()) - to_days( cu.fecFinPago )) AS diasVencidos,
		(SELECT	c.nombreKam FROM cliente c WHERE ( c.idCliente = s.idCliente )) AS KAM,
		IF(( d.observacion IS NULL ), '', d.observacion ) AS CodigoAntiguo,
		'' AS GuiaAntigua,
		0 AS IdSalidaDetAntigua 
FROM
		salida s
		INNER JOIN salida_det d ON s.idSalida = d.idSalida
		INNER JOIN laptop_cpu lc ON lc.idLC = d.idLC,
		cuota cu 
WHERE
		d.estado = 4 
		AND (( d.fecFinContrato = cu.fecFinPago AND d.corteAlquiler = 0 ) 	OR d.fecFinContrato > cu.fecFinPago) 
		AND cu.fecFinPago < curdate() 
		AND
			CASE WHEN d.caracteristicas='' THEN
				CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) 
			ELSE
				CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) or
				(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) = CONCAT( cu.idLC, '-', cu.idSalida )
			END
			
ORDER BY
		cliente,
		codigoEquipo


DROP VIEW IF EXISTS vista_productos_por_facturar_bk;
create view vista_productos_por_facturar_bk as
	SELECT
		( SELECT c.nombre_razonSocial FROM cliente c WHERE c.idCliente = s.idCliente ) AS cliente,
		d.fecIniContrato AS fecIniPlazoAlquiler,
		d.fecFinContrato AS fecFinPlazoAlquiler,
		"" AS factura,
		"" AS fecInicioFactura,
		"" AS fecFinFactura,
		"0" AS TotalSoles,
		"0" AS TotalDolares,
		"0" AS CostoSoles,
		"0" AS CostoDolares,
		"0" AS PendienteFacturarSoles,
		"0" AS PendienteFacturarDolares,
		lc.codigo AS codigoEquipo,
		d.guiaSalida AS guia,
		DATEDIFF( CURDATE(), d.fecIniContrato ) AS diasVencidos,
		( SELECT c.nombreKam FROM cliente c WHERE c.idCliente = s.idCliente ) AS KAM 
	FROM
		salida s
		INNER JOIN salida_det d ON s.idSalida = d.idSalida
		INNER JOIN laptop_cpu lc ON lc.idLC = d.idLC 
	WHERE
		d.estado = 4 
		AND
			CASE WHEN d.caracteristicas='' THEN
				CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c)
			ELSE
				CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c) and
				(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c )
			END
		
	UNION

	SELECT
		( SELECT c.nombre_razonSocial FROM cliente c WHERE c.idCliente = s.idCliente ) AS cliente,
		d.fecIniContrato AS fecIniPlazoAlquiler,
		d.fecFinContrato AS fecFinPlazoAlquiler,
		cu.numFactura AS factura,
		cu.fecInicioPago AS fecInicioFactura,
		cu.fecFinPago AS fecFinFactura,
		cu.totalSoles AS TotalSoles,
		cu.totalDolares AS TotalDolares,
		cu.costoSoles AS CostoSoles,
		cu.costoDolares AS CostoDolares,
		CEIL(DATEDIFF( CURDATE(), cu.fecFinPago )/30)*cu.totalSoles AS PendienteFacturarSoles,
		CEIL(DATEDIFF( CURDATE(), cu.fecFinPago )/30)*cu.totalDolares AS PendienteFacturarDolares,
		lc.codigo AS codigoEquipo,
		d.guiaSalida AS guia,
		DATEDIFF( CURDATE(), cu.fecFinPago ) AS diasVencidos,
		( SELECT c.nombreKam FROM cliente c WHERE c.idCliente = s.idCliente ) AS KAM 
	FROM
		salida s
		INNER JOIN salida_det d ON s.idSalida = d.idSalida
		INNER JOIN laptop_cpu lc ON lc.idLC = d.idLC,
		cuota cu 
	WHERE
		d.estado = 4 
		AND NOT ( d.fecFinContrato = cu.fecFinPago ) 
		AND cu.fecFinPago < CURDATE() 
		AND
			CASE WHEN d.caracteristicas='' THEN
				CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) 
			ELSE
				CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) or
				(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) = CONCAT( cu.idLC, '-', cu.idSalida )
			END
	ORDER BY
		cliente,
		codigoEquipo ;

DROP VIEW IF EXISTS vista_productos_por_facturar_bk;
create view vista_productos_por_facturar_bk as
	SELECT
		( SELECT c.nombre_razonSocial FROM cliente c WHERE c.idCliente = s.idCliente ) AS cliente,
		d.fecIniContrato AS fecIniPlazoAlquiler,
		d.fecFinContrato AS fecFinPlazoAlquiler,
		"" AS factura,
		"" AS fecInicioFactura,
		"" AS fecFinFactura,
		lc.codigo AS codigoEquipo,
		d.guiaSalida AS guia,
		DATEDIFF( CURDATE(), d.fecIniContrato ) AS diasVencidos,
		( SELECT c.nombreKam FROM cliente c WHERE c.idCliente = s.idCliente ) AS KAM 
	FROM
		salida s
		INNER JOIN salida_det d ON s.idSalida = d.idSalida
		INNER JOIN laptop_cpu lc ON lc.idLC = d.idLC 
	WHERE
		d.estado = 4 
		AND
			CASE WHEN d.caracteristicas='' THEN
				CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c)
			ELSE
				CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c) and
				(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c )
			END
		
	UNION

	SELECT
		( SELECT c.nombre_razonSocial FROM cliente c WHERE c.idCliente = s.idCliente ) AS cliente,
		d.fecIniContrato AS fecIniPlazoAlquiler,
		d.fecFinContrato AS fecFinPlazoAlquiler,
		cu.numFactura AS factura,
		cu.fecInicioPago AS fecInicioFactura,
		cu.fecFinPago AS fecFinFactura,
		lc.codigo AS codigoEquipo,
		d.guiaSalida AS guia,
		DATEDIFF( CURDATE(), cu.fecFinPago ) AS diasVencidos,
		( SELECT c.nombreKam FROM cliente c WHERE c.idCliente = s.idCliente ) AS KAM 
	FROM
		salida s
		INNER JOIN salida_det d ON s.idSalida = d.idSalida
		INNER JOIN laptop_cpu lc ON lc.idLC = d.idLC,
		cuota cu 
	WHERE
		d.estado = 4 
		AND NOT ( d.fecFinContrato = cu.fecFinPago ) 
		AND cu.fecFinPago < CURDATE() 
		AND
			CASE WHEN d.caracteristicas='' THEN
				CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) 
			ELSE
				CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) or
				(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) = CONCAT( cu.idLC, '-', cu.idSalida )
			END
	ORDER BY
		cliente,
		codigoEquipo;



DROP VIEW IF EXISTS vista_facturas_por_vencer;
create view vista_facturas_por_vencer as
SELECT
	( SELECT c.nombre_razonSocial FROM cliente c WHERE c.idCliente = s.idCliente ) AS cliente,
	d.fecIniContrato AS fecIniPlazoAlquiler,
	d.fecFinContrato AS fecFinPlazoAlquiler,
	cu.numFactura AS factura,
	cu.fecInicioPago AS fecInicioFactura,
	cu.fecFinPago AS fecFinFactura,
	lc.codigo AS codigoEquipo,
	d.guiaSalida AS guia,
	DATEDIFF( cu.fecFinPago, CURDATE() ) AS diasAntesVencer,
	( SELECT c.nombreKam FROM cliente c WHERE c.idCliente = s.idCliente ) AS KAM 
FROM
	salida s
	INNER JOIN salida_det d ON s.idSalida = d.idSalida
	INNER JOIN laptop_cpu lc ON lc.idLC = d.idLC,
	cuota cu 
WHERE
	d.estado = 4 
	AND NOT ( d.fecFinContrato = cu.fecFinPago ) 
	AND DATEDIFF( cu.fecFinPago, CURDATE() ) <=7 AND DATEDIFF( cu.fecFinPago, CURDATE() ) >=0 
	AND
	CASE
		WHEN d.caracteristicas = '' THEN
			CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) ELSE CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) 
			OR ( SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) FROM cambio ca WHERE ca.IdCambio = d.caracteristicas ) = CONCAT( cu.idLC, '-', cu.idSalida ) 
		END 
ORDER BY
	cliente,
	codigoEquipo;



	
/*Se mostrará la tabla de laptops en el maestro de laptops*/
create view vista_laptops_almacen_lista as
SELECT lc.idLC as idLC,
		lc.idMarca as idMarca,
		lc.marca as marcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as nombreModeloLC,
		lc.codigo as codigo,
		lc.tamanoPantalla as tamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as tipoProcesador,
		p.generacion as generacionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as nombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as capacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo,
		lc.partNumber as partNumber,
		lc.serieFabrica as serieFabrica,
		lc.garantia as garantia,
		lc.fecInicioSeguro as fecInicioSeguro,
		lc.fecFinSeguro as fecFinSeguro,
		lc.ubicacion as ubicacion,
		lc.observacion as observacion,
		lc.estado as estado
FROM vista_maestro_laptops lc 
		left join  vista_maestro_procesador p on lc.idProcesador=p.idProcesador 
		left join vista_maestro_video v on lc.idVideo=v.idVideo 
where lc.estado=2 and lc.ubicacion='ALMACEN'
ORDER BY lc.idLC;
	
/*Se mostrará la tabla de discos relacinados a una laptop*/
create view vista_laptops_discos as
SELECT lc.idLC as IdLC,
		d.idDisco as IdDisco,
		d.tipo as TipoDisco,
		d.tamano as Tamano,
		d.capacidad as Capacidad,
		dlc.cantidad as Cantidad
FROM vista_maestro_laptops lc, vista_maestro_disco d, disco_lc dlc
where lc.idLC=dlc.idLC and d.idDisco=dlc.idDisco 
ORDER BY d.tipo;


/*Se mostrará la tabla de discos relacinados a una laptop*/
create view vista_laptops_memorias as
SELECT lc.idLC as idLC,
		m.idMemoria as IdMemoria,
		m.tipo as TipoMemoria,
		m.tipo2 as Tipo2,
		m.capacidad as Capacidad,
		mlc.cantidad as Cantidad
FROM vista_maestro_laptops lc, vista_maestro_memoria m,  memoria_lc mlc
where lc.idLC=mlc.idLC and m.idMemoria=mlc.idMemoria
ORDER BY m.tipo;


/*Se mostrará los alquileres realizado*/
create view vista_lista_alquileres as
Select a.idSalida as idAlquiler,
			 a.idCliente as idCliente,
			 a.usuario_ins as nombreKam,
			 a.estado as idEstado,
			 c.nombre_razonSocial as nombreCliente,
			 cast(a.fec_ins as date) as fechaProceso,
			 e.nombreEstado as estado
From salida a inner join cliente c on a.idCliente=c.idCliente 
				inner join estados e on a.estado=e.idEstado;

/*Se mostrará los alquileres realizado*/
create view vista_laptops_almacen_lista_sin_filtro as
SELECT lc.idLC as idLC,
		lc.idMarca as idMarca,
		lc.marca as marcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as nombreModeloLC,
		lc.codigo as codigo,
		lc.tamanoPantalla as tamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as tipoProcesador,
		p.generacion as generacionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as nombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as capacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo,
		lc.partNumber as partNumber,
		lc.serieFabrica as serieFabrica,
		lc.garantia as garantia,
		lc.fecInicioSeguro as fecInicioSeguro,
		lc.fecFinSeguro as fecFinSeguro,
		lc.ubicacion as ubicacion,
		lc.observacion as observacion,
		lc.estado as estado
FROM vista_maestro_laptops lc 
		left join  vista_maestro_procesador p on lc.idProcesador=p.idProcesador 
		left join vista_maestro_video v on lc.idVideo=v.idVideo 
ORDER BY lc.idLC ;

/*Se mostrará todas las laptops que pertenezcan a un cliente cuando se le filtre por idCliente y que además estén en estado alquilado*/
create view vista_laptops_detalle_alquiler_cliente_estado_alquilado as
Select d.idSalidaDet as IdSalidaDetalle,
		s.idSucursal as IdSucursal,
		d.idLC as IdLC,
		cast(d.fecFinContrato as Date) as FinPlazoAlquiler,
		s.idCliente as IdCliente,
		lc.idMarca as idMarca,
		lc.marca as MarcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as NombreModeloLC,
		lc.codigo as Codigo,
		lc.tamanoPantalla as TamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as TipoProcesador,
		p.generacion as GeneracionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as NombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as CapacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo
From salida s INNER JOIN salida_det d on s.idSalida=d.idSalida
		left join  vista_maestro_laptops lc on d.idLC=lc.idLC
		left join  vista_maestro_procesador p on d.idProcesador=p.idProcesador 
		left join vista_maestro_video v on d.idVideo=v.idVideo 
where d.fueDevuelto=0 and (d.estado=4 or d.estado=9)
ORDER BY lc.idLC ;


create view vista_lista_devoluciones as
Select a.idDevolucion as IdDevolucion,
			 a.idCliente as IdCliente,
			 a.usuario_ins as NombreKam,
			 a.estado as IdEstado,
			 c.nombre_razonSocial as NombreCliente,
			 cast(a.fec_ins as date) as FechaProceso,
			 e.nombreEstado as Estado
From devolucion a inner join cliente c on a.idCliente=c.idCliente 
				inner join estados e on a.estado=e.idEstado;
				
				
create view vista_lista_cambios as
Select a.idCambio as IdCambio,
			 a.idCliente as IdCliente,
			 a.usuario_ins as NombreKam,
			 a.estado as IdEstado,
			 c.nombre_razonSocial as NombreCliente,
			 cast(a.fec_ins as date) as FechaProceso,
			 e.nombreEstado as Estado
From cambio a inner join cliente c on a.idCliente=c.idCliente 
				inner join estados e on a.estado=e.idEstado;

create view vista_datos_laptop_por_cambiar as
SELECT d.idLC as IdLCAntiguo,
		d.fecIniContrato as fecIniContrato,
		d.fecFinContrato as fecFinContrato,
		s.idSalida as IdSalida ,
		d.idSalidaDet as IdSalidaDet ,
		l.codigo as CodigoLCAntiguo,
		s.idCliente as IdCliente,
		s.idSucursal as IdSucursal,
		c.nombre_razonSocial as NombreCliente,
		s.rucDni as RucDni
FROM salida_det d 
		INNER JOIN salida s on d.idSalida=s.idSalida 
		INNER JOIN laptop_cpu l on d.idLC=l.idLC 
		INNER JOIN cliente c on s.idCliente=c.IdCliente
where d.estado=4 and fueDevuelto=0;


create view vista_laptops_marca as
Select m.idMarca, m.nombre
from marca m 
where m.idCategoria=1 and m.estado=1 ;


create view vista_laptops_modelo as
Select m.idMarca, mo.idModelo, mo.nombre
from marca m INNER JOIN modelo mo on m.idMarca=mo.IdMarca
where m.idCategoria=1 and m.estado=1 ;


create view vista_ingreso_tipo as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="INGRESO_TIPO" and activo=1;


create view vista_moneda_tipo as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="MONEDA_TIPO" and activo=1;


/*Se mostrará los alquileres realizado*/
create view vista_lista_ingresos as
Select a.idIngreso as idIngreso,
			 a.idProveedor as idProveedor,
			 a.usuario_ins as nombreKam,
			 a.estado as idEstado,
			 c.razonSocial as razonSocial,
			 cast(a.fec_ins as date) as fechaProceso,
			 e.nombreEstado as estado
From ingreso a inner join proveedor c on a.idProveedor=c.idProveedor 
				inner join estados e on a.estado=e.idEstado ;


/*Se mostrará los alquileres realizado*/
create view vista_licencia_ingresos as
Select l.idLicencia as IdLicencia,
				c.idCategoria as IdCategoria,
				c.nombre as Categoria,
				ma.idMarca as IdMarca,
				ma.nombre as Marca,
				mo.idModelo as IdModelo,
				mo.nombre as Version,
				l.idLC as IdLaptop,
				l.clave as Clave,
				l.ubicacion as Ubicacion,
				l.idIngreso as idIngreso,
				l.idIngresoDet as idIngresoDet,
				l.idIngresoDetAccesorios as idIngresoDetAccesorios,
				l.idLC as idLC
from licencia l, modelo mo, marca ma, categoria c
where l.idModelo=mo.idModelo and ma.idMarca=mo.idMarca and c.idCategoria=ma.idCategoria ;



create view vista_ingresos_detalles_modificable as
SELECT
	d.*,
	ma.nombre AS nombreMarca,
	mo.nombre AS nombreModelo,
	vp.tipo AS tipoProcesador,
	vp.generacion AS generacionProcesador,
	IFNULL( vv.nombreModelo, '' ) AS modeloVideo,
	IFNULL( vv.capacidad, '' ) AS capacidadVideo,
	IFNULL( vd1.capacidad, 0 ) AS CapacidadDisco1,
	IFNULL( vd1.tipo, '' ) AS TipoDisco1,
	IFNULL( vd1.tamano, '' ) AS TamanoDisco1,
	IFNULL( vd2.capacidad, 0 ) AS CapacidadDisco2,
	IFNULL( vd2.tipo, '' ) AS TipoDisco2,
	IFNULL( vd2.tamano, '' ) AS TamanoDisco2,
	IFNULL( m1.capacidad, 0 ) AS CapacidadMemoria1,
	IFNULL( m1.tipo, '' ) AS TipoMemoria1,
	IFNULL( m1.tipo2, '' ) AS Tipo2Memoria1,
	IFNULL( m2.capacidad, 0 ) AS CapacidadMemoria2,
	IFNULL( m2.tipo, '' ) AS TipoMemoria2,
	IFNULL( m2.tipo2, '' ) AS Tipo2Memoria2,
	IFNULL( m3.capacidad, 0 ) AS CapacidadMemoria3,
	IFNULL( m3.tipo, '' ) AS TipoMemoria3,
	IFNULL( m3.tipo2, '' ) AS Tipo2Memoria3,
	IFNULL( l1.Version, '' ) AS ModeloWindows,
	IFNULL( l1.Categoria, '' ) AS CategoriaWindows,
	IFNULL( l2.Version, '' ) AS ModeloOffice,
	IFNULL( l2.Categoria, '' ) AS CategoriaOffice,
	IFNULL( l3.Version, '' ) AS ModeloAntivirus,
	IFNULL( l3.Categoria, '' ) AS CategoriaAntivirus 
FROM
	ingreso_det d
	INNER JOIN marca ma ON d.idMarcaLC = ma.idMarca
	INNER JOIN modelo mo ON d.idModeloLC = mo.idModelo
	INNER JOIN vista_maestro_procesador vp ON d.idProcesador = vp.idProcesador
	LEFT JOIN vista_maestro_video vv ON d.idVideo = vv.idVideo
	LEFT JOIN vista_maestro_disco vd1 ON d.idDisco1 = vd1.idDisco
	LEFT JOIN vista_maestro_disco vd2 ON d.idDisco2 = vd2.idDisco
	LEFT JOIN vista_maestro_memoria m1 ON d.idMemoria1 = m1.idMemoria
	LEFT JOIN vista_maestro_memoria m2 ON d.idMemoria2 = m2.idMemoria
	LEFT JOIN vista_maestro_memoria m3 ON d.idMemoria3 = m3.idMemoria
	LEFT JOIN vista_maestro_licencias l1 ON d.idModeloWindows = l1.IdModelo
	LEFT JOIN vista_maestro_licencias l2 ON d.idModeloOffice = l2.IdModelo
	LEFT JOIN vista_maestro_licencias l3 ON d.idModeloAntivirus = l3.IdModelo ;
	
	
	
create view vista_ingresos_detalles_accesorios_modificable as
SELECT
	da.*,
	IFNULL( d.capacidad, '' ) AS CapacidadDisco,
	IFNULL( d.tipo, '' ) AS TipoDisco,
	IFNULL( d.tamano, '' ) AS TamanoDisco,
	IFNULL( m.capacidad, '' ) AS CapacidadMemoria,
	IFNULL( m.tipo, '' ) AS TipoMemoria,
	IFNULL( m.tipo2, '' ) AS Tipo2,
	IFNULL( l.Categoria, '' ) AS Categoria,
	IFNULL( l.IdCategoria, '' ) AS IdCategoriaLicencia,
	IFNULL( l.Tipo, '' ) AS Marca,
	IFNULL( l.Version, '' ) AS Version 
FROM
	ingreso_det_accesorios da
	LEFT JOIN vista_maestro_disco d ON da.idDisco = d.idDisco
	LEFT JOIN vista_maestro_memoria m ON da.idMemoria = m.idMemoria
	LEFT JOIN vista_maestro_licencias l ON da.idModeloLicencia = l.IdModelo ;
	
	
DROP view IF EXISTS vista_factura_CV;
create view vista_factura_CV as
SELECT
	CONCAT( s.rucDni, '-', l.codigo ) AS concatCodActCV,
	CONCAT( s.rucDni, '-', d.observacion ) AS concatCodAntCV,
	l.codigo,
	l.idLC AS IdLCActual,
	d.observacion AS CodigoAntiguo,
	cl.nombre_razonSocial,
	d.fecIniContrato,
	d.fecFinContrato,
	IFNULL( c.fecInicioPago, '31/12/1999' ) AS fecInicioPago,
	IFNULL( c.fecFinPago, '31/12/1999' ) AS fecFinPago,
	IFNULL( c.numFactura, '' ) AS numFactura,
	IFNULL( c.guiaSalida, '' ) AS guiaSalida,
	d.guiaSalida AS guiaActual,
	IFNULL((
		SELECT
			d2.guiaSalida AS GuiaSalidaAntiguo 
		FROM
			cambio c1
			INNER JOIN salida_det d2 ON d2.idLC = c1.idLCAntiguo 
		WHERE
			d.caracteristicas = c1.idCambio 
			),
		'' 
	) AS guiaAntigua,
	IFNULL((
		SELECT
			c2.fecInicioPago AS fecInicioPagoAntigua 
		FROM
			cambio c1
			INNER JOIN salida_det d2 ON d2.idLC = c1.idLCAntiguo
			INNER JOIN cuota c2 ON d2.idLC = c2.IdLC 
			AND d2.idSalida = c2.idSalida 
		WHERE
			d.caracteristicas = c1.idCambio 
			),
		'31/12/1999' 
	) AS fecInicioPagoAntigua,
	IFNULL((
		SELECT
			c2.fecFinPago AS fecFinPagoAntigua 
		FROM
			cambio c1
			INNER JOIN salida_det d2 ON d2.idLC = c1.idLCAntiguo
			INNER JOIN cuota c2 ON d2.idLC = c2.IdLC 
			AND d2.idSalida = c2.idSalida 
		WHERE
			d.caracteristicas = c1.idCambio 
			),
		'31/12/1999' 
	) AS fecFinPagoAntigua,
	IFNULL((
		SELECT
			c2.numFactura AS numFacturaAntigua 
		FROM
			cambio c1
			INNER JOIN salida_det d2 ON d2.idLC = c1.idLCAntiguo
			INNER JOIN cuota c2 ON d2.idLC = c2.IdLC 
			AND d2.idSalida = c2.idSalida 
		WHERE
			d.caracteristicas = c1.idCambio 
			),
		'' 
	) AS numFacturaAntigua,
	IFNULL((
		SELECT
			d2.idLC AS IdLCAntigua 
		FROM
			cambio c1
			INNER JOIN salida_det d2 ON d2.idLC = c1.idLCAntiguo 
		WHERE
			d.caracteristicas = c1.idCambio 
			),
		'' 
	) AS IdLCAntigua 
FROM
	salida s
	INNER JOIN salida_det d ON s.idSalida = d.idSalida
	LEFT JOIN laptop_cpu l ON d.idLC = l.idLC
	LEFT JOIN cuota c ON d.idLC = c.IdLC 
	AND d.idSalida = c.idSalida
	LEFT JOIN cliente cl ON s.rucDni = cl.nroDocumento 
WHERE
	d.estado = 4;
	
	
/*Se mostrará todas las laptops que pertenezcan a un cliente cuando se le filtre por idCliente y que además estén en estado alquilado*/
create view vista_laptops_detalle_alquiler_plazo_alquiler as
Select d.idSalidaDet as IdSalidaDetalle,
		s.idSucursal as IdSucursal,
		d.idLC as IdLC,
		d.fecIniContrato as fecIniContrato,
		d.fecFinContrato as fecFinContrato,
		s.idCliente as IdCliente,
		lc.idMarca as idMarca,
		lc.marca as MarcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as NombreModeloLC,
		lc.codigo as Codigo,
		lc.tamanoPantalla as TamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as TipoProcesador,
		p.generacion as GeneracionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as NombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as CapacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo
From salida s INNER JOIN salida_det d on s.idSalida=d.idSalida
		left join  vista_maestro_laptops lc on d.idLC=lc.idLC
		left join  vista_maestro_procesador p on d.idProcesador=p.idProcesador 
		left join vista_maestro_video v on d.idVideo=v.idVideo 
where d.fueDevuelto=0 and d.estado=4
ORDER BY lc.idLC ;

create view vista_laptops_cuadro_vencimiento as
Select d.idSalidaDet as IdSalidaDetalle,
		s.idSucursal as IdSucursal,
		s.idSalida as IdSalida,
		d.idLC as IdLC,
		d.fecIniContrato as fecIniContrato,
		d.fecFinContrato as fecFinContrato,
		s.idCliente as IdCliente,
		sc.nombreCliente as Cliente,
		sc.nombreContacto as Contacto,
		sc.direccion as DireccionCliente,
		sc.telefono as TelefonoContacto,
		lc.idMarca as idMarca,
		lc.marca as MarcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as NombreModeloLC,
		lc.codigo as Codigo,
		lc.tamanoPantalla as TamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as TipoProcesador,
		p.generacion as GeneracionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as NombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as CapacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo,
				
		d.guiaSalida AS guia,
		'' AS factura,
		'' AS fecInicioFactura,
		'' AS fecFinFactura,
		0 AS MontoSoles,
		0 AS MontoDolares,
		0 AS TotalDolares,
		DATEDIFF( CURDATE(), d.fecIniContrato ) AS diasVencidos,

	if(d.observacion is null,'',d.observacion) as CodigoAntiguo,
	
	IFNULL((Select dA.guiaSalida as GuiaAntigua
	From salida_det dA inner join laptop_cpu lc on dA.idLC=lc.idLC
	where dA.IdSalida=d.idSalida and lc.codigo=d.observacion), '') as GuiaAntigua,
	
	IFNULL((Select dA.idSalidaDet as IdSalidaDetAntigua
	From salida_det dA inner join laptop_cpu lc on dA.idLC=lc.idLC
	where dA.IdSalida=d.idSalida and lc.codigo=d.observacion), '') as IdSalidaDetAntigua
		
From salida s INNER JOIN salida_det d on s.idSalida=d.idSalida
		LEFT JOIN vista_maestro_sucursal_cliente sc on s.idSucursal=sc.idSucursal
		left join  vista_maestro_laptops lc on d.idLC=lc.idLC
		left join  vista_maestro_procesador p on d.idProcesador=p.idProcesador 
		left join vista_maestro_video v on d.idVideo=v.idVideo ,
		cuota cu 
where d.fueDevuelto=0 and d.estado=4
and  (DATEDIFF( d.fecFinContrato , CURDATE())>=0  )
		AND
			CASE WHEN d.caracteristicas='' THEN
				CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c)
			ELSE
				CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c) and
				(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c )
			END
union


Select d.idSalidaDet as IdSalidaDetalle,
		s.idSucursal as IdSucursal,
		s.idSalida as IdSalida,
		d.idLC as IdLC,
		d.fecIniContrato as fecIniContrato,
		d.fecFinContrato as fecFinContrato,
		s.idCliente as IdCliente,
		sc.nombreCliente as Cliente,
		sc.nombreContacto as Contacto,
		sc.direccion as DireccionCliente,
		sc.telefono as TelefonoContacto,
		lc.idMarca as idMarca,
		lc.marca as MarcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as NombreModeloLC,
		lc.codigo as Codigo,
		lc.tamanoPantalla as TamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as TipoProcesador,
		p.generacion as GeneracionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as NombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as CapacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo,
		
		d.guiaSalida AS guia,
		cu.numFactura AS factura,
		cu.fecInicioPago AS fecInicioFactura,
		cu.fecFinPago AS fecFinFactura,
		cu.totalSoles AS MontoSoles,
		cu.totalDolares AS MontoDolares,
		ROUND((cu.totalDolares+(cu.totalSoles/3.5)),2) AS TotalDolares,
		DATEDIFF( CURDATE(), cu.fecFinPago ) AS diasVencidos,

	if(d.observacion is null,'',d.observacion) as CodigoAntiguo,
	
	IFNULL((Select dA.guiaSalida as GuiaAntigua
	From salida_det dA inner join laptop_cpu lc on dA.idLC=lc.idLC
	where dA.IdSalida=d.idSalida and lc.codigo=d.observacion), '') as GuiaAntigua,
	
	IFNULL((Select dA.idSalidaDet as IdSalidaDetAntigua
	From salida_det dA inner join laptop_cpu lc on dA.idLC=lc.idLC
	where dA.IdSalida=d.idSalida and lc.codigo=d.observacion), '') as IdSalidaDetAntigua		
		
From salida s INNER JOIN salida_det d on s.idSalida=d.idSalida
		LEFT JOIN vista_maestro_sucursal_cliente sc on s.idSucursal=sc.idSucursal
		left join  vista_maestro_laptops lc on d.idLC=lc.idLC
		left join  vista_maestro_procesador p on d.idProcesador=p.idProcesador 
		left join vista_maestro_video v on d.idVideo=v.idVideo ,
		cuota cu 
where d.fueDevuelto=0 and d.estado=4
and  (DATEDIFF( d.fecFinContrato , CURDATE())>=0  )
		AND
			CASE WHEN d.caracteristicas='' THEN
				CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) 
			ELSE
				CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) or
				(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) = CONCAT( cu.idLC, '-', cu.idSalida )
			END
ORDER BY Cliente ;

create view vista_laptops_cuadro_vencimiento_bk as
Select d.idSalidaDet as IdSalidaDetalle,
		s.idSucursal as IdSucursal,
		s.idSalida as IdSalida,
		d.idLC as IdLC,
		d.fecIniContrato as fecIniContrato,
		d.fecFinContrato as fecFinContrato,
		s.idCliente as IdCliente,
		sc.nombreCliente as Cliente,
		sc.nombreContacto as Contacto,
		sc.direccion as DireccionCliente,
		sc.telefono as TelefonoContacto,
		lc.idMarca as idMarca,
		lc.marca as MarcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as NombreModeloLC,
		lc.codigo as Codigo,
		lc.tamanoPantalla as TamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as TipoProcesador,
		p.generacion as GeneracionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as NombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as CapacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo,
		
		d.guiaSalida AS guia,
		'' AS factura,
		'' AS fecInicioFactura,
		'' AS fecFinFactura,
		0 AS MontoSoles,
		0 AS MontoDolares,
		0 AS TotalDolares,
		DATEDIFF( CURDATE(), d.fecIniContrato ) AS diasVencidos
		
From salida s INNER JOIN salida_det d on s.idSalida=d.idSalida
		LEFT JOIN vista_maestro_sucursal_cliente sc on s.idSucursal=sc.idSucursal
		left join  vista_maestro_laptops lc on d.idLC=lc.idLC
		left join  vista_maestro_procesador p on d.idProcesador=p.idProcesador 
		left join vista_maestro_video v on d.idVideo=v.idVideo ,
		cuota cu 
where d.fueDevuelto=0 and d.estado=4
and  (DATEDIFF( d.fecFinContrato , CURDATE())>=0  )
		AND
			CASE WHEN d.caracteristicas='' THEN
				CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c)
			ELSE
				CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c) and
				(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c )
			END
union


Select d.idSalidaDet as IdSalidaDetalle,
		s.idSucursal as IdSucursal,
		s.idSalida as IdSalida,
		d.idLC as IdLC,
		d.fecIniContrato as fecIniContrato,
		d.fecFinContrato as fecFinContrato,
		s.idCliente as IdCliente,
		sc.nombreCliente as Cliente,
		sc.nombreContacto as Contacto,
		sc.direccion as DireccionCliente,
		sc.telefono as TelefonoContacto,
		lc.idMarca as idMarca,
		lc.marca as MarcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as NombreModeloLC,
		lc.codigo as Codigo,
		lc.tamanoPantalla as TamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as TipoProcesador,
		p.generacion as GeneracionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as NombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as CapacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo,
		
		d.guiaSalida AS guia,
		cu.numFactura AS factura,
		cu.fecInicioPago AS fecInicioFactura,
		cu.fecFinPago AS fecFinFactura,
		cu.totalSoles AS MontoSoles,
		cu.totalDolares AS MontoDolares,
		ROUND((cu.totalDolares+(cu.totalSoles/3.5)),2) AS TotalDolares,
		DATEDIFF( CURDATE(), cu.fecFinPago ) AS diasVencidos
		
From salida s INNER JOIN salida_det d on s.idSalida=d.idSalida
		LEFT JOIN vista_maestro_sucursal_cliente sc on s.idSucursal=sc.idSucursal
		left join  vista_maestro_laptops lc on d.idLC=lc.idLC
		left join  vista_maestro_procesador p on d.idProcesador=p.idProcesador 
		left join vista_maestro_video v on d.idVideo=v.idVideo ,
		cuota cu 
where d.fueDevuelto=0 and d.estado=4
and  (DATEDIFF( d.fecFinContrato , CURDATE())>=0  )
		AND
			CASE WHEN d.caracteristicas='' THEN
				CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) 
			ELSE
				CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) or
				(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) = CONCAT( cu.idLC, '-', cu.idSalida )
			END
ORDER BY IdCliente ;


create view vista_laptops_por_vencer as
Select d.idSalidaDet as IdSalidaDetalle,
		s.idSucursal as IdSucursal,
		d.idLC as IdLC,
		d.fecIniContrato as fecIniContrato,
		d.fecFinContrato as fecFinContrato,
		s.idCliente as IdCliente,
		sc.nombreCliente as Cliente,
		sc.nombreContacto as Contacto,
		sc.direccion as DireccionCliente,
		sc.telefono as TelefonoContacto,
		lc.idMarca as idMarca,
		lc.marca as MarcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as NombreModeloLC,
		lc.codigo as Codigo,
		lc.tamanoPantalla as TamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as TipoProcesador,
		p.generacion as GeneracionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as NombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as CapacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo
From salida s INNER JOIN salida_det d on s.idSalida=d.idSalida
		LEFT JOIN vista_maestro_sucursal_cliente sc on s.idSucursal=sc.idSucursal
		left join  vista_maestro_laptops lc on d.idLC=lc.idLC
		left join  vista_maestro_procesador p on d.idProcesador=p.idProcesador 
		left join vista_maestro_video v on d.idVideo=v.idVideo 
where d.fueDevuelto=0 and d.estado=4
and  (DATEDIFF( d.fecFinContrato , CURDATE())<7 and DATEDIFF( d.fecFinContrato , CURDATE())>=0  )
ORDER BY lc.idLC ;




DROP view IF EXISTS vista_inventario_laptops;
create view vista_inventario_laptops as
SELECT lc.idLC as idLC,
		lc.idMarca as idMarca,
		lc.marca as marcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as nombreModeloLC,
		lc.codigo as codigo,
		lc.tamanoPantalla as tamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as tipoProcesador,
		p.generacion as generacionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as nombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as capacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo,
		lc.partNumber as partNumber,
		lc.serieFabrica as serieFabrica,
		lc.garantia as garantia,
		lc.fecInicioSeguro as fecInicioSeguro,
		lc.fecFinSeguro as fecFinSeguro,
		lc.ubicacion as idUbicacionSucursal,
		lc.observacion as observacion,
		lc.estado as idEstado,
		(SELECT nombreEstado from estados e where lc.estado=e.idEstado) as estado,
		IFNULL((SELECT direccion from cliente_sucursal cs where lc.ubicacion=cs.IdSucursal),lc.ubicacion) as ubicacion,
		IFNULL((SELECT ct.nombre_razonSocial from cliente ct inner join cliente_sucursal cs on ct.idCliente=cs.idCliente where lc.ubicacion=cs.IdSucursal),'') as cliente,
		IFNULL(d.idSalida,'') as idSalida
FROM vista_maestro_laptops lc 
		left join  vista_maestro_procesador p on lc.idProcesador=p.idProcesador 
		left join vista_maestro_video v on lc.idVideo=v.idVideo 
		left join salida_det d on lc.idLC=d.idLC and d.estado=6 and d.fueDevuelto=0
ORDER BY lc.idLC;



DROP view IF EXISTS vista_inventario_memoria;
create view vista_inventario_memoria as
Select 	me.idMemoria as IdMemoria,
		ma.nombre as categoria,
		m.nombre as TipoMemoria,
		me.busFrecuencia as frecuencia,
		me.capacidad as Capacidad,
		me.cantidad as Cantidad,
		me.tipo as Tipo2,
		me.estado as estado
From memoria me
	inner join modelo m on m.idModelo = me.idModelo
	inner join marca ma on m.idMarca = ma.idMarca;


DROP view IF EXISTS vista_inventario_discos;
create view vista_inventario_discos as
Select 	d.idDisco as IdDisco,
		m.nombre as TipoDisco,
		d.tamano as Tamano,
		d.capacidad as Capacidad,
		d.cantidad as Cantidad,
		d.estado as Estado
From disco_duro d
	inner join modelo m on m.idModelo = d.idModelo ;


DROP view IF EXISTS vista_laptops_danados;
create view vista_laptops_danados as
SELECT  lc.codigo as codigo,
		lc.idLC as idLC,
		lc.marca as marcaLC,
		lc.nombreModelo as nombreModeloLC,
		lc.observacion as observacion,
		lc.estado as idEstado,
		(select nombreEstado from estados e where e.idEstado=lc.estado) as nombreEstado
FROM vista_maestro_laptops lc 
where lc.estado=3 and lc.ubicacion='ALMACEN'
ORDER BY lc.idLC;



DROP view IF EXISTS vista_lista_reparaciones;
create view vista_lista_reparaciones as
SELECT r.idReparacion AS IdReparacion,
			 r.idLC AS IdLC,
			 r.usuario_ins AS NombreResponsable,
			(SELECT u.nombre FROM usuario u WHERE u.usuario=r.usuario_ins) AS Responsable,
			 r.estado AS IdEstado,
			 r.codigoLC AS CodigoLC,
			 CAST(r.fec_ins AS DATE) AS FechaProceso,
			(SELECT e.nombreEstado FROM estados e WHERE e.IdEstado=r.estado) AS Estado,
			CAST(fechaReparacion as DATE) AS FechaReparacion,
			(SELECT e.nombreEstado FROM estados e WHERE e.IdEstado=r.estadoLCAnt) AS EstadoAntesReparacion,
			(SELECT e.nombreEstado FROM estados e WHERE e.IdEstado=r.estadoLCAct) AS EstadoLuegoReparacion,
			r.observacionActual AS DescripcionComoSeEncontro,
			r.observacionReparacion AS DescripcionReparacion
FROM reparacion r ;


DROP view IF EXISTS vista_lista_observaciones;
create view vista_lista_observaciones as
Select o.idObservacionDeudas as IdObservacion,
			o.idCliente as IdCliente,
			(Select c.nombre_razonSocial From cliente c Where c.idCliente=o.idCliente) as Cliente,
			(Select c.nroDocumento From cliente c Where c.idCliente=o.idCliente) as RUC,
			o.idLC as IdLC,
			(Select lc.codigo From laptop_cpu lc Where lc.idLC=o.IdLC) as CodigoLC,
			IFNULL(o.idDevolucion, 0) AS IdDevolucion,
			IFNULL(o.idCambio, 0) AS IdCambio,
			o.observacionDeuda as ObservacionDeuda,
			o.guiaLevantamiento as GuiaLevantamiento,
			o.observacionLevantamiento as ObservacionLevantamiento,
			o.fechaLevantamiento as FechaLevantamiento,
			o.estado as IdEstado,
			(Select e.nombreEstado From estados e where e.idEstado=o.estado) as Estado
From observacion_deudas o ;


DROP view IF EXISTS vista_procesador_marca;
create view vista_procesador_marca as
SELECT
	m.idMarca as IdMarca,
	m.nombre as Nombre,
	m.idCategoria as IdCategoria,
	m.estado as Estado
FROM marca m 
WHERE m.idCategoria = 9  
	AND m.estado = 1 ;

DROP view IF EXISTS vista_salida_tipo;
create view vista_salida_tipo as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="SALIDA_TIPO" and activo=1;




DROP view IF EXISTS vista_laptops_disponibles_danados;
create view vista_laptops_disponibles_danados as

SELECT
	0 as IdSalidaDet,
	lc.codigo AS codigo,
	lc.idLC AS idLC,
	lc.marca AS marcaLC,
	lc.nombreModelo AS nombreModeloLC,
	lc.observacion AS observacion,
	lc.estado AS idEstado,
	(	SELECT e.nombreEstado FROM	estados e WHERE	( e.idEstado = lc.estado )) AS nombreEstado 
FROM
	vista_maestro_laptops lc 
WHERE
		lc.estado = 2 or lc.estado = 3

UNION

SELECT 
		d.idSalidaDet as IdSalidaDet,
		lc.codigo AS codigo,
		lc.idLC AS idLC,
		lc.marca AS marcaLC,
		lc.nombreModelo AS nombreModeloLC,
		lc.observacion AS observacion,
		lc.estado AS idEstado,
		(	SELECT e.nombreEstado FROM	estados e WHERE	( e.idEstado = lc.estado )) AS nombreEstado 
FROM salida_det d 
		INNER JOIN vista_maestro_laptops lc on d.idLC=lc.idLC 
where (d.estado=4 or d.estado=9) and d.fueDevuelto=0

ORDER BY
	codigo;
	
	
	
DROP view IF EXISTS vista_laptops_personal_prestamo;
create view vista_laptops_personal_prestamo as
SELECT
	lc.codigo AS codigo,
	lc.idLC AS idLC,
	lc.marca AS marcaLC,
	lc.nombreModelo AS nombreModeloLC,
	lc.observacion AS observacion,
	lc.estado AS idEstado,
	(	SELECT e.nombreEstado FROM	estados e WHERE	( e.idEstado = lc.estado )) AS nombreEstado 
FROM
	vista_maestro_laptops lc 
WHERE
		lc.estado = 12 or lc.estado = 13
ORDER BY
	lc.codigo;

DROP view IF EXISTS vista_estados_Venta_Personal_Prestamo;
create view vista_estados_Venta_Personal_Prestamo as
SELECT *
FROM
	estados
WHERE
		idEstado=5 or idEstado=12 or idEstado=13
ORDER BY
	nombreEstado;

DROP view IF EXISTS vista_estados_Disponible_Danado;
create view vista_estados_Disponible_Danado as
SELECT *
FROM
	estados
WHERE
		idEstado=2 or idEstado=3
ORDER BY
	nombreEstado;
	


--=============================================================================================================



DROP view IF EXISTS vista_tablet_procesador;
create view vista_tablet_procesador as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="TABLET_PROCESADOR" and activo=1;

DROP view IF EXISTS vista_tablet_sistema;
create view vista_tablet_sistema as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="TABLET_SISTEMA" and activo=1;

DROP view IF EXISTS vista_tablet_ram;
create view vista_tablet_ram as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="TABLET_RAM" and activo=1;

DROP view IF EXISTS vista_tablet_rom;
create view vista_tablet_rom as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="TABLET_ROM" and activo=1;

DROP view IF EXISTS vista_tablets_marca;
create view vista_tablets_marca as
Select m.idMarca, m.nombre
from marca m 
where m.idCategoria=3 and m.estado=1 ;

DROP view IF EXISTS vista_tablets_modelo;
create view vista_tablets_modelo as
Select m.idMarca, mo.idModelo, mo.nombre
from marca m INNER JOIN modelo mo on m.idMarca=mo.IdMarca
where m.idCategoria=3 and m.estado=1 ;

DROP view IF EXISTS vista_monitores_marca;
create view vista_monitores_marca as
Select m.idMarca, m.nombre
from marca m 
where m.idCategoria=4 and m.estado=1 ;

DROP view IF EXISTS vista_monitores_modelo;
create view vista_monitores_modelo as
Select m.idMarca, mo.idModelo, mo.nombre
from marca m INNER JOIN modelo mo on m.idMarca=mo.IdMarca
where m.idCategoria=4 and m.estado=1 ;

DROP view IF EXISTS vista_monitor_tipo;
create view vista_monitor_tipo as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="MONITOR_TIPO" and activo=1;

DROP view IF EXISTS vista_impresoras_marca;
create view vista_impresoras_marca as
Select m.idMarca, m.nombre
from marca m 
where m.idCategoria=5 and m.estado=1 ;

DROP view IF EXISTS vista_impresoras_modelo;
create view vista_impresoras_modelo as
Select m.idMarca, mo.idModelo, mo.nombre
from marca m INNER JOIN modelo mo on m.idMarca=mo.IdMarca
where m.idCategoria=5 and m.estado=1 ;

DROP view IF EXISTS vista_impresora_tipo;
create view vista_impresora_tipo as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="IMPRESORA_TIPO" and activo=1;

DROP view IF EXISTS vista_proyectores_marca;
create view vista_proyectores_marca as
Select m.idMarca, m.nombre
from marca m 
where m.idCategoria=6 and m.estado=1 ;

DROP view IF EXISTS vista_proyectores_modelo;
create view vista_proyectores_modelo as
Select m.idMarca, mo.idModelo, mo.nombre
from marca m INNER JOIN modelo mo on m.idMarca=mo.IdMarca
where m.idCategoria=6 and m.estado=1 ;

DROP view IF EXISTS vista_proyectores_tipo;
create view vista_proyectores_tipo as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="PROYECTOR_TIPO" and activo=1;

DROP view IF EXISTS vista_proyectores_resolucion;
create view vista_proyectores_resolucion as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="PROYECTOR_RESOLUCION" and activo=1;

DROP view IF EXISTS vista_proyectores_luminen;
create view vista_proyectores_luminen as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="PROYECTOR_LUMINEN" and activo=1;

DROP view IF EXISTS vista_ecram_marca;
create view vista_ecram_marca as
Select m.idMarca, m.nombre
from marca m 
where m.idCategoria=7 and m.estado=1 ;

DROP view IF EXISTS vista_ecram_modelo;
create view vista_ecram_modelo as
Select m.idMarca, mo.idModelo, mo.nombre
from marca m INNER JOIN modelo mo on m.idMarca=mo.IdMarca
where m.idCategoria=7 and m.estado=1 ;

DROP view IF EXISTS vista_ecram_tipo;
create view vista_ecram_tipo as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="ECRAM_TIPO" and activo=1;

DROP view IF EXISTS vista_proyector_ecram_categoria;
create view vista_proyector_ecram_categoria as
Select idCategoria as idAuxiliar, nombre as descripcion
From categoria
where idCategoria=6 or idCategoria=7 ;


DROP view IF EXISTS vista_laptop_cpu_categoria;
create view vista_laptop_cpu_categoria as
Select idCategoria as idAuxiliar, nombre as descripcion
From categoria
where idCategoria=1 or idCategoria=2 ;


DROP view IF EXISTS vista_ingresos_detalles_tablet_modificable;
create view vista_ingresos_detalles_tablet_modificable as
SELECT
	d.*,
	ma.nombre AS nombreMarca,
	mo.nombre AS nombreModelo,
	vtp.descripcion AS procesador,
	vts.descripcion AS sistema,
	vtro.descripcion AS rom,
	vtra.descripcion AS ram
FROM
	ingreso_det_tablet d
	INNER JOIN marca ma ON d.idMarca = ma.idMarca
	INNER JOIN modelo mo ON d.idModelo = mo.idModelo
	INNER join auxiliar vtp ON d.idProcesador=vtp.idAuxiliar and vtp.cod_tabla="TABLET_PROCESADOR"
	INNER join auxiliar vts ON d.idSO=vts.idAuxiliar and vts.cod_tabla="TABLET_SISTEMA"
	INNER join auxiliar vtro ON d.idRom=vtro.idAuxiliar and vtro.cod_tabla="TABLET_ROM"
	INNER join auxiliar vtra ON d.idRam=vtra.idAuxiliar and vtra.cod_tabla="TABLET_RAM";


DROP view IF EXISTS vista_ingresos_detalles_impresora_modificable;
create view vista_ingresos_detalles_impresora_modificable as
SELECT
	d.*,
	ma.nombre AS nombreMarca,
	mo.nombre AS nombreModelo
FROM
	ingreso_det_impresora d
	INNER JOIN marca ma ON d.idMarca = ma.idMarca
	INNER JOIN modelo mo ON d.idModelo = mo.idModelo;


DROP view IF EXISTS vista_ingresos_detalles_monitor_modificable;
create view vista_ingresos_detalles_monitor_modificable as
SELECT
	d.*,
	ma.nombre AS nombreMarca,
	mo.nombre AS nombreModelo
FROM
	ingreso_det_monitor d
	INNER JOIN marca ma ON d.idMarca = ma.idMarca
	INNER JOIN modelo mo ON d.idModelo = mo.idModelo;


DROP view IF EXISTS vista_ingresos_detalles_proyector_modificable;
create view vista_ingresos_detalles_proyector_modificable as
SELECT
	d.*,
	ma.nombre AS nombreMarca,
	mo.nombre AS nombreModelo,
	ca.nombre as tipoEquipoProyector
FROM
	ingreso_det_proyectorecram d
	INNER JOIN marca ma ON d.idMarca = ma.idMarca
	INNER JOIN modelo mo ON d.idModelo = mo.idModelo
	INNER JOIN categoria ca ON d.idTipoEquipo = ca.idCategoria;



DROP view IF EXISTS vista_cpus_marca;
create view vista_cpus_marca as
Select m.idMarca, m.nombre
from marca m 
where m.idCategoria=2 and m.estado=1 ;


DROP view IF EXISTS vista_cpus_modelo;
create view vista_cpus_modelo as
Select m.idMarca, mo.idModelo, mo.nombre
from marca m INNER JOIN modelo mo on m.idMarca=mo.IdMarca
where m.idCategoria=2 and m.estado=1 ;



DROP view IF EXISTS vista_ingresos_detalles_modificable;
create view vista_ingresos_detalles_modificable as
SELECT
	d.*,
	ma.nombre AS nombreMarca,
	mo.nombre AS nombreModelo,
	vp.tipo AS tipoProcesador,
	vp.generacion AS generacionProcesador,
	IFNULL( vv.nombreModelo, '' ) AS modeloVideo,
	IFNULL( vv.capacidad, '' ) AS capacidadVideo,
	IFNULL( vd1.capacidad, 0 ) AS CapacidadDisco1,
	IFNULL( vd1.tipo, '' ) AS TipoDisco1,
	IFNULL( vd1.tamano, '' ) AS TamanoDisco1,
	IFNULL( vd2.capacidad, 0 ) AS CapacidadDisco2,
	IFNULL( vd2.tipo, '' ) AS TipoDisco2,
	IFNULL( vd2.tamano, '' ) AS TamanoDisco2,
	IFNULL( m1.capacidad, 0 ) AS CapacidadMemoria1,
	IFNULL( m1.tipo, '' ) AS TipoMemoria1,
	IFNULL( m1.tipo2, '' ) AS Tipo2Memoria1,
	IFNULL( m2.capacidad, 0 ) AS CapacidadMemoria2,
	IFNULL( m2.tipo, '' ) AS TipoMemoria2,
	IFNULL( m2.tipo2, '' ) AS Tipo2Memoria2,
	IFNULL( m3.capacidad, 0 ) AS CapacidadMemoria3,
	IFNULL( m3.tipo, '' ) AS TipoMemoria3,
	IFNULL( m3.tipo2, '' ) AS Tipo2Memoria3,
	IFNULL( l1.Version, '' ) AS ModeloWindows,
	IFNULL( l1.Categoria, '' ) AS CategoriaWindows,
	IFNULL( l2.Version, '' ) AS ModeloOffice,
	IFNULL( l2.Categoria, '' ) AS CategoriaOffice,
	IFNULL( l3.Version, '' ) AS ModeloAntivirus,
	IFNULL( l3.Categoria, '' ) AS CategoriaAntivirus 
FROM
	ingreso_det d
	INNER JOIN marca ma ON d.idMarcaLC = ma.idMarca
	INNER JOIN modelo mo ON d.idModeloLC = mo.idModelo
	INNER JOIN vista_maestro_procesador vp ON d.idProcesador = vp.idProcesador
	LEFT JOIN vista_maestro_video vv ON d.idVideo = vv.idVideo
	LEFT JOIN vista_maestro_disco vd1 ON d.idDisco1 = vd1.idDisco
	LEFT JOIN vista_maestro_disco vd2 ON d.idDisco2 = vd2.idDisco
	LEFT JOIN vista_maestro_memoria m1 ON d.idMemoria1 = m1.idMemoria
	LEFT JOIN vista_maestro_memoria m2 ON d.idMemoria2 = m2.idMemoria
	LEFT JOIN vista_maestro_memoria m3 ON d.idMemoria3 = m3.idMemoria
	LEFT JOIN vista_maestro_licencias l1 ON d.idModeloWindows = l1.IdModelo
	LEFT JOIN vista_maestro_licencias l2 ON d.idModeloOffice = l2.IdModelo
	LEFT JOIN vista_maestro_licencias l3 ON d.idModeloAntivirus = l3.IdModelo ;

--===========================================================================	

DROP VIEW IF EXISTS vista_buscarV;
create view vista_buscarV as
SELECT c.nroDocumento, lc.codigo, d.guiaSalida, CONCAT(c.nroDocumento,"-",lc.codigo) as concatenado
FROM 
	salida_det d
	INNER JOIN salida s on d.idSalida=s.idSalida
	INNER JOIN laptop_cpu lc on d.idLC=lc.idLC
	INNER JOIN cliente c on s.idCliente=c.idCliente
where d.fueDevuelto=0 and d.estado=4
	and  DATEDIFF( d.fecFinContrato , CURDATE())>=0 

UNION

SELECT c.nroDocumento, lc.codigo, d.guiaSalida, CONCAT(c.nroDocumento,"-",lc.codigo) as concatenado
FROM 
	salida_det d
	INNER JOIN salida s on d.idSalida=s.idSalida
	INNER JOIN laptop_cpu lc on d.idLC=lc.idLC
	INNER JOIN cliente c on s.idCliente=c.idCliente
WHERE d.fueDevuelto = 0  
		AND ((d.estado = 4 AND ( to_days( d.fecFinContrato ) - to_days( curdate())) < 0 ) 
				OR d.estado = 9 ) 

UNION
				
SELECT c.nroDocumento, lc.codigo, d.guiaSalida, CONCAT(c.nroDocumento,"-",lc.codigo) as concatenado
FROM
	salida s
	INNER JOIN salida_det d ON s.idSalida = d.idSalida
	INNER JOIN laptop_cpu lc ON lc.idLC = d.idLC 
	INNER JOIN cliente c on s.idCliente=c.idCliente
WHERE
	d.estado = 4 
	AND
		CASE WHEN d.caracteristicas='' THEN
			CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c)
		ELSE
			CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c) and
			(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c )
		END
		
UNION

SELECT c.nroDocumento, lc.codigo, d.guiaSalida, CONCAT(c.nroDocumento,"-",lc.codigo) as concatenado
FROM
	salida s
	INNER JOIN salida_det d ON s.idSalida = d.idSalida
	INNER JOIN laptop_cpu lc ON lc.idLC = d.idLC
	INNER JOIN cliente c on s.idCliente=c.idCliente,
	cuota cu 
WHERE
	d.estado = 4 
	AND (( d.fecFinContrato = cu.fecFinPago AND d.corteAlquiler = 0 ) 	OR d.fecFinContrato > cu.fecFinPago) 
	AND cu.fecFinPago < curdate() 
	AND
		CASE WHEN d.caracteristicas='' THEN
			CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) 
		ELSE
			CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) or
			(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) = CONCAT( cu.idLC, '-', cu.idSalida )
		END;
		
--========================NOTA CREDITO======================================	

DROP VIEW IF EXISTS vista_facturas_activas;
create view vista_facturas_activas as
Select Distinct numFactura
from factura
where estado=1
order by numFactura;

DROP VIEW IF EXISTS vista_equipos_por_factura;
create view vista_equipos_por_factura as
Select f.*,
lc.idLC,
f.fecIniPago as fecIniPagoAntiguo,
f.fecFinPago as fecFinPagoAntiguo,
f.totalSoles As totalSolesAntiguo, 
f.totalDolares As totalDolaresAntiguo, 
f.costoSoles As costoSolesAntiguo, 
f.costoDolares As costoDolaresAntiguo
from factura f INNER JOIN laptop_cpu lc ON f.codigoLC=lc.codigo   
where f.estado=1
Order By codigoLC;

		
--======================FACTURAS TRANSITO=======================================	


DROP VIEW IF EXISTS vista_equipos_disponible_preAlquiler;
create view vista_equipos_disponible_preAlquiler as
Select *
From laptop_cpu
where estado=2 or estado=6
ORDER BY codigo;

DROP VIEW IF EXISTS vista_equipos_por_factura_codigo;
create view vista_equipos_por_factura_codigo as
Select *
From factura_transito
where estado=1 and codigoEquipo<>'001'
Order By codigoEquipo;

DROP VIEW IF EXISTS vista_equipos_por_factura_generico;
create view vista_equipos_por_factura_generico as
Select *
From factura_transito
where estado=1 and codigoEquipo='001'
Order By codigoEquipo;



--======================STEVEN=======================================



DROP view IF EXISTS vista_sedes;
create view vista_sedes as
SELECT s.idSede AS idSede,
		s.nombreSede AS nombreSede 
FROM sede s
WHERE s.estado = 1;
	

CREATE OR REPLACE VIEW vista_maestro_laptops AS SELECT
	l.idLC AS idLC,
	ma.idMarca AS idMarca,
	ma.nombre AS marca,
	m.idModelo AS idModelo,
	m.nombre AS nombreModelo,
	l.codigo AS codigo,
	l.tamanoPantalla AS tamanoPantalla,
	l.idProcesador AS idProcesador,
	l.idSede AS idSede,
	IF(l.idVideo IS NULL , 0, l.idVideo ) AS idVideo,
	l.partNumber AS partNumber,
	l.serieFabrica AS serieFabrica,
	l.garantia AS garantia,
	l.fecInicioSeguro AS fecInicioSeguro,
	l.fecFinSeguro AS fecFinSeguro,
	l.ubicacion AS ubicacion,
	l.observacion AS observacion,
	l.estado AS estado,
	ifnull( li.Version, '' ) AS VersionOffice 
From laptop_cpu l
	inner join modelo m on m.idModelo = l.idModelo
	inner join marca ma on m.idMarca = ma.idMarca
	left join vista_licencia_lista li on l.idLC = li.IdLC and li.IdCategoria = 13 ;
	
	
CREATE OR REPLACE VIEW vista_inventario_laptops AS SELECT
	lc.idLC AS idLC,
	lc.idMarca AS idMarca,
	lc.marca AS marcaLC,
	lc.idModelo AS idModelo,
	lc.nombreModelo AS nombreModeloLC,
	lc.codigo AS codigo,
	lc.tamanoPantalla AS tamanoPantalla,
	lc.idSede AS idSede,
	p.idProcesador AS idProcesador,
	p.marca AS marcaProcesador,
	p.idTipo AS idTipoProcesador,
	p.tipo AS tipoProcesador,
	p.idGeneracion AS idGeneracionProcesador,
	p.generacion AS generacionProcesador,
	IF (( v.idVideo IS NULL ), 0, v.idVideo ) AS idVideo,
	IF (( v.marca IS NULL ), '', v.marca ) AS marcaVideo,
	IF (( v.nombreModelo IS NULL ), '', v.nombreModelo ) AS nombreModeloVideo,
	IF (( v.capacidad IS NULL ), 0, v.capacidad ) AS capacidadVideo,
	IF (( v.tipo IS NULL ), '', v.tipo ) AS tipoVideo,
	lc.partNumber AS partNumber,
	lc.serieFabrica AS serieFabrica,
	lc.garantia AS garantia,
	lc.fecInicioSeguro AS fecInicioSeguro,
	lc.fecFinSeguro AS fecFinSeguro,
	lc.ubicacion AS idUbicacionSucursal,
	lc.observacion AS observacion,
	lc.estado AS idEstado,(
	SELECT e.nombreEstado 
	FROM estados e  WHERE ( lc.estado = e.idEstado )) AS estado,
	ifnull(( SELECT cs.direccion FROM cliente_sucursal cs WHERE ( lc.ubicacion = cs.idSucursal )), lc.ubicacion ) AS ubicacion,
	ifnull(( SELECT ct.nombre_razonSocial 
		FROM
			(
				cliente ct
				JOIN cliente_sucursal cs ON ((
						ct.idCliente = cs.idCliente 
					))) 
		WHERE
			( lc.ubicacion = cs.idSucursal )),
		'' 
	) AS cliente,
	ifnull((
		SELECT
			ct.nroDocumento 
		FROM
			(
				cliente ct
				JOIN cliente_sucursal cs ON ((
						ct.idCliente = cs.idCliente 
					))) 
		WHERE
			( lc.ubicacion = cs.idSucursal )),
		'' 
	) AS rucCliente,
IF
	((
			lc.estado = 4 
			),(
		SELECT
			salida_det.idSalida 
		FROM
			salida_det 
		WHERE
			( salida_det.idLC = lc.idLC ) 
		ORDER BY
			salida_det.fecIniContrato DESC 
			LIMIT 1 
			),
	NULL 
	) AS idSalidaAlquilado,
IF
	((
			d.idSalida IS NOT NULL 
			),(
		SELECT
			cast( salida.fecSalida AS date ) 
		FROM
			salida 
		WHERE
			( salida.idSalida = idSalidaAlquilado )),
	NULL 
	) AS fecTraslado,
	sd.nombreSede AS Sede 
FROM
	((((
					vista_maestro_laptops lc
					LEFT JOIN vista_maestro_procesador p ON ((
							lc.idProcesador = p.idProcesador 
						)))
				LEFT JOIN vista_maestro_video v ON ((
						lc.idVideo = v.idVideo 
					)))
			LEFT JOIN salida_det d ON (((
						lc.idLC = d.idLC 
						) 
					AND (
					d.estado IN ( 4, 6 )) 
				AND ( d.fueDevuelto = 0 ))))
		LEFT JOIN sede sd ON ((
				lc.idSede = sd.idSede 
			))) 
ORDER BY
	lc.idLC;


CREATE OR REPLACE VIEW vista_laptops_cuadro_vencimiento AS SELECT
	d.idSalidaDet AS IdSalidaDetalle,
	s.idSucursal AS IdSucursal,
	s.idSalida AS IdSalida,
	cast( s.fecSalida AS date ) AS FecPrimerTraslado,
	d.idLC AS IdLC,
	cast( d.fecIniContrato AS date ) AS fecIniContrato,
	cast( d.fecFinContrato AS date ) AS fecFinContrato,
	s.idCliente AS IdCliente,
	sc.nroDocumento AS ruc,
	sc.nombreCliente AS Cliente,
	sc.nombreContacto AS Contacto,
	sc.direccion AS DireccionCliente,
	sc.telefono AS TelefonoContacto,
	lc.idMarca AS idMarca,
	lc.marca AS MarcaLC,
	lc.idModelo AS idModelo,
	lc.nombreModelo AS NombreModeloLC,
	lc.codigo AS Codigo,
	lc.tamanoPantalla AS TamanoPantalla,
	lc.VersionOffice AS VersionOffice,
	p.idProcesador AS idProcesador,
	p.marca AS marcaProcesador,
	p.tipo AS TipoProcesador,
	p.generacion AS GeneracionProcesador,
IF
	(( v.idVideo IS NULL ), 0, v.idVideo ) AS idVideo,
IF
	(( v.marca IS NULL ), '', v.marca ) AS marcaVideo,
IF
	(( v.nombreModelo IS NULL ), '', v.nombreModelo ) AS NombreModeloVideo,
IF
	(( v.capacidad IS NULL ), 0, v.capacidad ) AS CapacidadVideo,
IF
	(( v.tipo IS NULL ), '', v.tipo ) AS tipoVideo,
	d.guiaSalida AS guia,
	'' AS factura,
	'' AS fecInicioFactura,
	'' AS fecFinFactura,
	0 AS MontoSoles,
	0 AS MontoDolares,
	0 AS TotalDolares,
	0 AS CostoSoles,
	0 AS CostoDolares,
	0 AS UBSoles,(
		to_days(
		curdate()) - to_days( d.fecIniContrato )) AS diasVencidos,
IF
	(( d.observacion IS NULL ), '', d.observacion ) AS CodigoAntiguo,(
	SELECT
		c.nombreKam 
	FROM
		cliente c 
	WHERE
	( c.idCliente = s.idCliente )) AS KAM,
	'' AS GuiaAntigua,
	0 AS IdSalidaDetAntigua 
FROM
	((((((
							salida s
							JOIN salida_det d ON ((
									s.idSalida = d.idSalida 
								)))
						LEFT JOIN vista_maestro_sucursal_cliente sc ON ((
								s.idSucursal = sc.idSucursal 
							)))
					LEFT JOIN vista_maestro_laptops lc ON ((
							d.idLC = lc.idLC 
						)))
				LEFT JOIN vista_maestro_procesador p ON ((
						d.idProcesador = p.idProcesador 
					)))
			LEFT JOIN vista_maestro_video v ON ((
					d.idVideo = v.idVideo 
				)))
		JOIN cuota cu 
	) 
WHERE
	((
			d.fueDevuelto = 0 
			) 
		AND ( d.estado = 4 ) 
		AND (( to_days( d.fecFinContrato ) - to_days( curdate())) >= 0 ) 
		AND (
			0 <> (
			CASE
					
					WHEN ( d.caracteristicas = '' ) THEN
					concat( d.idLC, '-', d.idSalida ) NOT IN ( SELECT concat( c.idLC, '-', c.idSalida ) FROM cuota c ) ELSE (
						concat( d.idLC, '-', d.idSalida ) NOT IN ( SELECT concat( c.idLC, '-', c.idSalida ) FROM cuota c ) 
						AND (
						SELECT
							concat( ca.idLCAntiguo, '-', d.idSalida ) 
						FROM
							cambio ca 
						WHERE
						( ca.idCambio = d.caracteristicas )) NOT IN ( SELECT concat( c.idLC, '-', c.idSalida ) FROM cuota c )) 
				END 
				))) UNION
	SELECT
		d.idSalidaDet AS IdSalidaDetalle,
		s.idSucursal AS IdSucursal,
		s.idSalida AS IdSalida,
		cast( s.fecSalida AS date ) AS FecPrimerTraslado,
		d.idLC AS IdLC,
		cast( d.fecIniContrato AS date ) AS fecIniContrato,
		cast( d.fecFinContrato AS date ) AS fecFinContrato,
		s.idCliente AS IdCliente,
		sc.nroDocumento AS ruc,
		sc.nombreCliente AS Cliente,
		sc.nombreContacto AS Contacto,
		sc.direccion AS DireccionCliente,
		sc.telefono AS TelefonoContacto,
		lc.idMarca AS idMarca,
		lc.marca AS MarcaLC,
		lc.idModelo AS idModelo,
		lc.nombreModelo AS NombreModeloLC,
		lc.codigo AS Codigo,
		lc.tamanoPantalla AS TamanoPantalla,
		lc.VersionOffice AS VersionOffice,
		p.idProcesador AS idProcesador,
		p.marca AS marcaProcesador,
		p.tipo AS TipoProcesador,
		p.generacion AS GeneracionProcesador,
	IF
		(( v.idVideo IS NULL ), 0, v.idVideo ) AS idVideo,
	IF
		(( v.marca IS NULL ), '', v.marca ) AS marcaVideo,
	IF
		(( v.nombreModelo IS NULL ), '', v.nombreModelo ) AS NombreModeloVideo,
	IF
		(( v.capacidad IS NULL ), 0, v.capacidad ) AS CapacidadVideo,
	IF
		(( v.tipo IS NULL ), '', v.tipo ) AS tipoVideo,
		d.guiaSalida AS guia,
		cu.numFactura AS factura,
		cast( cu.fecInicioPago AS date ) AS fecInicioFactura,
		cast( cu.fecFinPago AS date ) AS fecFinFactura,
		cu.totalSoles AS MontoSoles,
		cu.totalDolares AS MontoDolares,
		round(( cu.totalDolares + ( cu.totalSoles / 3.5 )), 2 ) AS TotalDolares,
		cu.costoSoles AS CostoSoles,
		cu.costoDolares AS CostoDolares,((
				3.5 * ( cu.totalDolares - cu.costoDolares )) + ( cu.totalSoles - cu.costoSoles )) AS UBSoles,(
			to_days(
			curdate()) - to_days( cu.fecFinPago )) AS diasVencidos,
	IF
		(( d.observacion IS NULL ), '', d.observacion ) AS CodigoAntiguo,(
		SELECT
			c.nombreKam 
		FROM
			cliente c 
		WHERE
		( c.idCliente = s.idCliente )) AS KAM,
		'' AS GuiaAntigua,
		0 AS IdSalidaDetAntigua 
	FROM
		((((((
								salida s
								JOIN salida_det d ON ((
										s.idSalida = d.idSalida 
									)))
							LEFT JOIN vista_maestro_sucursal_cliente sc ON ((
									s.idSucursal = sc.idSucursal 
								)))
						LEFT JOIN vista_maestro_laptops lc ON ((
								d.idLC = lc.idLC 
							)))
					LEFT JOIN vista_maestro_procesador p ON ((
							d.idProcesador = p.idProcesador 
						)))
				LEFT JOIN vista_maestro_video v ON ((
						d.idVideo = v.idVideo 
					)))
			JOIN cuota cu 
		) 
	WHERE
		((
				d.fueDevuelto = 0 
				) 
			AND ( d.estado = 4 ) 
			AND (( to_days( d.fecFinContrato ) - to_days( curdate())) >= 0 ) 
			AND (
				0 <> (
				CASE
						
						WHEN ( d.caracteristicas = '' ) THEN
						(
							concat( d.idLC, '-', d.idSalida ) = concat( cu.idLC, '-', cu.idSalida )) ELSE ((
							concat( d.idLC, '-', d.idSalida ) = concat( cu.idLC, '-', cu.idSalida )) 
							OR ((
								SELECT
									concat( ca.idLCAntiguo, '-', d.idSalida ) 
								FROM
									cambio ca 
								WHERE
								( ca.idCambio = d.caracteristicas )) = concat( cu.idLC, '-', cu.idSalida ))) 
					END 
					))) 
	ORDER BY
	IdCliente;


DROP view IF EXISTS `vista_reporte_facturas`;
create view vista_reporte_facturas as
SELECT
	f.numFactura AS NumeroFactura,
	f.fecIniPago AS FechaInicioFactura,
	f.fecFinPago AS FechaFinFactura,
	f.fecEmisiom AS FechaEmisionFactura,
	c.nombre_razonSocial AS Cliente,
	f.ruc AS RucCliente,
	f.codigoLC AS CodigoEquipo, 
	f.guiaSalida AS GuiaSalida, 
	f.totalSoles AS TotalSoles, 
	f.totalDolares AS TotalDolares, 
	f.costoSoles AS CostoSoles, 
	f.costoDolares AS CostoDolares,
	ROUND((3.6*(f.totalDolares-f.costoDolares))+(f.totalSoles-f.costoSoles),2)	as UBSoles,
	IF(f.estado=1,"VIGENTE","ANULADA") AS EstadoFactura
FROM
	factura f
LEFT JOIN cliente c on f.ruc=c.nroDocumento
ORDER BY fecEmisiom DESC;

--============================Movimientos Internos Ventas==================================================================

DROP view IF EXISTS vista_laptops_disponibles_danados;
create view vista_laptops_disponibles_danados as

SELECT
	0 as IdSalidaDet,
	lc.codigo AS codigo,
	lc.idLC AS idLC,
	lc.marca AS marcaLC,
	lc.nombreModelo AS nombreModeloLC,
	lc.observacion AS observacion,
	lc.estado AS idEstado,
	(	SELECT e.nombreEstado FROM	estados e WHERE	( e.idEstado = lc.estado )) AS nombreEstado 
FROM
	vista_maestro_laptops lc 
WHERE
		lc.estado = 2 or lc.estado = 3

UNION

SELECT 
		d.idSalidaDet as IdSalidaDet,
		lc.codigo AS codigo,
		lc.idLC AS idLC,
		lc.marca AS marcaLC,
		lc.nombreModelo AS nombreModeloLC,
		lc.observacion AS observacion,
		lc.estado AS idEstado,
		(	SELECT e.nombreEstado FROM	estados e WHERE	( e.idEstado = lc.estado )) AS nombreEstado 
FROM salida_det d 
		INNER JOIN vista_maestro_laptops lc on d.idLC=lc.idLC 
where (d.estado=4 or d.estado=9) and d.fueDevuelto=0

ORDER BY
	codigo;
	
--==========================Cambio Razon Social==============================
DROP view IF EXISTS vista_equipos_en_alquiler;
create view vista_equipos_en_alquiler as
Select 
		d.idSalida as IdSalida,
		d.idSalidaDet as IdSalidaDetalle,
		d.guiaSalida AS GuiaSalida,
		s.idSucursal as IdSucursal,
		d.idLC as IdEquipo,
		lc.codigo as CodigoEquipo,
		d.fecIniContrato as FechaPlazoInicial,
		d.fecFinContrato as FechaPlazoFinal,
		s.idCliente as IdCliente,
		lc.marca as Marca,
		lc.nombreModelo as Modelo
From salida s INNER JOIN salida_det d on s.idSalida=d.idSalida
		left join  vista_maestro_laptops lc on d.idLC=lc.idLC
where d.fueDevuelto=0 and d.estado=4
ORDER BY CodigoEquipo ;
	
--==========================Steven Reporte de Alquiler==============================

DROP view IF EXISTS `vista_reportes_alquileres`;
create view vista_reportes_alquileres as
SELECT 
sd.idSalida as IdSalida,
sd.idSalidaDet as idSalidaDet,
s.idCliente as IdCliente,
s.IdSucursal as IdSucursal,
s.rucDni as RucDni,
c.nombre_razonSocial as Cliente,
sd.IdLC as IdLC,
lc.codigo as Codigo,
s.fecSalida as FecSalida,
sd.fecIniContrato as FecIniContrato,
sd.fecFinContrato as FecFinContrato,
sd.guiaSalida as GuiaSalida,
sd.estado as Estado,
e.nombreEstado as NombreEstado,
if(sd.estado=4,if(sd.fueDevuelto=1,"SI","NO"),if(ca.fueDevuelto=1,"SI","NO")) as FueDevuelto,
if(sd.estado=9 and ca.fueDevuelto=1,ca.fechaCambio,"") as FechaCambio,
if(sd.estado=4 and sd.fueDevuelto=1,d.fechaDevolucion,"") as FechaDevolucion,
if(sd.estado=4 and sd.fueDevuelto=1,d.guiaDevolucion,"") as GuiaDevolucion,
if(sd.estado=4 and sd.corteAlquiler=1,"SI",if(sd.estado=9,"","NO")) as CorteAlquiler,
cu.numFactura AS UltimaFactura,
cu.fecInicioPago as FecInicioFactura,
cu.fecFinPago as FecFinFactura,
cu.fecEmisiom as FechaEmisionFactura
FROM salida_det sd
LEFT JOIN salida s ON s.idSalida=sd.idSalida
LEFT JOIN estados e ON e.idEstado=sd.estado
LEFT JOIN laptop_cpu lc ON lc.idLC=sd.IdLC
LEFT JOIN cliente c ON c.idCliente=s.idCliente
LEFT JOIN devolucion_det dd ON dd.idSalidaDet=sd.idSalidaDet and dd.idLC=sd.idLC
LEFT JOIN devolucion d ON d.idDevolucion=dd.idDevolucion 
LEFT JOIN cambio ca ON ca.idSalidaDet=sd.idSalidaDet
LEFT JOIN cuota cu ON cu.idSalida=sd.idSalida and cu.ruc=s.rucDni and cu.codigoLC=lc.codigo and cu.guiaSalida=sd.guiaSalida;

--===================================Tipo de Cambio=================================

DROP VIEW IF EXISTS vista_equipos_por_factura_codigo;
create view vista_equipos_por_factura_codigo as
Select *
From factura_transito
where estado=1 and codigoEquipo<>'001'
Order By codigoEquipo;

DROP VIEW IF EXISTS vista_equipos_por_factura_generico;
create view vista_equipos_por_factura_generico as
Select *
From factura_transito
where estado=1 and codigoEquipo='001'
Order By codigoEquipo;

Select * from vista_factura_CV ;
,
	`d`.`corteAlquiler` AS `CorteAlquiler`;
	



--======================CONTACTOS=======================================	
DROP VIEW IF EXISTS vista_contacto_tipo;
create view vista_contacto_tipo as	
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="CONTACTO_TIPO" and activo=1;

DROP VIEW IF EXISTS vista_maestro_Contacto_Cliente;
create view vista_maestro_Contacto_Cliente as
Select 	cc.idContacto as IdContacto,
		cc.idCliente as IdCliente,
		c.nombre_razonSocial as NombreCliente,
		c.nroDocumento as DocumentoCliente,
		cc.idTipoContacto as IdTipoContacto,
		(Select descripcion from auxiliar where cod_tabla='CONTACTO_TIPO' and idAuxiliar=cc.idTipoContacto) AS TipoContacto,
		cc.nombre as NombreContacto,
		cc.email as Email,
		cc.telefono as Telefono,
		cc.anexo as Anexo,
		cc.cargo as Cargo,
		cc.observacion as Observacion,
		cc.estado as IdEstado,
		if((cc.estado=1),'ACTIVO','DESACTIVO') AS Estado
from cliente c left join cliente_contacto cc  on c.idCliente=cc.idCliente;



SELECT
	(Select c.nombre_razonSocial from cliente c where c.nroDocumento=d.rucDni) as cliente,
	d.fechaDevolucion,
	dd.codigoLC 
FROM
	devolucion_det dd
	INNER JOIN devolucion d ON dd.idDevolucion = d.idDevolucion 
WHERE
	idSalidaDet IN ( SELECT idSalidaDet FROM salida_det WHERE corteAlquiler = 0 AND estado = 4 AND fueDevuelto = 1 );
	
	
	
	
	
	
--Reporte de equipos que han sido devueltos sin tener corte de alquiler	
SELECT
	(Select c.nombre_razonSocial from cliente c where c.nroDocumento=d.rucDni) as cliente,
	d.fechaDevolucion,
	dd.codigoLC,
	dd.idSalidaDet, fecIniContrato, fecInicioPago, fecFinContrato ,fecFinPago
FROM
	devolucion_det dd
	INNER JOIN devolucion d ON dd.idDevolucion = d.idDevolucion 
	inner join salida_det sd on dd.idSalidaDet=sd.idSalidaDet
	inner join cuota c on sd.idSalida=c.idSalida and sd.idLC=c.idLC
WHERE
	dd.idSalidaDet IN ( SELECT idSalidaDet FROM salida_det WHERE corteAlquiler = 0 AND estado = 4 AND fueDevuelto = 1 );
	
SELECT
	idSalidaDet, fecIniContrato, fecInicioPago, fecFinContrato ,fecFinPago
FROM
	salida_det d inner join cuota c on d.idSalida=c.idSalida and d.idLC=c.idLC
WHERE
	d.corteAlquiler = 0 
	AND d.estado = 4 
	AND d.fueDevuelto = 1;
	
	
	
	
	
--Reporte de Ingresos	
SELECT
	i.facturaIngreso,
	i.razonSocial,
	i.fecIngresa,
	lc.codigo,
	lc.idModelo,
	(Select modelo.nombre from modelo where modelo.idModelo=lc.idModelo) as Modelo,
	(Select marca.nombre from marca inner join modelo on marca.idMarca=modelo.idMarca where modelo.idModelo=lc.idModelo) as Marca
FROM
	ingreso i
	INNER JOIN laptop_cpu lc ON i.idIngreso = lc.idIngreso;	






--==========================================vista_productos_por_facturar_bk2=======================
SELECT	
	(SELECT	c.nombre_razonSocial 	FROM	cliente c 	WHERE		( c.idCliente = s.idCliente )) AS cliente,
	(SELECT	c.nroDocumento FROM	cliente c WHERE	( c.idCliente = s.idCliente )) AS ruc,
	d.fecIniContrato AS fecIniPlazoAlquiler,
	d.fecFinContrato AS fecFinPlazoAlquiler,
	'' AS factura,
	'' AS fecInicioFactura,
	'' AS fecFinFactura,
	0 AS TotalSoles,
	0 AS TotalDolares,
	0 AS CostoSoles,
	0 AS CostoDolares,
	0 AS PendienteFacturarSoles,
	0 AS PendienteFacturarDolares,
	0 AS PendienteFacturarUtilidadSoles,
	s.idSalida AS idSalida,
	d.idSalidaDet AS idSalidaDet,
	concat(d.idSalidaDet,'*',s.idSalida,'*',d.guiaSalida,'*',(SELECT c.nroDocumento FROM cliente c  WHERE ( c.idCliente = s.idCliente )), '*', lc.codigo  ) AS CONCAT,
	IF(( t.tarifa IS NOT NULL ), t.tarifa, 0 ) AS TARIFA,
	lc.codigo AS codigoEquipo,
	d.guiaSalida AS guia,
	(	to_days(curdate()) - to_days( d.fecIniContrato )) AS diasVencidos,
	TRUNCATE (((( to_days( curdate()) - to_days( d.fecIniContrato )) / 30 ) + 0.99 ), 0 ) AS Periodos,
	0 AS NuevaDeudaSoles,
	(SELECT	c.nombreKam FROM cliente c WHERE ( c.idCliente = s.idCliente )) AS KAM,
	IF (( d.observacion IS NULL ), '', d.observacion ) AS CodigoAntiguo,
	'' AS GuiaAntigua,
	0 AS IdSalidaDetAntigua,
	lc.idMarca AS idMarca,
	lc.marca AS MarcaLC,
	lc.idModelo AS idModelo,
	lc.nombreModelo AS NombreModeloLC,
	lc.codigo AS Codigo,
	lc.tamanoPantalla AS TamanoPantalla,
	lc.VersionOffice AS VersionOffice,
	lc.VersionWindows AS VersionWindows,
	p.idProcesador AS idProcesador,
	p.marca AS marcaProcesador,
	p.tipo AS TipoProcesador,
	p.generacion AS GeneracionProcesador,
	IF (( v.idVideo IS NULL ), 0, v.idVideo ) AS idVideo,
	IF (( v.marca IS NULL ), '', v.marca ) AS marcaVideo,
	IF (( v.nombreModelo IS NULL ), '', v.nombreModelo ) AS NombreModeloVideo,
	IF (( v.capacidad IS NULL ), 0, v.capacidad ) AS CapacidadVideo,
	IF (( v.tipo IS NULL ), '', v.tipo ) AS tipoVideo,
	lc.idLC AS idLC,
	IF (( d.corteAlquiler = 1 ), 'SI', 'NO' ) AS CorteAlquiler 
FROM
	(((((	salida s
						JOIN salida_det d ON ((
								s.idSalida = d.idSalida 
							)))
					JOIN vista_maestro_laptops lc ON ((
							lc.idLC = d.idLC 
						)))
				LEFT JOIN vista_maestro_procesador p ON ((
						lc.idProcesador = p.idProcesador 
					)))
			LEFT JOIN vista_maestro_video v ON ((
					lc.idVideo = v.idVideo 
				)))
		LEFT JOIN tarifa t ON ((
				concat(
					t.idsalidadet,
					'*',
					t.idsalida,
					'*',
					t.guiaSalida,
					'*',
					t.rucCliente,
					'*',
					t.codigoLC 
					) = concat(
					d.idSalidaDet,
					'*',
					s.idSalida,
					'*',
					d.guiaSalida,
					'*',(
					SELECT
						c.nroDocumento 
					FROM
						cliente c 
					WHERE
					( c.idCliente = s.idCliente )),
					'*',
					lc.codigo 
				)))) 
WHERE
	((
			d.estado = 4 
			) 
		AND (
			0 <> (
			CASE
					
					WHEN ( d.caracteristicas = '' ) THEN
					concat( d.idLC, '-', d.idSalida ) NOT IN ( SELECT concat( c.idLC, '-', c.idSalida ) FROM cuota c ) ELSE (
						concat( d.idLC, '-', d.idSalida ) NOT IN ( SELECT concat( c.idLC, '-', c.idSalida ) FROM cuota c ) 
						AND (
						SELECT
							concat( ca.idLCAntiguo, '-', d.idSalida ) 
						FROM
							cambio ca 
						WHERE
						( ca.idCambio = d.caracteristicas )) NOT IN ( SELECT concat( c.idLC, '-', c.idSalida ) FROM cuota c )) 
				END 
				))) 
				
UNION
				
SELECT
	(SELECT c.nombre_razonSocial FROM cliente c WHERE ( c.idCliente = s.idCliente )) AS cliente,
	(SELECT c.nroDocumento FROM cliente c WHERE ( c.idCliente = s.idCliente )) AS ruc,
	d.fecIniContrato AS fecIniPlazoAlquiler,
	d.fecFinContrato AS fecFinPlazoAlquiler,
	cu.numFactura AS factura,
	cu.fecInicioPago AS fecInicioFactura,
	cu.fecFinPago AS fecFinFactura,
	cu.totalSoles AS TotalSoles,
	cu.totalDolares AS TotalDolares,
	cu.costoSoles AS CostoSoles,
	cu.costoDolares AS CostoDolares,
	(ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30)) * cu.totalSoles) AS PendienteFacturarSoles,
	(ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30)) * cu.totalDolares) AS PendienteFacturarDolares,(
	ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30)) * (((( cu.totalDolares * 3.6 ) - ( cu.costoDolares * 3.6 )) + cu.totalSoles ) - cu.costoSoles )) AS PendienteFacturarUtilidadSoles,
	s.idSalida AS idSalida,
	d.idSalidaDet AS idSalidaDet,
	concat(d.idSalidaDet,'*',s.idSalida,'*',d.guiaSalida,'*',(
	SELECT c.nroDocumento  FROM cliente c  WHERE ( c.idCliente = s.idCliente )), '*', lc.codigo ) AS CONCAT,
	IF ((t.tarifa IS NOT NULL),	t.tarifa,(ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30)) * (((( cu.totalDolares * 3.6 ) - ( cu.costoDolares * 3.6 )) + cu.totalSoles ) - cu.costoSoles ))) AS TARIFA,
	lc.codigo AS codigoEquipo,
	d.guiaSalida AS guia,
	(to_days(curdate()) - to_days( cu.fecFinPago )) AS diasVencidos,
	TRUNCATE (((( to_days( curdate()) - to_days( cu.fecFinPago )) / 30 ) + 0.99 ), 0 ) AS Periodos,
	IF((t.tarifa IS NOT NULL ),IF((t.moneda = 'SOLES'), round(((t.tarifa - t.costo) * TRUNCATE (((( to_days( curdate()) - to_days( cu.fecFinPago )) / 30 ) + 0.99 ), 0 )),2), round((((t.tarifa - t.costo) * 3.6) * TRUNCATE (((( to_days( curdate()) - to_days( cu.fecFinPago )) / 30 ) + 0.99 ), 0 )),2)),round(((((cu.totalDolares * 3.6) - ( cu.costoDolares * 3.6 )) + ( cu.totalSoles - cu.costoSoles )) * TRUNCATE (((( to_days( curdate()) - to_days( cu.fecFinPago )) / 30 ) + 0.99 ), 0 )),2)) AS NuevaDeudaSoles,
	(SELECT c.nombreKam FROM cliente c WHERE ( c.idCliente = s.idCliente )) AS KAM,
	IF (( d.observacion IS NULL ), '', d.observacion ) AS CodigoAntiguo,
	'' AS GuiaAntigua,
	0 AS IdSalidaDetAntigua,
	lc.idMarca AS idMarca,
	lc.marca AS MarcaLC,
	lc.idModelo AS idModelo,
	lc.nombreModelo AS NombreModeloLC,
	lc.codigo AS Codigo,
	lc.tamanoPantalla AS TamanoPantalla,
	lc.VersionOffice AS VersionOffice,
	lc.VersionWindows AS VersionWindows,
	p.idProcesador AS idProcesador,
	p.marca AS marcaProcesador,
	p.tipo AS TipoProcesador,
	p.generacion AS GeneracionProcesador,
	IF (( v.idVideo IS NULL ), 0, v.idVideo ) AS idVideo,
	IF (( v.marca IS NULL ), '', v.marca ) AS marcaVideo,
	IF (( v.nombreModelo IS NULL ), '', v.nombreModelo ) AS NombreModeloVideo,
	IF (( v.capacidad IS NULL ), 0, v.capacidad ) AS CapacidadVideo,
	IF (( v.tipo IS NULL ), '', v.tipo ) AS tipoVideo,
		lc.idLC AS idLC,
	IF (( d.corteAlquiler = 1 ), 'SI', 'NO' ) AS CorteAlquiler 
	FROM
		((((((
								salida s
								JOIN salida_det d ON ((
										s.idSalida = d.idSalida 
									)))
							JOIN vista_maestro_laptops lc ON ((
									lc.idLC = d.idLC 
								)))
						LEFT JOIN vista_maestro_procesador p ON ((
								lc.idProcesador = p.idProcesador 
							)))
					LEFT JOIN vista_maestro_video v ON ((
							lc.idVideo = v.idVideo 
						)))
				LEFT JOIN tarifa t ON t.idsalidadet=d.idSalidaDet)
			JOIN cuota cu 
		) 
	WHERE
		((
				d.estado = 4 
				) 
			AND (((
						d.fecFinContrato = cu.fecFinPago 
						) 
					AND ( d.corteAlquiler = 0 )) 
			OR ( d.fecFinContrato > cu.fecFinPago )) 
			AND (
			cu.fecFinPago < curdate()) 
			AND (
				0 <> (
				CASE
						
						WHEN ( d.caracteristicas = '' ) THEN
						(
							concat( d.idLC, '-', d.idSalida ) = concat( cu.idLC, '-', cu.idSalida )) ELSE ((
							concat( d.idLC, '-', d.idSalida ) = concat( cu.idLC, '-', cu.idSalida )) 
							OR ((
								SELECT
									concat( ca.idLCAntiguo, '-', d.idSalida ) 
								FROM
									cambio ca 
								WHERE
								( ca.idCambio = d.caracteristicas )) = concat( cu.idLC, '-', cu.idSalida ))) 
					END 
					))) 
		ORDER BY
		cliente,
	codigoEquipo




--=============================Nuevo Pendiente por facturar======================================



DROP VIEW IF EXISTS vista_productos_por_facturar;
create view vista_productos_por_facturar as
SELECT	
	(SELECT	c.nombre_razonSocial FROM cliente c WHERE c.idCliente = s.idCliente) AS cliente,
	(SELECT	c.nombreKam FROM cliente c WHERE ( c.idCliente = s.idCliente )) AS KAM,
	(SELECT	c.nroDocumento FROM	cliente c WHERE	c.idCliente = s.idCliente) AS ruc,
	d.fecIniContrato AS fecIniPlazoAlquiler,
	d.fecFinContrato AS fecFinPlazoAlquiler,
	'' AS factura,
	'' AS fecInicioFactura,
	'' AS fecFinFactura,
	0 AS TotalSoles,
	0 AS TotalDolares,
	0 AS CostoSoles,
	0 AS CostoDolares,
	s.idSalida AS idSalida,
	d.idSalidaDet AS idSalidaDet,
	d.guiaSalida AS guia,	
	lc.codigo AS codigoEquipo,
	ifnull(d.observacion, '' ) AS CodigoAntiguo,
	ifnull(t.tarifa, 0 ) AS TARIFA,
	ifnull(t.costo, 0 ) AS costo,
	ifnull(t.moneda, 0 ) AS moneda,
	3.6 AS tipoCambio,
	(to_days(curdate()) - to_days( d.fecIniContrato)) AS diasVencidos,
	(ceiling(((to_days(curdate()) - to_days( d.fecIniContrato )) / 30))) AS Periodos,
	IF((t.tarifa IS NOT NULL ),
		IF((t.moneda = 'SOLES'), 
			round(((t.tarifa - t.costo) * (ceiling(((to_days(curdate()) - to_days( d.fecIniContrato )) / 30)))),2),
			round((((t.tarifa - t.costo) * 3.6) * (ceiling(((to_days(curdate()) - to_days( d.fecIniContrato )) / 30)))),2)),
		0) AS NuevaDeudaSoles,
	'' AS GuiaAntigua,
	0 AS IdSalidaDetAntigua,
	lc.idMarca AS idMarca,
	lc.marca AS MarcaLC,
	lc.idModelo AS idModelo,
	lc.nombreModelo AS NombreModeloLC,
	lc.codigo AS Codigo,
	lc.tamanoPantalla AS TamanoPantalla,
	lc.VersionOffice AS VersionOffice,
	lc.VersionWindows AS VersionWindows,
	p.idProcesador AS idProcesador,
	p.marca AS marcaProcesador,
	p.tipo AS TipoProcesador,
	p.generacion AS GeneracionProcesador,
	ifnull( v.idVideo, 0 ) AS idVideo,
	ifnull( v.marca, '' ) AS marcaVideo,
	ifnull( v.nombreModelo, '' ) AS NombreModeloVideo,
	ifnull( v.capacidad, 0 ) AS CapacidadVideo,
	ifnull( v.tipo, '' ) AS tipoVideo,
	lc.idLC AS idLC,
	IF (( d.corteAlquiler = 1 ), 'SI', 'NO' ) AS CorteAlquiler 
FROM
	salida s
	INNER JOIN salida_det d ON s.idSalida = d.idSalida 
	INNER JOIN vista_maestro_laptops lc ON lc.idLC = d.idLC 
	LEFT JOIN vista_maestro_procesador p ON lc.idProcesador = p.idProcesador 
	LEFT JOIN vista_maestro_video v ON lc.idVideo = v.idVideo 
	LEFT JOIN tarifa t ON t.idsalidadet=d.idSalidaDet
WHERE
	((
		d.estado = 4 
		) 
	AND (
		0 <> (
		CASE
				
			WHEN ( d.caracteristicas = '' ) THEN
			concat( d.idLC, '-', d.idSalida ) NOT IN ( SELECT concat( c.idLC, '-', c.idSalida ) FROM cuota c ) ELSE (
				concat( d.idLC, '-', d.idSalida ) NOT IN ( SELECT concat( c.idLC, '-', c.idSalida ) FROM cuota c ) 
				AND (
				SELECT
					concat( ca.idLCAntiguo, '-', d.idSalida ) 
				FROM
					cambio ca 
				WHERE
				( ca.idCambio = d.caracteristicas )) NOT IN ( SELECT concat( c.idLC, '-', c.idSalida ) FROM cuota c )) 
			END 
			))) 
				
UNION
				
SELECT
	(SELECT c.nombre_razonSocial FROM cliente c WHERE ( c.idCliente = s.idCliente )) AS cliente,
	(SELECT c.nombreKam FROM cliente c WHERE ( c.idCliente = s.idCliente )) AS KAM,
	(SELECT c.nroDocumento FROM cliente c WHERE ( c.idCliente = s.idCliente )) AS ruc,
	d.fecIniContrato AS fecIniPlazoAlquiler,
	d.fecFinContrato AS fecFinPlazoAlquiler,
	cu.numFactura AS factura,
	cu.fecInicioPago AS fecInicioFactura,
	cu.fecFinPago AS fecFinFactura,
	cu.totalSoles AS TotalSoles,
	cu.totalDolares AS TotalDolares,
	cu.costoSoles AS CostoSoles,
	cu.costoDolares AS CostoDolares,
	s.idSalida AS idSalida,
	d.idSalidaDet AS idSalidaDet,
	d.guiaSalida AS guia,
	lc.codigo AS codigoEquipo,
	ifnull(d.observacion, '' ) AS CodigoAntiguo,
	ifnull(t.tarifa, 0 ) AS TARIFA,
	ifnull(t.costo, 0 ) AS costo,
	ifnull(t.moneda, 0 ) AS moneda,
	3.6 AS tipoCambio,
	(to_days(curdate()) - to_days( cu.fecFinPago )) AS diasVencidos,
	(ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30))) AS Periodos,
	IF((t.tarifa IS NOT NULL ),
		IF((t.moneda = 'SOLES'), 
			round(((t.tarifa - t.costo) * (ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30)))),2),
			round((((t.tarifa - t.costo) * 3.6) * (ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30)))),2)),
		0) AS NuevaDeudaSoles,
	'' AS GuiaAntigua,
	0 AS IdSalidaDetAntigua,
	lc.idMarca AS idMarca,
	lc.marca AS MarcaLC,
	lc.idModelo AS idModelo,
	lc.nombreModelo AS NombreModeloLC,
	lc.codigo AS Codigo,
	lc.tamanoPantalla AS TamanoPantalla,
	lc.VersionOffice AS VersionOffice,
	lc.VersionWindows AS VersionWindows,
	p.idProcesador AS idProcesador,
	p.marca AS marcaProcesador,
	p.tipo AS TipoProcesador,
	p.generacion AS GeneracionProcesador,
	ifnull( v.idVideo, 0 ) AS idVideo,
	ifnull( v.marca, '' ) AS marcaVideo,
	ifnull( v.nombreModelo, '' ) AS NombreModeloVideo,
	ifnull( v.capacidad, 0 ) AS CapacidadVideo,
	ifnull( v.tipo, '' ) AS tipoVideo,
	lc.idLC AS idLC,
	IF (( d.corteAlquiler = 1 ), 'SI', 'NO' ) AS CorteAlquiler 
	FROM
		salida s
		INNER JOIN salida_det d ON s.idSalida = d.idSalida 
		INNER JOIN vista_maestro_laptops lc ON lc.idLC = d.idLC 
		LEFT JOIN vista_maestro_procesador p ON lc.idProcesador = p.idProcesador 
		LEFT JOIN vista_maestro_video v ON lc.idVideo = v.idVideo 
		LEFT JOIN tarifa t ON t.idsalidadet=d.idSalidaDet
		JOIN cuota cu 
	WHERE
		((
			d.estado = 4 
			) 
		AND (((
					d.fecFinContrato = cu.fecFinPago 
					) 
				AND ( d.corteAlquiler = 0 )) 
		OR ( d.fecFinContrato > cu.fecFinPago )) 
		AND (
		cu.fecFinPago < curdate()) 
		AND (
			0 <> (
			CASE
					
				WHEN ( d.caracteristicas = '' ) THEN
				(
					concat( d.idLC, '-', d.idSalida ) = concat( cu.idLC, '-', cu.idSalida )) ELSE ((
					concat( d.idLC, '-', d.idSalida ) = concat( cu.idLC, '-', cu.idSalida )) 
					OR ((
						SELECT
							concat( ca.idLCAntiguo, '-', d.idSalida ) 
						FROM
							cambio ca 
						WHERE
						( ca.idCambio = d.caracteristicas )) = concat( cu.idLC, '-', cu.idSalida ))) 
				END 
				))) 
		ORDER BY
		cliente,
	codigoEquipo

--======================CORTE ALQUILER=======================================	


DROP VIEW IF EXISTS vista_reporte_corte_alquiler;
create view vista_reporte_corte_alquiler as
SELECT c.fec_ins AS FechaProceso,
	(SELECT nroDocumento FROM cliente where cliente.idCliente=c.idCliente) AS RUC,
	c.codigoEquipo AS Codigo,
	c.motivoCorte AS MotivoCorte,
	c.fecRecojo AS FechaRecojo,
	c.fecFinContratoNew AS FechaCorteAlquiler,
	c.idCorteAlquiler AS IdCorteAlquiler,
	c.estado AS IdEstado,
	if((c.estado=1),'ACTIVO','ANULADO') AS NombreEstado,
	ifnull((SELECT c1.fecFinPago AS fecFinPago 
		FROM cuota c1 JOIN laptop_cpu lc ON c1.idLC = lc.idLC
		WHERE c.idSalida = c1.idSalida AND  lc.idLC = c.idEquipo),
		ifnull((SELECT c2.fecFinPago AS fecFinPago 
			FROM cuota c2 JOIN laptop_cpu lc2 ON c2.idLC = lc2.idLC
			WHERE c.idSalida = c2.idSalida AND lc2.codigo = c.codigoEquipoAntiguo),
			'' 
		)) AS FechaUltimaFactura ,
	(Select d.FueDevuelto from salida_det d where c.idSalidaDet=d.idSalidaDet ) AS FueDevuelto
FROM corte_alquiler c;


Vista cuadro de venciomiento
--vista_laptops_cuadro_vencimiento
	,
	if((d.corteAlquiler=1),'SI','NO') AS CorteAlquiler

where
	AND --ELIMINAR ESTA PARTE
		CASE WHEN d.motivoCorte='DEVOLUCIÓN' THEN
			(( to_days( `d`.`fecRecojo` ) - to_days( curdate()) - 1) >= 0 ) 
		ELSE
			(( to_days( `d`.`fecFinContrato` ) - to_days( curdate())) >= 0 )
		END
		
	

Vista Pendiente por recoger
--vista_productos_por_recoger	
		
	IFNULL(d.personaContacto,sc.nombreContacto) AS `Contacto`,
	IFNULL(d.direccionRecojo,sc.direccion) AS `DireccionCliente`,
	IFNULL(d.telefono,sc.telefono) AS `TelefonoContacto`,
	IFNULL(d.fecRecojo,'') AS `FechaRecojo`,
	
	,
	IF(d.estado = 9, 'CAMBIO', IF(d.motivoCorte='DEVOLUCIÓN','DEVOLUCIÓN','OTRO MOTIVO') ) AS MotivoRecojo 

where 
	AND (
			(
				(d.estado = 4 ) 
				AND 
					CASE WHEN d.motivoCorte='DEVOLUCIÓN' AND (( to_days( `d`.`fecRecojo` ) - to_days( d.fecFinContrato) - 1) < 0 )  THEN
						(( to_days( `d`.`fecRecojo` ) - to_days( curdate()) - 1) < 0 ) 
					ELSE
						(( to_days( d.fecFinContrato) - to_days( curdate())) < 0 )
					END
				
			)
			OR 
			( d.estado = 9 )
		) 
		



Vista Pronosticador
--vista_pronosticador	
WHERE
	d.fueDevuelto = 0 
	AND d.estado = 4
	AND d.corteAlquiler = 1 
	AND d.motivoCorte='DEVOLUCIÓN'	
	
	
	
	
	
	
--================Esto es para el dash cuando se implemente la tarifas=========


SELECT
	d.idSalidaDet AS IdSalidaDet,
	cli.nombre_razonSocial AS cliente,
	cli.nroDocumento AS ruc,
	IF((t.tarifa IS NOT NULL ),
		IF((t.moneda = 'SOLES'), 
			round(((t.tarifa - t.costo) * (ceiling(((to_days(curdate()) - to_days( d.fecIniContrato )) / 30)))),2),
			round((((t.tarifa - t.costo) * 3.6) * (ceiling(((to_days(curdate()) - to_days( d.fecIniContrato )) / 30)))),2)),
		0) AS PendienteFacturarSoles,
	IF((t.tarifa IS NOT NULL ),
		IF((t.moneda = 'SOLES'), 
			round(((t.tarifa - t.costo) * (ceiling(((to_days(curdate()) - to_days( d.fecIniContrato )) / 30)))),2),
			round((((t.tarifa - t.costo) * 3.6) * (ceiling(((to_days(curdate()) - to_days( d.fecIniContrato )) / 30)))),2)),
		0) AS DeudaSoles,
	(to_days(curdate()) - to_days( d.fecIniContrato )) AS diasVencidos
FROM
	salida s
	INNER JOIN salida_det d ON s.idSalida = d.idSalida 
	INNER JOIN cliente cli ON cli.idCliente = s.idCliente 
	LEFT JOIN tarifa t ON d.idSalidaDet=t.idsalidadet
WHERE
	d.estado = 4 
	AND
		CASE WHEN d.caracteristicas='' THEN
			CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c)
		ELSE
			CONCAT( d.idLC, '-', d.idSalida ) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c) and
			(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) NOT IN ( SELECT CONCAT( c.idLC, '-', c.idSalida ) FROM cuota c )
		END
				
UNION

SELECT
	d.idSalidaDet AS IdSalidaDet,
	cli.nombre_razonSocial AS cliente,
	cli.nroDocumento AS ruc,
	IF((t.tarifa IS NOT NULL ),
		IF((t.moneda = 'SOLES'), 
			round(((t.tarifa - t.costo) * (ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30)))),2),
			round((((t.tarifa - t.costo) * 3.6) * (ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30)))),2)),
		0) AS PendienteFacturarSoles,
	IF((t.tarifa IS NOT NULL ),
		IF((t.moneda = 'SOLES'), 
			round(((t.tarifa - t.costo) * (ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30)))),2),
			round((((t.tarifa - t.costo) * 3.6) * (ceiling(((to_days(curdate()) - to_days( cu.fecFinPago )) / 30)))),2)),
		0) AS DeudaSoles,
	(to_days(curdate()) - to_days( cu.fecFinPago )) AS diasVencidos
FROM
	salida s
	INNER JOIN salida_det d ON s.idSalida = d.idSalida 
	INNER JOIN cliente cli ON cli.idCliente = s.idCliente 
	LEFT JOIN tarifa t ON d.idSalidaDet=t.idsalidadet
	JOIN cuota cu 
WHERE
	d.estado = 4 
	AND ((d.fecFinContrato = cu.fecFinPago AND  d.corteAlquiler = 0 ) OR  d.fecFinContrato > cu.fecFinPago ) 
	AND cu.fecFinPago < curdate()
	AND
		CASE WHEN d.caracteristicas='' THEN
			CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) 
		ELSE
			CONCAT( d.idLC, '-', d.idSalida )= CONCAT( cu.idLC, '-', cu.idSalida ) or
			(SELECT CONCAT( ca.IdLCAntiguo, '-', d.idSalida ) from cambio ca where ca.IdCambio=d.caracteristicas) = CONCAT( cu.idLC, '-', cu.idSalida )
		END
ORDER BY
cliente;



























CUADRO VENCIMIENTO
CV ESTÁN TODOS LOS EQUIPOS QUE ESTAN EN EL CLIENTE, A EXCEPCION DE LOS EQUIPOS DE CAMBIO.

		NO LES IMPORTE LA FECHA SUGERIDA NI EL CORTE DE ALQUILER
CV NO DEBERÍA ESTAR AMARRADA A LA FECHA SUGERIDA DE RECOJO
LAS LAPTOPS NO PUEDE DEPENDER DE UNA FECHA ARBITRARIA REGISTRADA POR UNA PERSONA.


PENDIENTE RECOGER
ES UN SUBCONJUNTO DEL CV, Y YA DEBERÍAN ESTAR RECGOEINDO SEGUN SU CORTE DE ALQUILER O LA FECHA SUGERIDA.
EQUIPOS CAMBIADOS QUE NO HAN SIDO DEVUELTO

EQUIPOS QUE NO SE HAN RECOGIDO CONTABILIZADOS DESDE UN DÍA ANTES DE LA FECHA SUGERIDA DE RECOJO.
EQUIPOS QUE YA PASARON SU CORTE DE ALQUILER Y SON POR MOTIVO DE CAMBIO DE RAZON SOCIAL O VENTA. NI BIEN SE HACE DEVOLUCION O SE GRABA LA VENTA, DESAPARECE.

PENDIENTE POR FACTURAR
ES UN SUBCONJUNTO, CASI UN 99%, DEL CV. SON TODOS LOS EQUIPOS QUE ESTAN EN EL CLIENTE Y DEBEN ALGUN PERIODO DE FACTURACION.
EQUIPOS QUE YA SE HAN DEVUELTO, PERO TODAVÍA NO LE GRABARON SU CORTE DE ALQUILER. ESE CASO NO DEBERÍA DE SUCEDER. EJEMPLO: CUANDO ALGUIEN NO UTILIZA EL APOLO PARA SOLICITAR EL RECOJO. LO CUAL ES UN ERROR EN EL PROCESO.

En el CV se tendrá que quitar la condicion de fechas, con eso, siempre estará, tenga o no corte de alquiler.
En el Pendiente por Recoger, se tendrá que cambiar un poco la condición y poner la siguiente lógica:
	FECHA SUGERIDA ES MENOR AL CORTE DE ALQUILER QUE SE GUIE DE LA FECHA SUGERIDA
	CASO CONTRARIO QUE SE GUIE DEL CORTE DE ALQUILER


					CASE WHEN d.motivoCorte='DEVOLUCIÓN' (( to_days( d.fecFinContrato) - to_days( curdate())) < 0 )AND THEN
						(( to_days( `d`.`fecRecojo` ) - to_days( curdate()) - 1) < 0 ) 
					ELSE
						(( to_days( d.fecFinContrato) - to_days( curdate())) < 0 )
					END

Select * from salida_det WHERE fueDevuelto=0 and corteAlquiler=1 and estado=4 and idSalidaTipo is null;


Select * from salida_det where fueDevuelto=0 and corteAlquiler=1 and estado=4 and motivoCorte is null;
DEVOLUCIÓN

UPDATE salida_det
set motivoCorte='DEVOLUCIÓN'
where fueDevuelto=0 and corteAlquiler=1 and estado=4 and motivoCorte is null;

