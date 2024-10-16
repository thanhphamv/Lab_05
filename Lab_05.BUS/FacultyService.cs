using Lab_05.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05.BUS
{
    public class FacultyService
    {
        public List<Faculty> GetAll()
        {
            ModelStudentDB context = new ModelStudentDB();
            return context.Faculties.ToList();
        }
    }
}
