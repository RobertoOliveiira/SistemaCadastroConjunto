using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetoAula.SistemaCadastro.Forms
{
    public partial class Form2 : Form
    {
        private readonly Form1 _parent;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form)
        {
            InitializeComponent();
            _parent = form;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Convenio convenio = new Convenio(textBoxNome.Text);
            _parent.ConvenioRepository.Save(convenio);
            _parent.PopulaComboConvenio();
            Close();
        }
    }
}
