﻿// <auto-generated />
using System;
using BelagricolaMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BelagricolaMVC.Migrations
{
    [DbContext(typeof(BelagricolaMVCContext))]
    [Migration("20220404023313_ChavesEstrangeiras")]
    partial class ChavesEstrangeiras
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BelagricolaMVC.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF");

                    b.Property<string>("Email");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<string>("Obs");

                    b.Property<string>("RG");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("BelagricolaMVC.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<string>("Nome");

                    b.Property<string>("Relacionamento");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("BelagricolaMVC.Models.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContatoId");

                    b.Property<string>("Tel");

                    b.HasKey("Id");

                    b.HasIndex("ContatoId");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("BelagricolaMVC.Models.Contato", b =>
                {
                    b.HasOne("BelagricolaMVC.Models.Cliente", "Cliente")
                        .WithMany("Contatos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BelagricolaMVC.Models.Telefone", b =>
                {
                    b.HasOne("BelagricolaMVC.Models.Contato", "Contato")
                        .WithMany("ListaTelefones")
                        .HasForeignKey("ContatoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
