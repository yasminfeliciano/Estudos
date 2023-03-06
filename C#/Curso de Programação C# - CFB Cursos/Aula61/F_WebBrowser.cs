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
    public partial class F_WebBrowser : Form
    {
        string home = null;
        string pesquisa = null;

        public F_WebBrowser()
        {
            InitializeComponent();
        }

        private void Navegar()
        {  
            if (tb_url.Text != "")
            {
                webBrowser.Navigate(tb_url.Text); 
            }
            else
            {
                MessageBox.Show("Digite uma URL");
                tb_url.Focus();
            }
        }

        private void btn_ir_Click(object sender, EventArgs e)
        {
            Navegar(); 
        }

        private void tb_url_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Navegar();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                webBrowser.GoHome();
            }
            else
            {
                webBrowser.Navigate(home);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void WebBrowser_CanGoForwardChanged(object sender, EventArgs e)
        {
            btn_proximo.Enabled = webBrowser.CanGoForward;
        }

        private void WebBrowser_CanGoBackChanged(object sender, EventArgs e)
        {
            btn_voltar.Enabled = webBrowser.CanGoBack;
        }

        private void btn_Parar_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            webBrowser.GoSearch();
        }

        private void btn_definirHome_Click(object sender, EventArgs e)
        {
            home = tb_url.Text;
        }
    }
}
