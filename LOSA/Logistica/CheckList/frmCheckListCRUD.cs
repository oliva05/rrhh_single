using ACS.Classes;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DocumentFormat.OpenXml.Office2013.Excel;
using LOSA.Clases;
using LOSA.Logistica.CheckList.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Logistica.CheckList
{
    public partial class frmCheckListCRUD : DevExpress.XtraEditors.XtraForm
    {
        UserLogin user;

        public enum TipoTransaccion
        {
            Nuevo=1,
            Update = 2
        }

        TipoTransaccion transaccionActual;

        DataTable detalle_inspeccion = new DataTable();       

        public frmCheckListCRUD(UserLogin pUser, TipoTransaccion transaccionActualP)
        {
            InitializeComponent();
            user = pUser;
            transaccionActual = transaccionActualP;

            CargarItems();
            CargarOperadores();

            CargarCaracteristicaMotor();
            CargarCaracteristicaElectrico();
            CargarCaracteristicaCabinas();
            CargarCaracteristicaTanques();
            CargarCaracteristicaParteInferior();

            slueOperador.EditValue = pUser.Id;

            detalle_inspeccion.Columns.Add("id_caracteristica_detalle", typeof(int));
            detalle_inspeccion.Columns.Add("conforme", typeof(bool));
            detalle_inspeccion.Columns.Add("no_conforme", typeof(bool));
            detalle_inspeccion.Columns.Add("no_aplica", typeof(bool));
            detalle_inspeccion.Columns.Add("observaciones", typeof(string));

            DataOperations dp = new DataOperations();
            deFecha.DateTime = dp.Now();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {

            if (slueOperador.EditValue == null)
            {
                var respuesta = new frmDialogResult("Debe seleccionar un Operador",frmDialogResult.MessageDialog.Message);

                respuesta.ShowDialog();
                return;
                
            }

            if (slueEquipo.EditValue == null)
            {
                var respuesta = new frmDialogResult("Debe seleccionar un equipo", frmDialogResult.MessageDialog.Message);
                respuesta.ShowDialog();

                return;
            }

            if (deFecha.EditValue == null)
            {
                var respuesta = new frmDialogResult("Debe seleccionar una fecha", frmDialogResult.MessageDialog.Message);
                respuesta.ShowDialog();

                return;
            }

            if (seHorometroI.EditValue == null)
            {
                var respuesta = new frmDialogResult("Debe ingresar el Horòmetro Incial", frmDialogResult.MessageDialog.Message);
                respuesta.ShowDialog();

                return;
            }

            if (seHorometroF.EditValue == null)
            {
                var respuesta = new frmDialogResult("Debe ingresar el Horòmetro Final", frmDialogResult.MessageDialog.Message);
                respuesta.ShowDialog();

                return;
            }

            if (Convert.ToDecimal( seHorometroI.EditValue) > Convert.ToDecimal(seHorometroF.EditValue))
            {
                var respuesta = new frmDialogResult("Horometro Inicial debe ser menor que Horogometro Final", frmDialogResult.MessageDialog.Message);
                respuesta.ShowDialog();

                return;
            }

            this.navigationFrame1.SelectedPage = npMotor;


        }

        public void CargarOperadores()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                dsCheckList1.Operadores.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadOperadoresForChecklist", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsCheckList1.Operadores);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarItems()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                dsCheckList1.checklist_items.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadCheckList", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsCheckList1.checklist_items);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        #region Caracteristicas
        public void CargarCaracteristicaMotor()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                dsCheckList1.Caracteristica_Motor.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadCaracteristica_motor", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsCheckList1.Caracteristica_Motor);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarCaracteristicaElectrico()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                dsCheckList1.Caracteristica_Electrico.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadCaracteristica_electrico", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsCheckList1.Caracteristica_Electrico);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarCaracteristicaCabinas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                dsCheckList1.Caracteristica_Cabinas.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadCaracteristica_cabinas", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsCheckList1.Caracteristica_Cabinas);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarCaracteristicaTanques()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                dsCheckList1.Caracteristica_Tanques.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadCaracteristica_tanques", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsCheckList1.Caracteristica_Tanques);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarCaracteristicaParteInferior()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                dsCheckList1.Caracteristica_Parte_Inferior.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadCaracteristica_parte_inferior", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsCheckList1.Caracteristica_Parte_Inferior);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        #endregion

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = npHeader;
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            bool isCompleted = true;

            foreach (var item in dsCheckList1.Caracteristica_Motor)
            {
                if (!item.conforme && !item.no_aplica && !item.no_conforme)
                {
                   isCompleted = false;
                    break;
                }
            }

            if (isCompleted)
            {
                this.navigationFrame1.SelectedPage = npElectrico;
            }
            else
            {
                var message = new frmDialogResult("No ha verificado todas las caracteristica", frmDialogResult.MessageDialog.Message);

                message.ShowDialog();
                return;
            }

        }

        private void btnClose3_Click(object sender, EventArgs e)
        {
            var respuesta = new frmDialogResult("Desea Cerrar la inspección?", frmDialogResult.MessageDialog.DialogResult);

            if (respuesta.ShowDialog() == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            var respuesta = new frmDialogResult("Desea Cerrar la inspección?", frmDialogResult.MessageDialog.DialogResult);

            if (respuesta.ShowDialog() == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            var respuesta = new frmDialogResult("Desea Cerrar la inspección?", frmDialogResult.MessageDialog.DialogResult);

            if (respuesta.ShowDialog() == DialogResult.Yes)
            {
                this.Close();

            }

        }

        private void gvMotor_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            try
            {
                //// Verificar si la columna editada es "Conforme"
                //if (e.Column.FieldName == "conforme")
                //{
                //    // Refrescar el estilo de la fila actual para aplicar los cambios
                //    gridView1.RefreshRowCell(e.RowHandle, e.Column);
                //}

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gvMotor_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            // Validar si la columna modificada es "Conforme", "No Conforme" o "No Aplica"
            if (e.Column.FieldName == "conforme" || e.Column.FieldName == "no_conforme" || e.Column.FieldName == "no_aplica")
            {
                // Obtener índice de la fila actual
                int rowHandle = e.RowHandle;

                // Desmarcar otras columnas booleanas
                view.SetRowCellValue(rowHandle, "conforme", e.Column.FieldName == "conforme");
                view.SetRowCellValue(rowHandle, "no_conforme", e.Column.FieldName == "no_conforme");
                view.SetRowCellValue(rowHandle, "no_aplica", e.Column.FieldName == "no_aplica");
            }

            // Verificar si la columna actual es "Conforme"
            if (e.Column.FieldName == "conforme")
            {
                // Forzar el cambio visual inmediato al cambiar el valor
                gvMotor.SetRowCellValue(e.RowHandle, e.Column, e.Value); // Actualizar el valor
                gvMotor.RefreshRowCell(e.RowHandle, e.Column); // Refrescar el estilo de la celda
            }
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = npMotor;
        }

        private void gvElectrico_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            // Validar si la columna modificada es "Conforme", "No Conforme" o "No Aplica"
            if (e.Column.FieldName == "conforme" || e.Column.FieldName == "no_conforme" || e.Column.FieldName == "no_aplica")
            {
                // Obtener índice de la fila actual
                int rowHandle = e.RowHandle;

                // Desmarcar otras columnas booleanas
                view.SetRowCellValue(rowHandle, "conforme", e.Column.FieldName == "conforme");
                view.SetRowCellValue(rowHandle, "no_conforme", e.Column.FieldName == "no_conforme");
                view.SetRowCellValue(rowHandle, "no_aplica", e.Column.FieldName == "no_aplica");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool isCompleted = true;

            foreach (var item in dsCheckList1.Caracteristica_Electrico)
            {
                if (!item.conforme && !item.no_aplica && !item.no_conforme)
                {
                    isCompleted = false;
                    break;
                }
            }

            if (isCompleted)
            {
                this.navigationFrame1.SelectedPage = npCabinas;
            }
            else
            {
                var message = new frmDialogResult("No ha verificado todas las caracteristica", frmDialogResult.MessageDialog.Message);

                message.ShowDialog();
                return;
            }

        }

        private void btnClose4_Click(object sender, EventArgs e)
        {
            var respuesta = new frmDialogResult("Desea Cerrar la inspección?", frmDialogResult.MessageDialog.DialogResult);

            if (respuesta.ShowDialog() == DialogResult.Yes)
            {
                this.Close();

            }
        }

            private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage=npElectrico;
        }

        private void btnNext4_Click(object sender, EventArgs e)
        {
            bool isCompleted = true;

            foreach (var item in dsCheckList1.Caracteristica_Cabinas)
            {
                if (!item.conforme && !item.no_aplica && !item.no_conforme)
                {
                    isCompleted = false;
                    break;
                }
            }

            if (isCompleted)
            {
                this.navigationFrame1.SelectedPage = npTanques;
            }
            else
            {
                var message = new frmDialogResult("No ha verificado todas las caracteristica", frmDialogResult.MessageDialog.Message);

                message.ShowDialog();
                return;
            }
        }

        private void btnBack5_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = npCabinas;
        }

        private void btnClose6_Click(object sender, EventArgs e)
        {
            var respuesta = new frmDialogResult ("Desea Cerrar la inspección?", frmDialogResult.MessageDialog.DialogResult);

            if (respuesta.ShowDialog() == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btnNext5_Click(object sender, EventArgs e)
        {
            bool isCompleted = true;

            foreach (var item in dsCheckList1.Caracteristica_Tanques)
            {
                if (!item.conforme && !item.no_aplica && !item.no_conforme)
                {
                    isCompleted = false;
                    break;
                }
            }

            if (isCompleted)
            {
                this.navigationFrame1.SelectedPage = npPI;

            }
            else
            {
                var message = new frmDialogResult("No ha verificado todas las caracteristica", frmDialogResult.MessageDialog.Message);

                message.ShowDialog();
                return;
            }

        }

        private void btnBack6_Click(object sender, EventArgs e)
        {
            this.navigationFrame1.SelectedPage = npTanques;
        }

        private void gvParteInferior_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            // Validar si la columna modificada es "Conforme", "No Conforme" o "No Aplica"
            if (e.Column.FieldName == "conforme" || e.Column.FieldName == "no_conforme" || e.Column.FieldName == "no_aplica")
            {
                // Obtener índice de la fila actual
                int rowHandle = e.RowHandle;

                // Desmarcar otras columnas booleanas
                view.SetRowCellValue(rowHandle, "conforme", e.Column.FieldName == "conforme");
                view.SetRowCellValue(rowHandle, "no_conforme", e.Column.FieldName == "no_conforme");
                view.SetRowCellValue(rowHandle, "no_aplica", e.Column.FieldName == "no_aplica");
            }
        }

        private void gvTanques_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            // Validar si la columna modificada es "Conforme", "No Conforme" o "No Aplica"
            if (e.Column.FieldName == "conforme" || e.Column.FieldName == "no_conforme" || e.Column.FieldName == "no_aplica")
            {
                // Obtener índice de la fila actual
                int rowHandle = e.RowHandle;

                // Desmarcar otras columnas booleanas
                view.SetRowCellValue(rowHandle, "conforme", e.Column.FieldName == "conforme");
                view.SetRowCellValue(rowHandle, "no_conforme", e.Column.FieldName == "no_conforme");
                view.SetRowCellValue(rowHandle, "no_aplica", e.Column.FieldName == "no_aplica");
            }
        }

        private void gvCabinas_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            // Validar si la columna modificada es "Conforme", "No Conforme" o "No Aplica"
            if (e.Column.FieldName == "conforme" || e.Column.FieldName == "no_conforme" || e.Column.FieldName == "no_aplica")
            {
                // Obtener índice de la fila actual
                int rowHandle = e.RowHandle;

                // Desmarcar otras columnas booleanas
                view.SetRowCellValue(rowHandle, "conforme", e.Column.FieldName == "conforme");
                view.SetRowCellValue(rowHandle, "no_conforme", e.Column.FieldName == "no_conforme");
                view.SetRowCellValue(rowHandle, "no_aplica", e.Column.FieldName == "no_aplica");
            }
        }

        private void slueEquipo_EditValueChanged(object sender, EventArgs e)
        {
            var selectedRow = slueEquipo.Properties.View.GetFocusedRow() as DataRowView;
            
            if (selectedRow != null)
            {
                var modelo = selectedRow["modelo"].ToString();
                lblModelo.Text = modelo;
            }
            else
            {
                lblModelo.Text = "--";
            }
        }

        private void deFecha_EditValueChanged(object sender, EventArgs e)
        {
            // Cultura (puedes usar CultureInfo.InvariantCulture o una específica como "es-ES")
            CultureInfo cultura = CultureInfo.CurrentCulture;

            // Obtener el número de semana
            int numeroSemana = cultura.Calendar.GetWeekOfYear(
                deFecha.DateTime,
                CalendarWeekRule.FirstDay, // Regla para determinar la primera semana del año
                DayOfWeek.Monday          // Día que se considera el inicio de la semana
            );

            lblSemana.Text = numeroSemana.ToString();   
        }

        private void gvMotor_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            // Verificar si la columna actual es "Conforme"
            if (e.Column.FieldName == "conforme" || e.Column.FieldName == "no_conforme" || e.Column.FieldName == "no_aplica")
            {
                // Obtener el valor de la celda
                bool isConforme = Convert.ToBoolean(gvMotor.GetRowCellValue(e.RowHandle, e.Column));

                // Cambiar el estilo si el valor es true
                if (isConforme)
                {
                    e.Appearance.BackColor = Color.LightGreen; // Cambia el color de fondo
                    //e.Appearance.ForeColor = Color.Black;     // Cambia el color del texto
                }
            }
        }

        private void gvElectrico_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            // Verificar si la columna actual es "Conforme"
            if (e.Column.FieldName == "conforme" || e.Column.FieldName == "no_conforme" || e.Column.FieldName == "no_aplica")
            {
                // Obtener el valor de la celda
                bool isConforme = Convert.ToBoolean(gvElectrico.GetRowCellValue(e.RowHandle, e.Column));

                // Cambiar el estilo si el valor es true
                if (isConforme)
                {
                    e.Appearance.BackColor = Color.LightGreen; // Cambia el color de fondo
                    //e.Appearance.ForeColor = Color.Black;     // Cambia el color del texto
                }
            }
        }

        private void gvCabinas_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            // Verificar si la columna actual es "Conforme"
            if (e.Column.FieldName == "conforme" || e.Column.FieldName == "no_conforme" || e.Column.FieldName == "no_aplica")
            {
                // Obtener el valor de la celda
                bool isConforme = Convert.ToBoolean(gvCabinas.GetRowCellValue(e.RowHandle, e.Column));

                // Cambiar el estilo si el valor es true
                if (isConforme)
                {
                    e.Appearance.BackColor = Color.LightGreen; // Cambia el color de fondo
                    //e.Appearance.ForeColor = Color.Black;     // Cambia el color del texto
                }
            }
        }

        private void gvTanques_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            // Verificar si la columna actual es "Conforme"
            if (e.Column.FieldName == "conforme" || e.Column.FieldName == "no_conforme" || e.Column.FieldName == "no_aplica")
            {
                // Obtener el valor de la celda
                bool isConforme = Convert.ToBoolean(gvTanques.GetRowCellValue(e.RowHandle, e.Column));

                // Cambiar el estilo si el valor es true
                if (isConforme)
                {
                    e.Appearance.BackColor = Color.LightGreen; // Cambia el color de fondo
                    //e.Appearance.ForeColor = Color.Black;     // Cambia el color del texto
                }
            }
        }

        private void gvParteInferior_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            // Verificar si la columna actual es "Conforme"
            if (e.Column.FieldName == "conforme" || e.Column.FieldName == "no_conforme" || e.Column.FieldName == "no_aplica")
            {
                // Obtener el valor de la celda
                bool isConforme = Convert.ToBoolean(gvParteInferior.GetRowCellValue(e.RowHandle, e.Column));

                // Cambiar el estilo si el valor es true
                if (isConforme)
                {
                    e.Appearance.BackColor = Color.LightGreen; // Cambia el color de fondo
                    //e.Appearance.ForeColor = Color.Black;     // Cambia el color del texto
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isCompleted = true;
            //detalle_inspeccion = new DataTable();

            foreach (var item in dsCheckList1.Caracteristica_Parte_Inferior)
            {
                if (!item.conforme && !item.no_aplica && !item.no_conforme)
                {
                    isCompleted = false;
                    break;
                }
            }

            if (isCompleted)
            {                     
                var respuesta = new frmDialogResult("Desea guardar la inspeccion?", frmDialogResult.MessageDialog.DialogResult);

                if (respuesta.ShowDialog() == DialogResult.Yes)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        bool esCompletado = false;

                        switch (transaccionActual)
                        {
                            case TipoTransaccion.Nuevo:
                                // Llamar al procedimiento almacenado
                                using (var connection = new SqlConnection(dp.ConnectionStringLOSA))
                                {
                                    connection.Open();

                                    var command = new SqlCommand("usp_InsertChecklist", connection);
                                    
                                        command.CommandType = CommandType.StoredProcedure;

                                        // Agregar parámetros para checklist_H
                                        command.Parameters.AddWithValue("@id_operador", slueOperador.EditValue);
                                        command.Parameters.AddWithValue("@fecha", deFecha.EditValue);
                                        //command.Parameters.AddWithValue("@numero_inspeccion", numeroInspeccion);
                                        command.Parameters.AddWithValue("@semana_inspeccion", lblSemana.Text);
                                        command.Parameters.AddWithValue("@id_item", slueEquipo.EditValue);
                                        command.Parameters.AddWithValue("@horometro_inicial", seHorometroI.EditValue);
                                        command.Parameters.AddWithValue("@horometro_final", seHorometroF.EditValue);
                                        command.Parameters.AddWithValue("@horometro_ultimo_mantenimiento", spHorometroUltimoMantenimiento.EditValue);
                                        command.Parameters.AddWithValue("@horometro_proximo_mantenimiento", seHorometroProximoManto.EditValue);
                                        command.Parameters.AddWithValue("@observaciones_H", txtObservaciones.Text);
                                        command.Parameters.AddWithValue("@usuario_creacion", user.Id);

                                        //Cargar datos de Motor
                                        foreach (var detalle in dsCheckList1.Caracteristica_Motor)
                                        {
                                            detalle_inspeccion.Rows.Add(detalle.id, detalle.conforme, detalle.no_conforme, detalle.no_aplica, detalle.observaciones);
                                        //detalle_inspeccion.Rows.Add(0, true, false, false, "HOLA");
                                    }

                                        //Cargar datos de Electrico
                                        foreach (var detalle in dsCheckList1.Caracteristica_Electrico)
                                        {
                                            detalle_inspeccion.Rows.Add(detalle.id, detalle.conforme, detalle.no_conforme, detalle.no_aplica, detalle.observaciones);
                                        }

                                        //Cargar datos de Cabinas
                                        foreach (var detalle in dsCheckList1.Caracteristica_Cabinas)
                                        {
                                            detalle_inspeccion.Rows.Add(detalle.id, detalle.conforme, detalle.no_conforme, detalle.no_aplica, detalle.observaciones);
                                        }

                                        //Cargar datos de Tanque
                                        foreach (var detalle in dsCheckList1.Caracteristica_Tanques)
                                        {
                                            detalle_inspeccion.Rows.Add(detalle.id, detalle.conforme, detalle.no_conforme, detalle.no_aplica, detalle.observaciones);
                                        }

                                        //Cargar datos de Parte Inferior
                                        foreach (var detalle in dsCheckList1.Caracteristica_Parte_Inferior)
                                        {
                                            detalle_inspeccion.Rows.Add(detalle.id, detalle.conforme, detalle.no_conforme, detalle.no_aplica, detalle.observaciones);
                                        }


                                        var tableParam = command.Parameters.AddWithValue("@detalle_inspeccion", detalle_inspeccion);
                                            tableParam.SqlDbType = SqlDbType.Structured;

                                        // Ejecutar el procedimiento
                                        command.ExecuteNonQuery();
                                    connection.Close();
                                    esCompletado = true;
                                    
                                }

                                if (esCompletado)
                                {
                                    var mensaje = new frmDialogResult("Inspección Creada con Éxito", frmDialogResult.MessageDialog.Message);

                                    if (mensaje.ShowDialog()== DialogResult.OK)
                                    {
                                        this.DialogResult = DialogResult.OK;
                                    }
                                }
                                break;
                            case TipoTransaccion.Update:
                                break;                    
                        }
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
            }
            else
            {
                var respuesta = new frmDialogResult("No ha verificado todas las caracteristica", frmDialogResult.MessageDialog.Message);

                respuesta.ShowDialog();
                return;

            }
            
        }
      

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var respuesta = new frmDialogResult("Desea Cerrar la inspección?", frmDialogResult.MessageDialog.DialogResult);

            if (respuesta.ShowDialog() == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

       

        private void seHonometroI_Click(object sender, EventArgs e)
        {
            TextEdit textEdit = sender as TextEdit;
            if (textEdit != null)
            {
                // Forzar la selección del texto después de que el control reciba el foco
                BeginInvoke(new Action(() =>
                {
                    textEdit.SelectAll();
                }));
            }
        }

        private void seHorometroF_Click(object sender, EventArgs e)
        {
            TextEdit textEdit = sender as TextEdit;
            if (textEdit != null)
            {
                // Forzar la selección del texto después de que el control reciba el foco
                BeginInvoke(new Action(() =>
                {
                    textEdit.SelectAll();
                }));
            }
        }

        private void spinEdit2_Click(object sender, EventArgs e)
        {
            TextEdit textEdit = sender as TextEdit;
            if (textEdit != null)
            {
                // Forzar la selección del texto después de que el control reciba el foco
                BeginInvoke(new Action(() =>
                {
                    textEdit.SelectAll();
                }));
            }
        }

        private void spinEdit1_Click(object sender, EventArgs e)
        {
            TextEdit textEdit = sender as TextEdit;
            if (textEdit != null)
            {
                // Forzar la selección del texto después de que el control reciba el foco
                BeginInvoke(new Action(() =>
                {
                    textEdit.SelectAll();
                }));
            }
        }
    }
}