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

namespace SGA_Client.Forms
{
    public partial class UsuariosCambiarContrasenaView : Form
    {
        internal string correo { get; set; }

        internal string codigoVerificacion { get; set; }

        internal string url = "https://localhost:44342/api/";

        public UsuariosCambiarContrasenaView()
        {
            InitializeComponent();
            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);
            this.UpdateStyles();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            UIHelper.DibujarCuadriculaFondo(this, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidarTodoElFormulario();
            if (tbContrasena.Text != tbConContrasena.Text)
            {
                MessageBox.Show($"Las Contraseñas no coinciden");
                return;
            }


            var cambioContrasena = new UsuarioCambioContrasenaModel
            {
              
                contrasena = tbContrasena.Text,
                correo = this.correo,
                codigoVerificacion = this.codigoVerificacion
            };

            try
            {
                btnGuardar.Enabled = false;

                string json = JsonConvert.SerializeObject(cambioContrasena);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await SesionGlobal.WebCliente.PostAsync(url + "resetPassword", content);

                if (response.IsSuccessStatusCode)
                {
                    DialogResult resultado = MessageBox.Show(
                     "¡Contraseña Cambiada exitosamente!",
                     "Éxito");
                    this.Close();
                }
                else
                {
                    string errorDetalle = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"No se pudo guardar: {errorDetalle}");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
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
    }
}
