using Lab_05.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05.BUS
{
    public class StudentService
    {
        public List<Student> GetAll()
        {
            ModelStudentDB context = new ModelStudentDB();
            return context.Students.ToList();
        }
        public List<Student> GetAllHasNoMajor()
        {
            ModelStudentDB context = new ModelStudentDB();
            return context.Students.Where(p => p.MajorID == null).ToList();
        }
        public List<Student> GetAllHasNoMinor(int facultyID)
        {
            ModelStudentDB context = new ModelStudentDB();
            return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }
        public Student FintById(String studentID)
        {
            ModelStudentDB context = new ModelStudentDB();
            return context.Students.FirstOrDefault(p => p.StudentID == studentID);
        }
        public void InsertUpdate(Student s)
        {
            ModelStudentDB context = new ModelStudentDB();
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }

        public void Delete(string mssv)
        {
            throw new NotImplementedException();
        }
    }
}
