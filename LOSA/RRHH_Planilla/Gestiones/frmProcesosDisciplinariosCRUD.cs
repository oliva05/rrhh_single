using ACS.Classes;
using DevExpress.Utils.CommonDialogs;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Clases.Planilla;
using LOSA.RRHH_Planilla.Capacitacion;
using LOSA.RRHH_Planilla.Gestiones;
using LOSA.RRHH_Planilla.Gestiones.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Mantenimientos
{
    public partial class frmProcesosDisciplinariosCRUD : DevExpress.XtraEditors.XtraForm
    {
        //PlanillaBancos banco = new PlanillaBancos();
        ProcesoDisciplinarioClass proceso_disciplinario = new ProcesoDisciplinarioClass();
        ProcesoDisciplinarioAdjuntoClass adjuntos = new ProcesoDisciplinarioAdjuntoClass();
        public enum TipoTransaccion
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccion transaccionActual;

        UserLogin usuario = new UserLogin();
        int proceso_id;
        public frmProcesosDisciplinariosCRUD(TipoTransaccion transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccionActual = transact;
            usuario=user_p;
            CargarEmpleados();
            CargarSanciones();
        }

        public frmProcesosDisciplinariosCRUD(TipoTransaccion transact, int id_proceso, UserLogin user_p)
        {
            InitializeComponent();
            transaccionActual = transact;
            proceso_id = id_proceso;
            
            usuario = user_p;
            CargarEmpleados();
            CargarSanciones();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (deFecha.EditValue==null)
            {
                CajaDialogo.Error("Debe seleccionar una fecha");
                return;
            }

            if (slueEmpleado.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar un empleado");
                return;
            }

            if (slueSancion.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar una sanción");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccionActual)
                {
                    case TipoTransaccion.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("dbo.[uspInsert_proceso_disciplinario]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@fecha",  deFecha.EditValue);
                            cmd.Parameters.AddWithValue("@id_employee",  slueEmpleado.EditValue);
                            cmd.Parameters.AddWithValue("@sancion_id",  slueSancion.EditValue);
                            cmd.Parameters.AddWithValue("@descripcion",  txtDescripcion.Text);
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;

                            //Llenar el DataTable para @adjuntos
                            DataTable adjuntosTable = new DataTable();
                            adjuntosTable.Columns.Add("id", typeof(int));
                            adjuntosTable.Columns.Add("file_name_", typeof(string));
                            adjuntosTable.Columns.Add("file_name_remote", typeof(string));
                            adjuntosTable.Columns.Add("path_", typeof(string));


                            foreach (var item in dsGestiones1.proceso_disciplinarios_adjuntos)
                            {
                                adjuntosTable.Rows.Add(item.id, item.file_name_,item.file_name_remote, dp.FTP_RRHH_ProcesosDisciplinarios + item.file_name_remote);
                            }

                            SqlParameter adjuntosParam = cmd.Parameters.AddWithValue("@adjuntos", adjuntosTable);
                            adjuntosParam.SqlDbType = SqlDbType.Structured;

                            Boolean result;

                            foreach (var item in dsGestiones1.proceso_disciplinarios_adjuntos)
                            {
                                result = false;
                                Upload(item.path_, item.file_name_remote);
                                result = true;
                            }

                            result = Convert.ToBoolean(cmd.ExecuteScalar());

                            // Comprobar el valor de retorno
                            if (result != null && Convert.ToBoolean(result))
                            {
                                CajaDialogo.Information("Proceso Disciplinario creado exitosamente.");
                                //this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                CajaDialogo.Error("Error al crear la transacción.");
                                this.DialogResult = DialogResult.Cancel;

                            }

                            cnx.Close();

                        }

                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccion.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("dbo.uspUpdate_proceso_disciplinario", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id_proceso", SqlDbType.VarChar).Value = proceso_disciplinario.Id;
                            cmd.Parameters.AddWithValue("@fecha", deFecha.EditValue);
                            cmd.Parameters.AddWithValue("@id_employee", slueEmpleado.EditValue);
                            cmd.Parameters.AddWithValue("@sancion_id", slueSancion.EditValue);
                            cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;


                            //Llenar el DataTable para @adjuntos
                            DataTable adjuntosTable = new DataTable();
                            adjuntosTable.Columns.Add("id", typeof(int));
                            adjuntosTable.Columns.Add("file_name_", typeof(string));
                            adjuntosTable.Columns.Add("file_name_remote", typeof(string));
                            adjuntosTable.Columns.Add("path_", typeof(string));

                           
                            foreach (var item in dsGestiones1.proceso_disciplinarios_adjuntos)
                            {
                                adjuntosTable.Rows.Add(item.id, item.file_name_, item.file_name_remote, dp.FTP_RRHH_Capacitaciones + item.file_name_);
                            }

                            SqlParameter adjuntosParam = cmd.Parameters.AddWithValue("@adjuntos", adjuntosTable);
                            adjuntosParam.SqlDbType = SqlDbType.Structured;

                            Boolean result;

                            foreach (var item in dsGestiones1.proceso_disciplinarios_adjuntos)
                            {
                                result = false;
                                if (item.id==0)
                                {
                                    Upload(item.path_, item.file_name_);
                                    result = true;
                                }
                            }

                            result = Convert.ToBoolean(cmd.ExecuteScalar());

                            // Comprobar el valor de retorno
                            if (result != null && Convert.ToBoolean(result))
                            {
                                CajaDialogo.Information("Proceso Disciplinario creado exitosamente.");
         
                            }
                            else
                            {
                                CajaDialogo.Error("Error al crear la transacción.");
                                this.DialogResult = DialogResult.Cancel;

                            }

                            cnx.Close();

                        }

                        this.DialogResult = DialogResult.OK;
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProcesosDisciplinariosCRUD_Load(object sender, EventArgs e)
        {
            try
            {
                

                proceso_disciplinario = new ProcesoDisciplinarioClass();


                if (TipoTransaccion.Editar == transaccionActual)
                {
                    proceso_disciplinario.RecuperaRegistrosPorId(proceso_id);

                    txtDescripcion.Text = proceso_disciplinario.Descripcion;
                    deFecha.EditValue = proceso_disciplinario.Fecha;
                    slueEmpleado.EditValue = proceso_disciplinario.EmpleadoId;
                    slueSancion.EditValue = proceso_disciplinario.SancionId;

                    ObtenerAdjuntos(proceso_disciplinario.Id);
                }
                else
                {
                    deFecha.EditValue = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarEmpleados()
        {
            try
            {
                DataOperations dp = new DataOperations();                

                dsGestiones1.employee.Clear();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetEmployee_list_from_procesos_disciplinarios", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsGestiones1.employee);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarSanciones()
        {
            try
            {
                DataOperations dp = new DataOperations();

                dsGestiones1.sancion.Clear();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspGet_procesos_disciplinarios_sanciones_list", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsGestiones1.sancion);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void ObtenerAdjuntos(int id_proceso)
        {
            try
            {
                DataOperations dp = new DataOperations();

                dsGestiones1.proceso_disciplinarios_adjuntos.Clear();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.uspGetAdjuntos_procesos_disciplinarios_por_id",cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_proceso", id_proceso);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
          
                    da.Fill(dsGestiones1.proceso_disciplinarios_adjuntos);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = "C:/";
                openFileDialog1.Filter= "Archivos PDF (*.pdf)|*.pdf|Archivos de texto (*.txt)|*.txt";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la extensión del archivo seleccionado
                    string extension = Path.GetExtension(openFileDialog1.FileName);

                    // Obtener la fecha y hora actual en formato ddMMyyyyhhmmss
                    string fechaHora = DateTime.Now.ToString("ddMMyyyyhhmmss");

                    // Concatenar la fecha y hora con la extensión del archivo
                    string fileNameRemote = fechaHora + extension;

                    // Crear una nueva fila
                    DataRow nuevaFila = dsGestiones1.proceso_disciplinarios_adjuntos.NewRow();

                    // Asignar valores a las columnas de la nueva fila
                    nuevaFila["ID"] = 0;
                    nuevaFila["path_"] = openFileDialog1.FileName;
                    nuevaFila["file_name_"] = openFileDialog1.SafeFileName;
                    nuevaFila["file_name_remote"] = fileNameRemote;

                    // Agregar la nueva fila al DataTable
                    dsGestiones1.proceso_disciplinarios_adjuntos.Rows.Add(nuevaFila);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private bool Upload(string pathFile, string fileName)
        {
            try
            {
                if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(fileName))
                {
                    CajaDialogo.Error("No se cargó la imagen");
                    return false;
                }
                else
                {
                    FTP_Class ftp1 = new FTP_Class();
                    return ftp1.GuardarArchivoRRHHProcesosDisciplinarios(usuario, fileName, pathFile);
                }
            }

            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        private void btnOpen_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsGestiones.proceso_disciplinarios_adjuntosRow)gvAdjunto.GetFocusedDataRow();

                if (row.id != 0)                {

                    FTP_Class ftp = new FTP_Class();

                    if (row != null)
                    {
                        ftp.OpenFile(row.path_, row.file_name_);
                    }
                }
                else
                {
                    Process.Start(row.path_);
                }


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void btnDescargar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FTP_Class ftp = new FTP_Class();

                var row = (dsGestiones.proceso_disciplinarios_adjuntosRow)gvAdjunto.GetFocusedDataRow();

                if (row.id != 0)
                {
                    saveFileDialog1.FileName = row.file_name_;

                    // Establece el filtro para mostrar todos los tipos de archivos
                    saveFileDialog1.Filter = "Todos los archivos (*.*)|*.*";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (row != null)
                        {
                            ftp.DownloadFileV2(row.path_, saveFileDialog1.FileName.Replace(Path.GetFileName(saveFileDialog1.FileName), ""), usuario, row.file_name_);
                            CajaDialogo.Information("Documento descargado en '" + saveFileDialog1.FileName + "'");
                        }
                    }
                }
                else
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string destinationFilePath = saveFileDialog.FileName;
                            File.Copy(row.path_, destinationFilePath, true);
                            MessageBox.Show("Archivo descargado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //uspDisableProcesoDisciplinarioAdjunto
            try
            {
                switch (transaccionActual)
                {
                    case TipoTransaccion.Nuevo:
                        gvAdjunto.DeleteRow(gvAdjunto.FocusedRowHandle);
                        break;
                    case TipoTransaccion.Editar:
                        var row = (dsGestiones.proceso_disciplinarios_adjuntosRow)gvAdjunto.GetFocusedDataRow();

                        DataOperations dp = new DataOperations();
                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                        var respuesta = CajaDialogo.Pregunta("¿Desea desactivar el registro?");

                        if (respuesta == DialogResult.Yes)
                        {

                            using (SqlCommand cmd = new SqlCommand("dbo.uspDisableProcesoDisciplinarioAdjunto", cnx))
                            {
                                cnx.Open();
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id", row.id);
                                cmd.ExecuteNonQuery();
                                cnx.Close();
                            }

                            CajaDialogo.Information("Adjunto desactivado!");
                            //CargarAdjuntos(capacitacionActual.Id);
                            gvAdjunto.DeleteRow(gvAdjunto.FocusedRowHandle);
                        }
                        break;
                    default:
                        break;
                }


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}