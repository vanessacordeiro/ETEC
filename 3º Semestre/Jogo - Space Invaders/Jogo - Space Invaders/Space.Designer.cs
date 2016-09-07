namespace Jogo
{
    partial class frmSpace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpace));
            this.timerInimigo = new System.Windows.Forms.Timer(this.components);
            this.pictureTiroJogador = new System.Windows.Forms.PictureBox();
            this.pictureInimigo = new System.Windows.Forms.PictureBox();
            this.pictureJogador = new System.Windows.Forms.PictureBox();
            this.pictureFundo = new System.Windows.Forms.PictureBox();
            this.timerTiroJogador = new System.Windows.Forms.Timer(this.components);
            this.pictureTiroInimigo = new System.Windows.Forms.PictureBox();
            this.timerTiroInimigo = new System.Windows.Forms.Timer(this.components);
            this.lblVidaJogador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureVj1 = new System.Windows.Forms.PictureBox();
            this.pictureVj2 = new System.Windows.Forms.PictureBox();
            this.pictureVj3 = new System.Windows.Forms.PictureBox();
            this.pictureVi1 = new System.Windows.Forms.PictureBox();
            this.pictureVi2 = new System.Windows.Forms.PictureBox();
            this.pictureVi3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTiroJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInimigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTiroInimigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVj2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVj3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVi3)).BeginInit();
            this.SuspendLayout();
            // 
            // timerInimigo
            // 
            this.timerInimigo.Enabled = true;
            this.timerInimigo.Interval = 800;
            this.timerInimigo.Tick += new System.EventHandler(this.timerInimigo_Tick);
            // 
            // pictureTiroJogador
            // 
            this.pictureTiroJogador.Image = global::Jogo.Properties.Resources.Tiro;
            this.pictureTiroJogador.Location = new System.Drawing.Point(296, 408);
            this.pictureTiroJogador.Name = "pictureTiroJogador";
            this.pictureTiroJogador.Size = new System.Drawing.Size(18, 12);
            this.pictureTiroJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureTiroJogador.TabIndex = 3;
            this.pictureTiroJogador.TabStop = false;
            this.pictureTiroJogador.Visible = false;
            // 
            // pictureInimigo
            // 
            this.pictureInimigo.Image = global::Jogo.Properties.Resources.Nave2;
            this.pictureInimigo.Location = new System.Drawing.Point(279, 2);
            this.pictureInimigo.Name = "pictureInimigo";
            this.pictureInimigo.Size = new System.Drawing.Size(59, 65);
            this.pictureInimigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureInimigo.TabIndex = 2;
            this.pictureInimigo.TabStop = false;
            // 
            // pictureJogador
            // 
            this.pictureJogador.Image = global::Jogo.Properties.Resources.Nave1;
            this.pictureJogador.Location = new System.Drawing.Point(279, 423);
            this.pictureJogador.Name = "pictureJogador";
            this.pictureJogador.Size = new System.Drawing.Size(50, 57);
            this.pictureJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureJogador.TabIndex = 1;
            this.pictureJogador.TabStop = false;
            // 
            // pictureFundo
            // 
            this.pictureFundo.Image = global::Jogo.Properties.Resources.Espaço2;
            this.pictureFundo.Location = new System.Drawing.Point(12, 1);
            this.pictureFundo.Name = "pictureFundo";
            this.pictureFundo.Size = new System.Drawing.Size(592, 503);
            this.pictureFundo.TabIndex = 0;
            this.pictureFundo.TabStop = false;
            // 
            // timerTiroJogador
            // 
            this.timerTiroJogador.Interval = 70;
            this.timerTiroJogador.Tick += new System.EventHandler(this.timerTiroJogador_Tick);
            // 
            // pictureTiroInimigo
            // 
            this.pictureTiroInimigo.Image = global::Jogo.Properties.Resources.Tiro;
            this.pictureTiroInimigo.Location = new System.Drawing.Point(296, 73);
            this.pictureTiroInimigo.Name = "pictureTiroInimigo";
            this.pictureTiroInimigo.Size = new System.Drawing.Size(18, 12);
            this.pictureTiroInimigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureTiroInimigo.TabIndex = 4;
            this.pictureTiroInimigo.TabStop = false;
            this.pictureTiroInimigo.Visible = false;
            // 
            // timerTiroInimigo
            // 
            this.timerTiroInimigo.Interval = 70;
            this.timerTiroInimigo.Tick += new System.EventHandler(this.timerTiroInimigo_Tick);
            // 
            // lblVidaJogador
            // 
            this.lblVidaJogador.AutoSize = true;
            this.lblVidaJogador.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblVidaJogador.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaJogador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVidaJogador.Location = new System.Drawing.Point(463, 491);
            this.lblVidaJogador.Name = "lblVidaJogador";
            this.lblVidaJogador.Size = new System.Drawing.Size(61, 13);
            this.lblVidaJogador.TabIndex = 5;
            this.lblVidaJogador.Text = "Vidas:";
            this.lblVidaJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vidas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureVj1
            // 
            this.pictureVj1.Image = global::Jogo.Properties.Resources.Nave1;
            this.pictureVj1.Location = new System.Drawing.Point(524, 480);
            this.pictureVj1.Name = "pictureVj1";
            this.pictureVj1.Size = new System.Drawing.Size(27, 24);
            this.pictureVj1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVj1.TabIndex = 7;
            this.pictureVj1.TabStop = false;
            // 
            // pictureVj2
            // 
            this.pictureVj2.Image = global::Jogo.Properties.Resources.Nave1;
            this.pictureVj2.Location = new System.Drawing.Point(553, 480);
            this.pictureVj2.Name = "pictureVj2";
            this.pictureVj2.Size = new System.Drawing.Size(27, 24);
            this.pictureVj2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVj2.TabIndex = 8;
            this.pictureVj2.TabStop = false;
            // 
            // pictureVj3
            // 
            this.pictureVj3.Image = global::Jogo.Properties.Resources.Nave1;
            this.pictureVj3.Location = new System.Drawing.Point(582, 480);
            this.pictureVj3.Name = "pictureVj3";
            this.pictureVj3.Size = new System.Drawing.Size(27, 24);
            this.pictureVj3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVj3.TabIndex = 9;
            this.pictureVj3.TabStop = false;
            // 
            // pictureVi1
            // 
            this.pictureVi1.Image = global::Jogo.Properties.Resources.Nave2;
            this.pictureVi1.Location = new System.Drawing.Point(61, -4);
            this.pictureVi1.Name = "pictureVi1";
            this.pictureVi1.Size = new System.Drawing.Size(27, 24);
            this.pictureVi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVi1.TabIndex = 10;
            this.pictureVi1.TabStop = false;
            // 
            // pictureVi2
            // 
            this.pictureVi2.Image = global::Jogo.Properties.Resources.Nave2;
            this.pictureVi2.Location = new System.Drawing.Point(90, -4);
            this.pictureVi2.Name = "pictureVi2";
            this.pictureVi2.Size = new System.Drawing.Size(27, 24);
            this.pictureVi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVi2.TabIndex = 11;
            this.pictureVi2.TabStop = false;
            // 
            // pictureVi3
            // 
            this.pictureVi3.Image = global::Jogo.Properties.Resources.Nave2;
            this.pictureVi3.Location = new System.Drawing.Point(119, -4);
            this.pictureVi3.Name = "pictureVi3";
            this.pictureVi3.Size = new System.Drawing.Size(27, 24);
            this.pictureVi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVi3.TabIndex = 12;
            this.pictureVi3.TabStop = false;
            // 
            // frmSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(616, 506);
            this.Controls.Add(this.pictureVi3);
            this.Controls.Add(this.pictureVi2);
            this.Controls.Add(this.pictureVi1);
            this.Controls.Add(this.pictureVj3);
            this.Controls.Add(this.pictureVj2);
            this.Controls.Add(this.pictureVj1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVidaJogador);
            this.Controls.Add(this.pictureTiroInimigo);
            this.Controls.Add(this.pictureTiroJogador);
            this.Controls.Add(this.pictureInimigo);
            this.Controls.Add(this.pictureJogador);
            this.Controls.Add(this.pictureFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Invaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSpace_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTiroJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInimigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTiroInimigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVj2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVj3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVi3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureFundo;
        private System.Windows.Forms.PictureBox pictureJogador;
        private System.Windows.Forms.PictureBox pictureInimigo;
        private System.Windows.Forms.Timer timerInimigo;
        private System.Windows.Forms.PictureBox pictureTiroJogador;
        private System.Windows.Forms.Timer timerTiroJogador;
        private System.Windows.Forms.PictureBox pictureTiroInimigo;
        private System.Windows.Forms.Timer timerTiroInimigo;
        private System.Windows.Forms.Label lblVidaJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureVj1;
        private System.Windows.Forms.PictureBox pictureVj2;
        private System.Windows.Forms.PictureBox pictureVj3;
        private System.Windows.Forms.PictureBox pictureVi1;
        private System.Windows.Forms.PictureBox pictureVi2;
        private System.Windows.Forms.PictureBox pictureVi3;
    }
}

