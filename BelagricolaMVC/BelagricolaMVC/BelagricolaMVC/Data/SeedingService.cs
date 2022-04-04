using BelagricolaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelagricolaMVC.Data
{
    public class SeedingService
    {
        private BelagricolaMVCContext _context;

        public SeedingService(BelagricolaMVCContext context)
        {
            _context = context;
        }
        
        public void Seed()
        {
            if (_context.Cliente.Any() || _context.Contato.Any() || _context.Telefone.Any())
            {
                return; //bd já possui dados
            }

            Cliente c1 = new Cliente(1, "Guilherme Crestani", "gcrestanis@gmail.com", "43.233.123-X", "100.323.414-12", new DateTime(2000, 10, 10), "Texto obs");
            Cliente c2 = new Cliente(2, "Joao da Silva", "joao@gmail.com", "12.345.678-9", "313.131.313-13", new DateTime(1990, 08, 08), "");
            Cliente c3 = new Cliente(3, "Maria Aparecida", "maria@gmail.com", "23.456.789-0", "456.654.456-64", new DateTime(1992, 06, 06), "Cliente novo");
            Cliente c4 = new Cliente(4, "Henrique Alberto", "henrique@gmail.com", "78.901.234-5", "789.987.789-98", new DateTime(2005, 05, 05), "Entrar em contato de manhã");
            Cliente c5 = new Cliente(5, "Fátima Santos", "fatima@gmail.com", "90.123.456-x", "147.285.369-78", new DateTime(1987, 03,03), "Não atende");

            Contato cont1 = new Contato(1, "Joaquim Crestani", "Pai", c1);
            Contato cont2 = new Contato(2, "Maria dos Santos", "Mãe", c1);
            Contato cont3 = new Contato(3, "Pedro da Silva", "Irmão", c2);
            Contato cont4 = new Contato(4, "Alberto Augusto", "Esposo", c3);
            Contato cont5 = new Contato(5, "Marcia Santos", "Irmã", c3);
            Contato cont6 = new Contato(6, "Jessica Alves", "Mãe", c4);
            Contato cont7 = new Contato(7, "Pedro", "Irmão", c5);

            Telefone t1 = new Telefone(1, "(55) 4545 5678", cont1);
            Telefone t2 = new Telefone(2, "(11) 9 1234 5678", cont2);
            Telefone t3 = new Telefone(3, "(17) 9 1232 2134", cont3);
            Telefone t4 = new Telefone(4, "(23) 9 4578 6521", cont4);
            Telefone t5 = new Telefone(5, "(21) 9 9685 7485", cont5);
            Telefone t6 = new Telefone(6, "(88) 7895 4648", cont6);
            Telefone t7 = new Telefone(7, "(42) 9 4592 2315", cont6);
            Telefone t8 = new Telefone(8, "(11) 9 3456 6894", cont7);
            Telefone t9 = new Telefone(9, "(11) 3121 4549", cont7);

            _context.Cliente.AddRange(c1, c2, c3, c4, c5);
            _context.Contato.AddRange(cont1, cont2, cont3, cont4, cont5, cont6, cont7);
            _context.Telefone.AddRange(t1,t2,t3,t4,t5,t6,t7,t8,t9);
            _context.SaveChanges();


        }
    }
}
