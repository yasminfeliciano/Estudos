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
    public partial class F_PictureBox : Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void F_PictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.NomeCanal;
            label2.Text = Properties.Resources.EnderecoCanal;
        }        
        
        private void btn_logo1_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.Rabisco;
        }

        private void btn_logo2_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.cat;
        }
    }
}
