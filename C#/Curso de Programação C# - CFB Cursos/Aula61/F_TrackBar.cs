using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula61
{
    public partial class F_TrackBar : Form
    {
        public F_TrackBar()
        {
            InitializeComponent();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            tb_valor.Text = trackBar.Value.ToString();
            label.Text = trackBar.Value.ToString();
        }

        private void btn_definir_Click(object sender, EventArgs e)
        {
            if(int.Parse(tb_valor.Text) < trackBar.Minimum)
            {
                MessageBox.Show("Valor muito pequeno");
                return;
            }

            if (int.Parse(tb_valor.Text) > trackBar.Maximum)
            {
                MessageBox.Show("Valor muito grande");
                return;
            }

            trackBar.Value = int.Parse(tb_valor.Text);
        }
    }
}
