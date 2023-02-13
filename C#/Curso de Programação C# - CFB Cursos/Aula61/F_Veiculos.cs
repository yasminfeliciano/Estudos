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
    public partial class F_Veiculos : Form
    {
        F_Principal fp;

        public F_Veiculos(string v, F_Principal f)
        {
            InitializeComponent();

            tb_listaVeiculos.Text = v;

            fp = f;

            f.num = 10;
        }

        private void tb_listaVeiculos_TextChanged(object sender, EventArgs e)
        {
            fp.tb_listaVeiculos.Text = tb_listaVeiculos.Text;
        }
    }
}
