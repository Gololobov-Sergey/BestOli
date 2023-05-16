using System.Text.RegularExpressions;

namespace BestOli
{
    public partial class Form_Oli : Form
    {
        List<Oil> oils = new List<Oil>();

        public Form_Oli()
        {
            InitializeComponent();

            oils.Add(new Oil { Name = "Бензин А-95", Price = 50.35M });
            oils.Add(new Oil { Name = "Бензин А-98", Price = 55.32M });
            oils.Add(new Oil { Name = "Бензин А-98 ЕВРО", Price = 60.35M });
            oils.Add(new Oil { Name = "Газ", Price = 21.10M });
            oils.Add(new Oil { Name = "Дизель", Price = 45.30M });

            cBox_Name_gasoline.Items.AddRange(oils.Select(o => o.Name).ToArray());
            cBox_Name_gasoline.SelectedIndex = 0;
        }

        private void but_payable_Click(object sender, EventArgs e)
        {

        }

        private void cBox_Name_gasoline_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;
            tBox_Price_gasoline.Text = oils[index].Price.ToString();
        }

        private void tBox_number_gasoline_TextChanged(object sender, EventArgs e)
        {
            if (tBox_number_gasoline.Text != "")
            {
                string pattern = @"^\d{1,5}.?\d?\d?$";
                Regex regex = new Regex(pattern);
                if (!regex.IsMatch(tBox_number_gasoline.Text))
                {
                    tBox_number_gasoline.Text = tBox_number_gasoline.Text.Remove(tBox_number_gasoline.Text.Length - 1);
                    tBox_number_gasoline.SelectionStart = tBox_number_gasoline.Text.Length;
                }
                calcSumGasoline();
            }
        }

        private void tBox_sum_gasoline_TextChanged(object sender, EventArgs e)
        {
            calcSumGasoline();
        }

        private void rB1_number_gasoline_CheckedChanged(object sender, EventArgs e)
        {
            tBox_number_gasoline.Enabled = rB1_number_gasoline.Checked;
            tBox_sum_gasoline.Text = "";
        }

        private void rB_sum_gasoline_CheckedChanged(object sender, EventArgs e)
        {
            tBox_sum_gasoline.Enabled = rB_sum_gasoline.Checked;
            tBox_number_gasoline.Text = "";
        }


        void calcSumGasoline()
        {
            decimal sumGas = 0;
            if (rB1_number_gasoline.Checked)
            {
                sumGas = Convert.ToDecimal(tBox_sum_gasoline.Text) *
                    Convert.ToDecimal(tBox_Price_gasoline.Text);

            }
            if (rB_sum_gasoline.Checked)
            {
                decimal volume = Convert.ToDecimal(tBox_sum_gasoline.Text) /
                    Convert.ToDecimal(tBox_Price_gasoline.Text);
                tBox_number_gasoline.Text = volume.ToString();
            }

            tBox_payable_gasoline.Text = sumGas.ToString();
        }


    }

    internal class Oil
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}