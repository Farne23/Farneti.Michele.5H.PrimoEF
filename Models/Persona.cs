using System.ComponentModel.DataAnnotations;

namespace Farneti.Michele._5H.PrimoEF.Models
{
    public class Persona
    {
        public int PersonaID{get;set;}
        public string Nome{get;set;}
        public string Cognome{get;set;}
        public string Email{get;set;}

        public override string ToString()
        {
            return ($"{PersonaID}\t{Nome}\t{Cognome}\t{Email}");
        }
    }
}