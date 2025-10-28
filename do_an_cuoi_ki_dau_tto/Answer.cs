using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_cuoi_ki_dau_tto
{
    internal class Answer
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        List<Answer> _answers = new List<Answer>();
        public void Add(Answer answer)
        {
            _answers.Add(answer);
        }
    }
}
