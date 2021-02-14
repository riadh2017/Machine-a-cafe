using DataModel;
using System;
using System.Collections.Generic;

namespace Services
{
    public interface ImachineService
   {
        Utilisateurs GetUser(decimal badge);
        List<Produits> GetProduits();
        Choix_utilisateurs GetUserChoice(decimal badge);
        void PostDernierChoix(Choix_utilisateurs dernierChoix);
    }
}
