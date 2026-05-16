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
    public partial class AlumnosProfesorView : Form
    {

        internal string url = "https://localhost:44342/api/alumnos";
        public AlumnosProfesorView()
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
            null, dgvAlumnos, new object[] { true });
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
        private async void AlumnosView_Load(object sender, EventArgs e)
        {
            await CargarAlumnosEnGrid(dgvAlumnos);
        }



        private async void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
                await CargarAlumnosEnGrid(dgvAlumnos);
            
        }

        private async void tbNombreAlumno_TextChanged(object sender, EventArgs e)
        {
            await CargarAlumnosEnGrid(dgvAlumnos);
        }

        public async Task CargarAlumnosEnGrid(DataGridView grid)
        {
            try
            {
                tbNombreAlumno.Enabled = false;
                cbGrupo.Enabled = false;
                AlumnosFiltrosModel filtros = new AlumnosFiltrosModel
                {
                    gradoGrupo = cbGrupo.Text,
                    nombreCURP = tbNombreAlumno.Text
                };
                if (cbGrupo.Text == "Ninguno" || cbGrupo.Text == "")
                {
                    filtros.gradoGrupo = null;
                }

                if (string.IsNullOrEmpty(tbNombreAlumno.Text))
                {
                    filtros.nombreCURP = null;
                }
                MessageBox.Show($"{filtros}","Error");
                string jsonFiltros = JsonConvert.SerializeObject(filtros);

                var content = new StringContent(jsonFiltros, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await SesionGlobal.WebCliente.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    List<AlumnoGridModel> lista = JsonConvert.DeserializeObject<List<AlumnoGridModel>>(jsonResponse);

                    grid.DataSource = null;
                    grid.DataSource = lista;

                    if (grid.Columns["idCURP"] != null)
                    {
                        grid.Columns["idCURP"].HeaderText = "CURP";
                        grid.Columns["Nombre"].HeaderText = "Nombre del Alumno";
                        grid.Columns["gradoGrupo"].HeaderText = "Grado Escolar";
                        grid.Columns["Tutor"].HeaderText = "Nombre del Tutor";
                        grid.Columns["TelefonoTutor"].HeaderText = "Teléfono";
                        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los datos: " + ex.Message);
            }
            finally {
                tbNombreAlumno.Enabled = true;
                cbGrupo.Enabled = true;
            }
        }

        private async void tbNombreAlumno_KeyDown(object sender, KeyEventArgs e)
        {
            await CargarAlumnosEnGrid(dgvAlumnos);
        }
    }
}
