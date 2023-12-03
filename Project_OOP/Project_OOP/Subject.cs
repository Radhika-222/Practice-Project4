using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    public class Subject
    {
        public string Name { get; set; }
        public int SubjectCode { get; set; }
        public string Teacher { get; set; }
        List<dynamic> subjects { get; set; }

        public void AddSubject()
        {
            Console.WriteLine("Enter the Subject Name");
            subjects = new List<dynamic>();
            Name = Console.ReadLine();
            subjects.Add(Name);
            Console.WriteLine("Enter the Subject Code");
            SubjectCode = int.Parse(Console.ReadLine());
            subjects.Add(SubjectCode);
            Console.WriteLine("Enter the Teacher for the Subject");
            Teacher = Console.ReadLine();
            subjects.Add(Teacher);
        }
        public void Display()
        {
            Console.WriteLine("Subject Name:\t" + Name);
            Console.WriteLine("Subject code:\t" + SubjectCode);
            Console.WriteLine("Subject Teacher:\t" + Teacher);

        }
    }
}

  

