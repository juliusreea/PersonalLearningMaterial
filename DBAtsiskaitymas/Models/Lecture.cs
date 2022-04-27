using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAtsiskaitymas
{
    public class Lecture
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public virtual List<Student> Students { get; set; } 
        public virtual List<Department> Departments { get; set; } 

        public Lecture(string name)
        {
            Id = new();
            Name = name;
        }
        public Lecture()
        {

        }
    }
}
