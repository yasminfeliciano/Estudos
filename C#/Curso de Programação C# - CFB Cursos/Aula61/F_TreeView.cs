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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox2.Clear();
            textBox1.Text = treeView.SelectedNode.Text;

            if(treeView.SelectedNode.Tag !=null)
            {
                textBox2.Text = treeView.SelectedNode.Tag.ToString();
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            TreeNode raizEstados = treeView.Nodes.Add("Estados");
            raizEstados.Name = "raizEstados";

            TreeNode raizCores = treeView.Nodes.Add("Cores");
            raizCores.Name = "raizCores";

            TreeNode estado1 = raizEstados.Nodes.Add("Minas Gerais");
            estado1.Name = "Minas Gerais";

            TreeNode estado2 = raizEstados.Nodes.Add("Rio de Janeiro");
            estado1.Name = "Rio de Janeiro";

            TreeNode estado3 = raizEstados.Nodes.Add("São Paulo");
            estado1.Name = "São Paulo";
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                treeView.Nodes.Remove(treeView.Nodes["raizEstados"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao remover nó"+ ex.ToString());
            }
        }

        private void btn_removerSelecionado_Click(object sender, EventArgs e)
        {
            try
            {
                treeView.Nodes.Remove(treeView.SelectedNode);
            }
            catch
            {
                MessageBox.Show("Erro ao remover nó.");
            }
        }
    }
}
