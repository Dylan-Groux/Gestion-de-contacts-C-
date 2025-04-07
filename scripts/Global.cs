using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContact
{
    public static class Global
    {

        //Variables
        public static MainWindows mainWindows;

        //Liste des groupes de contacts de l'utilisateur
        public static List<Groupes> suiviGroupes = new List<Groupes>()
        {
            new Groupes("Famille", "Famille"),
            new Groupes("Amis", "Amis"),
            new Groupes("Travail", "Travail"),
            new Groupes("Sport", "Sport"),

        };

        public static void AddGroupes(Groupes groupesToAdd)
        {
            suiviGroupes.Add(groupesToAdd);
            SaveManager.SaveData(suiviGroupes);

            mainWindows.LoadGroups();
        }

        public static void RemoveGroupes(Groupes groupesToRemove)
        {
            suiviGroupes.Remove(groupesToRemove);
            SaveManager.SaveData(suiviGroupes);

            mainWindows.LoadGroups();
        }
    }
}
