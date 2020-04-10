using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MesDepenses_EF_WpfApplication.DTO;

namespace MesDepenses_EF_WpfApplication.DAL
{
    class MesDepensesContext:DbContext
    {
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Depense> Depenses { get; set; }

        public MesDepensesContext()
            : base("name=Mes_Depenses")
        {
        }
    }
}
