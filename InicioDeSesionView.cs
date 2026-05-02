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

            title.Font = ManejadorDeFuentes.GetFont("Bevan", 48);
            header.Font = ManejadorDeFuentes.GetFont("Inter", 18, FontStyle.Bold);
            labelUsuario.Font = ManejadorDeFuentes.GetFont("Inter", 12);
            labelPassword.Font = ManejadorDeFuentes.GetFont("Inter", 12);
            textBoxUsuario.Font = ManejadorDeFuentes.GetFont("Inter", 12);
            textBoxPassword.Font = ManejadorDeFuentes.GetFont("Inter", 12);
            buttonSalir.Font = ManejadorDeFuentes.GetFont("Inter", 12);
            buttonIniciarSesion.Font = ManejadorDeFuentes.GetFont("Inter", 12);
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

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            MenuPrincipalDirectivo menu = new MenuPrincipalDirectivo(this);
            menu.Show();

            this.Hide();
        }
    }
}
