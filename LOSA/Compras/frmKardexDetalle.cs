using ACS.Classes;
using DevExpress.XtraEditors;
using ERP_INTECOLI.Compras;
using LOSA.MicroIngredientes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LOSA.Compras
{
    public partial class frmKardexDetalle : DevExpress.XtraEditors.XtraForm
    {
        string Capitulo;
        string PartidaArancelaria;
        int IdExoneracion;

        public enum TipoOperacion
        {
            DetalleOC = 1,
            DetalleKardex = 2
        }
        
        
        public frmKardexDetalle(string pcapitulo, string ppartida_aran, frmKardexDetalle.TipoOperacion tipoOperacion, int pIdExoneracion)
        {
            InitializeComponent();
            IdExoneracion = pIdExoneracion;
            //xtraTabControl1.SelectedTabPageIndex = 1;


            FormatoControles();
           

            switch (tipoOperacion)
            {
                case TipoOperacion.DetalleOC:

                    txtCapitulo.Text = Capitulo = pcapitulo;
                    txtPartidaArancelaria.Text = PartidaArancelaria = ppartida_aran;
                    if (PartidaArancelaria.Length > 2)
                    {
                        txtPartidaArancelaria.Visible = true;
                        labelControl1.Visible = true;
                    }
                    else
                    {
                        txtPartidaArancelaria.Visible = false;
                        labelControl1.Visible = false;
                    }
                    LoadData();

                    break;
                case TipoOperacion.DetalleKardex:
                    txtCapitulo.Text = Capitulo = pcapitulo;
                    txtPartidaArancelaria.Text = PartidaArancelaria = ppartida_aran;
                    if (PartidaArancelaria.Length > 2)
                    {
                        txtPartidaArancelaria.Visible = true;
                        labelControl1.Visible = true;
                    }
                    else
                    {
                        txtPartidaArancelaria.Visible = false;
                        labelControl1.Visible = false;
                    }
                    LoadDataKardex();
                    LoadData();

                    break;
                default:
                    break;
            }

            

        }

        private void FormatoControles()
        {
            txtCargaInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtCargaInicial.Properties.Mask.EditMask = "#,##0.00";
            txtCargaInicial.Properties.Mask.UseMaskAsDisplayFormat = true;

            txtExistencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtExistencia.Properties.Mask.EditMask = "#,##0.00";
            txtExistencia.Properties.Mask.UseMaskAsDisplayFormat = true;

            txtSaldoConsumido.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtSaldoConsumido.Properties.Mask.EditMask = "#,##0.00";
            txtSaldoConsumido.Properties.Mask.UseMaskAsDisplayFormat = true;

            txtGridResta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtGridResta.Properties.Mask.EditMask = "#,##0.00";
            txtGridResta.Properties.Mask.UseMaskAsDisplayFormat = true;
   
        }

        private void LoadDataKardex()
        {
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"[sp_get_movimientos_kardex_por_capitulo_y_partida]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Capitulo", Capitulo);
                cmd.Parameters.AddWithValue("@PartidaArancelaria", PartidaArancelaria);
                if (PartidaArancelaria.Length > 2)
                    cmd.Parameters.AddWithValue("@tipo_busqueda", 2);
                else
                    cmd.Parameters.AddWithValue("@tipo_busqueda", 1);
                cmd.Parameters.AddWithValue("@IdExoneracion", IdExoneracion);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.move_kardex.Clear();
                adat.Fill(dsCompras1.move_kardex);

                decimal Entrada = 0;
                decimal Salida = 0;
                foreach (dsCompras.move_kardexRow item in dsCompras1.move_kardex)
                {
                    Entrada += item.entrada;
                    Salida += item.salida;
                }

                txtGridResta.EditValue = Entrada - Salida;

                SqlCommand cmd1 = new SqlCommand("sp_get_carga_inicial_y_disponibilidad_for_id_exo", conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@Capitulo", Capitulo);
                cmd1.Parameters.AddWithValue("@PartidaArancelaria", PartidaArancelaria);
                if (PartidaArancelaria.Length > 2)
                    cmd1.Parameters.AddWithValue("@tipo_busqueda", 2);
                else
                    cmd1.Parameters.AddWithValue("@tipo_busqueda", 1);
                cmd1.Parameters.AddWithValue("@IdExoneracion", IdExoneracion);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    txtCargaInicial.Text = dr.GetDecimal(0).ToString();
                    txtExistencia.Text = dr.GetDecimal(1).ToString();
                    txtSaldoConsumido.Text = dr.GetDecimal(2).ToString();
                    dr.Close();
                }


                conn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadData()
        {
            
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"sp_get_detalle_por_capitulo_y_partida";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Capitulo",Capitulo);
                cmd.Parameters.AddWithValue("@PartidaArancelaria",PartidaArancelaria);
                if (PartidaArancelaria.Length > 2)
                    cmd.Parameters.AddWithValue("@tipo_busqueda", 2);
                else
                    cmd.Parameters.AddWithValue("@tipo_busqueda", 1);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.kardex_detalle.Clear();
                adat.Fill(dsCompras1.kardex_detalle);
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
    }
}