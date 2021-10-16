using System;
using Farneti.Michele._5H.PrimoEF.Models;

namespace Farneti.Michele._5H.PrimoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello db-World!");

            DbPersone db = new();
            
            for(int i = 0; i <100; i++)
            {
                db.Persone.Add(new Persona{nome="Marco",cognome="Violi"});
                db.SaveChanges();
            }

        }
    }
}
