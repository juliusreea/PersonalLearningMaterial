using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAtsiskaitymas
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string LastName { get; set; }
        public virtual List<Lecture> Lectures { get; set; }
        public Department Department { get; set; }

        public Student(string name, string lastName)
        {
            Id = new ();
            Name = name;
            LastName = lastName;
            Lectures = new List<Lecture>();
            Department = new Department();
        }
        public Student()
        {

        }
    }
}
