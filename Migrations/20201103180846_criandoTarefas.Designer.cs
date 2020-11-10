﻿// <auto-generated />
using System;
using Agenda.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agenda.Migrations
{
    [DbContext(typeof(AgendaContext))]
    [Migration("20201103180846_criandoTarefas")]
    partial class criandoTarefas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Agenda.Models.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<string>("Descricao");

                    b.Property<DateTime>("HorarioFim");

                    b.Property<DateTime>("HorarioInicio");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Tarefa");
                });
#pragma warning restore 612, 618
        }
    }
}
