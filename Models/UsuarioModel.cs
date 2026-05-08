using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SGA_Client.Models
{

    public class UsuarioModel
    {
        public int id { get; set; }

        public string tipoUsuario { get; set; }

        public string token { get; set; }
    }
    public static class SesionGlobal
    {
        
        public static readonly HttpClient WebCliente = new HttpClient();

        public static UsuarioModel UsuarioActual { get; private set; }
       
        public static void Iniciar(UsuarioModel usuarioActual)
        {
            UsuarioActual = usuarioActual;
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

}
