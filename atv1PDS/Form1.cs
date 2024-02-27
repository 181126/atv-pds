using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv1PDS
{
    public partial class Form1 : Form
    { 
       List<Empresa> lista = new List<Empresa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_capital_social_Click(object sender, EventArgs e)
        {

        }

        private void tb_razao_social_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_complemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();

            try {
                emp.cnpj = mtb_cnpj.Text;
                emp.razaoSocial = tb_razao_social.Text;
                emp.nomeFantasia = tb_fantasia.Text;
                emp.situacaoCadastral = cb_situacao_cad.Text;
                emp.telefone = mtb_telefone.Text;
                emp.capitalSocial = Convert.ToDouble(tb_capitalsocial.Text);
                emp.naturezaJuridica = cb_nat_juridica.Text;
                emp.estado = cb_estado.Text;
                emp.cep = tb_cep.Text;
                emp.rua = tb_rua.Text;
                emp.numero = tb_numero.Text;
                emp.bairro = tb_bairro.Text;
                emp.complemento = tb_complemento.Text;
                emp.dataInicio = dtp_dataInicio.Value;
                emp.nomeEmpresario = tb_nome.Text;
                emp.cpfEmpresario = mtb_cpf.Text;

                if (rb_simples_nacional.Checked)
                {
                    emp.regimeTributario = "Simples Nacional";
                }
                else if (rb_lucro_real.Checked)
                {
                    emp.regimeTributario = "Lucro Real";
                }
                else if (rb_lucro_presumido.Checked)
                {
                    emp.regimeTributario = "Lucro Presumido";
                }

                if (rb_matriz.Checked)
                {
                    emp.tipo = "Matriz";
                }
                else if (rb_filial.Checked)
                {
                    emp.tipo = "Filial";
                }

                if (rb_pequeno.Checked)
                {
                    emp.porte = "Pequeno";
                }
                else if (rb_medio.Checked)
                {
                    emp.porte = "Médio";
                }
                else if (rb_grande.Checked)
                {
                    emp.porte = "Grande";
                }

                lista.Add(emp);

                dgv1.DataSource = null;
                dgv1.Refresh();
                dgv1.DataSource = lista; 
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um Erro! {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rb_simples_nacional_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mtb_cnpj.Clear();
            tb_razao_social.Clear();
            tb_fantasia.Clear();
            cb_situacao_cad.SelectedItem = null;
            mtb_telefone.Clear();
            rb_simples_nacional.Checked = false;
            rb_lucro_presumido.Checked = false;
            rb_lucro_real.Checked = false;
            dtp_dataInicio.Value = DateTime.Now;
            tb_capitalsocial.Clear();
            cb_estado.SelectedItem = null;
            tb_cep.Clear();
            tb_rua.Clear();
            tb_numero.Clear();  
            tb_bairro.Clear();
            tb_complemento.Clear();
            cb_nat_juridica.SelectedItem = null;
            tb_nome.Clear();
            mtb_cpf.Clear();
            rb_matriz.Checked = false;
            rb_filial.Checked = false;
            rb_pequeno.Checked = false;
            rb_medio.Checked = false;
            rb_grande.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int excluir = dgv1.CurrentCell.RowIndex;
            lista.RemoveAt(excluir);

            dgv1.DataSource = null;//zerar ou seja deixar sem nenhum elemento
            dgv1.Refresh();//atualizar toda tabela
            dgv1.DataSource = lista;
        }
    }
}
