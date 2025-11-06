namespace wshop
{
    partial class SellProductForm
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericSellQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnVinde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSellQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(118, 27);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(97, 16);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "[product name]";
//            this.lblProductName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume Produs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantitate disponibila";
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Location = new System.Drawing.Point(171, 62);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(65, 16);
            this.lblCurrentStock.TabIndex = 3;
            this.lblCurrentStock.Text = "[cantitate]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "vanzare dorita";
            // 
            // numericSellQuantity
            // 
            this.numericSellQuantity.Location = new System.Drawing.Point(164, 100);
            this.numericSellQuantity.Name = "numericSellQuantity";
            this.numericSellQuantity.Size = new System.Drawing.Size(120, 22);
            this.numericSellQuantity.TabIndex = 5;
            // 
            // btnVinde
            // 
            this.btnVinde.Location = new System.Drawing.Point(92, 158);
            this.btnVinde.Name = "btnVinde";
            this.btnVinde.Size = new System.Drawing.Size(97, 36);
            this.btnVinde.TabIndex = 6;
            this.btnVinde.Text = "Vanzare";
            this.btnVinde.UseVisualStyleBackColor = true;
            // 
            // SellProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 223);
            this.Controls.Add(this.btnVinde);
            this.Controls.Add(this.numericSellQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCurrentStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProductName);
            this.Name = "SellProductForm";
            this.Text = "SellProductForm";
            this.Load += new System.EventHandler(this.SellProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSellQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericSellQuantity;
        private System.Windows.Forms.Button btnVinde;
    }
}