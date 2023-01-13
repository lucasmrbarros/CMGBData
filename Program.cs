using Data2;
using Data2.Models;
using System.Collections.Immutable;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

class Program
{
    static void Main(string[] args)
    {

        using (var ctx = new AppDbContext())
        {
            //CriacaoPessoas

            var pessoa1 = new Pessoa() { Nome = "Marcos", Idade = 26, QdtFilhos = 1 };

            ctx.Pessoas.Add(pessoa1);
            ctx.SaveChanges();


            var pessoa2 = new Pessoa() { Nome = "Luiza", Idade = 22, QdtFilhos = 0 };

            ctx.Pessoas.Add(pessoa2);
            ctx.SaveChanges();

            var pessoa3 = new Pessoa() { Nome = "Lucas", Idade = 25, QdtFilhos = 0 };

            ctx.Pessoas.Add(pessoa3);
            ctx.SaveChanges();

            var pessoa4 = new Pessoa() { Nome = "Andressa", Idade = 23, QdtFilhos = 0 };

            ctx.Pessoas.Add(pessoa4);
            ctx.SaveChanges();

            var pessoa5 = new Pessoa() { Nome = "Antonio", Idade = 42, QdtFilhos = 1 };

            ctx.Pessoas.Add(pessoa5);
            ctx.SaveChanges();

            var pessoa6 = new Pessoa() { Nome = "Jessica", Idade = 50, QdtFilhos = 2 };

            ctx.Pessoas.Add(pessoa6);
            ctx.SaveChanges();

            var pessoa7 = new Pessoa() { Nome = "Adriana", Idade = 89, QdtFilhos = 4 };

            ctx.Pessoas.Add(pessoa7);
            ctx.SaveChanges();

            var pessoa8 = new Pessoa() { Nome = "João", Idade = 45, QdtFilhos = 2 };

            ctx.Pessoas.Add(pessoa8);
            ctx.SaveChanges();

            var pessoa9 = new Pessoa() { Nome = "Jean", Idade = 35, QdtFilhos = 1 };

            ctx.Pessoas.Add(pessoa9);
            ctx.SaveChanges();

            var pessoa10 = new Pessoa() { Nome = "Leonardo", Idade = 51, QdtFilhos = 3 };

            ctx.Pessoas.Add(pessoa10);
            ctx.SaveChanges();


            //CriacaoPet
            var pet1 = new Pet() { Nome = "Toby", Adotado = false };

            ctx.Pets.Add(pet1);
            ctx.SaveChanges();

            var pet2 = new Pet() { Nome = "Buddy", Adotado = false };

            ctx.Pets.Add(pet2);
            ctx.SaveChanges();

            var pet3 = new Pet() { Nome = "Nico", Adotado = false };

            ctx.Pets.Add(pet3);
            ctx.SaveChanges();

            var pet4 = new Pet() { Nome = "Toddy", Adotado = false };

            ctx.Pets.Add(pet4);
            ctx.SaveChanges();

            var pet5 = new Pet() { Nome = "Max", Adotado = false };

            ctx.Pets.Add(pet5);
            ctx.SaveChanges();

            var pet6 = new Pet() { Nome = "Dudu", Adotado = false };

            ctx.Pets.Add(pet6);
            ctx.SaveChanges();

            var pet7 = new Pet() { Nome = "Snow", Adotado = false };

            ctx.Pets.Add(pet7);
            ctx.SaveChanges();

            var pet8 = new Pet() { Nome = "Joe", Adotado = false };

            ctx.Pets.Add(pet8);
            ctx.SaveChanges();

            var pet9 = new Pet() { Nome = "Bud", Adotado = true, PessoaId = 6 };

            ctx.Pets.Add(pet9);
            ctx.SaveChanges();

            var pet10 = new Pet() { Nome = "Kiara", Adotado = true, PessoaId = 7 };

            ctx.Pets.Add(pet10);
            ctx.SaveChanges();

            var pet11 = new Pet() { Nome = "Millie", Adotado = true, PessoaId = 7 };

            ctx.Pets.Add(pet11);
            ctx.SaveChanges();

            var pet12 = new Pet() { Nome = "Pink", Adotado = true, PessoaId = 2 };

            ctx.Pets.Add(pet12);
            ctx.SaveChanges();

            var pet13 = new Pet() { Nome = "Lana", Adotado = true, PessoaId = 2 };

            ctx.Pets.Add(pet13);
            ctx.SaveChanges();

            var pet14 = new Pet() { Nome = "Lucky", Adotado = true, PessoaId = 3 };

            ctx.Pets.Add(pet14);
            ctx.SaveChanges();


            //Consultas 
            Console.WriteLine("Pessoas que possuem pets:");

            var pessoaComPets = (from s in ctx.Pessoas
                                 where s.Pets.Count() > 0
                                 select s.Nome).ToList();

            foreach (var i in pessoaComPets)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Pessoas que possuem filhos e não possuem pets:");

            var pessoaComFilhoSemPets = (from s in ctx.Pessoas
                                         where (s.QdtFilhos > 0) && (s.Pets.Count == 0)
                                         select s.Nome).ToList();


            foreach (var j in pessoaComFilhoSemPets)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine();
            Console.WriteLine("Pessoas que não possuem filhos mas possuem pets:");

            Console.WriteLine(" ");
            Console.WriteLine("Pessoas que possuem filhos e não possuem pets:");

            var pessoaSemFilhoComPets = (from s in ctx.Pessoas
                                         where (s.QdtFilhos == 0) && (s.Pets.Count > 0)
                                         select s.Nome).ToList();


            foreach (var j in pessoaSemFilhoComPets)
            {
                Console.WriteLine(j);
            }
        }
    }
}