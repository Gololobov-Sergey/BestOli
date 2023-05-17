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
            del = new Button();
            edit = new Button();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gBox_Price_gasoline = new GroupBox();
            tBox_payable_gasoline = new Label();
            label4 = new Label();
            tBox_Price_gasoline = new TextBox();
            add = new Button();
            rB_sum_gasoline = new RadioButton();
            rB1_number_gasoline = new RadioButton();
            lPrice_gasoline = new Label();
            cBox_Name_gasoline = new ComboBox();
            lName_gasoline = new Label();
            gBox_Kafe = new GroupBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label5 = new Label();
            gBox_Price = new GroupBox();
            but_payable = new Button();
            label6 = new Label();
            tBox_payable = new TextBox();
            tBox_payable_пф = new TextBox();
            gBox_Gas_station.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            gBox_Price_gasoline.SuspendLayout();
            gBox_Kafe.SuspendLayout();
            groupBox1.SuspendLayout();
            gBox_Price.SuspendLayout();
            SuspendLayout();
            // 
            // gBox_Gas_station
            // 
            gBox_Gas_station.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gBox_Gas_station.Controls.Add(del);
            gBox_Gas_station.Controls.Add(edit);
            gBox_Gas_station.Controls.Add(numericUpDown2);
            gBox_Gas_station.Controls.Add(numericUpDown1);
            gBox_Gas_station.Controls.Add(label3);
            gBox_Gas_station.Controls.Add(label2);
            gBox_Gas_station.Controls.Add(label1);
            gBox_Gas_station.Controls.Add(gBox_Price_gasoline);
            gBox_Gas_station.Controls.Add(tBox_Price_gasoline);
            gBox_Gas_station.Controls.Add(add);
            gBox_Gas_station.Controls.Add(rB_sum_gasoline);
            gBox_Gas_station.Controls.Add(rB1_number_gasoline);
            gBox_Gas_station.Controls.Add(lPrice_gasoline);
            gBox_Gas_station.Controls.Add(cBox_Name_gasoline);
            gBox_Gas_station.Controls.Add(lName_gasoline);
            gBox_Gas_station.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gBox_Gas_station.ForeColor = SystemColors.WindowText;
            gBox_Gas_station.Location = new Point(20, 21);
            gBox_Gas_station.Name = "gBox_Gas_station";
            gBox_Gas_station.Size = new Size(295, 415);
            gBox_Gas_station.TabIndex = 0;
            gBox_Gas_station.TabStop = false;
            gBox_Gas_station.Text = "Автозаправка";
            // 
            // del
            // 
            del.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            del.Location = new Point(192, 128);
            del.Name = "del";
            del.Size = new Size(88, 32);
            del.TabIndex = 19;
            del.Text = "del";
            del.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            edit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            edit.Location = new Point(96, 128);
            edit.Name = "edit";
            edit.Size = new Size(88, 32);
            edit.TabIndex = 18;
            edit.Text = "edit";
            edit.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Enabled = false;
            numericUpDown2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown2.Location = new Point(119, 236);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(112, 27);
            numericUpDown2.TabIndex = 17;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Location = new Point(119, 190);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(114, 27);
            numericUpDown1.TabIndex = 15;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(253, 192);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 16;
            label3.Text = "л";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(237, 243);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 15;
            label2.Text = "грн";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(239, 84);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 14;
            label1.Text = "грн";
            // 
            // gBox_Price_gasoline
            // 
            gBox_Price_gasoline.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gBox_Price_gasoline.Controls.Add(tBox_payable_gasoline);
            gBox_Price_gasoline.Controls.Add(label4);
            gBox_Price_gasoline.Location = new Point(13, 282);
            gBox_Price_gasoline.Name = "gBox_Price_gasoline";
            gBox_Price_gasoline.Size = new Size(263, 117);
            gBox_Price_gasoline.TabIndex = 13;
            gBox_Price_gasoline.TabStop = false;
            gBox_Price_gasoline.Text = "До сплати";
            // 
            // tBox_payable_gasoline
            // 
            tBox_payable_gasoline.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            tBox_payable_gasoline.Location = new Point(44, 50);
            tBox_payable_gasoline.Name = "tBox_payable_gasoline";
            tBox_payable_gasoline.Size = new Size(186, 60);
            tBox_payable_gasoline.TabIndex = 17;
            tBox_payable_gasoline.Text = "0.00";
            tBox_payable_gasoline.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 83);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 16;
            label4.Text = "грн";
            // 
            // tBox_Price_gasoline
            // 
            tBox_Price_gasoline.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Price_gasoline.Location = new Point(93, 81);
            tBox_Price_gasoline.Name = "tBox_Price_gasoline";
            tBox_Price_gasoline.ReadOnly = true;
            tBox_Price_gasoline.Size = new Size(140, 27);
            tBox_Price_gasoline.TabIndex = 9;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(0, 128);
            add.Name = "add";
            add.Size = new Size(88, 32);
            add.TabIndex = 8;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // rB_sum_gasoline
            // 
            rB_sum_gasoline.AutoSize = true;
            rB_sum_gasoline.Location = new Point(22, 239);
            rB_sum_gasoline.Name = "rB_sum_gasoline";
            rB_sum_gasoline.Size = new Size(67, 24);
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
            rB1_number_gasoline.Size = new Size(95, 24);
            rB1_number_gasoline.TabIndex = 4;
            rB1_number_gasoline.TabStop = true;
            rB1_number_gasoline.Text = "Кількість";
            rB1_number_gasoline.UseVisualStyleBackColor = true;
            rB1_number_gasoline.CheckedChanged += rB1_number_gasoline_CheckedChanged;
            // 
            // lPrice_gasoline
            // 
            lPrice_gasoline.AutoSize = true;
            lPrice_gasoline.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lPrice_gasoline.ForeColor = SystemColors.WindowText;
            lPrice_gasoline.Location = new Point(6, 84);
            lPrice_gasoline.Name = "lPrice_gasoline";
            lPrice_gasoline.Size = new Size(42, 20);
            lPrice_gasoline.TabIndex = 2;
            lPrice_gasoline.Text = "Ціна";
            // 
            // cBox_Name_gasoline
            // 
            cBox_Name_gasoline.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_Name_gasoline.FormattingEnabled = true;
            cBox_Name_gasoline.Location = new Point(93, 34);
            cBox_Name_gasoline.Name = "cBox_Name_gasoline";
            cBox_Name_gasoline.Size = new Size(183, 28);
            cBox_Name_gasoline.TabIndex = 1;
            cBox_Name_gasoline.SelectedIndexChanged += cBox_Name_gasoline_SelectedIndexChanged;
            // 
            // lName_gasoline
            // 
            lName_gasoline.AutoSize = true;
            lName_gasoline.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lName_gasoline.ForeColor = SystemColors.ActiveCaptionText;
            lName_gasoline.Location = new Point(6, 38);
            lName_gasoline.Name = "lName_gasoline";
            lName_gasoline.Size = new Size(65, 20);
            lName_gasoline.TabIndex = 0;
            lName_gasoline.Text = "Бензин ";
            // 
            // gBox_Kafe
            // 
            gBox_Kafe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gBox_Kafe.Controls.Add(panel1);
            gBox_Kafe.Controls.Add(groupBox1);
            gBox_Kafe.Location = new Point(334, 21);
            gBox_Kafe.Name = "gBox_Kafe";
            gBox_Kafe.Size = new Size(422, 415);
            gBox_Kafe.TabIndex = 1;
            gBox_Kafe.TabStop = false;
            gBox_Kafe.Text = "Кафе";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Location = new Point(13, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 209);
            panel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(13, 282);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 117);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "До сплати";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(177, 43);
            label7.Name = "label7";
            label7.Size = new Size(177, 60);
            label7.TabIndex = 18;
            label7.Text = "0.00";
            label7.TextAlign = ContentAlignment.MiddleRight;
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
            // gBox_Price
            // 
            gBox_Price.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gBox_Price.Controls.Add(but_payable);
            gBox_Price.Controls.Add(label6);
            gBox_Price.Controls.Add(tBox_payable);
            gBox_Price.Location = new Point(20, 456);
            gBox_Price.Name = "gBox_Price";
            gBox_Price.Size = new Size(736, 165);
            gBox_Price.TabIndex = 2;
            gBox_Price.TabStop = false;
            gBox_Price.Text = "Повна оплата";
            // 
            // but_payable
            // 
            but_payable.Location = new Point(80, 70);
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
            label6.Location = new Point(687, 108);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 18;
            label6.Text = "грн";
            // 
            // tBox_payable
            // 
            tBox_payable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tBox_payable.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            tBox_payable.Location = new Point(449, 58);
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
            ClientSize = new Size(782, 633);
            Controls.Add(gBox_Price);
            Controls.Add(gBox_Kafe);
            Controls.Add(gBox_Gas_station);
            MaximizeBox = false;
            MaximumSize = new Size(800, 680);
            MinimumSize = new Size(800, 680);
            Name = "Form_Oli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BestOli";
            gBox_Gas_station.ResumeLayout(false);
            gBox_Gas_station.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            gBox_Price_gasoline.ResumeLayout(false);
            gBox_Price_gasoline.PerformLayout();
            gBox_Kafe.ResumeLayout(false);
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
        private Button add;
        private RadioButton rB_sum_gasoline;
        private RadioButton rB1_number_gasoline;
        private TextBox tBox_Price_gasoline;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gBox_Price_gasoline;
        private Label label4;
        private TextBox tBox_payable_пф;
        private GroupBox groupBox1;
        private Label label5;
        private Label label6;
        private TextBox tBox_payable;
        private Button but_payable;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label tBox_payable_gasoline;
        private Panel panel1;
        private Label label7;
        private Button del;
        private Button edit;
    }
}