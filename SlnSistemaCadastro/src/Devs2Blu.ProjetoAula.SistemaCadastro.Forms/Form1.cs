using Devs2Blu.ProjetoAula.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        public MySqlConnection Conn { get; set; }
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public PacienteRepository PacienteRepository = new PacienteRepository();
        public PessoaRepository PessoaRepository = new PessoaRepository();
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();
        public TipoPessoa TipoPessoa { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        #region Methods

        public void PopulaComboConvenio()
        {
            var listConvenios = ConvenioRepository.FetchAll();
            cboConvenio.DataSource = new BindingSource(listConvenios, null);
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";
        }

        private void PopulaDataGridPessoa()
        {
            var listPessoas = PessoaRepository.GetPessoas();
            gridPacientes.DataSource = new BindingSource(listPessoas, null);
        }

        public String ValidaForm()
        {
            if (txtNome.Text.Equals("")) return "O campo nome é obrigatório";
            if (txtCGCCPF.Text.Equals("")) return "O campo de documento é obrigatório";
            if (cboConvenio.Text.Equals("")) return "O campo convenio é obrigatório";
            if (txtCidade.Text.Equals("")) return "O campo cidade é obrigatório";
            if (txtBairro.Text.Equals("")) return "O campo bairro é obrigatório";
            if (txtRua.Text.Equals("")) return "O campo rua é obrigatório";
            if (txtNumero.Text.Equals("")) return "O campo numero é obrigatório";
            if (!(rdFisica.Checked || rdJuridica.Checked)) return "Selecione o tipo de usuário";
            return "";
        }

        public void Limpar()
        {
            txtNome.Clear();
            txtCGCCPF.Clear();
            mskCEP.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            txtNumero.Clear();
        }
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            #region TesteConexao
            /*Conn = ConnectionMySQL.GetConnection();

            if (Conn.State == ConnectionState.Open) {
            MessageBox.Show("Conexão efetuado com sucesso!", "Conexão ao MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Conn.Close();
            } */
            #endregion
            PopulaComboConvenio();
            PopulaDataGridPessoa();
        }

        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFisica.Checked)
            {
                lblCGCCPF.Text = "CPF";
                lblCGCCPF.Visible = true;
                TipoPessoa = TipoPessoa.PF;
            }
        }

        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdJuridica.Checked)
            {
                lblCGCCPF.Text = "CNPJ";
                lblCGCCPF.Visible = true;
                TipoPessoa = TipoPessoa.PJ;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm().Equals(""))
            {
                Pessoa pessoa = new Pessoa(txtNome.Text, txtCGCCPF.Text.Replace(',', '.'),TipoPessoa);
                pessoa.Id = PessoaRepository.Save(pessoa);
                
                Endereco endereco = new Endereco(pessoa, mskCEP.Text.Replace(',', '.'),txtRua.Text,
                    Int32.Parse(txtNumero.Text), txtBairro.Text, txtCidade.Text, cboUF.Text);
                EnderecoRepository.Save(endereco);
                
                Paciente paciente = new Paciente();
                paciente.Pessoa.Id = pessoa.Id;
                paciente.Convenio.Id = (int)cboConvenio.SelectedValue;
                Paciente pacienteResult = PacienteRepository.Save(paciente);
                
                if (pacienteResult.Pessoa.Id > 0)
                {
                    MessageBox.Show($"Pessoa {paciente.Pessoa.Id} - {paciente.Pessoa.Nome} salva com sucesso!", "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridPessoa();
                    Limpar();
                }
            }
            else
            {
                MessageBox.Show(ValidaForm(), "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cora Amorim \r\nRoberto Oliveira\r\nBernardo Miguel\r\nPedro Evers \r\nJailson Roth", "Desenvolvedores");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = (int)gridPacientes.CurrentRow.Cells[0].Value;
            if (PessoaRepository.Delete(pessoa))
            {
                MessageBox.Show("Paciente apagado com sucesso", "Deletar paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult = MessageBox.Show("Paciente possui informações salvas no banco, deseja apagar mesmo assim?", "Deletar Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(DialogResult == DialogResult.Yes)
                {
                    EnderecoRepository.DeletePessoa(pessoa.Id);
                    PacienteRepository.DeletePessoa(pessoa.Id);
                    PessoaRepository.Delete(pessoa);
                }
                else
                {
                    Close();
                }
            }
            PopulaDataGridPessoa();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void buttonCadConv_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            
            if (ValidaForm().Equals(""))
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Id = (int)gridPacientes.CurrentRow.Cells[0].Value;

                pessoa.Nome = txtNome.Text;
                pessoa.CGCCPF = txtCGCCPF.Text.Replace(',', '.');
                PessoaRepository.Update(pessoa);

                Endereco endereco = new Endereco(pessoa, mskCEP.Text.Replace(',', '.'), txtRua.Text,
                    Int32.Parse(txtNumero.Text), txtBairro.Text, txtCidade.Text, cboUF.Text);
                EnderecoRepository.Update(endereco);

                Paciente paciente = new Paciente();
                paciente.Pessoa.Id = pessoa.Id;
                paciente.Convenio.Id = (int)cboConvenio.SelectedValue;
                PacienteRepository.Update(paciente);

                PopulaDataGridPessoa();
                Limpar();
            }
            else
            {
                MessageBox.Show(ValidaForm(), "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridPacientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var tbPessoa = PessoaRepository.GetPessoaById((int)gridPacientes.CurrentRow.Cells[0].Value);
            if (tbPessoa.Read())
            {
                txtNome.Text = tbPessoa.GetValue(1).ToString();
                txtCGCCPF.Text = tbPessoa.GetValue(2).ToString();
            }
            var tbEndereco = EnderecoRepository.GetEnderecoByPessoaId((int)gridPacientes.CurrentRow.Cells[0].Value);
            if (tbEndereco.Read())
            {
                mskCEP.Text = tbEndereco.GetValue(2).ToString();
                txtCidade.Text = tbEndereco.GetValue(6).ToString(); ;
                txtBairro.Text = tbEndereco.GetValue(5).ToString(); ;
                txtRua.Text = tbEndereco.GetValue(3).ToString(); ;
                txtNumero.Text = tbEndereco.GetValue(4).ToString();
            }
        }
        #endregion
    }


}
