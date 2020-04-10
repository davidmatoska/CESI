using MesDepenses_EF_WpfApplication.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesDepenses_EF_WpfApplication.DTO
{
    public class Personne
    {
        public int PersonneID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual List<Depense> Depenses { get; set; }

        public Personne()
        {
            Depenses = new List<Depense>();
        }

        public Personne(string nom , string prenom)
        {
            Nom = nom;
            Prenom = prenom;
            Depenses = new List<Depense>();
        }
    }
}
