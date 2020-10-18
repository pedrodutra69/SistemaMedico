using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico
{
    public partial class SistemaMedico : Form
    {
        public SistemaMedico()
        {
            InitializeComponent();
        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CadastroCli = new CadastroCli();
            CadastroCli.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Agendacli = new Agendacli();
            Agendacli.Show();
        }
    }
}
