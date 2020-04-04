using System;
using System.Collections.Generic;

namespace PMStudio.MVC.Models
{
    public partial class TipoProjeto
    {
        public TipoProjeto()
        {
            this.Projetos = new List<Projeto>();
        }

        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public string Descricao { get; set; }
        public SituacaoEnum Situacao { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<Projeto> Projetos { get; set; }
    }
}