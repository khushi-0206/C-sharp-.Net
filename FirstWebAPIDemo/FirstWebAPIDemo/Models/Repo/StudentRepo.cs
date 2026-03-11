using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace FirstWebAPIDemo.Models.Repo
{
    public class StudentRepo : IRepos<Student>
    {
        public static List<Student> studList = null;
        public StudentRepo()
        {
            if (studList == null)
            {
                studList = new List<Student>()
                {
                    new Student(){RollNo=101,Name="Alok",City="Jalandhar",PhoneNum="123456789"},
                    new Student(){RollNo=102,Name="Riya",City="Ludhiana",PhoneNum="123456789"},
                    new Student(){RollNo=103,Name="Rajat",City="Phagwara",PhoneNum="123456789"}
                };
            }
            
        }
        public bool Add(Student obj)
        {
            bool flag = false;
            if (obj != null)
            {
                studList.Add(obj);
                flag = true;
            }
            return flag;
        }

        public bool Delete(int id)
        {
            bool flag = false;
            Student student = studList.Find(s => s.RollNo == id);
            if(student != null)
            {
                studList.Remove(student);
                flag = true;
            }
            return flag;
        }

        public Student Get(int id)
        {
            Student student = studList.Find(s => s.RollNo == id);
            if(student != null)
            {
                return student;
            }
            else
            {
                throw new Exception("Student Record Not Available.");
            }
        }

        public ICollection<Student> GetAll()
        {
            return studList;
        }

        public bool Update(int id, Student obj)
        {
            bool flag = false;
            Student student = studList.Find(s => s.RollNo == id);

            if (student != null && obj != null) 
            {
                student.Name = obj.Name;
                student.City = obj.City;
                student.PhoneNum = obj.PhoneNum;
                flag = true;
            }
            return flag;
        }
    }
}
