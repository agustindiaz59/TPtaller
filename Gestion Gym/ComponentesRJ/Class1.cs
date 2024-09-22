using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Gym.ComponentesRJ
{
    public class PanelRedondo : Panel
    {
        // Propiedades para el color del borde, el ancho del borde, y el radio de los bordes redondeados
        public Color BorderColor { get; set; } = Color.Black;
        public int BorderWidth { get; set; } = 2;
        public int Radio { get; set; } = 20;

        public PanelRedondo()
        {
            // Para reducir el parpadeo
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.DoubleBuffered = true;

            // Establecer el estilo de fondo del panel
            this.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
  
            DrawRoundedPanel(e.Graphics);
        }

        private void DrawRoundedPanel(Graphics g)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                // rectángulo redondeado
                path.AddArc(0, 0, Radio * 2, Radio * 2, 180, 90);
                path.AddArc(this.Width - Radio * 2, 0, Radio * 2, Radio * 2, 270, 90);
                path.AddArc(this.Width - Radio * 2, this.Height - Radio * 2, Radio * 2, Radio * 2, 0, 90);
                path.AddArc(0, this.Height - Radio * 2, Radio * 2, Radio * 2, 90, 90);
                path.CloseAllFigures();

                // Configurar el área de recorte
                this.Region = new Region(path);

                // Dibujar el panel
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Dibujar el borde
                using (Pen pen = new Pen(BorderColor, BorderWidth))
                {
                    g.DrawPath(pen, path);
                }
            }
        }
    }
}