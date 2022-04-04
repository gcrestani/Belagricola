using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BelagricolaMVC.Models;

namespace BelagricolaMVC.Data
{
    public class BelagricolaMVCContext : DbContext
    {
        public BelagricolaMVCContext (DbContextOptions<BelagricolaMVCContext> options)
            : base(options)
        {
        }

        public DbSet<BelagricolaMVC.Models.Cliente> Cliente { get; set; }
        public DbSet<BelagricolaMVC.Models.Contato> Contato { get; set; }
        public DbSet<BelagricolaMVC.Models.Telefone> Telefone { get; set; }
    }
}
