﻿using System;
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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
        }

        private void btn_novaTab_Click(object sender, EventArgs e)
        {
            if(tb_nomeNovaTab.Text != "")
            {
                TabPage pagina = new TabPage();
                pagina.Text = tb_nomeNovaTab.Text;
                pagina.Name = tb_nomeNovaTab.Text;
                pagina.TabIndex = tabControl.TabPages.Count;
                tabControl.TabPages.Add(pagina);
                tb_nomeNovaTab.Clear();
                DefinirMaximo();
            }
            else
            {
                MessageBox.Show("Digite o nome da nova tab");
                tb_nomeNovaTab.Focus();
            }
        }

        private void btn_removerTabAtual_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
            DefinirMaximo();
        }

        private void btn_posicionarTab_Click(object sender, EventArgs e)
        {
            //if (numericUpDown.Value < tabControl.TabPages.Count)
            //{
                tabControl.SelectedIndex = Int32.Parse(numericUpDown.Value.ToString());
            //}
        }

        private void DefinirMaximo()
        {
            numericUpDown.Maximum = tabControl.TabPages.Count - 1;
        }

        private void F_TabControl_Load(object sender, EventArgs e)
        {
            DefinirMaximo();
        }
    }
}
