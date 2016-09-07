using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _23._07
{
    public partial class Cad : Form
    {
        string[,] Pessoa = new string[3, 100];
        int x = 0;
        string result;
        Crud pesquisa = null;

        public Cad()
        {
            InitializeComponent();

            if (!File.Exists("contatos.txt"))
            {
                File.Create("contatos.txt");
            }
            TextReader leitor = leitor = new StreamReader("contatos.txt");

            for(int j = 0; j < 100; j++)
            {
                if ( leitor.ReadLine() == "")
                {
                    Pessoa[0,j] = leitor.ReadLine();
                    Pessoa[1,j] = leitor.ReadLine();
                    Pessoa[2,j] = leitor.ReadLine();
                    x++;
                }
            }
            
            leitor.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            btnOK.BackColor = Color.Blue;
            btnC.BackColor = Color.Blue;
            btnM.BackColor = Color.Blue;
            btnBusca.BackColor = Color.Blue;
            lbl1.ForeColor = Color.White;
            lbl2.ForeColor = Color.White;
            lbl3.ForeColor = Color.White;
            btnOK.ForeColor = Color.White;
            btnC.ForeColor = Color.White;
            btnM.ForeColor = Color.White;
            btnBusca.ForeColor = Color.White;
            
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            btnOK.BackColor = Color.Red;
            btnC.BackColor = Color.Red;
            btnM.BackColor = Color.Red;
            btnBusca.BackColor = Color.Red;
            lbl1.ForeColor = Color.White;
            lbl2.ForeColor = Color.White;
            lbl3.ForeColor = Color.White;
            btnOK.ForeColor = Color.White;
            btnC.ForeColor = Color.White;
            btnM.ForeColor = Color.White;
            btnBusca.ForeColor = Color.White;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            btnOK.BackColor = Color.Green;
            btnC.BackColor = Color.Green;
            btnM.BackColor = Color.Green;
            btnBusca.BackColor = Color.Green;
            lbl1.ForeColor = Color.White;
            lbl2.ForeColor = Color.White;
            lbl3.ForeColor = Color.White;
            btnOK.ForeColor = Color.White;
            btnC.ForeColor = Color.White;
            btnM.ForeColor = Color.White;
            btnBusca.ForeColor = Color.White;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            TextWriter escritor = new StreamWriter("contatos.txt");

            for (int i = 0; i < 100; i++)
            {
                if (Pessoa[0, i] != null)
                {
                    escritor.WriteLine("");
                    escritor.WriteLine(Pessoa[0,i]);
                    escritor.WriteLine(Pessoa[1,i]);
                    escritor.WriteLine(Pessoa[2,i]);
                }
            }
            escritor.Close();
            
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Pessoa[0, x] = txt1.Text.ToUpper();
            Pessoa[1, x] = txt2.Text.ToUpper();
            Pessoa[2, x] = txt3.Text.ToUpper();
            x = x + 1;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 100; a++)
            {
                if (Pessoa[0, a] != null)
                {
                    result = result + a +" "+ Pessoa[0, a] + "\n" + Pessoa[1, a] + "\n" + Pessoa[2, a] + "\n\n";
                }
            }
            MessageBox.Show(result);
            result = "";
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            pesquisa = new Crud(Pessoa);
            pesquisa.Show();
            
        }

       

       
    }
}
