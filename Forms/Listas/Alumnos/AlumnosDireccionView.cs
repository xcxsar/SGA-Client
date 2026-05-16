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
    public partial class AlumnosDireccionView : Form
    {
        internal AlumnoModel AlumnoSeleccionado; 

        internal string url = "https://localhost:44342/api/alumnos";
        public AlumnosDireccionView()
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

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            CrearAlumnoView crearAlumnoView = new CrearAlumnoView();
            crearAlumnoView.ShowDialog(this);
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (AlumnoSeleccionado == null || dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un alumno para modificar.", "No hay alumno seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ModificarAlumnoView modAlumnoView = new ModificarAlumnoView();
            modAlumnoView.AlumnoSeleccionado = this.AlumnoSeleccionado;
            modAlumnoView.ShowDialog(this);
            await CargarAlumnosEnGrid(dgvAlumnos);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (AlumnoSeleccionado == null || dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un alumno para modificar.", "No hay alumno seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { 
                   eliminarAlumnoSeleccionado();
            }
        }

        private async void AlumnosView_Load(object sender, EventArgs e)
        {
            await CargarAlumnosEnGrid(dgvAlumnos);
            guardarAlumnoSeleccionado();
        }

        public async Task CargarAlumnosEnGrid(DataGridView grid)
        {
            try
            {
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
        }

        private async void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
          guardarAlumnoSeleccionado();
        }
        private async void tbNombreAlumno_TextChanged(object sender, EventArgs e)
        {
                await CargarAlumnosEnGrid(dgvAlumnos);
        }

        public async void guardarAlumnoSeleccionado()
        {
            try
            {
                if (dgvAlumnos.SelectedRows.Count > 0)
                {

                    AlumnoGridModel alumnoSeleccionado = dgvAlumnos.CurrentRow?.DataBoundItem as AlumnoGridModel;

                    if (alumnoSeleccionado != null)
                    {

                        HttpResponseMessage response = await SesionGlobal.WebCliente.GetAsync(url+$"/{alumnoSeleccionado.idCURP}");

                        string json = await response.Content.ReadAsStringAsync();
                        if (response.IsSuccessStatusCode)
                        {
                            var jsonResponse = await response.Content.ReadAsStringAsync();
                            var alumno = JsonConvert.DeserializeObject<AlumnoModel>(jsonResponse);

                            
                            AlumnoSeleccionado = alumno;
                        }
                        else
                        {
                                MessageBox.Show($"No se pudo completar la acción: {json}",
                                                "Error de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el alumno: " + ex.Message);
            }
        }
        public async void eliminarAlumnoSeleccionado()
        {
            try
            {
                DialogResult resultado = MessageBox.Show(
                    "Desea eliminar al alumno " +
                    $"{AlumnoSeleccionado.idCURP}?",
                    "Precaucion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var payload = new { idCURP = AlumnoSeleccionado.idCURP };
                    string json = JsonConvert.SerializeObject(payload);

                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(url),
                        Content = new StringContent(json, Encoding.UTF8, "application/json")
                    };


                    HttpResponseMessage response = await SesionGlobal.WebCliente.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Alumno eliminado correctamente",
                                         "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CargarAlumnosEnGrid(dgvAlumnos);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el alumno: " + ex.Message);
            }
        }

        private async void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            await CargarAlumnosEnGrid(dgvAlumnos);
        }

        private async void tbNombreAlumno_KeyDown(object sender, KeyEventArgs e)
        {
                await CargarAlumnosEnGrid(dgvAlumnos);
        }
    }
}
