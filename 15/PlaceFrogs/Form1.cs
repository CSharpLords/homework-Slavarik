using System.Drawing;
using System.Windows.Forms;

namespace PlaceFrogs {
    public partial class Form1 : Form {
        int c = 50;
        Graphics graphics;
        Image frog = Image.FromFile("../../frog.png");
        Image lilypad = Image.FromFile("../../lilypad.png");

        public Form1() {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e) {
            graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // рисуем кувшинки и лягушек
            for (int i = 0; i < 1000; i += 250) {
                DrawLilypad(i, 0);
                DrawFrog(c, 35);
                c = c + 250;
            }
        }

        private void DrawFrog(int x, int y) {
            graphics.DrawImage(frog, x, y, 150, 150);
        }

        private void DrawLilypad(int x, int y) {
            graphics.DrawImage(lilypad, x, y, 250, 250);
        }
    }
}
