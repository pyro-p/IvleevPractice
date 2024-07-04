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
            int step = 1;
            dataGridView1.Rows.Clear();
            int.TryParse(maskedTextBoxN1.Text, out int N1);
            dataGridView1.Rows.Add(step++, "", N1, "");
            int.TryParse(maskedTextBoxN2.Text, out int N2);
            dataGridView1.Rows.Add(step++, "", "", N2);
            if (N1 > N2)
            {
                dataGridView1.Rows.Add(step++, "", "", "", "-");
                return;
            }
            dataGridView1.Rows.Add(step++, "", "", "", "+");


            double.TryParse(maskedTextBoxP1.Text, out double P1);
            double.TryParse(maskedTextBoxP2.Text, out double P2);
            if (P1 < P2)
            {
                dataGridView1.Rows.Add(step++, "", "", "", "", "", "-");
                return;
            }
            dataGridView1.Rows.Add(step++, "", "", "", "", "", "+");

            int year = 2014;
            dataGridView1.Rows.Add(step++, year);

            while (N1 < N2)
            {
                dataGridView1.Rows.Add(step++, "", "", "", "+");

                year++;
                dataGridView1.Rows.Add(step++, year);

                N1 = Convert.ToInt32(N1 * (P1 / 100 + 1));
                dataGridView1.Rows.Add(step++, "", N1, "");
                N2 = Convert.ToInt32(N2 * (1 - P2 / 100));
                dataGridView1.Rows.Add(step++, "", "", N2);
            }

            dataGridView1.Rows.Add(step, "", "", "", "-");
        }
    }
}