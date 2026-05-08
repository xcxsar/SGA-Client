using Newtonsoft.Json;
using SGA_Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA_Client
{
    public partial class InicioDeSesionView : Form
    {
        public InicioDeSesionView()
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
            title.Font = ManejadorDeFuentes.GetFont("Bevan", 48);
            header.Font = ManejadorDeFuentes.GetFont("Inter", 18, FontStyle.Bold);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            UIHelper.DibujarCuadriculaFondo(this, e);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsuario.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            var usuario = new UsuarioLoginModel
            {
                correo = textBoxUsuario.Text.Trim(),
                contrasena = textBoxPassword.Text.Trim()
            };

            string json = JsonConvert.SerializeObject(usuario);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                buttonIniciarSesion.Enabled = false;
                string url = "https://localhost:44342/api/login";

                HttpResponseMessage response = await SesionGlobal.WebCliente.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    var datos = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(datos);

                    var u = new UsuarioModel
                    {
                        id = data.id,
                        token = data.token,
                        tipoUsuario = data.tipoUsuario
                    };

                    SesionGlobal.Iniciar(u);
                    MessageBox.Show($"Bienvenido {usuario.correo}");

                    Form formularioAMostrar;

                    if (SesionGlobal.UsuarioActual.tipoUsuario == "Profesor")
                    {
                        formularioAMostrar = new MenuPrincipalProfesor(this); 
                    }
                    else if (SesionGlobal.UsuarioActual.tipoUsuario == "Direccion")
                    {
                        formularioAMostrar = new MenuPrincipalDirectivo(this);
                    }
                    else
                    {
                        MessageBox.Show("Rol de usuario no reconocido.");
                        return;
                    }

                    formularioAMostrar.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Error al iniciar sesión: Verifique sus credenciales."+ response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con el servidor: " + ex.Message);
            }
            finally
            {
                buttonIniciarSesion.Enabled = true;
            }
        }

        public void LimpiarTodo()
        {
           
            textBoxPassword.Text = string.Empty;
            textBoxUsuario.Text = string.Empty;
            textBoxUsuario.Focus();
            SesionGlobal.Cerrar();
        }

        private void InicioDeSesionView_Load(object sender, EventArgs e)
        {
            LimpiarTodo();
        }
    }
}
