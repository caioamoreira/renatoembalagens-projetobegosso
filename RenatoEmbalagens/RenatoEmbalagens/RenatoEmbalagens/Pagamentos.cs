using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenatoEmbalagens
{
    public partial class Pagamentos : Form
    {
        public Pagamentos()
        {
            InitializeComponent();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void Pagamentos_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Compras bllCompras = new Camadas.BLL.Compras();
            cbxCompras.DisplayMember = "idCompras";
            cbxCompras.ValueMember = "idCompras";
            cbxCompras.DataSource = bllCompras.Select();


            Camadas.BLL.Pagamentos bllpagamento = new Camadas.BLL.Pagamentos();
            dgvPagamentos.DataSource = bllpagamento.Select();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lblId.Text = "-1";
            Vencimento.Text = DateTime.Now.ToShortDateString();

            Vencimento.Enabled = true;
            txtValor.Enabled = true;
            txtPago.Enabled = true;
            cbxCompras.Enabled = true;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
        

            Vencimento.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Pagamentos bllPagamento = new Camadas.BLL.Pagamentos();
            Camadas.Model.Pagamentos pagamentos = new Camadas.Model.Pagamentos();
            int idPagamento = Convert.ToInt32(lblId.Text);

            string msg = "";
            if (idPagamento == -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Inclusão da Compra?";
            else msg = "Confirma Atualização da Compra?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
              
                pagamentos.idPagamento = idPagamento;
                pagamentos.idCompras = Convert.ToInt32(cbxCompras.Text);
                pagamentos.Parcela = Convert.ToInt32(txtParcela.Text);
                pagamentos.Vencimento = Vencimento.Value;
                pagamentos.Valor = Convert.ToSingle(txtValor.Text);
                pagamentos.Pago = Convert.ToChar(txtPago.Text);


                if (idPagamento == -1)  //-1 indica inserir 
                    bllPagamento.Insert(pagamentos);
                else bllPagamento.Update(pagamentos);
            }
            dgvPagamentos.DataSource = "";
            dgvPagamentos.DataSource = bllPagamento.Select();
        }
    }
}
