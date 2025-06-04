using ACS.Classes;
using DevExpress.Office.Utils;
using DevExpress.PivotGrid.SliceQueryDataSource;
using DevExpress.XtraRichEdit.Layout;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.RRHH_Planilla.Clases
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompleteName { get; set; }
        public bool Active { get; set; }
        public int CompanyId { get; set; }
        public int ParentId { get; set; }  // Nullable for potential null values
        public int IdDepartamentoParent { get; set; }  // Nullable for potential null values
        public string DepartmentParent { get; set; }
        public int CreateUid { get; set; }
        public DateTime CreateDate { get; set; }
        public int? WriteUid { get; set; }  // Nullable for potential null values
        public DateTime? WriteDate { get; set; }  // Nullable for potential null values
        public int? PaymentAccountId { get; set; }  // Nullable for potential null values
        public string PaymentAccount { get; set; }
        public int? AnalyticDepartmentAccountId { get; set; }  // Nullable for potential null values
        public string AnalyticDepartmentAccount { get; set; } = null;
        public int ManagerId { get; set; }
        public string ManagerName { get; set; } 
        public bool Recuperado { get; set; }

        public Departamento()
        {}

        DataOperations dp = new DataOperations();
        

        public bool RecuperarDetalleReglasSalariales(int IdDepart)
        {
            Recuperado = false;

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_department_class", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdDepartment", IdDepart);
                SqlDataReader reader = cmd.ExecuteReader(); 
                if(reader.Read())
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id"));
                    Name = reader.IsDBNull(reader.GetOrdinal("name_department")) ? "" : reader.GetString(reader.GetOrdinal("name_department"));
                    CompleteName = reader.IsDBNull(reader.GetOrdinal("complete_name")) ? "" : reader.GetString(reader.GetOrdinal("complete_name"));
                    Active = reader.GetBoolean(reader.GetOrdinal("active"));
                    ParentId = (int)(reader.IsDBNull(reader.GetOrdinal("parent_id")) ? 0 : reader.GetOrdinal("parent_id"));
                    DepartmentParent = reader.IsDBNull(reader.GetOrdinal("department_parent")) ? "" : reader.GetString(reader.GetOrdinal("department_parent"));
                    CreateUid = reader.IsDBNull(reader.GetOrdinal("create_uid")) ? 0 : reader.GetInt32(reader.GetOrdinal("create_uid"));
                    CreateDate = reader.GetDateTime(reader.GetOrdinal("create_date"));
                    WriteUid = reader.IsDBNull(reader.GetOrdinal("create_uid")) ? 0 : reader.GetInt32(reader.GetOrdinal("create_uid"));
                    WriteDate = reader.IsDBNull(reader.GetOrdinal("write_date")) ? DateTime.Now : reader.GetDateTime(reader.GetOrdinal("write_date"));
                    PaymentAccountId = reader.IsDBNull(reader.GetOrdinal("payment_account_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("payment_account_id"));
                    PaymentAccount = reader.IsDBNull(reader.GetOrdinal("payment_account")) ? "" : reader.GetString(reader.GetOrdinal("payment_account"));
                    AnalyticDepartmentAccountId = reader.IsDBNull(reader.GetOrdinal("analytic_department_account_id")) ? 0: reader.GetInt32(reader.GetOrdinal("analytic_department_account_id"));
                    AnalyticDepartmentAccount = reader.IsDBNull(reader.GetOrdinal("analytic_account")) ? "" : reader.GetString(reader.GetOrdinal("analytic_account"));
                    ManagerId = reader.IsDBNull(reader.GetOrdinal("manager_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("manager_id"));
                    ManagerName = reader.IsDBNull(reader.GetOrdinal("manager_name")) ? "" : reader.GetString(reader.GetOrdinal("manager_name"));
                    Recuperado = true;
                }
                reader.Close();
                conn.Close();
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return Recuperado;
        }
        


    }
}
