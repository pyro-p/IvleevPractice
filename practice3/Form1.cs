using practice3.task1;
using practice3.task2;
using practice3.task3;

namespace practice3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Task1
        /// </summary>
        List<Chair> chairs = new();

        private void ButtonObjectCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxObjectMaterial.Text == "" || textBoxObjectColor.Text == "")
            {
                MessageBox.Show("Заполните поля");
                return;
            }

            Chair chair = new Chair();
            chair.SetMaterial(comboBoxObjectMaterial.Text);
            chair.SetColor(textBoxObjectColor.Text);
            chairs.Add(chair);
        }

        private void ButtonObjectOutput_Click(object sender, EventArgs e)
        {
            if (chairs == null)
                return;

            listBoxObjects.Items.Clear();
            foreach (Chair chair in chairs)
            {
                listBoxObjects.Items.Add(chair.GetColor() + " " + chair.GetMaterial() + " стул");
            }
        }

        /// <summary>
        /// Task2
        /// </summary>
        List<Figure> figures = new();
        Random rnd = new Random();
        int startPosX;
        int startPosY;

        private void ButtonFigureSquare_Click(object sender, EventArgs e)
        {
            if (comboBoxFigureFill.Text == null || !int.TryParse(maskedTextBoxFigureWidth.Text, out int width))
                return;

            bool filled = false;
            switch (comboBoxFigureFill.Text)
            {
                case "Закрашенный":
                    filled = true;
                    break;
                case "Не закрашенный":
                    filled = false;
                    break;
            }

            Square square = new Square(filled, width);

            figures.Add(square);
        }

        private void ButtonFigureOval_Click(object sender, EventArgs e)
        {
            if (comboBoxFigureFill.Text == null || !int.TryParse(maskedTextBoxFigureWidth.Text, out int width))
                return;

            bool filled = false;
            switch (comboBoxFigureFill.Text)
            {
                case "Закрашенный":
                    filled = true;
                    break;
                case "Не закрашенный":
                    filled = false;
                    break;
            }

            Oval oval = new Oval(filled, width);

            figures.Add(oval);
        }

        private void ButtonFigureDraw_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black, 1);
            SolidBrush br = new SolidBrush(Color.Black);

            foreach (var figure in figures)
            {
                startPosX = rnd.Next(pictureBox1.Width - figure.Width);
                startPosY = rnd.Next(pictureBox1.Height - figure.Height);

                if (figure is Oval)
                {
                    g.DrawEllipse(pen, startPosX, startPosY, figure.Width, figure.Height);
                    if (figure.Filled)
                    {
                        g.FillEllipse(br, startPosX, startPosY, figure.Width, figure.Height);
                    }
                }

                if (figure is Square)
                {
                    g.DrawRectangle(pen, startPosX, startPosY, figure.Width, figure.Height);
                    if (figure.Filled)
                    {
                        g.FillRectangle(br, startPosX, startPosY, figure.Width, figure.Height);
                    }
                }
            }

            pictureBox1.Image = bmp;
        }

        /// <summary>
        /// Task3
        /// </summary>
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            CalculateChild calculate = new CalculateChild();

            int.TryParse(maskedTextBoxNum1.Text, out int x);
            int.TryParse(maskedTextBoxNum2.Text, out int y);

            textBoxCalculate.Text = calculate.GetResult(x, y).ToString();
        }
    }
}