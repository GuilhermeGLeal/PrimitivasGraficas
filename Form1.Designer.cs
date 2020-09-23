namespace PrimitivasGráficas
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
            this.rbCoord = new System.Windows.Forms.RadioButton();
            this.txXcoord = new System.Windows.Forms.TextBox();
            this.txYcoord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPrincp)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxPrincp
            // 
            this.picBoxPrincp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBoxPrincp.Location = new System.Drawing.Point(12, 12);
            this.picBoxPrincp.Name = "picBoxPrincp";
            this.picBoxPrincp.Size = new System.Drawing.Size(1056, 683);
            this.picBoxPrincp.TabIndex = 0;
            this.picBoxPrincp.TabStop = false;
            this.picBoxPrincp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicBoxPrincp_MouseClick);
            // 
            // btLimparTela
            // 
            this.btLimparTela.Location = new System.Drawing.Point(462, 701);
            this.btLimparTela.Name = "btLimparTela";
            this.btLimparTela.Size = new System.Drawing.Size(146, 27);
            this.btLimparTela.TabIndex = 3;
            this.btLimparTela.Text = "Limpar tela";
            this.btLimparTela.UseVisualStyleBackColor = true;
            this.btLimparTela.Click += new System.EventHandler(this.BtLimparTela_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1092, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
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
            this.cbOpcoesLinha.Location = new System.Drawing.Point(1095, 165);
            this.cbOpcoesLinha.Name = "cbOpcoesLinha";
            this.cbOpcoesLinha.Size = new System.Drawing.Size(309, 24);
            this.cbOpcoesLinha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1092, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
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
            this.cbFormaSelecionada.Location = new System.Drawing.Point(1095, 41);
            this.cbFormaSelecionada.Name = "cbFormaSelecionada";
            this.cbFormaSelecionada.Size = new System.Drawing.Size(163, 24);
            this.cbFormaSelecionada.TabIndex = 7;
            // 
            // btTesteLinhas
            // 
            this.btTesteLinhas.Location = new System.Drawing.Point(1098, 278);
            this.btTesteLinhas.Name = "btTesteLinhas";
            this.btTesteLinhas.Size = new System.Drawing.Size(135, 63);
            this.btTesteLinhas.TabIndex = 8;
            this.btTesteLinhas.Text = "Testes os Métodos da Linha";
            this.btTesteLinhas.UseVisualStyleBackColor = true;
            this.btTesteLinhas.Click += new System.EventHandler(this.BtTesteLinhas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1267, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 62);
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
            this.cbOpcoesCirculos.Location = new System.Drawing.Point(1095, 231);
            this.cbOpcoesCirculos.Name = "cbOpcoesCirculos";
            this.cbOpcoesCirculos.Size = new System.Drawing.Size(309, 24);
            this.cbOpcoesCirculos.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1095, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Métodos de criação de círculo";
            // 
            // btnRedo
            // 
            this.btnRedo.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.Image")));
            this.btnRedo.Location = new System.Drawing.Point(1095, 90);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(39, 28);
            this.btnRedo.TabIndex = 12;
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1092, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Transformar em relação á:";
            // 
            // rbOrigem
            // 
            this.rbOrigem.AutoSize = true;
            this.rbOrigem.Location = new System.Drawing.Point(1098, 403);
            this.rbOrigem.Name = "rbOrigem";
            this.rbOrigem.Size = new System.Drawing.Size(72, 21);
            this.rbOrigem.TabIndex = 14;
            this.rbOrigem.TabStop = true;
            this.rbOrigem.Text = "origem";
            this.rbOrigem.UseVisualStyleBackColor = true;
            // 
            // rbCentro
            // 
            this.rbCentro.AutoSize = true;
            this.rbCentro.Location = new System.Drawing.Point(1199, 403);
            this.rbCentro.Name = "rbCentro";
            this.rbCentro.Size = new System.Drawing.Size(69, 21);
            this.rbCentro.TabIndex = 15;
            this.rbCentro.TabStop = true;
            this.rbCentro.Text = "centro";
            this.rbCentro.UseVisualStyleBackColor = true;
            // 
            // rbCoord
            // 
            this.rbCoord.AutoSize = true;
            this.rbCoord.Location = new System.Drawing.Point(1299, 403);
            this.rbCoord.Name = "rbCoord";
            this.rbCoord.Size = new System.Drawing.Size(105, 21);
            this.rbCoord.TabIndex = 16;
            this.rbCoord.TabStop = true;
            this.rbCoord.Text = "coordenada";
            this.rbCoord.UseVisualStyleBackColor = true;
            // 
            // txXcoord
            // 
            this.txXcoord.Location = new System.Drawing.Point(1278, 442);
            this.txXcoord.MaxLength = 4;
            this.txXcoord.Name = "txXcoord";
            this.txXcoord.Size = new System.Drawing.Size(42, 22);
            this.txXcoord.TabIndex = 17;
            this.txXcoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txYcoord
            // 
            this.txYcoord.Location = new System.Drawing.Point(1349, 442);
            this.txYcoord.MaxLength = 4;
            this.txYcoord.Name = "txYcoord";
            this.txYcoord.Size = new System.Drawing.Size(42, 22);
            this.txYcoord.TabIndex = 18;
            this.txYcoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1296, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1359, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1284, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Escala";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1337, 585);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1274, 585);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "x";
            // 
            // txYescala
            // 
            this.txYescala.Location = new System.Drawing.Point(1322, 605);
            this.txYescala.MaxLength = 4;
            this.txYescala.Name = "txYescala";
            this.txYescala.Size = new System.Drawing.Size(42, 22);
            this.txYescala.TabIndex = 23;
            this.txYescala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txXescala
            // 
            this.txXescala.Location = new System.Drawing.Point(1251, 605);
            this.txXescala.MaxLength = 4;
            this.txXescala.Name = "txXescala";
            this.txXescala.Size = new System.Drawing.Size(42, 22);
            this.txXescala.TabIndex = 22;
            this.txXescala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1332, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1269, 507);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "x";
            // 
            // txYtrans
            // 
            this.txYtrans.Location = new System.Drawing.Point(1322, 527);
            this.txYtrans.MaxLength = 4;
            this.txYtrans.Name = "txYtrans";
            this.txYtrans.Size = new System.Drawing.Size(42, 22);
            this.txYtrans.TabIndex = 27;
            this.txYtrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txXtrans
            // 
            this.txXtrans.Location = new System.Drawing.Point(1251, 527);
            this.txXtrans.MaxLength = 4;
            this.txXtrans.Name = "txXtrans";
            this.txXtrans.Size = new System.Drawing.Size(42, 22);
            this.txXtrans.TabIndex = 26;
            this.txXtrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1275, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Translação";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1284, 650);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "Ângulo";
            // 
            // txAngulo
            // 
            this.txAngulo.Location = new System.Drawing.Point(1287, 673);
            this.txAngulo.MaxLength = 3;
            this.txAngulo.Name = "txAngulo";
            this.txAngulo.Size = new System.Drawing.Size(42, 22);
            this.txAngulo.TabIndex = 32;
            this.txAngulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAplicarTrans
            // 
            this.btAplicarTrans.Location = new System.Drawing.Point(1095, 745);
            this.btAplicarTrans.Name = "btAplicarTrans";
            this.btAplicarTrans.Size = new System.Drawing.Size(119, 30);
            this.btAplicarTrans.TabIndex = 33;
            this.btAplicarTrans.Text = "Aplicar";
            this.btAplicarTrans.UseVisualStyleBackColor = true;
            this.btAplicarTrans.Click += new System.EventHandler(this.BtAplicarTrans_Click);
            // 
            // btResetarCamp
            // 
            this.btResetarCamp.Location = new System.Drawing.Point(1272, 745);
            this.btResetarCamp.Name = "btResetarCamp";
            this.btResetarCamp.Size = new System.Drawing.Size(132, 30);
            this.btResetarCamp.TabIndex = 34;
            this.btResetarCamp.Text = "Resetar Campos";
            this.btResetarCamp.UseVisualStyleBackColor = true;
            this.btResetarCamp.Click += new System.EventHandler(this.BtResetarCamp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 802);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txYcoord);
            this.Controls.Add(this.txXcoord);
            this.Controls.Add(this.rbCoord);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPrincp)).EndInit();
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
        private System.Windows.Forms.RadioButton rbCoord;
        private System.Windows.Forms.TextBox txXcoord;
        private System.Windows.Forms.TextBox txYcoord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
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
    }
}

