using System;
using System.Collections.Generic;

namespace PMStudio.MVC.Models
{
    public partial class TipoCliente
    {
        public TipoCliente()
        {
            this.Clientes = new List<Cliente>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}