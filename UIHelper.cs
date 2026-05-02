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
    }
}