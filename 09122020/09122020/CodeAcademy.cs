using System;
using System.Collections.Generic;
using System.Text;

namespace _09122020
{
    public class CodeAcademy
    {

    }

    public abstract class Human 
    {
        public string Gender { get; set; }
    }

    public class Person : Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }
    }

    public class Student : Person, ICredentials
    {
        public string Occupation { get; set; }
        public int Username { get; set; }
        public string Password { get; set; }
        public Classroom Room { get; set; }
        public Teacher Mellim { get; set; }
        public Modules ModuleName { get; set; }

        public string Login()
        {
            return "I have logged in";
        }

        public void Logout()
        {
            Console.WriteLine("I have logged out");
        }


        public Student(string name, string occu) : base(name)
        {
            this.Occupation = occu;
        }

        ~Student()
        {
            Console.WriteLine("I was destructed");
        }
    }

    public class StudentAccount : Student
    {
        public string Username { get; set; }

        public StudentAccount(string elovset1, string elovset2, string username) : base(elovset1, elovset2)
        {
            this.Username = username;
        }
    }

    public class Teacher : Person
    {

        public Teacher(string elovset) : base(elovset)
        { 
        
        }

    }

    public class Classroom
    {
        public string ClassroomName { get; set; }
        public int StudentCapacity { get; set; }
        public int Id { get; set; }
        public int Temprature { get; set; }
    }

    public interface ICredentials
    { 
        int Username { get; set; }
        string Password { get; set; }

        string Login();
        void Logout();
    }

}
