using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelagricolaMVC.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Tel { get; set; }
        public Contato Contato { get; set; }
        public int ContatoId { get; set; }

        public Telefone()
        {
        }

        public Telefone(int id, string tel, Contato contato)
        {
            Id = id;
            Tel = tel;
            Contato = contato;
        }
    }
}
