using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelagricolaMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }
        public string Obs { get; set; }
        public ICollection<Contato> Contatos { get; set; } = new List<Contato>();

        public Cliente()
        {
        }

        public Cliente(int id, string nome, string email, string rG, string cPF, DateTime nascimento, string obs)
        {
            Id = id;
            Nome = nome;
            Email = email;
            RG = rG;
            CPF = cPF;
            Nascimento = nascimento;
            Obs = obs;
        }

        public void AdicionaContato(Contato c)
        {
            Contatos.Add(c);
        }

        public void RemoveContato(Contato c)
        {
            Contatos.Remove(c);
        }
    }
}
