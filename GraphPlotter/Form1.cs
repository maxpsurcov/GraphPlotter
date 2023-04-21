using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphPlotter
{
    public partial class Form1 : Form
    {
        private double r, h;
        private double minX, maxX, minY, maxY;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Зчитування введених користувачем значень
            if (!double.TryParse(txtR.Text, out r))
            {
                MessageBox.Show("Невірний формат значення R!");
                return;
            }

            if (!double.TryParse(txtH.Text, out h))
            {
                MessageBox.Show("Невірний формат значення H!");
                return;
            }

            // Визначення області визначення функції
            minX = -Math.PI;
            maxX = Math.PI;
            minY = r - h;
            maxY = r + h;

            // Очистка панелі для графіку
            panel1.Refresh();

            // Створення графіку
            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Blue, 2);

            // Відображення системи координат
            DrawAxes(g);

            // Побудова графіку функції
            DrawGraph(g, pen);
        }

        private void DrawAxes(Graphics g)
        {
            // Визначення розмірів панелі
            int width = panel1.Width;
            int height = panel1.Height;

            // Відображення осей координат
            g.DrawLine(Pens.Black, 0, height / 2, width, height / 2);
            g.DrawLine(Pens.Black, width / 2, 0, width / 2, height);

            // Відображення підписів осей координат
            Font font = new Font("Arial", 10);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            g.DrawString("X", font, Brushes.Black, width - 20, height / 2 - 20, format);
            g.DrawString("Y", font, Brushes.Black, width / 2 + 20, 0, format);

            // Відображення поділок на осі X
            double stepX = (maxX - minX) / 10;

            for (double x = minX; x <= maxX; x += stepX)
            {
                int posX = (int)((x - minX) / (maxX - minX) * width);

                g.DrawLine(Pens.Black, posX, height / 2 - 5, posX, height / 2 + 5);
                g.DrawString(x.ToString("0.##"), font, Brushes.Black, posX, height / 2 + 5, format);
            }

            // Відображення поділок на осі Y
            double stepY = (maxY - minY) / 10;

            for (double y = minY; y <= maxY; y += stepY)
            {
                int posY = (int)((maxY - y) / (maxY * minY) * height);
                g.DrawLine(Pens.Black, width / 2 - 5, posY, width / 2 + 5, posY);
                g.DrawString(y.ToString("0.##"), font, Brushes.Black, width / 2 + 10, posY - 10, format);
            }
        }
        private void DrawGraph(Graphics g, Pen pen)
        {
            // Визначення кроку для побудови кривої
            double step = 0.1;

            // Обчислення координат точок кривої
            for (double t = 0; t <= Math.PI * 2; t += step)
            {
                double x = r * t - h * Math.Sin(t);
                double y = r - h * Math.Cos(t);

                // Перетворення координат до системи координат панелі
                int posX = (int)((x - minX) / (maxX - minX) * panel1.Width);
                int posY = (int)((maxY - y) / (maxY - minY) * panel1.Height);

                // Відображення точки на графіку
                g.DrawEllipse(pen, posX - 2, posY - 2, 4, 4);
            }
        }
    }
}
