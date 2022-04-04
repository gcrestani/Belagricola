using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelagricolaMVC.Models.ViewModel
{
    public class ContatoIndexViewModel
    {
        public Contato Contato { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Telefone> Telefone { get; set; }

    }
}
