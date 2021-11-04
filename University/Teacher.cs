using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Teacher
    {
        public Teacher(string lastName, int age)
        {
            _id = Guid.NewGuid();
            _lastName = lastName;
            _age = age;
        }

        public string _lastName;
        public int _age;
        public Guid _id;
        public Student[] _student;
    }
}
