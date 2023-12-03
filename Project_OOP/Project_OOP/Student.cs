using System;
using System.Collections.Generic;


namespace Project_OOP
{
    public class Student
    {
        public string Name { get; set; }
        public string ClassAndSection { get; set; }

        List<dynamic> students = new List<dynamic>();

        public void AddStudent()
        {
            Console.WriteLine("Enter the Student Name");
            Name = Console.ReadLine();
            students.Add(Name);
            Console.WriteLine("Enter the Student class and section");
            ClassAndSection = Console.ReadLine();
            students.Add(ClassAndSection);

        }
        public void Display()
        {

            Console.WriteLine("*** Student Details are as follows **");
            Console.WriteLine("Student Name:\t" + Name);
            Console.WriteLine("Student Class:\t" + ClassAndSection);


        }
    }
}
