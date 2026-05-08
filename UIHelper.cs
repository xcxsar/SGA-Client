using System.Drawing;
using System.Windows.Forms;

namespace SGA_Client
{
    public static class UIHelper
    {
        public static void DibujarCuadriculaFondo(Form formulario, PaintEventArgs e, int spacing = 20)
        {
            e.Graphics.Clear(Color.White);

            using (Pen gridPen = new Pen(Color.FromArgb(230, 230, 230), 1))
            {
                for (int x = 0; x < formulario.ClientSize.Width; x += spacing)
                {
                    e.Graphics.DrawLine(gridPen, x, 0, x, formulario.ClientSize.Height);
                }
                for (int y = 0; y < formulario.ClientSize.Height; y += spacing)
                {
                    e.Graphics.DrawLine(gridPen, 0, y, formulario.ClientSize.Width, y);
                }
            }
        }

        public static void AplicarFuenteInterAControles(Control contenedor, int tamaño = 12, FontStyle estilo = FontStyle.Regular)
        {
            contenedor.Font = ManejadorDeFuentes.GetFont("Inter", tamaño, estilo);

            foreach (Control control in contenedor.Controls)
            {
                AplicarFuenteInterAControles(control, tamaño, estilo);
            }
        }
    }
}