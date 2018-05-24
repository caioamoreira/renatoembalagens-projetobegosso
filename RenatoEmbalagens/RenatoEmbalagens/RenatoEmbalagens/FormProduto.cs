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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void Habilitar(bool status)
        {
            txtDescricao.Enabled = status;
            txtValorCompra.Enabled = status;
            txtValorVenda.Enabled = status;
            txtEstoque.Enabled = status;
         

            dgvProdutos.Enabled = !status;


            //botoes
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnDeletar.Enabled = !status;
            btnGravar.Enabled = status;
            btnLimpar.Enabled = status;
            btnCancelar.Enabled = status;
        }

        private void limparCampos()
        {
            lblIdProdutos.Text = "";
            txtDescricao.Text = "";
            txtValorCompra.Text = "";
            txtValorVenda.Text = "";
            txtEstoque.Text = "";
            
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Produtos bllPro = new Camadas.BLL.Produtos();
            dgvProdutos.DataSource = bllPro.Select();
            Habilitar(false);
           // pnlPesquisa.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            limparCampos();
            lblIdProdutos.Text = "-1";
            txtDescricao.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblIdProdutos.Text != string.Empty)
            {
                Habilitar(true);
                txtDescricao.Focus();
            }
            else
            {
                string msg = " Não tem registros para fazer edição ";
                MessageBox.Show(msg, "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Produtos bllPro = new Camadas.BLL.Produtos();
            Camadas.Model.Produtos produtos = new Camadas.Model.Produtos();
            string msg;
            if (lblIdProdutos.Text != string.Empty)
            {
                msg = "Deseja Remover o Produto Selecionado?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    produtos.idProdutos = Convert.ToInt32(lblIdProdutos.Text);
                    bllPro.Delete(produtos);
                }
            }
            else
            {
                msg = "Não há registro para remoção...";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllPro.Select();
            limparCampos();
            Habilitar(false);
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            lblIdProdutos.Text = dgvProdutos.SelectedRows[0].Cells["idProdutos"].Value.ToString();
            txtDescricao.Text = dgvProdutos.SelectedRows[0].Cells["descricao"].Value.ToString();
            txtValorCompra.Text = dgvProdutos.SelectedRows[0].Cells["valorcompra"].Value.ToString();
            txtValorVenda.Text = dgvProdutos.SelectedRows[0].Cells["valorvenda"].Value.ToString();
            txtEstoque.Text = dgvProdutos.SelectedRows[0].Cells["estoque"].Value.ToString();
           
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Produtos bllPro = new Camadas.BLL.Produtos();
            Camadas.Model.Produtos produtos = new Camadas.Model.Produtos();
            int idProdutos = Convert.ToInt32(lblIdProdutos.Text);

            string msg;
            if (idProdutos == -1)
                msg = "Confirma inserção dos dados?";
            else msg = "Confirma alteração dos dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                produtos.idProdutos = idProdutos;
                produtos.descricao = txtDescricao.Text;
                produtos.valorcompra = Convert.ToSingle(txtValorCompra.Text);
                produtos.valorvenda = Convert.ToSingle(txtValorVenda.Text);
                produtos.estoque = Convert.ToSingle(txtEstoque.Text);
               


                if (idProdutos == -1)
                    bllPro.Insert(produtos);
                else
                {
                    bllPro.Update(produtos);
                }
            }
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllPro.Select();
            limparCampos();
            Habilitar(false);

        }
    }
}
