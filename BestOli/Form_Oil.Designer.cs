namespace BestOli
{
    partial class Form_Oli
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gBox_Gas_station = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gBox_Price_gasoline = new GroupBox();
            label4 = new Label();
            tBox_payable_gasoline = new TextBox();
            tBox_sum_gasoline = new TextBox();
            tBox_number_gasoline = new TextBox();
            tBox_Price_gasoline = new TextBox();
            but_change_gasoline = new Button();
            rB_sum_gasoline = new RadioButton();
            rB1_number_gasoline = new RadioButton();
            lPrice_gasoline = new Label();
            cBox_Name_gasoline = new ComboBox();
            lName_gasoline = new Label();
            gBox_Kafe = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            groupBox1 = new GroupBox();
            label5 = new Label();
            tBox_payable_kafe = new TextBox();
            gBox_Price = new GroupBox();
            but_payable = new Button();
            label6 = new Label();
            tBox_payable = new TextBox();
            tBox_payable_пф = new TextBox();
            gBox_Gas_station.SuspendLayout();
            gBox_Price_gasoline.SuspendLayout();
            gBox_Kafe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            gBox_Price.SuspendLayout();
            SuspendLayout();
            // 
            // gBox_Gas_station
            // 
            gBox_Gas_station.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gBox_Gas_station.Controls.Add(label3);
            gBox_Gas_station.Controls.Add(label2);
            gBox_Gas_station.Controls.Add(label1);
            gBox_Gas_station.Controls.Add(gBox_Price_gasoline);
            gBox_Gas_station.Controls.Add(tBox_sum_gasoline);
            gBox_Gas_station.Controls.Add(tBox_number_gasoline);
            gBox_Gas_station.Controls.Add(tBox_Price_gasoline);
            gBox_Gas_station.Controls.Add(but_change_gasoline);
            gBox_Gas_station.Controls.Add(rB_sum_gasoline);
            gBox_Gas_station.Controls.Add(rB1_number_gasoline);
            gBox_Gas_station.Controls.Add(lPrice_gasoline);
            gBox_Gas_station.Controls.Add(cBox_Name_gasoline);
            gBox_Gas_station.Controls.Add(lName_gasoline);
            gBox_Gas_station.ForeColor = SystemColors.WindowText;
            gBox_Gas_station.Location = new Point(20, 21);
            gBox_Gas_station.Name = "gBox_Gas_station";
            gBox_Gas_station.Size = new Size(425, 415);
            gBox_Gas_station.TabIndex = 0;
            gBox_Gas_station.TabStop = false;
            gBox_Gas_station.Text = "Автозаправка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 197);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 16;
            label3.Text = "л";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 246);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 15;
            label2.Text = "грн";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 89);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 14;
            label1.Text = "грн";
            // 
            // gBox_Price_gasoline
            // 
            gBox_Price_gasoline.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gBox_Price_gasoline.Controls.Add(label4);
            gBox_Price_gasoline.Controls.Add(tBox_payable_gasoline);
            gBox_Price_gasoline.Location = new Point(13, 282);
            gBox_Price_gasoline.Name = "gBox_Price_gasoline";
            gBox_Price_gasoline.Size = new Size(395, 117);
            gBox_Price_gasoline.TabIndex = 13;
            gBox_Price_gasoline.TabStop = false;
            gBox_Price_gasoline.Text = "До сплати";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 76);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 16;
            label4.Text = "грн";
            // 
            // tBox_payable_gasoline
            // 
            tBox_payable_gasoline.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tBox_payable_gasoline.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            tBox_payable_gasoline.Location = new Point(132, 26);
            tBox_payable_gasoline.Name = "tBox_payable_gasoline";
            tBox_payable_gasoline.ReadOnly = true;
            tBox_payable_gasoline.Size = new Size(222, 70);
            tBox_payable_gasoline.TabIndex = 12;
            // 
            // tBox_sum_gasoline
            // 
            tBox_sum_gasoline.Enabled = false;
            tBox_sum_gasoline.Location = new Point(150, 239);
            tBox_sum_gasoline.Name = "tBox_sum_gasoline";
            tBox_sum_gasoline.Size = new Size(158, 27);
            tBox_sum_gasoline.TabIndex = 11;
            tBox_sum_gasoline.TextChanged += tBox_sum_gasoline_TextChanged;
            // 
            // tBox_number_gasoline
            // 
            tBox_number_gasoline.Location = new Point(150, 190);
            tBox_number_gasoline.Name = "tBox_number_gasoline";
            tBox_number_gasoline.Size = new Size(158, 27);
            tBox_number_gasoline.TabIndex = 10;
            tBox_number_gasoline.TextChanged += tBox_number_gasoline_TextChanged;
            // 
            // tBox_Price_gasoline
            // 
            tBox_Price_gasoline.Location = new Point(93, 82);
            tBox_Price_gasoline.Name = "tBox_Price_gasoline";
            tBox_Price_gasoline.ReadOnly = true;
            tBox_Price_gasoline.Size = new Size(215, 27);
            tBox_Price_gasoline.TabIndex = 9;
            // 
            // but_change_gasoline
            // 
            but_change_gasoline.Location = new Point(326, 35);
            but_change_gasoline.Name = "but_change_gasoline";
            but_change_gasoline.Size = new Size(82, 29);
            but_change_gasoline.TabIndex = 8;
            but_change_gasoline.Text = "змінити";
            but_change_gasoline.UseVisualStyleBackColor = true;
            but_change_gasoline.Visible = false;
            // 
            // rB_sum_gasoline
            // 
            rB_sum_gasoline.AutoSize = true;
            rB_sum_gasoline.Location = new Point(22, 239);
            rB_sum_gasoline.Name = "rB_sum_gasoline";
            rB_sum_gasoline.Size = new Size(65, 24);
            rB_sum_gasoline.TabIndex = 5;
            rB_sum_gasoline.Text = "Сума";
            rB_sum_gasoline.UseVisualStyleBackColor = true;
            rB_sum_gasoline.CheckedChanged += rB_sum_gasoline_CheckedChanged;
            // 
            // rB1_number_gasoline
            // 
            rB1_number_gasoline.AutoSize = true;
            rB1_number_gasoline.Checked = true;
            rB1_number_gasoline.Location = new Point(22, 193);
            rB1_number_gasoline.Name = "rB1_number_gasoline";
            rB1_number_gasoline.Size = new Size(91, 24);
            rB1_number_gasoline.TabIndex = 4;
            rB1_number_gasoline.TabStop = true;
            rB1_number_gasoline.Text = "Кількість";
            rB1_number_gasoline.UseVisualStyleBackColor = true;
            rB1_number_gasoline.CheckedChanged += rB1_number_gasoline_CheckedChanged;
            // 
            // lPrice_gasoline
            // 
            lPrice_gasoline.AutoSize = true;
            lPrice_gasoline.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lPrice_gasoline.ForeColor = SystemColors.WindowText;
            lPrice_gasoline.Location = new Point(6, 84);
            lPrice_gasoline.Name = "lPrice_gasoline";
            lPrice_gasoline.Size = new Size(53, 25);
            lPrice_gasoline.TabIndex = 2;
            lPrice_gasoline.Text = "Ціна";
            // 
            // cBox_Name_gasoline
            // 
            cBox_Name_gasoline.FormattingEnabled = true;
            cBox_Name_gasoline.Location = new Point(93, 35);
            cBox_Name_gasoline.Name = "cBox_Name_gasoline";
            cBox_Name_gasoline.Size = new Size(215, 28);
            cBox_Name_gasoline.TabIndex = 1;
            cBox_Name_gasoline.SelectedIndexChanged += cBox_Name_gasoline_SelectedIndexChanged;
            // 
            // lName_gasoline
            // 
            lName_gasoline.AutoSize = true;
            lName_gasoline.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lName_gasoline.ForeColor = SystemColors.ActiveCaptionText;
            lName_gasoline.Location = new Point(6, 38);
            lName_gasoline.Name = "lName_gasoline";
            lName_gasoline.Size = new Size(81, 25);
            lName_gasoline.TabIndex = 0;
            lName_gasoline.Text = "Бензин ";
            // 
            // gBox_Kafe
            // 
            gBox_Kafe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gBox_Kafe.Controls.Add(numericUpDown1);
            gBox_Kafe.Controls.Add(groupBox1);
            gBox_Kafe.Location = new Point(470, 21);
            gBox_Kafe.Name = "gBox_Kafe";
            gBox_Kafe.Size = new Size(423, 415);
            gBox_Kafe.TabIndex = 1;
            gBox_Kafe.TabStop = false;
            gBox_Kafe.Text = "Кафе";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Location = new Point(72, 90);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tBox_payable_kafe);
            groupBox1.Location = new Point(13, 282);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 117);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "До сплати";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 76);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 16;
            label5.Text = "грн";
            // 
            // tBox_payable_kafe
            // 
            tBox_payable_kafe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tBox_payable_kafe.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            tBox_payable_kafe.Location = new Point(132, 26);
            tBox_payable_kafe.Name = "tBox_payable_kafe";
            tBox_payable_kafe.ReadOnly = true;
            tBox_payable_kafe.Size = new Size(222, 70);
            tBox_payable_kafe.TabIndex = 12;
            // 
            // gBox_Price
            // 
            gBox_Price.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gBox_Price.Controls.Add(but_payable);
            gBox_Price.Controls.Add(label6);
            gBox_Price.Controls.Add(tBox_payable);
            gBox_Price.Location = new Point(20, 456);
            gBox_Price.Name = "gBox_Price";
            gBox_Price.Size = new Size(873, 165);
            gBox_Price.TabIndex = 2;
            gBox_Price.TabStop = false;
            gBox_Price.Text = "Повна оплата";
            // 
            // but_payable
            // 
            but_payable.Location = new Point(210, 58);
            but_payable.Name = "but_payable";
            but_payable.Size = new Size(215, 70);
            but_payable.TabIndex = 19;
            but_payable.Text = "Оплата";
            but_payable.UseVisualStyleBackColor = true;
            but_payable.Click += but_payable_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(762, 108);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 18;
            label6.Text = "грн";
            // 
            // tBox_payable
            // 
            tBox_payable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tBox_payable.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            tBox_payable.Location = new Point(534, 58);
            tBox_payable.Name = "tBox_payable";
            tBox_payable.ReadOnly = true;
            tBox_payable.Size = new Size(222, 70);
            tBox_payable.TabIndex = 17;
            // 
            // tBox_payable_пф
            // 
            tBox_payable_пф.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tBox_payable_пф.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            tBox_payable_пф.Location = new Point(132, 26);
            tBox_payable_пф.Name = "tBox_payable_пф";
            tBox_payable_пф.Size = new Size(222, 70);
            tBox_payable_пф.TabIndex = 12;
            // 
            // Form_Oli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 633);
            Controls.Add(gBox_Price);
            Controls.Add(gBox_Kafe);
            Controls.Add(gBox_Gas_station);
            MaximumSize = new Size(1000, 1000);
            MinimumSize = new Size(900, 680);
            Name = "Form_Oli";
            Text = "BestOli";
            gBox_Gas_station.ResumeLayout(false);
            gBox_Gas_station.PerformLayout();
            gBox_Price_gasoline.ResumeLayout(false);
            gBox_Price_gasoline.PerformLayout();
            gBox_Kafe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gBox_Price.ResumeLayout(false);
            gBox_Price.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBox_Gas_station;
        private GroupBox gBox_Kafe;
        private GroupBox gBox_Price;
        private ComboBox cBox_Name_gasoline;
        private Label lName_gasoline;
        private Label lPrice_gasoline;
        private Button but_change_gasoline;
        private RadioButton rB_sum_gasoline;
        private RadioButton rB1_number_gasoline;
        private TextBox tBox_sum_gasoline;
        private TextBox tBox_number_gasoline;
        private TextBox tBox_Price_gasoline;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gBox_Price_gasoline;
        private TextBox tBox_payable_gasoline;
        private Label label4;
        private TextBox tBox_payable_пф;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox tBox_payable_kafe;
        private Label label6;
        private TextBox tBox_payable;
        private Button but_payable;
        private NumericUpDown numericUpDown1;
    }
}