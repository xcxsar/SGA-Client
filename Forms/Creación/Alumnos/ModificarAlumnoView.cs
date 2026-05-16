using Newtonsoft.Json;
using SGA_Client.Forms.Creación;
using SGA_Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SGA_Client.Forms.Creación
{
    public partial class ModificarAlumnoView : Form
    {
        internal string url = "https://localhost:44342/api/alumnos";

        public AlumnoModel AlumnoSeleccionado { get; set; }
        public ModificarAlumnoView()
        {
             
            InitializeComponent();
            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);

            if (this.cbGrupo != null )
            {
                this.cbGrupo.FlatStyle = FlatStyle.System;

            }
            this.UpdateStyles();

            UIHelper.AplicarFuenteInterAControles(this, 12);
            TitleAlumno.Font = ManejadorDeFuentes.GetFont("Bevan", 16);
            TitleTutor.Font = ManejadorDeFuentes.GetFont("Bevan", 16);
           
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            UIHelper.DibujarCuadriculaFondo(this, e);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarTodoElFormulario()) return;

            var alumno = new
            {
                idCURP = AlumnoSeleccionado.idCURP,
                nombre = tbNombreAlumno.Text,
                fechaNacimiento = dtpFechaNacimiento.Value,
                tutor = tbNombreTutor.Text,
                nuevaIdCURP = tbCURP.Text.ToUpper(),
                direccion = tbDireccion.Text,
                telefonoTutor = tbTelefonoTutor.Text,
                parentescoTutor = tbParentescoTutor.Text,
                gradoGrupo = $"{cbGrupo.Text}",
                primerApellido = tbPrimerApellidoAlumno.Text,
                segundoApellido = tbSegundoApellidoAlumno.Text,
                primerApellidoTutor = tbPrimerApellidoTutor.Text,
                segundoApellidoTutor = tbSegundoApellidoTutor.Text
               
            };

            MessageBox.Show($"{alumno}", "Debug ");
            try
            {
                btnGuardar.Enabled = false;

                string json = JsonConvert.SerializeObject(alumno);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await SesionGlobal.WebCliente.PostAsync(url+$"Modificar", content);

                if (response.IsSuccessStatusCode)
                {
                    DialogResult resultado = MessageBox.Show(
                     "¡Alumno guardado correctamente!",
                     "Éxito");
                }
                else
                {
                    string errorDetalle = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"No se pudo guardar: {errorDetalle}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
            finally
            {
                btnGuardar.Enabled = true;
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RellenarControles() {
            string nombre = AlumnoSeleccionado.nombre;
            string primerApellido = AlumnoSeleccionado.primerApellido;
            string segundoApellido = AlumnoSeleccionado.segundoApellido;

            string nombreTutor = AlumnoSeleccionado.tutor;
            string primerApellidoTutor = AlumnoSeleccionado.primerApellidoTutor;
            string segundoApellidoTutor = AlumnoSeleccionado.segundoApellidoTutor;

            tbCURP.Text = AlumnoSeleccionado.idCURP;
            tbDireccion.Text = AlumnoSeleccionado.direccion;

            tbNombreAlumno.Text = nombre;
            tbPrimerApellidoAlumno.Text = primerApellido;
            tbSegundoApellidoAlumno.Text = segundoApellido;

            tbNombreTutor.Text = nombreTutor;
            tbPrimerApellidoTutor.Text = primerApellidoTutor;
            tbSegundoApellidoTutor.Text = segundoApellidoTutor;

            dtpFechaNacimiento.Value = AlumnoSeleccionado.fechaNacimiento;

            cbGrupo.SelectedIndex = cbGrupo.Items.IndexOf(AlumnoSeleccionado.gradoGrupo);

            tbParentescoTutor.Text = AlumnoSeleccionado.parentescoTutor;
            tbTelefonoTutor.Text = AlumnoSeleccionado.telefonoTutor;
        }

  
        
        private bool ValidarTodoElFormulario()
        {
            return ValidarControlesRecursivo(this.Controls);
        }
        private bool ValidarControlesRecursivo(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
                if (c is TextBox || c is ComboBox)
                {
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        MessageBox.Show("Por favor, llena todos los campos del formulario.", "Campo Requerido");
                        c.Focus();
                        return false;
                    }
                }
                else if (c is DateTimePicker dtp)
                {
                    DateTime fechaSeleccionada = dtp.Value.Date;
                    int edad = DateTime.Today.Year - fechaSeleccionada.Year;

                    if (fechaSeleccionada > DateTime.Today.AddYears(-edad)) edad--;

                    if (fechaSeleccionada > DateTime.Today)
                    {
                        MessageBox.Show("La fecha no puede ser futura.");
                        dtp.Focus();
                        return false;
                    }

                    if (edad < 5 || edad > 18)
                    {
                        MessageBox.Show($"El alumno debe tener entre 5 y 18 años. (Edad detectada: {edad})");
                        dtp.Focus();
                        return false;
                    }
                }

                if (c.HasChildren)
                {
                    if (!ValidarControlesRecursivo(c.Controls)) return false;
                }
            }
            return true;
        }

        private void ModificarAlumnoView_Load(object sender, EventArgs e)
        {
                if (AlumnoSeleccionado != null)
                {
                    RellenarControles();
                }
                else
                {
                    MessageBox.Show("Error al cargar el alumno.", "Error");
                    this.Close();
                }
        }

        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
