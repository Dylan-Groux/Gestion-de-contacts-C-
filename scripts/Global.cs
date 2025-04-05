using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments
{
    public static class Global
    {

        //Variables
        public static List<Groupes> suiviGroupes = new List<Groupes>()
        {
            new Groupes("Famille", "Famille"),
            new Groupes("Amis", "Amis"),
            new Groupes("Travail", "Travail"),
            new Groupes("Sport", "Sport"),

        };

    }
}
