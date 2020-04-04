using System;
using System.Collections.Generic;

namespace PMStudio.MVC.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            this.Projetos = new List<Projeto>();
        }

        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public int IdTipoCliente { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual TipoCliente TipoCliente { get; set; }
        public virtual ICollection<Projeto> Projetos { get; set; }
    }
}