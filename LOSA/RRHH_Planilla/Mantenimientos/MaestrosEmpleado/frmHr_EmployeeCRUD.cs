using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DocumentFormat.OpenXml.Office.Word;
using LOSA.Clases;
using LOSA.Clases.Colaborador;
using LOSA.Clases.Planilla;
using LOSA.Mantenimientos.Modelos;
using LOSA.Presupuesto;
using LOSA.RecepcionMP;

//using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    public partial class frmHr_EmployeeCRUD : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        HrEmployee EmpleadoActual;
        string file_name_employee = "";
        string path_employee_file = "";
        
        //Subir foto de perfil
        bool transaccion_foto_perfil = false;

        //setear lista de hijos
        List<Hr_Employee_Children> hijos= new List<Hr_Employee_Children>();
        List<Hr_Beneficiario> beneficiarios= new List<Hr_Beneficiario>();
        public enum TipoTransaccion
        {
            Insert = 1,
            Update = 2,
            View = 3
        }

        private enum EstadoCapacitaciones
        {
            Programada = 1,
            Completada = 2,
            EnProceso = 3,
            Cancelada = 5,
        }
        TipoTransaccion TipoTransaccionActual;

        public frmHr_EmployeeCRUD(UserLogin pUsuario, string pCodigoEmpleado, TipoTransaccion pTipoTransaccion)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuario;  
            dp = new DataOperations();
            TipoTransaccionActual = pTipoTransaccion;
            EmpleadoActual = new HrEmployee();
            LoadDatosMaestros();

            cmdGuardar.Visible = false;
            txtCodigo.Enabled = false;  
            colDelete.Visible = false;

            switch (TipoTransaccionActual)
            {
                case TipoTransaccion.Insert:
                    cmdAgregarNuevo.Enabled = 
                    cmdAgregarNuevo.Visible = 
                    cmdEditar.Enabled =
                    gleCompany.Enabled =
                    gleDireccionesCompany.Enabled =
                    gleTelefonosCompany.Enabled =
                    gleDepartamentos.Enabled =
                    glePuestosDeTrabajo.Enabled =
                    gleProfesion.Enabled =
                    //gleBandaSalarial.Enabled =
                    gleResponsable.Enabled =
                    cmdGuardar.Visible = true;
                    cmdEditar.Visible = false;
                    lblNombreEmpleado.Visible = false;
                    cmdAgregarNuevo.Visible= lblCodigo.Visible = false;
                    txtEmployeeNameNombre.Visible = true;
                    btnAddExpediente.Enabled= false;
                    btnCambiarImagen.Enabled= true;
                    ShowImageFromFtp(GetUrlPhoto(0));//imagen defualt cuando hay un insert;
                    break;
                case TipoTransaccion.Update:
                    EmpleadoActual.Barcode = pCodigoEmpleado;
                    cmdAgregarNuevo.Enabled = true;
                    cmdEditar.Enabled =
                    gleCompany.Enabled =
                    gleDireccionesCompany.Enabled =
                    gleTelefonosCompany.Enabled =
                    gleDepartamentos.Enabled =
                    glePuestosDeTrabajo.Enabled =
                    gleProfesion.Enabled =
                    gleBandaSalarial.Enabled =
                    gleResponsable.Enabled =
                    cmdEditar.Visible = true;
                    LoadDatosEmpleado();
                    LoadExpedientes();
                    LoadAsignacionesEmpleado();
                    LoadContratos();
                    LoadCapacitacionesCompletadas((int)EstadoCapacitaciones.Completada);
                    LoadCapacitacionesProgramadas((int)EstadoCapacitaciones.Programada);

                    SetControlesEnable_orDisable(false);//Deshabiltamos
                    ShowImageFromFtp(GetUrlPhoto(EmpleadoActual.Id));
                    break;
                case TipoTransaccion.View:
                    EmpleadoActual.Barcode = pCodigoEmpleado;
                    cmdAgregarNuevo.Enabled = false;
                    cmdAgregarNuevo.Visible = false;
                    cmdEditar.Enabled =
                    gleCompany.Enabled =
                    gleDireccionesCompany.Enabled =
                    gleTelefonosCompany.Enabled =
                    gleDepartamentos.Enabled =
                    glePuestosDeTrabajo.Enabled =
                    gleProfesion.Enabled =
                    gleBandaSalarial.Enabled =
                    gleResponsable.Enabled = false;
                    cmdEditar.Visible = false;
                    btnAddExpediente.Enabled = false;
                    SetControlesEnable_orDisable(false);//Deshabiltamos

                    lblCodigo.Text = EmpleadoActual.Barcode;
                    lblNombreEmpleado.Text = EmpleadoActual.Name;
                    gleCompany.EditValue = EmpleadoActual.CompanyId;
                    gleDireccionesCompany.EditValue = EmpleadoActual.company_address_id;
                    gleTelefonosCompany.EditValue = EmpleadoActual.company_address_phone_id;
                    gleDepartamentos.EditValue = EmpleadoActual.DepartmentId;
                    glePuestosDeTrabajo.EditValue = EmpleadoActual.JobId;
                    gleProfesion.EditValue = EmpleadoActual.ProfessionId;
                    gleBandaSalarial.EditValue = EmpleadoActual.banda_salarial_id;
                    gleResponsable.EditValue = EmpleadoActual.ParentId;
                    txtPermisoTrabajo.Text = EmpleadoActual.NumeroPermisoTrabajo;

                    //Tab Informacion Privada
                    glePaisesNacionalidad.Enabled = 
                    txtNumeroIdentidad.Enabled = 
                    txtRTN.Enabled = 
                    txtNumeroPasaporte.Enabled = 
                    txtNumeroColegiatura.Enabled = 
                    cbxTipoSangre.Enabled = false;

                    LoadDatosEmpleado();
                    LoadContratos();
                    LoadCapacitacionesCompletadas((int)EstadoCapacitaciones.Completada);
                    LoadCapacitacionesProgramadas((int)EstadoCapacitaciones.Programada);

                    break;
                default:
                    cmdAgregarNuevo.Enabled = false;
                    cmdAgregarNuevo.Visible = false;
                    gleCompany.Enabled =
                    gleDireccionesCompany.Enabled =
                    gleTelefonosCompany.Enabled =
                    gleDepartamentos.Enabled =
                    glePuestosDeTrabajo.Enabled =
                    gleProfesion.Enabled =
                    gleBandaSalarial.Enabled =
                    gleResponsable.Enabled = false;
                    break;
            }
        }

        private void SetControlesEnable_orDisable(bool pEnable)
        {
            txtEmployeeNameNombre.Enabled =
            tggActive.Enabled =
            gleDireccionPrivada.Enabled =
            gleDireccionPrivada.Enabled =
            glePaisesNacionalidad.Enabled =
            cbxSexo.Enabled =
            cbxEstadoCivil.Enabled =
            txtEsposo_esposa.Enabled =
            dtFechaNacimientoEsposa.Enabled =
            //spinEditCantHijos.Enabled =
            tsDiscapacitado.Enabled =
            txtDiscapacidad.Enabled =
            txtLugarDeNacimiento.Enabled =
            glePaisNacimientoEmployee.Enabled =
            dtFechaNacimiento.Enabled =
            txtNumeroIdentidad.Enabled =
            txtNumeroPasaporte.Enabled =
            txtContactoEmergencia.Enabled =
            txtTelefonoEmergencia.Enabled =
            spinEditKmsCasaTrabajo.Enabled =
            gleDireccionesCompany.Enabled =
            glePuestosDeTrabajo.Enabled =
            gleDepartamentos.Enabled =
            gleDepartamentos.Enabled =
            gleResponsable.Enabled =
            gleCompany.Enabled =
            tggIsManager.Enabled =
            gleProfesion.Enabled =
            txtNumeroColegiatura.Enabled =
            txtRTN.Enabled =
            cbxTipoSangre.Enabled =
            txtNumeroCuentaEmpleado.Enabled =
            txtNumeroCuentaEmpleado.Enabled =
            gleBanco.Enabled =
            gleTipoTurno.Enabled =
            txtTallaCamisa.Enabled =
            txtTallaPantalon.Enabled =
            txtTallaZapatos.Enabled =
            txtEstatura.Enabled =
            txtPeso.Enabled =
            tggMarcaAsistencia.Enabled =
            gleClaseSeguro.Enabled =
            gleClaseSeguro.Enabled =
            gleDireccionesCompany.Enabled =
            gleTelefonosCompany.Enabled =
            gleBandaSalarial.Enabled =
            spinEditNumDependientes.Enabled =
            gleNiveldeCertificado.Enabled =
            gleAmbitoEstudio.Enabled =
            gleEscuelaUniversidad.Enabled =
            gleTipoPago.Enabled =
            tggRecibeDepreciacionVehicular.Enabled =
            glueTipoContrato.Enabled =
            tsPagaDependientes.Enabled =
            btnNewContract.Enabled =
            txtCorreo.Enabled =
            txtCorreoPersonal.Enabled =
            //txtPermisoTrabajo.Enabled =
            gleVehiculo.Enabled = pEnable;
        }


        private void LoadDatosMaestros()
        {
            LoadCompanies();
            LoadDepartamentos(1);
            if (gleDepartamentos.EditValue != null)
            {
                int idDepto = dp.ValidateNumberInt32(gleDepartamentos.EditValue);
                if (gleCompany.EditValue != null)
                {
                    int idCompany = dp.ValidateNumberInt32(gleCompany.EditValue);
                    LoadPuestosDeTrabajo(idDepto, idCompany);
                }
                else
                {
                    LoadPuestosDeTrabajo(0, 1);
                }
            }
            else
            {
                LoadPuestosDeTrabajo(0, 1);
            }

            LoadProfesiones();
            LoadBandasSalariales();
            LoadResponsables();
            LoadPaises_tiposSeguro();
            LoadDireccionesPrivadas();
            LoadUniversidadAmbitoEstudio();
            LoadDatosTabConfiguracion();
            LoadAsignacionesEmpleado();
            LoadTipoContrato();
            dtFechaNacimiento.DateTime = dp.dNow().AddYears(-18);
        }

        private void LoadDatosTabConfiguracion()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                //Tipo de Turno
                SqlCommand cmd = new SqlCommand("dbo.get_datos_maestros_config_rrhh_crud_employees", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo_dato_maestro", 1);
                dsMaestroEmpleados1.TipoTurno.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.TipoTurno);

                //Tipo de Pago
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_dato_maestro", 2);
                dsMaestroEmpleados1.TipoDePago.Clear();
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.TipoDePago);

                //Bancos
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_dato_maestro", 3);
                dsMaestroEmpleados1.BancoList.Clear();
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.BancoList);

                //Vehiculo Asignado
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_dato_maestro", 4);
                dsMaestroEmpleados1.VehiculosEmpresa.Clear();
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.VehiculosEmpresa);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadUniversidadAmbitoEstudio()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                //Nivel Certificado
                SqlCommand cmd = new SqlCommand("dbo.get_datos_maestros_estudios_perfil_empleado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo_lista", 1);
                dsMaestroEmpleados1.nivel_certificado.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.nivel_certificado);

                //Ambito de estudio
                cmd = new SqlCommand("dbo.get_datos_maestros_estudios_perfil_empleado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo_lista", 2);
                dsMaestroEmpleados1.ambito_estudio.Clear();
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.ambito_estudio);

                //Escuela Universidad
                cmd = new SqlCommand("dbo.get_datos_maestros_estudios_perfil_empleado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo_lista", 3);
                dsMaestroEmpleados1.escuela_universidad.Clear();
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.escuela_universidad);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDireccionesPrivadas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.get_direcciones_empleados_list", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@company_id", pIdCompany);
                dsMaestroEmpleados1.direccion_privada.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.direccion_privada);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadPaises_tiposSeguro()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_paises_from_configuration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@company_id", pIdCompany);
                dsMaestroEmpleados1.countries_paises.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.countries_paises);

                cmd = new SqlCommand("dbo.sp_get_lista_tipos_de_seguro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@company_id", pIdCompany);
                dsMaestroEmpleados1.tipos_seguro.Clear();
                adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.tipos_seguro);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadResponsables()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_jefes_or_responsables", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@company_id", pIdCompany);
                dsMaestroEmpleados1.responsable_jefe.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.responsable_jefe);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadBandasSalariales()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_bandas_salariales", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@company_id", pIdCompany);
                dsMaestroEmpleados1.banda_salarial.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.banda_salarial);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadProfesiones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_profesiones", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@company_id", pIdCompany);
                dsMaestroEmpleados1.profesion.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.profesion);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadPuestosDeTrabajo(int pIdDepartamento, int pIdCompany)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_puestos_trabajo_job", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_departamento", pIdDepartamento);
                cmd.Parameters.AddWithValue("@id_company", pIdCompany);
                dsMaestroEmpleados1.puesto_de_trabajo.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.puesto_de_trabajo);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDepartamentos(int pIdCompany)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_departamentos_rrhh", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company_id", pIdCompany);
                dsMaestroEmpleados1.departamentos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.departamentos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadCompanies()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_load_companies_rrhh", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsMaestroEmpleados1.company.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.company);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDirecionesByCompany(int pCompanyId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_direcciones_by_company", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company_id", pCompanyId);
                dsMaestroEmpleados1.direcciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.direcciones);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadTelefonosByAddressCompany(int pAddress_id)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_telefonos_by_company_address", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_address_id", pAddress_id);
                dsMaestroEmpleados1.telefonos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.telefonos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDatosEmpleado()
        {
            if (EmpleadoActual.RecuperarDatosPorCodigo(EmpleadoActual.Barcode))
            {
                //Tab Informacion del trabajo
                lblCodigo.Text = EmpleadoActual.Barcode;
                lblNombreEmpleado.Text = EmpleadoActual.Name;
                gleCompany.EditValue = EmpleadoActual.CompanyId;
                gleDireccionesCompany.EditValue = EmpleadoActual.company_address_id;
                gleTelefonosCompany.EditValue = EmpleadoActual.company_address_phone_id;
                gleDepartamentos.EditValue = EmpleadoActual.DepartmentId;
                glePuestosDeTrabajo.EditValue = EmpleadoActual.JobId;
                gleProfesion.EditValue = EmpleadoActual.ProfessionId;
                gleBandaSalarial.EditValue = EmpleadoActual.banda_salarial_id;
                gleResponsable.EditValue = EmpleadoActual.ParentId;
                tggIsManager.IsOn = EmpleadoActual.Manager;
                tggActive.IsOn = EmpleadoActual.Active;
                //Tab Informacion Privada
                //Ciudadania e informacion adicional
                glePaisesNacionalidad.EditValue = EmpleadoActual.CountryId;
                txtNumeroIdentidad.Text = EmpleadoActual.IdentificationId;
                txtRTN.Text = EmpleadoActual.Rtn;
                txtNumeroPasaporte.Text = EmpleadoActual.PassportId;
                txtNumeroColegiatura.Text = EmpleadoActual.College;
                
                if(!string.IsNullOrEmpty(EmpleadoActual.BloodType))
                    cbxTipoSangre.Text = EmpleadoActual.BloodType;
                else
                    cbxTipoSangre.Text = string.Empty;

                //Informacion de contacto
                gleDireccionPrivada.EditValue = EmpleadoActual.DireccionPrivadaID;
                txtContactoEmergencia.Text = EmpleadoActual.EmergencyContact;
                txtTelefonoEmergencia.Text = EmpleadoActual.EmergencyPhone;
                spinEditKmsCasaTrabajo.EditValue =  EmpleadoActual.KmHomeWork;
                gleClaseSeguro.EditValue = EmpleadoActual.id_tipo_seguro;
                spinEditNumDependientes.EditValue = EmpleadoActual.Dependientes_cant;
                txtCorreo.Text = EmpleadoActual.WorkEmail;
                txtCorreoPersonal.Text = EmpleadoActual.PrivateEmail;

                //Informacion Personal
                cbxSexo.Text = EmpleadoActual.Gender;
                cbxEstadoCivil.Text = EmpleadoActual.Marital;
                spinEditCantHijos.EditValue = EmpleadoActual.Children;
                dtFechaNacimiento.EditValue = EmpleadoActual.Birthday;
                txtLugarDeNacimiento.Text = EmpleadoActual.PlaceOfBirth;
                glePaisNacimientoEmployee.EditValue = EmpleadoActual.CountryOfBirth;
                lblEdadAnios.Text = GetEdadAnios(dtFechaNacimiento.DateTime).ToString();
                lblEdadMeses.Text = GetEdadMeses(dtFechaNacimiento.DateTime).ToString();
                txtEsposo_esposa.Text = EmpleadoActual.SpouseCompleteName;
                tsDiscapacitado.EditValue = EmpleadoActual.EsDiscapacitado;
                txtDiscapacidad.Text = EmpleadoActual.Discapacidad;
                txtPermisoTrabajo.Text = EmpleadoActual.NumeroPermisoTrabajo;


                if(EmpleadoActual.SpouseBirthdate  != null)
                {
                    if (EmpleadoActual.SpouseBirthdate.Year > 1920)
                        dtFechaNacimientoEsposa.DateTime = EmpleadoActual.SpouseBirthdate;
                }
                

                //Educacion
                gleNiveldeCertificado.EditValue = EmpleadoActual.IdNivelCertificadoEstudio;
                gleAmbitoEstudio.EditValue = EmpleadoActual.IdAmbitoEstudio;
                gleEscuelaUniversidad.EditValue = EmpleadoActual.IdEscuelaUniversidad;

                //Tab Asignacion de Equipos
                //Asignacion de Equipos, tallas configuradas
                txtEstatura.Text = EmpleadoActual.Height.ToString();
                txtPeso.Text = EmpleadoActual.Weight.ToString();
                txtTallaCamisa.Text = EmpleadoActual.ShirtSize.ToString();
                txtTallaPantalon.Text = EmpleadoActual.PantSize.ToString();
                txtTallaZapatos.Text = EmpleadoActual.ShoeSize.ToString();

                //Tab Configuracion RRHH
                glueTipoContrato.EditValue = EmpleadoActual.TipoContratoId;
                //Configuraciones Iniciales
                gleTipoTurno.EditValue = EmpleadoActual.RollTypeId;
                tggMarcaAsistencia.IsOn = EmpleadoActual.Marking;
                gleTipoPago.EditValue = EmpleadoActual.IdTipoPago;
                gleBanco.EditValue = EmpleadoActual.BankId;
                txtNumeroCuentaEmpleado.Text = EmpleadoActual.EmployeeAccount;
                tggRecibeDepreciacionVehicular.IsOn = EmpleadoActual.RecibeDepreciacionVehicular;
                gleVehiculo.EditValue = EmpleadoActual.IdVehiculoAsignado;

                //Otros
                tsPagaDependientes.EditValue = EmpleadoActual.PagaPorDependientes;
            }
        }

        private void LoadTipoContrato()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.uspLoadTipoContratoV2", con);
                cmd.CommandType = CommandType.StoredProcedure;
 
                dsColaborador1.hr_contrato_tipo_contrato.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsColaborador1.hr_contrato_tipo_contrato);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void LoadContratos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsColaborador1.contract_historical.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.usp_get_contrato_employee_from_employee_CRUD", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@IdEmployee", SqlDbType.VarChar).Value = EmpleadoActual.Id;
                    da.Fill(dsColaborador1.contract_historical);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadCapacitacionesCompletadas(int id_estado)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.uspGetCapacitaciones_from_empleado_crudV2", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_employee", EmpleadoActual.Id);
                    cmd.Parameters.AddWithValue("@id_estado", id_estado);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsCapacitacion1.capacitaciones_completadas_from_employee_crud1.Clear();
                    da.Fill(dsCapacitacion1.capacitaciones_completadas_from_employee_crud1);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void LoadCapacitacionesProgramadas(int id_estado)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.uspGetCapacitaciones_from_empleado_crudV2", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_employee", EmpleadoActual.Id);
                    cmd.Parameters.AddWithValue("@id_estado", id_estado);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsCapacitacion1.capacitaciones_programadas_from_employee_crud.Clear();
                    da.Fill(dsCapacitacion1.capacitaciones_programadas_from_employee_crud);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private int GetEdadAnios(DateTime pFechaNacimiento)
        {
           
            DateTime fechaNacimiento = pFechaNacimiento;
             

            DateTime now = dp.Now();
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            if (now < fechaNacimiento.AddYears(edad))
                --edad;

            return edad;
        }

        private int GetEdadMeses(DateTime pFechaNacimiento)
        {

            DateTime fechaNacimiento = pFechaNacimiento;
            int EdadMeses=0;

            DateTime now = dp.Now();
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            if (now < fechaNacimiento.AddYears(edad))
            {
                EdadMeses = fechaNacimiento.AddYears(edad).Month - now.Month;
                int dif = Math.Abs((fechaNacimiento.AddYears(edad).Month - now.Month) + 12 * (fechaNacimiento.AddYears(edad).Year - now.Year));
                if (dif == 0)
                    EdadMeses = 11;
                else
                    EdadMeses = 12 - dif;
            }
            else
            {
                EdadMeses = now.Month - fechaNacimiento.AddYears(edad).Month;
                if (now.Day < fechaNacimiento.AddYears(edad).Day)
                    --EdadMeses;
            }
            

            return EdadMeses;
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            switch (TipoTransaccionActual)
            {
                case TipoTransaccion.View :
                    CajaDialogo.Error("No posee autorizacion para editar datos!");
                    break;
                case TipoTransaccion.Insert:
                case TipoTransaccion.Update:
                    cmdEditar.Visible = false;
                    cmdGuardar.Visible =
                    cmdGuardar.Enabled = true;
                    txtEmployeeNameNombre.Text = EmpleadoActual.Name;
                    txtCodigo.Text = EmpleadoActual.Barcode;
                    gleCompany.Enabled = 
                    gleDireccionesCompany.Enabled =
                    gleTelefonosCompany.Enabled =   
                    gleDepartamentos.Enabled =
                    glePuestosDeTrabajo.Enabled =
                    gleProfesion.Enabled =
                    gleBandaSalarial.Enabled =
                    gleResponsable.Enabled = true;
                    btnAddExpediente.Enabled= true;
                    colDelete.Visible = true;
                    btnCambiarImagen.Enabled = true;
                    txtCodigo.Visible = txtEmployeeNameNombre.Visible = true;
                    lblCodigo.Visible = lblNombreEmpleado.Visible = false;
                    SetControlesEnable_orDisable(true);//Deshabiltamos
                    break;
            }
            

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            //Guardar los cambios efectuados
            switch (TipoTransaccionActual)
            {
                case  TipoTransaccion.Insert:
                    CallInsertEmployeeStoredProcedure();
                    break;
                case TipoTransaccion.Update:
                    CallUpdateEmployeeStoredProcedure();
                    break;
                case TipoTransaccion.View:

                    break;
                default:

                    break;
            }

            cmdEditar.Visible = true;
            lblCodigo.Visible = lblNombreEmpleado.Visible = true;
            txtCodigo.Visible = txtCodigo.Visible = false;
            cmdGuardar.Enabled = false;
            //btnImage.Enabled=false;
        }

         SqlTransaction transaccionEmployee = null;
        public void CallUpdateEmployeeStoredProcedure()
        {
            try
            {

            if (string.IsNullOrEmpty(txtEmployeeNameNombre.Text))
            {
                CajaDialogo.Error("No puede actualizar un empleado dejando el nombre en blanco!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Confirma la actualización del empleado: " + txtEmployeeNameNombre.Text + "?");
            if (r != DialogResult.Yes)
                return;

            // Nombre del stored procedure
            string storedProcedureName = "[dbo].[UpdateEmployeeCRUD_V3]";

                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        // Abrir la conexión y ejecutar el procedimiento almacenado
                        connection.Open();
                        transaccionEmployee = connection.BeginTransaction();

                        command.CommandType = CommandType.StoredProcedure;
                        command.Transaction = transaccionEmployee;


                        // Asignar todos los parámetros con DBNull.Value
                        command.Parameters.AddWithValue("@id", EmpleadoActual.Id);
                        command.Parameters.AddWithValue("@name", txtEmployeeNameNombre.Text);
                        command.Parameters.AddWithValue("@active", tggActive.IsOn);
                        if (this.UsuarioLogeado != null)
                        {
                            if (this.UsuarioLogeado.Id == 0)
                                command.Parameters.AddWithValue("@user_id", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@user_id", this.UsuarioLogeado.Id);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@user_id", DBNull.Value);
                        }


                        //Direccion privada
                        if (dp.ValidateNumberInt32(gleDireccionPrivada.EditValue) == 0)
                            command.Parameters.AddWithValue("@address_home_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@address_home_id", gleDireccionPrivada.EditValue);

                        //Pais de nacionalidad
                        if (dp.ValidateNumberInt32(glePaisesNacionalidad.EditValue) == 0)
                            command.Parameters.AddWithValue("@country_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@country_id", glePaisesNacionalidad.EditValue);


                        string Genero = dp.ValidateNumberString(cbxSexo.Text);
                        if (string.IsNullOrEmpty(Genero))
                            command.Parameters.AddWithValue("@gender", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@gender", cbxSexo.Text);

                        string EstadoCivil = dp.ValidateNumberString(cbxEstadoCivil.Text);
                        if (string.IsNullOrEmpty(EstadoCivil))
                            command.Parameters.AddWithValue("@marital", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@marital", EstadoCivil);

                        if (string.IsNullOrEmpty(txtEsposo_esposa.Text))
                            command.Parameters.AddWithValue("@spouse_complete_name", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@spouse_complete_name", txtEsposo_esposa.Text);

                        if (dtFechaNacimientoEsposa.DateTime != null)
                        {
                            if (dtFechaNacimientoEsposa.DateTime.Year > 1920)
                                command.Parameters.AddWithValue("@spouse_birthdate", dtFechaNacimientoEsposa.DateTime);
                            else
                                command.Parameters.AddWithValue("@spouse_birthdate", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@spouse_birthdate", DBNull.Value);
                        }

                        command.Parameters.AddWithValue("@children", spinEditCantHijos.EditValue);

                        if (string.IsNullOrEmpty(txtLugarDeNacimiento.Text))
                            command.Parameters.AddWithValue("@place_of_birth", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@place_of_birth", txtLugarDeNacimiento.Text);



                        //Pais de nacimiento
                        if (dp.ValidateNumberInt32(glePaisNacimientoEmployee.EditValue) == 0)
                            command.Parameters.AddWithValue("@country_of_birth", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@country_of_birth", glePaisNacimientoEmployee.EditValue);

                        //Fecha Nacimiento
                        if (dtFechaNacimiento.DateTime.Year <= 1920)
                            command.Parameters.AddWithValue("@birthday", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@birthday", dtFechaNacimiento.DateTime);


                        if (string.IsNullOrEmpty(txtNumeroIdentidad.Text))
                            command.Parameters.AddWithValue("@identification_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@identification_id", txtNumeroIdentidad.Text);

                        if (string.IsNullOrEmpty(txtNumeroPasaporte.Text))
                            command.Parameters.AddWithValue("@passport_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@passport_id", txtNumeroPasaporte.Text);

                        command.Parameters.AddWithValue("@additional_note", DBNull.Value);
                        command.Parameters.AddWithValue("@certificate", DBNull.Value);
                        command.Parameters.AddWithValue("@study_field", DBNull.Value);
                        command.Parameters.AddWithValue("@study_school", DBNull.Value);

                        if (string.IsNullOrEmpty(txtContactoEmergencia.Text))
                            command.Parameters.AddWithValue("@emergency_contact", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@emergency_contact", txtContactoEmergencia.Text);


                        if (string.IsNullOrEmpty(txtTelefonoEmergencia.Text))
                            command.Parameters.AddWithValue("@emergency_phone", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@emergency_phone", txtTelefonoEmergencia.Text);

                        command.Parameters.AddWithValue("@km_home_work", spinEditKmsCasaTrabajo.EditValue);
                        command.Parameters.AddWithValue("@job_title", DBNull.Value);


                        //Direccion company
                        if (dp.ValidateNumberInt32(gleDireccionesCompany.EditValue) == 0)
                            command.Parameters.AddWithValue("@address_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@address_id", gleDireccionesCompany.EditValue);

                        command.Parameters.AddWithValue("@work_phone", DBNull.Value);
                        command.Parameters.AddWithValue("@mobile_phone", DBNull.Value);

                        //Se agrega edicion de Correo de Trabajo
                        if (string.IsNullOrEmpty(txtCorreo.Text))
                            command.Parameters.AddWithValue("@work_email", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@work_email", txtCorreo.Text);

                        //Se agrega edicion de Correo Personal
                        if (string.IsNullOrEmpty(txtCorreoPersonal.Text))
                            command.Parameters.AddWithValue("@private_email", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@private_email", txtCorreoPersonal.Text);


                        command.Parameters.AddWithValue("@work_location", DBNull.Value);

                        //Puesto de trabajo
                        if (dp.ValidateNumberInt32(glePuestosDeTrabajo.EditValue) == 0)
                            command.Parameters.AddWithValue("@job_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@job_id", glePuestosDeTrabajo.EditValue);

                        //Departamento
                        if (dp.ValidateNumberInt32(gleDepartamentos.EditValue) == 0)
                            command.Parameters.AddWithValue("@department_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@department_id", gleDepartamentos.EditValue);

                        //Responsable
                        if (dp.ValidateNumberInt32(gleResponsable.EditValue) == 0)
                            command.Parameters.AddWithValue("@parent_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@parent_id", gleResponsable.EditValue);

                        //Company
                        if (dp.ValidateNumberInt32(gleCompany.EditValue) == 0)
                            command.Parameters.AddWithValue("@company_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@company_id", gleCompany.EditValue);


                        command.Parameters.AddWithValue("@create_uid", this.UsuarioLogeado.Id);
                        command.Parameters.AddWithValue("@create_date", dp.Now());
                        command.Parameters.AddWithValue("@manager", tggIsManager.IsOn);
                        command.Parameters.AddWithValue("@medic_exam", DBNull.Value);

                        if (dp.ValidateNumberInt32(gleProfesion.EditValue) == 0)
                            command.Parameters.AddWithValue("@profession_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@profession_id", gleProfesion.EditValue);

                        command.Parameters.AddWithValue("@payment_type", DBNull.Value);

                        if (string.IsNullOrEmpty(txtNumeroColegiatura.Text))
                            command.Parameters.AddWithValue("@college", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@college", txtNumeroColegiatura.Text);

                        if (string.IsNullOrEmpty(txtRTN.Text))
                            command.Parameters.AddWithValue("@rtn", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@rtn", txtRTN.Text);

                        if (string.IsNullOrEmpty(cbxTipoSangre.Text))
                            command.Parameters.AddWithValue("@blood_type", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@blood_type", cbxTipoSangre.Text);

                        if (string.IsNullOrEmpty(txtNumeroCuentaEmpleado.Text))
                            command.Parameters.AddWithValue("@employee_account", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@employee_account", txtNumeroCuentaEmpleado.Text);

                        if (dp.ValidateNumberInt32(gleBanco.EditValue) == 0)
                            command.Parameters.AddWithValue("@bank_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@bank_id", gleBanco.EditValue);

                        if (dp.ValidateNumberInt32(gleTipoTurno.EditValue) == 0)
                            command.Parameters.AddWithValue("@roll_type_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@roll_type_id", gleTipoTurno.EditValue);

                        if (string.IsNullOrEmpty(txtTallaCamisa.Text))
                            command.Parameters.AddWithValue("@shirt_size", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@shirt_size", txtTallaCamisa.Text);

                        if (string.IsNullOrEmpty(txtTallaPantalon.Text))
                            command.Parameters.AddWithValue("@pant_size", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@pant_size", txtTallaPantalon.Text);

                        if (string.IsNullOrEmpty(txtTallaZapatos.Text))
                            command.Parameters.AddWithValue("@shoe_size", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@shoe_size", txtTallaZapatos.Text);

                        if (string.IsNullOrEmpty(txtEstatura.Text))
                            command.Parameters.AddWithValue("@height", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@height", txtEstatura.Text);

                        if (string.IsNullOrEmpty(txtPeso.Text))
                            command.Parameters.AddWithValue("@weight", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@weight", txtPeso.Text);

                        command.Parameters.AddWithValue("@marking", tggMarcaAsistencia.IsOn);
                        command.Parameters.AddWithValue("@id_grupo", DBNull.Value);
                        command.Parameters.AddWithValue("@x_hour_in", DBNull.Value);
                        command.Parameters.AddWithValue("@x_hour_out", DBNull.Value);
                        command.Parameters.AddWithValue("@x_conf_aplic", DBNull.Value);
                        command.Parameters.AddWithValue("@x_id_journal", DBNull.Value);

                        if (dp.ValidateNumberInt32(gleClaseSeguro.EditValue) == 0)
                            command.Parameters.AddWithValue("@id_tipo_seguro", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_tipo_seguro", gleClaseSeguro.EditValue);

                        if (dp.ValidateNumberInt32(gleDireccionesCompany.EditValue) == 0)
                            command.Parameters.AddWithValue("@company_address_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@company_address_id", gleDireccionesCompany.EditValue);

                        if (dp.ValidateNumberInt32(gleTelefonosCompany.EditValue) == 0)
                            command.Parameters.AddWithValue("@hr_company_address_phone_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@hr_company_address_phone_id", gleTelefonosCompany.EditValue);

                        if (dp.ValidateNumberInt32(gleBandaSalarial.EditValue) == 0)
                            command.Parameters.AddWithValue("@banda_salarial_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@banda_salarial_id", gleBandaSalarial.EditValue);

                        command.Parameters.AddWithValue("@dependientes_cant", spinEditNumDependientes.EditValue);

                        if (dp.ValidateNumberInt32(gleNiveldeCertificado.EditValue) == 0)
                            command.Parameters.AddWithValue("@id_nivel_certificado_estudio", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_nivel_certificado_estudio", gleNiveldeCertificado.EditValue);

                        if (dp.ValidateNumberInt32(gleAmbitoEstudio.EditValue) == 0)
                            command.Parameters.AddWithValue("@id_ambito_estudio", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_ambito_estudio", gleAmbitoEstudio.EditValue);

                        if (dp.ValidateNumberInt32(gleEscuelaUniversidad.EditValue) == 0)
                            command.Parameters.AddWithValue("@id_escuela_universidad", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_escuela_universidad", gleEscuelaUniversidad.EditValue);

                        if (dp.ValidateNumberInt32(gleTipoPago.EditValue) == 0)
                            command.Parameters.AddWithValue("@id_tipo_pago", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_tipo_pago", gleTipoPago.EditValue);

                        command.Parameters.AddWithValue("@depreciacion_vehicular", tggRecibeDepreciacionVehicular.IsOn);

                        if (dp.ValidateNumberInt32(gleVehiculo.EditValue) == 0)
                            command.Parameters.AddWithValue("@id_vehiculo", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_vehiculo", gleVehiculo.EditValue);

                        if (!tsDiscapacitado.IsOn)
                        {
                            command.Parameters.AddWithValue("@es_discapacitado", false);
                            command.Parameters.AddWithValue("@discapacidad", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@es_discapacitado", true);
                            command.Parameters.AddWithValue("@discapacidad", txtDiscapacidad.Text);
                        }

                        if (glePaisesNacionalidad.EditValue == null)
                        {
                            command.Parameters.AddWithValue("@numero_permiso_trabajo", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@numero_permiso_trabajo", (int)glePaisesNacionalidad.EditValue != 96 ? string.Empty : txtPermisoTrabajo.Text);
                        }

                        command.Parameters.AddWithValue("@paga_por_dependientes", tsPagaDependientes.EditValue);
                        command.Parameters.AddWithValue("@id_tipo_contrato", glueTipoContrato.EditValue== null ? 1: glueTipoContrato.EditValue);

                        command.ExecuteNonQuery();

                       if (transaccion_foto_perfil)
                        {
                            file_name_employee = DateTime.Now.ToString("ddMMyyyyHHmmss") + Path.GetExtension(file_name_employee);
                            SqlCommand cmd = new SqlCommand("dbo.uspSaveFileRRHH_employee", connection);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Transaction = transaccionEmployee;

                            cmd.Parameters.Add("@path", SqlDbType.VarChar).Value = dp.FTP_RRHH_Empleados + file_name_employee;
                            cmd.Parameters.Add("@file_name", SqlDbType.VarChar).Value = file_name_employee;
                            cmd.Parameters.Add("@id_employee", SqlDbType.Int).Value = EmpleadoActual.Id;
                            cmd.Parameters.Add("@code_employee", SqlDbType.VarChar).Value = EmpleadoActual.Barcode;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = UsuarioLogeado.Id;

                            cmd.ExecuteNonQuery();

                            Upload(path_employee_file, file_name_employee);
                        }


                        CajaDialogo.InformationAuto();
                        transaccionEmployee.Commit();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                }
            }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaccionEmployee.Rollback();
            }
        }

        public void CallInsertEmployeeStoredProcedure()
        {
            try
            {

                if (string.IsNullOrEmpty(txtEmployeeNameNombre.Text))
                {
                    CajaDialogo.Error("No puede crear un empleado sin definir el nombre!");
                    return;
                }
                DialogResult r = CajaDialogo.Pregunta("Confirma la creacion del empleado: " + txtEmployeeNameNombre.Text + "?");
                if (r != DialogResult.Yes)
                    return;


                // Nombre del stored procedure
                string storedProcedureName = "InsertEmployeeNew_V3";


                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        // Abrir la conexión y ejecutar el procedimiento almacenado
                        connection.Open();
                        transaccionEmployee = connection.BeginTransaction();

                        command.CommandType = CommandType.StoredProcedure;
                        command.Transaction = transaccionEmployee;
                        // Asignar todos los parámetros con DBNull.Value

                        command.Parameters.AddWithValue("@name", txtEmployeeNameNombre.Text);
                        command.Parameters.AddWithValue("@active", tggActive.IsOn);
                        if (this.UsuarioLogeado != null)
                        {
                            if (this.UsuarioLogeado.Id == 0)
                                command.Parameters.AddWithValue("@user_id", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@user_id", this.UsuarioLogeado.Id);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@user_id", DBNull.Value);
                        }


                        //Direccion privada
                        if (dp.ValidateNumberInt32(gleDireccionPrivada.EditValue) == 0)
                            command.Parameters.AddWithValue("@address_home_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@address_home_id", gleDireccionPrivada.EditValue);

                        //Pais de nacionalidad
                        if (dp.ValidateNumberInt32(glePaisesNacionalidad.EditValue) == 0)
                            command.Parameters.AddWithValue("@country_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@country_id", glePaisesNacionalidad.EditValue);


                        string Genero = dp.ValidateNumberString(cbxSexo.Text);
                        if (string.IsNullOrEmpty(Genero))
                            command.Parameters.AddWithValue("@gender", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@gender", cbxSexo.Text);

                        string EstadoCivil = dp.ValidateNumberString(cbxEstadoCivil.Text);
                        if (string.IsNullOrEmpty(EstadoCivil))
                            command.Parameters.AddWithValue("@marital", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@marital", EstadoCivil);

                        if (string.IsNullOrEmpty(txtEsposo_esposa.Text))
                            command.Parameters.AddWithValue("@spouse_complete_name", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@spouse_complete_name", txtEsposo_esposa.Text);

                        if (dtFechaNacimientoEsposa.DateTime != null)
                        {
                            if (dtFechaNacimientoEsposa.DateTime.Year > 1920)
                                command.Parameters.AddWithValue("@spouse_birthdate", dtFechaNacimientoEsposa.DateTime);
                            else
                                command.Parameters.AddWithValue("@spouse_birthdate", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@spouse_birthdate", DBNull.Value);
                        }

                        command.Parameters.AddWithValue("@children", spinEditCantHijos.EditValue);

                        if (string.IsNullOrEmpty(txtLugarDeNacimiento.Text))
                            command.Parameters.AddWithValue("@place_of_birth", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@place_of_birth", txtLugarDeNacimiento.Text);



                        //Pais de nacimiento
                        if (dp.ValidateNumberInt32(glePaisNacimientoEmployee.EditValue) == 0)
                            command.Parameters.AddWithValue("@country_of_birth", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@country_of_birth", glePaisNacimientoEmployee.EditValue);

                        //Fecha Nacimiento
                        if (dtFechaNacimiento.DateTime.Year <= 1920)
                            command.Parameters.AddWithValue("@birthday", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@birthday", dtFechaNacimiento.DateTime);


                        if (string.IsNullOrEmpty(txtNumeroIdentidad.Text))
                            command.Parameters.AddWithValue("@identification_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@identification_id", txtNumeroIdentidad.Text);

                        if (string.IsNullOrEmpty(txtNumeroPasaporte.Text))
                            command.Parameters.AddWithValue("@passport_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@passport_id", txtNumeroPasaporte.Text);

                        command.Parameters.AddWithValue("@additional_note", DBNull.Value);
                        command.Parameters.AddWithValue("@certificate", DBNull.Value);
                        command.Parameters.AddWithValue("@study_field", DBNull.Value);
                        command.Parameters.AddWithValue("@study_school", DBNull.Value);

                        if (string.IsNullOrEmpty(txtContactoEmergencia.Text))
                            command.Parameters.AddWithValue("@emergency_contact", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@emergency_contact", txtContactoEmergencia.Text);


                        if (string.IsNullOrEmpty(txtTelefonoEmergencia.Text))
                            command.Parameters.AddWithValue("@emergency_phone", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@emergency_phone", txtTelefonoEmergencia.Text);

                        command.Parameters.AddWithValue("@km_home_work", spinEditKmsCasaTrabajo.EditValue);
                        command.Parameters.AddWithValue("@job_title", DBNull.Value);


                        //Direccion company
                        if (dp.ValidateNumberInt32(gleDireccionesCompany.EditValue) == 0)
                            command.Parameters.AddWithValue("@address_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@address_id", gleDireccionesCompany.EditValue);

                        command.Parameters.AddWithValue("@work_phone", DBNull.Value);
                        command.Parameters.AddWithValue("@mobile_phone", DBNull.Value);

                        //Se agrega Correo de Trabajo
                        if (string.IsNullOrEmpty(txtCorreo.Text))
                            command.Parameters.AddWithValue("@work_email", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@work_email", txtCorreo.Text);

                        //Se agrega Correo Personal
                        if (string.IsNullOrEmpty(txtCorreoPersonal.Text))
                            command.Parameters.AddWithValue("@private_email", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@private_email", txtCorreoPersonal.Text);


                        command.Parameters.AddWithValue("@work_location", DBNull.Value);

                        //Puesto de trabajo
                        if (dp.ValidateNumberInt32(glePuestosDeTrabajo.EditValue) == 0)
                            command.Parameters.AddWithValue("@job_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@job_id", glePuestosDeTrabajo.EditValue);

                        //Departamento
                        if (dp.ValidateNumberInt32(gleDepartamentos.EditValue) == 0)
                            command.Parameters.AddWithValue("@department_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@department_id", gleDepartamentos.EditValue);

                        //Responsable
                        if (dp.ValidateNumberInt32(gleResponsable.EditValue) == 0)
                            command.Parameters.AddWithValue("@parent_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@parent_id", gleResponsable.EditValue);

                        //Company
                        if (dp.ValidateNumberInt32(gleCompany.EditValue) == 0)
                            command.Parameters.AddWithValue("@company_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@company_id", gleCompany.EditValue);


                        command.Parameters.AddWithValue("@create_uid", this.UsuarioLogeado.Id);
                        command.Parameters.AddWithValue("@create_date", dp.Now());
                        command.Parameters.AddWithValue("@manager", tggIsManager.IsOn);
                        command.Parameters.AddWithValue("@medic_exam", DBNull.Value);

                        if (dp.ValidateNumberInt32(gleProfesion.EditValue) == 0)
                            command.Parameters.AddWithValue("@profession_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@profession_id", gleProfesion.EditValue);

                        command.Parameters.AddWithValue("@payment_type", DBNull.Value);

                        if (string.IsNullOrEmpty(txtNumeroColegiatura.Text))
                            command.Parameters.AddWithValue("@college", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@college", txtNumeroColegiatura.Text);

                        if (string.IsNullOrEmpty(txtRTN.Text))
                            command.Parameters.AddWithValue("@rtn", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@rtn", txtRTN.Text);

                        if (string.IsNullOrEmpty(cbxTipoSangre.Text))
                            command.Parameters.AddWithValue("@blood_type", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@blood_type", cbxTipoSangre.Text);

                        if (string.IsNullOrEmpty(txtNumeroCuentaEmpleado.Text))
                            command.Parameters.AddWithValue("@employee_account", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@employee_account", txtNumeroCuentaEmpleado.Text);

                        if (dp.ValidateNumberInt32(gleBanco.EditValue) == 0)
                            command.Parameters.AddWithValue("@bank_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@bank_id", gleBanco.EditValue);

                        if (dp.ValidateNumberInt32(gleTipoTurno.EditValue) == 0)
                            command.Parameters.AddWithValue("@roll_type_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@roll_type_id", gleTipoTurno.EditValue);

                        if (string.IsNullOrEmpty(txtTallaCamisa.Text))
                            command.Parameters.AddWithValue("@shirt_size", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@shirt_size", txtTallaCamisa.Text);

                        if (string.IsNullOrEmpty(txtTallaPantalon.Text))
                            command.Parameters.AddWithValue("@pant_size", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@pant_size", txtTallaPantalon.Text);

                        if (string.IsNullOrEmpty(txtTallaZapatos.Text))
                            command.Parameters.AddWithValue("@shoe_size", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@shoe_size", txtTallaZapatos.Text);

                        if (string.IsNullOrEmpty(txtEstatura.Text))
                            command.Parameters.AddWithValue("@height", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@height", txtEstatura.Text);

                        if (string.IsNullOrEmpty(txtPeso.Text))
                            command.Parameters.AddWithValue("@weight", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@weight", txtPeso.Text);

                        command.Parameters.AddWithValue("@marking", tggMarcaAsistencia.IsOn);
                        command.Parameters.AddWithValue("@id_grupo", DBNull.Value);
                        command.Parameters.AddWithValue("@x_hour_in", DBNull.Value);
                        command.Parameters.AddWithValue("@x_hour_out", DBNull.Value);
                        command.Parameters.AddWithValue("@x_conf_aplic", DBNull.Value);
                        command.Parameters.AddWithValue("@x_id_journal", DBNull.Value);

                        if (dp.ValidateNumberInt32(gleClaseSeguro.EditValue) == 0)
                            command.Parameters.AddWithValue("@id_tipo_seguro", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_tipo_seguro", gleClaseSeguro.EditValue);

                        if (dp.ValidateNumberInt32(gleDireccionesCompany.EditValue) == 0)
                            command.Parameters.AddWithValue("@company_address_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@company_address_id", gleDireccionesCompany.EditValue);

                        if (dp.ValidateNumberInt32(gleTelefonosCompany.EditValue) == 0)
                            command.Parameters.AddWithValue("@hr_company_address_phone_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@hr_company_address_phone_id", gleTelefonosCompany.EditValue);

                        if (dp.ValidateNumberInt32(gleBandaSalarial.EditValue) == 0)
                            command.Parameters.AddWithValue("@banda_salarial_id", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@banda_salarial_id", gleBandaSalarial.EditValue);

                        command.Parameters.AddWithValue("@dependientes_cant", spinEditNumDependientes.EditValue);

                        if (dp.ValidateNumberInt32(gleNiveldeCertificado.EditValue) == 0)
                            command.Parameters.AddWithValue("@id_nivel_certificado_estudio", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_nivel_certificado_estudio", gleNiveldeCertificado.EditValue);

                        if (dp.ValidateNumberInt32(gleAmbitoEstudio.EditValue) == 0)
                            command.Parameters.AddWithValue("@id_ambito_estudio", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_ambito_estudio", gleAmbitoEstudio.EditValue);

                        if (dp.ValidateNumberInt32(gleEscuelaUniversidad.EditValue) == 0)
                            command.Parameters.AddWithValue("@id_escuela_universidad", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_escuela_universidad", gleEscuelaUniversidad.EditValue);

                        if (dp.ValidateNumberInt32(gleTipoPago.EditValue) == 0)
                            command.Parameters.AddWithValue("@id_tipo_pago", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_tipo_pago", gleTipoPago.EditValue);

                        command.Parameters.AddWithValue("@depreciacion_vehicular", tggRecibeDepreciacionVehicular.IsOn);

                        if (dp.ValidateNumberInt32(gleVehiculo.EditValue) == 0)
                            command.Parameters.AddWithValue("@id_vehiculo", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@id_vehiculo", gleVehiculo.EditValue);

                        if (!tsDiscapacitado.IsOn)
                        {
                            command.Parameters.AddWithValue("@es_discapacitado", false);
                            command.Parameters.AddWithValue("@discapacidad", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@es_discapacitado", true);
                            command.Parameters.AddWithValue("@discapacidad", txtDiscapacidad.Text);
                        }

                        if (glePaisesNacionalidad.EditValue==null)
                        {
                            command.Parameters.AddWithValue("@numero_permiso_trabajo",DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@numero_permiso_trabajo", (int)glePaisesNacionalidad.EditValue!=96 ? string.Empty : txtPermisoTrabajo.Text);
                        }

                        command.Parameters.AddWithValue("@paga_por_dependientes", tsPagaDependientes.EditValue);

                        // Abrir la conexión y ejecutar el procedimiento almacenado
                        //connection.Open();
                        this.EmpleadoActual.Id = Convert.ToInt32(command.ExecuteNonQuery());


                        if (transaccion_foto_perfil)
                        {
                            file_name_employee = DateTime.Now.ToString("ddMMyyyyHHmmss") + Path.GetExtension(file_name_employee);
                            SqlCommand cmd = new SqlCommand("dbo.uspSaveFileRRHH_employee", connection);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Transaction = transaccionEmployee;

                            cmd.Parameters.Add("@path", SqlDbType.VarChar).Value = dp.FTP_RRHH_Empleados + file_name_employee;
                            cmd.Parameters.Add("@file_name", SqlDbType.VarChar).Value = file_name_employee;
                            cmd.Parameters.Add("@id_employee", SqlDbType.Int).Value = EmpleadoActual.Id;
                            cmd.Parameters.Add("@code_employee", SqlDbType.VarChar).Value = string.IsNullOrEmpty(EmpleadoActual.Barcode) ? string.Empty : EmpleadoActual.Barcode;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = UsuarioLogeado.Id;

                            cmd.ExecuteNonQuery();

                            Upload(path_employee_file, file_name_employee);
                        }

                        //Guardar informacion de los hijos
   
                        foreach (var hijo in hijos)
                        {
                            SqlCommand cmd_children = new SqlCommand("[dbo].[uspInsertEmployee_children]", connection);
                            cmd_children.CommandType = CommandType.StoredProcedure;
                            cmd_children.Transaction = transaccionEmployee;

                            cmd_children.Parameters.AddWithValue("@genero", hijo.Genero);
                            cmd_children.Parameters.AddWithValue("@fecha_nacimiento",  hijo.FechaNacimiento);
                            cmd_children.Parameters.AddWithValue("@id_employee",  this.EmpleadoActual.Id);

                            cmd_children.ExecuteNonQuery();
                        }

                        //Guardar informacion de beneficiarios

                        foreach (var item in beneficiarios)
                        {
                                SqlCommand cmd_beneficiarios = new SqlCommand("uspInsertEmployeeBeneficiarios", connection);
                                cmd_beneficiarios.CommandType = CommandType.StoredProcedure;
                                cmd_beneficiarios.Transaction = transaccionEmployee;

                                cmd_beneficiarios.Parameters.AddWithValue("@id_employee", this.EmpleadoActual.Id);
                                cmd_beneficiarios.Parameters.AddWithValue("@identidad", item.Identidad);
                                cmd_beneficiarios.Parameters.AddWithValue("@nombre", item.Nombre);
                                cmd_beneficiarios.Parameters.AddWithValue("@porcentaje", item.Porcentaje.ToString() + "%");
                                cmd_beneficiarios.Parameters.AddWithValue("@id", item.Id);

                                cmd_beneficiarios.ExecuteNonQuery();
                        }


                        CajaDialogo.InformationAuto();
                        transaccionEmployee.Commit();
                        connection.Close();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaccionEmployee.Rollback();
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gleCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (gleCompany.EditValue != null)
            {
                int pidCompany = dp.ValidateNumberInt32(gleCompany.EditValue);
                LoadDirecionesByCompany(pidCompany);
            }
        }

        private void gleDireccionesCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (gleDireccionesCompany.EditValue != null)
            {
                int pIdDireccion = dp.ValidateNumberInt32(gleDireccionesCompany.EditValue);
                LoadTelefonosByAddressCompany(pIdDireccion);
            }
        }

        private void gleDepartamentos_EditValueChanged(object sender, EventArgs e)
        {
            if (gleDepartamentos.EditValue != null)
            {
                int idDepto = dp.ValidateNumberInt32(gleDepartamentos.EditValue);
                if (gleCompany.EditValue != null)
                {
                    int idCompany = dp.ValidateNumberInt32(gleCompany.EditValue);
                    LoadPuestosDeTrabajo(idDepto, idCompany);
                }
                
            }
        }

        private void cmdAddNewDireccionPrivada_Click(object sender, EventArgs e)
        {
            //Agregar nueva direccion privada
            frmNewDIreccionPrivada frm = new frmNewDIreccionPrivada(this.UsuarioLogeado, this.lblCodigo.Text, this.lblNombreEmpleado.Text);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadDireccionesPrivadas();
                gleDireccionPrivada.EditValue = frm.idDireccion;
            }
        }

        private void cmdAgregarUniversidad_Click(object sender, EventArgs e)
        {
            //Agregar nueva Escuela/Universidad
            frmNewItemBasic frm = new frmNewItemBasic(this.UsuarioLogeado, "Agregar una nueva Escuela/Universidad");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadUniversidadAmbitoEstudio();
                gleEscuelaUniversidad.EditValue = frm.IdEscuelaUniversidad;
            }
        }

        private void cmdCopiarClipBoardAccountEmployeeNumber_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumeroCuentaEmpleado.Text))
            {
                Clipboard.SetText(txtNumeroCuentaEmpleado.Text);
            }
        }

        private void ShowImageFromFtp(string url_ftp)
        {
            try
            {

                FTP_Class ftp1 = new FTP_Class();
                DataOperations dp = new DataOperations();

                // Crear la solicitud FTP
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url_ftp);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                // Especificar credenciales FTP
                request.Credentials = new NetworkCredential(ftp1.UserFTP, ftp1.PassFTP);

                // Obtener la respuesta como un flujo (stream)
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                {
                    // Cargar la imagen en un PictureBox desde el stream
                    if (responseStream != null)
                    {
                        pbPhoto.Image = System.Drawing.Image.FromStream(responseStream);
                    }
                    Console.WriteLine("Imagen cargada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descargar la imagen: " + ex.Message);
            }
        }

        private string GetUrlPhoto(int id_employee)
        {
            try
            {

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                string path_ = "";
                string sql = "dbo.uspGetUrlPictureProfile";

                using (SqlCommand cmd = new SqlCommand(sql, cnx))
                {
                    cnx.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", id_employee);

                    path_ = (string)cmd.ExecuteScalar();

                    cnx.Close();
                }

                return path_;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return null;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            
        }

        private bool Upload(string pathFile, string fileName)
        {
            try
            {
                if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(fileName))
                {
                    CajaDialogo.Error("No se cargó la imagen");
                    return false;
                }
                else
                {
                    FTP_Class ftp1 = new FTP_Class();
                    return ftp1.GuardarArchivoRRHHEmpleado(UsuarioLogeado, fileName, pathFile);
                }
            }

            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        private void cmdAgregarNuevo_Click(object sender, EventArgs e)
        {
            //btnImage.Enabled = true;
        }

        private void dtFechaNacimiento_EditValueChanged(object sender, EventArgs e)
        {
            lblEdadAnios.Text = GetEdadAnios(dtFechaNacimiento.DateTime).ToString();
            lblEdadMeses.Text = GetEdadMeses(dtFechaNacimiento.DateTime).ToString();
        }

       
        private void btnAddExpediente_Click(object sender, EventArgs e)
        {
            frmExpedienteCRUDPreview frm = new frmExpedienteCRUDPreview(EmpleadoActual.Id, UsuarioLogeado);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                LoadExpedientes();
            }
        }

        private void LoadExpedientes()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.uspLoadExpedientesById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employee_id", EmpleadoActual.Id);
                dsMaestroEmpleados1.expediente_empleado.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.expediente_empleado);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnOpen_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FTP_Class ftp = new FTP_Class();

                var row = (dsMaestroEmpleados.expediente_empleadoRow)gvExpediente.GetFocusedDataRow();

                if (row != null)
                {
                    ftp.OpenFile(row.path, row.file_name_);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
 
            }
        }

        private void btnDownload_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FTP_Class ftp = new FTP_Class();

                folderBrowserDialog1.Description = "Selecciona la carpeta de destino para guardar el archivo";

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                 
                    var row = (dsMaestroEmpleados.expediente_empleadoRow) gvExpediente.GetFocusedDataRow();
                    if (row != null)
                    {
                        ftp.DownloadFileV2(row.path,folderBrowserDialog1.SelectedPath,UsuarioLogeado,row.file_name_);
                        CajaDialogo.Information("Documento descargado en '"+ folderBrowserDialog1.SelectedPath+"'");
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMaestroEmpleados.expediente_empleadoRow)gvExpediente.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                var respuesta = CajaDialogo.Pregunta("¿Desea eliminar el registro?");

                if (respuesta == DialogResult.Yes)
                {

                    using (SqlCommand cmd = new SqlCommand("dbo.uspDisableExpediente", cnx))
                    {
                        cnx.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                    }

                    CajaDialogo.Information("Datos deshabilitados!");
                    LoadExpedientes();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:/";

            // Establecer el filtro para solo permitir imágenes
            openFileDialog1.Filter = "Archivos de imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path_employee_file = openFileDialog1.FileName;
                file_name_employee = openFileDialog1.SafeFileName;

                Image image = Image.FromFile(path_employee_file);
                pbPhoto.Image = image;
                transaccion_foto_perfil = true;
            }
        }

        private void btnAsignacion_Click(object sender, EventArgs e)
        {
            frm_hr_employee_asignacion_crud frm = new frm_hr_employee_asignacion_crud(frm_hr_employee_asignacion_crud.TipoTransaccionPlanilla.Nuevo,UsuarioLogeado,EmpleadoActual.Id);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                LoadAsignacionesEmpleado();
            }
        }

        private void LoadAsignacionesEmpleado()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.uspLoadAsignacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employee_id", EmpleadoActual.Id);
                dsMaestroEmpleados1.hr_empleado_asignacion.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.hr_empleado_asignacion);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnEditar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMaestroEmpleados.hr_empleado_asignacionRow)gvAsignaciones.GetFocusedDataRow();

                frm_hr_employee_asignacion_crud frm = new frm_hr_employee_asignacion_crud(frm_hr_employee_asignacion_crud.TipoTransaccionPlanilla.Editar, row.id);

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    LoadAsignacionesEmpleado();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDeleteAsignacion_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMaestroEmpleados.hr_empleado_asignacionRow)gvAsignaciones.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                var respuesta = CajaDialogo.Pregunta("¿Desea deshabilitar este registro?");

                if (respuesta == DialogResult.Yes)
                {

                    using (SqlCommand cmd = new SqlCommand("dbo.uspDisableAsignacion", cnx))
                    {
                        cnx.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                    }

                    CajaDialogo.Information("Datos deshabilitados!");
                    LoadAsignacionesEmpleado();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            frmContratoColaborador frm = new frmContratoColaborador(EmpleadoActual.Id,UsuarioLogeado, EmpleadoActual.Id);

            frm.ShowDialog();
        }

        private void btnChildren_Click(object sender, EventArgs e)
        {
            bool crear_empleado = false;

            if (TipoTransaccionActual==TipoTransaccion.Insert)
            {
                crear_empleado = true;
            }

            frmEmployeeChildrenHome frm = new frmEmployeeChildrenHome(EmpleadoActual.Id, !cmdEditar.Visible, crear_empleado,hijos);
            hijos = new List<Hr_Employee_Children>();

            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                hijos = frm.hijos;
             
                if (crear_empleado)
                {
                    spinEditCantHijos.EditValue = hijos.Count;
                }
            }
        }

        private void glePuestosDeTrabajo_EditValueChanged(object sender, EventArgs e)
        {
            PlanillaPuestoTrabajo puesto_trabajo = new PlanillaPuestoTrabajo();

            if (glePuestosDeTrabajo.EditValue != null)
            {
                if (puesto_trabajo.RecuperaRegistro((int)glePuestosDeTrabajo.EditValue))
                {
                    gleBandaSalarial.EditValue = puesto_trabajo.BandaSalarialId;
                }
            }
        }

        private void tsDiscapacitado_Toggled(object sender, EventArgs e)
        {
            if (tsDiscapacitado.IsOn)
            {
                txtDiscapacidad.Enabled =true; 
            }
            else
            {
                txtDiscapacidad.Enabled =false;
                txtDiscapacidad.EditValue = null;
            }
        }

        private void glePaisesNacionalidad_EditValueChanged(object sender, EventArgs e)
        {
            if (glePaisesNacionalidad.EditValue != null)
            {
                if (Convert.ToInt32(glePaisesNacionalidad.EditValue) != 96 && glePaisesNacionalidad.Text!="")
                {
                    txtPermisoTrabajo.Enabled = true;
                }
                else
                {
                    txtPermisoTrabajo.EditValue = null;
                    txtPermisoTrabajo.Enabled = false;
                }
            }
        }

        private void btnBeneficiarios_Click(object sender, EventArgs e)
        {
            bool crear_empleado = false;

            if (TipoTransaccionActual == TipoTransaccion.Insert)
            {
                crear_empleado = true;
            }

            frmEmployeeBeneficiariosHome frm = new frmEmployeeBeneficiariosHome(EmpleadoActual.Id, !cmdEditar.Visible, crear_empleado,beneficiarios);
            beneficiarios = new List<Hr_Beneficiario>();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                beneficiarios = frm.beneficiarios;
            }
        }

        private void btnNewContract_Click(object sender, EventArgs e)
        {
            try
            {
                DetalleContrato contratoActual = new DetalleContrato();

                contratoActual.RecuperarRegistroPorEmpleadoId(EmpleadoActual.Id, 0);


                if (contratoActual.EstadoId > 0 && contratoActual.EstadoId <5 )
                {
                    var result = CajaDialogo.Pregunta("Al seleccionar un nuevo contrato, el contrato actual se enviara a Expirado, esta usted de acuerdo?");
                    if (result == DialogResult.Yes)
                    {
                        DataOperations dp = new DataOperations();

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("uspCancelarContrato", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@contrato_id", contratoActual.ID);

                            cmd.ExecuteNonQuery();

                            cnx.Close();
                        }

                        frmContratoColaborador frm = new frmContratoColaborador(EmpleadoActual.Id, UsuarioLogeado, EmpleadoActual.Id);

                        frm.ShowDialog();
                    }
                }
                else
                {
                    frmContratoColaborador frm = new frmContratoColaborador(EmpleadoActual.Id, UsuarioLogeado, EmpleadoActual.Id);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnViewContract_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gcContratoHistorico.FocusedView;
            var row = (dsColaborador.contract_historicalRow)gridview.GetFocusedDataRow();

            //frmContratoColaborador frm = new frmContratoColaborador(EmpleadoActual.Barcode, UsuarioLogeado, EmpleadoActual.Id);
            frmContratoColaborador frm = new frmContratoColaborador(EmpleadoActual.Id, UsuarioLogeado, row.id);
            frm.ShowDialog();
        }
    }
}