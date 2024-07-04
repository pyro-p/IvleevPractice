using Serilog;

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
            Log.Debug("x = {0}", x);
            double s = 0;

            for (double i = 1; i <= 80; i += 2)
            {
                s += Math.Cos(i * x) / (i * i);
                Log.Debug("s = {0}", s.ToString());
            }
                    
            double y = Math.Pow(Math.PI, 2) / 8 - Math.PI / 4 * Math.Abs(x);

            Log.Debug("s = {0}", s.ToString());
            Log.Debug("y = {0}", y.ToString());

            textBoxX.Text = s.ToString();
            textBoxY.Text = y.ToString();
        }
    }
}