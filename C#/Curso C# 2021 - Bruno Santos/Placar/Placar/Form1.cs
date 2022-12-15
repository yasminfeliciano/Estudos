using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarFicheiro();
            CarregarImagem(pb_clube1, lbl_nomeClube1.Text);
            CarregarImagem(pb_clube2, lbl_nomeClube2.Text);   
        }

        private void CarregarFicheiro()
        {
            //string texto = File.ReadAllText("jogo.txt", Encoding.UTF8);

            string texto = "";

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                texto = File.ReadAllText(openFileDialog1.FileName);
            }

            string[] parms = texto.Split(';');

            lbl_nomeClube1.Text = parms[0];
            lbl_nomeClube2.Text = parms[1];
            lbl_resultadoClube1.Text = parms[2];
            lbl_resultadoClube2.Text = parms[3];
            min = int.Parse(parms[4]);
            seg = int.Parse(parms[5]);

            texto = "";
            if (min < 10)
            {
                texto += "0" + min;
            }
            else
            {
                texto += min;
            }

            if (seg < 10)
            {
                texto += ":0" + seg;
            }
            else
            {
                texto += ":" + seg;
            }

            lbl_cronometro.Text = texto;

            if (min < 45)
            {
                lbl_parte.Text = "1ª Parte";
            }
            else
            {
                lbl_parte.Text = "2ª Parte";
            }
        }

        private void CarregarImagem(PictureBox pb_clube, string text)
        {
            if (text.Equals("Corinthians"))
            {
                pb_clube.Image = Properties.Resources.corinthians;
            }
            else if (text.Equals("Santos"))
            {
                pb_clube.Image = Properties.Resources.santos;
            }
            else if (text.Equals("São Paulo"))
            {
                pb_clube.Image = Properties.Resources.sao_paulo;
            }
            else if (text.Equals("Palmeiras"))
            {
                pb_clube.Image = Properties.Resources.palmeiras;
            }
            else if (text.Equals("Japão"))
            {
                pb_clube.Image = Properties.Resources.japao;
            }
            else if (text.Equals("Brasil"))
            {
                pb_clube.Image = Properties.Resources.brasil;
            }
        }

        private void bt_maisClube1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lbl_resultadoClube1.Text) + 1;
            lbl_resultadoClube1.Text = score.ToString();
        }

        private void bt_menosClube1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lbl_resultadoClube1.Text);
            if (score > 0)
            {
                score--;
                lbl_resultadoClube1.Text = score.ToString();
            }
        }

        private void bt_maisClube2_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lbl_resultadoClube2.Text) + 1;
            lbl_resultadoClube2.Text = score.ToString();
        }

        private void bt_menosClube2_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lbl_resultadoClube2.Text);
            if (score > 0)
            {
                score--;
                lbl_resultadoClube2.Text = score.ToString();
            }
        }

        int min = 0, seg = 0;

        private void bt_comecarJogo_Click(object sender, EventArgs e)
        {
            if (min == 90)
            {
                string resultadoFinal = lbl_nomeClube1.Text + ";" + lbl_nomeClube2.Text + ";" + lbl_resultadoClube1.Text + ";" + lbl_resultadoClube2.Text + ";" + min + ";" + seg;

                //File.WriteAllText("jogo.txt", resultadoFinal);

                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "txt files (*.txt) | *.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        myStream.Close();
                    }
                    File.WriteAllText(saveFileDialog1.FileName, resultadoFinal);
                }

                min = 0;
                seg = 0;
                lbl_cronometro.Text = "00:00";
                bt_comecarjogo.Text = "Começar Jogo";
                lbl_resultadoClube1.Text = "0";
                lbl_resultadoClube2.Text = "0";
                lbl_parte.Text = "1º Parte";
            }
            else
            {
                cronometro.Enabled = true;
                bt_comecarjogo.Visible = false;
                AtivarBotoes();
            }
        }

        private void AtivarBotoes()
        {
            bt_maisClube1.Enabled = true;
            bt_maisClube2.Enabled = true;
            bt_menosClube1.Enabled = true;
            bt_menosClube2.Enabled = true;
        }

        private void DesativarBotoes()
        {
            bt_maisClube1.Enabled = false;
            bt_maisClube2.Enabled = false;
            bt_menosClube1.Enabled = false;
            bt_menosClube2.Enabled = false;
        }

        private void cronometro_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }

            string texto = "";
            if (min < 10)
            {
                texto += "0" + min;
            }
            else
            {
                texto += min;
            }

            if (seg < 10)
            {
                texto += ":0" + seg;
            }
            else
            {
                texto += ":" + seg;
            }

            lbl_cronometro.Text = texto;

            if (min < 45)
            {
                lbl_parte.Text = "1ª Parte";
            }
            else
            {
                lbl_parte.Text = "2ª Parte";
            }

            if((min == 45 && seg == 0) || (min==90))
            {
                cronometro.Enabled = false;
                bt_comecarjogo.Visible = true;
                DesativarBotoes();

                if (min == 45)
                {
                    bt_comecarjogo.Text = "Começar 2ª Parte";
                }
                else if (min==90){
                    bt_comecarjogo.Text = "Gravar e recomeçar";
                }
            }
        }
    }
}
