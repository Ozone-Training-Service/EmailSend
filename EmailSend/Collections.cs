using EmailSend.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailSend
{
    public class Collections
    {


       public void Show()
        {
            List<string> nameList = new List<string>();
            nameList.Add("Vishnu");
            nameList.Add("Aji");
            nameList.Add("Vishnu");
            nameList.Add("Aji");
            nameList.Add("Vishnu");
            nameList.Add("Aji");
            nameList.Add("Vishnu");
            nameList.Add("Aji");


            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }


            List<Student> studentList = new List<Student>();

            Student s1 = new Student();
            s1.Id = 3;
            s1.Name = "Akshay";
            s1.M1 = 100;
            s1.M2 = 50;

            Student s2 = new Student();
            s2.Id = 2;
            s2.Name = "Vishnu kumar";
            s2.M1 = 1;
            s2.M2 = 5;



            Student s3 = new Student() { Id = 4, M2 = 100, M1 = 99, Name = "Vishnu pc" };

            Student s4 = new Student { Id = 5, M2 = 100, M1 = 99, Name = "Aji" };





            studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);
            studentList.Add(s4);

            Console.WriteLine("Students Details");
            
            foreach (var item in studentList)
            {
                Console.WriteLine("Name=  "+item.Name);
                Console.WriteLine("Id   ="+item.Id);
                Console.WriteLine("M1=  "+item.M1);
                Console.WriteLine("M2   ="+item.M2);
              
                Console.WriteLine(item);
            }


        }
    }
}
