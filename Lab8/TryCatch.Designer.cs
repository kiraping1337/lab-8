namespace Lab8
{
    partial class TryCatch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReadX = new System.Windows.Forms.TextBox();
            this.ReadY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::Lab8.Properties.Resources.TryCatchFunction;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 100);
            this.panel1.TabIndex = 0;
            // 
            // ReadX
            // 
            this.ReadX.Location = new System.Drawing.Point(25, 150);
            this.ReadX.Name = "ReadX";
            this.ReadX.Size = new System.Drawing.Size(114, 23);
            this.ReadX.TabIndex = 1;
            // 
            // ReadY
            // 
            this.ReadY.Location = new System.Drawing.Point(165, 150);
            this.ReadY.Name = "ReadY";
            this.ReadY.Size = new System.Drawing.Size(117, 23);
            this.ReadY.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(25, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Значение X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(165, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Значение Y:";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(25, 240);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(61, 18);
            this.Result.TabIndex = 6;
            this.Result.Text = "Ответ:";
            this.Result.Visible = false;
            // 
            // TryCatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(167)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(315, 276);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReadY);
            this.Controls.Add(this.ReadX);
            this.Controls.Add(this.panel1);
            this.Name = "TryCatch";
            this.Text = "TryCatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox ReadX;
        private TextBox ReadY;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label Result;
    }
}