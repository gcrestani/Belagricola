using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BelagricolaMVC
{
    public class Program
    {
        /*
         * QUESTÃO 04: Criar uma Api Rest

            EXPLICAÇÃO: Pensando no cadastro do cliente, considere os seguintes requisitos:
            Cada cliente no sistema deve possuir, além das suas informações cadastrais (limitadas em 6 informações a sua escolha),
            uma lista de contatos associados. Cada contato é representado pelas informações código, nome, lista de telefones e tipo
            de relacionamento com o cliente (Pai, mãe, irmão...). Os contatos podem estar associados a mais de um cliente, porém nunca
            possuir mais de uma associação ao mesmo cliente.

            Criar uma api Rest de consumo de clientes, onde ela deverá inserir, alterar e deletar as informações.

            O banco de dados fica a escolha do desenvolvedor.

            Criar uma aplicação para consumir a Api criada.

            Deverá ser encaminhado os dois projetos (Api e aplicação), o script do banco de dados e a documentação dos projetos.

        Models:
        Cliente
        Contatos

         */

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
