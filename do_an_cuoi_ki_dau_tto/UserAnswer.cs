using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_cuoi_ki_dau_tto
{
    internal class UserAnswer
    {
        public string ID { get; set; }
        public string Name { get; set; }
        List<UserAnswer> Answers;
        public void Add(UserAnswer answer)
        {
            Answers.Add(answer);
        }
    }
}
