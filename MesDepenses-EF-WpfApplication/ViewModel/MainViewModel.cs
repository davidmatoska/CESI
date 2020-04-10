using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using MesDepenses_EF_WpfApplication.Model;

namespace MesDepenses_EF_WpfApplication.ViewModel
{
    class MainWindowViewModel
    {
        public ICollectionView Personnes { get; private set; }

        public MainWindowViewModel()
        {
            
            var MesDepensesManager = new MesDepensesManagerModel();
            DTO.Personne myPersonne = new DTO.Personne("Bobby","Jones");
            DTO.Depense depenseBobby = new DTO.Depense(20,"restaurant");
           // DTO.Piece chambreCyprien = new DTO.Piece("chambreCyprien7", 12);
            myPersonne.Depenses.Add(depenseBobby);
            //myHotel.Pieces.Add(chambreCyprien);

           MesDepensesManager.CreatePersonne(myPersonne);

           // DTO.Hotel myHotel2 = new DTO.Hotel("googleHotel7");
           // DTO.Piece chambreTimothe = new DTO.Piece("chambreTimothe7", 12);
           // myHotel2.Pieces.Add(chambreTimothe);

           // hotelManager.CreateHotel(myHotel2);

            List<DTO.Personne> listPersonnes = MesDepensesManager.DisplayAllPersonnes();

            Personnes = CollectionViewSource.GetDefaultView(listPersonnes);
        }
    }
}
