using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [Serializable()]
    class ChatRoom
    {
        private string title;
        private string image;
        public static string topicSession = "Dance";
        private List<Client> clt;
        private List<ChatRoom> topicL;
        private Dictionary<ChatRoom, List<Client>> d;
        public int j = 0;
        public string[] tab = new string[2];

        public ChatRoom(string t, string i)
        {
            this.title = t;
            this.image = i;
            this.clt = new List<Client>();
            this.topicL = new List<ChatRoom>();
        }
        public ChatRoom(string t, string i, string p)
        {
            this.title = t;
            this.image = i;
        }
        public ChatRoom()
        {

            this.d = new Dictionary<ChatRoom, List<Client>>();

        }
        public string getTitle()
        {
            return title;
        }
        public void setTitle(string t)
        {
            this.title = t;
        }
        public string getImage()
        {
            return image;
        }
        public void setImage(string img)
        {
            this.image = img;
        }
        public void save(string s)
        {

            FileStream fileStream = new FileStream(s, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, d);
            fileStream.Close();
        }
        public void load(string s)
        {

            FileStream fileStream = new FileStream(s, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Dictionary<ChatRoom, List<Client>> content;
            content = (Dictionary<ChatRoom, List<Client>>)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
        }
        public void addTopic(ChatRoom t)
        {
            this.topicL.Add(t);
        }
    }
}
