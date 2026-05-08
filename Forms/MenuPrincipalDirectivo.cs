using Newtonsoft.Json;
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

namespace SGA_Client
{
    public partial class MenuPrincipalDirectivo : Form
    {
        private InicioDeSesionView _inicioDeSesionView;
        public MenuPrincipalDirectivo(InicioDeSesionView inicioDeSesionView)
        {
            InitializeComponent();

            title.Font = ManejadorDeFuentes.GetFont("Bevan", 32);
            btnAlumnos.Font = ManejadorDeFuentes.GetFont("Inter", 12);
            btnBoletas.Font = ManejadorDeFuentes.GetFont("Inter", 12);
            btnGenerarReporte.Font = ManejadorDeFuentes.GetFont("Inter", 12);
            btnSalir.Font = ManejadorDeFuentes.GetFont("Inter", 12);
            _inicioDeSesionView = inicioDeSesionView;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            UIHelper.DibujarCuadriculaFondo(this, e);
        }

        private async void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                btnSalir.Enabled = false;
                string url = "https://localhost:44342/api/logout";

                HttpResponseMessage response = await SesionGlobal.WebCliente.PostAsync(url, null);

                if (response.IsSuccessStatusCode)
                {
                    var datos = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(datos);

                    
                    MessageBox.Show($"{data.message}");


                    _inicioDeSesionView.LimpiarTodo();
                    _inicioDeSesionView.Show();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Error al cerrar sesión: Verifique sus credenciales.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con el servidor: " + ex.Message);
            }
            finally
            {
                btnSalir.Enabled = true;
            }
        }

        private void MenuPrincipalDirectivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_inicioDeSesionView.Visible)
            {
                Application.Exit();
            }
        }
    }
}
