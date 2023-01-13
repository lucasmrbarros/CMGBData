using Data2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data2
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=Conect")
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>()
                .HasKey(pet => pet.Id)
                .HasOptional(pet => pet.pessoa)
                .WithMany(Pessoa => Pessoa.Pets)
                .HasForeignKey(pet => pet.PessoaId);
            modelBuilder.Entity<Pessoa>()
                .HasKey(pessoa => pessoa.Id);
        }
    }
}
