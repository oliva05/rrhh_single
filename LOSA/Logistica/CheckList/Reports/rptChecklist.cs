using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using LOSA.Logistica.CheckList.Models;

namespace LOSA.Logistica.CheckList.Reports
{
    public partial class rptChecklist : DevExpress.XtraReports.UI.XtraReport
    {
        public rptChecklist(long id_checklist)
        {
            InitializeComponent();
            CargarCheckList_Detail(id_checklist);
            CheckList_Header checklist = new CheckList_Header();

            if (checklist.RecuperarRegistroPorId(id_checklist))
            {
                lblOperador.Text = checklist.Operador;
                lblEquipo.Text = checklist.Equipo;
                lblModelo.Text = checklist.Modelo;
                lblInspeccion.Text = checklist.NumeroInspeccion;
                lblSemanaInspeccion.Text = checklist.SemanaIspeccion.ToString();
                lblHorometroI.Text = checklist.HorometroInicial.ToString();
                lblHorometroF.Text = checklist.HorometroFinal.ToString();
                tcHorometroI.Text = checklist.HorometroInicial.ToString();
                tcHorometroF.Text = checklist.HorometroFinal.ToString();
                xrtcFecha.Text =  Convert.ToDateTime (checklist.Fecha).ToString("dd-MM-yyyy");
                lblHorometroUlt.Text = checklist.HorometroUltimoMantenimiento.ToString();
                lblHorometroProxi.Text = checklist.HorometroProximoMantenimiento.ToString();
                rtObservaciones.Html = "<strong style=\"font-size: 12px;font-family: 'Segoe UI';\">OBSERVACIONES: </strong>" + " "+checklist.Observaciones;
               
            }
            
        }

        public void CargarCheckList_Detail(long id_checklist)
        {
            try
            {
                DataOperations dp = new DataOperations();
           

                dsCheckList1.rpt_checklist_detail.Clear();

                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    SqlCommand cmd = new SqlCommand("dbo.uspRPT_checklist_detail", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_checklist",id_checklist);

                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dsCheckList1.rpt_checklist_detail);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void Detail_BeforePrint(object sender, CancelEventArgs e)
        {
            //XRTableCell cell = sender as XRTableCell;
            //if (cell != null)
            //{
            //    int idGrupo = Convert.ToInt32(GetCurrentColumnValue("id_grupo"));
            //    if (idGrupo != 1)
            //    {
            //        cell.Borders = DevExpress.XtraPrinting.BorderSide.None;
            //    }
            //    else
            //    {
            //        cell.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            //    }
            //}
        }

        private void xrTableCell3_BeforePrint(object sender, CancelEventArgs e)
        {
            //var cell = sender as XRTableCell;

            //if (cell != null)
            //{
            //    var idGrupo = GetCurrentColumnValue("id_grupo");

            //    // Oculta la celda inferior si está combinada
            //    if (idGrupo != null && Convert.ToInt32(idGrupo) == 1)
            //    {
            //        cell.Visible = false; // Oculta esta celda
            //    }
            //    else
            //    {
            //        cell.Visible = true; // Restaura visibilidad
            //    }
            //}
        }

        private void xrTableCell2_BeforePrint(object sender, CancelEventArgs e)
        {
            // Obtén el valor actual de id_grupo
            //var idGrupo = Convert.ToInt32(GetCurrentColumnValue("id_grupo"));

            //// Si id_grupo es distinto de 1, combina las celdas
            //if (idGrupo == 1)
            //{
            //    // Configura el texto de la primera celda con ambos valores
            //    xrTableCell2.Text = $"{xrTableCell2.Text}";

            //    // Oculta el contenido de la segunda celda
            //    xrTableCell3.Text = string.Empty;

            //    // Ajusta el ancho de la primera celda para abarcar ambas
            //    xrTableCell2.WidthF += xrTableCell3.WidthF;


            //    xrTableCell2.Borders =  DevExpress.XtraPrinting.BorderSide.Bottom | DevExpress.XtraPrinting.BorderSide.Left;
            //    xrTableCell2.BackColor = Color.LightBlue; // Color del borde
            //    xrTableCell3.BorderColor = Color.Black; // Color del borde
            //    //xrTableCell3.BackColor = Color.Green; // Color del borde
            //    //xrTableCell4.BackColor = Color.Red; // Color del borde


            //    xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            //    //xrTableCell3.BorderColor = Color.Red; // Color del borde
            //    //xrTableCell3.WidthF = 0;
            //}
            //else
            //{
            //    //xrTableCell3.BorderWidth = 1; // Ancho del borde de 1
            //    // Asegúrate de restaurar los valores si no cumplen la condición
            //    xrTableCell2.WidthF = 100; // Cambia por el ancho original
            //    xrTableCell3.WidthF = 100; // Cambia por el ancho original
            //    xrTableCell3.Borders =   DevExpress.XtraPrinting.BorderSide.Right;
            //    //xrTableCell3.BorderColor = Color.YellowGreen; // Color del borde
            //}


            //var cell = sender as XRTableCell;
            
            //if (cell != null)
            //{
            //    var idGrupo = GetCurrentColumnValue("id_grupo");

            //    // Oculta la celda inferior si está combinada
            //    if (idGrupo != null && Convert.ToInt32(idGrupo) == 1)
            //    {
            //        cell.Visible = false; // Oculta esta celda
            //    }
            //    else
            //    {
            //        cell.Visible = true; // Restaura visibilidad
            //    }
            //}


        }

        // Variable para almacenar el ancho original de la celda
        private float originalWidth;
        private void xrTableRow1_BeforePrint(object sender, CancelEventArgs e)
        {
            // Obtén el valor de id_grupo de los datos vinculados
            var currentValue = GetCurrentColumnValue("id_grupo");

            // Si es la primera vez, guarda el ancho original
            if (originalWidth == 0)
            {
                originalWidth = xrTableCell2.WidthF;
            }

            // Verifica si el valor es igual a 1
            if (currentValue != null && Convert.ToInt32(currentValue) == 1)
            {
                // Combina las celdas
                xrTableCell2.Text = $"{xrTableCell2.Text}";

                //// Limpia el texto de la segunda celda
                xrTableCell3.Text = string.Empty;

                // Ajusta el ancho de la celda combinada
                xrTableCell2.WidthF += xrTableCell3.WidthF;

                //xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Left;

                //xrTableCell3.BackColor = Color.LightBlue; // Color del borde
                xrTableCell3.Borders &= ~DevExpress.XtraPrinting.BorderSide.Left;
            }
            else
            {
                xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom | DevExpress.XtraPrinting.BorderSide.Left;

                // Restaurar configuración normal si no aplica la condición
                xrTableCell2.WidthF = originalWidth;

                //xrTableCell3.Visible = true;
            }
        }
    }
}
