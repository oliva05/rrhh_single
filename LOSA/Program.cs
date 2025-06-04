﻿using ACS.Classes;
using LOSA.Produccion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string name_ = Environment.MachineName.ToString();
            DataOperations dp = new DataOperations();
            string query = "sp_get_verify_is_tablet_alosy";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            bool val = true;
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name_", name_);
                val = Convert.ToBoolean(cmd.ExecuteScalar());
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error al cargar la informacion: " + ex.Message);
            }

            if(val)//es una tablet encontrada en el registro
                Application.Run(new frmMain());
            else
                Application.Run(new MDIParentFormLOSA());

            
            //
        }
    }
}
