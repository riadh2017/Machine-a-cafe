using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Produits
    {
        [Key]
        public int Id { get; set; }
        public string Nom_Produit { get; set; }
        //public Choix_utilisateurs Dernier_choix { get; set; }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var p = obj as Produits;
            if (p == null)
                return false;
            if (Id == p.Id)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (Id).GetHashCode();
        }
    }
}
