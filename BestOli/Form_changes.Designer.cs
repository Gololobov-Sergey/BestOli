namespace BestOli
{
    partial class Form_changes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tBox_Name = new TextBox();
            label2 = new Label();
            tBox_price = new TextBox();
            label3 = new Label();
            but_save = new Button();
            but_censel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 120);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Назва";
            // 
            // tBox_Name
            // 
            tBox_Name.Location = new Point(176, 113);
            tBox_Name.Name = "tBox_Name";
            tBox_Name.Size = new Size(207, 27);
            tBox_Name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(221, 71);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 2;
            label2.Text = "Зміна";
            // 
            // tBox_price
            // 
            tBox_price.Location = new Point(176, 161);
            tBox_price.Name = "tBox_price";
            tBox_price.Size = new Size(207, 27);
            tBox_price.TabIndex = 4;
            tBox_price.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 168);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 3;
            label3.Text = "Ціна";
            // 
            // but_save
            // 
            but_save.DialogResult = DialogResult.OK;
            but_save.Location = new Point(176, 213);
            but_save.Name = "but_save";
            but_save.Size = new Size(94, 29);
            but_save.TabIndex = 5;
            but_save.Text = "Зберегти";
            but_save.UseVisualStyleBackColor = true;
            // 
            // but_censel
            // 
            but_censel.DialogResult = DialogResult.Cancel;
            but_censel.Location = new Point(289, 213);
            but_censel.Name = "but_censel";
            but_censel.Size = new Size(94, 29);
            but_censel.TabIndex = 6;
            but_censel.Text = "Відміна";
            but_censel.UseVisualStyleBackColor = true;
            // 
            // Form_changes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 395);
            Controls.Add(but_censel);
            Controls.Add(but_save);
            Controls.Add(tBox_price);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tBox_Name);
            Controls.Add(label1);
            MaximumSize = new Size(578, 442);
            Name = "Form_changes";
            Text = "Form_changes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tBox_Name;
        private Label label2;
        private TextBox tBox_price;
        private Label label3;
        private Button but_save;
        private Button but_censel;
    }
}