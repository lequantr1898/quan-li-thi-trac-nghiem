using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_cuoi_ki_dau_tto
{
    internal class QuestionBank
    {
        public List<Question> questions {  get; set; }
        public List<Answer> answers { get; set; }
        public void Add(Question question)
        {
            questions.Add(question);
        }
        public void Clear()
        {
            questions.Clear();
        }
        public Exam GetExam(int id,string name,string decription , string type)
        {
            return new Exam();
        }
    }
}
