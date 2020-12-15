﻿using AccesoDatos;
using DevComponents.DotNetBar.SuperGrid;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apolo
{
    public partial class frmProcesoLevantamientoObservacionesBuscar : Form
    {
        private Observacion objSeleccionado;
        private ObservacionDA observacionDA;
        private ClienteDA clienteDA;
        private DataTable tablaCliente;
        private DataTable tablaObservacion;

        public frmProcesoLevantamientoObservacionesBuscar(int idUsuario)
        {
            InitializeComponent();

            inicializarFiltros(idUsuario);

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void inicializarFiltros(int idUsuario)
        {
            observacionDA = new ObservacionDA();
            clienteDA = new ClienteDA();

            dtpFecProceso.Value = DateTime.Now;

            tablaCliente = clienteDA.ListarClientes();
            cmbCliente.DataSource = tablaCliente;
            cmbCliente.DisplayMember = "nombre_razonSocial";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.SelectedIndex = 0;
            

            if (rbtnNumLevantamiento.Checked) txtNumCambio.Enabled = true;
            else txtNumCambio.Enabled = false;
            if (chbCliente.Checked) cmbCliente.Enabled = true;
            else cmbCliente.Enabled = false;
            if (chbFecProceso.Checked) dtpFecProceso.Enabled = true;
            else dtpFecProceso.Enabled = false;
            dgvLevantamiento.PrimaryGrid.AutoGenerateColumns = false;
        }

        public Observacion ObjSeleccionado { get => objSeleccionado; set => objSeleccionado = value; }

        public frmProcesoLevantamientoObservacionesBuscar()
        {
            InitializeComponent();
        }

        private void cargarDataGridView()
        {

            String sql = "\0";
            DateTime fecha_proceso;


            if (rbtnFiltros.Checked)
            {
                sql = "Where v.IdObservacion is not null and v.IdEstado=11 ";
                String sqlFec = ""; String sqlKam = ""; String sqlCli = ""; String sqlEst = "";
                if (chbFecProceso.Checked)
                {

                    fecha_proceso = dtpFecProceso.Value;
                    String dia = fecha_proceso.Day.ToString();
                    String mes = fecha_proceso.Month.ToString();
                    String anho = fecha_proceso.Year.ToString();

                    sqlFec = " AND Cast(v.FechaLevantamiento as DATE) = '" + anho + "-" + mes + "-" + dia + "'";
                    sql = sql + sqlFec;
                }
                if (chbCliente.Checked)
                {
                    if (cmbCliente.SelectedValue == null)
                    {
                        MessageBox.Show("No se puede buscar un Levantamiento de Observacion si no\nha seleccionado un Cliente correcto.", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                        return;
                    }
                    int idCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                    sqlCli = " AND v.idCliente = " + idCliente;
                    sql = sql + sqlCli;
                }
            }
            else if (rbtnNumLevantamiento.Checked)
            {
                try
                {
                    sql = "\0";
                    sql = "Where v.IdObservacion = " + Int32.Parse(txtNumCambio.Text);
                }
                catch
                {
                    MessageBox.Show("El numero de Levantamiento no es valido", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            tablaObservacion = observacionDA.ListarObservacionesABuscar(sql);
            dgvLevantamiento.PrimaryGrid.DataSource = tablaObservacion;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            dgvLevantamiento.PrimaryGrid.DataSource = null;
            dgvLevantamiento.PrimaryGrid.Rows.Clear();
            cargarDataGridView();
            Cursor.Current = Cursors.Default;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int i = dgvLevantamiento.PrimaryGrid.ActiveRow.Index;
                int idObservacion = int.Parse(((GridCell)(((GridRow)dgvLevantamiento.PrimaryGrid.ActiveRow)[0])).Value.ToString());
                if (!(i == -1))
                {
                    objSeleccionado = observacionDA.LlamarObservacionModificable(idObservacion);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun Levantamiento de Observacion", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Cursor.Current = Cursors.Default;
        }

        private void txtNumCambio_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }

        }

        private void rbtnNumCambio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNumLevantamiento.Checked)
            {
                panelNumOP.Enabled = true;
                txtNumCambio.Enabled = true;
            }
            else
            {
                panelNumOP.Enabled = false;
                txtNumCambio.Enabled = false;
                txtNumCambio.Text = "";
            }
        }

        private void rbtnFiltros_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtnFiltros.Checked)
            {
                panelFiltros.Enabled = true;//cmbEstado.Enabled = true;
                if (chbCliente.Checked) cmbCliente.Enabled = true;
                else cmbCliente.Enabled = false;
                if (chbFecProceso.Checked) dtpFecProceso.Enabled = true;
                else dtpFecProceso.Enabled = false;
            }
            else
            {
                panelFiltros.Enabled = false;//cmbEstado.Enabled = false;
                if (chbCliente.Checked) cmbCliente.Enabled = true;
                else cmbCliente.Enabled = false;
                if (chbFecProceso.Checked) dtpFecProceso.Enabled = true;
                else dtpFecProceso.Enabled = false;
            }

        }
        private void chbFecProceso_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFecProceso.Checked) dtpFecProceso.Enabled = true;
            else dtpFecProceso.Enabled = false;
        }
        private void chbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCliente.Checked) cmbCliente.Enabled = true;
            else cmbCliente.Enabled = false;

        }
    }
}