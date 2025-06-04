﻿using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class Proveedor
    {
        public string Codigo;
        public string Nombre;
        public string NombreF;
        public string RTN;
        public string Contacto;
        public string Telefono1;
        public string Telefono2;
        public string Telefono3;
        public string Direccion;
        public string Correo;
        public bool Recuperado;
        public int IdRiesgo;
        public bool Auditoria;
        public int IdAprobacion;
        public string Moneda;
        public int ContactCode;
        public string ContactName;

        public string TerminoPago;
        public Proveedor()
        {
        }

        public bool RecuperarRegistro(string pCodigo)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_datos_proveedor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", pCodigo);
                if (pCodigo == "")
                {
                    Nombre = "Aquafeed S.A de C.V.";
                }
                else
                {
                    Codigo = pCodigo;
                    Nombre = cmd.ExecuteScalar().ToString();
                }
                Recuperado = true;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            return Recuperado;
        }

        public bool RecuperarRegistroWithRTN(string pCodigo)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_datos_proveedorv3]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", pCodigo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IdRiesgo = 0;
                    IdAprobacion = 0;
                    Auditoria = false;

                    Codigo = pCodigo;
                    Nombre = dr.GetString(0);
                    NombreF = dr.GetString(1);
                    RTN = dr.GetString(2);
                    Contacto = dr.GetString(3);
                    Telefono1 = dr.GetString(4);
                    Telefono2 = dr.GetString(5);
                    Telefono3 = dr.GetString(6);
                    Direccion = dr.GetString(7);
                    Correo = dr.GetString(8);
                    if (!dr.IsDBNull(dr.GetOrdinal("id_riesgo")))
                        IdRiesgo = dr.GetInt32(9);
                    if (!dr.IsDBNull(dr.GetOrdinal("auditoria")))
                        Auditoria = dr.GetBoolean(10);
                    if (!dr.IsDBNull(dr.GetOrdinal("id_aprobacion")))
                        IdAprobacion = dr.GetInt32(11);
                    Moneda = dr.GetString(12);
                    ContactCode = dr.GetInt32(13);
                    ContactName = dr.GetString(14);
                    TerminoPago = dr.GetString(15);
                    Recuperado = true;
                }
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            return Recuperado;
        }

        internal bool UpdateDatos(object val, int option_, bool bit_ , string pCardCode)
        {
            bool a = false;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_update_master_data_proveedores_losa", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@option", option_);
                cmd.Parameters.AddWithValue("@bit", bit_);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(val));
                cmd.Parameters.AddWithValue("@cardcode", pCardCode);
                cmd.ExecuteNonQuery();
                a = true;
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return a;
        }
    }
}
