using System.Drawing;
using System.Windows.Forms;

namespace CircularProgressBar
{
    internal class CircularProgressBar : Control
    {
        public int Value { get; set; }
        public int Maximum { get; set; }
        public Size Size { get; set; }
        public Point Location { get; set; }
        public string Text { get; set; }
        public Font Font { get; set; }
        public Color ForeColor { get; set; }
    }
}