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

        private void rB1_number_gasoline_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = rB1_number_gasoline.Checked;
            numericUpDown2.Value = 0;
        }

        private void rB_sum_gasoline_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown2.Enabled = rB_sum_gasoline.Checked;
            numericUpDown1.Value = 0;
        }


        void calcSumGasoline()
        {
            decimal sumGas = 0;
            decimal volume = 0;
            if (rB1_number_gasoline.Checked)
            {
                sumGas = numericUpDown1.Value *
                    Convert.ToDecimal(tBox_Price_gasoline.Text);
                numericUpDown2.Value = sumGas;
            }
            if (rB_sum_gasoline.Checked)
            {
                volume = numericUpDown2.Value /
                    Convert.ToDecimal(tBox_Price_gasoline.Text);
                numericUpDown1.Value = volume;

                sumGas = numericUpDown2.Value;
            }

            tBox_payable_gasoline.Text = Math.Round(sumGas, 2).ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            calcSumGasoline();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            calcSumGasoline();
        }
    }

    internal class Oil
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}