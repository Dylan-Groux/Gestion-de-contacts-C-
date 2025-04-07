using System;
using System.Collections.Generic;


namespace MyContact
{
    [Serializable]
    public class Groupes
    {
        //Variables 
        private string name;
        private string description;
        private List<Contacts> contactsList;

        //Properties
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public List<Contacts> Contacts { get => contactsList; set => contactsList = value; }

        //Constructor
        public Groupes() 
        {
            this.Name = "Undefined";
            this.Description = "Undefined";
            this.contactsList = new List<Contacts>();

        }

        public Groupes(string groupName, string groupDescription)
        {
            this.Name = groupName;
            this.Description = groupDescription;
            this.contactsList = new List<Contacts>();

        }

        public Groupes(string groupName, string groupDescription, List<Contacts> contactsList)
        {
            this.Name = groupName;
            this.Description = groupDescription;
            this.contactsList =contactsList;

        }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
