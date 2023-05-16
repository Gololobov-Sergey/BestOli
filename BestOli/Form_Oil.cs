using System.Text.RegularExpressions;

namespace BestOli
{
    public partial class Form_Oli : Form
    {
        List<Oil> oils = new List<Oil>();
        List<Product> products = new List<Product>();

        List<RecordsProduct> records = new List<RecordsProduct>();

        public Form_Oli()
        {
            InitializeComponent();

            oils.Add(new Oil { Name = "Бензин А-95", Price = 50.35M });
            oils.Add(new Oil { Name = "Бензин А-98", Price = 55.32M });
            oils.Add(new Oil { Name = "Бензин А-98 ЕВРО", Price = 60.35M });
            oils.Add(new Oil { Name = "Газ", Price = 21.10M });
            oils.Add(new Oil { Name = "Дизель", Price = 45.30M });

            products.Add(new Product { Name = "Чай", Price = 10M });
            products.Add(new Product { Name = "Кофе", Price = 20M });
            products.Add(new Product { Name = "Булочка", Price = 8M });
            products.Add(new Product { Name = "Кока-Кола", Price = 15M });

            cBox_Name_gasoline.Items.AddRange(oils.Select(o => o.Name).ToArray());
            cBox_Name_gasoline.SelectedIndex = 0;

            for (int i = 0; i < products.Count; i++)
            {
                CheckBox ch = new CheckBox();
                ch.Location = new Point(13, 20 + i * 35);
                ch.Size = new Size(160, 24);
                ch.Text = products[i].Name;
                ch.CheckedChanged += Ch_CheckedChanged;

                TextBox tb = new TextBox();
                tb.Location = new Point(194, 20 + i * 35);
                tb.Text = products[i].Price.ToString();
                tb.ReadOnly = true;
                tb.Size = new Size(80, 24);
                tb.TextAlign = HorizontalAlignment.Right;

                NumericUpDown num = new NumericUpDown();
                num.Location = new Point(300, 20 + i * 35);
                num.Size = new Size(68, 24);
                num.Enabled = false;
                num.Minimum = 0;
                num.Maximum = 1000;
                num.Value = 0;
                num.ValueChanged += Num_ValueChanged;

                panel1.Controls.Add(ch);
                panel1.Controls.Add(tb);
                panel1.Controls.Add(num);

                RecordsProduct rp = new RecordsProduct
                {
                    checkBox_Name = ch,
                    tBox_Price = tb,
                    numUpDown_Number = num
                };

                records.Add(rp);
            }
        }

        private void Num_ValueChanged(object? sender, EventArgs e)
        {

        }

        private void Ch_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            int ind = records.FindIndex(r => r.checkBox_Name == cb);
            records[ind].numUpDown_Number.Enabled = cb.Checked;
            if (cb.Checked == false)
            {
                records[ind].numUpDown_Number.Value = 0;
            }
        }

        private void but_payable_Click(object sender, EventArgs e)
        {

        }

        private void cBox_Name_gasoline_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;
            tBox_Price_gasoline.Text = oils[index].Price.ToString();
            calcSumGasoline();
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

    internal class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    internal class Oil
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }


    class RecordsProduct
    {
        public CheckBox checkBox_Name { get; set; }
        public TextBox tBox_Price { get; set; }
        public NumericUpDown numUpDown_Number { get; set; }
    }
}