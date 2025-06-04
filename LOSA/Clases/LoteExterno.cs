using ACS.Classes;
using DevExpress.XtraEditors.Repository;
using LOSA.MigracionACS.MP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class LoteExterno
    {
        public LoteExterno() { }

        DataOperations dp = new DataOperations();
        private int idLoteExterno;
        private int idPresentacion;
        private string lote;
        private int idDetalle;
        private DateTime fechaVencimiento;
        private DateTime fechaProduccion;
        private string bodega;
        private int idMp;

        public int IdLoteExterno { get => idLoteExterno; set => idLoteExterno = value; }
        public int IdPresentacion { get => idPresentacion; set => idPresentacion = value; }
        public string Lote { get => lote; set => lote = value; }
        public int IdDetalle { get => idDetalle; set => idDetalle = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public DateTime FechaProduccion { get => fechaProduccion; set => fechaProduccion = value; }
        public string Bodega { get => bodega; set => bodega = value; }
        public int IdMp { get => idMp; set => idMp = value; }

        public bool RecuperarInfoLotesExternos(int pIdMP, string pLote) 
        {
            bool vale = false;
            try
            {
                
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_info_lote_externo_for_lote", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMp", pIdMP);
                cmd.Parameters.AddWithValue("@lote", pLote);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IdLoteExterno = reader.IsDBNull(reader.GetOrdinal("id_lote_externo")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_lote_externo"));
                    Lote = reader.IsDBNull(reader.GetOrdinal("lote")) ? "" : reader.GetString(reader.GetOrdinal("lote"));
                    IdDetalle = reader.IsDBNull(reader.GetOrdinal("id_detalle")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_detalle"));
                    FechaVencimiento = reader.IsDBNull(reader.GetOrdinal("fecha_vencimiento")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("fecha_vencimiento"));
                    FechaProduccion = reader.IsDBNull(reader.GetOrdinal("fecha_produccion")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("fecha_produccion"));
                    IdPresentacion = reader.IsDBNull(reader.GetOrdinal("id_presentacion")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_presentacion"));
                    Bodega = reader.IsDBNull(reader.GetOrdinal("bodega")) ? "" : reader.GetString(reader.GetOrdinal("bodega"));
                    IdMp = reader.IsDBNull(reader.GetOrdinal("id_mp")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_mp"));
                    reader.Close();
                    vale = true;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return vale;
        }
    }
}
