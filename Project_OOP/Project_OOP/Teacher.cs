using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    public class Teacher
    {
        public string Name { get; set; }
        public int ClassAndSection { get; set; }

        List<dynamic> teachers = new List<dynamic>();
        public void AddTeacher()
        {
            Console.WriteLine("Enter Teacher Name");
            Name = Console.ReadLine();
            teachers.Add(Name);
            Console.WriteLine("Enter Teacher Class");
            ClassAndSection = int.Parse(Console.ReadLine());
            teachers.Add(ClassAndSection);

        }
        public void Display()
        {
            Console.WriteLine("** Teacher Details are as follows **");
            Console.WriteLine("Teacher Name:\t" + Name);
            Console.WriteLine("Teacher Class:\t" + ClassAndSection);

        }
    }
}
   

