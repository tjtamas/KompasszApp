using KompasszApp.Models;
using KompasszApp.Repositories;
using KompasszApp.Interfaces;
using KompasszApp.Services;
using KompasszApp.Infrastructure;

using LiteDB;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = DatabaseFactory.Create();
            IRepository<Technology> techRepo = new LiteDbRepository<Technology>(db);
            var seeder = new TechnologySeeder(techRepo);


            seeder.Seed();
            seeder.PrintAll();


            Console.WriteLine("\nNyomj Entert a kilépéshez...");
            Console.ReadLine();

        }
    }
}
