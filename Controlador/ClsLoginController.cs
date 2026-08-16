using Pry_Sistema_Punto_de_Venta.Modelo;
using Pry_Sistema_Punto_de_Venta.Vista;
using System.Net.Mail;
using System.Net;

namespace Pry_Sistema_Punto_de_Venta.Controlador
{
    internal class ClsLoginController
    {
        private ClsLoginModelo ModeloLogin = new ClsLoginModelo();

        public string ROl { get; set; }
        public int usuario_id { get; set; }
        public ClsLoginController()
        {
            ROl = ModeloLogin.Rol;
            usuario_id = ModeloLogin.UsuarioActual;
        }

        public void validarcampos(string Nickname, string Password, FrmLogin vista)
        {

            try
            {
                bool esValido = ModeloLogin.validarusuario(Nickname.Trim(), Password.Trim());

                if (esValido)
                {
                    // AQUÍ ESTÁ EL CAMBIO: Asignamos el valor directamente del modelo
                    this.ROl = ModeloLogin.Rol;
                    this.usuario_id = ModeloLogin.UsuarioActual;
                    vista.notificarUsuario("Bienvenido, " + Nickname, false);
                }
                else
                {
                    vista.notificarUsuario("Usuario o contraseña incorrectos", true);
                }
            }
            catch (Exception ex)
            {
                vista.notificarUsuario("Error: " + ex.Message, true);
            }
        }

        public bool Validaradmin(string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new Exception("La contraseña no puede estar vacía.");
                }

                return ModeloLogin.Validarpassword(password);

            }
            catch (Exception e)
            {
                throw new Exception("" + e.Message);
            }
        }

        // Agrega esto dentro de ClsLoginController.cs
        public string SolicitarCodigo(string correo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(correo)) return "Por favor, ingresa un correo.";

                if (!ModeloLogin.ExisteCorreo(correo)) return "El correo no está registrado en el sistema.";

                // Generar código de 6 dígitos (Sin usar StringBuilder)
                Random rnd = new Random();
                string codigo = rnd.Next(100000, 999999).ToString();
                DateTime expiracion = DateTime.Now.AddMinutes(15);

                // Guardar en BD
                ModeloLogin.GuardarTokenRecuperacion(correo, codigo, expiracion);

                // Enviar Correo (Configura tus credenciales reales aquí)
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("notificaciones.puntodeventafcm@gmail.com");
                mail.To.Add(correo);
                mail.Subject = "Código de Recuperación de Cuenta";
                mail.Body = "Tu código de recuperación es: " + codigo + "\nEste código expira en 15 minutos. Si no solicitaste esto, ignora este mensaje.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("notificaciones.puntodeventafcm@gmail.com", "gekq aons sczg sobc");
                smtp.EnableSsl = true;
                smtp.Send(mail);

                return "OK"; // Indica éxito
            }
            catch (Exception ex)
            {
                return "Error al enviar el correo: " + ex.Message;
            }
        }

        public string CambiarPassword(string correo, string codigo, string nuevaPass, string confPass)
        {
            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nuevaPass))
                return "Todos los campos son obligatorios.";

            if (nuevaPass != confPass)
                return "Las contraseñas no coinciden.";

            if (nuevaPass.Length < 6)
                return "La contraseña debe tener al menos 6 caracteres.";

            try
            {
                bool exito = ModeloLogin.ValidarYActualizarPassword(correo, codigo, nuevaPass);

                if (exito)
                    return "OK";
                else
                    return "El código es incorrecto o ha expirado.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar: " + ex.Message;
            }
        }
    }
}
