using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            _inicioDeSesionView.Show();
        }
    }
}
