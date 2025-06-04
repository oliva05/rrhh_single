﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACS.Classes;
using System.Net;
using System.Net.Mail;
using System.Data;
//using Microsoft.Exchange.WebServices.Data;

namespace LOSA.Clases
{
    class SecOps
    {
        public DataSet ValidateUser(string user, string password)
        {
            DataSet toreturn = new DataSet();
            DataOperations dp = new DataOperations();

//            toreturn = dp.ACS_GetSelectData(@"  SELECT TOP 1 [id]
//			                                            ,[nombre]
//			                                            ,[tipo]
//			                                            ,[defaultheme]
//                                              FROM [dbo].[conf_usuarios]
//                                             WHERE [usuario] = '" + user + @"'
//                                               AND [encpass] = HASHBYTES('SHA1', '" + password + @"');");

            toreturn = dp.ACS_GetSelectData(@"  SELECT TOP 1 [id]
			                                            ,[nombre]
			                                            ,[tipo]
			                                            ,[defaultheme]
                                                        ,[ADUser]
                                              FROM [dbo].[conf_usuarios]
                                             WHERE [ADUser] = '" + user + @"';");

            if (toreturn.Tables[0].Rows.Count > 0)
            {
                return toreturn;
            }
            else
            {
                return null;
            }
        }

        public void SendEmailAlert_GD(DataTable Receivers, int ColumnNumber, string Subject, string Body, bool isHTML, MailPriority priority)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("apps@aquafeedhn.net", "Aquafeed Apps");

                foreach (DataRow row in Receivers.Rows)
                {
                    message.To.Add(new MailAddress(row[ColumnNumber].ToString()));
                }

                message.Subject = Subject;
                message.Body = Body;
                message.IsBodyHtml = isHTML;
                message.Priority = priority;

                smtp.EnableSsl = false;
                smtp.Port = 80;
                smtp.Host = "smtpout.secureserver.net";
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential("apps@aquafeedhn.net", "$Applications1620&$");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(message);
                smtp.Dispose();
            }
            catch (Exception ex) 
            {
                try
                {
                    if (ex.HResult == -2146233088)
                    {
                        MailMessage message = new MailMessage();
                        SmtpClient smtp = new SmtpClient();

                        message.From = new MailAddress("apps2@aquafeedhn.net", "Aquafeed Apps");

                        foreach (DataRow row in Receivers.Rows)
                        {
                            message.To.Add(new MailAddress(row[ColumnNumber].ToString()));
                        }

                        message.Subject = Subject;
                        message.Body = Body;
                        message.IsBodyHtml = isHTML;
                        message.Priority = priority;

                        smtp.EnableSsl = false;
                        smtp.Port = 80;
                        smtp.Host = "smtpout.secureserver.net";
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = new NetworkCredential("apps2@aquafeedhn.net", "A1dd1cf460&");
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                        smtp.Send(message);
                        smtp.Dispose();
                    }
                }
                catch (Exception ex2) 
                {
                    if (ex2.HResult == -2146233088)
                    {
                        MailMessage message = new MailMessage();
                        SmtpClient smtp = new SmtpClient();

                        message.From = new MailAddress("apps3@aquafeedhn.net", "Aquafeed Apps");

                        foreach (DataRow row in Receivers.Rows)
                        {
                            message.To.Add(new MailAddress(row[ColumnNumber].ToString()));
                        }

                        message.Subject = Subject;
                        message.Body = Body;
                        message.IsBodyHtml = isHTML;
                        message.Priority = priority;

                        smtp.EnableSsl = false;
                        smtp.Port = 80;
                        smtp.Host = "smtpout.secureserver.net";
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = new NetworkCredential("apps3@aquafeedhn.net", "A1dd1cf460&");
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                        smtp.Send(message);
                        smtp.Dispose();
                    }
                }
            }
        }

        public void SendEmailAlert_SingleContact_GD(string Receiver, int ColumnNumber, string Subject, string Body, bool isHTML)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("apps@aquafeedhn.net", "Aquafeed Apps");

