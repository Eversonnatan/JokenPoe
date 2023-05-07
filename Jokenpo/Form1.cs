using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokenpo
{
    public partial class fmrJoken : Form
    {
        int pontoCpu = 0, pontoJogador = 0 ;
        string ComputadorEscolha;
        string JogadorEscolha;

        public void Jogada()
        {
            if (JogadorEscolha != string.Empty)
            {
                Escolhas();
                if (ComputadorEscolha != string.Empty)
                {
                    if (ComputadorEscolha == "PEDRA" && JogadorEscolha == "PEDRA")
                    {
                        pontoCpu++;
                        pontoJogador++;

                    }
                    else if (ComputadorEscolha == "PAPEL" && JogadorEscolha == "PAPEL")
                    {
                        pontoCpu++;
                        pontoJogador++;

                    }
                    else if (ComputadorEscolha == "TESOURA" && JogadorEscolha == "TESOURA")
                    {
                        pontoCpu++;
                        pontoJogador++;
                    }
                    else if (ComputadorEscolha == "PEDRA" && JogadorEscolha == "TESOURA")
                    {
                        pontoCpu++;

                    }
                    else if (JogadorEscolha == "PEDRA" && ComputadorEscolha == "TESOURA")
                    {
                        pontoJogador++;
                    }
                    else if (ComputadorEscolha == "PAPEL" && JogadorEscolha == "TESOURA")
                    {
                        pontoJogador++;
                    }
                    else if (ComputadorEscolha == "PAPEL" && JogadorEscolha == "PEDRA")
                    {
                        pontoCpu++;
                    }
                    else if (ComputadorEscolha == "PEDRA" && JogadorEscolha == "PAPEL")
                    {
                        pontoJogador++;
                    }
                    else if (ComputadorEscolha == "TESOURA" && JogadorEscolha == "PAPEL")
                    {
                        pontoCpu++;
                    }
                }
                
            }
        }

        private void Escolhas()
        {
            Random sorteio = new Random();
            int numero = sorteio.Next(1, 3);
            if (numero == 1)
            {
                ComputadorEscolha = "PEDRA";  

                pbximageCpu.Image = Properties.Resources.pedra1;
            }

                
            else if (numero == 2)
            {
                ComputadorEscolha = "PAPEL";

                pbximageCpu.Image = Properties.Resources.papel;
            }
            else
              {
                ComputadorEscolha = "TESOURA";

                pbximageCpu.Image = Properties.Resources.tesoura;
            }
        }


        public fmrJoken()
        {
            InitializeComponent();
        }

        private void rbPedra_CheckedChanged(object sender, EventArgs e)
        {
            JogadorEscolha = "PEDRA";
            pbxImageJogador.Image = Properties.Resources.pedra1;
        }

        private void rbPapel_CheckedChanged(object sender, EventArgs e)
        {
            JogadorEscolha = "PAPEL";
            pbxImageJogador.Image = Properties.Resources.papel;
        }

        private void rbTesoura_CheckedChanged(object sender, EventArgs e)
        {
            JogadorEscolha = "TESOURA";
            pbxImageJogador.Image = Properties.Resources.tesoura;
        }

        private void pbximageCpu_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPontoJogador_Click(object sender, EventArgs e)
        {
          
        }

        private void lblPontoCPU_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbximageCpu.Visible = false;
            pbxImageJogador.Visible = false;
            timer1.Stop();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxImageJogador_Click(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            
             Jogada();

            lblPontoJogador.Text = String.Format("Pontos = {0} ", pontoJogador.ToString());
            lblPontoCPU.Text = String.Format("Pontos = {0} ", pontoCpu.ToString());

            pbxImageJogador.Visible = true;
            pbximageCpu.Visible = true;
            timer1.Start();

        }
    }
}
