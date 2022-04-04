using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelagricolaMVC.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Telefone> ListaTelefones { get; set; } = new List<Telefone>();
        public string Relacionamento { get; set; }
        public Cliente Cliente { get; set; }

        public Contato()
        {
        }

        public Contato(int id, string nome, string relacionamento, Cliente cliente)
        {
            Id = id;
            Nome = nome;
            Relacionamento = relacionamento;
            Cliente = cliente;
        }

        public void AdicionaTelefone(Telefone t)
        {
            ListaTelefones.Add(t);
        }

        public void RemoveTelefone(Telefone t)
        {
            ListaTelefones.Remove(t);
        }
    }


    // Cada contato é representado pelas informações código, nome, lista de telefones e tipo
    //de relacionamento com o cliente(Pai, mãe, irmão...).
}
