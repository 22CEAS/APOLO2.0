﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using MySql.Data.MySqlClient;
namespace AccesoDatos
{
    public class IngresoDA
    {
        DBManager objManager;
        MySqlParameter[] parametrosEntrada = null;
        MySqlParameter[] parametrosEntrada_aux = null;
        MySqlParameter[] parametrosEntrada_aux_2 = null;
        int IdCategoriaWindows = 12;
        int IdCategoriaOffice = 13;
        int IdCategoriaAntivirus = 14;

        private int idMarcaApple = 1;
        private int idTipoProyector = 6; 

        public IngresoDA()
        {
            objManager = new DBManager();
        }

        public DataTable ListarEstados()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM estados ; ");
        }

        public DataTable ListarLaptopCpuTipo()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_laptop_cpu_categoria ;");
        }

        public DataTable ListarDiscosDuros()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_disco ;");
        }

        public DataTable ListarProcesadores()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_procesador ;");
        }

        public DataTable ListarMemorias()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_memoria ;");
        }

        public DataTable ListarTarjetaVideos()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_video ;");
        }

        public DataTable ListarLicencias()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_licencias ;");
        }

        public DataTable ListarLicenciasSO()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_licencias where IdCategoria= " + this.IdCategoriaWindows + " ;");
        }

        public DataTable ListarLaptopsMarcas()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_laptops_marca ;");
        }

        public DataTable ListarLaptopsModelos(int idMarca)
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_laptops_modelo where idMarca=" + idMarca + " ;");
        }

        public DataTable ListarCpusMarcas()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_cpus_marca ;");
        }

        public DataTable ListarCpusModelos(int idMarca)
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_cpus_modelo where idMarca=" + idMarca + " ;");
        }

        public DataTable ListarTabletMarcas()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_tablets_marca ;");
        }

        public DataTable ListarTabletModelos(int idMarca)
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_tablets_modelo where idMarca=" + idMarca + " ;");
        }

        public DataTable ListarTabletProcesadores()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_tablet_procesador ;");
        }

        public DataTable ListarTabletSistemas()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_tablet_sistema ;");
        }

        public DataTable ListarTabletRAM()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_tablet_ram ;");
        }

        public DataTable ListarTabletROM()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_tablet_rom ;");
        }

        public DataTable ListarMonitorMarcas()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_monitores_marca ;");
        }

        public DataTable ListarMonitorModelos(int idMarca)
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_monitores_modelo where idMarca=" + idMarca + " ;");
        }

        public DataTable ListarMonitorTipo()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_monitor_tipo ;");
        }
        
        public DataTable ListarImpresoraMarcas()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_impresoras_marca ;");
        }

        public DataTable ListarImpresoraModelos(int idMarca)
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_impresoras_modelo where idMarca=" + idMarca + " ;");
        }

        public DataTable ListarImpresoraTipo()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_impresora_tipo ;");
        }
        
        public DataTable ListarProyectorMarcas()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_proyectores_marca ;");
        }

        public DataTable ListarProyectorModelos(int idMarca)
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_proyectores_modelo where idMarca=" + idMarca + " ;");
        }

        public DataTable ListarProyectorTipo()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_proyectores_tipo ;");
        }

        public DataTable ListarProyectorResolucion()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_proyectores_resolucion ;");
        }

        public DataTable ListarProyectorLuminen()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_proyectores_luminen ;");
        }

        public DataTable ListarProyectorEcramTipo()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_proyector_ecram_categoria ;");
        }
        
        public DataTable ListarEcramMarcas()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_ecram_marca ;");
        }

        public DataTable ListarEcramModelos(int idMarca)
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_ecram_modelo where idMarca=" + idMarca + " ;");
        }

        public DataTable ListarEcramTipo()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_ecram_tipo ;");
        }

        public DataTable ListarDestinos()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_maestro_disco ;");
        }

        public DataTable ListarProveedores()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_proveedor_lista ;");
        }

        public DataTable ListarIngresoTipo()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_ingreso_tipo ;");
        }

        public DataTable ListarMonedaTipo()
        {
            return objManager.MostrarTablaDatos("SELECT * FROM vista_moneda_tipo ;");
        }

        public DataTable ListarIngreso(string sql)
        {
            return objManager.MostrarTablaDatos("Select * from vista_lista_ingresos v " + sql + " ;");
        }

        public int InsertarIngreso(Ingreso ingreso, string usuario)
        {

            bool error = false;

            parametrosEntrada = new MySqlParameter[17];
            parametrosEntrada[0] = new MySqlParameter("@_idOC", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_idTipoIngreso", MySqlDbType.Int32);
            parametrosEntrada[2] = new MySqlParameter("@_tipoIngreso", MySqlDbType.VarChar, 255);
            parametrosEntrada[3] = new MySqlParameter("@_idProveedor", MySqlDbType.Int32);
            parametrosEntrada[4] = new MySqlParameter("@_razonSocial", MySqlDbType.VarChar, 255);
            parametrosEntrada[5] = new MySqlParameter("@_ruc", MySqlDbType.VarChar, 11);
            parametrosEntrada[6] = new MySqlParameter("@_facturaIngreso", MySqlDbType.VarChar, 255);
            parametrosEntrada[7] = new MySqlParameter("@_guiaIngreso", MySqlDbType.VarChar, 255);
            parametrosEntrada[8] = new MySqlParameter("@_fecIngresa", MySqlDbType.DateTime);
            parametrosEntrada[9] = new MySqlParameter("@_idTipoMoneda", MySqlDbType.Int32);
            parametrosEntrada[10] = new MySqlParameter("@_tipoMoneda", MySqlDbType.VarChar, 255);
            parametrosEntrada[11] = new MySqlParameter("@_montoCambio", MySqlDbType.Double);
            parametrosEntrada[12] = new MySqlParameter("@_total", MySqlDbType.Double);
            parametrosEntrada[13] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
            parametrosEntrada[14] = new MySqlParameter("@_estado", MySqlDbType.Int32);
            parametrosEntrada[15] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
            parametrosEntrada[16] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);

            parametrosEntrada[0].Value = 0;
            parametrosEntrada[1].Value = ingreso.IdTipoIngreso;
            parametrosEntrada[2].Value = ingreso.TipoIngreso;
            parametrosEntrada[3].Value = ingreso.IdProveedor;
            parametrosEntrada[4].Value = ingreso.RazonSocial;
            parametrosEntrada[5].Value = ingreso.Ruc;
            parametrosEntrada[6].Value = ingreso.Factura;
            parametrosEntrada[7].Value = ingreso.Guia;
            parametrosEntrada[8].Value = ingreso.FechaIngreso;
            parametrosEntrada[9].Value = ingreso.IdMonedaTipo;
            parametrosEntrada[10].Value = ingreso.MonedaTipo;
            parametrosEntrada[11].Value = ingreso.MontoCambio;
            parametrosEntrada[12].Value = ingreso.Total;
            parametrosEntrada[13].Value = ingreso.Observacion;
            parametrosEntrada[14].Value = ingreso.Estado;
            parametrosEntrada[15].Value = usuario;

            string[] datosSalida = new string[1];

            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso",
                16, 17, out datosSalida, 1);

            if (datosSalida != null)
            {
                ingreso.IdIngreso = Convert.ToInt32(datosSalida[0]);

                //Aqui ira la recursividad

                

                //! LOGICA PARA QUE EL CODIGO TENGA EL MES Y AÑO DE INGRESO
                DateTime fechaIngreso = Convert.ToDateTime(parametrosEntrada[8].Value);
                //MessageBox.Show(dtpFechaIngreso.Value.ToString());

                int month = fechaIngreso.Month;
                string year = fechaIngreso.Year.ToString();
                year = year.Substring(fechaIngreso.Year.ToString().Length-2,2);

                //MessageBox.Show($"El mes ingresado es el: {month.ToString("00")}");
                //MessageBox.Show($"El año ingresado es el: {year}");


                if (IngresosDetallesYAccesorios(ingreso, usuario, ingreso.IdProveedor,month,year) == -1) return -1;
            }
            return ingreso.IdIngreso;
        }

        public int IngresosDetallesYAccesorios(Ingreso ingreso, string usuario, int idProveedor,int month,string year)
        {
            bool error = false;

            string[] datosSalida = new string[1];
            string[] codigoArrendamientoExistente = new string[1];
            int idLC = 0;
            
            if (ingreso.Detalles.Count > 0)
            {
                error = InsertarIngresoDetalleLaptops(ingreso, usuario);
                if (error) return -1;

                foreach (IngresoDetalle det in ingreso.Detalles)
                {
                    for (int i = 0; i < det.Cantidad; i++)
                    {
                        //SI EXISTE EL CODIGO, BORRAR TODOS LOS REGISTROS Y QUE LUEGO SIGA CON EL FLUJO NORMAL
                        string[] cantidadArrendamiento = new string[1];

                        parametrosEntrada_aux_2 = new MySqlParameter[3];
                        parametrosEntrada_aux_2[0] = new MySqlParameter("@_codigoLapArrendamiento", MySqlDbType.VarChar, 255);
                        parametrosEntrada_aux_2[1] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                        parametrosEntrada_aux_2[2] = new MySqlParameter("@_idLC", MySqlDbType.Int32);

                        parametrosEntrada_aux_2[0].Value = det.Series[i];


                        //! VERIFICAR DEVOLUCION DE DATOS
                        objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada_aux_2, "verificarArrendamiento",
                                            1, 3, out cantidadArrendamiento, 2);
                        int cantidadDeArrendamientos = int.Parse(cantidadArrendamiento[0]); //VERIFICA SI EXISTE EL CODIGO
                        int idLCarrendamiento = int.Parse(cantidadArrendamiento[1]); //CODIGO LC EXISTENTE
                        //MessageBox.Show(cantidadDeArrendamientos.ToString());
                        //MessageBox.Show(idLCarrendamiento.ToString());

                        string aux = "";
                        string aux2 = "";
                        int codigoCorr = 0;

                        if (ingreso.TipoIngreso == "COMPRA")
                        {
                            //SI ES COMPRA
                            //LOGICA CORRELATIVO
                            string[] codigoSiguiente = new string[2];


                            parametrosEntrada_aux = new MySqlParameter[6];
                            parametrosEntrada_aux[0] = new MySqlParameter("@_marcaLap", MySqlDbType.VarChar, 80);
                            parametrosEntrada_aux[1] = new MySqlParameter("@_idProveedor", MySqlDbType.Int32);
                            parametrosEntrada_aux[2] = new MySqlParameter("@_monthIngreso", MySqlDbType.Int32);
                            parametrosEntrada_aux[3] = new MySqlParameter("@_yearIngreso", MySqlDbType.VarChar, 80);
                            parametrosEntrada_aux[4] = new MySqlParameter("@_proximoCodigo", MySqlDbType.Int32);
                            parametrosEntrada_aux[5] = new MySqlParameter("@_prefijo", MySqlDbType.VarChar, 80);


                            //! VALIDAR SI ES UNA LAP NORMAL O UNA MAC


                            //! VALIDAR SI ES UNA LAP NORMAL O UNA MAC

                            
                            
                            if (det.LaptopIdMarca == this.idMarcaApple) //APPLE  
                            {
                                parametrosEntrada_aux[0].Value = "PCR-MAC";
                            }
                            else
                            {
                                parametrosEntrada_aux[0].Value = "PCR-LAP";
                            }

                            parametrosEntrada_aux[1].Value = idProveedor;
                            parametrosEntrada_aux[2].Value = month;
                            parametrosEntrada_aux[3].Value = year;
                            //MessageBox.Show("ID DEL PROVEEDOR: "+idProveedor.ToString());



                            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada_aux, "obtener_codigo_correlativo",
                                            4, 6, out codigoSiguiente, 2);

                            aux = codigoSiguiente[0]; //CODIGO
                            aux2 = codigoSiguiente[1]; //PREFIJO

                            //MessageBox.Show($"El siguiente codigo es el: {aux} {aux2}");


                            codigoCorr = int.Parse(aux);

                            if (codigoSiguiente != null)
                            {
                                //VERIFICACION
                                //MessageBox.Show("El proximo codigo es el: "+(codigoCorr+1));
                                //MessageBox.Show("El proximo prefijo es el: " + aux2);
                            }
                            //FIN LOGICA CORRELATIVO

                        }

                        //AQUI PONER PROCEDURE DE CODIGO CORRELATIVO
<<<<<<< HEAD

                        

                        parametrosEntrada = new MySqlParameter[18];
=======
                        parametrosEntrada = new MySqlParameter[20];
>>>>>>> f2aae5a45f110363faf7fd5d1a13b9c1d10fbf25
                        parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                        parametrosEntrada[1] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);
                        parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                        parametrosEntrada[3] = new MySqlParameter("@_descripcion", MySqlDbType.VarChar, 250);
                        parametrosEntrada[4] = new MySqlParameter("@_tamanoPantalla", MySqlDbType.Double);
                        parametrosEntrada[5] = new MySqlParameter("@_idProcesador", MySqlDbType.Int32);
                        parametrosEntrada[6] = new MySqlParameter("@_idVideo", MySqlDbType.Int32);
                        parametrosEntrada[7] = new MySqlParameter("@_partNumber", MySqlDbType.VarChar, 80);
                        parametrosEntrada[8] = new MySqlParameter("@_serieFabrica", MySqlDbType.VarChar, 80);
                        parametrosEntrada[9] = new MySqlParameter("@_garantia", MySqlDbType.Int32);
                        parametrosEntrada[10] = new MySqlParameter("@_fecInicioSeguro", MySqlDbType.DateTime);
                        parametrosEntrada[11] = new MySqlParameter("@_fecFinSeguro", MySqlDbType.DateTime);
                        parametrosEntrada[12] = new MySqlParameter("@_ubicacion", MySqlDbType.VarChar, 80);
                        parametrosEntrada[13] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
                        parametrosEntrada[14] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                        parametrosEntrada[15] = new MySqlParameter("@_compraSubarriendo", MySqlDbType.Int16);
                        parametrosEntrada[16] = new MySqlParameter("@_codigo", MySqlDbType.VarChar, 80);
                        parametrosEntrada[17] = new MySqlParameter("@_idTipoEquipoLC", MySqlDbType.Int32);
                        parametrosEntrada[18] = new MySqlParameter("@_nombreTipoEquipoLC", MySqlDbType.VarChar, 255);
                        parametrosEntrada[19] = new MySqlParameter("@_idLC", MySqlDbType.Int32);

                        parametrosEntrada[0].Value = ingreso.IdIngreso;
                        parametrosEntrada[1].Value = det.IdIngresoDetalle;
                        parametrosEntrada[2].Value = det.LaptopIdModelo;
                        parametrosEntrada[3].Value = "";
                        parametrosEntrada[4].Value = det.LaptopTamanoPantalla;
                        parametrosEntrada[5].Value = det.Laptop.Procesador.IdProcesador;
                        if (det.Laptop.Video.IdVideo == 0)
                        {
                            parametrosEntrada[6].Value = null;
                        }
                        else
                        {
                            parametrosEntrada[6].Value = det.Laptop.Video.IdVideo;
                        }
                        parametrosEntrada[7].Value = det.Laptop.PartNumber;
                        parametrosEntrada[8].Value = det.Series[i];
                        parametrosEntrada[9].Value = det.Laptop.Garantia;
                        parametrosEntrada[10].Value = null;
                        parametrosEntrada[11].Value = null;
                        parametrosEntrada[12].Value = "ALMACEN";
                        parametrosEntrada[13].Value = det.Laptop.Observacion;
                        parametrosEntrada[14].Value = usuario;
                        parametrosEntrada[15].Value = ingreso.IdTipoIngreso;
                        if (ingreso.TipoIngreso == "COMPRA") //SI ES COMPRA
                        {
                            parametrosEntrada[16].Value = aux2 + (codigoCorr + 1).ToString("000");
                        }
                        else //SI ES ARRENDAMIENTO GUARDA LO QUE ELLOS HAN INGRESADO
                        {
                            //MessageBox.Show(det.Series[i]);
                            parametrosEntrada[16].Value = det.Series[i];
                        }

                        parametrosEntrada[17].Value = det.LaptopIdTipoEquipoLC;
                        parametrosEntrada[18].Value = det.LaptopTipoEquipoLC;

                        datosSalida = new string[1];
                        
                        //cantidadDeArrendamientos
                        if (ingreso.TipoIngreso == "COMPRA")
                        {
                            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_laptop_cpu",
                                19, 20, out datosSalida, 1);
                            idLC = Convert.ToInt32(datosSalida[0]);
                        }
                        else
                        {
                            if (cantidadDeArrendamientos == 0)
                            {
                                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_laptop_cpu",
                                19, 20, out datosSalida, 1);
                                idLC = Convert.ToInt32(datosSalida[0]);
                            }
                            else
                            {
                                idLC = idLCarrendamiento;
                            }
                        }
                        
                        if (datosSalida != null)
                        {
                            foreach (Memoria mem in det.Laptop.Memorias)
                            {
                                parametrosEntrada = new MySqlParameter[5];
                                parametrosEntrada[0] = new MySqlParameter("@_idMemoria", MySqlDbType.Int32);
                                parametrosEntrada[1] = new MySqlParameter("@_idLC", MySqlDbType.Int32);
                                parametrosEntrada[2] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                                parametrosEntrada[3] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                                parametrosEntrada[4] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);

                                parametrosEntrada[0].Value = mem.IdMemoria;
                                parametrosEntrada[1].Value = idLC;
                                parametrosEntrada[2].Value = mem.Cantidad;
                                parametrosEntrada[3].Value = ingreso.IdIngreso;
                                parametrosEntrada[4].Value = usuario;

                                bool okey = objManager.EjecutarProcedure(parametrosEntrada, "insert_memoria_LC_ingreso");
                            }

                            foreach (DiscoDuro disco in det.Laptop.Discos)
                            {
                                parametrosEntrada = new MySqlParameter[5];
                                parametrosEntrada[0] = new MySqlParameter("@_idDisco", MySqlDbType.Int32);
                                parametrosEntrada[1] = new MySqlParameter("@_idLC", MySqlDbType.Int32);
                                parametrosEntrada[2] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                                parametrosEntrada[3] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                                parametrosEntrada[4] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);

                                parametrosEntrada[0].Value = disco.IdDisco;
                                parametrosEntrada[1].Value = idLC;
                                parametrosEntrada[2].Value = disco.Cantidad;
                                parametrosEntrada[3].Value = ingreso.IdIngreso;
                                parametrosEntrada[4].Value = usuario;

                                bool okey = objManager.EjecutarProcedure(parametrosEntrada, "insert_disco_LC_ingreso");
                            }


                            foreach (Licencia licencia in det.Laptop.Licencias)
                            {
                                parametrosEntrada = new MySqlParameter[9];
                                parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                                parametrosEntrada[1] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);
                                parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                                parametrosEntrada[3] = new MySqlParameter("@_idLC", MySqlDbType.Int32);
                                parametrosEntrada[4] = new MySqlParameter("@_clave", MySqlDbType.VarChar, 80);
                                parametrosEntrada[5] = new MySqlParameter("@_fechaActivacion", MySqlDbType.DateTime);
                                parametrosEntrada[6] = new MySqlParameter("@_ubicacion", MySqlDbType.VarChar, 80);
                                parametrosEntrada[7] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 80);
                                parametrosEntrada[8] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 80);

                                parametrosEntrada[0].Value = ingreso.IdIngreso;
                                parametrosEntrada[1].Value = 1;//Id=1 es idIngresoDet Id=2 es idIngresoDetAccesorios
                                parametrosEntrada[2].Value = licencia.IdModelo;
                                parametrosEntrada[3].Value = idLC;
                                if (licencia.IdCategoria == IdCategoriaWindows)
                                {
                                    parametrosEntrada[4].Value = det.Windows[i];
                                }
                                else if (licencia.IdCategoria == IdCategoriaOffice)
                                {
                                    parametrosEntrada[4].Value = det.Office[i];
                                }
                                else if (licencia.IdCategoria == IdCategoriaAntivirus)
                                {
                                    parametrosEntrada[4].Value = det.Antivirus[i];
                                }

                                parametrosEntrada[5].Value = ingreso.FechaIngreso;
                                parametrosEntrada[6].Value = "ALMACEN";
                                parametrosEntrada[7].Value = licencia.Observacion;
                                parametrosEntrada[8].Value = usuario;

                                bool okey = objManager.EjecutarProcedure(parametrosEntrada, "insert_licencia_det");

                            }
                        }
                    }
                }

            }
            
            if (ingreso.DetallesTablets.Count > 0)
            {
                error = InsertarIngresoDetalleTablets(ingreso, usuario);
                if (error) return -1;

                foreach (IngresoDetalleTablet det in ingreso.DetallesTablets)
                {
                    for (int i = 0; i < det.Cantidad; i++)
                    {

                        string aux = "";
                        string aux2 = "";
                        int codigoCorr = 0;
                        if (ingreso.TipoIngreso == "COMPRA")
                        {
                            string[] codigoSiguiente = new string[2];


                            parametrosEntrada_aux = new MySqlParameter[5];
                            parametrosEntrada_aux[0] = new MySqlParameter("@_idProveedor", MySqlDbType.Int32);
                            parametrosEntrada_aux[1] = new MySqlParameter("@_monthIngreso", MySqlDbType.Int32);
                            parametrosEntrada_aux[2] = new MySqlParameter("@_yearIngreso", MySqlDbType.VarChar, 80);
                            parametrosEntrada_aux[3] = new MySqlParameter("@_proximoCodigo", MySqlDbType.Int32);
                            parametrosEntrada_aux[4] = new MySqlParameter("@_prefijo", MySqlDbType.VarChar, 80);

                            parametrosEntrada_aux[0].Value = idProveedor;
                            parametrosEntrada_aux[1].Value = month;
                            parametrosEntrada_aux[2].Value = year;
                            //MessageBox.Show("ID DEL PROVEEDOR: "+idProveedor.ToString());



                            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada_aux, "obtener_codigo_correlativo_tablet",
                                            3, 5, out codigoSiguiente, 2);

                            aux = codigoSiguiente[0]; //CODIGO
                            aux2 = codigoSiguiente[1]; //PREFIJO
                            codigoCorr = int.Parse(aux);

                            if (codigoSiguiente != null)
                            {
                                //VERIFICACION
                                //MessageBox.Show("El proximo codigo es el: "+(codigoCorr+1));
                                //MessageBox.Show("El proximo prefijo es el: " + aux2);
                            }
                            //FIN LOGICA CORRELATIVO

                        }

                        parametrosEntrada = new MySqlParameter[19];
                        parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                        parametrosEntrada[1] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);
                        parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                        parametrosEntrada[3] = new MySqlParameter("@_idProcesador", MySqlDbType.Int32);
                        parametrosEntrada[4] = new MySqlParameter("@_idSO", MySqlDbType.Int32);
                        parametrosEntrada[5] = new MySqlParameter("@_idRam", MySqlDbType.Int32);
                        parametrosEntrada[6] = new MySqlParameter("@_idRom", MySqlDbType.Int32);
                        parametrosEntrada[7] = new MySqlParameter("@_pantalla", MySqlDbType.Double);
                        parametrosEntrada[8] = new MySqlParameter("@_serieFabrica", MySqlDbType.VarChar, 255);
                        parametrosEntrada[9] = new MySqlParameter("@_partNumber", MySqlDbType.VarChar, 255);
                        parametrosEntrada[10] = new MySqlParameter("@_garantia", MySqlDbType.Int32);
                        parametrosEntrada[11] = new MySqlParameter("@_fecInicioSeguro", MySqlDbType.DateTime);
                        parametrosEntrada[12] = new MySqlParameter("@_fecFinSeguro", MySqlDbType.DateTime);
                        parametrosEntrada[13] = new MySqlParameter("@_compraSubarriendo", MySqlDbType.Int32);
                        parametrosEntrada[14] = new MySqlParameter("@_ubicacion", MySqlDbType.VarChar, 255);
                        parametrosEntrada[15] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
                        parametrosEntrada[16] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 255);
                        parametrosEntrada[17] = new MySqlParameter("@_codigo", MySqlDbType.VarChar, 255);
                        parametrosEntrada[18] = new MySqlParameter("@_idTablet", MySqlDbType.Int32);

                        parametrosEntrada[0].Value = ingreso.IdIngreso;
                        parametrosEntrada[1].Value = det.IdIngresoDetalleTablet;
                        parametrosEntrada[2].Value = det.TabletIdModelo;
                        parametrosEntrada[3].Value = det.TabletIdProcesador;
                        parametrosEntrada[4].Value = det.TabletIdSO;
                        parametrosEntrada[5].Value = det.TabletIdRAM;
                        parametrosEntrada[6].Value = det.TabletIdROM;
                        parametrosEntrada[7].Value = det.TabletTamanoPantalla;
                        parametrosEntrada[8].Value = det.Series[i];
                        parametrosEntrada[9].Value = det.Tablet.PartNumber;
                        parametrosEntrada[10].Value = det.Tablet.Garantia;
                        parametrosEntrada[11].Value = null;
                        parametrosEntrada[12].Value = null;
                        parametrosEntrada[13].Value = ingreso.IdTipoIngreso;
                        parametrosEntrada[14].Value = "ALMACEN";
                        parametrosEntrada[15].Value = det.Tablet.Observacion;
                        parametrosEntrada[16].Value = usuario;
                        parametrosEntrada[17].Value = aux2 + (codigoCorr + 1).ToString("000");

                        datosSalida = new string[1];

                        objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_tablet",
                            18, 19, out datosSalida, 1);
                    }
                }

            }

            if (ingreso.DetallesImpresoras.Count > 0)
            {
                error = InsertarIngresoDetalleImpresoras(ingreso, usuario);
                if (error) return -1;

                foreach (IngresoDetalleImpresora det in ingreso.DetallesImpresoras)
                {
                    for (int i = 0; i < det.Cantidad; i++)
                    {

                        string aux = "";
                        string aux2 = "";
                        int codigoCorr = 0;
                        if (ingreso.TipoIngreso == "COMPRA")
                        {
                            string[] codigoSiguiente = new string[2];


                            parametrosEntrada_aux = new MySqlParameter[5];
                            parametrosEntrada_aux[0] = new MySqlParameter("@_idProveedor", MySqlDbType.Int32);
                            parametrosEntrada_aux[1] = new MySqlParameter("@_monthIngreso", MySqlDbType.Int32);
                            parametrosEntrada_aux[2] = new MySqlParameter("@_yearIngreso", MySqlDbType.VarChar, 80);
                            parametrosEntrada_aux[3] = new MySqlParameter("@_proximoCodigo", MySqlDbType.Int32);
                            parametrosEntrada_aux[4] = new MySqlParameter("@_prefijo", MySqlDbType.VarChar, 80);

                            parametrosEntrada_aux[0].Value = idProveedor;
                            parametrosEntrada_aux[1].Value = month;
                            parametrosEntrada_aux[2].Value = year;
                            //MessageBox.Show("ID DEL PROVEEDOR: "+idProveedor.ToString());



                            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada_aux, "obtener_codigo_correlativo_impresora",
                                            3, 5, out codigoSiguiente, 2);

                            aux = codigoSiguiente[0]; //CODIGO
                            aux2 = codigoSiguiente[1]; //PREFIJO
                            codigoCorr = int.Parse(aux);

                            if (codigoSiguiente != null)
                            {
                                //VERIFICACION
                                //MessageBox.Show("El proximo codigo es el: "+(codigoCorr+1));
                                //MessageBox.Show("El proximo prefijo es el: " + aux2);
                            }
                            //FIN LOGICA CORRELATIVO

                        }

                        parametrosEntrada = new MySqlParameter[17];
                        parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                        parametrosEntrada[1] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);
                        parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                        parametrosEntrada[3] = new MySqlParameter("@_idCaracteristica", MySqlDbType.Int32);
                        parametrosEntrada[4] = new MySqlParameter("@_caracteristica", MySqlDbType.VarChar, 255);
                        parametrosEntrada[5] = new MySqlParameter("@_serieFabrica", MySqlDbType.VarChar, 255);
                        parametrosEntrada[6] = new MySqlParameter("@_partNumber", MySqlDbType.VarChar, 255);
                        parametrosEntrada[7] = new MySqlParameter("@_garantia", MySqlDbType.Int32);
                        parametrosEntrada[8] = new MySqlParameter("@_fecInicioSeguro", MySqlDbType.DateTime);
                        parametrosEntrada[9] = new MySqlParameter("@_fecFinSeguro", MySqlDbType.DateTime);
                        parametrosEntrada[10] = new MySqlParameter("@_compraSubarriendo", MySqlDbType.Int32);
                        parametrosEntrada[11] = new MySqlParameter("@_ubicacion", MySqlDbType.VarChar, 255);
                        parametrosEntrada[12] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
                        parametrosEntrada[13] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 255);
                        parametrosEntrada[14] = new MySqlParameter("@_codigo", MySqlDbType.VarChar, 255);
                        parametrosEntrada[15] = new MySqlParameter("@_multifuncional", MySqlDbType.Int32);
                        parametrosEntrada[16] = new MySqlParameter("@_idImpresora", MySqlDbType.Int32);

                        parametrosEntrada[0].Value = ingreso.IdIngreso;
                        parametrosEntrada[1].Value = det.IdIngresoDetalleImpresora;
                        parametrosEntrada[2].Value = det.ImpresoraIdModelo;
                        parametrosEntrada[3].Value = det.ImpresoraIdTipo;
                        parametrosEntrada[4].Value = det.ImpresoraTipo;
                        parametrosEntrada[5].Value = det.Series[i];
                        parametrosEntrada[6].Value = det.Impresora.PartNumber;
                        parametrosEntrada[7].Value = det.Impresora.Garantia;
                        parametrosEntrada[8].Value = null;
                        parametrosEntrada[9].Value = null;
                        parametrosEntrada[10].Value = ingreso.IdTipoIngreso;
                        parametrosEntrada[11].Value = "ALMACEN";
                        parametrosEntrada[12].Value = det.Impresora.Observacion;
                        parametrosEntrada[13].Value = usuario;
                        parametrosEntrada[14].Value = aux2 + (codigoCorr + 1).ToString("000");
                        parametrosEntrada[15].Value = det.Impresora.Multifuncional;


                        datosSalida = new string[1];

                        objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_impresora",
                            16, 17, out datosSalida, 1);
                    }
                }

            }

            if (ingreso.DetallesMonitores.Count > 0)
            {
                error = InsertarIngresoDetalleMonitores(ingreso, usuario);
                if (error) return -1;

                foreach (IngresoDetalleMonitor det in ingreso.DetallesMonitores)
                {
                    for (int i = 0; i < det.Cantidad; i++)
                    {

                        string aux = "";
                        string aux2 = "";
                        int codigoCorr = 0;
                        if (ingreso.TipoIngreso == "COMPRA")
                        {
                            string[] codigoSiguiente = new string[2];


                            parametrosEntrada_aux = new MySqlParameter[5];
                            parametrosEntrada_aux[0] = new MySqlParameter("@_idProveedor", MySqlDbType.Int32);
                            parametrosEntrada_aux[1] = new MySqlParameter("@_monthIngreso", MySqlDbType.Int32);
                            parametrosEntrada_aux[2] = new MySqlParameter("@_yearIngreso", MySqlDbType.VarChar, 80);
                            parametrosEntrada_aux[3] = new MySqlParameter("@_proximoCodigo", MySqlDbType.Int32);
                            parametrosEntrada_aux[4] = new MySqlParameter("@_prefijo", MySqlDbType.VarChar, 80);

                            parametrosEntrada_aux[0].Value = idProveedor;
                            parametrosEntrada_aux[1].Value = month;
                            parametrosEntrada_aux[2].Value = year;
                            //MessageBox.Show("ID DEL PROVEEDOR: "+idProveedor.ToString());



                            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada_aux, "obtener_codigo_correlativo_monitor",
                                            3, 5, out codigoSiguiente, 2);

                            aux = codigoSiguiente[0]; //CODIGO
                            aux2 = codigoSiguiente[1]; //PREFIJO
                            codigoCorr = int.Parse(aux);

                            if (codigoSiguiente != null)
                            {
                                //VERIFICACION
                                //MessageBox.Show("El proximo codigo es el: "+(codigoCorr+1));
                                //MessageBox.Show("El proximo prefijo es el: " + aux2);
                            }
                            //FIN LOGICA CORRELATIVO

                        }

                        parametrosEntrada = new MySqlParameter[20];
                        parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                        parametrosEntrada[1] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);
                        parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                        parametrosEntrada[3] = new MySqlParameter("@_idTipo", MySqlDbType.Int32);
                        parametrosEntrada[4] = new MySqlParameter("@_tipo", MySqlDbType.VarChar, 255);
                        parametrosEntrada[5] = new MySqlParameter("@_pantalla", MySqlDbType.Double);
                        parametrosEntrada[6] = new MySqlParameter("@_serieFabrica", MySqlDbType.VarChar, 255);
                        parametrosEntrada[7] = new MySqlParameter("@_partNumber", MySqlDbType.VarChar, 255);
                        parametrosEntrada[8] = new MySqlParameter("@_garantia", MySqlDbType.Int32);
                        parametrosEntrada[9] = new MySqlParameter("@_fecInicioSeguro", MySqlDbType.DateTime);
                        parametrosEntrada[10] = new MySqlParameter("@_fecFinSeguro", MySqlDbType.DateTime);
                        parametrosEntrada[11] = new MySqlParameter("@_compraSubarriendo", MySqlDbType.Int32);
                        parametrosEntrada[12] = new MySqlParameter("@_ubicacion", MySqlDbType.VarChar, 255);
                        parametrosEntrada[13] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
                        parametrosEntrada[14] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 255);
                        parametrosEntrada[15] = new MySqlParameter("@_codigo", MySqlDbType.VarChar, 255);
                        parametrosEntrada[16] = new MySqlParameter("@_hdmi", MySqlDbType.Int32);
                        parametrosEntrada[17] = new MySqlParameter("@_vga", MySqlDbType.Int32);
                        parametrosEntrada[18] = new MySqlParameter("@_displayPort", MySqlDbType.Int32);
                        parametrosEntrada[19] = new MySqlParameter("@_idMonitor", MySqlDbType.Int32);

                        parametrosEntrada[0].Value = ingreso.IdIngreso;
                        parametrosEntrada[1].Value = det.IdIngresoDetalleMonitor;
                        parametrosEntrada[2].Value = det.MonitorIdModelo;
                        parametrosEntrada[3].Value = det.MonitorIdTipo;
                        parametrosEntrada[4].Value = det.MonitorTipo;
                        parametrosEntrada[5].Value = det.MonitorTamanoPantalla;
                        parametrosEntrada[6].Value = det.Series[i];
                        parametrosEntrada[7].Value = det.Monitor.PartNumber;
                        parametrosEntrada[8].Value = det.Monitor.Garantia;
                        parametrosEntrada[9].Value = null;
                        parametrosEntrada[10].Value = null;
                        parametrosEntrada[11].Value = ingreso.IdTipoIngreso;
                        parametrosEntrada[12].Value = "ALMACEN";
                        parametrosEntrada[13].Value = det.Monitor.Observacion;
                        parametrosEntrada[14].Value = usuario;
                        parametrosEntrada[15].Value = aux2 + (codigoCorr + 1).ToString("000");
                        parametrosEntrada[16].Value = det.Monitor.Hdmi;
                        parametrosEntrada[17].Value = det.Monitor.Vga;
                        parametrosEntrada[18].Value = det.Monitor.DisplayPort;

                        datosSalida = new string[1];

                        objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_monitor",
                            19, 20, out datosSalida, 1);
                    }
                }

            }

            if (ingreso.DetallesProyectores.Count > 0)
            {
                error = InsertarIngresoDetalleProyectores(ingreso, usuario);
                if (error) return -1;

                foreach (IngresoDetalleProyector det in ingreso.DetallesProyectores)
                {
                    for (int i = 0; i < det.Cantidad; i++)
                    {

                        string aux = "";
                        string aux2 = "";
                        int codigoCorr = 0;

                        if (ingreso.TipoIngreso == "COMPRA")
                        {
                            //SI ES COMPRA
                            //LOGICA CORRELATIVO
                            string[] codigoSiguiente = new string[2];


                            parametrosEntrada_aux = new MySqlParameter[6];
                            parametrosEntrada_aux[0] = new MySqlParameter("@_marcaProyEcram", MySqlDbType.VarChar, 80);
                            parametrosEntrada_aux[1] = new MySqlParameter("@_idProveedor", MySqlDbType.Int32);
                            parametrosEntrada_aux[2] = new MySqlParameter("@_monthIngreso", MySqlDbType.Int32);
                            parametrosEntrada_aux[3] = new MySqlParameter("@_yearIngreso", MySqlDbType.VarChar, 80);
                            parametrosEntrada_aux[4] = new MySqlParameter("@_proximoCodigo", MySqlDbType.Int32);
                            parametrosEntrada_aux[5] = new MySqlParameter("@_prefijo", MySqlDbType.VarChar, 80);


                            
                            if (det.ProyectorIdTipoEquipoProyector == this.idTipoProyector) //PROYECTOR
                            {
                                parametrosEntrada_aux[0].Value = "PCR-PROY";
                            }
                            else //ECRAM
                            {
                                parametrosEntrada_aux[0].Value = "PCR-TRI";
                            }

                            parametrosEntrada_aux[1].Value = idProveedor;
                            parametrosEntrada_aux[2].Value = month;
                            parametrosEntrada_aux[3].Value = year;
                            //MessageBox.Show("ID DEL PROVEEDOR: "+idProveedor.ToString());



                            objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada_aux, "obtener_codigo_correlativo_proy_ecram",
                                            4, 6, out codigoSiguiente, 2);

                            aux = codigoSiguiente[0]; //CODIGO
                            aux2 = codigoSiguiente[1]; //PREFIJO

                            //MessageBox.Show($"El siguiente codigo es el: {aux} {aux2}");


                            codigoCorr = int.Parse(aux);

                            if (codigoSiguiente != null)
                            {
                                //VERIFICACION
                                //MessageBox.Show("El proximo codigo es el: "+(codigoCorr+1));
                                //MessageBox.Show("El proximo prefijo es el: " + aux2);
                            }
                            //FIN LOGICA CORRELATIVO

                        }
                        parametrosEntrada = new MySqlParameter[20];
                        parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                        parametrosEntrada[1] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);
                        parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                        parametrosEntrada[3] = new MySqlParameter("@_idTipoEquipo", MySqlDbType.Int32);
                        parametrosEntrada[4] = new MySqlParameter("@_idCaracteristica", MySqlDbType.Int32);
                        parametrosEntrada[5] = new MySqlParameter("@_caracteristica", MySqlDbType.VarChar, 255);
                        parametrosEntrada[6] = new MySqlParameter("@_tamanoEcram", MySqlDbType.Double);
                        parametrosEntrada[7] = new MySqlParameter("@_serieFabrica", MySqlDbType.VarChar, 255);
                        parametrosEntrada[8] = new MySqlParameter("@_partNumber", MySqlDbType.VarChar, 255);
                        parametrosEntrada[9] = new MySqlParameter("@_garantia", MySqlDbType.Int32);
                        parametrosEntrada[10] = new MySqlParameter("@_fecInicioSeguro", MySqlDbType.DateTime);
                        parametrosEntrada[11] = new MySqlParameter("@_fecFinSeguro", MySqlDbType.DateTime);
                        parametrosEntrada[12] = new MySqlParameter("@_compraSubarriendo", MySqlDbType.Int32);
                        parametrosEntrada[13] = new MySqlParameter("@_ubicacion", MySqlDbType.VarChar, 255);
                        parametrosEntrada[14] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
                        parametrosEntrada[15] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 255);
                        parametrosEntrada[16] = new MySqlParameter("@_codigo", MySqlDbType.VarChar, 255);
                        parametrosEntrada[17] = new MySqlParameter("@_idResolucion", MySqlDbType.Int32);
                        parametrosEntrada[18] = new MySqlParameter("@_idLuminen", MySqlDbType.Int32);
                        parametrosEntrada[19] = new MySqlParameter("@_idProyectorEcram", MySqlDbType.Int32);

                        parametrosEntrada[0].Value = ingreso.IdIngreso;
                        parametrosEntrada[1].Value = det.IdIngresoDetalleProyector;
                        parametrosEntrada[2].Value = det.ProyectorIdModelo;
                        parametrosEntrada[3].Value = det.ProyectorIdTipoEquipoProyector;
                        parametrosEntrada[4].Value = det.ProyectorIdCaracteristica;
                        parametrosEntrada[5].Value = det.ProyectorCaracteristica;
                        parametrosEntrada[6].Value = det.ProyectorTamano;
                        parametrosEntrada[7].Value = det.Series[i];
                        parametrosEntrada[8].Value = det.Proyector.PartNumber;
                        parametrosEntrada[9].Value = det.Proyector.Garantia;
                        parametrosEntrada[10].Value = null;
                        parametrosEntrada[11].Value = null;
                        parametrosEntrada[12].Value = ingreso.IdTipoIngreso;
                        parametrosEntrada[13].Value = "ALMACEN";
                        parametrosEntrada[14].Value = det.Proyector.Observacion;
                        parametrosEntrada[15].Value = usuario;
                        parametrosEntrada[16].Value = aux2 + (codigoCorr + 1).ToString("000");
                        parametrosEntrada[17].Value = det.ProyectorIdResolucion;
                        parametrosEntrada[18].Value = det.ProyectorIdLuminen;

                        datosSalida = new string[1];

                        objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_proyectorEcram",
                            19, 20, out datosSalida, 1);
                    }
                }

            }

            if (ingreso.Discos.Count > 0 || ingreso.Memorias.Count > 0 || ingreso.Licencias.Count > 0)
            {
                error = InsertarIngresoDetalleAccesorios(ingreso, usuario);
                if (error) return -1;

                foreach (DiscoDuro disco in ingreso.Discos)
                {
                    parametrosEntrada = new MySqlParameter[2];
                    parametrosEntrada[0] = new MySqlParameter("@_idDisco", MySqlDbType.Int32);
                    parametrosEntrada[1] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);

                    parametrosEntrada[0].Value = disco.IdDisco;
                    parametrosEntrada[1].Value = disco.Cantidad;

                    bool okey = objManager.EjecutarProcedure(parametrosEntrada, "update_disco_cantidad");
                }

                foreach (Memoria memoria in ingreso.Memorias)
                {
                    parametrosEntrada = new MySqlParameter[2];
                    parametrosEntrada[0] = new MySqlParameter("@_idMemoria", MySqlDbType.Int32);
                    parametrosEntrada[1] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);

                    parametrosEntrada[0].Value = memoria.IdMemoria;
                    parametrosEntrada[1].Value = memoria.Cantidad;

                    bool okey = objManager.EjecutarProcedure(parametrosEntrada, "update_memoria_cantidad");
                }

                foreach (Licencia licencia in ingreso.Licencias)
                {
                    for (int i = 0; i < licencia.Cantidad; i++)
                    {
                        parametrosEntrada = new MySqlParameter[9];
                        parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                        parametrosEntrada[1] = new MySqlParameter("@_idIngresoDetAccesorios", MySqlDbType.Int32);
                        parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                        parametrosEntrada[3] = new MySqlParameter("@_idLC", MySqlDbType.Int32);
                        parametrosEntrada[4] = new MySqlParameter("@_clave", MySqlDbType.VarChar, 80);
                        parametrosEntrada[5] = new MySqlParameter("@_fechaActivacion", MySqlDbType.DateTime);
                        parametrosEntrada[6] = new MySqlParameter("@_ubicacion", MySqlDbType.VarChar, 80);
                        parametrosEntrada[7] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 80);
                        parametrosEntrada[8] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 80);

                        parametrosEntrada[0].Value = ingreso.IdIngreso;
                        parametrosEntrada[1].Value = 2;//Id=1 es idIngresoDet Id=2 es idIngresoDetAccesorios
                        parametrosEntrada[2].Value = licencia.IdModelo;
                        parametrosEntrada[3].Value = null;
                        parametrosEntrada[4].Value = licencia.Clave;
                        parametrosEntrada[5].Value = null;
                        parametrosEntrada[6].Value = "ALMACEN";
                        parametrosEntrada[7].Value = licencia.Observacion;
                        parametrosEntrada[8].Value = usuario;

                        bool okey = objManager.EjecutarProcedure(parametrosEntrada, "insert_licencia_det_accesorios");
                    }
                }
            }

            return 0;
        }

        public bool InsertarIngresoDetalleLaptops(Ingreso ingreso, string usuario)
        {
            foreach (IngresoDetalle det in ingreso.Detalles)
            {
                parametrosEntrada = new MySqlParameter[30];
                parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idMarcaLC", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idModeloLC", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_partNumber", MySqlDbType.VarChar, 255);
                parametrosEntrada[4] = new MySqlParameter("@_pantalla", MySqlDbType.Double);
                parametrosEntrada[5] = new MySqlParameter("@_garantia", MySqlDbType.Int32);
                parametrosEntrada[6] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[7] = new MySqlParameter("@_subTotal", MySqlDbType.Double);
                parametrosEntrada[8] = new MySqlParameter("@_idProcesador", MySqlDbType.Int32);
                parametrosEntrada[9] = new MySqlParameter("@_idVideo", MySqlDbType.Int32);
                parametrosEntrada[10] = new MySqlParameter("@_idDisco1", MySqlDbType.Int32);
                parametrosEntrada[11] = new MySqlParameter("@_cantidadDisco1", MySqlDbType.Int32);
                parametrosEntrada[12] = new MySqlParameter("@_idDisco2", MySqlDbType.Int32);
                parametrosEntrada[13] = new MySqlParameter("@_cantidadDisco2", MySqlDbType.Int32);
                parametrosEntrada[14] = new MySqlParameter("@_idMemoria1", MySqlDbType.Int32);
                parametrosEntrada[15] = new MySqlParameter("@_cantidadMemoria1", MySqlDbType.Int32);
                parametrosEntrada[16] = new MySqlParameter("@_idMemoria2", MySqlDbType.Int32);
                parametrosEntrada[17] = new MySqlParameter("@_cantidadMemoria2", MySqlDbType.Int32);
                parametrosEntrada[18] = new MySqlParameter("@_idMemoria3", MySqlDbType.Int32);
                parametrosEntrada[19] = new MySqlParameter("@_cantidadMemoria3", MySqlDbType.Int32);
                parametrosEntrada[20] = new MySqlParameter("@_idModeloWindows", MySqlDbType.Int32);
                parametrosEntrada[21] = new MySqlParameter("@_idModeloOffice", MySqlDbType.Int32);
                parametrosEntrada[22] = new MySqlParameter("@_idModeloAntivirus", MySqlDbType.Int32);
                parametrosEntrada[23] = new MySqlParameter("@_caracteristicas", MySqlDbType.VarChar, 100);
                parametrosEntrada[24] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
                parametrosEntrada[25] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[26] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                parametrosEntrada[27] = new MySqlParameter("@_idTipoEquipoLC", MySqlDbType.Int32);
                parametrosEntrada[28] = new MySqlParameter("@_nombreTipoEquipoLC", MySqlDbType.VarChar, 255);
                parametrosEntrada[29] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);


                parametrosEntrada[0].Value = ingreso.IdIngreso;
                parametrosEntrada[1].Value = det.LaptopIdMarca; //MessageBox.Show(parametrosEntrada[1].Value.ToString());
                parametrosEntrada[2].Value = det.LaptopIdModelo;
                parametrosEntrada[3].Value = det.Laptop.PartNumber;
                parametrosEntrada[4].Value = det.LaptopTamanoPantalla;
                parametrosEntrada[5].Value = det.Laptop.Garantia;
                parametrosEntrada[6].Value = det.Cantidad;
                parametrosEntrada[7].Value = det.Precio;
                parametrosEntrada[8].Value = det.Laptop.IdProcesador;
                parametrosEntrada[9].Value = det.Laptop.IdVideo;
                int cantDiscos = det.Laptop.Discos.Count;
                if (cantDiscos == 1)
                {
                    parametrosEntrada[10].Value = det.Laptop.Discos[0].IdDisco;
                    parametrosEntrada[11].Value = det.Laptop.Discos[0].Cantidad;
                    parametrosEntrada[12].Value = 0;
                    parametrosEntrada[13].Value = 0;
                }
                else if (cantDiscos == 2)
                {
                    parametrosEntrada[10].Value = det.Laptop.Discos[0].IdDisco;
                    parametrosEntrada[11].Value = det.Laptop.Discos[0].Cantidad;
                    parametrosEntrada[12].Value = det.Laptop.Discos[1].IdDisco;
                    parametrosEntrada[13].Value = det.Laptop.Discos[1].Cantidad;
                }

                int cantMemorias = det.Laptop.Memorias.Count;
                if (cantMemorias == 1)
                {
                    parametrosEntrada[14].Value = det.Laptop.Memorias[0].IdMemoria;
                    parametrosEntrada[15].Value = det.Laptop.Memorias[0].Cantidad;
                    parametrosEntrada[16].Value = 0;
                    parametrosEntrada[17].Value = 0;
                    parametrosEntrada[18].Value = 0;
                    parametrosEntrada[19].Value = 0;
                }
                else if (cantMemorias == 2)
                {
                    parametrosEntrada[14].Value = det.Laptop.Memorias[0].IdMemoria;
                    parametrosEntrada[15].Value = det.Laptop.Memorias[0].Cantidad;
                    parametrosEntrada[16].Value = det.Laptop.Memorias[1].IdMemoria;
                    parametrosEntrada[17].Value = det.Laptop.Memorias[1].Cantidad;
                    parametrosEntrada[18].Value = 0;
                    parametrosEntrada[19].Value = 0;
                }
                else if (cantMemorias == 3)
                {
                    parametrosEntrada[14].Value = det.Laptop.Memorias[0].IdMemoria;
                    parametrosEntrada[15].Value = det.Laptop.Memorias[0].Cantidad;
                    parametrosEntrada[16].Value = det.Laptop.Memorias[1].IdMemoria;
                    parametrosEntrada[17].Value = det.Laptop.Memorias[1].Cantidad;
                    parametrosEntrada[18].Value = det.Laptop.Memorias[2].IdMemoria;
                    parametrosEntrada[19].Value = det.Laptop.Memorias[2].Cantidad;
                }
                int idWin = -1;
                int idOff = -1;
                int idAnt = -1;
                for (int i = 0; i < det.Laptop.Licencias.Count; i++)
                {
                    if (det.Laptop.Licencias[i].IdCategoria == IdCategoriaWindows)
                        idWin = det.Laptop.Licencias[i].IdModelo;
                    else if (det.Laptop.Licencias[i].IdCategoria == IdCategoriaOffice)
                        idOff = det.Laptop.Licencias[i].IdModelo;
                    else if (det.Laptop.Licencias[i].IdCategoria == IdCategoriaAntivirus)
                        idAnt = det.Laptop.Licencias[i].IdModelo;
                }
                parametrosEntrada[20].Value = (idWin == -1) ? 0 : idWin;
                parametrosEntrada[21].Value = (idOff == -1) ? 0 : idOff;
                parametrosEntrada[22].Value = (idAnt == -1) ? 0 : idAnt;
                parametrosEntrada[23].Value = det.Caracteristica;
                parametrosEntrada[24].Value = det.Observacion;
                parametrosEntrada[25].Value = det.Estado;
                parametrosEntrada[26].Value = usuario;
                parametrosEntrada[27].Value = det.LaptopIdTipoEquipoLC;
                parametrosEntrada[28].Value = det.LaptopTipoEquipoLC;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso_det",
                29, 30, out datosSalida, 1);
                if (datosSalida == null)
                {
                    return true;
                }
                det.IdIngresoDetalle = Convert.ToInt32(datosSalida[0]);
            }
            return false;
        }

        public bool InsertarIngresoDetalleAccesorios(Ingreso ingreso, string usuario)
        {
            foreach (Licencia det in ingreso.Licencias)
            {
                parametrosEntrada = new MySqlParameter[12];
                parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idCategoria", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idModeloLicencia", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_clave", MySqlDbType.VarChar, 255);
                parametrosEntrada[4] = new MySqlParameter("@_idDisco", MySqlDbType.Int32);
                parametrosEntrada[5] = new MySqlParameter("@_idMemoria", MySqlDbType.Int32);
                parametrosEntrada[6] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[7] = new MySqlParameter("@_subTotal", MySqlDbType.Double);
                parametrosEntrada[8] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
                parametrosEntrada[9] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[10] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                parametrosEntrada[11] = new MySqlParameter("@_idIngresoDetAccesorios", MySqlDbType.Int32);


                parametrosEntrada[0].Value = ingreso.IdIngreso;
                parametrosEntrada[1].Value = det.IdCategoria;
                parametrosEntrada[2].Value = det.IdModelo;
                parametrosEntrada[3].Value = det.Clave;
                parametrosEntrada[4].Value = 0;
                parametrosEntrada[5].Value = 0;
                parametrosEntrada[6].Value = det.Cantidad;
                parametrosEntrada[7].Value = det.Precio;
                parametrosEntrada[8].Value = det.Observacion;
                parametrosEntrada[9].Value = 1;
                parametrosEntrada[10].Value = usuario;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso_det_accesorios",
                11, 12, out datosSalida, 1);
                if (datosSalida == null)
                {
                    return true;
                }
            }

            foreach (DiscoDuro det in ingreso.Discos)
            {
                parametrosEntrada = new MySqlParameter[12];
                parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idCategoria", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idModeloLicencia", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_clave", MySqlDbType.VarChar, 255);
                parametrosEntrada[4] = new MySqlParameter("@_idDisco", MySqlDbType.Int32);
                parametrosEntrada[5] = new MySqlParameter("@_idMemoria", MySqlDbType.Int32);
                parametrosEntrada[6] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[7] = new MySqlParameter("@_subTotal", MySqlDbType.Double);
                parametrosEntrada[8] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
                parametrosEntrada[9] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[10] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                parametrosEntrada[11] = new MySqlParameter("@_idIngresoDetAccesorios", MySqlDbType.Int32);


                parametrosEntrada[0].Value = ingreso.IdIngreso;
                parametrosEntrada[1].Value = 0;
                parametrosEntrada[2].Value = 0;
                parametrosEntrada[3].Value = "";
                parametrosEntrada[4].Value = det.IdDisco;
                parametrosEntrada[5].Value = 0;
                parametrosEntrada[6].Value = det.Cantidad;
                parametrosEntrada[7].Value = det.Precio;
                parametrosEntrada[8].Value = det.Observacion;
                parametrosEntrada[9].Value = 1;
                parametrosEntrada[10].Value = usuario;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso_det_accesorios",
                11, 12, out datosSalida, 1);
                if (datosSalida == null)
                {
                    return true;
                }
            }

            foreach (Memoria det in ingreso.Memorias)
            {
                parametrosEntrada = new MySqlParameter[12];
                parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idCategoria", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idModeloLicencia", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_clave", MySqlDbType.VarChar, 255);
                parametrosEntrada[4] = new MySqlParameter("@_idDisco", MySqlDbType.Int32);
                parametrosEntrada[5] = new MySqlParameter("@_idMemoria", MySqlDbType.Int32);
                parametrosEntrada[6] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[7] = new MySqlParameter("@_subTotal", MySqlDbType.Double);
                parametrosEntrada[8] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
                parametrosEntrada[9] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[10] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 100);
                parametrosEntrada[11] = new MySqlParameter("@_idIngresoDetAccesorios", MySqlDbType.Int32);


                parametrosEntrada[0].Value = ingreso.IdIngreso;
                parametrosEntrada[1].Value = 0;
                parametrosEntrada[2].Value = 0;
                parametrosEntrada[3].Value = "";
                parametrosEntrada[4].Value = 0;
                parametrosEntrada[5].Value = det.IdMemoria;
                parametrosEntrada[6].Value = det.Cantidad;
                parametrosEntrada[7].Value = det.Precio;
                parametrosEntrada[8].Value = det.Observacion;
                parametrosEntrada[9].Value = 1;
                parametrosEntrada[10].Value = usuario;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso_det_accesorios",
                11, 12, out datosSalida, 1);
                if (datosSalida == null)
                {
                    return true;
                }
            }
            return false;
        }
                    
        public bool InsertarIngresoDetalleImpresoras(Ingreso ingreso, string usuario)
        {
            foreach (IngresoDetalleImpresora det in ingreso.DetallesImpresoras)
            {
                parametrosEntrada = new MySqlParameter[14];
                parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idMarca", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_idCaracteristica", MySqlDbType.Int32);
                parametrosEntrada[4] = new MySqlParameter("@_caracteristica", MySqlDbType.VarChar, 255);
                parametrosEntrada[5] = new MySqlParameter("@_partNumber", MySqlDbType.VarChar, 255);
                parametrosEntrada[6] = new MySqlParameter("@_garantia", MySqlDbType.Int32);
                parametrosEntrada[7] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[8] = new MySqlParameter("@_subTotal", MySqlDbType.Double);
                parametrosEntrada[9] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
                parametrosEntrada[10] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[11] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 255);
                parametrosEntrada[12] = new MySqlParameter("@_multifuncional", MySqlDbType.Int32);
                parametrosEntrada[13] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);


                parametrosEntrada[0].Value = ingreso.IdIngreso;
                parametrosEntrada[1].Value = det.ImpresoraIdMarca; 
                parametrosEntrada[2].Value = det.ImpresoraIdModelo;
                parametrosEntrada[3].Value = det.ImpresoraIdTipo;
                parametrosEntrada[4].Value = det.ImpresoraTipo;
                parametrosEntrada[5].Value = det.Impresora.PartNumber;
                parametrosEntrada[6].Value = det.Impresora.Garantia;
                parametrosEntrada[7].Value = det.Cantidad;
                parametrosEntrada[8].Value = det.Precio;
                parametrosEntrada[9].Value = det.Observacion;
                parametrosEntrada[10].Value = det.Estado;
                parametrosEntrada[11].Value = usuario;
                parametrosEntrada[12].Value = det.Impresora.Multifuncional;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso_det_impresora",
                13, 14, out datosSalida, 1);
                if (datosSalida == null)
                {
                    return true;
                }
                det.IdIngresoDetalleImpresora = Convert.ToInt32(datosSalida[0]);
            }
            return false;
        }

        public bool InsertarIngresoDetalleMonitores(Ingreso ingreso, string usuario)
        {
            foreach (IngresoDetalleMonitor det in ingreso.DetallesMonitores)
            {
                parametrosEntrada = new MySqlParameter[17];
                parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idMarca", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_idTipo", MySqlDbType.Int32);
                parametrosEntrada[4] = new MySqlParameter("@_tipo", MySqlDbType.VarChar, 255);
                parametrosEntrada[5] = new MySqlParameter("@_pantalla", MySqlDbType.Double);
                parametrosEntrada[6] = new MySqlParameter("@_partNumber", MySqlDbType.VarChar, 255);
                parametrosEntrada[7] = new MySqlParameter("@_garantia", MySqlDbType.Int32);
                parametrosEntrada[8] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[9] = new MySqlParameter("@_subTotal", MySqlDbType.Double);
                parametrosEntrada[10] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
                parametrosEntrada[11] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[12] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 255);
                parametrosEntrada[13] = new MySqlParameter("@_hdmi", MySqlDbType.Int32);
                parametrosEntrada[14] = new MySqlParameter("@_vga", MySqlDbType.Int32);
                parametrosEntrada[15] = new MySqlParameter("@_displayPort", MySqlDbType.Int32);
                parametrosEntrada[16] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);


                parametrosEntrada[0].Value = ingreso.IdIngreso;
                parametrosEntrada[1].Value = det.MonitorIdMarca;
                parametrosEntrada[2].Value = det.MonitorIdModelo;
                parametrosEntrada[3].Value = det.MonitorIdTipo;
                parametrosEntrada[4].Value = det.MonitorTipo;
                parametrosEntrada[5].Value = det.MonitorTamanoPantalla;
                parametrosEntrada[6].Value = det.Monitor.PartNumber;
                parametrosEntrada[7].Value = det.Monitor.Garantia;
                parametrosEntrada[8].Value = det.Cantidad;
                parametrosEntrada[9].Value = det.Precio;
                parametrosEntrada[10].Value = det.Observacion;
                parametrosEntrada[11].Value = det.Estado;
                parametrosEntrada[12].Value = usuario;
                parametrosEntrada[13].Value = det.Monitor.Hdmi;
                parametrosEntrada[14].Value = det.Monitor.Vga;
                parametrosEntrada[15].Value = det.Monitor.DisplayPort;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso_det_monitor",
                16, 17, out datosSalida, 1);
                if (datosSalida == null)
                {
                    return true;
                }
                det.IdIngresoDetalleMonitor = Convert.ToInt32(datosSalida[0]);
            }
            return false;
        }

        public bool InsertarIngresoDetalleTablets(Ingreso ingreso, string usuario)
        {
            foreach (IngresoDetalleTablet det in ingreso.DetallesTablets)
            {
                parametrosEntrada = new MySqlParameter[16];
                parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idMarca", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_idProcesador", MySqlDbType.Int32);
                parametrosEntrada[4] = new MySqlParameter("@_idSO", MySqlDbType.Int32);
                parametrosEntrada[5] = new MySqlParameter("@_idRam", MySqlDbType.Int32);
                parametrosEntrada[6] = new MySqlParameter("@_idRom", MySqlDbType.Int32);
                parametrosEntrada[7] = new MySqlParameter("@_pantalla", MySqlDbType.Double);
                parametrosEntrada[8] = new MySqlParameter("@_partNumber", MySqlDbType.VarChar, 255);
                parametrosEntrada[9] = new MySqlParameter("@_garantia", MySqlDbType.Int32);
                parametrosEntrada[10] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[11] = new MySqlParameter("@_subTotal", MySqlDbType.Double);
                parametrosEntrada[12] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
                parametrosEntrada[13] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[14] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 255);
                parametrosEntrada[15] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);


                parametrosEntrada[0].Value = ingreso.IdIngreso;
                parametrosEntrada[1].Value = det.TabletIdMarca;
                parametrosEntrada[2].Value = det.TabletIdModelo;
                parametrosEntrada[3].Value = det.TabletIdProcesador;
                parametrosEntrada[4].Value = det.TabletIdSO;
                parametrosEntrada[5].Value = det.TabletIdRAM;
                parametrosEntrada[6].Value = det.TabletIdROM;
                parametrosEntrada[7].Value = det.TabletTamanoPantalla;
                parametrosEntrada[8].Value = det.Tablet.PartNumber;
                parametrosEntrada[9].Value = det.Tablet.Garantia;
                parametrosEntrada[10].Value = det.Cantidad;
                parametrosEntrada[11].Value = det.Precio;
                parametrosEntrada[12].Value = det.Observacion;
                parametrosEntrada[13].Value = det.Estado;
                parametrosEntrada[14].Value = usuario;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso_det_tablet",
                15, 16, out datosSalida, 1);
                if (datosSalida == null)
                {
                    return true;
                }
                det.IdIngresoDetalleTablet = Convert.ToInt32(datosSalida[0]);
            }
            return false;
        }

        public bool InsertarIngresoDetalleProyectores(Ingreso ingreso, string usuario)
        {
            foreach (IngresoDetalleProyector det in ingreso.DetallesProyectores)
            {
                parametrosEntrada = new MySqlParameter[17];
                parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_idMarca", MySqlDbType.Int32);
                parametrosEntrada[2] = new MySqlParameter("@_idModelo", MySqlDbType.Int32);
                parametrosEntrada[3] = new MySqlParameter("@_idTipoEquipo", MySqlDbType.Int32);
                parametrosEntrada[4] = new MySqlParameter("@_idCaracteristica", MySqlDbType.Int32);
                parametrosEntrada[5] = new MySqlParameter("@_caracteristica", MySqlDbType.VarChar, 255);
                parametrosEntrada[6] = new MySqlParameter("@_tamanoEcram", MySqlDbType.Double);
                parametrosEntrada[7] = new MySqlParameter("@_partNumber", MySqlDbType.VarChar, 255);
                parametrosEntrada[8] = new MySqlParameter("@_garantia", MySqlDbType.Int32);
                parametrosEntrada[9] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[10] = new MySqlParameter("@_subTotal", MySqlDbType.Double);
                parametrosEntrada[11] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 255);
                parametrosEntrada[12] = new MySqlParameter("@_estado", MySqlDbType.Int32);
                parametrosEntrada[13] = new MySqlParameter("@_usuario_ins", MySqlDbType.VarChar, 255);
                parametrosEntrada[14] = new MySqlParameter("@_idResolucion", MySqlDbType.Int32);
                parametrosEntrada[15] = new MySqlParameter("@_idLuminen", MySqlDbType.Int32);
                parametrosEntrada[16] = new MySqlParameter("@_idIngresoDet", MySqlDbType.Int32);


                parametrosEntrada[0].Value = ingreso.IdIngreso;
                parametrosEntrada[1].Value = det.ProyectorIdMarca;
                parametrosEntrada[2].Value = det.ProyectorIdModelo;
                parametrosEntrada[3].Value = det.ProyectorIdTipoEquipoProyector;
                parametrosEntrada[4].Value = det.ProyectorIdCaracteristica;
                parametrosEntrada[5].Value = det.ProyectorCaracteristica;
                parametrosEntrada[6].Value = det.ProyectorTamano;
                parametrosEntrada[7].Value = det.Proyector.PartNumber;
                parametrosEntrada[8].Value = det.Proyector.Garantia;
                parametrosEntrada[9].Value = det.Cantidad;
                parametrosEntrada[10].Value = det.Precio;
                parametrosEntrada[11].Value = det.Observacion;
                parametrosEntrada[12].Value = det.Estado;
                parametrosEntrada[13].Value = usuario;
                parametrosEntrada[14].Value = det.Proyector.IdResolucion;
                parametrosEntrada[15].Value = det.Proyector.IdLuminen;

                string[] datosSalida = new string[1];

                objManager.EjecutarProcedureConDatosDevueltos(parametrosEntrada, "insert_ingreso_det_proyectorEcram",
                16, 17, out datosSalida, 1);
                if (datosSalida == null)
                {
                    return true;
                }
                det.IdIngresoDetalleProyector = Convert.ToInt32(datosSalida[0]);
            }
            return false;
        }
        
        public int ModificarIngreso(Ingreso ingreso, string usuario)
        {
            bool okey;
            //========================Todo lo que tiene que ver con la tabla ingreso detalle===================
            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_disco_LC_ingreso");


            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_memoria_LC_ingreso");


            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_licencia_LC_ingreso");


            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_LC_ingreso");


            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_det_ingreso");

            //=================Todo lo que tiene que ver con la tabla ingreso detalle tablet===================
                       
            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_tablet_ingreso");


            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_det_tablet_ingreso");

            //=================Todo lo que tiene que ver con la tabla ingreso detalle impresora===================
            
            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_impresora_ingreso");


            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_det_impresora_ingreso");

            //=================Todo lo que tiene que ver con la tabla ingreso detalle monitor===================

            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_monitor_ingreso");


            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_det_monitor_ingreso");

            //=================Todo lo que tiene que ver con la tabla ingreso detalle proyectorEcram===================
            
            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_proyectorEcram_ingreso");


            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_det_proyectorEcram_ingreso");

            //=================Todo lo que tiene que ver con la tabla ingreso detalle accesorio===================

            foreach (Memoria mem in ingreso.Memorias)
            {
                parametrosEntrada = new MySqlParameter[2];
                parametrosEntrada[0] = new MySqlParameter("@_idMemoria", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[0].Value = mem.IdMemoria;
                parametrosEntrada[1].Value = mem.Cantidad;
                okey = objManager.EjecutarProcedure(parametrosEntrada, "update_memoria_cantidad_menos");
            }

            foreach (DiscoDuro disco in ingreso.Discos)
            {
                parametrosEntrada = new MySqlParameter[2];
                parametrosEntrada[0] = new MySqlParameter("@_idDisco", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[0].Value = disco.IdDisco;
                parametrosEntrada[1].Value = disco.Cantidad;
                okey = objManager.EjecutarProcedure(parametrosEntrada, "update_disco_cantidad_menos");
            }

            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_det_accesorios_ingreso");


            //========================Se modificara el ingreso=========================


            parametrosEntrada = new MySqlParameter[17];
            parametrosEntrada[0] = new MySqlParameter("@_idOC", MySqlDbType.Int32);
            parametrosEntrada[1] = new MySqlParameter("@_idTipoIngreso", MySqlDbType.Int32);
            parametrosEntrada[2] = new MySqlParameter("@_tipoIngreso", MySqlDbType.VarChar, 255);
            parametrosEntrada[3] = new MySqlParameter("@_idProveedor", MySqlDbType.Int32);
            parametrosEntrada[4] = new MySqlParameter("@_razonSocial", MySqlDbType.VarChar, 255);
            parametrosEntrada[5] = new MySqlParameter("@_ruc", MySqlDbType.VarChar, 11);
            parametrosEntrada[6] = new MySqlParameter("@_facturaIngreso", MySqlDbType.VarChar, 255);
            parametrosEntrada[7] = new MySqlParameter("@_guiaIngreso", MySqlDbType.VarChar, 255);
            parametrosEntrada[8] = new MySqlParameter("@_fecIngresa", MySqlDbType.DateTime);
            parametrosEntrada[9] = new MySqlParameter("@_idTipoMoneda", MySqlDbType.Int32);
            parametrosEntrada[10] = new MySqlParameter("@_tipoMoneda", MySqlDbType.VarChar, 255);
            parametrosEntrada[11] = new MySqlParameter("@_montoCambio", MySqlDbType.Double);
            parametrosEntrada[12] = new MySqlParameter("@_total", MySqlDbType.Double);
            parametrosEntrada[13] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
            parametrosEntrada[14] = new MySqlParameter("@_estado", MySqlDbType.Int32);
            parametrosEntrada[15] = new MySqlParameter("@_usuario_mod", MySqlDbType.VarChar, 100);
            parametrosEntrada[16] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);

            parametrosEntrada[0].Value = 0;
            parametrosEntrada[1].Value = ingreso.IdTipoIngreso;
            parametrosEntrada[2].Value = ingreso.TipoIngreso;
            parametrosEntrada[3].Value = ingreso.IdProveedor;
            parametrosEntrada[4].Value = ingreso.RazonSocial;
            parametrosEntrada[5].Value = ingreso.Ruc;
            parametrosEntrada[6].Value = ingreso.Factura;
            parametrosEntrada[7].Value = ingreso.Guia;
            parametrosEntrada[8].Value = ingreso.FechaIngreso;
            parametrosEntrada[9].Value = ingreso.IdMonedaTipo;
            parametrosEntrada[10].Value = ingreso.MonedaTipo;
            parametrosEntrada[11].Value = ingreso.MontoCambio;
            parametrosEntrada[12].Value = ingreso.Total;
            parametrosEntrada[13].Value = ingreso.Observacion;
            parametrosEntrada[14].Value = ingreso.Estado;
            parametrosEntrada[15].Value = usuario;
            parametrosEntrada[16].Value = ingreso.IdIngreso;

            okey = objManager.EjecutarProcedure(parametrosEntrada, "update_ingreso");

            //Aqui ira la recursividad

            //! LOGICA PARA QUE EL CODIGO TENGA EL MES Y AÑO DE INGRESO
            DateTime fechaIngreso = Convert.ToDateTime(parametrosEntrada[8].Value);
            //MessageBox.Show(dtpFechaIngreso.Value.ToString());

            int month = fechaIngreso.Month;
            string year = fechaIngreso.Year.ToString();
            year = year.Substring(fechaIngreso.Year.ToString().Length - 2, 2);

            


            if (IngresosDetallesYAccesorios(ingreso, usuario, ingreso.IdProveedor,month,year) == -1) return -1;

            return 0;
        }

        public int AnularIngreso(Ingreso ingreso, string usuario)
        {
            bool okey;

            parametrosEntrada = new MySqlParameter[4];
            parametrosEntrada[0] = new MySqlParameter("@_observacion", MySqlDbType.VarChar, 100);
            parametrosEntrada[1] = new MySqlParameter("@_estado", MySqlDbType.Int32);
            parametrosEntrada[2] = new MySqlParameter("@_usuario_mod", MySqlDbType.VarChar, 100);
            parametrosEntrada[3] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);

            parametrosEntrada[0].Value = ingreso.Observacion;
            parametrosEntrada[1].Value = ingreso.Estado;
            parametrosEntrada[2].Value = usuario;
            parametrosEntrada[3].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "anular_ingreso");
            if (!okey) return -1;

            //========================Todo lo que tiene que ver con la tabla ingreso detalle===================

            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_disco_LC_ingreso");
            if (!okey) return -1;


            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_memoria_LC_ingreso");
            if (!okey) return -1;


            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_licencia_LC_ingreso");
            if (!okey) return -1;


            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_LC_ingreso");
            if (!okey) return -1;
            
            //=================Todo lo que tiene que ver con la tabla ingreso detalle tablet===================

            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_tablet_ingreso");
            if (!okey) return -1;

            //=================Todo lo que tiene que ver con la tabla ingreso detalle impresora===================

            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_impresora_ingreso");
            if (!okey) return -1;

            //=================Todo lo que tiene que ver con la tabla ingreso detalle monitor===================

            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_monitor_ingreso");
            if (!okey) return -1;

            //=================Todo lo que tiene que ver con la tabla ingreso detalle proyectorEcram===================

            parametrosEntrada = new MySqlParameter[1];
            parametrosEntrada[0] = new MySqlParameter("@_idIngreso", MySqlDbType.Int32);
            parametrosEntrada[0].Value = ingreso.IdIngreso;
            okey = objManager.EjecutarProcedure(parametrosEntrada, "delete_proyectorEcram_ingreso");
            if (!okey) return -1;

            //=================Todo lo que tiene que ver con la tabla ingreso detalle accesorio===================

            foreach (Memoria mem in ingreso.Memorias)
            {
                parametrosEntrada = new MySqlParameter[2];
                parametrosEntrada[0] = new MySqlParameter("@_idMemoria", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[0].Value = mem.IdMemoria;
                parametrosEntrada[1].Value = mem.Cantidad;
                okey = objManager.EjecutarProcedure(parametrosEntrada, "update_memoria_cantidad_menos");
                if (!okey) return -1;
            }

            foreach (DiscoDuro disco in ingreso.Discos)
            {
                parametrosEntrada = new MySqlParameter[2];
                parametrosEntrada[0] = new MySqlParameter("@_idDisco", MySqlDbType.Int32);
                parametrosEntrada[1] = new MySqlParameter("@_cantidad", MySqlDbType.Int32);
                parametrosEntrada[0].Value = disco.IdDisco;
                parametrosEntrada[1].Value = disco.Cantidad;
                okey = objManager.EjecutarProcedure(parametrosEntrada, "update_disco_cantidad_menos");
                if (!okey) return -1;
            }

            return 0;
        }

        public Ingreso LlamarIngresoModificable(int idIngreso)
        {
            Ingreso ingresoDevuelto = new Ingreso();
            MySqlDataReader reader;
            string sql = "";
            MySqlDataReader reader2;
            string sql2 = "";

            //==========================Este bloque es para llenar solo ingreso cabecera =================================

            sql = "Select * From ingreso where idIngreso=" + idIngreso + " ;";
            reader = objManager.MostrarInformacion(sql);

            while (reader.Read())
            {
                ingresoDevuelto.IdIngreso = reader.GetInt32("idIngreso");
                ingresoDevuelto.IdTipoIngreso = reader.GetInt32("idTipoIngreso");
                ingresoDevuelto.TipoIngreso = reader.GetString("tipoIngreso");
                ingresoDevuelto.IdProveedor = reader.GetInt32("idProveedor");
                ingresoDevuelto.Ruc = reader.GetString("ruc");
                ingresoDevuelto.RazonSocial = reader.GetString("razonSocial");
                ingresoDevuelto.Factura = reader.GetString("facturaIngreso");
                ingresoDevuelto.Guia = reader.GetString("guiaIngreso");
                ingresoDevuelto.FechaIngreso = reader.GetDateTime("fecIngresa");
                ingresoDevuelto.IdMonedaTipo = reader.GetInt32("idTipoMoneda");
                ingresoDevuelto.MonedaTipo = reader.GetString("tipoMoneda");
                ingresoDevuelto.MontoCambio = reader.GetDouble("montoCambio");
                ingresoDevuelto.Total = reader.GetDouble("total");
                ingresoDevuelto.Observacion = reader.GetString("observacion");
                ingresoDevuelto.Estado = reader.GetInt32("estado");
                ingresoDevuelto.UsuarioRegistro.Nombre = reader.GetString("usuario_ins");
            }

            objManager.conexion.Close();
            objManager.conexion.Dispose();
            objManager.cmd.Dispose();

            //==========================Este bloque es para llenar lo que es ingreso detalle LC====================

            sql = "SELECT * FROM vista_ingresos_detalles_modificable where idIngreso = " + idIngreso + " ;";
            reader = objManager.MostrarInformacion(sql);


            int idIngresoDetalleLC = 1;
            while (reader.Read())
            {
                IngresoDetalle det = new IngresoDetalle();

                det.LaptopMarcaLC = reader.GetString("nombreMarca");
                det.LaptopNombreModeloLC = reader.GetString("nombreModelo");
                det.LaptopTipoProcesador = reader.GetString("tipoProcesador");
                det.Laptop.Procesador.Generacion = reader.GetInt32("generacionProcesador");

                det.IdIngresoDetalle = reader.GetInt32("idIngresoDet");
                det.Laptop.IdTipoEquipoLC = reader.GetInt32("idTipoEquipoLC");
                det.Laptop.NombreTipoEquipoLC = reader.GetString("nombreTipoEquipoLC");
                det.Laptop.IdMarca = reader.GetInt32("idMarcaLC");
                det.Laptop.IdModelo = reader.GetInt32("idModeloLC");
                det.Laptop.PartNumber = reader.GetString("partNumber");
                det.Laptop.TamanoPantalla = reader.GetDouble("pantalla");
                det.Laptop.Garantia = reader.GetInt32("garantia");
                det.Cantidad = reader.GetInt32("cantidad");
                det.Precio = reader.GetInt32("subTotal");
                det.Laptop.Procesador.IdProcesador = reader.GetInt32("idProcesador");
                if (reader.GetInt32("idVideo") != 0)
                {
                    det.Laptop.Video.IdVideo = reader.GetInt32("idVideo");
                    det.LaptopNombreModeloVideo = reader.GetString("modeloVideo");
                    det.Laptop.Video.Capacidad = reader.GetInt32("capacidadVideo");
                }
                if (reader.GetInt32("idDisco1") != 0)
                {
                    DiscoDuro disco = new DiscoDuro();
                    disco.IdDisco = reader.GetInt32("idDisco1");
                    disco.Cantidad = reader.GetInt32("cantidadDisco1");
                    disco.Capacidad = reader.GetInt32("CapacidadDisco1");
                    disco.TipoDisco = reader.GetString("TipoDisco1");
                    disco.Tamano = reader.GetString("TamanoDisco1");
                    det.Laptop.Discos.Add(disco);
                }
                if (reader.GetInt32("idDisco2") != 0)
                {
                    DiscoDuro disco = new DiscoDuro();
                    disco.IdDisco = reader.GetInt32("idDisco2");
                    disco.Cantidad = reader.GetInt32("cantidadDisco2");
                    disco.Capacidad = reader.GetInt32("CapacidadDisco2");
                    disco.TipoDisco = reader.GetString("TipoDisco2");
                    disco.Tamano = reader.GetString("TamanoDisco2");
                    det.Laptop.Discos.Add(disco);
                }
                if (reader.GetInt32("idMemoria1") != 0)
                {
                    Memoria memoria = new Memoria();
                    memoria.IdMemoria = reader.GetInt32("idMemoria1");
                    memoria.Cantidad = reader.GetInt32("cantidadMemoria1");
                    memoria.Capacidad = reader.GetInt32("CapacidadMemoria1");
                    memoria.TipoMemoria = reader.GetString("TipoMemoria1");
                    memoria.Tipo = reader.GetString("Tipo2Memoria1");
                    det.Laptop.Memorias.Add(memoria);
                }
                if (reader.GetInt32("idMemoria2") != 0)
                {
                    Memoria memoria = new Memoria();
                    memoria.IdMemoria = reader.GetInt32("idMemoria2");
                    memoria.Cantidad = reader.GetInt32("cantidadMemoria2");
                    memoria.Capacidad = reader.GetInt32("CapacidadMemoria2");
                    memoria.TipoMemoria = reader.GetString("TipoMemoria2");
                    memoria.Tipo = reader.GetString("Tipo2Memoria2");
                    det.Laptop.Memorias.Add(memoria);
                }
                if (reader.GetInt32("idMemoria3") != 0)
                {
                    Memoria memoria = new Memoria();
                    memoria.IdMemoria = reader.GetInt32("idMemoria3");
                    memoria.Cantidad = reader.GetInt32("cantidadMemoria3");
                    memoria.Capacidad = reader.GetInt32("CapacidadMemoria3");
                    memoria.TipoMemoria = reader.GetString("TipoMemoria3");
                    memoria.Tipo = reader.GetString("Tipo2Memoria3");
                    det.Laptop.Memorias.Add(memoria);
                }

                if (reader.GetInt32("idModeloWindows") != 0)
                {
                    Licencia licencia = new Licencia();
                    licencia.IdCategoria = IdCategoriaWindows;
                    licencia.IdModelo = reader.GetInt32("idModeloWindows");
                    licencia.Version = reader.GetString("ModeloWindows");
                    licencia.Categoria = reader.GetString("CategoriaWindows");
                    det.Laptop.Licencias.Add(licencia);
                }
                if (reader.GetInt32("idModeloOffice") != 0)
                {
                    Licencia licencia = new Licencia();
                    licencia.IdCategoria = IdCategoriaOffice;
                    licencia.IdModelo = reader.GetInt32("idModeloOffice");
                    licencia.Version = reader.GetString("ModeloOffice");
                    licencia.Categoria = reader.GetString("CategoriaOffice");
                    det.Laptop.Licencias.Add(licencia);
                }
                if (reader.GetInt32("idModeloAntivirus") != 0)
                {
                    Licencia licencia = new Licencia();
                    licencia.IdCategoria = IdCategoriaAntivirus;
                    licencia.IdModelo = reader.GetInt32("idModeloAntivirus");
                    licencia.Version = reader.GetString("ModeloAntivirus");
                    licencia.Categoria = reader.GetString("CategoriaAntivirus");
                    det.Laptop.Licencias.Add(licencia);
                }
                det.Caracteristica = reader.GetString("caracteristicas");
                det.Observacion = reader.GetString("observacion");
                det.Estado = reader.GetInt32("estado");


                sql2 = "Select * From laptop_cpu where idIngreso=" + ingresoDevuelto.IdIngreso + " and  idIngresoDet=" + det.IdIngresoDetalle + " ;";
                reader2 = objManager.MostrarInformacion(sql2);

                BindingList<LC> listaLaptops = new BindingList<LC>();

                while (reader2.Read())
                {
                    LC lap = new LC();
                    String serieFabrica = reader2.GetString("serieFabrica");
                    lap.IdLC = reader2.GetInt32("idLC");
                    listaLaptops.Add(lap);
                    det.Series.Add(serieFabrica);
                }

                foreach (LC lap in listaLaptops)
                {
                    sql2 = "Select * From vista_licencia_ingresos where idIngreso=" + ingresoDevuelto.IdIngreso + " and  idIngresoDet=1 and  idLC=" + lap.IdLC + " ;";
                    reader2 = objManager.MostrarInformacion(sql2);

                    while (reader2.Read())
                    {
                        if (reader2.GetInt32("IdCategoria") == IdCategoriaWindows)
                        {
                            String window = reader2.GetString("Clave");
                            det.Windows.Add(window);
                        }
                        if (reader2.GetInt32("IdCategoria") == IdCategoriaOffice)
                        {
                            String office = reader2.GetString("Clave");
                            det.Office.Add(office);
                        }
                        if (reader2.GetInt32("IdCategoria") == IdCategoriaAntivirus)
                        {
                            String antivirus = reader2.GetString("Clave");
                            det.Antivirus.Add(antivirus);
                        }
                    }
                }
                det.IdIngresoDetalle = idIngresoDetalleLC;
                idIngresoDetalleLC++;
                ingresoDevuelto.Detalles.Add(det);
            }

            objManager.conexion.Close();
            objManager.conexion.Dispose();
            objManager.cmd.Dispose();



            //==========================Este bloque es para llenar lo que es ingreso detalle tablet====================

            sql = "SELECT * FROM vista_ingresos_detalles_tablet_modificable where idIngreso = " + idIngreso + " ;";
            reader = objManager.MostrarInformacion(sql);

            int idIngresoDetalleTablet = 1;
            while (reader.Read())
            {
                IngresoDetalleTablet det = new IngresoDetalleTablet();

                det.TabletMarca = reader.GetString("nombreMarca");
                det.TabletNombreModelo = reader.GetString("nombreModelo");
                det.TabletProcesador = reader.GetString("procesador");
                det.TabletSistema = reader.GetString("sistema");

                det.IdIngresoDetalleTablet = reader.GetInt32("idIngresoDet");
                det.Tablet.IdMarcaTablet = reader.GetInt32("idMarca");
                det.Tablet.IdModeloTablet = reader.GetInt32("idModelo");
                det.Tablet.IdProcesador = reader.GetInt32("idProcesador");
                det.Tablet.IdSO = reader.GetInt32("idSO");
                det.Tablet.IdRAM = reader.GetInt32("idRam");
                det.Tablet.IdROM = reader.GetInt32("idRom");
                //det.Tablet.PartNumber = reader.GetString("partNumber");
                det.Tablet.TamanoPantalla = reader.GetDouble("pantalla");
                det.Tablet.Garantia = reader.GetInt32("garantia");
                det.Cantidad = reader.GetInt32("cantidad");
                det.Precio = reader.GetInt32("subTotal");


                //det.Caracteristica = reader.GetString("caracteristicas");
                det.Observacion = reader.GetString("observacion");
                det.Estado = reader.GetInt32("estado");


                sql2 = "Select * From tablet where idIngreso=" + ingresoDevuelto.IdIngreso + " and  idIngresoDet=" + det.IdIngresoDetalleTablet + " ;";
                reader2 = objManager.MostrarInformacion(sql2);

                BindingList<Tablet> listaTablets = new BindingList<Tablet>();

                while (reader2.Read())
                {
                    Tablet tab = new Tablet();
                    String serieFabrica = reader2.GetString("serieFabrica");
                    tab.IdTablet = reader2.GetInt32("idTablet");
                    listaTablets.Add(tab);
                    det.Series.Add(serieFabrica);
                }

                det.IdIngresoDetalleTablet = idIngresoDetalleTablet;
                idIngresoDetalleTablet++;
                ingresoDevuelto.DetallesTablets.Add(det);
            }

            objManager.conexion.Close();
            objManager.conexion.Dispose();
            objManager.cmd.Dispose();



            //==========================Este bloque es para llenar lo que es ingreso detalle impresora====================

            sql = "SELECT * FROM vista_ingresos_detalles_impresora_modificable where idIngreso = " + idIngreso + " ;";
            reader = objManager.MostrarInformacion(sql);

            int idIngresoDetalleImpresora = 1;
            while (reader.Read())
            {
                IngresoDetalleImpresora det = new IngresoDetalleImpresora();

                det.ImpresoraMarca = reader.GetString("nombreMarca");
                det.ImpresoraNombreModelo = reader.GetString("nombreModelo");
                det.ImpresoraTipo = reader.GetString("caracteristica");

                det.IdIngresoDetalleImpresora = reader.GetInt32("idIngresoDet");
                det.Impresora.IdMarcaImpresora = reader.GetInt32("idMarca");
                det.Impresora.IdModeloImpresora = reader.GetInt32("idModelo");
                det.Impresora.IdTipo = reader.GetInt32("idCaracteristica");
                det.Impresora.Tipo = reader.GetString("caracteristica");
                det.Impresora.Multifuncional = reader.GetInt32("multifuncional");
                det.Impresora.PartNumber = reader.GetString("partNumber");
                //det.Impresora.TamanoPantalla = reader.GetDouble("pantalla");
                det.Impresora.Garantia = reader.GetInt32("garantia");
                det.Cantidad = reader.GetInt32("cantidad");
                det.Precio = reader.GetInt32("subTotal");


                //det.Caracteristica = reader.GetString("caracteristicas");
                det.Observacion = reader.GetString("observacion");
                det.Estado = reader.GetInt32("estado");


                sql2 = "Select * From impresora where idIngreso=" + ingresoDevuelto.IdIngreso + " and  idIngresoDet=" + det.IdIngresoDetalleImpresora + " ;";
                reader2 = objManager.MostrarInformacion(sql2);

                BindingList<Impresora> listaImpresora = new BindingList<Impresora>();

                while (reader2.Read())
                {
                    Impresora imp = new Impresora();
                    String serieFabrica = reader2.GetString("serieFabrica");
                    imp.IdImpresora = reader2.GetInt32("idImpresora");
                    listaImpresora.Add(imp);
                    det.Series.Add(serieFabrica);
                }

                det.IdIngresoDetalleImpresora = idIngresoDetalleImpresora;
                idIngresoDetalleImpresora++;
                ingresoDevuelto.DetallesImpresoras.Add(det);
            }

            objManager.conexion.Close();
            objManager.conexion.Dispose();
            objManager.cmd.Dispose();



            //==========================Este bloque es para llenar lo que es ingreso detalle monitor====================

            sql = "SELECT * FROM vista_ingresos_detalles_monitor_modificable where idIngreso = " + idIngreso + " ;";
            reader = objManager.MostrarInformacion(sql);

            int idIngresoDetalleMonitor = 1;
            while (reader.Read())
            {
                IngresoDetalleMonitor det = new IngresoDetalleMonitor();

                det.MonitorMarca = reader.GetString("nombreMarca");
                det.MonitorNombreModelo = reader.GetString("nombreModelo");
                det.MonitorTipo = reader.GetString("tipo");

                det.IdIngresoDetalleMonitor = reader.GetInt32("idIngresoDet");
                det.Monitor.IdMarcaMonitor = reader.GetInt32("idMarca");
                det.Monitor.IdModeloMonitor = reader.GetInt32("idModelo");
                det.Monitor.IdTipo = reader.GetInt32("idTipo");
                det.Monitor.Hdmi = reader.GetInt32("hdmi");
                det.Monitor.Vga = reader.GetInt32("vga");
                det.Monitor.DisplayPort = reader.GetInt32("displayPort");
                det.Monitor.PartNumber = reader.GetString("partNumber");
                det.Monitor.TamanoPantalla = reader.GetDouble("pantalla");
                det.Monitor.Garantia = reader.GetInt32("garantia");
                det.Cantidad = reader.GetInt32("cantidad");
                det.Precio = reader.GetInt32("subTotal");


                //det.Caracteristica = reader.GetString("caracteristicas");
                det.Observacion = reader.GetString("observacion");
                det.Estado = reader.GetInt32("estado");


                sql2 = "Select * From monitor where idIngreso=" + ingresoDevuelto.IdIngreso + " and  idIngresoDet=" + det.IdIngresoDetalleMonitor + " ;";
                reader2 = objManager.MostrarInformacion(sql2);

                BindingList<Monitor> listaMonitores = new BindingList<Monitor>();

                while (reader2.Read())
                {
                    Monitor mon = new Monitor();
                    String serieFabrica = reader2.GetString("serieFabrica");
                    mon.IdMonitor = reader2.GetInt32("idMonitor");
                    listaMonitores.Add(mon);
                    det.Series.Add(serieFabrica);
                }

                det.IdIngresoDetalleMonitor = idIngresoDetalleMonitor;
                idIngresoDetalleMonitor++;
                ingresoDevuelto.DetallesMonitores.Add(det);
            }

            objManager.conexion.Close();
            objManager.conexion.Dispose();
            objManager.cmd.Dispose();



            //==========================Este bloque es para llenar lo que es ingreso detalle proyectorEcram====================

            sql = "SELECT * FROM vista_ingresos_detalles_proyector_modificable where idIngreso = " + idIngreso + " ;";
            reader = objManager.MostrarInformacion(sql);

            int idIngresoDetalleProyector = 1;
            while (reader.Read())
            {
                IngresoDetalleProyector det = new IngresoDetalleProyector();

                det.ProyectorMarca = reader.GetString("nombreMarca");
                det.ProyectorNombreModelo = reader.GetString("nombreModelo");
                det.ProyectorTipoEquipoProyector = reader.GetString("tipoEquipoProyector");

                det.IdIngresoDetalleProyector = reader.GetInt32("idIngresoDet");
                det.Proyector.IdMarcaProyector = reader.GetInt32("idMarca");
                det.Proyector.IdModeloProyector = reader.GetInt32("idModelo");
                det.Proyector.IdTipoEquipoProyector = reader.GetInt32("idTipoEquipo");
                det.Proyector.IdCaracteristica = reader.GetInt32("idCaracteristica");
                det.Proyector.Caracteristica = reader.GetString("caracteristica");
                det.Proyector.IdLuminen = reader.GetInt32("idLuminen");
                det.Proyector.IdResolucion = reader.GetInt32("idResolucion");
                //det.Proyector.PartNumber = reader.GetString("partNumber");
                det.Proyector.TamanoProyector = reader.GetDouble("tamanoEcram");
                det.Proyector.Garantia = reader.GetInt32("garantia");
                det.Cantidad = reader.GetInt32("cantidad");
                det.Precio = reader.GetInt32("subTotal");


                //det.Caracteristica = reader.GetString("caracteristicas");
                det.Observacion = reader.GetString("observacion");
                det.Estado = reader.GetInt32("estado");


                sql2 = "Select * From proyectorEcram where idIngreso=" + ingresoDevuelto.IdIngreso + " and  idIngresoDet=" + det.IdIngresoDetalleProyector + " ;";
                reader2 = objManager.MostrarInformacion(sql2);

                BindingList<Proyector> listaProyectores = new BindingList<Proyector>();

                while (reader2.Read())
                {
                    Proyector proy = new Proyector();
                    String serieFabrica = reader2.GetString("serieFabrica");
                    proy.IdProyector = reader2.GetInt32("idProyectorEcram");
                    listaProyectores.Add(proy);
                    det.Series.Add(serieFabrica);
                }

                det.IdIngresoDetalleProyector = idIngresoDetalleProyector;
                idIngresoDetalleProyector++;
                ingresoDevuelto.DetallesProyectores.Add(det);
            }

            objManager.conexion.Close();
            objManager.conexion.Dispose();
            objManager.cmd.Dispose();

            //==========================Este bloque es para llenar lo que es ingreso detalle accesorio====================


            sql = "SELECT * FROM vista_ingresos_detalles_accesorios_modificable WHERE idIngreso = " + idIngreso + " ;";
            reader = objManager.MostrarInformacion(sql);

            int idLicencias = 1;
            while (reader.Read())
            {
                Licencia licenciaIndependiente = new Licencia();
                DiscoDuro discoIndependiente = new DiscoDuro();
                Memoria memoriaIndependiente = new Memoria();

                if (reader.GetInt32("idModeloLicencia") != 0)
                {
                    licenciaIndependiente.IdModelo = reader.GetInt32("idModeloLicencia");
                    licenciaIndependiente.Clave = reader.GetString("clave");
                    licenciaIndependiente.Cantidad = reader.GetInt32("cantidad");
                    licenciaIndependiente.Precio = reader.GetDouble("subTotal");
                    licenciaIndependiente.IdCategoria = reader.GetInt32("IdCategoriaLicencia");
                    licenciaIndependiente.Categoria = reader.GetString("Categoria");
                    licenciaIndependiente.Marca = reader.GetString("Marca");
                    licenciaIndependiente.Version = reader.GetString("Version");
                    licenciaIndependiente.IdLicencia = idLicencias;
                    idLicencias++;
                    ingresoDevuelto.Licencias.Add(licenciaIndependiente);
                }
                else if (reader.GetInt32("idDisco") != 0)
                {
                    discoIndependiente.IdDisco = reader.GetInt32("idDisco");
                    discoIndependiente.Cantidad = reader.GetInt32("cantidad");
                    discoIndependiente.Precio = reader.GetDouble("subTotal");
                    discoIndependiente.TipoDisco = reader.GetString("TipoDisco");
                    discoIndependiente.Tamano = reader.GetString("TamanoDisco");
                    discoIndependiente.Capacidad = reader.GetInt32("CapacidadDisco");
                    ingresoDevuelto.Discos.Add(discoIndependiente);
                }
                else if (reader.GetInt32("idMemoria") != 0)
                {
                    memoriaIndependiente.IdMemoria = reader.GetInt32("idMemoria");
                    memoriaIndependiente.Cantidad = reader.GetInt32("cantidad");
                    memoriaIndependiente.Precio = reader.GetDouble("subTotal");
                    memoriaIndependiente.TipoMemoria = reader.GetString("TipoMemoria");
                    memoriaIndependiente.Tipo = reader.GetString("Tipo2");
                    memoriaIndependiente.Capacidad = reader.GetInt32("CapacidadMemoria");
                    ingresoDevuelto.Memorias.Add(memoriaIndependiente);
                }

            }

            objManager.conexion.Close();
            objManager.conexion.Dispose();
            objManager.cmd.Dispose();

            return ingresoDevuelto;
        }

    }
}
