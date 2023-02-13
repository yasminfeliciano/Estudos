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
    public partial class F_MonthCalendar : Form
    {
        public F_MonthCalendar()
        {
            InitializeComponent();
        }

        private void btn_pegarData_Click(object sender, EventArgs e)
        {
            tb_dataInicial.Text = monthCalendar.SelectionStart.ToShortDateString();
            tb_dataFinal.Text = monthCalendar.SelectionEnd.ToShortDateString();
            tb_dataHoje.Text = monthCalendar.TodayDate.ToShortDateString();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            tb_dataInicial.Text = monthCalendar.SelectionStart.ToShortDateString();
            tb_dataFinal.Text = monthCalendar.SelectionEnd.ToShortDateString();
            tb_dataHoje.Text = monthCalendar.TodayDate.ToShortDateString();
        }
    }
}
