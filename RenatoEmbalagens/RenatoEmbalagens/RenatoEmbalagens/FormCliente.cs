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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void Habilitar(bool status)
        {
            txtNome.Enabled = status;
            txtEndereco.Enabled = status;
            txtTelefone.Enabled = status;
            txtCelular.Enabled = status;
            txtCidade.Enabled = status;
            txtEstado.Enabled = status;

            dataGridView1.Enabled = !status;


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
            lblIdCliente.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
        }


        private void FormCliente_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            dataGridView1.DataSource = bllCli.Select();
            Habilitar(false);
            pnlPesquisa.Visible = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            limparCampos();
            lblIdCliente.Text = "-1";
            txtNome.Focus();


           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblIdCliente.Text != string.Empty)
            {
                Habilitar(true);
                txtNome.Focus();
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


            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
            string msg;
            if (lblIdCliente.Text != string.Empty)
            {
                msg = "Deseja Remover o Cliente Selecionado?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    cliente.idCliente = Convert.ToInt32(lblIdCliente.Text);
                    bllCli.Delete(cliente);
                }
            }
            else
            {
                msg = "Não há registro para remoção...";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = bllCli.Select();
            limparCampos();
            Habilitar(false);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lblIdCliente.Text = dataGridView1.SelectedRows[0].Cells["idCliente"].Value.ToString();
                txtNome.Text = dataGridView1.SelectedRows[0].Cells["nome"].Value.ToString();
                txtEndereco.Text = dataGridView1.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtTelefone.Text = dataGridView1.SelectedRows[0].Cells["telefone"].Value.ToString();
                txtCelular.Text = dataGridView1.SelectedRows[0].Cells["celular"].Value.ToString();
                txtCidade.Text = dataGridView1.SelectedRows[0].Cells["cidade"].Value.ToString();
                txtEstado.Text = dataGridView1.SelectedRows[0].Cells["estado"].Value.ToString();

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)

        {

            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
            int idCliente = Convert.ToInt32(lblIdCliente.Text);

            string msg;
            if (idCliente == -1)
                msg = "Confirma inserção dos dados?";
            else msg = "Confirma alteração dos dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                cliente.idCliente = idCliente;
                cliente.nome = txtNome.Text;
                cliente.endereco = txtEndereco.Text;
                cliente.telefone = txtTelefone.Text;
                cliente.celular = txtCelular.Text;
                cliente.cidade = txtCidade.Text;
                cliente.estado = txtEstado.Text;


                if (idCliente == -1)
                    bllCli.Insert(cliente);
                else
                {
                    bllCli.Update(cliente);
                }
            }
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = bllCli.Select();
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = !pnlPesquisa.Visible;
            rdbTodos.Checked = true;

          
            //  rdbTodos_CheckedChanged(null,null);


        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnFiltrar.Visible = false;
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = bllCliente.Select();

        }

        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            lblPesquisa.Text = "Informa o ID: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            lblPesquisa.Text = "Informa o Nome: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnFiltrar.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbCidade_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
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
                Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
                List<Camadas.Model.Cliente> lstCliente = new List<Camadas.Model.Cliente>();

                if (rdbId.Checked == true)
                    lstCliente = bllCli.SelectByIdCliente(Convert.ToInt32(txtPesquisa.Text));
                else if (rdbNome.Checked == true)
                    lstCliente = bllCli.SelectByNome(txtPesquisa.Text);
                else if (rdbCidade.Checked == true)
                    lstCliente = bllCli.SelectByCidade(txtPesquisa.Text);

                dataGridView1.DataSource = "";
                dataGridView1.DataSource = lstCliente;
            }
            else
            {
                string msg = "Campo Pesquisa está Vazio...";
                MessageBox.Show(msg, "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void gpdPesquisar_Enter(object sender, EventArgs e)
        {

        }
    }
}
