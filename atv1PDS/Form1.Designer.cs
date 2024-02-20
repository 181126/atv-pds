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
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mtb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.tb_razao_social.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_razao_social.Name = "tb_razao_social";
            this.tb_razao_social.Size = new System.Drawing.Size(257, 22);
            this.tb_razao_social.TabIndex = 3;
            this.tb_razao_social.TextChanged += new System.EventHandler(this.tb_razao_social_TextChanged);
            // 
            // tb_fantasia
            // 
            this.tb_fantasia.Location = new System.Drawing.Point(263, 214);
            this.tb_fantasia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cb_situacao_cad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_situacao_cad.Name = "cb_situacao_cad";
            this.cb_situacao_cad.Size = new System.Drawing.Size(257, 24);
            this.cb_situacao_cad.TabIndex = 7;
            // 
            // lb_regime_tributario
            // 
            this.lb_regime_tributario.AutoSize = true;
            this.lb_regime_tributario.Location = new System.Drawing.Point(92, 334);
            this.lb_regime_tributario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_regime_tributario.Name = "lb_regime_tributario";
            this.lb_regime_tributario.Size = new System.Drawing.Size(115, 16);
            this.lb_regime_tributario.TabIndex = 8;
            this.lb_regime_tributario.Text = "Regime Tributário";
            // 
            // rb_simples_nacional
            // 
            this.rb_simples_nacional.AutoSize = true;
            this.rb_simples_nacional.Location = new System.Drawing.Point(7, 17);
            this.rb_simples_nacional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_simples_nacional.Name = "rb_simples_nacional";
            this.rb_simples_nacional.Size = new System.Drawing.Size(134, 20);
            this.rb_simples_nacional.TabIndex = 9;
            this.rb_simples_nacional.TabStop = true;
            this.rb_simples_nacional.Text = "Simples Nacional";
            this.rb_simples_nacional.UseVisualStyleBackColor = true;
            // 
            // rb_lucro_presumido
            // 
            this.rb_lucro_presumido.AutoSize = true;
            this.rb_lucro_presumido.Location = new System.Drawing.Point(149, 17);
            this.rb_lucro_presumido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rb_lucro_real.Location = new System.Drawing.Point(280, 17);
            this.rb_lucro_real.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lb_telefone.Location = new System.Drawing.Point(92, 398);
            this.lb_telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(61, 16);
            this.lb_telefone.TabIndex = 12;
            this.lb_telefone.Text = "Telefone";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(229, 394);
            this.mtb_telefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(257, 22);
            this.mtb_telefone.TabIndex = 13;
            // 
            // lb_capital_social
            // 
            this.lb_capital_social.AutoSize = true;
            this.lb_capital_social.Location = new System.Drawing.Point(92, 460);
            this.lb_capital_social.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_capital_social.Name = "lb_capital_social";
            this.lb_capital_social.Size = new System.Drawing.Size(90, 16);
            this.lb_capital_social.TabIndex = 14;
            this.lb_capital_social.Text = "Capital Social";
            this.lb_capital_social.Click += new System.EventHandler(this.lb_capital_social_Click);
            // 
            // tb_capitalsocial
            // 
            this.tb_capitalsocial.Location = new System.Drawing.Point(229, 460);
            this.tb_capitalsocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_capitalsocial.Name = "tb_capitalsocial";
            this.tb_capitalsocial.Size = new System.Drawing.Size(257, 22);
            this.tb_capitalsocial.TabIndex = 15;
            // 
            // lb_endereco
            // 
            this.lb_endereco.AutoSize = true;
            this.lb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_endereco.Location = new System.Drawing.Point(921, 49);
            this.lb_endereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_endereco.Name = "lb_endereco";
            this.lb_endereco.Size = new System.Drawing.Size(126, 29);
            this.lb_endereco.TabIndex = 16;
            this.lb_endereco.Text = "Endereço";
            // 
            // lb_rua
            // 
            this.lb_rua.AutoSize = true;
            this.lb_rua.Location = new System.Drawing.Point(817, 214);
            this.lb_rua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_rua.Name = "lb_rua";
            this.lb_rua.Size = new System.Drawing.Size(32, 16);
            this.lb_rua.TabIndex = 17;
            this.lb_rua.Text = "Rua";
            // 
            // lb_cep
            // 
            this.lb_cep.AutoSize = true;
            this.lb_cep.Location = new System.Drawing.Point(817, 172);
            this.lb_cep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cep.Name = "lb_cep";
            this.lb_cep.Size = new System.Drawing.Size(32, 16);
            this.lb_cep.TabIndex = 18;
            this.lb_cep.Text = "Cep";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(817, 257);
            this.lb_numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(55, 16);
            this.lb_numero.TabIndex = 20;
            this.lb_numero.Text = "Numero";
            // 
            // lb_bairro
            // 
            this.lb_bairro.AutoSize = true;
            this.lb_bairro.Location = new System.Drawing.Point(817, 306);
            this.lb_bairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_bairro.Name = "lb_bairro";
            this.lb_bairro.Size = new System.Drawing.Size(43, 16);
            this.lb_bairro.TabIndex = 22;
            this.lb_bairro.Text = "Bairro";
            // 
            // lb_complemento
            // 
            this.lb_complemento.AutoSize = true;
            this.lb_complemento.Location = new System.Drawing.Point(805, 363);
            this.lb_complemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_complemento.Name = "lb_complemento";
            this.lb_complemento.Size = new System.Drawing.Size(91, 16);
            this.lb_complemento.TabIndex = 24;
            this.lb_complemento.Text = "Complemento";
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Location = new System.Drawing.Point(817, 124);
            this.lb_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(50, 16);
            this.lb_estado.TabIndex = 25;
            this.lb_estado.Text = "Estado";
            // 
            // tb_cep
            // 
            this.tb_cep.Location = new System.Drawing.Point(927, 164);
            this.tb_cep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.Size = new System.Drawing.Size(257, 22);
            this.tb_cep.TabIndex = 26;
            // 
            // tb_complemento
            // 
            this.tb_complemento.Location = new System.Drawing.Point(927, 359);
            this.tb_complemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_complemento.Name = "tb_complemento";
            this.tb_complemento.Size = new System.Drawing.Size(257, 22);
            this.tb_complemento.TabIndex = 28;
            this.tb_complemento.TextChanged += new System.EventHandler(this.tb_complemento_TextChanged);
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(927, 303);
            this.tb_bairro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(257, 22);
            this.tb_bairro.TabIndex = 30;
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(927, 254);
            this.tb_numero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(257, 22);
            this.tb_numero.TabIndex = 32;
            // 
            // tb_rua
            // 
            this.tb_rua.Location = new System.Drawing.Point(927, 214);
            this.tb_rua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cb_estado.Location = new System.Drawing.Point(927, 114);
            this.cb_estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(257, 24);
            this.cb_estado.TabIndex = 35;
            // 
            // lb_tipo
            // 
            this.lb_tipo.AutoSize = true;
            this.lb_tipo.Location = new System.Drawing.Point(92, 519);
            this.lb_tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tipo.Name = "lb_tipo";
            this.lb_tipo.Size = new System.Drawing.Size(35, 16);
            this.lb_tipo.TabIndex = 36;
            this.lb_tipo.Text = "Tipo";
            // 
            // rb_matriz
            // 
            this.rb_matriz.AutoSize = true;
            this.rb_matriz.Location = new System.Drawing.Point(7, 22);
            this.rb_matriz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rb_filial.Location = new System.Drawing.Point(78, 22);
            this.rb_filial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lb_porte.Location = new System.Drawing.Point(92, 575);
            this.lb_porte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_porte.Name = "lb_porte";
            this.lb_porte.Size = new System.Drawing.Size(39, 16);
            this.lb_porte.TabIndex = 39;
            this.lb_porte.Text = "Porte";
            // 
            // rb_pequeno
            // 
            this.rb_pequeno.AutoSize = true;
            this.rb_pequeno.Location = new System.Drawing.Point(0, 20);
            this.rb_pequeno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rb_grande.Location = new System.Drawing.Point(165, 22);
            this.rb_grande.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rb_medio.Location = new System.Drawing.Point(91, 20);
            this.rb_medio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lb_nat_juridica.Location = new System.Drawing.Point(85, 634);
            this.lb_nat_juridica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nat_juridica.Name = "lb_nat_juridica";
            this.lb_nat_juridica.Size = new System.Drawing.Size(111, 16);
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
            this.cb_nat_juridica.Location = new System.Drawing.Point(229, 630);
            this.cb_nat_juridica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_nat_juridica.Name = "cb_nat_juridica";
            this.cb_nat_juridica.Size = new System.Drawing.Size(257, 24);
            this.cb_nat_juridica.TabIndex = 44;
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Location = new System.Drawing.Point(795, 577);
            this.lb_cpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(121, 16);
            this.lb_cpf.TabIndex = 45;
            this.lb_cpf.Text = "CPF do Propietário";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(784, 496);
            this.lb_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(132, 16);
            this.lb_nome.TabIndex = 46;
            this.lb_nome.Text = "Nome do Propietário";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(927, 496);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(257, 22);
            this.tb_nome.TabIndex = 47;
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(927, 575);
            this.tb_cpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(257, 22);
            this.tb_cpf.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 680);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 47);
            this.button1.TabIndex = 49;
            this.button1.Text = "salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(844, 680);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 47);
            this.button2.TabIndex = 50;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mtb_cnpj
            // 
            this.mtb_cnpj.Location = new System.Drawing.Point(263, 107);
            this.mtb_cnpj.Mask = "00,000,000/0000-00";
            this.mtb_cnpj.Name = "mtb_cnpj";
            this.mtb_cnpj.Size = new System.Drawing.Size(257, 22);
            this.mtb_cnpj.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_simples_nacional);
            this.groupBox1.Controls.Add(this.rb_lucro_presumido);
            this.groupBox1.Controls.Add(this.rb_lucro_real);
            this.groupBox1.Location = new System.Drawing.Point(229, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 44);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_matriz);
            this.groupBox2.Controls.Add(this.rb_filial);
            this.groupBox2.Location = new System.Drawing.Point(229, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 52);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_pequeno);
            this.groupBox3.Controls.Add(this.rb_medio);
            this.groupBox3.Controls.Add(this.rb_grande);
            this.groupBox3.Location = new System.Drawing.Point(220, 554);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 47);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtb_cnpj);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_cpf);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mtb_cnpj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

