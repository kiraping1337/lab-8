namespace Lab8
{
    partial class Strings
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
            this.Str1 = new System.Windows.Forms.RichTextBox();
            this.Str2 = new System.Windows.Forms.RichTextBox();
            this.Str3 = new System.Windows.Forms.RichTextBox();
            this.LowerUpperStr = new System.Windows.Forms.Button();
            this.PunctuationStr = new System.Windows.Forms.Button();
            this.Str2And3Op = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Str1
            // 
            this.Str1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Str1.Location = new System.Drawing.Point(12, 41);
            this.Str1.Name = "Str1";
            this.Str1.Size = new System.Drawing.Size(302, 246);
            this.Str1.TabIndex = 0;
            this.Str1.Text = "";
            // 
            // Str2
            // 
            this.Str2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Str2.Location = new System.Drawing.Point(12, 316);
            this.Str2.Name = "Str2";
            this.Str2.Size = new System.Drawing.Size(302, 43);
            this.Str2.TabIndex = 1;
            this.Str2.Text = "";
            // 
            // Str3
            // 
            this.Str3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Str3.Location = new System.Drawing.Point(12, 383);
            this.Str3.Name = "Str3";
            this.Str3.Size = new System.Drawing.Size(302, 43);
            this.Str3.TabIndex = 2;
            this.Str3.Text = "";
            // 
            // LowerUpperStr
            // 
            this.LowerUpperStr.BackColor = System.Drawing.Color.White;
            this.LowerUpperStr.FlatAppearance.BorderSize = 0;
            this.LowerUpperStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LowerUpperStr.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LowerUpperStr.Location = new System.Drawing.Point(353, 41);
            this.LowerUpperStr.Name = "LowerUpperStr";
            this.LowerUpperStr.Size = new System.Drawing.Size(208, 114);
            this.LowerUpperStr.TabIndex = 3;
            this.LowerUpperStr.Text = "Посчитать количество строчных и прописных букв в строке 1";
            this.LowerUpperStr.UseVisualStyleBackColor = false;
            this.LowerUpperStr.Click += new System.EventHandler(this.LowerUpperStr_Click);
            // 
            // PunctuationStr
            // 
            this.PunctuationStr.BackColor = System.Drawing.Color.White;
            this.PunctuationStr.FlatAppearance.BorderSize = 0;
            this.PunctuationStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PunctuationStr.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PunctuationStr.Location = new System.Drawing.Point(353, 172);
            this.PunctuationStr.Name = "PunctuationStr";
            this.PunctuationStr.Size = new System.Drawing.Size(208, 115);
            this.PunctuationStr.TabIndex = 4;
            this.PunctuationStr.Text = "Посчитать количество знаков препинания в строке 1";
            this.PunctuationStr.UseVisualStyleBackColor = false;
            this.PunctuationStr.Click += new System.EventHandler(this.PunctuationStr_Click);
            // 
            // Str2And3Op
            // 
            this.Str2And3Op.BackColor = System.Drawing.Color.White;
            this.Str2And3Op.FlatAppearance.BorderSize = 0;
            this.Str2And3Op.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Str2And3Op.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Str2And3Op.Location = new System.Drawing.Point(353, 316);
            this.Str2And3Op.Name = "Str2And3Op";
            this.Str2And3Op.Size = new System.Drawing.Size(208, 110);
            this.Str2And3Op.TabIndex = 5;
            this.Str2And3Op.Text = "Вывести на экран, сколько первых символов совпадают";
            this.Str2And3Op.UseVisualStyleBackColor = false;
            this.Str2And3Op.Click += new System.EventHandler(this.Str2And3Op_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Строка 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Строка 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Строка 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(353, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Задания со строкой 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(353, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Задание со строками 2 и 3:";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(12, 441);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(302, 23);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Очистить строки";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Undo
            // 
            this.Undo.BackColor = System.Drawing.Color.White;
            this.Undo.FlatAppearance.BorderSize = 0;
            this.Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Undo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Undo.Location = new System.Drawing.Point(353, 441);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(208, 23);
            this.Undo.TabIndex = 12;
            this.Undo.Text = "Вернуть тестовые строки";
            this.Undo.UseVisualStyleBackColor = false;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Strings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(167)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(593, 476);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Str2And3Op);
            this.Controls.Add(this.PunctuationStr);
            this.Controls.Add(this.LowerUpperStr);
            this.Controls.Add(this.Str3);
            this.Controls.Add(this.Str2);
            this.Controls.Add(this.Str1);
            this.Name = "Strings";
            this.Text = "Strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox Str1;
        private RichTextBox Str2;
        private RichTextBox Str3;
        private Button LowerUpperStr;
        private Button PunctuationStr;
        private Button Str2And3Op;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Clear;
        private Button Undo;
    }
}