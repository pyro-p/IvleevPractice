namespace practice4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAction_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            double.TryParse(maskedTextBoxA.Text, out double A);
            double.TryParse(maskedTextBoxB.Text, out double B);

            int production = 100;
            int demand = 150000;
            int year = 1;
            int step = 1;
            dataGridView1.Rows.Add(step, year, production, demand);

            while (production < demand)
            {
                step++;
                dataGridView1.Rows.Add(step, "", "", "", "+");

                year++;
                step++;

                production = Convert.ToInt32(production * (A / 100 + 1));
                demand = Convert.ToInt32(demand * (1 - B / 100));

                dataGridView1.Rows.Add(step, year, production, demand);
            }

            step++;
            dataGridView1.Rows.Add(step, "", "", "", "-");
        }
    }
}