using Lab05.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.BUS
{
    public class StudentService
    {
        public List<Student> GetAll()
        {
            StudentContextB contetx = new StudentContextB();
            return contetx.Students.ToList();
        }
        public List<Student> GetAllHasNoMajor() 
        {
            StudentContextB context = new StudentContextB();
            return context.Students.Where(p=>p.MajorID == null).ToList();
        }
        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            StudentContextB contextB = new StudentContextB();
            return contextB.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }
        public Student FindById(string studentID)
        {
            StudentContextB context = new StudentContextB();
            return context.Students.FirstOrDefault(p => p.StudentID == studentID);
        }
        public void InsertUpdate(Student s)
        {
            StudentContextB context = new StudentContextB();
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }


    }
}
