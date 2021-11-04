using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student list");
            Student student1 = new Student("Aram", 17, Teacher);
            Student student2 = new Student("Gohar", 18);
            Student student3 = new Student("Vahe", 16);
            Student student4 = new Student("Nora", 17);
            Student student5 = new Student("Edik", 16);
            Student student6 = new Student("Mari", 17);
            Student student7 = new Student("Nick", 18);
            Student student8 = new Student("Seda", 16);

            Console.WriteLine("Teacher list");
            Teacher teacher1 = new Teacher("Melkonyan", 50);
            Teacher teacher2 = new Teacher("Vardanyan", 45);
            Teacher teacher3 = new Teacher("Gasparyan", 30);


        }
        public class TeacherManager
        {
              
        }
        public class StudentManager
        {
            // divide students number to teacher number, if will be remainder, add it in last teacher list
            
            public int GetStudentMark(int maxAllowedLength)
            {
                maxAllowedLength = 100;
                int mark;
                Random rnd = new Random();
                mark = rnd.Next(100);

                return mark;
            }
            public void Print(string coment, int mark)
            {
                if (mark < 30)
                {
                    Console.WriteLine($"Your mark is {mark}, if you want to stay at uneiversity, please do well");
                }
                else if (mark >= 30 && mark < 80)
                {
                    Console.WriteLine($"Your mark is {mark}, it is good");
                }
                else
                {
                    Console.WriteLine($"Your mark is {mark}, it is perfectly well");
                }
            }
        }
    }
}
