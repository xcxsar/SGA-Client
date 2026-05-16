using Newtonsoft.Json;
using SGA_Client.Forms;
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

        private async void lbOlvidarContraseña_Click(object sender, EventArgs e)
        {
             DialogResult respuesta = MessageBox.Show(
            "¿Desea cambiar la contraseña que olvidó?",
             "Recuperar Contraseña",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                string correo = MostrarInputBox("Recuperación", "Por favor, introduce tu correo electrónico:");

                if (string.IsNullOrWhiteSpace(correo))
                {
                    MessageBox.Show("Operación cancelada o correo no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Enviar solicitud al backend para generar y enviar el código de verificación
                try
                {
                    string url = $"https://localhost:44342/api/getCode?correo={correo}";
                    var content = new StringContent("", Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await SesionGlobal.WebCliente.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Código de verificación enviado a tu correo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string codigo = MostrarInputBox("Verificación", "Introduce el código de verificación enviado a tu correo:");

                        if (string.IsNullOrWhiteSpace(codigo))
                        {
                            MessageBox.Show("Operación cancelada o código no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // Enviar solicitud al backend para verificar el código
                        try
                        {
                            url = $"https://localhost:44342/api/verifyCode?correo={correo}&codigo={codigo}";
                            content = new StringContent("", Encoding.UTF8, "application/json");

                            response = await SesionGlobal.WebCliente.PostAsync(url, content);

                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Código de verificación Correcto", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UsuariosCambiarContrasenaView frmNuevaContrasena = new UsuariosCambiarContrasenaView();
                                frmNuevaContrasena.correo = correo;
                                frmNuevaContrasena.codigoVerificacion = codigo;
                                this.Hide();
                                frmNuevaContrasena.ShowDialog();
                                this.Show();
                            }
                            else if (response.StatusCode == HttpStatusCode.NotFound)
                            {
                                MessageBox.Show("Correo no encontrado. Verifica el correo ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Error al enviar el código de verificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudo conectar con el servidor: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Correo no encontrado. Verifica el correo ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo conectar con el servidor: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        public static string MostrarInputBox(string titulo, string textoIndicacion)
        {
            Form formulario = new Form();
            Label etiqueta = new Label();
            TextBox cajaTexto = new TextBox();
            Button botonAceptar = new Button();
            Button botonCancelar = new Button();

            formulario.Text = titulo;
            etiqueta.Text = textoIndicacion;
            cajaTexto.Text = "";

            botonAceptar.Text = "Aceptar";
            botonCancelar.Text = "Cancelar";
            botonAceptar.DialogResult = DialogResult.OK;
            botonCancelar.DialogResult = DialogResult.Cancel;

            etiqueta.SetBounds(12, 15, 372, 20);
            cajaTexto.SetBounds(12, 36, 372, 20);
            botonAceptar.SetBounds(228, 72, 75, 23);
            botonCancelar.SetBounds(309, 72, 75, 23);
            formulario.ClientSize = new Size(396, 107);
            formulario.Controls.AddRange(new Control[] { etiqueta, cajaTexto, botonAceptar, botonCancelar });
            formulario.FormBorderStyle = FormBorderStyle.FixedDialog;
            formulario.StartPosition = FormStartPosition.CenterParent;
            formulario.MinimizeBox = false;
            formulario.MaximizeBox = false;
            formulario.AcceptButton = botonAceptar;
            formulario.CancelButton = botonCancelar;

            DialogResult resultado = formulario.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                return cajaTexto.Text;
            }
            return string.Empty;
        }
    }
}
