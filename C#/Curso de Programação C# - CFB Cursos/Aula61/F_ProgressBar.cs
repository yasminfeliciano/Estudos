using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Aula61
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void btn_definirValor_Click(object sender, EventArgs e)
        {
            if((int.Parse(tb_value.Text) >= progressBar.Minimum) & (int.Parse(tb_value.Text) <= progressBar.Maximum))
            {
                progressBar.Value = int.Parse(tb_value.Text);
            }
        }

        private void btn_preencher_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Maximum = int.Parse(tb_contagem.Text);

            for(int i = 0; i <= int.Parse(tb_contagem.Text); i++)
            {
                label.Text = i.ToString();
                progressBar.Value = i;
                //Thread.Sleep(200);
            }
        }
    }
}
