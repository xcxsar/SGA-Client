using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SGA_Client.Models
{

    public class UsuarioModel
    {
        public int id { get; set; }

        public string tipoUsuario { get; set; }

        public string contrasena { get; set; }
        public string correo { get; set; }

        public string nombre { get; set; }

        public string token { get; set; }
    }
    public class UsuarioCreationModel
    {
        
        public string tipoUsuario { get; set; }

        public string contrasena { get; set; }
        public string correo { get; set; }

        public string nombre { get; set; }
    }
    public static class SesionGlobal
    {
        
        public static readonly HttpClient WebCliente = new HttpClient();

        public static UsuarioModel UsuarioActual { get; private set; }
       
        public static void Iniciar(UsuarioModel usuarioActual)
        {
            UsuarioActual = usuarioActual;

            WebCliente.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", usuarioActual.token);
        }

        public static void Cerrar()
        {
            UsuarioActual = null;
            WebCliente.DefaultRequestHeaders.Authorization = null;
        }
    }
    public class UsuarioLoginModel
    {
        public string correo { get; set; }
        public string contrasena { get; set; }
    }

    public class UsersGridDto
    {
        public string nombre { get; set; }

        public string correo { get; set; }
        public string tipoUsuario { get; set; }
        public int usuarioId { get; set; }
    }

    public class UsersFiltrosModel
    {
        public string nombre { get; set; }
        public string tipoUsuario { get; set; }
    }

    public class UsuarioCambioContrasenaModel
    {
        public string correo { get; set; }
        public string contrasena { get; set; }
        public string codigoVerificacion { get; set; }
    }


}
