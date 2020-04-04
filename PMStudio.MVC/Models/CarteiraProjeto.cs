using System;
using System.Collections.Generic;

namespace PMStudio.MVC.Models
{
    public partial class CarteiraProjeto
    {
        public int Id { get; set; }
        public int IdProjeto { get; set; }
        public int IdCarteira { get; set; }
        public virtual Carteira Carteira { get; set; }
        public virtual Projeto Projeto { get; set; }
    }
}