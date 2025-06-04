using ACS.Classes;
using DevExpress.Charts.Native;
using DevExpress.Data.Browsing.Design;
using DevExpress.XtraEditors;
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

namespace LOSA.Compras
{
    public partial class frmAddGastosAdicionales : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public decimal TotalGastos = 0;
        int IdOrdenCompra = 0;
        public DataTable MyTable = new DataTable();
        DataTable MyTableByName = new DataTable("MyTableName");
        public enum TipoOperacion
        {
            Nuevo = 1,
            Editar = 2,
            Vista = 3
        }

        int IdEstadoOC;

        TipoOperacion tipoOP;
        public frmAddGastosAdicionales(int pIdOrdenC, int pIdEstadoCompra)
        {
            InitializeComponent();
            IdEstadoOC = pIdEstadoCompra;
            IdOrdenCompra = pIdOrdenC;
            switch (IdEstadoOC)
            {
                default:
                    break;
            }

            LoadConceptos();
            LoadMetodoDistribucion();

            LoadGastosAdicionales();
        }

        public frmAddGastosAdicionales(int pIdOrdenC, int pIdEstadoCompra, DataTable pmytable)
        {
            InitializeComponent();
            IdEstadoOC = pIdEstadoCompra;
            IdOrdenCompra = pIdOrdenC;

            switch (IdEstadoOC)
            {
                default:
                    break;
            }

            LoadConceptos();
            LoadMetodoDistribucion();
            MyTableByName = pmytable;
            LoadGastosAdicionales();


            foreach (dsCompras.gastos_adicionalesRow item in dsCompras1.gastos_adicionales)
            {
                foreach (DataRow rowTable in MyTableByName.Rows)
                {
                    if (item.expnscode == rowTable[0].ToString())
                    {
                        item.expnscode = rowTable[0].ToString();
                        item.taxcode = rowTable[1].ToString();
                        item.import_isv = Convert.ToDecimal(rowTable[2]);
                        item.mtd_distrb = rowTable[3].ToString();
                        item.importa_total = Convert.ToDecimal(rowTable[4]);
                        item.id_detalle_gasto = Convert.ToInt32(rowTable[5]);
                    }
                   
                }
            }


        }

        private void LoadMetodoDistribucion()
        {
            try
            {
                string query = @"sp_cm_get_gastos_metodos_distribucion";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.metodo_distribucion_gastos.Clear();
                adat.Fill(dsCompras1.metodo_distribucion_gastos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadConceptos()
        {
            try
            {
                string query = @"sp_get_lista_gastos_adicionales";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.expnscode.Clear();
                adat.Fill(dsCompras1.expnscode);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadGastosAdicionales()
        {
            try
            {
                string query = @"sp_get_conceptos_gastos_adicionales";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ordenh", IdOrdenCompra);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.gastos_adicionales.Clear();
                adat.Fill(dsCompras1.gastos_adicionales);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            foreach (dsCompras.gastos_adicionalesRow item in dsCompras1.gastos_adicionales.Rows)
            {
                if (item.importa_total < 0)
                {
                    CajaDialogo.Error("No puede ser menor que 0");
                    return;
                }
            }


            
            
            MyTable.Columns.Add("expnscode", typeof(int));
            MyTable.Columns.Add("taxcode", typeof(string));
            MyTable.Columns.Add("import_isv", typeof(decimal));
            MyTable.Columns.Add("mtd_distrb", typeof(string));
            MyTable.Columns.Add("importa_total", typeof(decimal));
            MyTable.Columns.Add("id_detalle_gasto", typeof(int));


            MyTable.Clear();

            foreach (dsCompras.gastos_adicionalesRow item in dsCompras1.gastos_adicionales.Rows)
            {
                DataRow row = MyTable.NewRow();
                row["expnscode"] = item.expnscode;
                row["taxcode"] = item.taxcode;
                row["import_isv"] = item.import_isv;
                row["mtd_distrb"] = item.mtd_distrb;
                row["importa_total"] = item.importa_total;
                row["id_detalle_gasto"] = item.id_detalle_gasto;
                TotalGastos += item.importa_total;
                MyTable.Rows.Add(row);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

            //SqlTransaction transaction = null;

            //SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            //bool Guardar = false;

            //try
            //{
            //    conn.Open();
            //    transaction = conn.BeginTransaction("Transaction Order");

            //    SqlCommand cmd = conn.CreateCommand();

            //    foreach (dsCompras.gastos_adicionalesRow item in dsCompras1.gastos_adicionales.Rows)
            //    {
            //        if (item.id_detalle_gasto == 0) //INSERT
            //        {
            //            if (item.importa_total > 0)
            //            {
            //                cmd.CommandText = "sp_insert_gastos_adicionales";
            //                cmd.Connection = conn;
            //                cmd.Transaction = transaction;
            //                cmd.CommandType = CommandType.StoredProcedure;
            //                cmd.Parameters.AddWithValue("@id_orden_h", IdOrdenCompra);
            //                cmd.Parameters.AddWithValue("@taxcode", item.taxcode);
            //                cmd.Parameters.AddWithValue("@import_isv", item.import_isv);
            //                cmd.Parameters.AddWithValue("@mtd_distrb", item.mtd_distrb);
            //                cmd.Parameters.AddWithValue("@importa_total", item.importa_total);
            //                cmd.Parameters.AddWithValue("@id_expns_code", item.expnscode);
            //                cmd.ExecuteNonQuery();
            //            }

            //        }
            //        else
            //        {
            //            cmd.Parameters.Clear();
            //            cmd.CommandText = "sp_update_gastos_adicionales";
            //            cmd.Connection = conn;
            //            cmd.Transaction = transaction;
            //            cmd.CommandType = CommandType.StoredProcedure;
            //            cmd.Parameters.AddWithValue("@id", item.id);
            //            cmd.Parameters.AddWithValue("@id_orden_h", IdOrdenCompra);
            //            cmd.Parameters.AddWithValue("@taxcode", item.taxcode);
            //            cmd.Parameters.AddWithValue("@import_isv", item.import_isv);
            //            cmd.Parameters.AddWithValue("@mtd_distrb", item.mtd_distrb);
            //            cmd.Parameters.AddWithValue("@importa_total", item.importa_total);
            //            cmd.Parameters.AddWithValue("@id_expns_code", item.expnscode);
            //            cmd.ExecuteNonQuery();
            //        }
            //    }

            //    transaction.Commit();

            //    Guardar = true;

            //    if(Guardar)
            //    {
            //        foreach (dsCompras.gastos_adicionalesRow row in dsCompras1.gastos_adicionales)
            //        {
            //            TotalGastos += row.importa_total;
            //        }

            //    }

            //    this.DialogResult = DialogResult.OK;
            //    this.Close();

            //}
            //catch (Exception ec)
            //{
            //    transaction.Rollback();
            //    CajaDialogo.Error(ec.Message);
            //    Guardar = false;
            //}

        }
    }
}