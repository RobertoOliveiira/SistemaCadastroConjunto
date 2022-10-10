namespace Devs2Blu.ProjetoAula.SistemaCadastro.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpConteudo = new System.Windows.Forms.GroupBox();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.cboConvenio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rdFisica = new System.Windows.Forms.RadioButton();
            this.rdJuridica = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCGCCPF = new System.Windows.Forms.Label();
            this.gpEnderecoCadastro = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCGCCPF = new System.Windows.Forms.MaskedTextBox();
            this.buttonCadConv = new System.Windows.Forms.Button();
            this.gpFormCadastro = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.gpConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.gpTipoPessoa.SuspendLayout();
            this.gpEnderecoCadastro.SuspendLayout();
            this.gpFormCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Location = new System.Drawing.Point(326, 115);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 63);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gpConteudo
            // 
            this.gpConteudo.Controls.Add(this.gridPacientes);
            this.gpConteudo.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpConteudo.Location = new System.Drawing.Point(26, 194);
            this.gpConteudo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gpConteudo.Name = "gpConteudo";
            this.gpConteudo.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gpConteudo.Size = new System.Drawing.Size(872, 333);
            this.gpConteudo.TabIndex = 4;
            this.gpConteudo.TabStop = false;
            // 
            // gridPacientes
            // 
            this.gridPacientes.AllowUserToAddRows = false;
            this.gridPacientes.AllowUserToOrderColumns = true;
            this.gridPacientes.BackgroundColor = System.Drawing.Color.White;
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.GridColor = System.Drawing.Color.Silver;
            this.gridPacientes.Location = new System.Drawing.Point(0, 5);
            this.gridPacientes.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.ReadOnly = true;
            this.gridPacientes.Size = new System.Drawing.Size(872, 328);
            this.gridPacientes.TabIndex = 5;
            this.gridPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPacientes_CellContentClick);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(951, 28);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(731, 557);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(113, 63);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(843, 570);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(55, 37);
            this.btnInfo.TabIndex = 16;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // cboConvenio
            // 
            this.cboConvenio.FormattingEnabled = true;
            this.cboConvenio.Location = new System.Drawing.Point(268, 83);
            this.cboConvenio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cboConvenio.Name = "cboConvenio";
            this.cboConvenio.Size = new System.Drawing.Size(117, 26);
            this.cboConvenio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Convênio";
            // 
            // gpTipoPessoa
            // 
            this.gpTipoPessoa.BackColor = System.Drawing.Color.White;
            this.gpTipoPessoa.Controls.Add(this.rdJuridica);
            this.gpTipoPessoa.Controls.Add(this.rdFisica);
            this.gpTipoPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpTipoPessoa.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTipoPessoa.ForeColor = System.Drawing.Color.Black;
            this.gpTipoPessoa.Location = new System.Drawing.Point(26, 115);
            this.gpTipoPessoa.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gpTipoPessoa.Name = "gpTipoPessoa";
            this.gpTipoPessoa.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gpTipoPessoa.Size = new System.Drawing.Size(183, 47);
            this.gpTipoPessoa.TabIndex = 7;
            this.gpTipoPessoa.TabStop = false;
            this.gpTipoPessoa.Text = "Tipo Pessoa";
            // 
            // rdFisica
            // 
            this.rdFisica.AutoSize = true;
            this.rdFisica.Checked = true;
            this.rdFisica.Location = new System.Drawing.Point(23, 17);
            this.rdFisica.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rdFisica.Name = "rdFisica";
            this.rdFisica.Size = new System.Drawing.Size(58, 22);
            this.rdFisica.TabIndex = 6;
            this.rdFisica.TabStop = true;
            this.rdFisica.Text = "Física";
            this.rdFisica.UseVisualStyleBackColor = true;
            this.rdFisica.CheckedChanged += new System.EventHandler(this.rdFisica_CheckedChanged);
            // 
            // rdJuridica
            // 
            this.rdJuridica.AutoSize = true;
            this.rdJuridica.Location = new System.Drawing.Point(91, 17);
            this.rdJuridica.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rdJuridica.Name = "rdJuridica";
            this.rdJuridica.Size = new System.Drawing.Size(71, 22);
            this.rdJuridica.TabIndex = 7;
            this.rdJuridica.Text = "Jurídica";
            this.rdJuridica.UseVisualStyleBackColor = true;
            this.rdJuridica.CheckedChanged += new System.EventHandler(this.rdJuridica_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(159, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 8;
            // 
            // lblCGCCPF
            // 
            this.lblCGCCPF.AutoSize = true;
            this.lblCGCCPF.Location = new System.Drawing.Point(32, 88);
            this.lblCGCCPF.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCGCCPF.Name = "lblCGCCPF";
            this.lblCGCCPF.Size = new System.Drawing.Size(30, 18);
            this.lblCGCCPF.TabIndex = 9;
            this.lblCGCCPF.Text = "CPF";
            // 
            // gpEnderecoCadastro
            // 
            this.gpEnderecoCadastro.BackColor = System.Drawing.Color.White;
            this.gpEnderecoCadastro.Controls.Add(this.mskCEP);
            this.gpEnderecoCadastro.Controls.Add(this.txtRua);
            this.gpEnderecoCadastro.Controls.Add(this.label6);
            this.gpEnderecoCadastro.Controls.Add(this.txtBairro);
            this.gpEnderecoCadastro.Controls.Add(this.label4);
            this.gpEnderecoCadastro.Controls.Add(this.label5);
            this.gpEnderecoCadastro.Controls.Add(this.txtNumero);
            this.gpEnderecoCadastro.Controls.Add(this.label7);
            this.gpEnderecoCadastro.Controls.Add(this.label8);
            this.gpEnderecoCadastro.Controls.Add(this.cboUF);
            this.gpEnderecoCadastro.Controls.Add(this.label9);
            this.gpEnderecoCadastro.Controls.Add(this.txtCidade);
            this.gpEnderecoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpEnderecoCadastro.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEnderecoCadastro.ForeColor = System.Drawing.Color.Black;
            this.gpEnderecoCadastro.Location = new System.Drawing.Point(459, 13);
            this.gpEnderecoCadastro.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gpEnderecoCadastro.Name = "gpEnderecoCadastro";
            this.gpEnderecoCadastro.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gpEnderecoCadastro.Size = new System.Drawing.Size(439, 149);
            this.gpEnderecoCadastro.TabIndex = 10;
            this.gpEnderecoCadastro.TabStop = false;
            this.gpEnderecoCadastro.Text = "Endereço/Contato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nº";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rua";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cidade";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(283, 34);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(135, 22);
            this.txtCidade.TabIndex = 19;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(56, 73);
            this.txtRua.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(362, 22);
            this.txtRua.TabIndex = 20;
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboUF.Location = new System.Drawing.Point(168, 34);
            this.cboUF.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(51, 26);
            this.cboUF.TabIndex = 13;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(56, 113);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(44, 22);
            this.txtNumero.TabIndex = 21;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(168, 112);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(250, 22);
            this.txtBairro.TabIndex = 22;
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(56, 34);
            this.mskCEP.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.mskCEP.Mask = "00.000-00";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(73, 22);
            this.mskCEP.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 46);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(354, 22);
            this.txtNome.TabIndex = 11;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(219, 115);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(113, 63);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCGCCPF
            // 
            this.txtCGCCPF.Location = new System.Drawing.Point(72, 85);
            this.txtCGCCPF.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCGCCPF.Mask = "000.000.000-00";
            this.txtCGCCPF.Name = "txtCGCCPF";
            this.txtCGCCPF.Size = new System.Drawing.Size(116, 22);
            this.txtCGCCPF.TabIndex = 17;
            // 
            // buttonCadConv
            // 
            this.buttonCadConv.FlatAppearance.BorderSize = 0;
            this.buttonCadConv.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadConv.Location = new System.Drawing.Point(395, 83);
            this.buttonCadConv.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonCadConv.Name = "buttonCadConv";
            this.buttonCadConv.Size = new System.Drawing.Size(30, 28);
            this.buttonCadConv.TabIndex = 18;
            this.buttonCadConv.Text = "+";
            this.buttonCadConv.UseVisualStyleBackColor = true;
            this.buttonCadConv.Click += new System.EventHandler(this.buttonCadConv_Click);
            // 
            // gpFormCadastro
            // 
            this.gpFormCadastro.BackColor = System.Drawing.Color.White;
            this.gpFormCadastro.Controls.Add(this.btnAtualizar);
            this.gpFormCadastro.Controls.Add(this.groupBox1);
            this.gpFormCadastro.Controls.Add(this.btnLimpar);
            this.gpFormCadastro.Controls.Add(this.groupBox3);
            this.gpFormCadastro.Controls.Add(this.btnExcluir);
            this.gpFormCadastro.Controls.Add(this.btnInfo);
            this.gpFormCadastro.Controls.Add(this.gpConteudo);
            this.gpFormCadastro.Controls.Add(this.groupBox2);
            this.gpFormCadastro.Controls.Add(this.buttonCadConv);
            this.gpFormCadastro.Controls.Add(this.gpTipoPessoa);
            this.gpFormCadastro.Controls.Add(this.btnSalvar);
            this.gpFormCadastro.Controls.Add(this.txtCGCCPF);
            this.gpFormCadastro.Controls.Add(this.txtNome);
            this.gpFormCadastro.Controls.Add(this.lblCGCCPF);
            this.gpFormCadastro.Controls.Add(this.gpEnderecoCadastro);
            this.gpFormCadastro.Controls.Add(this.label3);
            this.gpFormCadastro.Controls.Add(this.label2);
            this.gpFormCadastro.Controls.Add(this.label1);
            this.gpFormCadastro.Controls.Add(this.cboConvenio);
            this.gpFormCadastro.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpFormCadastro.ForeColor = System.Drawing.Color.Black;
            this.gpFormCadastro.Location = new System.Drawing.Point(14, 37);
            this.gpFormCadastro.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gpFormCadastro.Name = "gpFormCadastro";
            this.gpFormCadastro.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gpFormCadastro.Size = new System.Drawing.Size(924, 626);
            this.gpFormCadastro.TabIndex = 3;
            this.gpFormCadastro.TabStop = false;
            this.gpFormCadastro.Text = "Formulário de Cadastro";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 543);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 10);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 10);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox3.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 10);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(627, 557);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(113, 63);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(951, 672);
            this.Controls.Add(this.gpFormCadastro);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form1";
            this.Text = "+Devs2Blu - Sistema de Cadastro Hospitalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.gpTipoPessoa.ResumeLayout(false);
            this.gpTipoPessoa.PerformLayout();
            this.gpEnderecoCadastro.ResumeLayout(false);
            this.gpEnderecoCadastro.PerformLayout();
            this.gpFormCadastro.ResumeLayout(false);
            this.gpFormCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpConteudo;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ComboBox cboConvenio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpTipoPessoa;
        private System.Windows.Forms.RadioButton rdJuridica;
        private System.Windows.Forms.RadioButton rdFisica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCGCCPF;
        private System.Windows.Forms.GroupBox gpEnderecoCadastro;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox txtCGCCPF;
        private System.Windows.Forms.Button buttonCadConv;
        private System.Windows.Forms.GroupBox gpFormCadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAtualizar;
    }
}

