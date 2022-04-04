using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelagricolaMVC.Models.ViewModel
{
    public class ContatoFormViewModel
    {
        public Contato Contato { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
    }
}
