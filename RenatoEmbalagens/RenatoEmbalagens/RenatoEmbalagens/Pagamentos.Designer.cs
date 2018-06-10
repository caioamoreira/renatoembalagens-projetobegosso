namespace RenatoEmbalagens
{
    partial class Pagamentos
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
            this.lblIdPagamento = new System.Windows.Forms.Label();
            this.lblCompras = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbxCompras = new System.Windows.Forms.ComboBox();
            this.dgvPagamentos = new System.Windows.Forms.DataGridView();
            this.Vencimento = new System.Windows.Forms.DateTimePicker();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdPagamento
            // 
            this.lblIdPagamento.AutoSize = true;
            this.lblIdPagamento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPagamento.Location = new System.Drawing.Point(86, 9);
            this.lblIdPagamento.Name = "lblIdPagamento";
            this.lblIdPagamento.Size = new System.Drawing.Size(33, 17);
            this.lblIdPagamento.TabIndex = 0;
            this.lblIdPagamento.Text = "ID :";
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.Location = new System.Drawing.Point(37, 43);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(83, 17);
            this.lblCompras.TabIndex = 1;
            this.lblCompras.Text = "Compras :";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcela.Location = new System.Drawing.Point(45, 74);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(74, 17);
            this.lblParcela.TabIndex = 2;
            this.lblParcela.Text = "Parcela :";
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimento.Location = new System.Drawing.Point(16, 106);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(103, 17);
            this.lblVencimento.TabIndex = 3;
            this.lblVencimento.Text = "Vencimento :";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(61, 138);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(56, 17);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor :";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Location = new System.Drawing.Point(67, 170);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(50, 17);
            this.lblPago.TabIndex = 5;
            this.lblPago.Text = "Pago:";
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(125, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // txtParcela
            // 
            this.txtParcela.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcela.Location = new System.Drawing.Point(127, 71);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(54, 25);
            this.txtParcela.TabIndex = 7;
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(123, 167);
            this.txtPago.MaxLength = 1;
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(37, 25);
            this.txtPago.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(125, 135);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(79, 25);
            this.txtValor.TabIndex = 9;
            // 
            // cbxCompras
            // 
            this.cbxCompras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCompras.FormattingEnabled = true;
            this.cbxCompras.Location = new System.Drawing.Point(128, 40);
            this.cbxCompras.Name = "cbxCompras";
            this.cbxCompras.Size = new System.Drawing.Size(53, 25);
            this.cbxCompras.TabIndex = 11;
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Location = new System.Drawing.Point(19, 293);
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.Size = new System.Drawing.Size(527, 100);
            this.dgvPagamentos.TabIndex = 12;
            // 
            // Vencimento
            // 
            this.Vencimento.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vencimento.CustomFormat = "dd-mm-yyyy";
            this.Vencimento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vencimento.Location = new System.Drawing.Point(127, 104);
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.Size = new System.Drawing.Size(113, 25);
            this.Vencimento.TabIndex = 13;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(12, 239);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(93, 239);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(174, 239);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 16;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(255, 239);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(336, 239);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Pagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 430);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.Vencimento);
            this.Controls.Add(this.dgvPagamentos);
            this.Controls.Add(this.cbxCompras);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.txtParcela);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblVencimento);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.lblIdPagamento);
            this.Name = "Pagamentos";
            this.Text = "Pagamentos";
            this.Load += new System.EventHandler(this.Pagamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdPagamento;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbxCompras;
        private System.Windows.Forms.DataGridView dgvPagamentos;
        private System.Windows.Forms.DateTimePicker Vencimento;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
    }
}