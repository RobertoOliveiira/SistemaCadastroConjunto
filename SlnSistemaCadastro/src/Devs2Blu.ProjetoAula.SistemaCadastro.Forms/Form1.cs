using Correios;
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
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
                Pessoa pessoa = new Pessoa(txtNome.Text, txtCGCCPF.Text.Replace(',', '.'), TipoPessoa);
                pessoa.Id = PessoaRepository.Save(pessoa);

                Endereco endereco = new Endereco(pessoa, mskCEP.Text.Replace(',', '.'), txtRua.Text,
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
                }
            }
            else
            {
                MessageBox.Show(ValidaForm(), "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

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
                if (DialogResult == DialogResult.Yes)
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

        private void gridPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCGCCPF.Clear();
            mskCEP.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            txtNumero.Clear();
        }

        private void buttonCadConv_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + mskCEP.Text.Remove(2) + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Erro na requisição: " + ChecaServidor.StatusCode.ToString());
                return; // Encerra o código
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        String response = responseReader.ReadToEnd();
                        MessageBox.Show(response);
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");
                        MessageBox.Show(response);

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            // CEP
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(':');
                                mskCEP.Text = valor[1].ToString();
                            }

                            // Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(':');
                                txtRua.Text = valor[1].ToString();
                            }


                            // Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(':');
                                txtBairro.Text = valor[1].ToString();
                            }

                            // Cidade
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(':');
                                txtCidade.Text = valor[1].ToString();
                            }

                            // UF
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(':');
                                cboUF.Text = valor[1].ToString();
                            }
                            cont++;
                        }
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCGCCPF.Text))
                MessageBox.Show("O campo de CEP esta vazio", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                CorreiosApi correiosApi = new CorreiosApi();
                var retorno = correiosApi.consultaCEP(mskCEP.Text);

                if (retorno is null)
                {
                    MessageBox.Show("O campo de CEP esta vazio", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                txtBairro.Text = retorno.bairro;
                txtCidade.Text = retorno.cidade;
                txtRua.Text = retorno.end;
                cboUF.Text = retorno.uf;
            }
        }
    }
}
