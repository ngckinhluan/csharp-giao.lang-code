using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV7.Entities
{
    internal class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }


        public Student()
        {

        }

        public Student(string id, string name, int yob, double gpa)
        {
            Id = id;
            Name = name;
            Yob = yob;
            Gpa = gpa;
        }
        // ToString for me pls
        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name} | Yob: {Yob} | Gpa: {Gpa}";
        }
        public void ShowProfile()
        {
            Console.WriteLine(ToString());
        }
    }
}
