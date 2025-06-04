﻿using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RecepcionMP
{
    public partial class frmMP_Granel : Form
    {
        UserLogin UsuarioLogeado;
        ArrayList list = new ArrayList();
        ArrayList listMP = new ArrayList();
        int id_lote_Traslado, id_transferencia_h;
        string itemcode;
        decimal InAlmacenExterno;
        dsWizard dsWizard;
        bool istraslado;
        public frmMP_Granel(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadData();
            LoadBarcos();
            LoadUbicaciones();
        }

        public frmMP_Granel(UserLogin pUsuarioLogeado, bool Istraslado, int idLote, int pid_transferencia_h)
        {
            InitializeComponent();
            id_lote_Traslado = idLote;
            istraslado = Istraslado;
            UsuarioLogeado = pUsuarioLogeado;
            id_transferencia_h = pid_transferencia_h;
            LoadData();
            LoadBarcos();
            LoadUbicaciones();

        }

   
        


        private void LoadUbicaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);

                string SQL = @"sp_get_lista_ubicaciones_granel";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@codigo_barra", "");
                dsRecepcionMPx1.ubicaciones_granel.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.ubicaciones_granel);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void LoadBarcos()
        {
            //
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_ships_active_for_losa", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsRecepcionMPx1.barcos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.barcos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadData_by_item()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_ingresos_granel_mp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsRecepcionMPx1.granel.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.granel);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_ingresos_granel_mp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsRecepcionMPx1.granel.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.granel);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdPasarAlosy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Registrar en ALOSY

        }

        private void cmdLoteActivo_Click(object sender, EventArgs e)
        {
            if (istraslado)
            {
                frmLoteActvoGranel frm = new frmLoteActvoGranel(UsuarioLogeado,id_lote_Traslado);
                frm.Show();
            }
            else
            {
                frmLoteActvoGranel frm = new frmLoteActvoGranel(UsuarioLogeado);
                frm.Show();
            }
        }

        private void checkBoxSeleccionarTodas_CheckedChanged(object sender, EventArgs e)
        {
            var gridView = (GridView)gcMP.FocusedView;
            int conta = dsRecepcionMPx1.granel.Count;

            for (int i = 0; i < conta; i++)
            {
                dsRecepcionMPx.granelRow row = (dsRecepcionMPx.granelRow)gridView.GetDataRow(i);

                int r = gridView.GetVisibleRowHandle(i);
                if (r >= 0)
                {
                    if (row != null)
                    {
                        row.seleccionar = checkBoxSeleccionarTodas.Checked;
                    }
                }
                else
                {
                    if (row != null)
                        row.seleccionar = false;
                }
            }

            //foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            //{
            //    row.seleccionar = checkBoxSeleccionarTodas.Checked;
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Generar ingreso de granel
            int Total = 0;
            foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            {
                if (row.seleccionar)
                {
                    Total++;
                }
            }
            if(Total == 0)
            {
                CajaDialogo.Error("¡Es necesario seleccionar al menos una boleta!");
                return;
            }

            //Agregamos las boletas seleccionadas
            list = new ArrayList();
            foreach (dsRecepcionMPx.granelRow row in dsRecepcionMPx1.granel.Rows)
            {
                if (row.seleccionar)
                {
                    AddItemCode(row.itemcode, row.Producto);
                }
            }

            frmMP_Granel_Selec_Lote frm = new frmMP_Granel_Selec_Lote(list);
            if(frm.ShowDialog()== DialogResult.OK)
            {
                ArrayList ListaRes = frm.ListaResultados;
                foreach(ItemMP_Lote Item in ListaRes)
                {
                    //hacer la lista de boletas.
                    ArrayList ListaBoletas = new ArrayList();
                    foreach(dsRecepcionMPx.granelRow row_granel in dsRecepcionMPx1.granel.Rows)
                    {
                        if (row_granel.seleccionar)
                        {
                            if(row_granel.itemcode == Item.ItemCode)
                            {
                                ListaBoletas.Add(row_granel);
                            }
                        }
                    }

                    if (istraslado)
                    {
                        frmIngresoGranelAlosy frm1 = new frmIngresoGranelAlosy(this.UsuarioLogeado, ListaBoletas, Item,istraslado, id_lote_Traslado, id_transferencia_h);
                        if (frm1.ShowDialog() == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                    else
                    {
                        frmIngresoGranelAlosy frm1 = new frmIngresoGranelAlosy(this.UsuarioLogeado, ListaBoletas, Item);
                        if (frm1.ShowDialog() == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                }
            }

            //frmIngresoGranelAlosy frm = new frmIngresoGranelAlosy(this.UsuarioLogeado,list);
            //frm.Show();
        }

        private void AddItemCode(string itemcode, string pName)
        {
            if(list.Count == 0)
            {
                //Lo agregamos por que es el primero
                ItemMP_Lote Item = new ItemMP_Lote();
                Item.ItemCode = itemcode;
                Item.Card_Name = pName;
                
                list.Add(Item);
            }
            else
            {
                //Vamos a verificar si el codigo esta en lista
                bool Exist = false;
                foreach (ItemMP_Lote vItemCode in list)
                {
                    if(itemcode == vItemCode.ItemCode)
                    {
                        Exist = true;
                    }
                }

                //Si el codigo no esta en lista lo vamos agregar
                if (!Exist)
                {
                    ItemMP_Lote Item = new ItemMP_Lote
                    {
                        ItemCode = itemcode,
                        Card_Name = pName
                    };
                    list.Add(Item);
                }

            }
        }

        private void AddItemCodeMP(string itemcode, string pName)
        {
            if (listMP == null)
                listMP = new ArrayList();
        
            if (listMP.Count == 0)
            {
                //Lo agregamos por que es el primero
                MateriaPrima Item = new MateriaPrima();
                Item.CodeMP_SAP = itemcode;
                Item.Name = pName;
                listMP.Add(Item);
            }
            else
            {
                //Vamos a verificar si el codigo esta en lista
                bool Exist = false;
                foreach (MateriaPrima vItemCode in listMP)
                {
                    if (itemcode == vItemCode.CodeMP_SAP)
                        Exist = true;
                }

                //Si el codigo no esta en lista lo vamos agregar
                if (!Exist)
                {
                    MateriaPrima Item = new MateriaPrima
                    {
                        CodeMP_SAP = itemcode,
                        Name = pName
                    };
                    listMP.Add(Item);
                }

            }
        }

        private void cmdChangeRM_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            

        }

        private void cmdChangeMP_Click(object sender, EventArgs e)
        {
            
        }

        private void gvMP_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                popupMenuClickDerecho.ShowPopup(Cursor.Position);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Click 
            int Total = 0;
            foreach (dsRecepcionMPx.granelRow row_i in dsRecepcionMPx1.granel.Rows)
            {
                if (row_i.seleccionar)
                {
                    Total++;
                }
            }
            if (Total == 0)
            {
                CajaDialogo.Error("¡Es necesario seleccionar al menos una boleta!");
                return;
            }

            //Agregamos las boletas seleccionadas
            listMP = new ArrayList();
            foreach (dsRecepcionMPx.granelRow row_i in dsRecepcionMPx1.granel.Rows)
            {
                if (row_i.seleccionar)
                    if (row_i.itemcode.Trim() == "MP00003" || row_i.itemcode.Trim() == "MP00004")
                        AddItemCodeMP(row_i.itemcode, row_i.Producto);
            }

            if (listMP.Count > 0)
            {
                frmMP_Granel_Selec_MP frm = new frmMP_Granel_Selec_MP(listMP, "");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    foreach (dsRecepcionMPx.granelRow row_granel in dsRecepcionMPx1.granel.Rows)
                    {
                        if (row_granel.seleccionar)
                        {
                            if (row_granel.itemcode.Trim() == "MP00003" || row_granel.itemcode.Trim() == "MP00004")
                            {
                                row_granel.itemcode = frm.ItemSelected.CodeMP_SAP;
                                row_granel.Producto = frm.ItemSelected.Name;
                            }
                        }
                    }
                }
            }
            else
            {
                CajaDialogo.Error("¡Solo se permite cambiar Boletas de Materia Prima: Harina de Soya!");
            }
        }







    }
}
