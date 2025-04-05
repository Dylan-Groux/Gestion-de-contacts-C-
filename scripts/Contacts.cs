using System;
using System.Drawing;
using System.Drawing.Text;

namespace MediaTekDocuments
{
    public class Contacts
    {
        //Variable
        private string firstname;
        private string lastname;
        private string email;
        private string phone;
        private string address;
        private Image photo;

        //Properties
        public string FirstName { get => firstname; set => firstname = value; }
        public string LastName { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public Image Photo { get => photo; set => photo = value; }

        //Constructors
        public Contacts()
        {

        }

        public Contacts(string firstname, string lastname, string email, string phone, string address, Image photo)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.Photo = photo;

        }


        public override string ToString()
        {
            return firstname + " " + lastname;
        }



    }
}
