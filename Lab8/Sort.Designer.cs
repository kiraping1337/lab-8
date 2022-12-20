namespace Lab8
{
    partial class Sort
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
            this.arraylength = new System.Windows.Forms.TextBox();
            this.TimeSort1 = new System.Windows.Forms.TextBox();
            this.TimeSort2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Unsorted = new System.Windows.Forms.DataGridView();
            this.Sorted = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Unsorted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sorted)).BeginInit();
            this.SuspendLayout();
            // 
            // arraylength
            // 
            this.arraylength.BackColor = System.Drawing.Color.White;
            this.arraylength.Location = new System.Drawing.Point(24, 47);
            this.arraylength.Name = "arraylength";
            this.arraylength.Size = new System.Drawing.Size(191, 23);
            this.arraylength.TabIndex = 0;
            // 
            // TimeSort1
            // 
            this.TimeSort1.BackColor = System.Drawing.Color.White;
            this.TimeSort1.Enabled = false;
            this.TimeSort1.Location = new System.Drawing.Point(25, 287);
            this.TimeSort1.Name = "TimeSort1";
            this.TimeSort1.Size = new System.Drawing.Size(290, 23);
            this.TimeSort1.TabIndex = 3;
            // 
            // TimeSort2
            // 
            this.TimeSort2.BackColor = System.Drawing.Color.White;
            this.TimeSort2.Enabled = false;
            this.TimeSort2.Location = new System.Drawing.Point(382, 287);
            this.TimeSort2.Name = "TimeSort2";
            this.TimeSort2.Size = new System.Drawing.Size(280, 23);
            this.TimeSort2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(469, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Создать массив";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(25, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 66);
            this.button3.TabIndex = 7;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(246, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 66);
            this.button4.TabIndex = 8;
            this.button4.Text = "Отсортировать";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(473, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 66);
            this.button5.TabIndex = 9;
            this.button5.Text = "Сравнить время сортировок";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Длина массива:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Неотсортированный массив:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Отсортированный массив:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Время сортировки пузырьком:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(381, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Время сортировки перемешиванием:";
            // 
            // Unsorted
            // 
            this.Unsorted.AllowUserToOrderColumns = true;
            this.Unsorted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Unsorted.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Unsorted.BackgroundColor = System.Drawing.Color.White;
            this.Unsorted.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Unsorted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Unsorted.ColumnHeadersVisible = false;
            this.Unsorted.Enabled = false;
            this.Unsorted.GridColor = System.Drawing.Color.White;
            this.Unsorted.Location = new System.Drawing.Point(25, 107);
            this.Unsorted.Name = "Unsorted";
            this.Unsorted.ReadOnly = true;
            this.Unsorted.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Unsorted.RowHeadersVisible = false;
            this.Unsorted.RowTemplate.Height = 25;
            this.Unsorted.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Unsorted.Size = new System.Drawing.Size(637, 22);
            this.Unsorted.TabIndex = 15;
            // 
            // Sorted
            // 
            this.Sorted.AllowUserToOrderColumns = true;
            this.Sorted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Sorted.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Sorted.BackgroundColor = System.Drawing.Color.White;
            this.Sorted.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Sorted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sorted.ColumnHeadersVisible = false;
            this.Sorted.Enabled = false;
            this.Sorted.GridColor = System.Drawing.Color.White;
            this.Sorted.Location = new System.Drawing.Point(24, 243);
            this.Sorted.Name = "Sorted";
            this.Sorted.ReadOnly = true;
            this.Sorted.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Sorted.RowHeadersVisible = false;
            this.Sorted.RowTemplate.Height = 25;
            this.Sorted.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Sorted.Size = new System.Drawing.Size(638, 22);
            this.Sorted.TabIndex = 16;
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(167)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(674, 325);
            this.Controls.Add(this.Sorted);
            this.Controls.Add(this.Unsorted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimeSort2);
            this.Controls.Add(this.TimeSort1);
            this.Controls.Add(this.arraylength);
            this.Name = "Sort";
            this.Text = "Sort";
            ((System.ComponentModel.ISupportInitialize)(this.Unsorted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sorted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox arraylength;
        private TextBox TimeSort1;
        private TextBox TimeSort2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView Unsorted;
        private DataGridView Sorted;
    }
}