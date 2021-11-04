using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Student
    {
        public Student(string name, int age, Teacher teacher)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
            _teacher = teacher;
        }

        public string _name;
        public int _age;
        public Guid _id;
        public Teacher _teacher;

    }
}
