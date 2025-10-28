using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_cuoi_ki_dau_tto
{
    internal class Subject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Subject() { }
        private List<Subject> _subjects = new List<Subject>();
        public Subject(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }
    }
}
