using ACS.Classes;
 
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.RRHH_Planilla.Capacitacion.Model;
using LOSA.RRHH_Planilla.Mantenimientos;
using LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Capacitacion
{
    public partial class frmCapacitacionCRUD : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuario_logueados;
        Decimal total_hours = 0;
        DataOperations dp = new DataOperations();
        int IdCapacitacion = 0;
        public enum TipoTransaccion {
          Nuevo=1,
            Update=2
        }

        TipoTransaccion transaccionActual;
        CapacitacionClass capacitacionActual = new CapacitacionClass();
        public frmCapacitacionCRUD(UserLogin usuario,TipoTransaccion transacccion)
        {
            InitializeComponent();
            usuario_logueados = usuario;
            transaccionActual= transacccion;
            capacitacionActual = new CapacitacionClass();
            capacitacionActual.Moneda = "HNL";
            capacitacionActual.MonedaId = 44;
            CambiarMascaraMoneda(capacitacionActual.Moneda);

            if (transaccionActual == TipoTransaccion.Nuevo)
            {
                CambiarMascaraMoneda("HNL");
                colfile_name_.Visible = false;
                colOriginalName.Visible = true;
                colAbrir.Visible = false;
                colDescargar.Visible = false;
                CargarGastosByDefualt();
            }
        }


        public frmCapacitacionCRUD(UserLogin usuario, TipoTransaccion transacccion,int id_capacitacion)
        {
            InitializeComponent();
            usuario_logueados = usuario;
            transaccionActual = transacccion;
            IdCapacitacion = id_capacitacion;
            CargarEstados();

            if (transaccionActual == TipoTransaccion.Update)
            {
                lueEstado.Visible = true;
                lbEstado.Visible = true;

                if (capacitacionActual.RecuperaRegistrosByCapacitacionId(id_capacitacion))
                {

                    txtAsunto.Text = capacitacionActual.Asunto;
                    txtNombre.Text = capacitacionActual.Nombre;
                    txtProveedor.Text = capacitacionActual.Proveedor;
                    txtUbicacion.Text = capacitacionActual.Ubicacion;
                    txtDuracion.EditValue = capacitacionActual.Duracion;
                    deFecha.EditValue = capacitacionActual.FechaProgramada;
                    txtCosto.EditValue = capacitacionActual.Costo;
                    txtDescripcion.Text = capacitacionActual.Descripcion;
       
                    lueEstado.EditValue = capacitacionActual.EstadoId;
                    lblTotalhrs.Text = $"Total hrs: {capacitacionActual.TotalHours} hrs";
                    deFechaEjecucion.EditValue = capacitacionActual.FechaEjecucion;

                    colOriginalName.Visible = false;


                    ObtenerCapacitadores(id_capacitacion);
                    ObtenerEmpleadosById(id_capacitacion);
                    CargarAdjuntos(capacitacionActual.Id);
                    CargarEstados();
                    CambiarMascaraMoneda(capacitacionActual.Moneda);
                }

                if (transaccionActual == TipoTransaccion.Nuevo)
                {
                    CambiarMascaraMoneda("HNL");
                    colfile_name_.Visible=false;
                    colOriginalName.Visible=true;
                    colAbrir.Visible = false;
                    colDescargar.Visible=false;
                }
                CargarGastosByDefualt();
            }
        }

  
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSeleccionEmpleadosFromCapacitacion frm = new frmSeleccionEmpleadosFromCapacitacion(IdCapacitacion);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                switch (transaccionActual)
                {
                    case TipoTransaccion.Nuevo:
                            // Suponiendo que frm.empleados es una lista o colección que implementa IList o similar
                            for (int i = 0; i < frm.empleados.Count; i++)
                            {
                                var item = frm.empleados[i];

                                // Definir el criterio de búsqueda
                                string searchExpression = $"id_employee = {item.Id}";

                                // Usar el método Select para buscar filas que cumplan el criterio
                                DataRow[] foundRows = dsCapacitacion1.capacitacion_empleados.Select(searchExpression);

                                // Verificar y mostrar los resultados de la búsqueda
                                if (foundRows.Length > 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    // Crear una nueva fila
                                    DataRow newRow = dsCapacitacion1.capacitacion_empleados.NewRow();
                                    newRow["id_employee"] = item.Id;
                                    newRow["barcode"] = item.Codigo;
                                    newRow["nombre"] = item.Nombre;
                                    newRow["department_id"] = item.DepartmentId;
                                    newRow["department"] = item.Department;
                                    newRow["job_id"] = item.JobId;
                                    newRow["job_title"] = item.JobTitle;

                                    // Agregar la fila al DataTable
                                    dsCapacitacion1.capacitacion_empleados.Rows.Add(newRow);
                                }
                            }
                        break;
                    case TipoTransaccion.Update:

                        SqlTransaction transaction = null;
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                        bool Guardar = false;

                        try
                        {
                            conn.Open();
                            transaction = conn.BeginTransaction("Transaction Order");

                            foreach (var empleados in frm.empleados) //Lista de Empleados 
                            {
                                SqlCommand cmd = conn.CreateCommand();
                                cmd.CommandText = "sp_insert_capacitacion_update";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@employee_id", empleados.Id);
                                cmd.Parameters.AddWithValue("@training_id", IdCapacitacion);
                                cmd.ExecuteNonQuery();//Ejecutamos el SP por cada Empleado!
                                Guardar = true;
                            }

                            transaction.Commit();//Si todo sale bien, se Guarda
                        }
                        catch (Exception ec)
                        {
                            if (transaction != null)
                                transaction.Rollback(); // Deshacer los cambios si hay un error

                            CajaDialogo.Error(ec.Message);
                            Guardar = false;
                        }
                        finally
                        {
                            conn.Close();
                        }

                        if(Guardar)
                        {
                            ObtenerEmpleadosById(IdCapacitacion);
                        }


                        break;
                    default:
                        break;
                }

                

                int cantidad_empleados = gvEmpleados.RowCount;

                if (txtDuracion.EditValue != null)
                {

                    Decimal duracion = Convert.ToDecimal(txtDuracion.EditValue);

                    total_hours = duracion * cantidad_empleados;

                    lblTotalhrs.Text = $"Total hrs: {total_hours} hrs";
                }


            }



            //if (frm.ShowDialog() == DialogResult.OK)
            //{

            //    // Suponiendo que frm.empleados es una lista o colección que implementa IList o similar
            //    for (int i = 0; i < frm.empleados.Count; i++)
            //    {
            //        var item = frm.empleados[i];

            //        // Definir el criterio de búsqueda
            //        string searchExpression = $"id_employee = {item.Id}";

            //        // Usar el método Select para buscar filas que cumplan el criterio
            //        DataRow[] foundRows = dsCapacitacion1.capacitacion_empleados.Select(searchExpression);

            //        // Verificar y mostrar los resultados de la búsqueda
            //        if (foundRows.Length > 0)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            // Crear una nueva fila
            //            DataRow newRow = dsCapacitacion1.capacitacion_empleados.NewRow();
            //            newRow["id_employee"] = item.Id;
            //            newRow["barcode"] = item.Codigo;
            //            newRow["nombre"] = item.Nombre;
            //            newRow["department_id"] = item.DepartmentId;
            //            newRow["department"] = item.Department;
            //            newRow["job_id"] = item.JobId;
            //            newRow["job_title"] = item.JobTitle;

            //            // Agregar la fila al DataTable
            //            dsCapacitacion1.capacitacion_empleados.Rows.Add(newRow);
            //        }
            //    }

            //        int cantidad_empleados = gvEmpleados.RowCount;

            //        if (txtDuracion.EditValue != null)
            //        {

            //            Decimal duracion = Convert.ToDecimal(txtDuracion.EditValue);

            //            total_hours = duracion * cantidad_empleados;

            //            lblTotalhrs.Text = $"Total hrs: {total_hours} hrs";
            //        }


            //}
        }

        private void btnDelete_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                switch (transaccionActual)
                {
                    case TipoTransaccion.Nuevo:
                         gvEmpleados.DeleteRow(gvEmpleados.FocusedRowHandle);
                        break;
                    case TipoTransaccion.Update:
                            var row = (dsCapacitacion.capacitacion_empleadosRow)gvEmpleados.GetFocusedDataRow();

                            if (row != null)
                            {
                                DataOperations dp = new DataOperations();
                                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                                var respuesta = CajaDialogo.Pregunta("¿Desea desactivar el registro?");

                                if (respuesta == DialogResult.Yes)
                                {

                                    using (SqlCommand cmd = new SqlCommand("dbo.uspDesactivar_empleado_de_capacitacion", cnx))
                                    {
                                        cnx.Open();
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                                        cmd.ExecuteNonQuery();
                                        cnx.Close();
                                    }

                                    CajaDialogo.Information("Empleado desactivado!");
                                    gvEmpleados.DeleteRow(gvEmpleados.FocusedRowHandle);
                                dsCapacitacion1.AcceptChanges();
                                }
                            }
                       
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
               
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();

                if (string.IsNullOrEmpty(txtAsunto.Text))
                {
                    CajaDialogo.Error("Debe de ingresar un asunto");
                    return;
                }

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    CajaDialogo.Error("Debe de ingresar un nombre");
                    return;
                }

                if (deFecha.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar una fecha");
                    return;
                }

                if (deFechaEjecucion.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar una fecha de Ejecucion");
                    return;
                }

                if (string.IsNullOrEmpty(txtUbicacion.Text))
                {
                    CajaDialogo.Error("Debe de ingresar una ubicacion");
                    return;
                }

                if (string.IsNullOrEmpty(txtProveedor.Text))
                {
                    CajaDialogo.Error("Debe de ingresar un proveedor ubicacion");
                    return;
                }

                if (txtDuracion.EditValue == null)
                {
                    CajaDialogo.Error("Debe de ingresar una duracion");
                    return;
                }

                if (dsCapacitacion1.capacitador.Rows.Count == 0)
                {
                    CajaDialogo.Error("Debe de ingresar minimo un Capacitador");
                    return;
                }

                if (dsCapacitacion1.capacitacion_empleados.Rows.Count == 0)
                {
                    CajaDialogo.Error("Debe de ingresar empleados a capacitar");
                    return;
                }

                foreach (var item in dsCapacitacion1.capacitador)
                {
                    if (string.IsNullOrEmpty(item.nombre))
                    {
                        CajaDialogo.Error("Debe de ingresar el nombre de los capacitadores");
                        return;
                    }
                }

                switch (transaccionActual)
                {
                    case TipoTransaccion.Nuevo:
                        using (SqlConnection connection = new SqlConnection(dp.ConnectionStringRRHH))
                        {
                            // Crear el comando para el procedimiento almacenado
                            SqlCommand command = new SqlCommand("dbo.uspCrearCapacitacionV3", connection);
                            command.CommandType = CommandType.StoredProcedure;

                            // Definir y agregar los parámetros
                            command.Parameters.AddWithValue("@user_id", usuario_logueados.Id);
                            command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            command.Parameters.AddWithValue("@asunto", txtAsunto.Text);
                            command.Parameters.AddWithValue("@ubicacion", txtUbicacion.Text);
                            command.Parameters.AddWithValue("@proveedor", txtProveedor.Text);
                            command.Parameters.AddWithValue("@fecha", deFecha.EditValue);
                            command.Parameters.AddWithValue("@fecha_ejecucion", deFechaEjecucion.EditValue == null ? DBNull.Value : deFechaEjecucion.EditValue);
                            command.Parameters.AddWithValue("@costo", txtCosto.EditValue == null ? DBNull.Value : txtCosto.EditValue);
                            command.Parameters.AddWithValue("@duracion", txtDuracion.EditValue);
                            command.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                            command.Parameters.AddWithValue("@total_hours", total_hours);
                            command.Parameters.AddWithValue("@currency_id", capacitacionActual.MonedaId);

                            // Llenar el DataTable para @capacitadores
                            DataTable capacitadoresTable = new DataTable();
                            capacitadoresTable.Columns.Add("id", typeof(int));
                            capacitadoresTable.Columns.Add("nombre", typeof(string));
                            capacitadoresTable.Columns.Add("contacto", typeof(string));

                            foreach (var item in dsCapacitacion1.capacitador)
                            {
                                capacitadoresTable.Rows.Add(item.id, item.nombre, item.contact_info);

                            }

                            SqlParameter capacitadoresParam = command.Parameters.AddWithValue("@capacitadores", capacitadoresTable);
                            capacitadoresParam.SqlDbType = SqlDbType.Structured;

                            //Llenar el DataTable para @empleados
                            DataTable empleadosTable = new DataTable();
                            empleadosTable.Columns.Add("id", typeof(int));
                            empleadosTable.Columns.Add("id_employee", typeof(int));

                            foreach (var item in dsCapacitacion1.capacitacion_empleados)
                            {
                                empleadosTable.Rows.Add(item.id, item.id_employee);

                            }

                            SqlParameter empleadosParam = command.Parameters.AddWithValue("@empleados", empleadosTable);
                            empleadosParam.SqlDbType = SqlDbType.Structured;

                            //Llenar el DataTable para @adjuntos
                            DataTable adjuntosTable = new DataTable();
                            adjuntosTable.Columns.Add("id", typeof(int));
                            adjuntosTable.Columns.Add("file_name_", typeof(string));
                            adjuntosTable.Columns.Add("descripcion", typeof(string));
                            adjuntosTable.Columns.Add("tipo_adjunto_id", typeof(int));
                            adjuntosTable.Columns.Add("file_name_original", typeof(string));
                            adjuntosTable.Columns.Add("path_", typeof(string));

                            foreach (var item in dsCapacitacion1.capacitacion_adjuntos)
                            {
                                adjuntosTable.Rows.Add(item.id, item.file_name_, item.descripcion, item.tipo_adjunto_id, item.file_name_original, dp.FTP_RRHH_Capacitaciones + item.file_name_);
                            }

                            SqlParameter adjuntosParam = command.Parameters.AddWithValue("@adjuntos", adjuntosTable);
                            empleadosParam.SqlDbType = SqlDbType.Structured;



                            Boolean result;

                            foreach (var item in dsCapacitacion1.capacitacion_adjuntos)
                            {
                                result = false;
                                Upload(item.path_, item.file_name_);
                                result = true;
                            }

                            //Insertar Otros Gastos
                            //Llenar el DataTable para @adjuntos
                            DataTable otros_gastros_Table = new DataTable();
                            otros_gastros_Table.Columns.Add("id", typeof(int));
                            otros_gastros_Table.Columns.Add("id_tipo_gasto", typeof(int));
                            otros_gastros_Table.Columns.Add("monto", typeof(decimal));

                            foreach (var item in dsCapacitacion1.otros_gastos)
                            {
                                otros_gastros_Table.Rows.Add(item.id, item.id_tipo_gasto, item.monto);
                            }

                            SqlParameter otros_gastos_Param = command.Parameters.AddWithValue("@otros_gastos", otros_gastros_Table);
                            otros_gastos_Param.SqlDbType = SqlDbType.Structured;


                            // Abrir la conexión y ejecutar el comando
                            connection.Open();

                            result = Convert.ToBoolean(command.ExecuteScalar());

                            connection.Close();

                            // Comprobar el valor de retorno
                            if (result != null && Convert.ToBoolean(result))
                            {
                                CajaDialogo.Information("Capacitación creada exitosamente.");
                                //this.DialogResult = DialogResult.OK;
                                LimpiarPantalla();

                            }
                            else
                            {
                                CajaDialogo.Error("Error al crear la capacitación.");
                                this.DialogResult = DialogResult.Cancel;

                            }
                        }

                        break;
                    case TipoTransaccion.Update:
                        using (SqlConnection connection = new SqlConnection(dp.ConnectionStringRRHH))
                        {
                            // Crear el comando para el procedimiento almacenado
                            SqlCommand command = new SqlCommand("dbo.uspUpdateCapacitacionV2", connection);
                            command.CommandType = CommandType.StoredProcedure;

                            // Definir y agregar los parámetros
                            command.Parameters.AddWithValue("@estado_id", lueEstado.EditValue);
                            command.Parameters.AddWithValue("@id_capacitacion", capacitacionActual.Id);
                            command.Parameters.AddWithValue("@user_id", usuario_logueados.Id);
                            command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            command.Parameters.AddWithValue("@asunto", txtAsunto.Text);
                            command.Parameters.AddWithValue("@ubicacion", txtUbicacion.Text);
                            command.Parameters.AddWithValue("@proveedor", txtProveedor.Text);
                            command.Parameters.AddWithValue("@fecha_ejecucion", deFechaEjecucion.EditValue == null ? DBNull.Value : deFechaEjecucion.EditValue);
                            command.Parameters.AddWithValue("@fecha", deFecha.EditValue);
                            command.Parameters.AddWithValue("@costo", txtCosto.EditValue == null ? DBNull.Value : txtCosto.EditValue);
                            command.Parameters.AddWithValue("@duracion", txtDuracion.EditValue);
                            command.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                            command.Parameters.AddWithValue("@total_hours", total_hours);

                            // Llenar el DataTable para @capacitadores
                            DataTable capacitadoresTable = new DataTable();
                            capacitadoresTable.Columns.Add("id", typeof(int));
                            capacitadoresTable.Columns.Add("nombre", typeof(string));
                            capacitadoresTable.Columns.Add("contacto", typeof(string));

                            foreach (var item in dsCapacitacion1.capacitador)
                            {
                                capacitadoresTable.Rows.Add(item.id, item.nombre, item.contact_info);

                            }

                            SqlParameter capacitadoresParam = command.Parameters.AddWithValue("@capacitadores", capacitadoresTable);
                            capacitadoresParam.SqlDbType = SqlDbType.Structured;

                            ////Llenar el DataTable para @empleados
                            //DataTable empleadosTable = new DataTable();
                            //empleadosTable.Columns.Add("id", typeof(int));
                            //empleadosTable.Columns.Add("id_employee", typeof(int));

                            //foreach (var item in dsCapacitacion1.capacitacion_empleados)
                            //{
                            //    empleadosTable.Rows.Add(item.id, item.id_employee);

                            //}

                            //SqlParameter empleadosParam = command.Parameters.AddWithValue("@empleados", empleadosTable);
                            //empleadosParam.SqlDbType = SqlDbType.Structured;

                            //Llenar el DataTable para @adjuntos
                            DataTable adjuntosTable = new DataTable();
                            adjuntosTable.Columns.Add("id", typeof(int));
                            adjuntosTable.Columns.Add("file_name_", typeof(string));
                            adjuntosTable.Columns.Add("descripcion", typeof(string));
                            adjuntosTable.Columns.Add("tipo_adjunto_id", typeof(int));
                            adjuntosTable.Columns.Add("file_name_original", typeof(string));
                            adjuntosTable.Columns.Add("path_", typeof(string));

                            foreach (var item in dsCapacitacion1.capacitacion_adjuntos)
                            {
                                adjuntosTable.Rows.Add(item.id, item.file_name_, item.descripcion, item.tipo_adjunto_id, item.file_name_original, dp.FTP_RRHH_Capacitaciones + item.file_name_);
                            }

                            SqlParameter adjuntosParam = command.Parameters.AddWithValue("@adjuntos", adjuntosTable);
                            //empleadosParam.SqlDbType = SqlDbType.Structured;


                            // Abrir la conexión y ejecutar el comando
                            connection.Open();
                            Boolean result;

                            foreach (var item in dsCapacitacion1.capacitacion_adjuntos)
                            {
                                if (item.id == 0)
                                {
                                    result = false;
                                    Upload(item.path_, item.file_name_);
                                    result = true;
                                }
                            }

                            result = Convert.ToBoolean(command.ExecuteScalar());

                            // Comprobar el valor de retorno
                            if (result)
                            {
                                CajaDialogo.Information("Capacitación Actualizada exitosamente.");
                                //this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                CajaDialogo.Error("Error al Actualizar la capacitación.");
                                this.DialogResult = DialogResult.Cancel;
                            }
                        }

                        ObtenerEmpleadosById(capacitacionActual.Id);
                        ObtenerCapacitadores(capacitacionActual.Id);
                        CargarAdjuntos(capacitacionActual.Id);
                        break;
                    default:
                        break;
                }


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDeleteCapacitador_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                switch (transaccionActual)
                {
                    case TipoTransaccion.Nuevo:
                        var respuesta_nuevo = CajaDialogo.Pregunta("¿Desea desactivar el registro?");

                        if (respuesta_nuevo == DialogResult.Yes)
                        {
                            gvCapacitadores.DeleteRow(gvCapacitadores.FocusedRowHandle);
                        }
                        break;
                    case TipoTransaccion.Update:
                        var row = (dsCapacitacion.capacitadorRow)gvCapacitadores.GetFocusedDataRow();

                        if (row != null)
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                            var respuesta = CajaDialogo.Pregunta("¿Desea desactivar el registro?");

                            if (respuesta == DialogResult.Yes)
                            {

                                using (SqlCommand cmd = new SqlCommand("dbo.uspDesactivar_capacitador_de_capacitacion", cnx))
                                {
                                    cnx.Open();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                                    cmd.ExecuteNonQuery();
                                    cnx.Close();
                                }

                                CajaDialogo.Information("Capacitador desactivado!");
                                gvCapacitadores.DeleteRow(gvCapacitadores.FocusedRowHandle);
                            }
                        }
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void ObtenerCapacitadores(int id_capacitacion)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    
                    SqlCommand cmd = new SqlCommand("uspGetCapacitadores_by_capacitacion_id_Class", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_capacitacion", id_capacitacion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsCapacitacion1.capacitador.Clear();
                    da.Fill(dsCapacitacion1.capacitador);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                 
            }
        }


        private void ObtenerEmpleadosById(int id_capacitacion)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("uspGetEmployee_by_capacitacio_id", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_capacitacion", id_capacitacion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsCapacitacion1.capacitacion_empleados.Clear();
                    da.Fill(dsCapacitacion1.capacitacion_empleados);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void CargarEstados()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspCargarEstadosCapacitacion",cnx);
                    dsCapacitacion1.capacitacion_estados.Clear();
                    da.Fill(dsCapacitacion1.capacitacion_estados);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void CargarGastosByDefualt()
        {
            try
            {
                DataOperations dp = new DataOperations();

                switch (transaccionActual)
                {
                    case TipoTransaccion.Nuevo:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                        {
                            cnx.Open();

                            SqlDataAdapter da = new SqlDataAdapter("dbo.uspGet_Default_OtrosGastos", cnx);
                            dsCapacitacion1.otros_gastos.Clear();
                            da.Fill(dsCapacitacion1.otros_gastos);
                            cnx.Close();

                        }
                        break;
                    case TipoTransaccion.Update:
                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("dbo.usp_Get_Gastos_capacitacion_from_crud_edit_option", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_capacitacion",capacitacionActual.Id);

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            dsCapacitacion1.otros_gastos.Clear();
                            da.Fill(dsCapacitacion1.otros_gastos);
                            cnx.Close();

                        }
                        break;
                    default:
                        break;
                }

               
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void CambiarMascaraMoneda(string moneda)
        {
            switch (moneda.ToUpper())
            {
                case "USD": // Dólares
                    txtCosto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    txtCosto.Properties.Mask.EditMask = "c"; // Formato monetario
                    txtCosto.Properties.Mask.Culture = new CultureInfo("en-US"); // Formato de EE.UU. (USD)
                    txtCosto.Properties.Mask.UseMaskAsDisplayFormat = true;
                    break;

                case "HNL": // Lempiras
                    txtCosto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    txtCosto.Properties.Mask.EditMask = "c"; // Formato monetario
                    txtCosto.Properties.Mask.Culture = new CultureInfo("es-HN"); // Formato de Honduras (HNL)
                    txtCosto.Properties.Mask.UseMaskAsDisplayFormat = true;
                    break;


            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                switch (transaccionActual)
                {
                    case TipoTransaccion.Nuevo:
                        
                        if (capacitacionActual.Moneda=="USD")
                        {
                            capacitacionActual.MonedaId = 44;//HNL
                            capacitacionActual.Moneda = "HNL";//HNL
                            CajaDialogo.Information("Se ha cambiado la moneda a HNL");
                            CambiarMascaraMoneda(capacitacionActual.Moneda);
                        }
                        else
                        {
                            capacitacionActual.MonedaId = 2;//USD
                            capacitacionActual.Moneda = "USD";//HNL
                            CajaDialogo.Information("Se ha cambiado la moneda a USD");
                            CambiarMascaraMoneda(capacitacionActual.Moneda);
                        }
                        break;
                    case TipoTransaccion.Update:
                        string mensaje = "";

                        mensaje= capacitacionActual.CambiarMonedaCostoCapacitacion(capacitacionActual.Id, capacitacionActual.MonedaId);
                        capacitacionActual.RecuperaRegistrosByCapacitacionId(capacitacionActual.Id);

                        CajaDialogo.Information(mensaje);
                        CambiarMascaraMoneda(capacitacionActual.Moneda);
                        break;
                    default:
                        break;
                }
               
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        private void txtDuracion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
            int cantidad_empleados = gvEmpleados.RowCount;

            if (txtDuracion.EditValue!=null)
            {

            Decimal duracion = Convert.ToDecimal(txtDuracion.EditValue);

                    total_hours = duracion * cantidad_empleados;

            lblTotalhrs.Text = $"Total hrs: {total_hours} hrs";
            }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAddAttach_Click(object sender, EventArgs e)
        {

            switch (transaccionActual)
            {
                case TipoTransaccion.Nuevo:
                    frmCapacitacionAdjuntoCRUD frm = new frmCapacitacionAdjuntoCRUD();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        // Crear una nueva fila
                        DataRow nuevaFila = dsCapacitacion1.capacitacion_adjuntos.NewRow();

                        // Asignar valores a las columnas de la nueva fila
                        nuevaFila["id"] = 0;
                        nuevaFila["file_name_"] = frm.adjuntos.FileName;
                        nuevaFila["descripcion"] = frm.adjuntos.Descripcion;
                        nuevaFila["tipo_adjunto"] = frm.adjuntos.Tipo;
                        nuevaFila["path_"] = frm.adjuntos.Path;
                        nuevaFila["file_name_original"] = frm.adjuntos.FileNameOriginal;
                        nuevaFila["tipo_adjunto_id"] = frm.adjuntos.TipoId;

                        // Agregar la fila al DataTable
                        dsCapacitacion1.capacitacion_adjuntos.Rows.Add(nuevaFila);

                        dsCapacitacion1.AcceptChanges();
                        btnSave.Enabled = true;
                    }

                    break;
                case TipoTransaccion.Update:
                    frmCapacitacionAdjuntoCRUD frm2 = new frmCapacitacionAdjuntoCRUD();
                    if (frm2.ShowDialog() == DialogResult.OK)
                    {
                        // Crear una nueva fila
                        DataRow nuevaFila = dsCapacitacion1.capacitacion_adjuntos.NewRow();

                        // Asignar valores a las columnas de la nueva fila
                        nuevaFila["id"] = 0;
                        nuevaFila["file_name_"] = frm2.adjuntos.FileName;
                        nuevaFila["descripcion"] = frm2.adjuntos.Descripcion;
                        nuevaFila["tipo_adjunto"] = frm2.adjuntos.Tipo;
                        nuevaFila["path_"] = frm2.adjuntos.Path;
                        nuevaFila["file_name_original"] = frm2.adjuntos.FileNameOriginal;
                        nuevaFila["tipo_adjunto_id"] = frm2.adjuntos.TipoId;

                        // Agregar la fila al DataTable
                        dsCapacitacion1.capacitacion_adjuntos.Rows.Add(nuevaFila);

                        dsCapacitacion1.AcceptChanges();
                        btnSave.Enabled = true;
                    }
                    break;
                default:
                    break;
            }
           
        }

        private void CargarAdjuntos(int id_capacitacion)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.uspGet_adjuntos_capacitacion_by_id", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_capacitacion", id_capacitacion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsCapacitacion1.capacitacion_adjuntos.Clear();
                    da.Fill(dsCapacitacion1.capacitacion_adjuntos);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void btnOpen_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsCapacitacion.capacitacion_adjuntosRow)gvAdjuntos.GetFocusedDataRow();

                if (row.id!=0)
                {

                FTP_Class ftp = new FTP_Class();

                        if (row != null)
                        {
                            ftp.OpenFile(row.path_, row.file_name_);
                        }
                }
                else
                {
                    Process.Start(row.path_);
                }
                              

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void btnDescargar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FTP_Class ftp = new FTP_Class();

                var row = (dsCapacitacion.capacitacion_adjuntosRow)gvAdjuntos.GetFocusedDataRow();

                if (row.id != 0)
                {
                    saveFileDialog1.FileName = row.file_name_;

                    // Establece el filtro para mostrar todos los tipos de archivos
                    saveFileDialog1.Filter = "Todos los archivos (*.*)|*.*";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (row != null)
                        {
                            ftp.DownloadFileV2(row.path_, saveFileDialog1.FileName.Replace(Path.GetFileName(saveFileDialog1.FileName), ""), usuario_logueados, row.file_name_);
                            CajaDialogo.Information("Documento descargado en '" + saveFileDialog1.FileName + "'");
                        }
                    }
                }
                else
                {
                            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) 
                            {
                                
                                if (saveFileDialog.ShowDialog() == DialogResult.OK) 
                                { 
                                    string destinationFilePath = saveFileDialog.FileName; 
                                    File.Copy(row.path_, destinationFilePath, true); 
                                    MessageBox.Show("Archivo descargado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                                } 
                            } 
           
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDeleteAdjunto_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                switch (transaccionActual)
                {
                    case TipoTransaccion.Nuevo:
                        gvAdjuntos.DeleteRow(gvAdjuntos.FocusedRowHandle);
                        break;
                    case TipoTransaccion.Update:
                        var row = (dsCapacitacion.capacitacion_adjuntosRow)gvAdjuntos.GetFocusedDataRow();

                        DataOperations dp = new DataOperations();
                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                        var respuesta = CajaDialogo.Pregunta("¿Desea desactivar el registro?");

                        if (respuesta == DialogResult.Yes)
                        {

                            using (SqlCommand cmd = new SqlCommand("dbo.uspDesactivar_capacitacion_adjunto", cnx))
                            {
                                cnx.Open();
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id", row.id);
                                cmd.ExecuteNonQuery();
                                cnx.Close();
                            }

                            CajaDialogo.Information("Adjunto desactivado!");
                            //CargarAdjuntos(capacitacionActual.Id);
                            gvAdjuntos.DeleteRow(gvAdjuntos.FocusedRowHandle);
                            dsCapacitacion1.AcceptChanges();
                        }
                        break;
                    default:
                        break;
                }

               
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
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
                    return ftp1.GuardarArchivoRRHHCapacitacion(usuario_logueados, fileName, pathFile);
                }
            }

            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        private void lueEstado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int cantidad_empleados = gvEmpleados.RowCount;

                if (txtDuracion.EditValue != null)
                {

                    Decimal duracion = Convert.ToDecimal(txtDuracion.EditValue);

                    total_hours = duracion * cantidad_empleados;

                    lblTotalhrs.Text = $"Total hrs: {total_hours} hrs";
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gvOtrosGastos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (transaccionActual == TipoTransaccion.Update)
                {
                    if (e.Column.FieldName == "monto")
                    {
                        // Obtén el valor editado
                        var editedValue = e.Value;

                        // Si el valor es null o vacío, establece 0 como valor predeterminado
                        if (editedValue == null || string.IsNullOrWhiteSpace(editedValue.ToString()))
                        {
                            gvOtrosGastos.SetRowCellValue(e.RowHandle, e.Column, 0);
                        }
                        else
                        {
                            DataOperations dp = new DataOperations();

                            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                            {
                                SqlCommand cmd = new SqlCommand("dbo.usp_update_otros_gastos_capacitacion", cnx);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_gasto", gvOtrosGastos.GetRowCellValue(e.RowHandle, colid));
                                cmd.Parameters.AddWithValue("@monto", gvOtrosGastos.GetRowCellValue(e.RowHandle, colmonto));
                                cmd.Parameters.AddWithValue("@id_tipo_gasto", gvOtrosGastos.GetRowCellValue(e.RowHandle, colid_tipo_gasto));
                                cmd.Parameters.AddWithValue("@id_capacitacion", capacitacionActual.Id);

                                cnx.Open();
                                cmd.ExecuteNonQuery();
                                cnx.Close();

                                //CajaDialogo.Information("Se ha actualizado el gasto seleccionado");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gcEmpleados.ExportToXlsx(dialog.FileName);
            }
        }

        private void LimpiarPantalla()
        {
            deFecha.EditValue = null;
            deFechaEjecucion.EditValue = null;
            txtAsunto.EditValue = null;
            txtNombre.EditValue = null;
            txtProveedor.EditValue = null;
            txtUbicacion.EditValue= null;
            txtCosto.EditValue= null;
            txtDuracion.EditValue= null;
            txtDescripcion.EditValue = null;
            dsCapacitacion1.capacitacion_adjuntos.Clear();
            dsCapacitacion1.capacitador.Clear();
            dsCapacitacion1.capacitacion_empleados.Clear();
            dsCapacitacion1.otros_gastos.Clear();

        }
    }
}