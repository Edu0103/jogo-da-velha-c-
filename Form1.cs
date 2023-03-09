using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppJogoDaVelha
{
    public partial class Form1 : Form
    {
        bool jogo = true;
        int jogada = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(jogo)
            {
                button1.Text = "X";
                jogo = false;
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
                Testa8(1);
                jogada++;
            }
            else
            {
                button1.Text = "O";
                jogo = true;
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
                Testa8(2);
                jogada++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jogo)
            {
                button2.Text = "X";
                jogo = false;
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
                Testa8(1);
                jogada++;
            }
            else
            {
                button2.Text = "O";
                jogo = true;
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
                Testa8(2);
                jogada++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (jogo)
            {
                button3.Text = "X";
                jogo = false;
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
                Testa8(1);
                jogada++;
            }
            else
            {
                button3.Text = "O";
                jogo = true;
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
                Testa8(2);
                jogada++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (jogo)
            {
                button6.Text = "X";
                jogo = false;
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
                Testa8(1);
                jogada++;
            }
            else
            {
                button6.Text = "O";
                jogo = true;
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
                Testa8(2);
                jogada++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (jogo)
            {
                button5.Text = "X";
                jogo = false;
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
                Testa8(1);
                jogada++;
            }
            else
            {
                button5.Text = "O";
                jogo = true;
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
                Testa8(2);
                jogada++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (jogo)
            {
                button4.Text = "X";
                jogo = false;
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
                Testa8(1);
                jogada++;
            }
            else
            {
                button4.Text = "O";
                jogo = true;
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
                Testa8(2);
                jogada++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (jogo)
            {
                button9.Text = "X";
                jogo = false;
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
                Testa8(1);
                jogada++;
            }
            else
            {
                button9.Text = "O";
                jogo = true;
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
                Testa8(2);
                jogada++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (jogo)
            {
                button8.Text = "X";
                jogo = false;
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
                Testa8(1);
                jogada++;
            }
            else
            {
                button8.Text = "O";
                jogo = true;
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
                Testa8(2);
                jogada++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (jogo)
            {
                button7.Text = "X";
                jogo = false;
                Testa1(1);
                Testa2(1);
                Testa3(1);
                Testa4(1);
                Testa5(1);
                Testa6(1);
                Testa7(1);
                Testa8(1);
                jogada++;
            }
            else
            {
                button7.Text = "O";
                jogo = true;
                Testa1(2);
                Testa2(2);
                Testa3(2);
                Testa4(2);
                Testa5(2);
                Testa6(2);
                Testa7(2);
                Testa8(2);
                jogada++;
            }
        }

       public void Testa1(int jogador)
        {
            String t = "";
            if(jogador == 1)
            {
                t = "X";
                if (t == button1.Text && t == button2.Text && t == button3.Text)
                {
                    MessageBox.Show("Jogador 1 Venceu");
                }
            }
            else
            {
                t = "O";
                if (t == button1.Text && t == button2.Text && t == button3.Text)
                {
                    MessageBox.Show("Jogador 2 Venceu");
                }
            }
           
        }
        public void Testa2(int jogador)
        {
            String t = "";
            if (jogador == 1)
            {
                t = "X";
                if (t == button4.Text && t == button5.Text && t == button6.Text)
                {
                    MessageBox.Show("Jogador 1 Venceu");
                }
            }
            else
            {
                t = "O";
                if (t == button4.Text && t == button4.Text && t == button6.Text)
                {
                    MessageBox.Show("Jogador 2 Venceu");
                }
            }

        }

        public void Testa3(int jogador)
        {
            String t = "";
            if (jogador == 1)
            {
                t = "X";
                if (t == button7.Text && t == button8.Text && t == button9.Text)
                {
                    MessageBox.Show("Jogador 1 Venceu");
                }
            }
            else
            {
                t = "O";
                if (t == button7.Text && t == button8.Text && t == button9.Text)
                {
                    MessageBox.Show("Jogador 2 Venceu");
                }
            }

        }

        public void Testa4(int jogador)
        {
            String t = "";
            if (jogador == 1)
            {
                t = "X";
                if (t == button1.Text && t == button6.Text && t == button9.Text)
                {
                    MessageBox.Show("Jogador 1 Venceu");
                }
            }
            else
            {
                t = "O";
                if (t == button1.Text && t == button6.Text && t == button9.Text)
                {
                    MessageBox.Show("Jogador 2 Venceu");
                }
            }

        }

        public void Testa5(int jogador)
        {
            String t = "";
            if (jogador == 1)
            {
                t = "X";
                if (t == button2.Text && t == button5.Text && t == button8.Text)
                {
                    MessageBox.Show("Jogador 1 Venceu");
                }
            }
            else
            {
                t = "O";
                if (t == button2.Text && t == button5.Text && t == button8.Text)
                {
                    MessageBox.Show("Jogador 2 Venceu");
                }
            }

        }

        public void Testa6(int jogador)
        {
            String t = "";
            if (jogador == 1)
            {
                t = "X";
                if (t == button3.Text && t == button4.Text && t == button7.Text)
                {
                    MessageBox.Show("Jogador 1 Venceu");
                }
            }
            else
            {
                t = "O";
                if (t == button3.Text && t == button4.Text && t == button7.Text)
                {
                    MessageBox.Show("Jogador 2 Venceu");
                }
            }

        }

        public void Testa7(int jogador)
        {
            String t = "";
            if (jogador == 1)
            {
                t = "X";
                if (t == button1.Text && t == button5.Text && t == button7.Text)
                {
                    MessageBox.Show("Jogador 1 Venceu");
                }
            }
            else
            {
                t = "O";
                if (t == button1.Text && t == button5.Text && t == button7.Text)
                {
                    MessageBox.Show("Jogador 2 Venceu");
                }
            }

        }

        public void Testa8(int jogador)
        {
            String t = "";
            if (jogador == 1)
            {
                t = "X";
                if (t == button3.Text && t == button5.Text && t == button9.Text)
                {
                    MessageBox.Show("Jogador 1 Venceu");
                }
            }
            else
            {
                t = "O";
                if (t == button3.Text && t == button5.Text && t == button9.Text)
                {
                    MessageBox.Show("Jogador 2 Venceu");
                }
            }

        }

    }

}
