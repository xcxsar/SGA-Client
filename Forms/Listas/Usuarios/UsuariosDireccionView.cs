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
    public partial class UsuariosDireccionView : Form
    {
        internal AlumnoModel AlumnoSeleccionado; 

        internal string url = "https://localhost:44342/api/";
        public UsuariosDireccionView()
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
            typeof(DataGridView).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
            null, dgvUsuarios, new object[] { true });
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

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistrarUsuarioView crearUsuarioView = new RegistrarUsuarioView();
            crearUsuarioView.ShowDialog(this);

            await CargarUsuariosEnGrid(dgvUsuarios);
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuarioView modificarUsuarioView = new ModificarUsuarioView();
            modificarUsuarioView.ShowDialog(this);
            await CargarUsuariosEnGrid(dgvUsuarios);
        }
        private async void AlumnosView_Load(object sender, EventArgs e)
        {
            await CargarUsuariosEnGrid(dgvUsuarios);
        }

        public async Task CargarUsuariosEnGrid(DataGridView grid)
        {
            try
            {
                UsersFiltrosModel filtros = new UsersFiltrosModel
                {
                    tipoUsuario = cbGrupo.Text,
                    nombre = tbNombreUsuario.Text
                };
                if (cbGrupo.Text == "Ninguno" || cbGrupo.Text == "")
                {
                    filtros.tipoUsuario = null;
                }
              
                if (string.IsNullOrEmpty(tbNombreUsuario.Text))
                {
                    filtros.nombre = null;
                }

                string jsonFiltros = JsonConvert.SerializeObject(filtros);

                var content = new StringContent(jsonFiltros, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await SesionGlobal.WebCliente.PostAsync(url+"users", content);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    List<UsersGridDto> lista = JsonConvert.DeserializeObject<List<UsersGridDto>>(jsonResponse);

                    grid.DataSource = null;
                    grid.DataSource = lista;

                    if (grid.Columns["usuarioId"] != null)
                    {
                        grid.Columns["usuarioId"].HeaderText = "Id";
                        grid.Columns["nombre"].HeaderText = "Nombre del Usuario";
                        grid.Columns["correo"].HeaderText = "Correo";
                        grid.Columns["tipoUsuario"].HeaderText = "Tipo De Usuario";
                        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los datos: " + ex.Message);
            }
        }

        private async void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
        }
        private async void tbNombreAlumno_TextChanged(object sender, EventArgs e)
        {
                await CargarUsuariosEnGrid(dgvUsuarios);
        }

        public async void guardarAlumnoSeleccionado()
        {
         
        }
        public async void eliminarAlumnoSeleccionado()
        {
         
        }

        private async void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            await CargarUsuariosEnGrid(dgvUsuarios);
        }

        private async void tbNombreAlumno_KeyDown(object sender, KeyEventArgs e)
        {
                await CargarUsuariosEnGrid(dgvUsuarios);
            
        }
    }
}
