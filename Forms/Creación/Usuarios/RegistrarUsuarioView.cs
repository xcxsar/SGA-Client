using Newtonsoft.Json;
using SGA_Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA_Client.Forms.Creación
{
    public partial class RegistrarUsuarioView : Form
    {

        internal string url = "https://localhost:44342/api/register";
        public RegistrarUsuarioView()
        {
            InitializeComponent();
            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);
            this.UpdateStyles();

            UIHelper.AplicarFuenteInterAControles(this, 12);
            Title.Font = ManejadorDeFuentes.GetFont("Bevan", 16);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            UIHelper.DibujarCuadriculaFondo(this, e);
        }


        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarTodoElFormulario()) return;

            if (tbContrasena.Text != tbConContrasena.Text) 
            {
                MessageBox.Show($"Las Contraseñas no coinciden");
                return;
            }


            var usuario = new UsuarioCreationModel
            {
                tipoUsuario = cbTipoUsuario.Text,
                contrasena = tbContrasena.Text,
                correo = tbCorreo.Text,
                nombre = tbNombreAlumno.Text,
            };

            try
            {
                btnGuardar.Enabled = false;

                string json = JsonConvert.SerializeObject(usuario);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await SesionGlobal.WebCliente.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    DialogResult resultado = MessageBox.Show(
                     "¡Usuario guardado correctamente! ¿Desea registrar a otro usuario?",
                     "Éxito",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        LimpiarFormulario();
                    }
                    else
                    {
                        this.Close();
                    }
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
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void LimpiarFormulario()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
                else if (c is ComboBox combo)
                {
                    combo.SelectedIndex = -1;
                    combo.Text = string.Empty;
                }
                else if (c is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now;
                }

                if (c.HasChildren)
                {
                    LimpiarControlesInternos(c);
                }
            }
            tbNombreAlumno.Focus();
        }
        private void LimpiarControlesInternos(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                if (c is TextBox) c.Text = string.Empty;
                if (c is ComboBox cb) cb.SelectedIndex = -1;
                if (c is DateTimePicker dtp) dtp.Value = DateTime.Now;
                if (c.HasChildren) LimpiarControlesInternos(c);
            }
        }

    }
}

