namespace atv1PDS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_cnpj = new System.Windows.Forms.Label();
            this.lb_razao_social = new System.Windows.Forms.Label();
            this.tb_razao_social = new System.Windows.Forms.TextBox();
            this.tb_fantasia = new System.Windows.Forms.TextBox();
            this.lb_fantasia = new System.Windows.Forms.Label();
            this.lb_situacao_cad = new System.Windows.Forms.Label();
            this.cb_situacao_cad = new System.Windows.Forms.ComboBox();
            this.lb_regime_tributario = new System.Windows.Forms.Label();
            this.rb_simples_nacional = new System.Windows.Forms.RadioButton();
            this.rb_lucro_presumido = new System.Windows.Forms.RadioButton();
            this.rb_lucro_real = new System.Windows.Forms.RadioButton();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lb_capital_social = new System.Windows.Forms.Label();
            this.tb_capitalsocial = new System.Windows.Forms.TextBox();
            this.lb_endereco = new System.Windows.Forms.Label();
            this.lb_rua = new System.Windows.Forms.Label();
            this.lb_cep = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.lb_bairro = new System.Windows.Forms.Label();
            this.lb_complemento = new System.Windows.Forms.Label();
            this.lb_estado = new System.Windows.Forms.Label();
            this.tb_cep = new System.Windows.Forms.TextBox();
            this.tb_complemento = new System.Windows.Forms.TextBox();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.tb_rua = new System.Windows.Forms.TextBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.lb_tipo = new System.Windows.Forms.Label();
            this.rb_matriz = new System.Windows.Forms.RadioButton();
            this.rb_filial = new System.Windows.Forms.RadioButton();
            this.lb_porte = new System.Windows.Forms.Label();
            this.rb_pequeno = new System.Windows.Forms.RadioButton();
            this.rb_grande = new System.Windows.Forms.RadioButton();
            this.rb_medio = new System.Windows.Forms.RadioButton();
            this.lb_nat_juridica = new System.Windows.Forms.Label();
            this.cb_nat_juridica = new System.Windows.Forms.ComboBox();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mtb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.lb_dataInicio = new System.Windows.Forms.Label();
            this.dtp_dataInicio = new System.Windows.Forms.DateTimePicker();
            this.lb_cadastro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_cnpj
            // 
            this.lb_cnpj.AutoSize = true;
            this.lb_cnpj.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cnpj.Location = new System.Drawing.Point(77, 105);
            this.lb_cnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cnpj.Name = "lb_cnpj";
            this.lb_cnpj.Size = new System.Drawing.Size(54, 24);
            this.lb_cnpj.TabIndex = 0;
            this.lb_cnpj.Text = "CNPJ";
            this.lb_cnpj.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_razao_social
            // 
            this.lb_razao_social.AutoSize = true;
            this.lb_razao_social.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_razao_social.Location = new System.Drawing.Point(77, 156);
            this.lb_razao_social.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_razao_social.Name = "lb_razao_social";
            this.lb_razao_social.Size = new System.Drawing.Size(117, 24);
            this.lb_razao_social.TabIndex = 1;
            this.lb_razao_social.Text = "Razão Social";
            // 
            // tb_razao_social
            // 
            this.tb_razao_social.Location = new System.Drawing.Point(263, 158);
            this.tb_razao_social.Margin = new System.Windows.Forms.Padding(4);
            this.tb_razao_social.Name = "tb_razao_social";
            this.tb_razao_social.Size = new System.Drawing.Size(257, 22);
            this.tb_razao_social.TabIndex = 3;
            this.tb_razao_social.TextChanged += new System.EventHandler(this.tb_razao_social_TextChanged);
            // 
            // tb_fantasia
            // 
            this.tb_fantasia.Location = new System.Drawing.Point(263, 214);
            this.tb_fantasia.Margin = new System.Windows.Forms.Padding(4);
            this.tb_fantasia.Name = "tb_fantasia";
            this.tb_fantasia.Size = new System.Drawing.Size(257, 22);
            this.tb_fantasia.TabIndex = 4;
            // 
            // lb_fantasia
            // 
            this.lb_fantasia.AutoSize = true;
            this.lb_fantasia.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fantasia.Location = new System.Drawing.Point(77, 215);
            this.lb_fantasia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fantasia.Name = "lb_fantasia";
            this.lb_fantasia.Size = new System.Drawing.Size(137, 24);
            this.lb_fantasia.TabIndex = 5;
            this.lb_fantasia.Text = "Nome Fantasia";
            // 
            // lb_situacao_cad
            // 
            this.lb_situacao_cad.AutoSize = true;
            this.lb_situacao_cad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_situacao_cad.Location = new System.Drawing.Point(77, 278);
            this.lb_situacao_cad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_situacao_cad.Name = "lb_situacao_cad";
            this.lb_situacao_cad.Size = new System.Drawing.Size(167, 24);
            this.lb_situacao_cad.TabIndex = 6;
            this.lb_situacao_cad.Text = "Situação Cadastral";
            // 
            // cb_situacao_cad
            // 
            this.cb_situacao_cad.FormattingEnabled = true;
            this.cb_situacao_cad.Items.AddRange(new object[] {
            "Ativa",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.cb_situacao_cad.Location = new System.Drawing.Point(263, 278);
            this.cb_situacao_cad.Margin = new System.Windows.Forms.Padding(4);
            this.cb_situacao_cad.Name = "cb_situacao_cad";
            this.cb_situacao_cad.Size = new System.Drawing.Size(257, 24);
            this.cb_situacao_cad.TabIndex = 7;
            // 
            // lb_regime_tributario
            // 
            this.lb_regime_tributario.AutoSize = true;
            this.lb_regime_tributario.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_regime_tributario.Location = new System.Drawing.Point(77, 336);
            this.lb_regime_tributario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_regime_tributario.Name = "lb_regime_tributario";
            this.lb_regime_tributario.Size = new System.Drawing.Size(165, 24);
            this.lb_regime_tributario.TabIndex = 8;
            this.lb_regime_tributario.Text = "Regime Tributário";
            // 
            // rb_simples_nacional
            // 
            this.rb_simples_nacional.AutoSize = true;
            this.rb_simples_nacional.Location = new System.Drawing.Point(7, 9);
            this.rb_simples_nacional.Margin = new System.Windows.Forms.Padding(4);
            this.rb_simples_nacional.Name = "rb_simples_nacional";
            this.rb_simples_nacional.Size = new System.Drawing.Size(134, 20);
            this.rb_simples_nacional.TabIndex = 9;
            this.rb_simples_nacional.TabStop = true;
            this.rb_simples_nacional.Text = "Simples Nacional";
            this.rb_simples_nacional.UseVisualStyleBackColor = true;
            this.rb_simples_nacional.CheckedChanged += new System.EventHandler(this.rb_simples_nacional_CheckedChanged);
            // 
            // rb_lucro_presumido
            // 
            this.rb_lucro_presumido.AutoSize = true;
            this.rb_lucro_presumido.Location = new System.Drawing.Point(250, 10);
            this.rb_lucro_presumido.Margin = new System.Windows.Forms.Padding(4);
            this.rb_lucro_presumido.Name = "rb_lucro_presumido";
            this.rb_lucro_presumido.Size = new System.Drawing.Size(129, 20);
            this.rb_lucro_presumido.TabIndex = 10;
            this.rb_lucro_presumido.TabStop = true;
            this.rb_lucro_presumido.Text = "Lucro Presumido";
            this.rb_lucro_presumido.UseVisualStyleBackColor = true;
            // 
            // rb_lucro_real
            // 
            this.rb_lucro_real.AutoSize = true;
            this.rb_lucro_real.Location = new System.Drawing.Point(149, 10);
            this.rb_lucro_real.Margin = new System.Windows.Forms.Padding(4);
            this.rb_lucro_real.Name = "rb_lucro_real";
            this.rb_lucro_real.Size = new System.Drawing.Size(93, 20);
            this.rb_lucro_real.TabIndex = 11;
            this.rb_lucro_real.TabStop = true;
            this.rb_lucro_real.Text = "Lucro Real";
            this.rb_lucro_real.UseVisualStyleBackColor = true;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefone.Location = new System.Drawing.Point(77, 391);
            this.lb_telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(85, 24);
            this.lb_telefone.TabIndex = 12;
            this.lb_telefone.Text = "Telefone";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(263, 393);
            this.mtb_telefone.Margin = new System.Windows.Forms.Padding(4);
            this.mtb_telefone.Mask = "(00) 00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(257, 22);
            this.mtb_telefone.TabIndex = 13;
            // 
            // lb_capital_social
            // 
            this.lb_capital_social.AutoSize = true;
            this.lb_capital_social.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_capital_social.Location = new System.Drawing.Point(77, 455);
            this.lb_capital_social.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_capital_social.Name = "lb_capital_social";
            this.lb_capital_social.Size = new System.Drawing.Size(124, 24);
            this.lb_capital_social.TabIndex = 14;
            this.lb_capital_social.Text = "Capital Social";
            this.lb_capital_social.Click += new System.EventHandler(this.lb_capital_social_Click);
            // 
            // tb_capitalsocial
            // 
            this.tb_capitalsocial.Location = new System.Drawing.Point(263, 457);
            this.tb_capitalsocial.Margin = new System.Windows.Forms.Padding(4);
            this.tb_capitalsocial.Name = "tb_capitalsocial";
            this.tb_capitalsocial.Size = new System.Drawing.Size(257, 22);
            this.tb_capitalsocial.TabIndex = 15;
            // 
            // lb_endereco
            // 
            this.lb_endereco.AutoSize = true;
            this.lb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_endereco.Location = new System.Drawing.Point(990, 49);
            this.lb_endereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_endereco.Name = "lb_endereco";
            this.lb_endereco.Size = new System.Drawing.Size(126, 29);
            this.lb_endereco.TabIndex = 16;
            this.lb_endereco.Text = "Endereço";
            // 
            // lb_rua
            // 
            this.lb_rua.AutoSize = true;
            this.lb_rua.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rua.Location = new System.Drawing.Point(798, 212);
            this.lb_rua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_rua.Name = "lb_rua";
            this.lb_rua.Size = new System.Drawing.Size(43, 24);
            this.lb_rua.TabIndex = 17;
            this.lb_rua.Text = "Rua";
            // 
            // lb_cep
            // 
            this.lb_cep.AutoSize = true;
            this.lb_cep.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cep.Location = new System.Drawing.Point(798, 158);
            this.lb_cep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cep.Name = "lb_cep";
            this.lb_cep.Size = new System.Drawing.Size(42, 24);
            this.lb_cep.TabIndex = 18;
            this.lb_cep.Text = "Cep";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero.Location = new System.Drawing.Point(796, 257);
            this.lb_numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(80, 24);
            this.lb_numero.TabIndex = 20;
            this.lb_numero.Text = "Numero";
            // 
            // lb_bairro
            // 
            this.lb_bairro.AutoSize = true;
            this.lb_bairro.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bairro.Location = new System.Drawing.Point(798, 306);
            this.lb_bairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_bairro.Name = "lb_bairro";
            this.lb_bairro.Size = new System.Drawing.Size(62, 24);
            this.lb_bairro.TabIndex = 22;
            this.lb_bairro.Text = "Bairro";
            // 
            // lb_complemento
            // 
            this.lb_complemento.AutoSize = true;
            this.lb_complemento.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_complemento.Location = new System.Drawing.Point(796, 362);
            this.lb_complemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_complemento.Name = "lb_complemento";
            this.lb_complemento.Size = new System.Drawing.Size(131, 24);
            this.lb_complemento.TabIndex = 24;
            this.lb_complemento.Text = "Complemento";
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado.Location = new System.Drawing.Point(798, 107);
            this.lb_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(67, 24);
            this.lb_estado.TabIndex = 25;
            this.lb_estado.Text = "Estado";
            // 
            // tb_cep
            // 
            this.tb_cep.Location = new System.Drawing.Point(935, 158);
            this.tb_cep.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.Size = new System.Drawing.Size(257, 22);
            this.tb_cep.TabIndex = 26;
            // 
            // tb_complemento
            // 
            this.tb_complemento.Location = new System.Drawing.Point(935, 362);
            this.tb_complemento.Margin = new System.Windows.Forms.Padding(4);
            this.tb_complemento.Name = "tb_complemento";
            this.tb_complemento.Size = new System.Drawing.Size(257, 22);
            this.tb_complemento.TabIndex = 28;
            this.tb_complemento.TextChanged += new System.EventHandler(this.tb_complemento_TextChanged);
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(935, 306);
            this.tb_bairro.Margin = new System.Windows.Forms.Padding(4);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(257, 22);
            this.tb_bairro.TabIndex = 30;
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(935, 257);
            this.tb_numero.Margin = new System.Windows.Forms.Padding(4);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(257, 22);
            this.tb_numero.TabIndex = 32;
            // 
            // tb_rua
            // 
            this.tb_rua.Location = new System.Drawing.Point(935, 214);
            this.tb_rua.Margin = new System.Windows.Forms.Padding(4);
            this.tb_rua.Name = "tb_rua";
            this.tb_rua.Size = new System.Drawing.Size(257, 22);
            this.tb_rua.TabIndex = 34;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cb_estado.Location = new System.Drawing.Point(935, 107);
            this.cb_estado.Margin = new System.Windows.Forms.Padding(4);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(257, 24);
            this.cb_estado.TabIndex = 35;
            // 
            // lb_tipo
            // 
            this.lb_tipo.AutoSize = true;
            this.lb_tipo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tipo.Location = new System.Drawing.Point(77, 516);
            this.lb_tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tipo.Name = "lb_tipo";
            this.lb_tipo.Size = new System.Drawing.Size(48, 24);
            this.lb_tipo.TabIndex = 36;
            this.lb_tipo.Text = "Tipo";
            // 
            // rb_matriz
            // 
            this.rb_matriz.AutoSize = true;
            this.rb_matriz.Location = new System.Drawing.Point(7, 10);
            this.rb_matriz.Margin = new System.Windows.Forms.Padding(4);
            this.rb_matriz.Name = "rb_matriz";
            this.rb_matriz.Size = new System.Drawing.Size(63, 20);
            this.rb_matriz.TabIndex = 37;
            this.rb_matriz.TabStop = true;
            this.rb_matriz.Text = "Matriz";
            this.rb_matriz.UseVisualStyleBackColor = true;
            // 
            // rb_filial
            // 
            this.rb_filial.AutoSize = true;
            this.rb_filial.Location = new System.Drawing.Point(78, 10);
            this.rb_filial.Margin = new System.Windows.Forms.Padding(4);
            this.rb_filial.Name = "rb_filial";
            this.rb_filial.Size = new System.Drawing.Size(56, 20);
            this.rb_filial.TabIndex = 38;
            this.rb_filial.TabStop = true;
            this.rb_filial.Text = "Filial";
            this.rb_filial.UseVisualStyleBackColor = true;
            // 
            // lb_porte
            // 
            this.lb_porte.AutoSize = true;
            this.lb_porte.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_porte.Location = new System.Drawing.Point(77, 577);
            this.lb_porte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_porte.Name = "lb_porte";
            this.lb_porte.Size = new System.Drawing.Size(56, 24);
            this.lb_porte.TabIndex = 39;
            this.lb_porte.Text = "Porte";
            // 
            // rb_pequeno
            // 
            this.rb_pequeno.AutoSize = true;
            this.rb_pequeno.Location = new System.Drawing.Point(7, 12);
            this.rb_pequeno.Margin = new System.Windows.Forms.Padding(4);
            this.rb_pequeno.Name = "rb_pequeno";
            this.rb_pequeno.Size = new System.Drawing.Size(83, 20);
            this.rb_pequeno.TabIndex = 40;
            this.rb_pequeno.TabStop = true;
            this.rb_pequeno.Text = "Pequeno";
            this.rb_pequeno.UseVisualStyleBackColor = true;
            // 
            // rb_grande
            // 
            this.rb_grande.AutoSize = true;
            this.rb_grande.Location = new System.Drawing.Point(172, 12);
            this.rb_grande.Margin = new System.Windows.Forms.Padding(4);
            this.rb_grande.Name = "rb_grande";
            this.rb_grande.Size = new System.Drawing.Size(73, 20);
            this.rb_grande.TabIndex = 41;
            this.rb_grande.TabStop = true;
            this.rb_grande.Text = "Grande";
            this.rb_grande.UseVisualStyleBackColor = true;
            // 
            // rb_medio
            // 
            this.rb_medio.AutoSize = true;
            this.rb_medio.Location = new System.Drawing.Point(98, 12);
            this.rb_medio.Margin = new System.Windows.Forms.Padding(4);
            this.rb_medio.Name = "rb_medio";
            this.rb_medio.Size = new System.Drawing.Size(66, 20);
            this.rb_medio.TabIndex = 42;
            this.rb_medio.TabStop = true;
            this.rb_medio.Text = "Médio";
            this.rb_medio.UseVisualStyleBackColor = true;
            // 
            // lb_nat_juridica
            // 
            this.lb_nat_juridica.AutoSize = true;
            this.lb_nat_juridica.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nat_juridica.Location = new System.Drawing.Point(77, 631);
            this.lb_nat_juridica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nat_juridica.Name = "lb_nat_juridica";
            this.lb_nat_juridica.Size = new System.Drawing.Size(159, 24);
            this.lb_nat_juridica.TabIndex = 43;
            this.lb_nat_juridica.Text = "Natureza Jurídica";
            // 
            // cb_nat_juridica
            // 
            this.cb_nat_juridica.FormattingEnabled = true;
            this.cb_nat_juridica.Items.AddRange(new object[] {
            "EI - Empresário Individual",
            "MEI - Microempreendedor Individual",
            "Sociedade Anônima"});
            this.cb_nat_juridica.Location = new System.Drawing.Point(263, 631);
            this.cb_nat_juridica.Margin = new System.Windows.Forms.Padding(4);
            this.cb_nat_juridica.Name = "cb_nat_juridica";
            this.cb_nat_juridica.Size = new System.Drawing.Size(257, 24);
            this.cb_nat_juridica.TabIndex = 44;
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(798, 590);
            this.lb_cpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(46, 24);
            this.lb_cpf.TabIndex = 45;
            this.lb_cpf.Text = "CPF ";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(798, 531);
            this.lb_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(62, 24);
            this.lb_nome.TabIndex = 46;
            this.lb_nome.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(927, 533);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(257, 22);
            this.tb_nome.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(818, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 47);
            this.button1.TabIndex = 49;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtb_cnpj
            // 
            this.mtb_cnpj.Location = new System.Drawing.Point(263, 107);
            this.mtb_cnpj.Mask = "00,000,000/0000-00";
            this.mtb_cnpj.Name = "mtb_cnpj";
            this.mtb_cnpj.Size = new System.Drawing.Size(257, 22);
            this.mtb_cnpj.TabIndex = 51;
            // 
            // lb_dataInicio
            // 
            this.lb_dataInicio.AutoSize = true;
            this.lb_dataInicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dataInicio.Location = new System.Drawing.Point(872, 434);
            this.lb_dataInicio.Name = "lb_dataInicio";
            this.lb_dataInicio.Size = new System.Drawing.Size(269, 25);
            this.lb_dataInicio.TabIndex = 52;
            this.lb_dataInicio.Text = "Data de Início das Atividades";
            // 
            // dtp_dataInicio
            // 
            this.dtp_dataInicio.Location = new System.Drawing.Point(878, 473);
            this.dtp_dataInicio.Name = "dtp_dataInicio";
            this.dtp_dataInicio.Size = new System.Drawing.Size(263, 22);
            this.dtp_dataInicio.TabIndex = 53;
            // 
            // lb_cadastro
            // 
            this.lb_cadastro.AutoSize = true;
            this.lb_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cadastro.Location = new System.Drawing.Point(254, 49);
            this.lb_cadastro.Name = "lb_cadastro";
            this.lb_cadastro.Size = new System.Drawing.Size(266, 29);
            this.lb_cadastro.TabIndex = 54;
            this.lb_cadastro.Text = "Cadastro Empresarial";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_lucro_presumido);
            this.groupBox1.Controls.Add(this.rb_lucro_real);
            this.groupBox1.Controls.Add(this.rb_simples_nacional);
            this.groupBox1.Location = new System.Drawing.Point(259, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 37);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_matriz);
            this.groupBox2.Controls.Add(this.rb_filial);
            this.groupBox2.Location = new System.Drawing.Point(263, 516);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 37);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_pequeno);
            this.groupBox3.Controls.Add(this.rb_medio);
            this.groupBox3.Controls.Add(this.rb_grande);
            this.groupBox3.Location = new System.Drawing.Point(263, 573);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 39);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(112, 725);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(1126, 114);
            this.dgv1.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(932, 657);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 47);
            this.button2.TabIndex = 59;
            this.button2.Text = "EXCLUIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1053, 657);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 47);
            this.button3.TabIndex = 60;
            this.button3.Text = "NOVO ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(927, 592);
            this.mtb_cpf.Mask = "000,000,000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(257, 22);
            this.mtb_cpf.TabIndex = 61;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1333, 960);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_cadastro);
            this.Controls.Add(this.dtp_dataInicio);
            this.Controls.Add(this.lb_dataInicio);
            this.Controls.Add(this.mtb_cnpj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.cb_nat_juridica);
            this.Controls.Add(this.lb_nat_juridica);
            this.Controls.Add(this.lb_porte);
            this.Controls.Add(this.lb_tipo);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.tb_rua);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.tb_bairro);
            this.Controls.Add(this.tb_complemento);
            this.Controls.Add(this.tb_cep);
            this.Controls.Add(this.lb_estado);
            this.Controls.Add(this.lb_complemento);
            this.Controls.Add(this.lb_bairro);
            this.Controls.Add(this.lb_numero);
            this.Controls.Add(this.lb_cep);
            this.Controls.Add(this.lb_rua);
            this.Controls.Add(this.lb_endereco);
            this.Controls.Add(this.tb_capitalsocial);
            this.Controls.Add(this.lb_capital_social);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.lb_regime_tributario);
            this.Controls.Add(this.cb_situacao_cad);
            this.Controls.Add(this.lb_situacao_cad);
            this.Controls.Add(this.lb_fantasia);
            this.Controls.Add(this.tb_fantasia);
            this.Controls.Add(this.tb_razao_social);
            this.Controls.Add(this.lb_razao_social);
            this.Controls.Add(this.lb_cnpj);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_cnpj;
        private System.Windows.Forms.Label lb_razao_social;
        private System.Windows.Forms.TextBox tb_razao_social;
        private System.Windows.Forms.TextBox tb_fantasia;
        private System.Windows.Forms.Label lb_fantasia;
        private System.Windows.Forms.Label lb_situacao_cad;
        private System.Windows.Forms.ComboBox cb_situacao_cad;
        private System.Windows.Forms.Label lb_regime_tributario;
        private System.Windows.Forms.RadioButton rb_simples_nacional;
        private System.Windows.Forms.RadioButton rb_lucro_presumido;
        private System.Windows.Forms.RadioButton rb_lucro_real;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label lb_capital_social;
        private System.Windows.Forms.TextBox tb_capitalsocial;
        private System.Windows.Forms.Label lb_endereco;
        private System.Windows.Forms.Label lb_rua;
        private System.Windows.Forms.Label lb_cep;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label lb_bairro;
        private System.Windows.Forms.Label lb_complemento;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.TextBox tb_cep;
        private System.Windows.Forms.TextBox tb_complemento;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.TextBox tb_rua;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label lb_tipo;
        private System.Windows.Forms.RadioButton rb_matriz;
        private System.Windows.Forms.RadioButton rb_filial;
        private System.Windows.Forms.Label lb_porte;
        private System.Windows.Forms.RadioButton rb_pequeno;
        private System.Windows.Forms.RadioButton rb_grande;
        private System.Windows.Forms.RadioButton rb_medio;
        private System.Windows.Forms.Label lb_nat_juridica;
        private System.Windows.Forms.ComboBox cb_nat_juridica;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtb_cnpj;
        private System.Windows.Forms.Label lb_dataInicio;
        private System.Windows.Forms.DateTimePicker dtp_dataInicio;
        private System.Windows.Forms.Label lb_cadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
    }
}

