using Lab_05.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05.BUS
{
    public class MajorService
    {
        public List<Major> GetAllByFaculty(int facultyID)
        {
            ModelStudentDB context = new ModelStudentDB();
            return context.Majors.Where(p => p.FacultyID == facultyID).ToList();
        }
    }
}
