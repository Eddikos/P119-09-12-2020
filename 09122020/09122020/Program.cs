using Microsoft.AspNetCore.Http;
using System;
using System.Net;

namespace _09122020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Teacher eldar = new Teacher("Eldar");
            eldar.Surname = "Alasgarov";

            Classroom neptun = new Classroom();
            neptun.StudentCapacity = 16;
            neptun.ClassroomName = "Neptun";
            neptun.Temprature = 24;
            neptun.Id = 7;

            Student stu = new Student("Mesut", "Telebe");
            stu.Name = "Sadiq";
            stu.Room = neptun;
            stu.Mellim = eldar;
            stu.ModuleName = Modules.CSharp;

            Console.WriteLine(stu.Room.Id);
            Console.WriteLine(stu.Mellim.Name);
            Console.WriteLine(stu.ModuleName == Modules.Introduction);
            Console.WriteLine((int)stu.ModuleName);
            Console.WriteLine(stu.ModuleName.ToString() == "CSharp");

            

            StudentAccount sa = new StudentAccount("", "", "");


            // Helper help = new Helper();
            var cem = Helper.Sum(4, 5);
            var yeni = Helper.AddPrefix("Elovset");

            var yuvarlaq = Math.Ceiling(5.4);




            String.Compare("Baki", "Baku");

            //string pcName = "DEll Latitude";
            //string.Contains("e");





            //gun.Reload();
        }
    }
}
