using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PMStudio.MVC.Models
{
    public partial class Projeto
    {
        public Projeto()
        {
            this.CarteiraProjetoList = new List<CarteiraProjeto>();
        }

        public int Id { get; set; }
        public int IdTipoProjeto { get; set; }
        public int IdCliente { get; set; }
        public string Identificador { get; set; }
        public string Nome { get; set; }
        public string Justificativa { get; set; }
        public string Objetivo { get; set; }
        public Nullable<int> Prazo { get; set; }
        public Nullable<double> Custo { get; set; }
        
        public string Descricao { get; set; }
        public string Meta { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> DtCadastro { get; set; }

        public Nullable<DateTime> DtAtualizacao { get; set; }
        public Nullable<DateTime> DtInicio { get; set; }
        public Nullable<DateTime> DtFim { get; set; }
        public string Login { get; set; }
        public SituacaoEnum Situacao { get; set; }
        public virtual ICollection<CarteiraProjeto> CarteiraProjetoList { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual TipoProjeto TiposProjetos { get; set; }
    }
}