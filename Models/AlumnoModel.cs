using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SGA_Client.Models
{
    public class AlumnoModel
    {
        public string nombre { get; set; }
        public string idCURP { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string tutor { get; set; }
        
        public string primerApellidoTutor { get; set; }
        public string segundoApellidoTutor { get; set; }

        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }

        public string parentescoTutor { get; set; }
        public string direccion { get; set; }
        public string telefonoTutor { get; set; }
        public string gradoGrupo { get; set; }
    }

    public class AlumnoGridModel
    {
        public string idCURP { get; set; }
        public string Nombre { get; set; }
        public string gradoGrupo { get; set; } 
        public string TelefonoTutor { get; set; }
        public string Tutor { get; set; }
    }
    public class AlumnosFiltrosModel {
        public string gradoGrupo { get; set; }
        public string nombreCURP { get; set; }
    }
}
