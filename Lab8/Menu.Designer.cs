namespace Lab8
{
    partial class Menu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Function1 = new System.Windows.Forms.Button();
            this.Function2 = new System.Windows.Forms.Button();
            this.Function3 = new System.Windows.Forms.Button();
            this.Function4 = new System.Windows.Forms.Button();
            this.Function5 = new System.Windows.Forms.Button();
            this.Function6 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab8.Properties.Resources.IconLab;
            this.pictureBox1.Location = new System.Drawing.Point(50, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Function1
            // 
            this.Function1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(167)))), ((int)(((byte)(219)))));
            this.Function1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Function1.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Function1.Location = new System.Drawing.Point(50, 116);
            this.Function1.Name = "Function1";
            this.Function1.Size = new System.Drawing.Size(166, 49);
            this.Function1.TabIndex = 1;
            this.Function1.Text = "Угадай ответ";
            this.Function1.UseVisualStyleBackColor = false;
            this.Function1.Click += new System.EventHandler(this.Function1_Click);
            // 
            // Function2
            // 
            this.Function2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(167)))), ((int)(((byte)(219)))));
            this.Function2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Function2.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Function2.Location = new System.Drawing.Point(51, 180);
            this.Function2.Name = "Function2";
            this.Function2.Size = new System.Drawing.Size(166, 49);
            this.Function2.TabIndex = 2;
            this.Function2.Text = "Информация об авторе";
            this.Function2.UseVisualStyleBackColor = false;
            this.Function2.Click += new System.EventHandler(this.Function2_Click);
            // 
            // Function3
            // 
            this.Function3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(167)))), ((int)(((byte)(219)))));
            this.Function3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Function3.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Function3.Location = new System.Drawing.Point(51, 244);
            this.Function3.Name = "Function3";
            this.Function3.Size = new System.Drawing.Size(166, 49);
            this.Function3.TabIndex = 3;
            this.Function3.Text = "Сортировка";
            this.Function3.UseVisualStyleBackColor = false;
            this.Function3.Click += new System.EventHandler(this.Function3_Click);
            // 
            // Function4
            // 
            this.Function4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(167)))), ((int)(((byte)(219)))));
            this.Function4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Function4.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Function4.Location = new System.Drawing.Point(51, 308);
            this.Function4.Name = "Function4";
            this.Function4.Size = new System.Drawing.Size(166, 49);
            this.Function4.TabIndex = 4;
            this.Function4.Text = "Крестики нолики 3х3";
            this.Function4.UseVisualStyleBackColor = false;
            this.Function4.Click += new System.EventHandler(this.Function4_Click);
            // 
            // Function5
            // 
            this.Function5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(167)))), ((int)(((byte)(219)))));
            this.Function5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Function5.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Function5.Location = new System.Drawing.Point(50, 374);
            this.Function5.Name = "Function5";
            this.Function5.Size = new System.Drawing.Size(166, 49);
            this.Function5.TabIndex = 5;
            this.Function5.Text = "Работа со строками";
            this.Function5.UseVisualStyleBackColor = false;
            this.Function5.Click += new System.EventHandler(this.Function5_Click);
            // 
            // Function6
            // 
            this.Function6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(167)))), ((int)(((byte)(219)))));
            this.Function6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Function6.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Function6.Location = new System.Drawing.Point(50, 443);
            this.Function6.Name = "Function6";
            this.Function6.Size = new System.Drawing.Size(166, 49);
            this.Function6.TabIndex = 6;
            this.Function6.Text = "Try catch finally";
            this.Function6.UseVisualStyleBackColor = false;
            this.Function6.Click += new System.EventHandler(this.Function6_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(167)))), ((int)(((byte)(219)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.Location = new System.Drawing.Point(50, 511);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(166, 49);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.BackgroundImage = global::Lab8.Properties.Resources.MenuTexture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(268, 580);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Function6);
            this.Controls.Add(this.Function5);
            this.Controls.Add(this.Function4);
            this.Controls.Add(this.Function3);
            this.Controls.Add(this.Function2);
            this.Controls.Add(this.Function1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button Function1;
        private Button Function2;
        private Button Function3;
        private Button Function4;
        private Button Function5;
        private Button Function6;
        private Button Exit;
    }
}