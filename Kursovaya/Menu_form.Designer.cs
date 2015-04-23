namespace Kursovaya
{
    partial class Menu_form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TL_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.описаниеМетодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Desc_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FC_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Solve_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ref_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_nemuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TL_menuItem,
            this.описаниеМетодаToolStripMenuItem,
            this.Solve_menuItem,
            this.Exit_menuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // TL_menuItem
            // 
            this.TL_menuItem.Name = "TL_menuItem";
            this.TL_menuItem.Size = new System.Drawing.Size(171, 22);
            this.TL_menuItem.Text = "Титульный лист";
            this.TL_menuItem.Click += new System.EventHandler(this.TL_menuItem_Click);
            // 
            // описаниеМетодаToolStripMenuItem
            // 
            this.описаниеМетодаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Desc_menuItem,
            this.FC_menuItem});
            this.описаниеМетодаToolStripMenuItem.Name = "описаниеМетодаToolStripMenuItem";
            this.описаниеМетодаToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.описаниеМетодаToolStripMenuItem.Text = "Описание метода";
            // 
            // Desc_menuItem
            // 
            this.Desc_menuItem.Name = "Desc_menuItem";
            this.Desc_menuItem.Size = new System.Drawing.Size(138, 22);
            this.Desc_menuItem.Text = "Описание";
            this.Desc_menuItem.Click += new System.EventHandler(this.Desc_menuItem_Click);
            // 
            // FC_menuItem
            // 
            this.FC_menuItem.Name = "FC_menuItem";
            this.FC_menuItem.Size = new System.Drawing.Size(138, 22);
            this.FC_menuItem.Text = "Блок-схема";
            this.FC_menuItem.Click += new System.EventHandler(this.FC_menuItem_Click);
            // 
            // Solve_menuItem
            // 
            this.Solve_menuItem.Name = "Solve_menuItem";
            this.Solve_menuItem.Size = new System.Drawing.Size(171, 22);
            this.Solve_menuItem.Text = "Решить СЛАУ";
            this.Solve_menuItem.Click += new System.EventHandler(this.Solve_menuItem_Click);
            // 
            // Exit_menuItem
            // 
            this.Exit_menuItem.Name = "Exit_menuItem";
            this.Exit_menuItem.Size = new System.Drawing.Size(171, 22);
            this.Exit_menuItem.Text = "Выход";
            this.Exit_menuItem.Click += new System.EventHandler(this.Exit_menuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ref_menuItem,
            this.About_nemuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // Ref_menuItem
            // 
            this.Ref_menuItem.Name = "Ref_menuItem";
            this.Ref_menuItem.Size = new System.Drawing.Size(149, 22);
            this.Ref_menuItem.Text = "Справка";
            this.Ref_menuItem.Click += new System.EventHandler(this.Ref_menuItem_Click);
            // 
            // About_nemuItem
            // 
            this.About_nemuItem.Name = "About_nemuItem";
            this.About_nemuItem.Size = new System.Drawing.Size(149, 22);
            this.About_nemuItem.Text = "О программе";
            this.About_nemuItem.Click += new System.EventHandler(this.About_nemuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(509, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(432, 17);
            this.toolStripStatusLabel1.Text = "Для того чтобы решить систему уравнений нажмите Меню -> Решить СЛАУ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_form";
            this.Text = "Курсовая работа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_form_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem описаниеМетодаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Desc_menuItem;
        private System.Windows.Forms.ToolStripMenuItem FC_menuItem;
        private System.Windows.Forms.ToolStripMenuItem Solve_menuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_menuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ref_menuItem;
        private System.Windows.Forms.ToolStripMenuItem About_nemuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem TL_menuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}