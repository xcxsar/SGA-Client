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
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Always call base first
            base.OnPaint(e);

            // Clear the background with a solid color (e.g., White)
            e.Graphics.Clear(Color.White);

            int spacing = 20;
            using (Pen gridPen = new Pen(Color.LightGray, 1))
            {
                for (int x = 0; x < this.ClientSize.Width; x += spacing)
                {
                    e.Graphics.DrawLine(gridPen, x, 0, x, this.ClientSize.Height);
                }
                for (int y = 0; y < this.ClientSize.Height; y += spacing)
                {
                    e.Graphics.DrawLine(gridPen, 0, y, this.ClientSize.Width, y);
                }
            }
        }
    }
}
