using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodavelha
{
    public partial class Form1 : Form
    {

        string initialState = "X";

        public Form1()
        {
            InitializeComponent();
            casa_1.Enabled = false;
            casa_2.Enabled = false;
            casa_3.Enabled = false;
            casa_4.Enabled = false;
            casa_5.Enabled = false;
            casa_6.Enabled = false;
            casa_7.Enabled = false;
            casa_8.Enabled = false;
            casa_9.Enabled = false;
        }

        
        //Usado para fazer a mudança de jogador usando uma condição if-else
        private string SwitchPlayer()
        {
            if (initialState == "X")
            {
                initialState = "O";
            }
            else
            {
                initialState = "X";
            }
            return initialState;
        }
        //metodo usado para fazer o bloqueio das casas.
        private void blockCasas()
        {
            casa_1.Enabled = false;
            casa_2.Enabled = false;
            casa_3.Enabled = false;
            casa_4.Enabled = false;
            casa_5.Enabled = false;
            casa_6.Enabled = false;
            casa_7.Enabled = false;
            casa_8.Enabled = false;
            casa_9.Enabled = false;

        }

        //metodo usado para verificação da vitoria usando if-else
        private void verificyVitory()
        {
            blockCasas();

            if (initialState == "O")
            {
                Winner.Text = "JOGADOR 1 VENCEU";
            }
            else
            {
                Winner.Text = "JOGADOR 2 VENCEU";
            }

            botaoLimpar.Enabled = false;
        }
        
        //metodo usado para verificação da velha usando if
        private void verificaVelha()
        {
            if (casa_1.Text != "-"
                && casa_2.Text != "-"
                && casa_3.Text != "-"
                && casa_4.Text != "-"
                && casa_5.Text != "-"
                && casa_6.Text != "-"
                && casa_7.Text != "-"
                && casa_8.Text != "-"
                && casa_9.Text != "-"
                )
            {
                Winner.Text = "DEU VELHA";
                label1.Text = "DEU VELHA";
                blockCasas();
                label1.Text = "Vitoria do "+initialState;
                botaoLimpar.Enabled = false;

            }
        }

        //metodo que vai ser chamado no botao limpar casas, setando texto inicial definido como -, pois deixando vazio nao funciona.
        private void limpar_Casas()
        {
            casa_1.Text = "-";
            casa_2.Text = "-";
            casa_3.Text = "-";
            casa_4.Text = "-";
            casa_5.Text = "-";
            casa_6.Text = "-";
            casa_7.Text = "-";
            casa_8.Text = "-";
            casa_9.Text = "-";
            initialState = "X";
        }


        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            limpar_Casas();
            label1.Text = "Jogo zerado Click em Jogar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            casa_1.Text = SwitchPlayer();

            if (casa_1.Text == casa_2.Text && casa_2.Text == casa_3.Text)
            {
                verificyVitory();
            }
            else if (casa_1.Text == casa_4.Text && casa_4.Text == casa_7.Text)
            {
                verificyVitory();
            }
            else if (casa_1.Text == casa_5.Text && casa_5.Text == casa_9.Text)
            {
                verificyVitory();
            }
            verificaVelha();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            casa_2.Text = SwitchPlayer();

            if (casa_2.Text == casa_5.Text && casa_5.Text == casa_8.Text)
            {
                verificyVitory();
            }
            else if (casa_2.Text == casa_1.Text && casa_2.Text == casa_3.Text)
            {
                verificyVitory();
            }
            verificaVelha();

        }

        private void casa_3_Click(object sender, EventArgs e)
        {
            casa_3.Text = SwitchPlayer();
            if (casa_3.Text == casa_2.Text && casa_3.Text == casa_1.Text)
            {
                verificyVitory();
            }
            else if (casa_3.Text == casa_5.Text && casa_5.Text == casa_7.Text)
            {
                verificyVitory();
            }
            else if (casa_3.Text == casa_6.Text && casa_6.Text == casa_9.Text)
            {
                verificyVitory();
            }
            verificaVelha();
        }

        private void casa_4_Click(object sender, EventArgs e)
        {
            casa_4.Text = SwitchPlayer();

            if (casa_4.Text == casa_5.Text && casa_5.Text == casa_6.Text)
            {
                verificyVitory();
            }
            else if (casa_4.Text == casa_1.Text && casa_4.Text == casa_7.Text)
            {
                verificyVitory();
            }
            verificaVelha();
        }

        private void casa_5_Click(object sender, EventArgs e)
        {
            casa_5.Text = SwitchPlayer();
            if (casa_5.Text == casa_1.Text && casa_5.Text == casa_9.Text)
            {
                verificyVitory();
            }
            else if (casa_5.Text == casa_3.Text && casa_5.Text == casa_7.Text)
            {
                verificyVitory();
            }
            else if (casa_5.Text == casa_4.Text && casa_5.Text == casa_6.Text)
            {
                verificyVitory();
            }
            else if (casa_5.Text == casa_2.Text && casa_5.Text == casa_8.Text)
            {
                verificyVitory();
            }
            verificaVelha();

        }

        private void casa_6_Click(object sender, EventArgs e)
        {
            casa_6.Text = SwitchPlayer();
            if (casa_6.Text == casa_4.Text && casa_6.Text == casa_5.Text)
            {
                verificyVitory();
            }
            else if (casa_6.Text == casa_3.Text && casa_6.Text == casa_9.Text)
            {
                verificyVitory();
            }
            verificaVelha();

        }

        private void casa_7_Click(object sender, EventArgs e)
        {
            casa_7.Text = SwitchPlayer();
            if (casa_7.Text == casa_4.Text && casa_4.Text == casa_1.Text)
            {
                verificyVitory();
            }
            else if (casa_7.Text == casa_5.Text && casa_5.Text == casa_3.Text)
            {
                verificyVitory();
            }
            else if (casa_7.Text == casa_8.Text && casa_8.Text == casa_9.Text)
            {
                verificyVitory();
            }
            verificaVelha();
        }

        private void casa_8_Click(object sender, EventArgs e)
        {
            casa_8.Text = SwitchPlayer();
            if (casa_8.Text == casa_5.Text && casa_5.Text == casa_2.Text)
            {
                verificyVitory();
            }
            else if (casa_8.Text == casa_7.Text && casa_7.Text == casa_9.Text)
            {
                verificyVitory();
            }
            verificaVelha();
        }

        private void casa_9_Click(object sender, EventArgs e)
        {
            casa_9.Text = SwitchPlayer();
            if (casa_9.Text == casa_8.Text && casa_8.Text == casa_7.Text)
            {
                verificyVitory();
            }
            else if (casa_9.Text == casa_5.Text && casa_5.Text == casa_1.Text)
            {
                verificyVitory();
            }
            else if (casa_9.Text == casa_6.Text && casa_6.Text == casa_3.Text)
            {
                verificyVitory();
            }
            verificaVelha();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botaoJogar_Click(object sender, EventArgs e)
        {
            casa_1.Enabled = true;
            casa_2.Enabled = true;
            casa_3.Enabled = true;
            casa_4.Enabled = true;
            casa_5.Enabled = true;
            casa_6.Enabled = true;
            casa_7.Enabled = true;
            casa_8.Enabled = true;
            casa_9.Enabled = true;
            Winner.Text = "";
            limpar_Casas();
            label1.Text = "Jogando...";
            botaoLimpar.Enabled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
