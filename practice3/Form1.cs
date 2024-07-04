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
        List<Bed> beds = new();

        private void ButtonObjectCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxObjectMaterial.Text == "" || textBoxObjectColor.Text == "")
            {
                MessageBox.Show("Заполните поля");
                return;
            }

            Bed bed = new Bed();
            bed.SetSize(comboBoxObjectMaterial.Text);
            bed.SetColor(textBoxObjectColor.Text);
            beds.Add(bed);
        }

        private void ButtonObjectOutput_Click(object sender, EventArgs e)
        {
            if (beds == null)
                return;

            listBoxObjects.Items.Clear();
            foreach (Bed bed in beds)
            {
                listBoxObjects.Items.Add(bed.GetColor() + " " + bed.GetSize() + " кровать");
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

            startPosX = rnd.Next(pictureBox1.Width);
            startPosY = rnd.Next(pictureBox1.Height);

            task2.Rectangle square = new task2.Rectangle(filled, width, startPosX, startPosY);

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

            startPosX = rnd.Next(pictureBox1.Width);
            startPosY = rnd.Next(pictureBox1.Height);

            Circle circle = new Circle(filled, width, startPosX, startPosY);

            figures.Add(circle);
        }

        private void ButtonFigureDraw_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new(pictureBox1.Width, pictureBox1.Height);

            foreach (var figure in figures)
            {
                figure.CreateTools(pictureBox1.Width, pictureBox1.Height, bmp);
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