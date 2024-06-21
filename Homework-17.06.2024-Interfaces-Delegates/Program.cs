using System.Collections;

namespace Homework_17._06._2024_Interfaces_Delegates
{
    //class GroupEnumerator : IEnumerator
    //{
    //    public List<Student> students;
    //    public int position = -1;

    //    public GroupEnumerator(List<Student> students)
    //    {
    //        this.students = students;
    //    }

    //    object IEnumerator.Current
    //    {
    //        get
    //        {
    //            return students[position];
    //        }
    //    }

    //    public bool MoveNext()
    //    {
    //        position++;
    //        return position < students.Count;
    //    }

    //    public void Reset()
    //    {
    //        position = -1;
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AddTestsRatings(12);
            student.AddCourseWorksRatings(12);
            student.AddExamsRatings(12);

            Student student1 = new("Evgeniya", "Sadova", new DateOnly(2001, 01, 01));
            student1.AddTestsRatings(11);
            student1.AddCourseWorksRatings(12);
            student1.AddExamsRatings(12);

            Student student2 = new("Irina", "Strat", new DateOnly(2002, 02, 02));
            student2.AddTestsRatings(10);
            student2.AddCourseWorksRatings(12);
            student2.AddExamsRatings(12);

            Student student3 = new("Liliya", "Khachatryan", new DateOnly(2003, 03, 03));
            student3.AddTestsRatings(9);
            student3.AddCourseWorksRatings(12);
            student3.AddExamsRatings(12);

            Student student4 = new("Artem", "Karp", new DateOnly(2004, 04, 04));
            student4.AddTestsRatings(8);
            student4.AddCourseWorksRatings(12);
            student4.AddExamsRatings(12);

            Student student5 = new("Alexandr", "Martinov", new DateOnly(2005, 05, 05));
            student5.AddTestsRatings(7);
            student5.AddCourseWorksRatings(12);
            student5.AddExamsRatings(12);

            Student student6 = new("Vitaly", "Ogorodnikov", new DateOnly(2006, 06, 06));
            student6.AddTestsRatings(2);
            student6.AddCourseWorksRatings(2);
            student6.AddExamsRatings(2);

            Student student7 = new("Maxim", "Fedorov-Marushchak", new DateOnly(1988, 10, 30));
            student7.AddTestsRatings(6);
            student7.AddCourseWorksRatings(12);
            student7.AddExamsRatings(12);

            Group group = new Group();
            group.AddStudent(student);
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);
            group.AddStudent(student5);
            group.AddStudent(student6);
            group.AddStudent(student7);

            foreach (Student stud in group)
            {
                Console.Write("{0, -40}", "Student: " + stud.Name + " " + stud.LastName);
                Console.WriteLine("{0, 10}","Average Ratings: " + stud.AverageRatings());
            }
            Console.WriteLine();
            
        }
    }
}
