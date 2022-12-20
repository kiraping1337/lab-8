namespace Lab8
{
    partial class Function1
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
            this.f = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReadB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReadUserResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Calculation = new System.Windows.Forms.Button();
            this.Attemp = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.White;
            this.f.BackgroundImage = global::Lab8.Properties.Resources.Function;
            this.f.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.f.Location = new System.Drawing.Point(12, 12);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(333, 270);
            this.f.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(377, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите значение числа a:";
            // 
            // ReadA
            // 
            this.ReadA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReadA.Location = new System.Drawing.Point(377, 37);
            this.ReadA.Name = "ReadA";
            this.ReadA.Size = new System.Drawing.Size(242, 29);
            this.ReadA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(377, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите значение числа b:";
            // 
            // ReadB
            // 
            this.ReadB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReadB.Location = new System.Drawing.Point(377, 109);
            this.ReadB.Name = "ReadB";
            this.ReadB.Size = new System.Drawing.Size(242, 29);
            this.ReadB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(377, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите ваш ответ:";
            // 
            // ReadUserResult
            // 
            this.ReadUserResult.Enabled = false;
            this.ReadUserResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReadUserResult.Location = new System.Drawing.Point(377, 181);
            this.ReadUserResult.Name = "ReadUserResult";
            this.ReadUserResult.Size = new System.Drawing.Size(242, 29);
            this.ReadUserResult.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(377, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Правильный ответ:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(377, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Осталось попыток:";
            this.label5.Visible = false;
            // 
            // Calculation
            // 
            this.Calculation.BackColor = System.Drawing.Color.White;
            this.Calculation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Calculation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Calculation.Location = new System.Drawing.Point(664, 37);
            this.Calculation.Name = "Calculation";
            this.Calculation.Size = new System.Drawing.Size(124, 29);
            this.Calculation.TabIndex = 9;
            this.Calculation.Text = "Посчитать";
            this.Calculation.UseVisualStyleBackColor = false;
            this.Calculation.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // Attemp
            // 
            this.Attemp.BackColor = System.Drawing.Color.White;
            this.Attemp.Enabled = false;
            this.Attemp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Attemp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Attemp.Location = new System.Drawing.Point(664, 109);
            this.Attemp.Name = "Attemp";
            this.Attemp.Size = new System.Drawing.Size(124, 29);
            this.Attemp.TabIndex = 10;
            this.Attemp.Text = "Угадать";
            this.Attemp.UseVisualStyleBackColor = false;
            this.Attemp.Click += new System.EventHandler(this.Attemp_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(664, 181);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(124, 29);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Function1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(167)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 294);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Attemp);
            this.Controls.Add(this.Calculation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReadUserResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReadB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReadA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f);
            this.Name = "Function1";
            this.Text = "Угадай ответ";
            this.Load += new System.EventHandler(this.Function1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel f;
        private Label label1;
        private TextBox ReadA;
        private Label label2;
        private TextBox ReadB;
        private Label label3;
        private TextBox ReadUserResult;
        private Label label4;
        private Label label5;
        private Button Calculation;
        private Button Attemp;
        private Button Clear;
    }
}