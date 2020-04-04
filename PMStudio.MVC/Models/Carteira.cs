using System;
using System.Collections.Generic;

namespace PMStudio.MVC.Models
{
    public partial class Carteira
    {
        public Carteira()
        {
            this.CarteiraProjetoList = new List<CarteiraProjeto>();
        }

        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public Nullable<int> Codigo { get; set; }
        public string Descricao { get; set; }
        public Nullable<double> Valor { get; set; }
        public string Titulo { get; set; }
        public string AdFinanceira { get; set; }
        public string AdFisica { get; set; }
        public DateTime DtCadastro { get; set; }
        public Nullable<DateTime> DtAtualizacao { get; set; }
        public string Login { get; set; }
        public SituacaoEnum Situacao { get; set; }
        public virtual ICollection<CarteiraProjeto> CarteiraProjetoList { get; set; }
    }
}