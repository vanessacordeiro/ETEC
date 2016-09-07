using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo
{
    public partial class frmSpace : Form
    {
        public frmSpace()
        {
            InitializeComponent();
        }

        bool cont = true;
        Random randNum = new Random();
        int vidasJ = 3; 
        int vidasI = 3;
        
        private void timerInimigo_Tick(object sender, EventArgs e)
        {
            if (cont == true)
            {
                if (pictureInimigo.Location.X < 520)
                {
                    this.pictureInimigo.Location = new Point(pictureInimigo.Location.X + 40, pictureInimigo.Location.Y + 0);
                    cont = true;
                }
                else if (pictureInimigo.Location.X > 30)
                {
                    this.pictureInimigo.Location = new Point(pictureInimigo.Location.X - 40, pictureInimigo.Location.Y - 0);
                    cont = false;
                }
            }
            else
            {
                if (pictureInimigo.Location.X > 30)
                {
                    this.pictureInimigo.Location = new Point(pictureInimigo.Location.X - 40, pictureInimigo.Location.Y - 0);
                    cont = false;
                }
                else if (pictureInimigo.Location.X < 520)
                {
                    this.pictureInimigo.Location = new Point(pictureInimigo.Location.X + 40, pictureInimigo.Location.Y + 0);
                    cont = true;
                }
            }

            int temp = randNum.Next(0, 2);
            if (temp == 1)
            {
                this.pictureTiroInimigo.Location = this.pictureInimigo.Location;
                timerTiroInimigo.Enabled = true;
            }
        }

        private void frmSpace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureJogador.Location.X > 30)
                {
                    this.pictureJogador.Location = new Point(pictureJogador.Location.X - 40, pictureJogador.Location.Y - 0);
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (pictureJogador.Location.X < 520)
                {
                    this.pictureJogador.Location = new Point(pictureJogador.Location.X + 40, pictureJogador.Location.Y + 0);
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                timerTiroJogador.Enabled = true;
                this.pictureTiroJogador.Location = this.pictureJogador.Location;
            }
        }

        private void timerTiroJogador_Tick(object sender, EventArgs e)
        {
            pictureTiroJogador.Visible = true;
            this.pictureTiroJogador.Location = new Point(pictureTiroJogador.Location.X - 0, pictureTiroJogador.Location.Y - 50);
            if ((pictureTiroJogador.Location.X > pictureInimigo.Location.X) && (pictureTiroJogador.Location.Y > pictureInimigo.Location.Y) && (pictureTiroJogador.Location.X < pictureInimigo.Location.X + 59) && (pictureTiroJogador.Location.Y < pictureInimigo.Location.Y + 65))
            {
                switch(vidasI)
                {
                    case 1:
                        timerTiroJogador.Stop();
                        timerTiroInimigo.Stop();
                        this.pictureVi1.Visible = false;
                        this.pictureTiroInimigo.Visible = false;
                        this.pictureTiroJogador.Visible = false;
                        timerInimigo.Stop();
                        MessageBox.Show("Você venceu!");
                        Application.Exit();
                    break;
                    case 2:
                        timerTiroJogador.Stop();
                        vidasI = vidasI - 1;
                        this.pictureVi2.Visible = false;
                        this.pictureTiroJogador.Visible = false;
                    break;
                    case 3:
                        timerTiroJogador.Stop();
                        vidasI = vidasI - 1;
                        this.pictureVi3.Visible = false;
                        this.pictureTiroJogador.Visible = false;
                    break;
                }
            }
        }

        private void timerTiroInimigo_Tick(object sender, EventArgs e)
        {
            pictureTiroInimigo.Visible = true;
            this.pictureTiroInimigo.Location = new Point(pictureTiroInimigo.Location.X + 0, pictureTiroInimigo.Location.Y + 50);
            if ((pictureTiroInimigo.Location.X > pictureJogador.Location.X) && (pictureTiroInimigo.Location.Y > pictureJogador.Location.Y) && (pictureTiroInimigo.Location.X < pictureJogador.Location.X + 50) && (pictureTiroInimigo.Location.Y < pictureJogador.Location.Y + 57))
            {
                switch (vidasJ)
                {
                    case 1:
                        timerTiroInimigo.Stop();
                        timerTiroJogador.Stop();
                        this.pictureVj1.Visible = false;
                        this.pictureTiroInimigo.Visible = false;
                        this.pictureTiroJogador.Visible = false;
                        timerInimigo.Stop();
                        MessageBox.Show("Você perdeu!");
                        Application.Exit();
                    break;
                    case 2:
                        timerTiroInimigo.Stop();
                        vidasJ = vidasJ - 1;
                        this.pictureVj2.Visible = false;
                        this.pictureTiroInimigo.Visible = false;
                    break;
                    case 3:
                        timerTiroInimigo.Stop();
                        vidasJ = vidasJ - 1;
                        this.pictureVj3.Visible = false;
                        this.pictureTiroInimigo.Visible = false;
                    break;
                }
            }
        }
    }
}
