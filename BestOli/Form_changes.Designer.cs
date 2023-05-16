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
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.but_save = new System.Windows.Forms.Button();
            this.but_censel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
            // 
            // tBox_Name
            // 
            this.tBox_Name.Location = new System.Drawing.Point(176, 113);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(207, 27);
            this.tBox_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(221, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Зміна";
            // 
            // tBox_price
            // 
            this.tBox_price.Location = new System.Drawing.Point(176, 161);
            this.tBox_price.Name = "tBox_price";
            this.tBox_price.Size = new System.Drawing.Size(207, 27);
            this.tBox_price.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ціна";
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(176, 213);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(94, 29);
            this.but_save.TabIndex = 5;
            this.but_save.Text = "Зберегти";
            this.but_save.UseVisualStyleBackColor = true;
            // 
            // but_censel
            // 
            this.but_censel.Location = new System.Drawing.Point(289, 213);
            this.but_censel.Name = "but_censel";
            this.but_censel.Size = new System.Drawing.Size(94, 29);
            this.but_censel.TabIndex = 6;
            this.but_censel.Text = "Відміна";
            this.but_censel.UseVisualStyleBackColor = true;
            // 
            // Form_changes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 395);
            this.Controls.Add(this.but_censel);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.tBox_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(578, 442);
            this.Name = "Form_changes";
            this.Text = "Form_changes";
            this.ResumeLayout(false);
            this.PerformLayout();

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