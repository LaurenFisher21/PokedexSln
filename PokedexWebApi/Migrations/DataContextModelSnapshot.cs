﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokedexWebApi.Data;

#nullable disable

namespace PokedexWebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PokedexWebApi.Models.Pokemon", b =>
                {
                    b.Property<int>("PokemonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PokemonID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PokemonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PokemonType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PokemonID");

                    b.ToTable("Pokemon");
                });

            modelBuilder.Entity("PokedexWebApi.Models.PokemonStats", b =>
                {
                    b.Property<int>("PokeStatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PokeStatID"), 1L, 1);

                    b.Property<int>("PokeAtt")
                        .HasColumnType("int");

                    b.Property<int>("PokeDef")
                        .HasColumnType("int");

                    b.Property<int>("PokeHp")
                        .HasColumnType("int");

                    b.Property<int>("PokeSpAtt")
                        .HasColumnType("int");

                    b.Property<int>("PokeSpDef")
                        .HasColumnType("int");

                    b.Property<int>("PokemonID")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.HasKey("PokeStatID");

                    b.HasIndex("PokemonID");

                    b.ToTable("PokemonStats");
                });

            modelBuilder.Entity("PokedexWebApi.Models.PokemonStats", b =>
                {
                    b.HasOne("PokedexWebApi.Models.Pokemon", "Pokemon")
                        .WithMany()
                        .HasForeignKey("PokemonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");
                });
#pragma warning restore 612, 618
        }
    }
}