            message.To.Add(new MailAddress(Receiver));

            message.Subject = Subject;
            message.Body = Body;
            message.IsBodyHtml = isHTML;

            smtp.EnableSsl = false;
            smtp.Port = 80;
            smtp.Host = "smtpout.secureserver.net";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential("apps@aquafeedhn.net", "$Applications1620&$");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Send(message);
        }

        //public void SendEmail_EX(/*DataSet Receivers, int ColumnNumber, string Subject, string Body, bool isHTML*/)
        //{
        //    ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2007_SP1);

        //    service.Credentials = new WebCredentials("david.riega@aquafeedhn.com", "3vilM0nk3y07&");

        //    service.TraceEnabled = true;
        //    service.TraceFlags = TraceFlags.All;

        //    service.AutodiscoverUrl("david.riega@aquafeedhn.com", RedirectionUrlValidationCallback);

        //    EmailMessage email = new EmailMessage(service);

        //    email.ToRecipients.Add("test@aquafeedhn.com");

        //    email.Subject = "HelloWorld";
        //    email.Body = new MessageBody("This is the first email I've sent by using the EWS Managed API");

        //    email.Send();
        //}

        private static bool RedirectionUrlValidationCallback(string redirectionURL) 
        {
            // The default for the validation callback is to reject the URL.
            bool result = false;

            Uri redirectionUri = new Uri(redirectionURL);

            // Validate the contents of the redirection URL. In this simple validation
            // callback, the redirection URL is considered valid if it is using HTTPS
            // to encrypt the authentication credentials. 
            if (redirectionUri.Scheme == "https")
            {
                result = true;
            }
            return result;
        }

        public string GetTableHTML(DataSet Information)
        {
            try
            {
                string messageBody = "<font>El Siguiente es un correo de prueba, por favor hacer caso omiso. </font><br><br>";

                if (Information.Tables[0].Rows.Count == 0)
                    return messageBody;
                string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\" >";
                string htmlTableEnd = "</table>";
                string htmlHeaderRowStart = "<tr style =\"background-color:#6FA1D2; color:#ffffff;\">";
                string htmlHeaderRowEnd = "</tr>";
                string htmlTrStart = "<tr style =\"color:#555555;\">";
                string htmlTrEnd = "</tr>";
                string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
                string htmlTdEnd = "</td>";

                messageBody += htmlTableStart;
                messageBody += htmlHeaderRowStart;

                foreach (DataColumn column in Information.Tables[0].Columns)
                {
                    messageBody += htmlTdStart + column.ColumnName + " " + htmlTdEnd;
                }

                messageBody += htmlHeaderRowEnd;

                foreach (DataRow Row in Information.Tables[0].Rows)
                {
                    messageBody = messageBody + htmlTrStart;

                    foreach (DataColumn column in Information.Tables[0].Columns)
                    {
                        messageBody += htmlTdStart + Row[column.ColumnName] + " " + htmlTdEnd;
                    }

                    messageBody = messageBody + htmlTrEnd;
                }

                messageBody = messageBody + htmlTableEnd;


                return messageBody;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return null;
            }
        }

        public string ParseTicketHTMLFormatBody(string Nombre, string body, string ticket, string estado, string usuario_asignado, string prioridad, string comentarios, string titulo)
        {
            return@"<head>
                    <style>
                    .myDiv {
                            border: 5px  #0074ba;
                            background-color: #0074ba;
                            text-align: center;
                           }

                    </style>
                    </head>
                    <body>

                    <div class=""myDiv""> 
  	                     <h2 style = ""color:white;""> " + titulo + @"</h2>
                         <p style = ""color:white;"" > Se ha creado el ticket # " + ticket + @"</p>
                    </div>
    
            <h3> <b>Titulo:</b> " + titulo + @"</h3>
                <p>Hola " + Nombre + @",</p>
            <p> Se ha creado el ticket [#" + ticket + @"].</p>
            
            <p><b>Descripcion Requerimiento:</b> " + body + @"</p>
            <ul>
                <li> <b>Usuario Asignado:</b> " + usuario_asignado + @"</li>
                <li> <b>Estado: </b>" + estado + @"</li>
                <li> <b>Prioridad:</b> " + prioridad + @" </li>
            </ul>
           <p>Estaremos dando seguimiento y atención a su solicitud. Vaya a la sección de <b>tickets</b> en la App de ALOSY para revisar el estado de su ticket. </p>
            <div class=""myDiv""> 
                 <p style = ""color:white;"" > IT DEPARTMENT 2024. </p>
                 <p style = ""color:white;"" > AQUAFEED S.A.DE C.V. </p>
             </div>

         </body>";
           
        }

        public string ParseTicketHTMLFormatBodyStatus(string Nombre, string body, string ticket, string estado, string usuario_asignado, string prioridad, string comentarios, string titulo)
        {
            return @"<head>
                    <style>
                    .myDiv {
                            border: 5px  #0074ba;
                            background-color: #0074ba;
                            text-align: center;
                           }

                    </style>
                    </head>
                    <body>

                    <div class=""myDiv""> 
  	                     <h2 style = ""color:white;""> " + titulo + @"</h2>
                         <p style = ""color:white;"" > El ticket # " + ticket + @" ha cambiado de estado</p>
                    </div>
    
                <p>Hola " + Nombre + @",</p>
            <p> El ticket [#" + ticket + @"] ha cambiado de estado a: " + estado + @".</p>
            <p> <b>Titulo:</b> " + titulo + @"</p>
            
            <p><b>Descripcion Requerimiento:</b> " + body + @"</p>
            <ul>
                <li> <b>Usuario Asignado:</b> " + usuario_asignado + @"</li>
                <li> <b>Prioridad:</b> " + prioridad + @" </li>
            </ul>
           <p>Estaremos dando seguimiento y atención a su solicitud. Vaya a la sección de <b>tickets</b> en la App de ALOSY para revisar el estado de su ticket. </p>
            <div class=""myDiv""> 
                 <p style = ""color:white;"" > IT DEPARTMENT 2025. </p>
                 <p style = ""color:white;"" > AQUAFEED S.A.DE C.V. </p>
             </div>

         </body>";
        }

        public string ParseTicketHTMLFormatBodyPriority(string Nombre, string body, string ticket, string estado, string usuario_asignado, string prioridad, string comentarios, string titulo)
        {
            return @"<head>
                    <style>
                    .myDiv {
                            border: 5px  #0074ba;
                            background-color: #0074ba;
                            text-align: center;
                           }

                    </style>
                    </head>
                    <body>

                    <div class=""myDiv""> 
  	                     <h2 style = ""color:white;""> " + titulo + @"</h2>
                         <p style = ""color:white;"" > El ticket # " + ticket + @" ha cambiado de Prioridad</p>
                    </div>
    
                <p>Hola " + Nombre + @",</p>
            <h2> <b>Titulo:</b> " + titulo + @"</h2>
            <p> El ticket [#" + ticket + @"] ha cambiado de prioridad a: " + prioridad + @".</p>
            
            <p><b>Descripcion Requerimiento:</b> " + body + @"</p>
            <ul>
                <li> <b>Usuario Asignado:</b> " + usuario_asignado + @"</li>
                
                <li> <b>Estado:</b> " + estado + @" </li>
            </ul>
           <p>Estaremos dando seguimiento y atención a su solicitud. Vaya a la sección de <b>tickets</b> en la App de ALOSY para revisar el estado de su ticket. </p>
            <div class=""myDiv""> 
                 <p style = ""color:white;"" > IT DEPARTMENT 2025. </p>
                 <p style = ""color:white;"" > AQUAFEED S.A.DE C.V. </p>
             </div>

         </body>";
        }

        public string ParseTicketHTMLFormatBodyUserAssgined(string Nombre, string body, string ticket, string estado, string usuario_asignado, string prioridad, string comentarios,string titulo)
        {

            return @"<head>
                    <style>
                    .myDiv {
                            border: 5px  #0074ba;
                            background-color: #0074ba;
                            text-align: center;
                           }

                    </style>
                    </head>
                    <body>

                    <div class=""myDiv""> 
  	                     <h2 style = ""color:white;""> " + titulo + @"</h2>
                         <p style = ""color:white;"" > El ticket # " + ticket + @" ha cambiado de usuario asignado</p>
                    </div>
    
                <p>Hola " + Nombre + @",</p>
            <h2> El ticket [#" + ticket + @"] ha cambiado de usuario asignado a: " + usuario_asignado + @".</h2>
            <p> <b>Titulo:</b> " + titulo + @"</p>
            
            <p><b>Descripcion Requerimiento:</b> " + body + @"</p>
            <ul>
                <li> <b>Prioridad:</b> " + prioridad + @"</li>
                
                <li> <b>Estado:</b> " + estado + @" </li>
            </ul>
           <p>Estaremos dando seguimiento y atención a su solicitud. Vaya a la sección de <b>tickets</b> en la App de ALOSY para revisar el estado de su ticket. </p>
            <div class=""myDiv""> 
                 <p style = ""color:white;"" > IT DEPARTMENT 2025. </p>
                 <p style = ""color:white;"" > AQUAFEED S.A.DE C.V. </p>
             </div>

         </body>";
        }

        public void SendEmailTicketCreated(EmailTicketParams emailTicketParmas)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("its@aquafeedhn.net", "Aquafeed Apps");

            message.To.Add(new MailAddress(emailTicketParmas.Destinatario));
            

            foreach (var item in emailTicketParmas.CorreosCC)
            {
                message.CC.Add(new MailAddress(item));
            }

            message.Subject = emailTicketParmas.Subject;

            if (emailTicketParmas.IsHTML == true)
            {
                message.Body = ParseTicketHTMLFormatBody(emailTicketParmas.Nombre
                                                        , emailTicketParmas.Body
                                                        , emailTicketParmas.TicketID.ToString()
                                                        , emailTicketParmas.Estado
                                                        , emailTicketParmas.UsuarioAsignado
                                                        , emailTicketParmas.PrioridadTicket
                                                        ,emailTicketParmas.Body
                                                        ,emailTicketParmas.TituloTicket);
            }
            else
            {
                message.Body = emailTicketParmas.Body;
            }
            message.IsBodyHtml = emailTicketParmas.IsHTML;

            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Host = "outlook.office365.com";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential("its@aquafeedhn.net", "$Applications1620&$");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                smtp.Send(message);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void SendEmailTicketChangeStatus(EmailTicketParams emailTicketParmas)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("its@aquafeedhn.net", "Aquafeed Apps");


             message.To.Add(new MailAddress(emailTicketParmas.Destinatario));
            

            foreach (var email in emailTicketParmas.CorreosCC)
            {
                message.CC.Add(new MailAddress(email));
            }

            message.Subject = emailTicketParmas.Subject;

            if (emailTicketParmas.IsHTML == true)
            {
                message.Body = ParseTicketHTMLFormatBodyStatus(emailTicketParmas.Nombre
                                                                , emailTicketParmas.Body
                                                                , emailTicketParmas.TicketID.ToString()
                                                                , emailTicketParmas.Estado
                                                                , emailTicketParmas.UsuarioAsignado
                                                                , emailTicketParmas.PrioridadTicket
                                                                 , emailTicketParmas.Body
                                                        , emailTicketParmas.TituloTicket);
            }
            else
            {
                message.Body = emailTicketParmas.Body;
            }
            message.IsBodyHtml = emailTicketParmas.IsHTML;

            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Host = "outlook.office365.com";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential("its@aquafeedhn.net", "$Applications1620&$");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                smtp.Send(message);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void SendEmailTicketChangePrioridad(EmailTicketParams emailTicketParmas)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("its@aquafeedhn.net", "Aquafeed Apps");

            
                message.To.Add(new MailAddress(emailTicketParmas.Destinatario));
            

            foreach (var email in emailTicketParmas.CorreosCC)
            {
                message.CC.Add(new MailAddress(email));
            }

            message.Subject = emailTicketParmas.Subject;

            if (emailTicketParmas.IsHTML == true)
            {
                message.Body = ParseTicketHTMLFormatBodyPriority(emailTicketParmas.Nombre
                                                                , emailTicketParmas.Body
                                                                , emailTicketParmas.TicketID.ToString()
                                                                , emailTicketParmas.Estado
                                                                , emailTicketParmas.UsuarioAsignado
                                                                , emailTicketParmas.PrioridadTicket
                                                                , emailTicketParmas.Body
                                                        , emailTicketParmas.TituloTicket);
            }
            else
            {
                message.Body = emailTicketParmas.Body;
            }
            message.IsBodyHtml = emailTicketParmas.IsHTML;

            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Host = "outlook.office365.com";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential("its@aquafeedhn.net", "$Applications1620&$");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                smtp.Send(message);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void SendEmailTicketChangeUserAssigned(EmailTicketParams emailTicketParmas)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("its@aquafeedhn.net", "Aquafeed Apps");

            message.To.Add(new MailAddress(emailTicketParmas.Destinatario));
            

            foreach (var email in emailTicketParmas.CorreosCC)
            {
                message.CC.Add(new MailAddress(email));
            }

            message.Subject = emailTicketParmas.Subject;

            if (emailTicketParmas.IsHTML == true)
            {
                message.Body = ParseTicketHTMLFormatBodyUserAssgined(emailTicketParmas.Nombre
                                                                    , emailTicketParmas.Body
                                                                    , emailTicketParmas.TicketID.ToString()
                                                                    , emailTicketParmas.Estado, emailTicketParmas.UsuarioAsignado
                                                                    , emailTicketParmas.PrioridadTicket
                                                                     , emailTicketParmas.Body
                                                        , emailTicketParmas.TituloTicket);
            }
            else
            {
                message.Body = emailTicketParmas.Body;
            }
            message.IsBodyHtml = emailTicketParmas.IsHTML;

            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Host = "outlook.office365.com";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential("its@aquafeedhn.net", "$Applications1620&$");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                smtp.Send(message);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        public void SendEmailSolicitudITCreated(Email_IT_RequestParams email_IT_RequestParams)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("its@aquafeedhn.net", "Aquafeed Apps");

            message.To.Add(new MailAddress(email_IT_RequestParams.MailUsuarioSolicita));


            message.CC.Add(new MailAddress("ruben.garcia@aquafeedhn.com"));
            message.CC.Add(new MailAddress("danys.oliva@aquafeedhn.com"));
            message.CC.Add(new MailAddress("oscar.bonilla@aquafeedhn.com"));
            //message.CC.Add(new MailAddress("reuceda05@hotmail.com"));


            message.Subject = email_IT_RequestParams.Subject;

            if (email_IT_RequestParams.IsHTML == true)
            {
                message.Body = ParseSolicitudHTMLFormatBody(email_IT_RequestParams);
            }
            else
            {
                message.Body = email_IT_RequestParams.Body;
            }
            message.IsBodyHtml = email_IT_RequestParams.IsHTML;

            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Host = "outlook.office365.com";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential("its@aquafeedhn.net", "$Applications1620&$");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                smtp.Send(message);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public string ParseSolicitudHTMLFormatBody(Email_IT_RequestParams emailParams)
        {

            string accesosFormatHTML = "" ;


            foreach (var item in emailParams.Accesos)
            {
                string val = "<li>"+item+"</li>";
                accesosFormatHTML = accesosFormatHTML+val;
            }

            return @"<p>Hola " + emailParams.NombreUsuarioSolicita + @",</p>
            <p> La solicitud [#" + emailParams.TicketID.ToString() + @"] se ha creado, estaremos dando seguimiento y atención a su solicitud.</p>
            <ul>
                <li> <b>Acceso para el usuario:</b> " + emailParams.NombreUsuarioAcceso + @"</li>
                <li> <b>Departamento:</b> " + emailParams.Departamento + @"</li>
                <li> <b>Razon:</b> " + emailParams.Razon + @" </li>
                <li> <b>Estado de la solicitud: </b>" + emailParams.Estado + @"</li>
                <li> <b>Asignado a: </b>" + emailParams.Asignado_A + @"</li>
                <li> <b>Accesos </b><ul>"+ accesosFormatHTML+ @"</ul>
				</li>
            </ul>";
        }

        public void SendEmailTicketFollowUP(EmailTicketParams emailTicketParams)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("its@aquafeedhn.net", "Aquafeed Apps");
            message.To.Add(new MailAddress(emailTicketParams.Destinatario));

            foreach (var item in emailTicketParams.CorreosCC)
            {
                if (string.IsNullOrEmpty(item))
                {

                }
                else
                    message.CC.Add(new MailAddress(item));

            }

            message.Subject = emailTicketParams.Subject;

            if (emailTicketParams.IsHTML == true)
            {
                message.Body = ParseTicketHTMLFormatBodyFollowUp(emailTicketParams.Nombre
                                                                , emailTicketParams.Body
                                                                , emailTicketParams.TicketID.ToString()
                                                                , emailTicketParams.Estado
                                                                , emailTicketParams.UsuarioAsignado
                                                                , emailTicketParams.UsuarioSeguimiento
                                                                , emailTicketParams.PrioridadTicket
                                                                , emailTicketParams.Subject
                                                                , emailTicketParams.RequerInicial);

            }
            else
            {
                message.Body = emailTicketParams.Body;
            }
            message.IsBodyHtml = emailTicketParams.IsHTML;

            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Host = "outlook.office365.com";
            smtp.Credentials = new NetworkCredential("its@aquafeedhn.net", "$Applications1620&$");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public string ParseTicketHTMLFormatBodyFollowUp(string Nombre, string body, string ticket, string estado, string usuario_asignado,string usuario_seguimiento, string prioridad, string titulo, string reque_descripcion)
        {
            return @"<head>
                    <style>
                    .myDiv {
                            border: 5px  #0074ba;
                            background-color: #0074ba;
                            text-align: center;
                           }

                    </style>
                    </head>
                    <body>

                    <div class=""myDiv""> 
  	                     <h2 style = ""color:white;""> " + titulo + @"</h2>
                         <p style = ""color:white;"" > Este es un seguimiento del ticket # " + ticket + @"</p>
                    </div>
    
                <p>Hola " + Nombre + @",</p>
            <p> Se le ha dado seguimiento al ticket [#" + ticket + @"].</p>
            <p> <b>Seguimiento por " + usuario_seguimiento + ": </b>" + body + @" </p>
            <p> Vaya a la sección de <b>tickets</b> en la App de ALOSY para revisar el estado de su ticket. </p>
            <p><b>Descripcion Requerimiento:</b> " + reque_descripcion + @"</p>
            <ul>
                <li> <b>Usuario Asignado:</b> " + usuario_asignado + @"</li>
                <li> <b>Estado: </b>" + estado + @"</li>
                <li> <b>Prioridad:</b> " + prioridad + @" </li>
            </ul>
            <p> El Ticket sigue en proceso de realización. Se le informara al momento de su conclusión.</p>
            <div class=""myDiv""> 
                 <p style = ""color:white;"" > IT DEPARTMENT 2025. </p>
                 <p style = ""color:white;"" > AQUAFEED S.A.DE C.V. </p>
             </div>

         </body>";


        }
    }
}
