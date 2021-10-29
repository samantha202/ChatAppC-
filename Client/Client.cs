using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Client
    {
        private string firstname;
        private string lastname;
        private string email;
        private string password;
        private List<Client> lst;//users list

        public Client(string f, string l, string e, string pass)
        {
            this.lst = new List<Client>();
            this.firstname = f;
            this.lastname = l;
            this.email = e;
            this.password = pass;
        }
        public Client()
        {
        }

        public string getFirstName()
        {
            return firstname;
        }
        public string getLastName()
        {
            return lastname;
        }

        public string getEmail()
        {
            return email;
        }

        public string getPass()
        {
            return password;
        }
    }
}
