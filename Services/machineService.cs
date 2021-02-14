using DataModel;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class machineService: ImachineService
    {
        public readonly MachineContext _machineContext;
        public machineService(MachineContext machineContext)
        {
            _machineContext = machineContext;
        }

        public List<Produits> GetProduits()
        {
           return _machineContext.Produits.ToList();
        }

        public Utilisateurs GetUser(decimal badge)
        {
            var result = _machineContext.Utilisateurs.Where(u => u.Num_Badge == badge);

            if (result != null)
            {
                return result.FirstOrDefault();
            }
            else
            {
                return null;
            }

        }

        public Choix_utilisateurs GetUserChoice(decimal badge)
        {

            var result = _machineContext.Choix_utilisateurs.Where(u => u.Num_Badge == badge);

            if (result != null)
            {
                return result.FirstOrDefault();
            }
            else
            {
                return null;
            }

        }

        public void PostDernierChoix(Choix_utilisateurs dernierChoix)
        {
            var result = _machineContext.Choix_utilisateurs.Where(u => u.Num_Badge == dernierChoix.Num_Badge);

            if (result != null)
            {
                _machineContext.Remove(result.FirstOrDefault());
                _machineContext.SaveChanges();
            }

            _machineContext.Add(dernierChoix);
            _machineContext.SaveChanges();

        }
    }
}
