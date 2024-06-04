using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Npgsql;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette1
{
    public class ApplicationData
    {
        
        public ApplicationData()
        {
            Magasin.Read();
            Caracteristique.Read();
            Categorie.Read();
            CommandeAchat.Read();
            Couleur.Read();
            DetailCommande.Read();
            DetailCaracteristique.Read();
            Fournisseur.Read();
            Fournit.Read();

        }
 
    }
}
