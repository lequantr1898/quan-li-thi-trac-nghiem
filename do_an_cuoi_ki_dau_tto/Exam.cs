using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_cuoi_ki_dau_tto
{
    internal class Exam
    {
        public string ID {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        private List<Answer> Answers { get; set; }
        private List<UserAnswer> userAnswers { get; set; }
        private List<Question> questions { get; set; }
        public int Check_Answer(List<Question> questions , List<UserAnswer> userAnswers , List<Answer> answers)
        {
            int Point = 0;
            if(questions.Count == 0) return 0;
            int Point_In_A_Question = 10/questions.Count;
            for(int i = 0; i<questions.Count; i++)
            {
                if (userAnswers[i].Name == answers[i].Name)
                {
                    Point += Point_In_A_Question;
                }
            }
            return Point;
        }
    }
}
