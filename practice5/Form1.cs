using System;

namespace practice5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            double.TryParse(textBoxX.Text, out double x);
            double s = 0;
            Log("x = " + x);

            

            for (double i = 1, j = Math.Pow(i * 2, 2) - 1; i <= 50; i++, j = Math.Pow(i * 2, 2) - 1)
            {
                s += Math.Cos(i * 2 * x) / j;
                Log(s.ToString());
            }

            double y = (double)1 / 2 - ((Math.PI / 4) * Math.Abs(Math.Sin(x)));

            // 8
            //for (double i = 0, j = 1; i < 40; i++, j += 2)
            //{
            //    if (i % 2 == 0)
            //    {
            //        s += Math.Pow(x, j) / j;
            //    }
            //    else
            //    {
            //        s -= Math.Pow(x, j) / j;
            //    }
            //    Log(s.ToString());
            //}

            //double y = Math.Atan(x);

            Log("Y: " + y.ToString());

            textBoxX.Text = s.ToString();
            textBoxY.Text = y.ToString();
        }

        private void Log(string message)
        {
            string filePath = $"log {DateTime.Now.ToString("yyyy-MM-dd_HH-mm")}.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss:fff") + ": " + message);
            }
        }
    }
}