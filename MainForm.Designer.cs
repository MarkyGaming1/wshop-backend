namespace wshop
{
    partial class MainForm
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
            this.dataGridViewProduse = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareProdusNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareCantitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCauta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProduse
            // 
            this.dataGridViewProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduse.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewProduse.Name = "dataGridViewProduse";
            this.dataGridViewProduse.RowHeadersWidth = 51;
            this.dataGridViewProduse.RowTemplate.Height = 24;
            this.dataGridViewProduse.Size = new System.Drawing.Size(983, 568);
            this.dataGridViewProduse.TabIndex = 0;
            this.dataGridViewProduse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduse_CellContentClick);
            this.dataGridViewProduse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduse_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1670, 1095);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(226, 45);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareProduseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugareProduseToolStripMenuItem
            // 
            this.adaugareProduseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareProdusNouToolStripMenuItem,
            this.adaugareCantitateToolStripMenuItem});
            this.adaugareProduseToolStripMenuItem.Name = "adaugareProduseToolStripMenuItem";
            this.adaugareProduseToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.adaugareProduseToolStripMenuItem.Text = "Adaugare Produse";
            // 
            // adaugareProdusNouToolStripMenuItem
            // 
            this.adaugareProdusNouToolStripMenuItem.Name = "adaugareProdusNouToolStripMenuItem";
            this.adaugareProdusNouToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.adaugareProdusNouToolStripMenuItem.Text = "Adaugare Produs Nou";
            this.adaugareProdusNouToolStripMenuItem.Click += new System.EventHandler(this.adaugareProdusNouToolStripMenuItem_Click);
            // 
            // adaugareCantitateToolStripMenuItem
            // 
            this.adaugareCantitateToolStripMenuItem.Name = "adaugareCantitateToolStripMenuItem";
            this.adaugareCantitateToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.adaugareCantitateToolStripMenuItem.Text = "Adaugare Cantitate";
            this.adaugareCantitateToolStripMenuItem.Click += new System.EventHandler(this.adaugareCantitateToolStripMenuItem_Click);
            // 
            // txtCauta
            // 
            this.txtCauta.Location = new System.Drawing.Point(469, 0);
            this.txtCauta.Name = "txtCauta";
            this.txtCauta.Size = new System.Drawing.Size(268, 22);
            this.txtCauta.TabIndex = 3;
            this.txtCauta.TextChanged += new System.EventHandler(this.txtCauta_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 596);
            this.Controls.Add(this.txtCauta);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewProduse);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduse;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareProduseToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCauta;
        private System.Windows.Forms.ToolStripMenuItem adaugareProdusNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareCantitateToolStripMenuItem;
    }
}