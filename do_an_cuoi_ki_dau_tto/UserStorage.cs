using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace do_an_cuoi_ki_dau_tto
{
    internal class UserStorage
    {
        public static void SaveToFile(List<User> users, string filepath)
        {
            using(FileStream fs = new FileStream(filepath,FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 
                bf.Serialize(fs, users);
#pragma warning restore SYSLIB0011
            }
        }
        public static List<User> LoadFromFile(string filepath)
        {
            if(!File.Exists(filepath))
            {
                return new List<User> ();
            }
            using (FileStream fs = new FileStream(filepath, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011
                return (List<User>)bf.Deserialize(fs);
#pragma warning disable SYSLIB0011
            }
        }
    }
}
