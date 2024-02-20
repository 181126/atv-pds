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

            emp.cnpj = mtb_cnpj.Text;
            emp.razaoSocial = tb_razao_social.Text;
            emp.nomeFantasia = tb_fantasia.Text;
            emp.situacaoCadastral = cb_situacao_cad.Text;
            emp.regimeTributario = groupBox1.Text;
            emp.telefone = mtb_telefone.Text;
            emp.capitalSocial = tb_capitalsocial.Text;
            emp.tipo = groupBox2.Text;
            emp.porte = groupBox3.Text;
            emp.estado = Convert.ToString (cb_estado.Items);
            emp.cep = tb_cep.Text;
            emp.rua = tb_rua.Text;
            emp.numero = tb_numero.Text;
            emp.bairro = tb_bairro.Text;
            emp.complemento = tb_complemento.Text;  
            emp.nomeEmpresario = tb_nome.Text;
            emp.cpfEmpresario= tb_cpf.Text;


            if (emp.cnpj != null && emp.razaoSocial != null && emp.nomeFantasia != null && emp.telefone != null && 
                emp.capitalSocial != null && emp.capitalSocial != null && emp.estado != null && emp.cep != null &&
                emp.rua != null && emp.numero != null && emp.bairro != null && emp.complemento != null && emp.nomeEmpresario
                != null && emp.cpfEmpresario != null)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("a");
            }
           
        }
    }
}
