using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Colaborador
{
    public class HrEmployee
    {
        #region Propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public int? UserId { get; set; }
        public bool Active { get; set; }
        

        /// <summary>
        /// Direccion Privada del empleado
        /// </summary>
        public int? DireccionPrivadaID { get; set; }
        

        public int? CountryId { get; set; }
        public string Gender { get; set; }
        public string Marital { get; set; }
        public string SpouseCompleteName { get; set; }
        public DateTime SpouseBirthdate { get; set; }
        public int? Children { get; set; }
        public string PlaceOfBirth { get; set; }
        public int? CountryOfBirth { get; set; }
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Numero de identidad
        /// </summary>
        public string IdentificationId { get; set; }
        
        public string PassportId { get; set; }
        public string AdditionalNote { get; set; }
        public string Certificate { get; set; }
        public string StudyField { get; set; }
        public string StudySchool { get; set; }
        public string DepartmentTitle { get; set; }
        public string CategoriaContrato { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
        public int? KmHomeWork { get; set; }
        public string JobTitle { get; set; }
        public string Job { get; set; }
        public string Puesto { get; set; }
        public int? AddressId { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string WorkEmail { get; set; }
        public string PrivateEmail { get; set; }
        public string WorkLocation { get; set; }
        public int? company_address_id { get; set; }
        public int? company_address_phone_id { get; set; }
        public int? banda_salarial_id { get; set; }
        public int? JobId { get; set; }
        public int? DepartmentId { get; set; }
        public int? ParentId { get; set; }
        public int? CompanyId { get; set; }
        public int? CreateUid { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Barcode { get; set; }
        public bool Manager { get; set; }
        public DateTime? MedicExam { get; set; }
        public int? ProfessionId { get; set; }
        public string PaymentType { get; set; }
        public string College { get; set; }
        public string Rtn { get; set; }
        public string BloodType { get; set; }
        public string EmployeeAccount { get; set; }
        public int? BankId { get; set; }
        public int? RollTypeId { get; set; }
        public string ShirtSize { get; set; }
        public string PantSize { get; set; }
        public string ShoeSize { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public bool Marking { get; set; }
        public int? IdGrupo { get; set; }
        public TimeSpan? XHourIn { get; set; }
        public TimeSpan? XHourOut { get; set; }
        public bool? XConfAplic { get; set; }
        public int? XIdJournal { get; set; }
        public int? Dependientes_cant { get; set; }
        public int? id_tipo_seguro { get; set; }
        public int? CompanyAddressId { get; set; }
        public int? HrCompanyAddressPhoneId { get; set; }
        public int? BandaSalarialId { get; set; }
        public int? IdNivelCertificadoEstudio { get; set; }
        public int? IdAmbitoEstudio { get; set; }
        public int? IdEscuelaUniversidad { get; set; }
        public int? IdTipoPago { get; set; }

        public bool RecibeDepreciacionVehicular { get; set; }
        public int? IdVehiculoAsignado { get; set; }
        public bool EsDiscapacitado { get; set; }
        public string Discapacidad { get; set; }
        public string NumeroPermisoTrabajo { get; set; }
        public bool PagaPorDependientes { get; set; }
        public int? TipoContratoId { get; set; }
        public int ContractId { get; set; }
        public string HorarioTrabajoParaImprimirContrato { get; set; }
        public string DireccionPersonal { get; set; }
        public string Turno { get; set; }
        public bool Recuperado { get; set; }


        DataOperations dp;
        #endregion

        public HrEmployee()
        {
            dp = new DataOperations();
        }

        #region Functions 
        #region Recuperar Registro
        public bool RecuperarDatosPorId(int id)
        {
            Recuperado = false;
            string connectionString = dp.ConnectionStringRRHH; // Reemplaza con tu cadena de conexión
            string query = @"dbo.get_dato_maestro_hr_employeeV5";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id"));
                                Name = reader.IsDBNull(reader.GetOrdinal("name")) ? string.Empty : reader.GetString(reader.GetOrdinal("name"));
                                UserId = reader.IsDBNull(reader.GetOrdinal("user_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("user_id"));
                                Active = reader.IsDBNull(reader.GetOrdinal("active")) ? false : reader.GetBoolean(reader.GetOrdinal("active"));
                                DireccionPrivadaID = reader.IsDBNull(reader.GetOrdinal("address_home_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("address_home_id"));
                                CountryId = reader.IsDBNull(reader.GetOrdinal("country_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("country_id"));
                                Gender = reader.IsDBNull(reader.GetOrdinal("gender")) ? string.Empty : reader.GetString(reader.GetOrdinal("gender"));
                                Marital = reader.IsDBNull(reader.GetOrdinal("marital")) ? string.Empty : reader.GetString(reader.GetOrdinal("marital"));
                                SpouseCompleteName = reader.IsDBNull(reader.GetOrdinal("spouse_complete_name")) ? string.Empty : reader.GetString(reader.GetOrdinal("spouse_complete_name"));
                                SpouseBirthdate = reader.IsDBNull(reader.GetOrdinal("spouse_birthdate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("spouse_birthdate"));
                                Children = reader.IsDBNull(reader.GetOrdinal("children")) ? 0 : reader.GetInt32(reader.GetOrdinal("children"));
                                PlaceOfBirth = reader.IsDBNull(reader.GetOrdinal("place_of_birth")) ? string.Empty : reader.GetString(reader.GetOrdinal("place_of_birth"));
                                CountryOfBirth = reader.IsDBNull(reader.GetOrdinal("country_of_birth")) ? 0 : reader.GetInt32(reader.GetOrdinal("country_of_birth"));
                                Birthday = reader.IsDBNull(reader.GetOrdinal("birthday")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("birthday"));
                                IdentificationId = reader.IsDBNull(reader.GetOrdinal("identification_id")) ? string.Empty : reader.GetString(reader.GetOrdinal("identification_id"));
                                PassportId = reader.IsDBNull(reader.GetOrdinal("passport_id")) ? string.Empty : reader.GetString(reader.GetOrdinal("passport_id"));
                                AdditionalNote = reader.IsDBNull(reader.GetOrdinal("additional_note")) ? string.Empty : reader.GetString(reader.GetOrdinal("additional_note"));
                                Certificate = reader.IsDBNull(reader.GetOrdinal("certificate")) ? string.Empty : reader.GetString(reader.GetOrdinal("certificate"));
                                StudyField = reader.IsDBNull(reader.GetOrdinal("study_field")) ? string.Empty : reader.GetString(reader.GetOrdinal("study_field"));
                                StudySchool = reader.IsDBNull(reader.GetOrdinal("study_school")) ? string.Empty : reader.GetString(reader.GetOrdinal("study_school"));
                                EmergencyContact = reader.IsDBNull(reader.GetOrdinal("emergency_contact")) ? string.Empty : reader.GetString(reader.GetOrdinal("emergency_contact"));
                                EmergencyPhone = reader.IsDBNull(reader.GetOrdinal("emergency_phone")) ? string.Empty : reader.GetString(reader.GetOrdinal("emergency_phone"));
                                KmHomeWork = reader.IsDBNull(reader.GetOrdinal("km_home_work")) ? 0 : reader.GetInt32(reader.GetOrdinal("km_home_work"));
                                JobTitle = reader.IsDBNull(reader.GetOrdinal("job_title")) ? string.Empty : reader.GetString(reader.GetOrdinal("job_title"));
                                Puesto = reader.IsDBNull(reader.GetOrdinal("puesto")) ? string.Empty : reader.GetString(reader.GetOrdinal("puesto"));
                                AddressId = reader.IsDBNull(reader.GetOrdinal("address_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("address_id"));
                                WorkPhone = reader.IsDBNull(reader.GetOrdinal("work_phone")) ? string.Empty : reader.GetString(reader.GetOrdinal("work_phone"));
                                MobilePhone = reader.IsDBNull(reader.GetOrdinal("mobile_phone")) ? string.Empty : reader.GetString(reader.GetOrdinal("mobile_phone"));
                                WorkEmail = reader.IsDBNull(reader.GetOrdinal("work_email")) ? string.Empty : reader.GetString(reader.GetOrdinal("work_email"));
                                PrivateEmail = reader.IsDBNull(reader.GetOrdinal("private_email")) ? string.Empty : reader.GetString(reader.GetOrdinal("private_email"));
                                WorkLocation = reader.IsDBNull(reader.GetOrdinal("work_location")) ? string.Empty : reader.GetString(reader.GetOrdinal("work_location"));
                                company_address_id = reader.IsDBNull(reader.GetOrdinal("company_address_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("company_address_id"));
                                company_address_phone_id = reader.IsDBNull(reader.GetOrdinal("hr_company_address_phone_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("hr_company_address_phone_id"));
                                banda_salarial_id = reader.IsDBNull(reader.GetOrdinal("banda_salarial_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("banda_salarial_id"));
                                JobId = reader.IsDBNull(reader.GetOrdinal("job_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("job_id"));
                                //JobId = reader.IsDBNull(reader.GetOrdinal("job_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("job_id"));
                                DepartmentId = reader.IsDBNull(reader.GetOrdinal("department_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("department_id"));
                                DepartmentTitle = reader.IsDBNull(reader.GetOrdinal("department_title")) ? string.Empty : reader.GetString(reader.GetOrdinal("department_title"));
                                ParentId = reader.IsDBNull(reader.GetOrdinal("parent_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("parent_id"));
                                CompanyId = reader.IsDBNull(reader.GetOrdinal("company_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("company_id"));
                                CreateUid = reader.IsDBNull(reader.GetOrdinal("create_uid")) ? 0 : reader.GetInt32(reader.GetOrdinal("create_uid"));
                                CreateDate = reader.IsDBNull(reader.GetOrdinal("create_date")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("create_date"));
                                Barcode = reader.IsDBNull(reader.GetOrdinal("barcode")) ? string.Empty : reader.GetString(reader.GetOrdinal("barcode"));
                                Manager = reader.IsDBNull(reader.GetOrdinal("manager")) ? false : reader.GetBoolean(reader.GetOrdinal("manager"));
                                MedicExam = reader.IsDBNull(reader.GetOrdinal("medic_exam")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("medic_exam"));
                                ProfessionId = reader.IsDBNull(reader.GetOrdinal("profession_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("profession_id"));
                                PaymentType = reader.IsDBNull(reader.GetOrdinal("payment_type")) ? string.Empty : reader.GetString(reader.GetOrdinal("payment_type"));
                                College = reader.IsDBNull(reader.GetOrdinal("college")) ? string.Empty : reader.GetString(reader.GetOrdinal("college"));
                                Rtn = reader.IsDBNull(reader.GetOrdinal("rtn")) ? string.Empty : reader.GetString(reader.GetOrdinal("rtn"));
                                BloodType = reader.IsDBNull(reader.GetOrdinal("blood_type")) ? string.Empty : reader.GetString(reader.GetOrdinal("blood_type"));
                                EmployeeAccount = reader.IsDBNull(reader.GetOrdinal("employee_account")) ? string.Empty : reader.GetString(reader.GetOrdinal("employee_account"));
                                BankId = reader.IsDBNull(reader.GetOrdinal("bank_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("bank_id"));
                                RollTypeId = reader.IsDBNull(reader.GetOrdinal("roll_type_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("roll_type_id"));
                                ShirtSize = reader.IsDBNull(reader.GetOrdinal("shirt_size")) ? string.Empty : reader.GetString(reader.GetOrdinal("shirt_size"));
                                PantSize = reader.IsDBNull(reader.GetOrdinal("pant_size")) ? string.Empty : reader.GetString(reader.GetOrdinal("pant_size"));
                                ShoeSize = reader.IsDBNull(reader.GetOrdinal("shoe_size")) ? string.Empty : reader.GetString(reader.GetOrdinal("shoe_size"));
                                Height = reader.IsDBNull(reader.GetOrdinal("height")) ? 0 : reader.GetInt32(reader.GetOrdinal("height"));
                                Weight = reader.IsDBNull(reader.GetOrdinal("weight")) ? 0 : reader.GetInt32(reader.GetOrdinal("weight"));
                                Marking = reader.IsDBNull(reader.GetOrdinal("marking")) ? false : reader.GetBoolean(reader.GetOrdinal("marking"));
                                IdGrupo = reader.IsDBNull(reader.GetOrdinal("id_grupo")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_grupo"));
                                XHourIn = reader.IsDBNull(reader.GetOrdinal("x_hour_in")) ? TimeSpan.Zero : reader.GetTimeSpan(reader.GetOrdinal("x_hour_in"));
                                XHourOut = reader.IsDBNull(reader.GetOrdinal("x_hour_out")) ? TimeSpan.Zero : reader.GetTimeSpan(reader.GetOrdinal("x_hour_out"));
                                XConfAplic = reader.IsDBNull(reader.GetOrdinal("x_conf_aplic")) ? false : reader.GetBoolean(reader.GetOrdinal("x_conf_aplic"));
                                XIdJournal = reader.IsDBNull(reader.GetOrdinal("x_id_journal")) ? 0 : reader.GetInt32(reader.GetOrdinal("x_id_journal"));
                                Dependientes_cant = reader.IsDBNull(reader.GetOrdinal("dependientes_cant")) ? 0 : reader.GetInt32(reader.GetOrdinal("dependientes_cant"));
                                id_tipo_seguro = reader.IsDBNull(reader.GetOrdinal("id_tipo_seguro")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_tipo_seguro"));
                                CompanyAddressId = reader.IsDBNull(reader.GetOrdinal("company_address_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("company_address_id"));
                                HrCompanyAddressPhoneId = reader.IsDBNull(reader.GetOrdinal("hr_company_address_phone_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("hr_company_address_phone_id"));
                                BandaSalarialId = reader.IsDBNull(reader.GetOrdinal("banda_salarial_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("banda_salarial_id"));
                                IdNivelCertificadoEstudio = reader.IsDBNull(reader.GetOrdinal("id_nivel_certificado_estudio")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_nivel_certificado_estudio"));
                                IdAmbitoEstudio = reader.IsDBNull(reader.GetOrdinal("id_ambito_estudio")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_ambito_estudio"));
                                IdEscuelaUniversidad = reader.IsDBNull(reader.GetOrdinal("id_escuela_universidad")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_escuela_universidad"));
                                IdTipoPago = reader.IsDBNull(reader.GetOrdinal("id_tipo_pago")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_tipo_pago"));
                                RecibeDepreciacionVehicular = reader.IsDBNull(reader.GetOrdinal("depreciacion_vehicular")) ? false : reader.GetBoolean(reader.GetOrdinal("depreciacion_vehicular"));
                                IdVehiculoAsignado = reader.IsDBNull(reader.GetOrdinal("id_vehiculo")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_vehiculo"));
                                HorarioTrabajoParaImprimirContrato = reader.IsDBNull(reader.GetOrdinal("display_for_contract_print")) ? string.Empty : reader.GetString(reader.GetOrdinal("display_for_contract_print"));
                                DireccionPersonal = reader.IsDBNull(reader.GetOrdinal("direccion_personal")) ? string.Empty : reader.GetString(reader.GetOrdinal("direccion_personal"));
                                Turno = reader.IsDBNull(reader.GetOrdinal("turno")) ? string.Empty : reader.GetString(reader.GetOrdinal("turno"));

                                Recuperado = true;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Aquí podrías registrar la excepción o manejarla según sea necesario
                CajaDialogo.Error($"Error al cargar datos: {ex.Message}");
                Recuperado = false;
            }

            return Recuperado;
        }


        public bool RecuperarDatosPorCodigo(string pCodigo)
        {
            Recuperado = false;
            string connectionString = dp.ConnectionStringRRHH; // Reemplaza con tu cadena de conexión
            string query = @"dbo.[get_dato_maestro_hr_employee_by_codeV4]";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@barcode", pCodigo);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id"));
                                Name = reader.IsDBNull(reader.GetOrdinal("name")) ? string.Empty : reader.GetString(reader.GetOrdinal("name"));
                                UserId = reader.IsDBNull(reader.GetOrdinal("user_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("user_id"));
                                Active = reader.IsDBNull(reader.GetOrdinal("active")) ? false : reader.GetBoolean(reader.GetOrdinal("active"));
                                DireccionPrivadaID = reader.IsDBNull(reader.GetOrdinal("address_home_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("address_home_id"));
                                CountryId = reader.IsDBNull(reader.GetOrdinal("country_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("country_id"));
                                Gender = reader.IsDBNull(reader.GetOrdinal("gender")) ? string.Empty : reader.GetString(reader.GetOrdinal("gender"));
                                Marital = reader.IsDBNull(reader.GetOrdinal("marital")) ? string.Empty : reader.GetString(reader.GetOrdinal("marital"));
                                SpouseCompleteName = reader.IsDBNull(reader.GetOrdinal("spouse_complete_name")) ? string.Empty : reader.GetString(reader.GetOrdinal("spouse_complete_name"));
                                SpouseBirthdate = reader.IsDBNull(reader.GetOrdinal("spouse_birthdate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("spouse_birthdate"));
                                Children = reader.IsDBNull(reader.GetOrdinal("children")) ? 0 : reader.GetInt32(reader.GetOrdinal("children"));
                                PlaceOfBirth = reader.IsDBNull(reader.GetOrdinal("place_of_birth")) ? string.Empty : reader.GetString(reader.GetOrdinal("place_of_birth"));
                                CountryOfBirth = reader.IsDBNull(reader.GetOrdinal("country_of_birth")) ? 0 : reader.GetInt32(reader.GetOrdinal("country_of_birth"));
                                Birthday = reader.IsDBNull(reader.GetOrdinal("birthday")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("birthday"));
                                IdentificationId = reader.IsDBNull(reader.GetOrdinal("identification_id")) ? string.Empty : reader.GetString(reader.GetOrdinal("identification_id"));
                                PassportId = reader.IsDBNull(reader.GetOrdinal("passport_id")) ? string.Empty : reader.GetString(reader.GetOrdinal("passport_id"));
                                AdditionalNote = reader.IsDBNull(reader.GetOrdinal("additional_note")) ? string.Empty : reader.GetString(reader.GetOrdinal("additional_note"));
                                Certificate = reader.IsDBNull(reader.GetOrdinal("certificate")) ? string.Empty : reader.GetString(reader.GetOrdinal("certificate"));
                                StudyField = reader.IsDBNull(reader.GetOrdinal("study_field")) ? string.Empty : reader.GetString(reader.GetOrdinal("study_field"));
                                StudySchool = reader.IsDBNull(reader.GetOrdinal("study_school")) ? string.Empty : reader.GetString(reader.GetOrdinal("study_school"));
                                EmergencyContact = reader.IsDBNull(reader.GetOrdinal("emergency_contact")) ? string.Empty : reader.GetString(reader.GetOrdinal("emergency_contact"));
                                EmergencyPhone = reader.IsDBNull(reader.GetOrdinal("emergency_phone")) ? string.Empty : reader.GetString(reader.GetOrdinal("emergency_phone"));
                                KmHomeWork = reader.IsDBNull(reader.GetOrdinal("km_home_work")) ? 0 : reader.GetInt32(reader.GetOrdinal("km_home_work"));
                                JobTitle = reader.IsDBNull(reader.GetOrdinal("job_title")) ? string.Empty : reader.GetString(reader.GetOrdinal("job_title"));
                                Puesto = reader.IsDBNull(reader.GetOrdinal("puesto")) ? string.Empty : reader.GetString(reader.GetOrdinal("puesto"));
                                AddressId = reader.IsDBNull(reader.GetOrdinal("address_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("address_id"));
                                WorkPhone = reader.IsDBNull(reader.GetOrdinal("work_phone")) ? string.Empty : reader.GetString(reader.GetOrdinal("work_phone"));
                                MobilePhone = reader.IsDBNull(reader.GetOrdinal("mobile_phone")) ? string.Empty : reader.GetString(reader.GetOrdinal("mobile_phone"));
                                WorkEmail = reader.IsDBNull(reader.GetOrdinal("work_email")) ? string.Empty : reader.GetString(reader.GetOrdinal("work_email"));
                                PrivateEmail = reader.IsDBNull(reader.GetOrdinal("private_email")) ? string.Empty : reader.GetString(reader.GetOrdinal("private_email"));
                                WorkLocation = reader.IsDBNull(reader.GetOrdinal("work_location")) ? string.Empty : reader.GetString(reader.GetOrdinal("work_location"));
                                company_address_id = reader.IsDBNull(reader.GetOrdinal("company_address_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("company_address_id"));
                                company_address_phone_id = reader.IsDBNull(reader.GetOrdinal("hr_company_address_phone_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("hr_company_address_phone_id"));
                                banda_salarial_id = reader.IsDBNull(reader.GetOrdinal("banda_salarial_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("banda_salarial_id"));
                                JobId = reader.IsDBNull(reader.GetOrdinal("job_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("job_id"));
                                DepartmentId = reader.IsDBNull(reader.GetOrdinal("department_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("department_id"));
                                ParentId = reader.IsDBNull(reader.GetOrdinal("parent_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("parent_id"));
                                CompanyId = reader.IsDBNull(reader.GetOrdinal("company_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("company_id"));
                                CreateUid = reader.IsDBNull(reader.GetOrdinal("create_uid")) ? 0 : reader.GetInt32(reader.GetOrdinal("create_uid"));
                                CreateDate = reader.IsDBNull(reader.GetOrdinal("create_date")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("create_date"));
                                Barcode = reader.IsDBNull(reader.GetOrdinal("barcode")) ? string.Empty : reader.GetString(reader.GetOrdinal("barcode"));
                                Manager = reader.IsDBNull(reader.GetOrdinal("manager")) ? false : reader.GetBoolean(reader.GetOrdinal("manager"));
                                MedicExam = reader.IsDBNull(reader.GetOrdinal("medic_exam")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("medic_exam"));
                                ProfessionId = reader.IsDBNull(reader.GetOrdinal("profession_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("profession_id"));
                                PaymentType = reader.IsDBNull(reader.GetOrdinal("payment_type")) ? string.Empty : reader.GetString(reader.GetOrdinal("payment_type"));
                                College = reader.IsDBNull(reader.GetOrdinal("college")) ? string.Empty : reader.GetString(reader.GetOrdinal("college"));
                                Rtn = reader.IsDBNull(reader.GetOrdinal("rtn")) ? string.Empty : reader.GetString(reader.GetOrdinal("rtn"));
                                BloodType = reader.IsDBNull(reader.GetOrdinal("blood_type")) ? string.Empty : reader.GetString(reader.GetOrdinal("blood_type"));
                                EmployeeAccount = reader.IsDBNull(reader.GetOrdinal("employee_account")) ? string.Empty : reader.GetString(reader.GetOrdinal("employee_account"));
                                BankId = reader.IsDBNull(reader.GetOrdinal("bank_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("bank_id"));
                                RollTypeId = reader.IsDBNull(reader.GetOrdinal("roll_type_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("roll_type_id"));
                                ShirtSize = reader.IsDBNull(reader.GetOrdinal("shirt_size")) ? string.Empty : reader.GetString(reader.GetOrdinal("shirt_size"));
                                PantSize = reader.IsDBNull(reader.GetOrdinal("pant_size")) ? string.Empty : reader.GetString(reader.GetOrdinal("pant_size"));
                                ShoeSize = reader.IsDBNull(reader.GetOrdinal("shoe_size")) ? string.Empty : reader.GetString(reader.GetOrdinal("shoe_size"));
                                Height = reader.IsDBNull(reader.GetOrdinal("height")) ? 0 : reader.GetInt32(reader.GetOrdinal("height"));
                                Weight = reader.IsDBNull(reader.GetOrdinal("weight")) ? 0 : reader.GetInt32(reader.GetOrdinal("weight"));
                                Marking = reader.IsDBNull(reader.GetOrdinal("marking")) ? false : reader.GetBoolean(reader.GetOrdinal("marking"));
                                IdGrupo = reader.IsDBNull(reader.GetOrdinal("id_grupo")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_grupo"));
                                XHourIn = reader.IsDBNull(reader.GetOrdinal("x_hour_in")) ? TimeSpan.Zero : reader.GetTimeSpan(reader.GetOrdinal("x_hour_in"));
                                XHourOut = reader.IsDBNull(reader.GetOrdinal("x_hour_out")) ? TimeSpan.Zero : reader.GetTimeSpan(reader.GetOrdinal("x_hour_out"));
                                XConfAplic = reader.IsDBNull(reader.GetOrdinal("x_conf_aplic")) ? false : reader.GetBoolean(reader.GetOrdinal("x_conf_aplic"));
                                XIdJournal = reader.IsDBNull(reader.GetOrdinal("x_id_journal")) ? 0 : reader.GetInt32(reader.GetOrdinal("x_id_journal"));
                                Dependientes_cant = reader.IsDBNull(reader.GetOrdinal("dependientes_cant")) ? 0 : reader.GetInt32(reader.GetOrdinal("dependientes_cant"));
                                id_tipo_seguro = reader.IsDBNull(reader.GetOrdinal("id_tipo_seguro")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_tipo_seguro"));
                                CompanyAddressId = reader.IsDBNull(reader.GetOrdinal("company_address_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("company_address_id"));
                                HrCompanyAddressPhoneId = reader.IsDBNull(reader.GetOrdinal("hr_company_address_phone_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("hr_company_address_phone_id"));
                                BandaSalarialId = reader.IsDBNull(reader.GetOrdinal("banda_salarial_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("banda_salarial_id"));
                                IdNivelCertificadoEstudio = reader.IsDBNull(reader.GetOrdinal("id_nivel_certificado_estudio")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_nivel_certificado_estudio"));
                                IdAmbitoEstudio = reader.IsDBNull(reader.GetOrdinal("id_ambito_estudio")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_ambito_estudio"));
                                IdEscuelaUniversidad = reader.IsDBNull(reader.GetOrdinal("id_escuela_universidad")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_escuela_universidad"));
                                IdTipoPago = reader.IsDBNull(reader.GetOrdinal("id_tipo_pago")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_tipo_pago"));
                                RecibeDepreciacionVehicular = reader.IsDBNull(reader.GetOrdinal("depreciacion_vehicular")) ? false : reader.GetBoolean(reader.GetOrdinal("depreciacion_vehicular"));
                                IdVehiculoAsignado = reader.IsDBNull(reader.GetOrdinal("id_vehiculo")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_vehiculo"));
                                DepartmentTitle = reader.IsDBNull(reader.GetOrdinal("department_title")) ? string.Empty : reader.GetString(reader.GetOrdinal("department_title"));
                                CategoriaContrato = reader.IsDBNull(reader.GetOrdinal("categoria_contrato")) ? string.Empty : reader.GetString(reader.GetOrdinal("categoria_contrato"));
                                EsDiscapacitado = reader.IsDBNull(reader.GetOrdinal("es_discapacitado")) ? false : reader.GetBoolean(reader.GetOrdinal("es_discapacitado"));
                                Discapacidad = reader.IsDBNull(reader.GetOrdinal("discapacidad")) ? string.Empty : reader.GetString(reader.GetOrdinal("discapacidad"));
                                NumeroPermisoTrabajo = reader.IsDBNull(reader.GetOrdinal("numero_permiso_trabajo")) ? string.Empty : reader.GetString(reader.GetOrdinal("numero_permiso_trabajo"));
                                PagaPorDependientes = reader.IsDBNull(reader.GetOrdinal("paga_por_dependientes")) ? false : reader.GetBoolean(reader.GetOrdinal("paga_por_dependientes"));
                                TipoContratoId = reader.IsDBNull(reader.GetOrdinal("id_tipo_contrato")) ? 0 : reader.GetInt32(reader.GetOrdinal("id_tipo_contrato"));
                                ContractId = reader.IsDBNull(reader.GetOrdinal("contract_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("contract_id"));
                                Recuperado = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Aquí podrías registrar la excepción o manejarla según sea necesario
                CajaDialogo.Error($"Error al cargar datos: {ex.Message}");
                Recuperado = false;
            }

            return Recuperado;
        }
        #endregion
        #endregion
    }
}
