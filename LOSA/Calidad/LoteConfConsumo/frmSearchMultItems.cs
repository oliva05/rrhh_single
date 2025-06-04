using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.RRHH_Planilla.Planilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Calidad.LoteConfConsumo
{
    public partial class frmSearchMultItems : DevExpress.XtraEditors.XtraForm
    {
        //public MateriaPrima MateriaPrimaSelected;
        DataOperations dp = new DataOperations();
        //public ItemBusqueda ItemSeleccionado;
        DataView dv;// = new DataView(dsConfigLoteConsumo1.search_mp);
        string StoreProcedureConfigActual = "";
        int IdPayslipRun;
        public List<ItemBusqueda> list = new List<ItemBusqueda>(); 
        public enum TipoBusqueda
        {
            Empleados = 1,
            ListaEmpleados = 2,
            EmpleadosDepreciacion = 3,
            PrestamoDepreciacion = 4
        }

        TipoBusqueda TipoBusquedaActual;

        public frmSearchMultItems(TipoBusqueda pTipo, int pIdPayslipRun)
        {
            InitializeComponent();
            TipoBusquedaActual = pTipo;
            StoreProcedureConfigActual = "dbo.[sp_get_lista_empleados]";
            IdPayslipRun = pIdPayslipRun;

            //MateriaPrimaSelected = new MateriaPrima();
            switch (TipoBusquedaActual)
            {
                case TipoBusqueda.Empleados:
                    LoadData();
                    break;

                case TipoBusqueda.ListaEmpleados:
                    LoadData();
                    break;
                case TipoBusqueda.EmpleadosDepreciacion:
                    LoadData();
                    break;

                case TipoBusqueda.PrestamoDepreciacion:
                    LoadData();
                    break;

                default:
                    break;
            }
            //ItemSeleccionado = new ItemBusqueda();


        }

        private void LoadData()
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection(dp.ConnectionStringRRHH);

                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[sp_get_lista_empleados]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@parametro_busqueda", Convert.ToInt32(TipoBusquedaActual));
                cmd.Parameters.AddWithValue("@id_payslip_run", IdPayslipRun);

                dsPlanillasCalculo1.search_employee.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPlanillasCalculo1.search_employee);

                dv = new DataView(dsPlanillasCalculo1.search_employee);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmSearchMultItems_Activated(object sender, EventArgs e)
        {
            txtParametroBusqueda.Focus();
        }

        private void txtParametroBusqueda_EditValueChanged(object sender, EventArgs e)
        {
            dv.RowFilter = @"[concat_] like '%" + txtParametroBusqueda.Text + "%'";
            gridControlDetalleMP.DataSource = dv;
        }

        private void txtParametroBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (dv.Count == 1)
            //    {
            //        var gridView = (GridView)gridControlDetalleMP.FocusedView;
            //        var row = (dsPlanillasCalculo.search_employeeRow)gridView.GetDataRow(0);

            //        list.Add= row.id;
            //        ItemSeleccionado.ItemCode = row.ItemCode;
            //        ItemSeleccionado.ItemName = row.Name_;
            //        row.Seleccionado = true;
            //        cmdAplicar_Click(new object(), new EventArgs());
            //    }
            //}
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
           

            foreach (dsPlanillasCalculo.search_employeeRow item in dsPlanillasCalculo1.search_employee.Rows)
            {
                if (item.Seleccionado)
                {
                    list.Add(new ItemBusqueda { id = item.id, ItemCode = item.ItemCode, ItemName = item.Name_ });
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}