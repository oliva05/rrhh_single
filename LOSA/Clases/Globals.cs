﻿//LOSA


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACS.Classes
{
    //enum listaAmbientes{ Produccion, Desarrollo, HAMACHI };

    public class Globals
    {
        //Cambiar aqui: ------------------------------------
        //listaAmbientes value = listaAmbientes.Desarrollo;
        //--------------------------------------------------

        public enum Especies
        {
            Tilapia = 1,
            Camaron = 2
        }
        #region Credenciales Producción

        ////WINCC
        //public static string CMS_ServerPellet = "AQFSVR010\\AQFSVR010";
        //public static string CMS_ServerExtruder = "AQFSVR010\\AQFSVR010";
        //public static string CMS_DB_User = "losa_user_db";
        //public static string CMS_DB_Pass = "";
        //public static string CMS_ActiveDB = "process_data";

        ////Ttrace
        //public static string ServerAddress = "AQFSVR010\\AQFSVR010";
        //public static string ServerName = "Servidor Productivo";
        //public static string ActiveDB = "ACS";
        //public static string DB_User = "losa_user_db";
        //public static string DB_Pass = "AquaF33dHN2014";

        ////ACS(Costos)
        //public static string CTS_ServerAddress = "AQFSVR010";
        //public static string CTS_ServerName = "Servidor Productivo";
        //public static string CTS_ActiveDB = "ACS";
        //public static string CTS_DB_User = "losa_user_db";
        //public static string CTS_DB_Pass = "AquaF33dHN2014";

        ////Bascula nueva version (desarrollo)
        //public static string Bas_ServerAddress = "AQFSVR010\\AQFSVR010";
        //public static string Bas_ServerName = "Servidor Produccion";
        //public static string Bas_ActiveDB = "BASCULA";
        //public static string Bas_DB_User = "losa_user_db";
        //public static string Bas_DB_Pass = "AquaF33dHN2014";

        ////LOSA
        //public static string LOSA_ServerAddress = "AQFSVR010\\AQFSVR010";
        //public static string LOSA_ServerName = "AQFSVR010\\AQFSVR010";
        //public static string LOSA_ActiveDB = "LOSA"; //BASE PRODUCTIVA
        //public static string LOSA_DB_User = "losa_user_db";
        //public static string LOSA_DB_Pass = " AquaF33dHN2014";

        ////RRHH
        //public static string RRHH_ServerAddress = "AQFSVR010\\AQFSVR010";
        //public static string RRHH_ServerName = "AQFSVR010\\AQFSVR010";
        ////public static string RRHH_ActiveDB = "RRHH_DEV"; //BASE Prueba
        //public static string RRHH_ActiveDB = "RRHH"; //BASE PRODUCTIVA
        //public static string RRHH_DB_User = "losa_user_db";
        //public static string RRHH_DB_Pass = " AquaF33dHN2014";

        ////LOSA Servidor Produccion AQFSVR010
        ////public static string LOSA_ServerAddress = "AQFSVR010";
        ////public static string LOSA_ServerName = "AQFSVR010";
        ////public static string LOSA_ActiveDB = "LOSA"; //BASE PRODUCTIVA
        ////public static string LOSA_DB_User = "sa";
        ////public static string LOSA_DB_Pass = "AquaF33dHN2022";

        //////LOSA Desarrollo
        ////public static string LOSA_ServerName = $"AQFSVR003";
        ////public static string LOSA_ServerAddress = $"AQFSVR003";
        ////public static string LOSA_ActiveDB = "LOSA";
        ////public static string LOSA_DB_User = "sa";
        ////public static string LOSA_DB_Pass = "AquaF33dHN2014";

        ////LOSA local Roger Euceda
        ////public static string LOSA_ServerAddress = @"ADRE5079CP\SQLEXPRESS2014";
        ////public static string LOSA_ServerName = @"ADRE5079CP\SQLEXPRESS2014";
        ////public static string LOSA_ActiveDB = "LOSA";
        ////public static string LOSA_DB_User = "sa";
        ////public static string LOSA_DB_Pass = "ABC123xyz";

        ////SAP
        //public static string SAP_ServerAddress = @"AQFSVR006\AQFSVR006";
        //public static string SAP_ServerName = "Servidor de Desarrollo";
        //public static string SAP_ActiveDB = "AQUA";
        //public static string SAP_DB_User = "sa";
        //public static string SAP_DB_Pass = "Aqua2018";

        ////SAP_ACS
        //public static string SAP_ACS_ServerAddress = @"AQFSVR006\AQFSVR006";
        //public static string SAP_ACS_ServerName = "Servidor de Desarrollo";
        //public static string SAP_ACS_ActiveDB = "ACS";
        //public static string SAP_ACS_DB_User = "sa";
        //public static string SAP_ACS_DB_Pass = "Aqua2018";


        //// APMS(Aquafeed Pocess Management System)
        //public static string APMS_Server = @"AQFSVR008\AQFSVR008";
        //public static string APMS_DB_User = "sa";
        //public static string APMS_DB_Pass = "AquaF33dHN2017";
        //public static string APMS_ActiveDB = "APMS";

        ////AMS
        //public static string AMS_ServerAddress = $"AQFSVR007\\AQFSVR007";
        //public static string AMS_ServerName = $"AQFSVR007\\AQFSVR007";
        //public static string AMS_ActiveDB = "AMS";
        //public static string AMS_DB_User = "sa";
        //public static string AMS_DB_Pass = "AquaF33dHN2014";

        ////public static string APMS_Server = @"AQFSVR007\AQFSVR007";
        ////public static string APMS_DB_User = "sa";
        ////public static string APMS_DB_Pass = "AquaF33dHN2014";
        ////public static string APMS_ActiveDB = "APMS";

        ////ODOO
        //public static string odoo_ServerAddress = "AQFSVR003";
        //public static string odoo_ServerName = "Servidor Productivo";
        //public static string odoo_ActiveDB = "aquafeed";
        //public static string odoo_DB_User = "aquafeed";
        //public static string odoo_DB_Pass = "Aqua3820";

        ////ODOO2
        //public static string odoo2_ServerAddress = "AQFSVR003";
        //public static string odoo2_ServerName = "Servidor Productivo";
        //public static string odoo2_ActiveDB = "AFF";
        //public static string odoo2_DB_User = "aquafeed";
        //public static string odoo2_DB_Pass = "Aqua3820";


        ////ODOO4
        //public static string odoo4_ServerAddress = "10.50.11.137";
        //public static string odoo4_ServerName = "Servidor Odoo Virtual";
        //public static string odoo4_ActiveDB = "aqua_base";
        //public static string odoo4_DB_User = "vegeta";
        //public static string odoo4_DB_Pass = "aquaf33d19";

        ////ODOO5
        //public static string odoo5_ServerAddress = "10.50.11.137";
        //public static string odoo5_ServerName = "Servidor Odoo Virtual";
        //public static string odoo5_ActiveDB = "dbaquafeed_bk";
        //public static string odoo5_DB_User = "vegeta";
        //public static string odoo5_DB_Pass = "aquaf33d19";


        //////Promix -- TEST ---
        //public static string prinin_ServerAddress = "9DR5P32";
        //public static string prinin_ServerName = "Development Server";
        //public static string prinin_ActiveDB = "PRININ";
        //public static string prinin_DB_User = "sa";
        //public static string prinin_DB_Pass = "";

        ////SAP
        //public static string ActiveDBSDK = "AQUA";
        //public static string ServerSDK = @"AQFSVR006\AQFSVR006";
        //public static string ServerlicenseSDK = "aqfsvr006";


        #endregion

        #region Credenciales de Testing PC 6G1SST3 - Ruben

        //////ACS(Costos)
        //public static string CTS_ServerAddress = "6G1SST3";
        //public static string CTS_ServerName = "6G1SST3";
        //public static string CTS_ActiveDB = "ACS";
        //public static string CTS_DB_User = "sa";
        //public static string CTS_DB_Pass = "Marathones00";

        //////LOSA
        //public static string LOSA_ServerAddress = "6G1SST3";
        //public static string LOSA_ServerName = "6G1SST3";
        //public static string LOSA_ActiveDB = "LOSA"; //BASE de Prueba 
        //public static string LOSA_DB_User = "sa";
        //public static string LOSA_DB_Pass = " Marathones00";

        //public static string Bas_ServerAddress = "6G1SST3";
        //public static string Bas_ServerName = "Servidor Desarrollo";
        //public static string Bas_ActiveDB = "BASCULA";
        //public static string Bas_DB_User = "sa";
        //public static string Bas_DB_Pass = "Marathones00";

        //Cafeteria
        public static string cafeteria_ServerAddress = "10.50.11.51";
        public static string cafeteria_ServerName = "Servidor Cafeteria";
        public static string cafeteria_ActiveDB = "CAFETERIA_COPMIXAL";
        public static string cafeteria_DB_User = "aquafeed_admin";
        public static string cafeteria_DB_Pass = "Aq4x_3Fj2#";

        #endregion

        #region Credenciales de Testing PC 7L12TV3 - Danys Oliva
        //ACS(Costos)
        public static string CTS_ServerAddress = "7L12TV3";
        public static string CTS_ServerName = "7L12TV3";
        public static string CTS_ActiveDB = "ACS";
        public static string CTS_DB_User = "sa";
        public static string CTS_DB_Pass = "Aq4x_3Fj2#";

        //Bascula nueva version (desarrollo)
        public static string Bas_ServerAddress = "AQFSVR010\\AQFSVR010";
        public static string Bas_ServerName = "Servidor Desarrollo";
        public static string Bas_ActiveDB = "BASCULA";
        public static string Bas_DB_User = "losa_user_db";
        public static string Bas_DB_Pass = "AquaF33dHN2014";

        //LOSA
        public static string LOSA_ServerAddress = "7L12TV3";
        public static string LOSA_ServerName = "7L12TV3";
        public static string LOSA_ActiveDB = "LOSA"; //BASE de Prueba 
        public static string LOSA_DB_User = "sa";
        public static string LOSA_DB_Pass = " Aq4x_3Fj2#";

        ////RRHH
        //public static string RRHH_ServerAddress = "173.208.156.233";
        //public static string RRHH_ServerName = "173.208.156.233";
        //public static string RRHH_ActiveDB = "RRHH"; //BASE de Prueba 
        //public static string RRHH_DB_User = "usrRRHH";
        //public static string RRHH_DB_Pass = "Aq4x_3Fj2#";

        //RRHH
        public static string RRHH_ServerAddress = "173.208.156.233";
        public static string RRHH_ServerName = "173.208.156.233";
        public static string RRHH_ActiveDB = "RRHH"; //BASE de Prueba 
        public static string RRHH_DB_User = "usrRRHH";
        public static string RRHH_DB_Pass = "Aq4x_3Fj2#";

        // APMS(Aquafeed Pocess Management System)
        public static string APMS_Server = @"AQFSVR008\AQFSVR008";
        public static string APMS_DB_User = "sa";
        public static string APMS_DB_Pass = "AquaF33dHN2017";
        public static string APMS_ActiveDB = "APMS";

        //SAP
        public static string ActiveDBSDK = "AQUA";
        public static string ServerSDK = @"AQFSVR006\AQFSVR006";
        public static string ServerlicenseSDK = "aqfsvr006";

        //SAP_ACS
        public static string SAP_ACS_ServerAddress = @"AQFSVR006\AQFSVR006";
        public static string SAP_ACS_ServerName = "Servidor de Desarrollo";
        public static string SAP_ACS_ActiveDB = "ACS";
        public static string SAP_ACS_DB_User = "sa";
        public static string SAP_ACS_DB_Pass = "Aqua2018";
        
        //SAP
        public static string SAP_ServerAddress = @"AQFSVR006\AQFSVR006";
        public static string SAP_ServerName = "Servidor de Desarrollo";
        public static string SAP_ActiveDB = "AQUA";
        public static string SAP_DB_User = "sa";
        public static string SAP_DB_Pass = "Aqua2018";

        //ODOO
        public static string odoo_ServerAddress = "AQFSVR003";
        public static string odoo_ServerName = "Servidor Productivo";
        public static string odoo_ActiveDB = "aquafeed";
        public static string odoo_DB_User = "aquafeed";
        public static string odoo_DB_Pass = "Aqua3820";

        //ODOO2
        public static string odoo2_ServerAddress = "AQFSVR003";
        public static string odoo2_ServerName = "Servidor Productivo";
        public static string odoo2_ActiveDB = "AFF";
        public static string odoo2_DB_User = "aquafeed";
        public static string odoo2_DB_Pass = "Aqua3820";


        //ODOO4
        public static string odoo4_ServerAddress = "10.50.11.137";
        public static string odoo4_ServerName = "Servidor Odoo Virtual";
        public static string odoo4_ActiveDB = "aqua_base";
        public static string odoo4_DB_User = "vegeta";
        public static string odoo4_DB_Pass = "aquaf33d19";

        //ODOO5
        public static string odoo5_ServerAddress = "10.50.11.137";
        public static string odoo5_ServerName = "Servidor Odoo Virtual";
        public static string odoo5_ActiveDB = "dbaquafeed_bk";
        public static string odoo5_DB_User = "vegeta";
        public static string odoo5_DB_Pass = "aquaf33d19";

        //AMS
        public static string AMS_ServerAddress = $"AQFSVR007\\AQFSVR007";
        public static string AMS_ServerName = $"AQFSVR007\\AQFSVR007";
        public static string AMS_ActiveDB = "AMS";
        public static string AMS_DB_User = "sa";
        public static string AMS_DB_Pass = "AquaF33dHN2014";
        #endregion


        #region Credenciales Pruebas AQFSVR007\\AQFSVR007

        ////WINCC
        //public static string CMS_ServerPellet = "AQFSVR003";
        //public static string CMS_ServerExtruder = "AQFSVR003";
        //public static string CMS_DB_User = "sa";
        //public static string CMS_DB_Pass = "";
        //public static string CMS_ActiveDB = "process_data";

        ////Ttrace
        //public static string ServerAddress = "AQFSVR007\\AQFSVR007";
        //public static string ServerName = "Servidor Productivo";
        //public static string ActiveDB = "ACS";
        //public static string DB_User = "sa";
        //public static string DB_Pass = "AquaF33dHN2014";

        ////ACS(Costos)
        //public static string CTS_ServerAddress = "AQFSVR007\\AQFSVR007";
        //public static string CTS_ServerName = "Servidor Productivo";
        //public static string CTS_ActiveDB = "ACS";
        //public static string CTS_DB_User = "sa";
        //public static string CTS_DB_Pass = "AquaF33dHN2014";

        //////Bascula nueva version (desarrollo)
        //public static string Bas_ServerAddress = "AQFSVR007\\AQFSVR007";
        //public static string Bas_ServerName = "Servidor Desarrollo";
        //public static string Bas_ActiveDB = "BASCULA";
        //public static string Bas_DB_User = "sa";
        //public static string Bas_DB_Pass = "AquaF33dHN2014";

        ////LOSA
        //public static string LOSA_ServerAddress = "AQFSVR007\\AQFSVR007";
        //public static string LOSA_ServerName = "AQFSVR007\\AQFSVR007";
        //public static string LOSA_ActiveDB = "LOSA"; //BASE PRODUCTIVA
        ////public static string LOSA_ActiveDB = "LOSA2"; //BASE DE PRUEBAS
        //public static string LOSA_DB_User = "sa";
        //public static string LOSA_DB_Pass = " AquaF33dHN2014";

        //////LOSA Desarrollo
        ////public static string LOSA_ServerName = $"AQFSVR007\\AQFSVR007";
        ////public static string LOSA_ServerAddress = $"AQFSVR007\\AQFSVR007";
        ////public static string LOSA_ActiveDB = "LOSA";
        ////public static string LOSA_DB_User = "sa";
        ////public static string LOSA_DB_Pass = "AquaF33dHN2014";

        ////LOSA local Roger Euceda
        ////public static string LOSA_ServerAddress = @"ADRE5079CP\SQLEXPRESS2014";
        ////public static string LOSA_ServerName = @"ADRE5079CP\SQLEXPRESS2014";
        ////public static string LOSA_ActiveDB = "LOSA";
        ////public static string LOSA_DB_User = "sa";
        ////public static string LOSA_DB_Pass = "ABC123xyz";

        ////SAP
        //public static string SAP_ServerAddress = @"AQFSVR006\AQFSVR006";
        //public static string SAP_ServerName = "Servidor de Desarrollo";
        //public static string SAP_ActiveDB = "AQUA";
        //public static string SAP_DB_User = "sa";
        //public static string SAP_DB_Pass = "Aqua2018";


        //// APMS(Aquafeed Pocess Management System)
        //public static string APMS_Server = @"AQFSVR008\AQFSVR008";
        //public static string APMS_DB_User = "sa";
        //public static string APMS_DB_Pass = "AquaF33dHN2017";
        //public static string APMS_ActiveDB = "APMS";

        ////public static string APMS_Server = @"AQFSVR007\AQFSVR007";
        ////public static string APMS_DB_User = "sa";
        ////public static string APMS_DB_Pass = "AquaF33dHN2014";
        ////public static string APMS_ActiveDB = "APMS";

        ////ODOO
        //public static string odoo_ServerAddress = "AQFSVR003";
        //public static string odoo_ServerName = "Servidor Productivo";
        //public static string odoo_ActiveDB = "aquafeed";
        //public static string odoo_DB_User = "aquafeed";
        //public static string odoo_DB_Pass = "Aqua3820";

        ////ODOO2
        //public static string odoo2_ServerAddress = "AQFSVR003";
        //public static string odoo2_ServerName = "Servidor Productivo";
        //public static string odoo2_ActiveDB = "AFF";
        //public static string odoo2_DB_User = "aquafeed";
        //public static string odoo2_DB_Pass = "Aqua3820";


        ////ODOO4
        //public static string odoo4_ServerAddress = "AQFSVR003";
        //public static string odoo4_ServerName = "Servidor Productivo";
        //public static string odoo4_ActiveDB = "odoo_sap";
        //public static string odoo4_DB_User = "aquafeed";
        //public static string odoo4_DB_Pass = "Aqua3820";


        //////Promix -- TEST ---
        //public static string prinin_ServerAddress = "9DR5P32";
        //public static string prinin_ServerName = "Development Server";
        //public static string prinin_ActiveDB = "PRININ";
        //public static string prinin_DB_User = "sa";
        //public static string prinin_DB_Pass = "";

        ////SAP
        //public static string ActiveDBSDK = "AQUA_AF";
        //public static string ServerSDK = "10.50.11.31";
        //public static string ServerlicenseSDK = "10.50.11.31";
        #endregion

        internal string ConnectionStringAPMS = @"Server=" + Globals.APMS_Server + @";
                                                       Database=" + Globals.APMS_ActiveDB + @";
                                                       User Id=" + Globals.APMS_DB_User + @";
                                                       Password=" + Globals.APMS_DB_Pass + ";";


        #region Credenciales Desarrollo
        ////WINCC
        //public static string CMS_ServerPellet = @"JFTDF12\SQLEXPRESS";
        //public static string CMS_ServerExtruder = @"JFTDF12\SQLEXPRESS";
        //public static string CMS_DB_User = "sa";
        //public static string CMS_DB_Pass = "AquaFeed2016";
        //public static string CMS_ActiveDB = "process_data";

        ////APMS (Aquafeed Pocess Management System)
        ////public static string APMS_Server        = @"JFTDF12\SQLEXPRESS";
        //public static string APMS_Server = @"localhost";
        //public static string APMS_DB_User = "sa";
        //public static string APMS_DB_Pass = "AquaFeed2016";
        //public static string APMS_ActiveDB = "APMS";

        ////ACS (Aquafeed Costing System)
        ////ACS (Costos)
        //public static string CTS_ServerAddress = @"F3DYSQ2\MSSQLSERVER2";
        //public static string CTS_ServerName = @"F3DYSQ2\MSSQLSERVER2";
        //public static string CTS_ActiveDB = "ACS";
        //public static string CTS_DB_User = "sa";
        //public static string CTS_DB_Pass = "Aqua2018";

        ////Odoo
        //public static string odoo_ServerAddress = "AQFSVR003";
        //public static string odoo_ServerName = "Servidor Productivo";
        //public static string odoo_ActiveDB = "RRHH";
        //public static string odoo_DB_User = "aquafeed";
        //public static string odoo_DB_Pass = "Aqua3820";


        ////ODOO2
        //public static string odoo2_ServerAddress = "AQFSVR003";
        //public static string odoo2_ServerName = "Servidor Productivo";
        //public static string odoo2_ActiveDB = "AFF";
        //public static string odoo2_DB_User = "aquafeed";
        //public static string odoo2_DB_Pass = "Aqua3820";

        //////ODOO4
        //public static string odoo4_ServerAddress = "AQFSVR003";
        //public static string odoo4_ServerName = "Servidor Productivo";
        //public static string odoo4_ActiveDB = "odoo_sap";
        //public static string odoo4_DB_User = "aquafeed";
        //public static string odoo4_DB_Pass = "Aqua3820";


        ////Promix
        //public static string prinin_ServerAddress = "9DR5P32";
        //public static string prinin_ServerName = "Development Server";
        //public static string prinin_ActiveDB = "PRININ";
        //public static string prinin_DB_User = "sa";
        //public static string prinin_DB_Pass = "";

        ////SAP
        //public static string SAP_ServerAddress = @"AQFSVR006";
        //public static string SAP_ServerName = "Servidor de Desarrollo";
        //public static string SAP_ActiveDB = "AQUA";
        //public static string SAP_DB_User = "sa";
        //public static string SAP_DB_Pass = "Aqua2018";


        #endregion

        #region Credenciales Desarrollo
        ////WINCC
        //public static string CMS_ServerPellet = @"JFTDF12\SQLEXPRESS";
        //public static string CMS_ServerExtruder = @"JFTDF12\SQLEXPRESS";
        //public static string CMS_DB_User = "sa";
        //public static string CMS_DB_Pass = "AquaFeed2016";
        //public static string CMS_ActiveDB = "process_data";

        //APMS (Aquafeed Pocess Management System)
        //public static string APMS_Server        = @"JFTDF12\SQLEXPRESS";
        //public static string APMS_Server = @"localhost";
        //public static string APMS_DB_User = "sa";
        //public static string APMS_DB_Pass = "AquaFeed2016";
        //public static string APMS_ActiveDB = "APMS";

        //ACS (Aquafeed Costing System)
        //ACS (Costos)
        //public static string CTS_ServerAddress = "6XJ7QD2-PC";
        //public static string CTS_ServerName = "6XJ7QD2-PC";
        //public static string CTS_ActiveDB = "ACS";
        //public static string CTS_DB_User = "sa";
        //public static string CTS_DB_Pass = "Marathon00";

        //Odoo2
        //public static string odoo2_ServerAddress = "AQFSVR003";
        //public static string odoo2_ServerName = "Servidor Productivo";
        //public static string odoo2_ActiveDB = "RRHH";
        //public static string odoo2_DB_User = "aquafeed";
        //public static string odoo2_DB_Pass = "Aqua3820";


        //ODOO2
        //public static string odoo2_ServerAddress = "AQFSVR003";
        //public static string odoo2_ServerName = "Servidor Productivo";
        //public static string odoo2_ActiveDB = "AFF";
        //public static string odoo2_DB_User = "aquafeed";
        //public static string odoo2_DB_Pass = "Aqua3820";

        ////ODOO4
        //public static string odoo4_ServerAddress = "AQFSVR003";
        //public static string odoo4_ServerName = "Servidor Productivo";
        //public static string odoo4_ActiveDB = "odoo_sap";
        //public static string odoo4_DB_User = "aquafeed";
        //public static string odoo4_DB_Pass = "Aqua3820";


        //Promix
        //public static string prinin_ServerAddress = "9DR5P32";
        //public static string prinin_ServerName = "Development Server";
        //public static string prinin_ActiveDB = "PRININ";
        //public static string prinin_DB_User = "sa";
        //public static string prinin_DB_Pass = "Promix1620";
        //public static string prinin_DB_Pass = "Promix1620";
        #endregion

        #region Credenciales Desarrollo (HAMACHI)
        ////WINCC
        //public static string CMS_ServerPellet = "25.15.38.196";
        //public static string CMS_ServerExtruder = "25.15.38.196";

        //public static string CMS_DB_User = "sa";
        //public static string CMS_DB_Pass = "AquaFeed2016";
        //public static string CMS_ActiveDB = "process_data";

        ////ACS (Costos)
        //public static string CTS_ServerAddress = "25.15.38.196";
        //public static string CTS_ServerName = "Servidor de Desarrollo";
        //public static string CTS_ActiveDB = "ACS";

        //public static string CTS_DB_User = "sa";
        //public static string CTS_DB_Pass = "AquaFeed2016";

        ////ODOO
        //public static string odoo_ServerAddress = "25.15.38.196";
        //public static string odoo_ServerName = "Servidor de Desarrollo";
        //public static string odoo_ActiveDB = "pruebas";

        //public static string odoo_DB_User = "aquafeed"; //"aquafeed";
        //public static string odoo_DB_Pass = "Aqua3820";
        #endregion
    }
}