using DBAtsiskaitymas.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DBAtsiskaitymas.Functionalities
{
    
    public class DataProcedures
    {
        public static UniversityContext _context = new();

        public Department CreateDepartment(string departmentName)
        {
            var department = _context.Departments.FirstOrDefault(x => x.Name == departmentName);
            if (department == null)
            {
                _context.Departments.Add(new Department { Name = departmentName });
                _context.SaveChanges();
            }
            return department;
        }
        public Department CreateDepartmentWithLectures(string departmentName, List<Lecture> lectures)//adding new department and list of lectures if they dont exist in DB
        {
            var department = _context.Departments.FirstOrDefault(x => x.Name == departmentName);
            if (department == null)
            {
                _context.Departments.Add(new Department { Name = departmentName, Lectures = lectures });
                _context.SaveChanges();
            }
            return department;
        }
        
        public Student AddStudent(string name, string lastName, Department department, List<Lecture> lectures)
        {
            foreach (var lecture in lectures)
            {
                if (_context.Lectures.FirstOrDefault(x => x.Name == lecture.Name) == null)
                {
                    _context.Lectures.Add(new Lecture { Name = lecture.Name });
                    _context.SaveChanges();
                }

            }
            if (_context.Students.FirstOrDefault(x => x.Name == name && x.LastName == lastName) == null)
            {
                _context.Students.Add(new Student { Name = name, LastName = lastName, Department = department, Lectures = lectures });
                _context.SaveChanges();
            }
            return _context.Students.FirstOrDefault(x=>x.Name == name&& x.LastName == lastName);

        }
        public Lecture AddLecture(string name)
        {
            var lecture = _context.Lectures.FirstOrDefault(x => x.Name == name);
            if (lecture == null)
            {
                _context.Add(lecture = new Lecture { Name = name });
                _context.SaveChanges();
            }
            return _context.Lectures.FirstOrDefault(x => x.Name == name);
        }
        public Student TransferStudent(Student student, Department department, List<Lecture> lectures)
        {
            var studentToRemove = _context.Students.Where(x=>x.Name == student.Name).Include(x => x.Department).Include(x => x.Lectures).First();
            _context.Remove(studentToRemove);
            _context.SaveChanges();

            foreach (var lecture in lectures)
            {
                if (_context.Lectures.FirstOrDefault(x => x.Name == lecture.Name) == null)
                {
                    _context.Lectures.Add(new Lecture { Name = lecture.Name });
                    _context.SaveChanges();
                }

            }
            if (_context.Students.FirstOrDefault(x => x.Name == student.Name && x.LastName == student.LastName) == null)
            {
                _context.Students.Add(new Student { Name = student.Name, LastName = student.LastName, Department = department, Lectures = lectures });
                _context.SaveChanges();
            }
            return _context.Students.FirstOrDefault(x => x.Name == student.Name && x.LastName == student.LastName);


        }
    }
}
