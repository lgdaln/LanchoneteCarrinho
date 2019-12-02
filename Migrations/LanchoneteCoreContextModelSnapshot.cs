﻿// <auto-generated />
using System;
using LanchoneteCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LanchoneteCore.Migrations
{
    [DbContext(typeof(LanchoneteCoreContext))]
    partial class LanchoneteCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LanchoneteCore.Models.Atendente", b =>
                {
                    b.Property<int>("AtendenteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Telefone");

                    b.HasKey("AtendenteID");

                    b.ToTable("Atendente");
                });

            modelBuilder.Entity("LanchoneteCore.Models.CarrinhoCompraItem", b =>
                {
                    b.Property<int>("CarrinhoCompraItemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarrinhoCompraID");

                    b.Property<int?>("ProdutoID");

                    b.Property<int>("Quantidade");

                    b.HasKey("CarrinhoCompraItemID");

                    b.HasIndex("ProdutoID");

                    b.ToTable("CarrinhoCompraItem");
                });

            modelBuilder.Entity("LanchoneteCore.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF");

                    b.Property<string>("Email");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Telefone");

                    b.HasKey("ClienteID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("LanchoneteCore.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AtendenteID");

                    b.Property<int>("ClienteID");

                    b.Property<DateTime>("Data");

                    b.Property<string>("Hora");

                    b.Property<string>("Statusp");

                    b.Property<double>("ValorAtual");

                    b.HasKey("PedidoID");

                    b.HasIndex("AtendenteID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("LanchoneteCore.Models.PedidoDetalhe", b =>
                {
                    b.Property<int>("PedidoDetalheID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PedidoID");

                    b.Property<decimal>("Preco");

                    b.Property<int>("ProdutoID");

                    b.Property<int>("Quantidade");

                    b.HasKey("PedidoDetalheID");

                    b.HasIndex("PedidoID");

                    b.HasIndex("ProdutoID");

                    b.ToTable("PedidoDetalhe");
                });

            modelBuilder.Entity("LanchoneteCore.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Disponibilidade");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("ValorUnitario");

                    b.HasKey("ProdutoID");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("LanchoneteCore.Models.CarrinhoCompraItem", b =>
                {
                    b.HasOne("LanchoneteCore.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID");
                });

            modelBuilder.Entity("LanchoneteCore.Models.Pedido", b =>
                {
                    b.HasOne("LanchoneteCore.Models.Atendente", "Atendente")
                        .WithMany("Pedidos")
                        .HasForeignKey("AtendenteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LanchoneteCore.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LanchoneteCore.Models.PedidoDetalhe", b =>
                {
                    b.HasOne("LanchoneteCore.Models.Pedido", "Pedido")
                        .WithMany("ListaPedidoDetalhe")
                        .HasForeignKey("PedidoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LanchoneteCore.Models.Produto", "Produto")
                        .WithMany("ListaPedidoDetalhe")
                        .HasForeignKey("ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}