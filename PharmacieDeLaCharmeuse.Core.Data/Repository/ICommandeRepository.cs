using PharmacieDeLaCharmeuse.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Repository
{
    public  interface ICommandeRepository
    {
        void CreateCommande(Commande commande);

        IEnumerable<Commande> GetAllCommandes();

        Commande GetComandeById(int id);
    }
}
