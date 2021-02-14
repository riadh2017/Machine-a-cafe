using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Choix_utilisateurs
    {
        [Key]
        public decimal Num_Badge { get; set; }
        public int Id_Produit { get; set; }
        public int Qtte_Sucre { get; set; }
        public string  Mug { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var cu = obj as Choix_utilisateurs;
            if (cu == null)
                return false;
            if (Num_Badge == cu.Num_Badge && Id_Produit == cu.Id_Produit)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (Num_Badge + "|" + Id_Produit).GetHashCode();
        }
    }
}
