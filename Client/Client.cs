using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    //save the state of a client object and recreate it if necessary
    [Serializable()]
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
        //this function saves the list of users in a file
        public void save(string s)
        {
            FileStream fileStream = new FileStream(s, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, lst);
            fileStream.Close();
        }
        //this function retrieves the list of users from a file
        public void load(string s, Client c)
        {
            
            FileStream fileStream = new FileStream(s, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<Client> content;
            content = (List<Client>)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            foreach (Client client in content)
            {
                lst.Add(client);
            }
            lst.Add(c);
        }

    }
}
