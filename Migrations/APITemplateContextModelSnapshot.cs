﻿// <auto-generated />
using APITemplateAPI.Models.DB.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APITemplate.Migrations
{
    [DbContext(typeof(APITemplateContext))]
    partial class APITemplateContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APITemplateAPI.Models.TbEmployee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("contacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("primeiroNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ultimoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TbEmployees");
                });
#pragma warning restore 612, 618
        }
    }
}