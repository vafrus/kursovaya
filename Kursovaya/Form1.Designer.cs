namespace Kursovaya
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.In_area = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Rang = new System.Windows.Forms.TextBox();
            this.Out_area = new System.Windows.Forms.GroupBox();
            this.Out_pic = new System.Windows.Forms.PictureBox();
            this.In_area.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Out_area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Out_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // In_area
            // 
            this.In_area.Controls.Add(this.label3);
            this.In_area.Controls.Add(this.button3);
            this.In_area.Controls.Add(this.label2);
            this.In_area.Location = new System.Drawing.Point(12, 81);
            this.In_area.Name = "In_area";
            this.In_area.Size = new System.Drawing.Size(763, 320);
            this.In_area.TabIndex = 1;
            this.In_area.TabStop = false;
            this.In_area.Text = "Ввод коэфициентов СЛАУ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Если порядок матрицы равен двум, то можно посмотреть визуализацию решения";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(455, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Визуализация";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_vis);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите коэффициенты системы";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Решить систему";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Solve_SLAU);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Rang);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 63);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод данных СЛАУ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Init_Input_Field);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите порядок матрицы";
            // 
            // Rang
            // 
            this.Rang.Location = new System.Drawing.Point(154, 24);
            this.Rang.Name = "Rang";
            this.Rang.Size = new System.Drawing.Size(43, 20);
            this.Rang.TabIndex = 1;
            this.Rang.Text = "2";
            // 
            // Out_area
            // 
            this.Out_area.Controls.Add(this.Out_pic);
            this.Out_area.Controls.Add(this.button2);
            this.Out_area.Location = new System.Drawing.Point(781, 81);
            this.Out_area.Name = "Out_area";
            this.Out_area.Size = new System.Drawing.Size(192, 320);
            this.Out_area.TabIndex = 2;
            this.Out_area.TabStop = false;
            this.Out_area.Text = "Решение";
            // 
            // Out_pic
            // 
            this.Out_pic.Location = new System.Drawing.Point(7, 55);
            this.Out_pic.Name = "Out_pic";
            this.Out_pic.Size = new System.Drawing.Size(179, 259);
            this.Out_pic.TabIndex = 0;
            this.Out_pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 413);
            this.Controls.Add(this.Out_area);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.In_area);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Решение СЛАУ";
            this.In_area.ResumeLayout(false);
            this.In_area.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Out_area.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Out_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox In_area;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Rang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Out_area;
        private System.Windows.Forms.PictureBox Out_pic;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;


    }
}

