using ACS.Classes;
using Devart.Data.PostgreSql;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.RRHH_Planilla.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Planilla
{
    public partial class frmDeduccionCafeteria : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuario_logueado;
        public frmDeduccionCafeteria(UserLogin pUsuario)
        {
            InitializeComponent();
            usuario_logueado = pUsuario;
            //CargarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarDatos()
        {
            // Configuración de la conexión a la base de datos
            
            DataOperations dp = new DataOperations();
            using (PgSqlConnection connection = new PgSqlConnection(dp.ConnectionStringCafeteria))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Consulta SQL
                    string query = "SELECT * from public.\"ft_get_deduction_cafeteria_for_AMS\"(@fecha_param)";

                    dsPlanillasTransaccion1.deduccion_cafeteria.Clear();
                    PgSqlDataAdapter da = new PgSqlDataAdapter(query, connection);
                    //da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.SelectCommand.Parameters.AddWithValue("@fecha_param", deFecha.DateTime);
                    da.Fill(dsPlanillasTransaccion1.deduccion_cafeteria);

                                      
                }
                catch (Exception ex)
                {
                  CajaDialogo.Error($"Error: {ex.Message}");
                }
                finally
                {
                    // Cerrar la conexión
                    connection.Close();
                }
            }
        }

        private void deFecha_EditValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
            checkEdit1.EditValue = true ;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            SqlTransaction transaccion = null;
            try
            {
                if (deFecha.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar una fecha");
                    return;
                }

                if (gvDeduccion.RowCount == 0)
                {
                    CajaDialogo.Error("No hay deducciones qué generar.");
                    return;
                }

                int contador = 0;
                var respuesta = CajaDialogo.Pregunta("¿Esta seguro de generar las deducciones de cafetería?");

                if (respuesta == DialogResult.Yes)
                {

                    DataOperations dp = new DataOperations();

                    // Crear una tabla en memoria que coincida con la definición del UDTT
                    DataTable udttTable = new DataTable();
                    udttTable.Columns.Add("fecha", typeof(DateTime));
                    udttTable.Columns.Add("codigo", typeof(string));
                    udttTable.Columns.Add("nombre", typeof(string));
                    udttTable.Columns.Add("total", typeof(decimal));
                    udttTable.Columns.Add("create_user", typeof(int));


                    foreach (var item in dsPlanillasTransaccion1.deduccion_cafeteria)
                    {
                        if (item.excluir==true)
                        {

                            udttTable.Rows.Add(deFecha.EditValue, item.codigo,
                                                item.nombre,
                                                item.total,
                                                usuario_logueado.Id);
                            contador++;
                        }
                    }

                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                    {
                        cnx.Open();
                        transaccion = cnx.BeginTransaction();

                        SqlDataAdapter da = new SqlDataAdapter("uspGenerateDeductionByCafeteriaa", cnx);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Transaction = transaccion;

                        // Crear el parámetro con el UDTT
                        SqlParameter parameter = da.SelectCommand.Parameters.AddWithValue("@deducciones_cafeteria", udttTable);
                        parameter.SqlDbType = SqlDbType.Structured;
                        parameter.TypeName = "dbo.cafeteria_montos_a_deducir";

                        // Ejecutar el comando
                        da.Fill(dsPlanillasTransaccion1.procesar_deduccion_cafeteria);
                        transaccion.Commit();
                        cnx.Close();
                    }

                    bool transaccion_finalizada = false;
                    splashScreenManager1.ShowWaitForm();
                    Thread.Sleep(5000);
                    foreach (var item in dsPlanillasTransaccion1.procesar_deduccion_cafeteria)
                    {
                        transaccion_finalizada = false;
                        ProcesarDeduccionCafeteriaFromPgSQL(item.id_inserted, item.barcode);
                        transaccion_finalizada = true;
                    }
                    splashScreenManager1.CloseWaitForm();

                    if (transaccion_finalizada)
                    {
                        CajaDialogo.Information($"Se han generado {contador} deduccion(es) exitosamente");
                        dsPlanillasTransaccion1.deduccion_cafeteria.Clear();
                        deFecha.EditValue = null;
                        checkEdit1.EditValue = false;
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaccion.Rollback();
            }
        }

        public void ProcesarDeduccionCafeteriaFromPgSQL(int id_deduction,string barcode)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (PgSqlConnection cnx = new PgSqlConnection(dp.ConnectionStringCafeteria))
                {
                    cnx.Open();
                    string commandText = "ft_procesar_deduccion_by_code";
                    PgSqlCommand cmd = new PgSqlCommand(commandText,cnx);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_fecha_corte",deFecha.EditValue);
                    cmd.Parameters.AddWithValue("@p_id_deduction",id_deduction);
                    cmd.Parameters.AddWithValue("@p_barcode",  barcode);

                    cmd.ExecuteNonQuery();
                    cnx.Clone();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
           
                foreach (var item in dsPlanillasTransaccion1.deduccion_cafeteria)
                {
                    item.excluir = checkEdit1.Checked;
                }
      
        }
    }
}