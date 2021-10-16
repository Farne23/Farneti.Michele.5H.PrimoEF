using System;
using Microsoft.EntityFrameworkCore;

namespace Farneti.Michele._5H.PrimoEF.Models
{
    public class DbPersone : DbContext
    {
        public DbSet<Persona> Persone {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder opzioni)
        {
            opzioni.UseSqlite("Data Source=database.db");
        }     
        
    }
}