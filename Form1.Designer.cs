﻿namespace PrimitivasGráficas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBoxPrincp = new System.Windows.Forms.PictureBox();
            this.btLimparTela = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOpcoesLinha = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFormaSelecionada = new System.Windows.Forms.ComboBox();
            this.btTesteLinhas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbOpcoesCirculos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRedo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rbOrigem = new System.Windows.Forms.RadioButton();
            this.rbCentro = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txYescala = new System.Windows.Forms.TextBox();
            this.txXescala = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txYtrans = new System.Windows.Forms.TextBox();
            this.txXtrans = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txAngulo = new System.Windows.Forms.TextBox();
            this.btAplicarTrans = new System.Windows.Forms.Button();
            this.btResetarCamp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txShearX = new System.Windows.Forms.TextBox();
            this.txShearY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbPoligonos = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtPontosPoligono = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txReflexaoY = new System.Windows.Forms.TextBox();
            this.txReflexaoX = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btPintar = new System.Windows.Forms.Button();
            this.ckFloodFill = new System.Windows.Forms.CheckBox();
            this.ckScanLine = new System.Windows.Forms.CheckBox();
            this.btViewport = new System.Windows.Forms.Button();
            this.txX = new System.Windows.Forms.TextBox();
            this.txY = new System.Windows.Forms.TextBox();
            this.picBoxViewPort = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPrincp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPontosPoligono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxViewPort)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxPrincp
            // 
            this.picBoxPrincp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBoxPrincp.Location = new System.Drawing.Point(9, 10);
            this.picBoxPrincp.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxPrincp.Name = "picBoxPrincp";
            this.picBoxPrincp.Size = new System.Drawing.Size(792, 555);
            this.picBoxPrincp.TabIndex = 0;
            this.picBoxPrincp.TabStop = false;
            this.picBoxPrincp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicBoxPrincp_MouseClick);
            // 
            // btLimparTela
            // 
            this.btLimparTela.Location = new System.Drawing.Point(346, 570);
            this.btLimparTela.Margin = new System.Windows.Forms.Padding(2);
            this.btLimparTela.Name = "btLimparTela";
            this.btLimparTela.Size = new System.Drawing.Size(110, 22);
            this.btLimparTela.TabIndex = 3;
            this.btLimparTela.Text = "Limpar tela";
            this.btLimparTela.UseVisualStyleBackColor = true;
            this.btLimparTela.Click += new System.EventHandler(this.BtLimparTela_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(819, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Métodos de criação de linha";
            // 
            // cbOpcoesLinha
            // 
            this.cbOpcoesLinha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoesLinha.FormattingEnabled = true;
            this.cbOpcoesLinha.Items.AddRange(new object[] {
            "DDA (VERDE)",
            "Equação Real da Reta (AZUL)",
            "Método do ponto médio (VERMELHO)"});
            this.cbOpcoesLinha.Location = new System.Drawing.Point(821, 134);
            this.cbOpcoesLinha.Margin = new System.Windows.Forms.Padding(2);
            this.cbOpcoesLinha.Name = "cbOpcoesLinha";
            this.cbOpcoesLinha.Size = new System.Drawing.Size(233, 21);
            this.cbOpcoesLinha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(819, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Forma Geométrica";
            // 
            // cbFormaSelecionada
            // 
            this.cbFormaSelecionada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaSelecionada.FormattingEnabled = true;
            this.cbFormaSelecionada.Items.AddRange(new object[] {
            "Círculo",
            "Elipse",
            "Linha",
            "Polígono"});
            this.cbFormaSelecionada.Location = new System.Drawing.Point(821, 33);
            this.cbFormaSelecionada.Margin = new System.Windows.Forms.Padding(2);
            this.cbFormaSelecionada.Name = "cbFormaSelecionada";
            this.cbFormaSelecionada.Size = new System.Drawing.Size(123, 21);
            this.cbFormaSelecionada.TabIndex = 7;
            // 
            // btTesteLinhas
            // 
            this.btTesteLinhas.Location = new System.Drawing.Point(824, 226);
            this.btTesteLinhas.Margin = new System.Windows.Forms.Padding(2);
            this.btTesteLinhas.Name = "btTesteLinhas";
            this.btTesteLinhas.Size = new System.Drawing.Size(101, 51);
            this.btTesteLinhas.TabIndex = 8;
            this.btTesteLinhas.Text = "Testes os Métodos da Linha";
            this.btTesteLinhas.UseVisualStyleBackColor = true;
            this.btTesteLinhas.Click += new System.EventHandler(this.BtTesteLinhas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(950, 227);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Testes os Métodos do Círculo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbOpcoesCirculos
            // 
            this.cbOpcoesCirculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoesCirculos.FormattingEnabled = true;
            this.cbOpcoesCirculos.Items.AddRange(new object[] {
            "Equação Geral da Circuferência (Vermelho)",
            "Trigonometria (Verde)",
            "Ponto Médio (Azul)"});
            this.cbOpcoesCirculos.Location = new System.Drawing.Point(821, 188);
            this.cbOpcoesCirculos.Margin = new System.Windows.Forms.Padding(2);
            this.cbOpcoesCirculos.Name = "cbOpcoesCirculos";
            this.cbOpcoesCirculos.Size = new System.Drawing.Size(233, 21);
            this.cbOpcoesCirculos.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(821, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Métodos de criação de círculo";
            // 
            // btnRedo
            // 
            this.btnRedo.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.Image")));
            this.btnRedo.Location = new System.Drawing.Point(821, 73);
            this.btnRedo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(29, 23);
            this.btnRedo.TabIndex = 12;
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(874, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Transformar em relação á:";
            // 
            // rbOrigem
            // 
            this.rbOrigem.AutoSize = true;
            this.rbOrigem.Location = new System.Drawing.Point(876, 319);
            this.rbOrigem.Margin = new System.Windows.Forms.Padding(2);
            this.rbOrigem.Name = "rbOrigem";
            this.rbOrigem.Size = new System.Drawing.Size(56, 17);
            this.rbOrigem.TabIndex = 14;
            this.rbOrigem.TabStop = true;
            this.rbOrigem.Text = "origem";
            this.rbOrigem.UseVisualStyleBackColor = true;
            // 
            // rbCentro
            // 
            this.rbCentro.AutoSize = true;
            this.rbCentro.Location = new System.Drawing.Point(978, 319);
            this.rbCentro.Margin = new System.Windows.Forms.Padding(2);
            this.rbCentro.Name = "rbCentro";
            this.rbCentro.Size = new System.Drawing.Size(55, 17);
            this.rbCentro.TabIndex = 15;
            this.rbCentro.TabStop = true;
            this.rbCentro.Text = "centro";
            this.rbCentro.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(979, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Escala";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1018, 422);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(971, 422);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "X";
            // 
            // txYescala
            // 
            this.txYescala.Location = new System.Drawing.Point(1007, 438);
            this.txYescala.Margin = new System.Windows.Forms.Padding(2);
            this.txYescala.MaxLength = 4;
            this.txYescala.Name = "txYescala";
            this.txYescala.Size = new System.Drawing.Size(32, 20);
            this.txYescala.TabIndex = 23;
            this.txYescala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txXescala
            // 
            this.txXescala.Location = new System.Drawing.Point(954, 438);
            this.txXescala.Margin = new System.Windows.Forms.Padding(2);
            this.txXescala.MaxLength = 4;
            this.txXescala.Name = "txXescala";
            this.txXescala.Size = new System.Drawing.Size(32, 20);
            this.txXescala.TabIndex = 22;
            this.txXescala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1015, 366);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(968, 366);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "X";
            // 
            // txYtrans
            // 
            this.txYtrans.Location = new System.Drawing.Point(1007, 382);
            this.txYtrans.Margin = new System.Windows.Forms.Padding(2);
            this.txYtrans.MaxLength = 4;
            this.txYtrans.Name = "txYtrans";
            this.txYtrans.Size = new System.Drawing.Size(32, 20);
            this.txYtrans.TabIndex = 27;
            this.txYtrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txXtrans
            // 
            this.txXtrans.Location = new System.Drawing.Point(954, 382);
            this.txXtrans.Margin = new System.Windows.Forms.Padding(2);
            this.txXtrans.MaxLength = 4;
            this.txXtrans.Name = "txXtrans";
            this.txXtrans.Size = new System.Drawing.Size(32, 20);
            this.txXtrans.TabIndex = 26;
            this.txXtrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(972, 347);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Translação";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(979, 463);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Ângulo";
            // 
            // txAngulo
            // 
            this.txAngulo.Location = new System.Drawing.Point(981, 479);
            this.txAngulo.Margin = new System.Windows.Forms.Padding(2);
            this.txAngulo.MaxLength = 4;
            this.txAngulo.Name = "txAngulo";
            this.txAngulo.Size = new System.Drawing.Size(32, 20);
            this.txAngulo.TabIndex = 32;
            this.txAngulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAplicarTrans
            // 
            this.btAplicarTrans.Location = new System.Drawing.Point(824, 618);
            this.btAplicarTrans.Margin = new System.Windows.Forms.Padding(2);
            this.btAplicarTrans.Name = "btAplicarTrans";
            this.btAplicarTrans.Size = new System.Drawing.Size(89, 24);
            this.btAplicarTrans.TabIndex = 33;
            this.btAplicarTrans.Text = "Aplicar";
            this.btAplicarTrans.UseVisualStyleBackColor = true;
            this.btAplicarTrans.Click += new System.EventHandler(this.BtAplicarTrans_Click);
            // 
            // btResetarCamp
            // 
            this.btResetarCamp.Location = new System.Drawing.Point(954, 618);
            this.btResetarCamp.Margin = new System.Windows.Forms.Padding(2);
            this.btResetarCamp.Name = "btResetarCamp";
            this.btResetarCamp.Size = new System.Drawing.Size(99, 24);
            this.btResetarCamp.TabIndex = 34;
            this.btResetarCamp.Text = "Resetar Campos";
            this.btResetarCamp.UseVisualStyleBackColor = true;
            this.btResetarCamp.Click += new System.EventHandler(this.BtResetarCamp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(968, 502);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Cisalhamento";
            // 
            // txShearX
            // 
            this.txShearX.Location = new System.Drawing.Point(954, 532);
            this.txShearX.Margin = new System.Windows.Forms.Padding(2);
            this.txShearX.MaxLength = 4;
            this.txShearX.Name = "txShearX";
            this.txShearX.Size = new System.Drawing.Size(32, 20);
            this.txShearX.TabIndex = 36;
            this.txShearX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txShearY
            // 
            this.txShearY.Location = new System.Drawing.Point(1007, 532);
            this.txShearY.Margin = new System.Windows.Forms.Padding(2);
            this.txShearY.MaxLength = 4;
            this.txShearY.Name = "txShearY";
            this.txShearY.Size = new System.Drawing.Size(32, 20);
            this.txShearY.TabIndex = 37;
            this.txShearY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(958, 516);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1018, 516);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Y";
            // 
            // cbPoligonos
            // 
            this.cbPoligonos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoligonos.FormattingEnabled = true;
            this.cbPoligonos.Location = new System.Drawing.Point(820, 380);
            this.cbPoligonos.Margin = new System.Windows.Forms.Padding(2);
            this.cbPoligonos.Name = "cbPoligonos";
            this.cbPoligonos.Size = new System.Drawing.Size(111, 21);
            this.cbPoligonos.TabIndex = 40;
            this.cbPoligonos.SelectedIndexChanged += new System.EventHandler(this.cbPoligonos_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(833, 364);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Poligonos";
            // 
            // dtPontosPoligono
            // 
            this.dtPontosPoligono.AllowUserToAddRows = false;
            this.dtPontosPoligono.AllowUserToDeleteRows = false;
            this.dtPontosPoligono.AllowUserToResizeColumns = false;
            this.dtPontosPoligono.AllowUserToResizeRows = false;
            this.dtPontosPoligono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPontosPoligono.Location = new System.Drawing.Point(818, 422);
            this.dtPontosPoligono.Margin = new System.Windows.Forms.Padding(2);
            this.dtPontosPoligono.Name = "dtPontosPoligono";
            this.dtPontosPoligono.ReadOnly = true;
            this.dtPontosPoligono.RowHeadersVisible = false;
            this.dtPontosPoligono.RowHeadersWidth = 51;
            this.dtPontosPoligono.RowTemplate.Height = 24;
            this.dtPontosPoligono.Size = new System.Drawing.Size(112, 179);
            this.dtPontosPoligono.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1018, 574);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Y";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(958, 574);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "X";
            // 
            // txReflexaoY
            // 
            this.txReflexaoY.Location = new System.Drawing.Point(1007, 591);
            this.txReflexaoY.Margin = new System.Windows.Forms.Padding(2);
            this.txReflexaoY.MaxLength = 4;
            this.txReflexaoY.Name = "txReflexaoY";
            this.txReflexaoY.Size = new System.Drawing.Size(32, 20);
            this.txReflexaoY.TabIndex = 45;
            this.txReflexaoY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txReflexaoX
            // 
            this.txReflexaoX.Location = new System.Drawing.Point(954, 591);
            this.txReflexaoX.Margin = new System.Windows.Forms.Padding(2);
            this.txReflexaoX.MaxLength = 4;
            this.txReflexaoX.Name = "txReflexaoX";
            this.txReflexaoX.Size = new System.Drawing.Size(32, 20);
            this.txReflexaoX.TabIndex = 44;
            this.txReflexaoX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(969, 561);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Reflexão";
            // 
            // btPintar
            // 
            this.btPintar.Location = new System.Drawing.Point(656, 574);
            this.btPintar.Margin = new System.Windows.Forms.Padding(2);
            this.btPintar.Name = "btPintar";
            this.btPintar.Size = new System.Drawing.Size(98, 26);
            this.btPintar.TabIndex = 48;
            this.btPintar.Text = "Pintar Poligono";
            this.btPintar.UseVisualStyleBackColor = true;
            this.btPintar.Click += new System.EventHandler(this.btPintar_Click);
            // 
            // ckFloodFill
            // 
            this.ckFloodFill.AutoSize = true;
            this.ckFloodFill.Location = new System.Drawing.Point(628, 605);
            this.ckFloodFill.Margin = new System.Windows.Forms.Padding(2);
            this.ckFloodFill.Name = "ckFloodFill";
            this.ckFloodFill.Size = new System.Drawing.Size(67, 17);
            this.ckFloodFill.TabIndex = 49;
            this.ckFloodFill.Text = "Flood Fill";
            this.ckFloodFill.UseVisualStyleBackColor = true;
            // 
            // ckScanLine
            // 
            this.ckScanLine.AutoSize = true;
            this.ckScanLine.Location = new System.Drawing.Point(716, 605);
            this.ckScanLine.Margin = new System.Windows.Forms.Padding(2);
            this.ckScanLine.Name = "ckScanLine";
            this.ckScanLine.Size = new System.Drawing.Size(74, 17);
            this.ckScanLine.TabIndex = 50;
            this.ckScanLine.Text = "Scan Line";
            this.ckScanLine.UseVisualStyleBackColor = true;
            // 
            // btViewport
            // 
            this.btViewport.Location = new System.Drawing.Point(381, 605);
            this.btViewport.Name = "btViewport";
            this.btViewport.Size = new System.Drawing.Size(75, 23);
            this.btViewport.TabIndex = 51;
            this.btViewport.Text = "button2";
            this.btViewport.UseVisualStyleBackColor = true;
            this.btViewport.Click += new System.EventHandler(this.btViewport_Click);
            // 
            // txX
            // 
            this.txX.Location = new System.Drawing.Point(70, 607);
            this.txX.Name = "txX";
            this.txX.Size = new System.Drawing.Size(100, 20);
            this.txX.TabIndex = 52;
            // 
            // txY
            // 
            this.txY.Location = new System.Drawing.Point(212, 602);
            this.txY.Name = "txY";
            this.txY.Size = new System.Drawing.Size(100, 20);
            this.txY.TabIndex = 53;
            // 
            // picBoxViewPort
            // 
            this.picBoxViewPort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picBoxViewPort.Location = new System.Drawing.Point(1069, 12);
            this.picBoxViewPort.Name = "picBoxViewPort";
            this.picBoxViewPort.Size = new System.Drawing.Size(150, 553);
            this.picBoxViewPort.TabIndex = 54;
            this.picBoxViewPort.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 652);
            this.Controls.Add(this.picBoxViewPort);
            this.Controls.Add(this.txY);
            this.Controls.Add(this.txX);
            this.Controls.Add(this.btViewport);
            this.Controls.Add(this.ckScanLine);
            this.Controls.Add(this.ckFloodFill);
            this.Controls.Add(this.btPintar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txReflexaoY);
            this.Controls.Add(this.txReflexaoX);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtPontosPoligono);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbPoligonos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txShearY);
            this.Controls.Add(this.txShearX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btResetarCamp);
            this.Controls.Add(this.btAplicarTrans);
            this.Controls.Add(this.txAngulo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txYtrans);
            this.Controls.Add(this.txXtrans);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txYescala);
            this.Controls.Add(this.txXescala);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbCentro);
            this.Controls.Add(this.rbOrigem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbOpcoesCirculos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btTesteLinhas);
            this.Controls.Add(this.cbFormaSelecionada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOpcoesLinha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLimparTela);
            this.Controls.Add(this.picBoxPrincp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPrincp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPontosPoligono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxViewPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPrincp;
        private System.Windows.Forms.Button btLimparTela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOpcoesLinha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFormaSelecionada;
        private System.Windows.Forms.Button btTesteLinhas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbOpcoesCirculos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbOrigem;
        private System.Windows.Forms.RadioButton rbCentro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txYescala;
        private System.Windows.Forms.TextBox txXescala;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txYtrans;
        private System.Windows.Forms.TextBox txXtrans;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txAngulo;
        private System.Windows.Forms.Button btAplicarTrans;
        private System.Windows.Forms.Button btResetarCamp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txShearX;
        private System.Windows.Forms.TextBox txShearY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbPoligonos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dtPontosPoligono;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txReflexaoY;
        private System.Windows.Forms.TextBox txReflexaoX;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btPintar;
        private System.Windows.Forms.CheckBox ckFloodFill;
        private System.Windows.Forms.CheckBox ckScanLine;
        private System.Windows.Forms.Button btViewport;
        private System.Windows.Forms.TextBox txX;
        private System.Windows.Forms.TextBox txY;
        private System.Windows.Forms.PictureBox picBoxViewPort;
    }
}

