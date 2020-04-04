using System;
using System.Collections.Generic;

namespace PMStudio.MVC.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            this.Clientes = new List<Cliente>();
            this.TiposProjetos = new List<TipoProjeto>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string Site { get; set; }
        public string Contato { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string Email { get; set; }
        public SituacaoEnum Situacao { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<TipoProjeto> TiposProjetos { get; set; }
    }
}