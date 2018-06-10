namespace RenatoEmbalagens
{
    partial class FormCompras
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
            this.components = new System.ComponentModel.Container();
            this.pnlCompras = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cbxIdFornecedor = new System.Windows.Forms.ComboBox();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.lblIdCompras = new System.Windows.Forms.Label();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.lblIdFornecedor = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.pnlDetalheCompras = new System.Windows.Forms.Panel();
            this.btnNvo = new System.Windows.Forms.Button();
            this.lblIdc = new System.Windows.Forms.Label();
            this.lblid1 = new System.Windows.Forms.Label();
            this.lblId_Compras = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbxProdutos = new System.Windows.Forms.ComboBox();
            this.cbxIdCompras = new System.Windows.Forms.ComboBox();
            this.txtProdutos = new System.Windows.Forms.TextBox();
            this.txtIdCompras = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.lblId_Produtos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDetalheCompras = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.pnlDetalheCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalheCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCompras
            // 
            this.pnlCompras.Controls.Add(this.label5);
            this.pnlCompras.Controls.Add(this.txtIdFornecedor);
            this.pnlCompras.Controls.Add(this.btnSair);
            this.pnlCompras.Controls.Add(this.btnLimpar);
            this.pnlCompras.Controls.Add(this.btnGravar);
            this.pnlCompras.Controls.Add(this.btnNovo);
            this.pnlCompras.Controls.Add(this.cbxIdFornecedor);
            this.pnlCompras.Controls.Add(this.data);
            this.pnlCompras.Controls.Add(this.lblIdCompras);
            this.pnlCompras.Controls.Add(this.lblDataCompra);
            this.pnlCompras.Controls.Add(this.lblIdFornecedor);
            this.pnlCompras.Controls.Add(this.lblId);
            this.pnlCompras.Controls.Add(this.dgvCompras);
            this.pnlCompras.Location = new System.Drawing.Point(23, 24);
            this.pnlCompras.Name = "pnlCompras";
            this.pnlCompras.Size = new System.Drawing.Size(693, 185);
            this.pnlCompras.TabIndex = 0;
            this.pnlCompras.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCompras_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Compra Fornecedores";
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFornecedor.Location = new System.Drawing.Point(129, 38);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(34, 26);
            this.txtIdFornecedor.TabIndex = 11;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(489, 73);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(67, 29);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(416, 73);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(67, 29);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(340, 73);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(67, 29);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(258, 73);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(67, 29);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cbxIdFornecedor
            // 
            this.cbxIdFornecedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdFornecedor.FormattingEnabled = true;
            this.cbxIdFornecedor.Location = new System.Drawing.Point(169, 39);
            this.cbxIdFornecedor.Name = "cbxIdFornecedor";
            this.cbxIdFornecedor.Size = new System.Drawing.Size(156, 26);
            this.cbxIdFornecedor.TabIndex = 6;
            this.cbxIdFornecedor.SelectedIndexChanged += new System.EventHandler(this.cbxIdFornecedor_SelectedIndexChanged);
            // 
            // data
            // 
            this.data.CustomFormat = "dd-MM-yyyy";
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data.Location = new System.Drawing.Point(129, 71);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(93, 20);
            this.data.TabIndex = 5;
            // 
            // lblIdCompras
            // 
            this.lblIdCompras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCompras.Location = new System.Drawing.Point(129, 6);
            this.lblIdCompras.Name = "lblIdCompras";
            this.lblIdCompras.Size = new System.Drawing.Size(34, 18);
            this.lblIdCompras.TabIndex = 4;
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompra.Location = new System.Drawing.Point(62, 73);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(55, 18);
            this.lblDataCompra.TabIndex = 3;
            this.lblDataCompra.Text = "Data :";
            // 
            // lblIdFornecedor
            // 
            this.lblIdFornecedor.AutoSize = true;
            this.lblIdFornecedor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFornecedor.Location = new System.Drawing.Point(6, 42);
            this.lblIdFornecedor.Name = "lblIdFornecedor";
            this.lblIdFornecedor.Size = new System.Drawing.Size(111, 18);
            this.lblIdFornecedor.TabIndex = 2;
            this.lblIdFornecedor.Text = "Fornecedor :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(83, 6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 18);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID :";
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(65, 108);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(446, 64);
            this.dgvCompras.TabIndex = 0;
            // 
            // pnlDetalheCompras
            // 
            this.pnlDetalheCompras.Controls.Add(this.btnNvo);
            this.pnlDetalheCompras.Controls.Add(this.lblIdc);
            this.pnlDetalheCompras.Controls.Add(this.lblid1);
            this.pnlDetalheCompras.Controls.Add(this.lblId_Compras);
            this.pnlDetalheCompras.Controls.Add(this.btnDeletar);
            this.pnlDetalheCompras.Controls.Add(this.label11);
            this.pnlDetalheCompras.Controls.Add(this.btnEditar);
            this.pnlDetalheCompras.Controls.Add(this.txtQtde);
            this.pnlDetalheCompras.Controls.Add(this.btnCancelar);
            this.pnlDetalheCompras.Controls.Add(this.txtValor);
            this.pnlDetalheCompras.Controls.Add(this.btnInserir);
            this.pnlDetalheCompras.Controls.Add(this.txtTotal);
            this.pnlDetalheCompras.Controls.Add(this.cbxProdutos);
            this.pnlDetalheCompras.Controls.Add(this.cbxIdCompras);
            this.pnlDetalheCompras.Controls.Add(this.txtProdutos);
            this.pnlDetalheCompras.Controls.Add(this.txtIdCompras);
            this.pnlDetalheCompras.Controls.Add(this.lblTotal);
            this.pnlDetalheCompras.Controls.Add(this.lblValorPago);
            this.pnlDetalheCompras.Controls.Add(this.lblQtde);
            this.pnlDetalheCompras.Controls.Add(this.lblId_Produtos);
            this.pnlDetalheCompras.Controls.Add(this.label6);
            this.pnlDetalheCompras.Controls.Add(this.dgvDetalheCompras);
            this.pnlDetalheCompras.Location = new System.Drawing.Point(23, 215);
            this.pnlDetalheCompras.Name = "pnlDetalheCompras";
            this.pnlDetalheCompras.Size = new System.Drawing.Size(693, 279);
            this.pnlDetalheCompras.TabIndex = 1;
            // 
            // btnNvo
            // 
            this.btnNvo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNvo.Location = new System.Drawing.Point(214, 151);
            this.btnNvo.Name = "btnNvo";
            this.btnNvo.Size = new System.Drawing.Size(75, 23);
            this.btnNvo.TabIndex = 20;
            this.btnNvo.Text = "Novo";
            this.btnNvo.UseVisualStyleBackColor = true;
            this.btnNvo.Click += new System.EventHandler(this.btnNvo_Click);
            // 
            // lblIdc
            // 
            this.lblIdc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdc.Location = new System.Drawing.Point(129, 21);
            this.lblIdc.Name = "lblIdc";
            this.lblIdc.Size = new System.Drawing.Size(28, 15);
            this.lblIdc.TabIndex = 19;
            // 
            // lblid1
            // 
            this.lblid1.AutoSize = true;
            this.lblid1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid1.Location = new System.Drawing.Point(89, 21);
            this.lblid1.Name = "lblid1";
            this.lblid1.Size = new System.Drawing.Size(28, 15);
            this.lblid1.TabIndex = 18;
            this.lblid1.Text = "ID :";
            this.lblid1.Click += new System.EventHandler(this.lblid1_Click);
            // 
            // lblId_Compras
            // 
            this.lblId_Compras.AutoSize = true;
            this.lblId_Compras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_Compras.Location = new System.Drawing.Point(30, 50);
            this.lblId_Compras.Name = "lblId_Compras";
            this.lblId_Compras.Size = new System.Drawing.Size(87, 15);
            this.lblId_Compras.TabIndex = 17;
            this.lblId_Compras.Text = "ID Compras:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(585, 151);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 16;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(336, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "Detalhe Compras";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(490, 151);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(129, 102);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(47, 20);
            this.txtQtde.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(399, 151);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(129, 128);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(47, 20);
            this.txtValor.TabIndex = 11;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(305, 151);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(129, 154);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(47, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // cbxProdutos
            // 
            this.cbxProdutos.FormattingEnabled = true;
            this.cbxProdutos.Location = new System.Drawing.Point(182, 75);
            this.cbxProdutos.Name = "cbxProdutos";
            this.cbxProdutos.Size = new System.Drawing.Size(243, 21);
            this.cbxProdutos.TabIndex = 9;
            this.cbxProdutos.SelectedIndexChanged += new System.EventHandler(this.cbxProdutos_SelectedIndexChanged);
            // 
            // cbxIdCompras
            // 
            this.cbxIdCompras.FormattingEnabled = true;
            this.cbxIdCompras.Location = new System.Drawing.Point(182, 48);
            this.cbxIdCompras.Name = "cbxIdCompras";
            this.cbxIdCompras.Size = new System.Drawing.Size(57, 21);
            this.cbxIdCompras.TabIndex = 8;
            this.cbxIdCompras.SelectedIndexChanged += new System.EventHandler(this.cbxIdCompras_SelectedIndexChanged);
            // 
            // txtProdutos
            // 
            this.txtProdutos.Location = new System.Drawing.Point(129, 75);
            this.txtProdutos.Name = "txtProdutos";
            this.txtProdutos.Size = new System.Drawing.Size(47, 20);
            this.txtProdutos.TabIndex = 7;
            // 
            // txtIdCompras
            // 
            this.txtIdCompras.Location = new System.Drawing.Point(129, 48);
            this.txtIdCompras.Name = "txtIdCompras";
            this.txtIdCompras.Size = new System.Drawing.Size(47, 20);
            this.txtIdCompras.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(70, 154);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 15);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total :";
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.Location = new System.Drawing.Point(68, 130);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(49, 15);
            this.lblValorPago.TabIndex = 4;
            this.lblValorPago.Text = "Valor :";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.Location = new System.Drawing.Point(28, 102);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(89, 15);
            this.lblQtde.TabIndex = 3;
            this.lblQtde.Text = "Quantidade :";
            // 
            // lblId_Produtos
            // 
            this.lblId_Produtos.AutoSize = true;
            this.lblId_Produtos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_Produtos.Location = new System.Drawing.Point(44, 77);
            this.lblId_Produtos.Name = "lblId_Produtos";
            this.lblId_Produtos.Size = new System.Drawing.Size(73, 15);
            this.lblId_Produtos.TabIndex = 2;
            this.lblId_Produtos.Text = "Produtos :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 1;
            // 
            // dgvDetalheCompras
            // 
            this.dgvDetalheCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalheCompras.Location = new System.Drawing.Point(3, 179);
            this.dgvDetalheCompras.Name = "dgvDetalheCompras";
            this.dgvDetalheCompras.Size = new System.Drawing.Size(687, 97);
            this.dgvDetalheCompras.TabIndex = 0;
            this.dgvDetalheCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalheCompras_CellContentClick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 522);
            this.Controls.Add(this.pnlDetalheCompras);
            this.Controls.Add(this.pnlCompras);
            this.Name = "FormCompras";
            this.Text = "FormCompras";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            this.pnlCompras.ResumeLayout(false);
            this.pnlCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.pnlDetalheCompras.ResumeLayout(false);
            this.pnlDetalheCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalheCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCompras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cbxIdFornecedor;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Label lblIdCompras;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.Label lblIdFornecedor;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Panel pnlDetalheCompras;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbxProdutos;
        private System.Windows.Forms.ComboBox cbxIdCompras;
        private System.Windows.Forms.TextBox txtProdutos;
        private System.Windows.Forms.TextBox txtIdCompras;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Label lblId_Produtos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblId_Compras;
        private System.Windows.Forms.DataGridView dgvDetalheCompras;
        private System.Windows.Forms.Label lblid1;
        private System.Windows.Forms.Label lblIdc;
        private System.Windows.Forms.Button btnNvo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}