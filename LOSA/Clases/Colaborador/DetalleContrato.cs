using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Colaborador
{
    public class DetalleContrato
    {
        public int EmloyeeId { get; set; }
        public int ID { get; set; }
        public int AniosAntiguedad { get; set; }
        public int MesesAntiguedad { get; set; }
        public string Barcode { get; set; }
        public int PagoPlanificadoId { get; set; }
        public int ContractTypeId { get; set; }
        public int PermitNumberOfDays { get; set; }
        public string PagoPlanificado { get; set; }
        public int PlanificacionTrabajoId { get; set; }
        public string PlanificacionTrabajo { get; set; }
        public string CategoriaContrato { get; set; }
        public int EmployeeId { get; set; }
        public int TipoContrato { get; set; }
        public decimal Wage { get; set; }
        public string Moneda { get; set; }
        public string SimboloMoneda { get; set; }
        public int EstadoId { get; set; }
        public string Estado { get; set; }
        public string Nota { get; set; }
        public string DescripcionPermiso { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool StudyPermit { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperarRegistroPorCodigo(string barCode) {

            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetContratoDetalleByBarCode", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@barcode", System.Data.SqlDbType.VarChar).Value = barCode;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Barcode = barCode;
                        StartDate = dr["fecha_inicio"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime( dr["fecha_inicio"].ToString());
                        EndDate = dr["fecha_fin"] == DBNull.Value ? (DateTime?)null: (DateTime)dr["fecha_fin"];
                        PagoPlanificadoId = dr.IsDBNull(dr.GetOrdinal("periodo_pago_id")) ? 0 : Convert.ToInt32(dr["periodo_pago_id"].ToString());
                        PagoPlanificado = dr.IsDBNull(dr.GetOrdinal("periodo_pago")) ? "" : dr["periodo_pago"].ToString();
                        PlanificacionTrabajoId = dr.IsDBNull(dr.GetOrdinal("recursos_calendario_id")) ? 0 : Convert.ToInt32(dr["recursos_calendario_id"].ToString());
                        PlanificacionTrabajo = dr.IsDBNull(dr.GetOrdinal("calendar")) ? "" : dr["calendar"].ToString();
                        EstadoId = dr.IsDBNull(dr.GetOrdinal("estado_id")) ? 0 : Convert.ToInt32(dr["estado"].ToString());
                        Estado = dr.IsDBNull(dr.GetOrdinal("estado")) ? "" : dr["estado"].ToString();
                        Nota = dr.IsDBNull(dr.GetOrdinal("notas")) ? "" : dr["notas"].ToString();
                        AniosAntiguedad = dr.IsDBNull(dr.GetOrdinal("anios_antiguedad")) ? 0 : Convert.ToInt32(dr["anios_antiguedad"].ToString());
                        MesesAntiguedad = dr.IsDBNull(dr.GetOrdinal("meses_antiguedad")) ? 0 : Convert.ToInt32(dr["meses_antiguedad"].ToString());
                        Wage = dr.IsDBNull(dr.GetOrdinal("salario")) ? 0 : Convert.ToDecimal(dr["salario"].ToString());
                        ID = dr.IsDBNull(dr.GetOrdinal("id")) ? 0 : Convert.ToInt32 (dr["id"].ToString());
                        ContractTypeId = dr.IsDBNull(dr.GetOrdinal("categoria_empleado_id")) ? 0 : Convert.ToInt32 (dr["categoria_empleado_id"].ToString());
                        StudyPermit = dr.IsDBNull(dr.GetOrdinal("permiso_estudio")) ? false : Convert.ToBoolean(dr["permiso_estudio"].ToString()); 
                        PermitNumberOfDays = dr.IsDBNull(dr.GetOrdinal("permitir_numero_de_dias")) ? 0 : Convert.ToInt32 (dr["permitir_numero_de_dias"].ToString());
                        TipoContrato = dr.IsDBNull(dr.GetOrdinal("id_tipo_contrato")) ? 0 : Convert.ToInt32(dr["id_tipo_contrato"].ToString());
                        DescripcionPermiso = dr.IsDBNull(dr.GetOrdinal("descripcion_permiso")) ? "" : dr["descripcion_permiso"].ToString();
                        Moneda = dr.IsDBNull(dr.GetOrdinal("moneda")) ? "" : dr["moneda"].ToString();
                        SimboloMoneda = dr.IsDBNull(dr.GetOrdinal("simbolo")) ? "" : dr["simbolo"].ToString();
                        CategoriaContrato = dr.IsDBNull(dr.GetOrdinal("categoria_contrato")) ? "" : dr["categoria_contrato"].ToString();
                        EmployeeId = dr.IsDBNull(dr.GetOrdinal("employee_id")) ? 0 : Convert.ToInt32(dr["employee_id"].ToString());

                        //Si todas las propiedades se asignan carrectamente, en envía true para aprobar el proceso.
                        Recuperado = true;
                    }
                    cnx.Close();

                }

                return Recuperado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }



        public bool RecuperarRegistroPorEmpleadoId(int pIdEmployee, int pIdContrato)
        {

            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("[uspGetContratoDetalleByIdEmployeeAndContractId]", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_employee", System.Data.SqlDbType.VarChar).Value = pIdEmployee;
                    cmd.Parameters.Add("@ContractId", System.Data.SqlDbType.VarChar).Value = pIdContrato;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //Barcode = barCode;
                        StartDate = dr["fecha_inicio"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_inicio"].ToString());
                        EndDate = dr["fecha_fin"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["fecha_fin"];
                        PagoPlanificadoId = dr.IsDBNull(dr.GetOrdinal("periodo_pago_id")) ? 0 : Convert.ToInt32(dr["periodo_pago_id"].ToString());
                        PagoPlanificado = dr.IsDBNull(dr.GetOrdinal("periodo_pago")) ? "" : dr["periodo_pago"].ToString();
                        PlanificacionTrabajoId = dr.IsDBNull(dr.GetOrdinal("recursos_calendario_id")) ? 0 : Convert.ToInt32(dr["recursos_calendario_id"].ToString());
                        PlanificacionTrabajo = dr.IsDBNull(dr.GetOrdinal("calendar")) ? "" : dr["calendar"].ToString();
                        EstadoId = dr.IsDBNull(dr.GetOrdinal("estado_id")) ? 0 : Convert.ToInt32(dr["estado_id"].ToString());
                        Estado = dr.IsDBNull(dr.GetOrdinal("estado")) ? "" : dr["estado"].ToString();
                        Nota = dr.IsDBNull(dr.GetOrdinal("notas")) ? "" : dr["notas"].ToString();
                        AniosAntiguedad = dr.IsDBNull(dr.GetOrdinal("anios_antiguedad")) ? 0 : Convert.ToInt32(dr["anios_antiguedad"].ToString());
                        MesesAntiguedad = dr.IsDBNull(dr.GetOrdinal("meses_antiguedad")) ? 0 : Convert.ToInt32(dr["meses_antiguedad"].ToString());
                        Wage = dr.IsDBNull(dr.GetOrdinal("salario")) ? 0 : Convert.ToDecimal(dr["salario"].ToString());
                        ID = dr.IsDBNull(dr.GetOrdinal("id")) ? 0 : Convert.ToInt32(dr["id"].ToString());
                        ContractTypeId = dr.IsDBNull(dr.GetOrdinal("categoria_empleado_id")) ? 0 : Convert.ToInt32(dr["categoria_empleado_id"].ToString());
                        StudyPermit = dr.IsDBNull(dr.GetOrdinal("permiso_estudio")) ? false : Convert.ToBoolean(dr["permiso_estudio"].ToString());
                        PermitNumberOfDays = dr.IsDBNull(dr.GetOrdinal("permitir_numero_de_dias")) ? 0 : Convert.ToInt32(dr["permitir_numero_de_dias"].ToString());
                        TipoContrato = dr.IsDBNull(dr.GetOrdinal("id_tipo_contrato")) ? 0 : Convert.ToInt32(dr["id_tipo_contrato"].ToString());
                        DescripcionPermiso = dr.IsDBNull(dr.GetOrdinal("descripcion_permiso")) ? "" : dr["descripcion_permiso"].ToString();
                        Moneda = dr.IsDBNull(dr.GetOrdinal("moneda")) ? "" : dr["moneda"].ToString();
                        SimboloMoneda = dr.IsDBNull(dr.GetOrdinal("simbolo")) ? "" : dr["simbolo"].ToString();
                        EmployeeId = dr.IsDBNull(dr.GetOrdinal("employee_id")) ? 0 : Convert.ToInt32(dr["employee_id"].ToString());
                        Barcode = dr.IsDBNull(dr.GetOrdinal("name")) ? "" : dr["name"].ToString();
                        CategoriaContrato = dr.IsDBNull(dr.GetOrdinal("categoria_contrato")) ? "" : dr["categoria_contrato"].ToString();

                        //Si todas las propiedades se asignan carrectamente, en envía true para aprobar el proceso.
                        Recuperado = true;
                    }
                    cnx.Close();

                }

                return Recuperado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }



        public bool RecuperarRegistroPorId(int id)
        {

            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetContratoDetalleByIdV2", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Barcode = dr.IsDBNull(dr.GetOrdinal("barcode")) ? "" : dr["barcode"].ToString();
                        StartDate = dr["fecha_inicio"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_inicio"].ToString());
                        EndDate = dr["fecha_fin"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["fecha_fin"];
                        PagoPlanificadoId = dr.IsDBNull(dr.GetOrdinal("periodo_pago_id")) ? 0 : Convert.ToInt32(dr["periodo_pago_id"].ToString());
                        PagoPlanificado = dr.IsDBNull(dr.GetOrdinal("periodo_pago")) ? "" : dr["periodo_pago"].ToString();
                        PlanificacionTrabajoId = dr.IsDBNull(dr.GetOrdinal("recursos_calendario_id")) ? 0 : Convert.ToInt32(dr["recursos_calendario_id"].ToString());
                        PlanificacionTrabajo = dr.IsDBNull(dr.GetOrdinal("calendar")) ? "" : dr["calendar"].ToString();
                        Estado = dr.IsDBNull(dr.GetOrdinal("estado")) ? "" : dr["estado"].ToString();
                        Nota = dr.IsDBNull(dr.GetOrdinal("notas")) ? "" : dr["notas"].ToString();
                        AniosAntiguedad = dr.IsDBNull(dr.GetOrdinal("anios_antiguedad")) ? 0 : Convert.ToInt32(dr["anios_antiguedad"].ToString());
                        MesesAntiguedad = dr.IsDBNull(dr.GetOrdinal("meses_antiguedad")) ? 0 : Convert.ToInt32(dr["meses_antiguedad"].ToString());
                        Wage = dr.IsDBNull(dr.GetOrdinal("salario")) ? 0 : Convert.ToDecimal(dr["salario"].ToString());
                        ID = dr.IsDBNull(dr.GetOrdinal("id")) ? 0 : Convert.ToInt32(dr["id"].ToString());
                        ContractTypeId = dr.IsDBNull(dr.GetOrdinal("categoria_empleado_id")) ? 0 : Convert.ToInt32(dr["categoria_empleado_id"].ToString());
                        StudyPermit = dr.IsDBNull(dr.GetOrdinal("permiso_estudio")) ? false : Convert.ToBoolean(dr["permiso_estudio"].ToString());
                        PermitNumberOfDays = dr.IsDBNull(dr.GetOrdinal("permitir_numero_de_dias")) ? 0 : Convert.ToInt32(dr["permitir_numero_de_dias"].ToString());
                        TipoContrato = dr.IsDBNull(dr.GetOrdinal("id_tipo_contrato")) ? 0 : Convert.ToInt32(dr["id_tipo_contrato"].ToString());
                        DescripcionPermiso = dr.IsDBNull(dr.GetOrdinal("descripcion_permiso")) ? "" : dr["descripcion_permiso"].ToString();
                        Moneda = dr.IsDBNull(dr.GetOrdinal("moneda")) ? "" : dr["moneda"].ToString();
                        SimboloMoneda = dr.IsDBNull(dr.GetOrdinal("simbolo")) ? "" : dr["simbolo"].ToString();
                        EmployeeId = dr.IsDBNull(dr.GetOrdinal("employee_id")) ? 0 : Convert.ToInt32(dr["employee_id"].ToString());
                        CategoriaContrato = dr.IsDBNull(dr.GetOrdinal("categoria_contrato")) ? "" : dr["categoria_contrato"].ToString();

                        //Si todas las propiedades se asignan carrectamente, en envía true para aprobar el proceso.
                        Recuperado = true;
                    }
                    cnx.Close();

                }

                return Recuperado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }
    }
}
