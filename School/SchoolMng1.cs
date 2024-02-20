using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class SchoolMng1
    {
        static List<Students> students = new List<Students>()
        {
            new Students() {RollNumber = 1,FirstName="sai",LastName="pavan",DOB=new DateTime(day:01,month:02,year:2001)},
             new Students() {RollNumber = 2,FirstName="Paul",LastName="kiran",DOB=new DateTime(day:01,month:02,year:1999)},
              new Students() {RollNumber = 3,FirstName="kumar",LastName="chennuri",DOB=new DateTime(day:01,month:02,year:2000)}
        };
        static List<Teachers> teacherslist = new List<Teachers>()
        {
            new Teachers() {Tid=1,TeacherName="Paul"},
            new Teachers(){Tid=2,TeacherName="Kiran"},
            new Teachers(){Tid=3,TeacherName="Kumar"}
        };
        static List<Subjects> subjectslist = new List<Subjects>()
        {
            new Subjects(){SubjectId=1,SubjectName="Maths"},
            new Subjects(){SubjectId=2,SubjectName="Social"},
            new Subjects(){SubjectId=3,SubjectName="English"}
        };
        public static List<Students> AllStudents()
        {
            return students;
        }
        public static List<Students> StudentById(int id)
        {
            List<Students> stu = students.FindAll(e => e.RollNumber == id);
            return stu;
        }
        public static List<Teachers> AllTeachers()
        {
            return teacherslist;
        }
        public static List<Subjects> AllSubjects() { return subjectslist; }
    }
}
