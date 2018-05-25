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
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void Habilitar(bool status)
        {
            txtEmpresa.Enabled = status;
            txtEndereco.Enabled = status;
            txtTelefone.Enabled = status;
           
            txtCidade.Enabled = status;
            txtEstado.Enabled = status;

            dgvFornecedor.Enabled = !status;


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
            lblIdFornecedor.Text = "";
            txtEmpresa.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
     
            txtCidade.Text = "";
            txtEstado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Fornecedor bllFor = new Camadas.BLL.Fornecedor();
            dgvFornecedor.DataSource = bllFor.Select();
            Habilitar(false);
            pnlPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            lblPesquisa.Visible = false;
            btnFiltrar.Visible = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            limparCampos();
            lblIdFornecedor.Text = "-1";
            txtEmpresa.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblIdFornecedor.Text != string.Empty)
            {
                Habilitar(true);
                txtEmpresa.Focus();
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
            Camadas.BLL.Fornecedor bllFor = new Camadas.BLL.Fornecedor();
            Camadas.Model.Fornecedor fornecedor = new Camadas.Model.Fornecedor();
            string msg;
            if (lblIdFornecedor.Text != string.Empty)
            {
                msg = "Deseja Remover o Fornecedor Selecionado?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    fornecedor.idFornecedor = Convert.ToInt32(lblIdFornecedor.Text);
                    bllFor.Delete(fornecedor);
                }
            }
            else
            {
                msg = "Não há registro para remoção...";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvFornecedor.DataSource = "";
            dgvFornecedor.DataSource = bllFor.Select();
            limparCampos();
            Habilitar(false);
        }

        private void dgvFornecedor_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            {
                lblIdFornecedor.Text = dgvFornecedor.SelectedRows[0].Cells["idFornecedor"].Value.ToString();
                txtEmpresa.Text = dgvFornecedor.SelectedRows[0].Cells["empresa"].Value.ToString();
                txtEndereco.Text = dgvFornecedor.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtTelefone.Text = dgvFornecedor.SelectedRows[0].Cells["telefone"].Value.ToString();
              
                txtCidade.Text = dgvFornecedor.SelectedRows[0].Cells["cidade"].Value.ToString();
                txtEstado.Text = dgvFornecedor.SelectedRows[0].Cells["estado"].Value.ToString();

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Fornecedor bllFor = new Camadas.BLL.Fornecedor();
            Camadas.Model.Fornecedor fornecedor = new Camadas.Model.Fornecedor();
            int idFornecedor = Convert.ToInt32(lblIdFornecedor.Text);

            string msg;
            if (idFornecedor == -1)
                msg = "Confirma inserção dos dados?";
            else msg = "Confirma alteração dos dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                fornecedor.idFornecedor = idFornecedor;
                fornecedor.empresa = txtEmpresa.Text;
                fornecedor.endereco = txtEndereco.Text;
                fornecedor.telefone = txtTelefone.Text;
                
                fornecedor.cidade = txtCidade.Text;
                fornecedor.estado = txtEstado.Text;


                if (idFornecedor == -1)
                    bllFor.Insert(fornecedor);
                else
                {
                    bllFor.Update(fornecedor);
                }
            }
            dgvFornecedor.DataSource = "";
            dgvFornecedor.DataSource = bllFor.Select();
            limparCampos();
            Habilitar(false);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            limparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = !pnlPesquisa.Visible;
            rdbTodos.Checked = true;
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnFiltrar.Visible = false;
            Camadas.BLL.Fornecedor bllFornecedor = new Camadas.BLL.Fornecedor();
            dgvFornecedor.DataSource = "";
            dgvFornecedor.DataSource = bllFornecedor.Select();
        }

        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            dgvFornecedor.DataSource = "";
            lblPesquisa.Text = "Informa o ID: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            dgvFornecedor.DataSource = "";
            lblPesquisa.Text = "Informa a Empresa: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbCidade_CheckedChanged(object sender, EventArgs e)
        {
            dgvFornecedor.DataSource = "";
            lblPesquisa.Text = "Informe a Cidade: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != String.Empty)
            {
                Camadas.BLL.Fornecedor bllFor = new Camadas.BLL.Fornecedor();
                List<Camadas.Model.Fornecedor> lstFornecedores = new List<Camadas.Model.Fornecedor>();

                if (rdbId.Checked == true)
                    lstFornecedores = bllFor.SelectById(Convert.ToInt32(txtPesquisa.Text));
                else if (rdbEmpresa.Checked == true)
                    lstFornecedores = bllFor.SelectByEmpresa(txtPesquisa.Text);
                else if (rdbCidade.Checked == true)
                    lstFornecedores = bllFor.SelectByCidade(txtPesquisa.Text);

                dgvFornecedor.DataSource = "";
                dgvFornecedor.DataSource = lstFornecedores;
            }
            else
            {
                string msg = "Campo Pesquisa está Vazio...";
                MessageBox.Show(msg, "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pnlPesquisar_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
