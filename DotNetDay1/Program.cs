using System;
using System.Linq;
using System.Collections.Generic;
//namespace DotNetDay1
//{

//    public class Student()
//    {
//        public string name { get; set; } = null;
//        public int age { get; set; }

//    }
//    public class Program()
//    {
//        static void Main(string[] args)
//        {
//            List<Student> students = new List<Student>()
//            {
//                new Student {name="madan",age=24},
//                new Student {name="Hari",age=23},
//                new Student {name="Badri",age=24},
//                new Student {name="madan",age=24},
//            };
//            foreach(var i in students)
//            {
//                Console.WriteLine(i.name);
//                Console.WriteLine(i.age);
//            }
//        }
//    }
//}

//Properties 
//public class Student()
//{
//    public int Id { get; set; }
//    public string Name { get; set; } = null;
//    public int Age { get; set; }

//    public void ShowDetails()
//    {
//        Console.WriteLine($"ID :- {Id} ");
//        Console.WriteLine($"Hello my name is :- {Name} ");
//        Console.WriteLine($"My age is :- {Age} ");
//    }
//}
//public class Program()
//{
//    public static void Main()
//    {
//        Student std = new Student();
//        std.Id = 1;
//        std.Name = "Madan";
//        std.Age = 24;
//        std.ShowDetails();
//    }

//}

public class Program()
{
    public string name;
    public string name2;
    public void Show()
    {
        //var compare=name.CompareTo(name2); //if match return 0 else return 1
        //var compare = name.Equals(name2);//if matched return True else return False 
        //var compare = name.Contains("M");//if M value is exist in name then it will return true else false
        //var compare = name.GetTypeCode();//it will return the types of name, in this case it return the String
        //var compare=name.GetHashCode();//it will return the hash code name  
        //var compare=name.EndsWith("n");//it return true if name endswith n ,in this case it will return True because Madan endswith n
        //var compare = name.IndexOf("n");//it will return the current index of n,in this case index of n in Madan is 4
        //var compare = name.Insert(5, "Khadka");//it will add khadka of index 5 of madan  
        //var compare = name.Length;//it will return length  of index 5 ,in this case i will return 5 because length of Madan is 5
        //var compare = name.Replace("an","hu");//it will remove the an from Madan and add hu output will be Madhu
        //var compare=name.Split(" ");
        //foreach (var word in compare)
        //{
        //    Console.WriteLine(word);
        //}
        //var compare=name.Substring(0, name.Length-1);//it will return the value of name less then length-1 from end,in this case it return mada
        //var compare=name.Substring(1, name.Length-1);//it will return the value of name less then length-1 from start,in this case it return adan
        //var compare=name.ToUpper();// it will capatalize the value of name, in this case it will return the MADAN 
        //var compare=name.ToLower();//it will convert value of name in lowercase ,in this case it eill return madan
        var compare = name.Clone();//it will Clone the value of name in compare variable
        Console.WriteLine(compare);
        Console.WriteLine(name);
        Console.WriteLine(name2);
    }

    public static void Main()
    {
        Program p = new Program();
        p.name = "Madan";
        p.name2 = "Madan";
        p.Show();
    }
}


