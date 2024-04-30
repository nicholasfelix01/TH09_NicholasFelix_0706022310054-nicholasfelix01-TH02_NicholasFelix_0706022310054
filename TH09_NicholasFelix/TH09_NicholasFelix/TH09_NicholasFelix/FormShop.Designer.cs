namespace TH09_NicholasFelix
{
    partial class FormShop
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.topWearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tShirtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shirtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomWearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longPantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jewelryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_show = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDIe = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.TextBox();
            this.lbl_3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topWearToolStripMenuItem,
            this.bottomWearToolStripMenuItem,
            this.accessoriesToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // topWearToolStripMenuItem
            // 
            this.topWearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tShirtToolStripMenuItem,
            this.shirtToolStripMenuItem});
            this.topWearToolStripMenuItem.Name = "topWearToolStripMenuItem";
            this.topWearToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.topWearToolStripMenuItem.Text = "Top Wear";
            // 
            // tShirtToolStripMenuItem
            // 
            this.tShirtToolStripMenuItem.Name = "tShirtToolStripMenuItem";
            this.tShirtToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.tShirtToolStripMenuItem.Text = "T-Shirt";
            this.tShirtToolStripMenuItem.Click += new System.EventHandler(this.tShirtToolStripMenuItem_Click);
            // 
            // shirtToolStripMenuItem
            // 
            this.shirtToolStripMenuItem.Name = "shirtToolStripMenuItem";
            this.shirtToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.shirtToolStripMenuItem.Text = "Shirt";
            this.shirtToolStripMenuItem.Click += new System.EventHandler(this.shirtToolStripMenuItem_Click);
            // 
            // bottomWearToolStripMenuItem
            // 
            this.bottomWearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantsToolStripMenuItem,
            this.longPantsToolStripMenuItem});
            this.bottomWearToolStripMenuItem.Name = "bottomWearToolStripMenuItem";
            this.bottomWearToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.bottomWearToolStripMenuItem.Text = "Bottom Wear";
            // 
            // pantsToolStripMenuItem
            // 
            this.pantsToolStripMenuItem.Name = "pantsToolStripMenuItem";
            this.pantsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.pantsToolStripMenuItem.Text = "Pants";
            this.pantsToolStripMenuItem.Click += new System.EventHandler(this.pantsToolStripMenuItem_Click);
            // 
            // longPantsToolStripMenuItem
            // 
            this.longPantsToolStripMenuItem.Name = "longPantsToolStripMenuItem";
            this.longPantsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.longPantsToolStripMenuItem.Text = "Long Pants";
            this.longPantsToolStripMenuItem.Click += new System.EventHandler(this.longPantsToolStripMenuItem_Click);
            // 
            // accessoriesToolStripMenuItem
            // 
            this.accessoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shoesToolStripMenuItem,
            this.jewelryToolStripMenuItem});
            this.accessoriesToolStripMenuItem.Name = "accessoriesToolStripMenuItem";
            this.accessoriesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.accessoriesToolStripMenuItem.Text = "Accessories";
            // 
            // shoesToolStripMenuItem
            // 
            this.shoesToolStripMenuItem.Name = "shoesToolStripMenuItem";
            this.shoesToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.shoesToolStripMenuItem.Text = "Shoes";
            this.shoesToolStripMenuItem.Click += new System.EventHandler(this.shoesToolStripMenuItem_Click);
            // 
            // jewelryToolStripMenuItem
            // 
            this.jewelryToolStripMenuItem.Name = "jewelryToolStripMenuItem";
            this.jewelryToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.jewelryToolStripMenuItem.Text = "Jewelry";
            this.jewelryToolStripMenuItem.Click += new System.EventHandler(this.jewelryToolStripMenuItem_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.othersToolStripMenuItem.Text = "Others";
            this.othersToolStripMenuItem.Click += new System.EventHandler(this.othersToolStripMenuItem_Click);
            // 
            // pnl_show
            // 
            this.pnl_show.Location = new System.Drawing.Point(0, 27);
            this.pnl_show.Name = "pnl_show";
            this.pnl_show.Size = new System.Drawing.Size(576, 369);
            this.pnl_show.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(591, 27);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(306, 203);
            this.dgv.TabIndex = 2;
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            // 
            // btnDIe
            // 
            this.btnDIe.Location = new System.Drawing.Point(847, 236);
            this.btnDIe.Name = "btnDIe";
            this.btnDIe.Size = new System.Drawing.Size(50, 23);
            this.btnDIe.TabIndex = 3;
            this.btnDIe.Text = "Die";
            this.btnDIe.UseVisualStyleBackColor = true;
            this.btnDIe.Click += new System.EventHandler(this.btnDIe_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.Location = new System.Drawing.Point(666, 305);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(193, 23);
            this.lbl_1.TabIndex = 4;
            // 
            // lbl_3
            // 
            this.lbl_3.Location = new System.Drawing.Point(666, 365);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(172, 23);
            this.lbl_3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(592, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(592, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "10% Tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(618, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total";
            // 
            // lbl_2
            // 
            this.lbl_2.Location = new System.Drawing.Point(666, 336);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(93, 23);
            this.lbl_2.TabIndex = 9;
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(916, 399);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.pnl_show);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDIe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormShop";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem topWearToolStripMenuItem;
        private ToolStripMenuItem bottomWearToolStripMenuItem;
        private ToolStripMenuItem accessoriesToolStripMenuItem;
        private ToolStripMenuItem othersToolStripMenuItem;
        private Panel pnl_show;
        private DataGridView dgv;
        private Button btnDIe;
        private TextBox lbl_1;
        private TextBox lbl_3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox lbl_2;
        private ToolStripMenuItem tShirtToolStripMenuItem;
        private ToolStripMenuItem shirtToolStripMenuItem;
        private ToolStripMenuItem pantsToolStripMenuItem;
        private ToolStripMenuItem longPantsToolStripMenuItem;
        private ToolStripMenuItem shoesToolStripMenuItem;
        private ToolStripMenuItem jewelryToolStripMenuItem;
    }
}