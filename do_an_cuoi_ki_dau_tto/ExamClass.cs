using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_cuoi_ki_dau_tto
{
    internal class ExamClass
    {
        public string ID { get; set; }
        public int numUser { get; set; }
        List<User> users = new List<User>();
        public void Add(User user)
        {
            users.Add(user);
        }
    }
}
