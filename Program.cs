using System;
using System.Linq;
using Farneti.Michele._5H.PrimoEF.Models;

namespace Farneti.Michele._5H.PrimoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello db-World!");

            DbPersone db = new();
                
            foreach(Persona R in db.Persone)
            {
                Console.WriteLine(R);
            }

            var g = db.Persone.Max(Marco => Marco.PersonaID);
            Console.WriteLine(g);

            //Preleva il primo record
            var p = db.Persone.First();
            db.Persone.Remove(p);

            db.Persone.RemoveRange(db.Persone);

            db.Persone.Add(new Persona{Nome="Marco",Cognome="Violi", Email="marco.violi@libero.it"});
            db.SaveChanges();
        }
    }
}
