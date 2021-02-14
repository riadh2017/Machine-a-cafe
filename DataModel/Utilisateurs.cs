using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Utilisateurs
    {
        [Key]
        public decimal Num_Badge { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        //public  Choix_utilisateurs Dernier_choix { get; set; }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var u = obj as Utilisateurs;
            if (u == null)
                return false;
            if (Num_Badge == u.Num_Badge )
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (Num_Badge).GetHashCode();
        }
    }
}
