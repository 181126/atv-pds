using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv1PDS
{
    internal class Empresa
    {
        public string cnpj { get; set;} 
        public string razaoSocial { get; set; }
        public string nomeFantasia { get; set; }
        public string situacaoCadastral { get; set; }
        public string regimeTributario { get; set; } 
        public string telefone { get; set; }
        public double capitalSocial { get; set; }
        public string tipo { get; set; }
        public string porte { get; set; }
        public string naturezaJuridica { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public DateTime dataInicio { get; set; }
        public string nomeEmpresario { get; set; }
        public string cpfEmpresario { get; set; }

        public Empresa ()
        {

        }
         
        public Empresa(string cnpj, string razaoSocial, string nomeFantasia, string situacaoCadastral, string regimeTributario, string telefone, double capitalSocial, string tipo, string porte, string naturezaJuridica, string estado, string cep, string rua, string numero, string bairro, string complemento, DateTime dataInicio, string nomeEmpresario, string cpfEmpresario)
        {
            this.cnpj = cnpj;
            this.razaoSocial = razaoSocial;
            this.nomeFantasia = nomeFantasia;
            this.situacaoCadastral = situacaoCadastral;
            this.regimeTributario = regimeTributario;
            this.telefone = telefone;
            this.capitalSocial = capitalSocial;
            this.tipo = tipo;
            this.porte = porte;
            this.naturezaJuridica = naturezaJuridica;
            this.estado = estado;
            this.cep = cep;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;
            this.dataInicio = dataInicio;
            this.nomeEmpresario = nomeEmpresario;
            this.cpfEmpresario = cpfEmpresario;
        }
    }
}
