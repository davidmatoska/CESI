using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MesDepenses_EF_WpfApplication.DTO
{

    
    public class Depense
    {
        
        public int DepenseID { get; set; }
       
        public int Montant { get; set; }
        public string Type_Depense { get; set; }

        

        public Depense(int montant, string type_depense )
        {
            Montant = montant;
            Type_Depense = type_depense;
            
        }
    }
}
