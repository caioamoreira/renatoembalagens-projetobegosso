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
    public partial class FormCompras : Form
    {
        
        public FormCompras()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pnlCompras_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            // carregar dados combo cliente
            Camadas.BLL.Fornecedor bllFornecedor = new Camadas.BLL.Fornecedor();
            cbxIdFornecedor.DisplayMember = "empresa";
            cbxIdFornecedor.ValueMember = "idFornecedor";
            cbxIdFornecedor.DataSource = bllFornecedor.Select();

            ///carregar dados combo idCompras
            Camadas.BLL.Compras bllcompras = new Camadas.BLL.Compras();
            cbxIdCompras.DisplayMember = "idCompras";
            cbxIdCompras.ValueMember = "idCompras";
            cbxIdCompras.DataSource = bllcompras.Select();

            /// carrefar dados combo Produtos
            Camadas.BLL.Produtos bllPro = new Camadas.BLL.Produtos();
            cbxProdutos.DisplayMember = "descricao";
            cbxProdutos.ValueMember = "idProdutos";
            cbxProdutos.DataSource = bllPro.Select();


            //preencher grid compras
            Camadas.BLL.Compras bllCompras = new Camadas.BLL.Compras();
            dgvCompras.DataSource = bllCompras.Select();
            //  lblIdCompras.Text = dgvCompras.Rows[0].Cells["idCompras"].Value.ToString();
            // data.Text = dgvCompras.Rows[0].Cells["DataCompra"].Value.ToString();
            //  txtIdFornecedor.Text = dgvCompras.Rows[0].Cells["IdFornecedor"].Value.ToString();
            //   cbxIdFornecedor.SelectedValue = Convert.ToInt32(txtIdFornecedor.Text);

            //preender grid detalhe vendas
            Camadas.BLL.Detalhe_Compras blldetalhecompras = new Camadas.BLL.Detalhe_Compras();
            dgvDetalheCompras.DataSource = blldetalhecompras.Select();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lblIdCompras.Text = "-1";
            data.Text = DateTime.Now.ToShortDateString();

            data.Enabled = true;
            txtIdFornecedor.Enabled = true;
            cbxIdFornecedor.Enabled = true;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;

            data.Focus();
        }

        private void RecuperaDadosProduto()
        {
            Camadas.BLL.Fornecedor bllFornecedor = new Camadas.BLL.Fornecedor();
            List<Camadas.Model.Fornecedor> lstFornecedor = new List<Camadas.Model.Fornecedor>();
            lstFornecedor = bllFornecedor.SelectById(Convert.ToInt32(txtIdFornecedor.Text));


            //       txtIdFornecedor.Text = fornecedor.status.ToString();




        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Compras bllCompras = new Camadas.BLL.Compras();
            Camadas.Model.Compras compras = new Camadas.Model.Compras();
            int id = Convert.ToInt32(lblIdCompras.Text);

            string msg = "";
            if (id == -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Inclusão da Compra?";
            else msg = "Confirma Atualização da Compra?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                compras.idCompras = id;
                compras.DataCompra = data.Value;
                compras.idFornecedor = Convert.ToInt32(txtIdFornecedor.Text);
                compras.Empresa = cbxIdFornecedor.Text;



                if (id == -1)  //-1 indica inserir 
                    bllCompras.Insert(compras);
                else bllCompras.Update(compras);
            }
            dgvCompras.DataSource = "";
            dgvCompras.DataSource = bllCompras.Select();  //atualiza a grid
                                                          //   LimpaControlesVendas(); //limpa campos
                                                          //   HabilitaControlesVendas(false);  //desabilita controles




            /////////////////////






            data.Enabled = false;
            txtIdCompras.Enabled = false;
            cbxIdFornecedor.Enabled = false;
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
        }

        private void cbxIdFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdFornecedor.Text = cbxIdFornecedor.SelectedValue.ToString();
        }

        public void BuscarEmpresa()
        {

        }

        private void cbxIdCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdCompras.Text = cbxIdCompras.SelectedValue.ToString();
        }

        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProdutos.Text = cbxProdutos.SelectedValue.ToString();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Detalhe_Compras blldetalhecompras = new Camadas.BLL.Detalhe_Compras();
            Camadas.Model.Detalhe_Compras detalhecompras = new Camadas.Model.Detalhe_Compras();
            int id = Convert.ToInt32(lblIdc.Text);

            string msg = "";
            if (id == -1) // id=-1 (Inclusão) e id!=-1 (atualização)
                msg = "Confirma Inclusão da Compra?";
            else msg = "Confirma Atualização da Compra?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                detalhecompras.id = id;
                detalhecompras.idCompras = Convert.ToInt32(txtIdCompras.Text);
              
                detalhecompras.idProdutos = Convert.ToInt32(txtProdutos.Text);

                detalhecompras.Produtos = cbxProdutos.Text;
                detalhecompras.Qtde = Convert.ToSingle(txtQtde.Text);
                detalhecompras.Valor = Convert.ToSingle(txtValor.Text);
                detalhecompras.Total = Convert.ToSingle(txtTotal.Text);



                if (id == -1)  //-1 indica inserir 
                    blldetalhecompras.Insert(detalhecompras);
                else blldetalhecompras.Update(detalhecompras);
            }
            dgvDetalheCompras.DataSource = "";
            dgvDetalheCompras.DataSource = blldetalhecompras.Select();
        }

        private void lblid1_Click(object sender, EventArgs e)
        {

        }

        private void btnNvo_Click(object sender, EventArgs e)
        {
            lblIdc.Text = "-1";
            

            
            txtIdCompras.Enabled = true;
            cbxIdCompras.Enabled = true;
            txtProdutos.Enabled = true;
            cbxProdutos.Enabled = true;
            txtQtde.Enabled = true;
            txtValor.Enabled = true;
            txtTotal.Enabled = true;
            btnNvo.Enabled = false;
            btnInserir.Enabled = true;
         




            txtQtde.Focus();

        }

        private void dgvDetalheCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private int qtdPrd = 0;
        private float ValorProd;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(txtQtde.Text != "" && txtValor.Text != "")
            {
                qtdPrd = Convert.ToInt32(txtQtde.Text);
                ValorProd =(float) Convert.ToDecimal(txtValor.Text);

                txtTotal.Text = "" + qtdPrd * ValorProd;
            }
            else
            {
                txtTotal.Clear();
            }

        }
    }

}
