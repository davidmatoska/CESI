using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesDepenses_EF_WpfApplication.DAL;

namespace MesDepenses_EF_WpfApplication.Model
{
    class MesDepensesManagerModel
    {
        //public MesDepensesContext MesDepensesContext;

        public MesDepensesManagerModel()
        {
            //MesDepensesContext = new MesDepensesContext();   
        }

        // opérations CRUD...
        public void CreatePersonne(DTO.Personne Personne)
        {
            using (MesDepensesContext context = new MesDepensesContext())
            {
                try
                {
                    context.Personnes.Add(Personne);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<DTO.Personne> DisplayAllPersonnes()
        {
            using (MesDepensesContext context = new MesDepensesContext())
            {
                try
                {
                    // Display all Hotels from the database 
                    
                    var query = from personne in context.Personnes
                                orderby personne.Nom
                                select personne;
                    List<DTO.Personne> l = query.ToList<DTO.Personne>();
                    return l;
                }
                catch
                {
                    throw;
                }
            }
        }

        public void DeletePersonne(DTO.Personne Personne)
        {
            using (MesDepensesContext context = new MesDepensesContext())

                try
                {
                    context.Personnes.Attach(Personne);
                    context.Personnes.Remove(Personne);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }

        }

        public void UpdatePersonne(DTO.Personne Personne, DTO.Personne PersonneUpdated)
        {
            using (MesDepensesContext context = new MesDepensesContext())

                try
                {

                    if (Personne != null && PersonneUpdated != null)
                    {
                        PersonneUpdated.PersonneID = Personne.PersonneID;
                        context.Entry(Personne).CurrentValues.SetValues(Personne);
                    }




                }
                catch
                {
                    throw;
                }
        }



        public void CreateDepense(DTO.Depense Depense)
        {
            using (MesDepensesContext context = new MesDepensesContext())
            {
                try
                {
                    context.Depenses.Add(Depense);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public void DeleteDepense(DTO.Depense Depense)
        {
            using (MesDepensesContext context = new MesDepensesContext())

                    try
                {
                    context.Depenses.Attach(Depense);
                    context.Depenses.Remove(Depense);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }

        }

        public void UpdateDepense(DTO.Depense Depense , DTO.Depense DepenseUpdated)
        {
            using (MesDepensesContext context = new MesDepensesContext())

                try
            {

                    if (Depense != null && DepenseUpdated != null) 
                    {
                        DepenseUpdated.DepenseID = Depense.DepenseID;
                        context.Entry(Depense).CurrentValues.SetValues(Depense);
                    } 




            }
            catch
            {
                throw;
            }
        }



        public List<DTO.Depense> DisplayAllDepenses()
        {
            using (MesDepensesContext context = new MesDepensesContext())
            {
                try
                {
                    // Display all Hotels from the database 

                    var query = from depense in context.Depenses
                                orderby depense.Montant descending
                                select depense;
                    List<DTO.Depense> l = query.ToList<DTO.Depense>();
                    return l;
                }
                catch
                {
                    throw;
                }
            }
        }

       


    }
}
