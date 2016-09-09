namespace Banco_MME
{
    partial class Extrato
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
            this.dgvExtrato = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtrato)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExtrato
            // 
            this.dgvExtrato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExtrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExtrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtrato.Enabled = false;
            this.dgvExtrato.Location = new System.Drawing.Point(0, 0);
            this.dgvExtrato.Name = "dgvExtrato";
            this.dgvExtrato.ReadOnly = true;
            this.dgvExtrato.RowHeadersVisible = false;
            this.dgvExtrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtrato.Size = new System.Drawing.Size(380, 657);
            this.dgvExtrato.TabIndex = 0;
            // 
            // Extrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 656);
            this.Controls.Add(this.dgvExtrato);
            this.Name = "Extrato";
            this.Text = "Extrato";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtrato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExtrato;
    }
}