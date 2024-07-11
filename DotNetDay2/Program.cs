namespace DotNetDay2
{
    //Constructor !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //public class Day2
    //{
    //    public  Day2()
    //    {
    //        Console.WriteLine("Hello my name is madan");
    //    }
    //}
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Day2 day2 = new Day2();
    //    }
    //}



    //Inheritance !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //public class Person()
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }=string.Empty;
    //}
    //public class Student : Person
    //{
    //    public int Roll { get; set; }
    //}

    //public class Program
    //{
    //    public static void Main()
    //    {
    //        Student S = new();
    //        S.Id= 1;
    //        S.Name = "Madan";
    //        S.Roll = 14;
    //        Console.WriteLine(S.Id);
    //        Console.WriteLine(S.Name);
    //        Console.WriteLine(S.Roll);
    //    }
    //}

    //inheritance 2!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //public class Person()
    //{
    //    public int num1 { get; set; }
    //    public int num2 { get; set; }
    //    //public int num1 = 24;
    //    //public int num2 = 35;
    //}
    //public class Student : Person
    //{
    //   public void Show() 
    //   { 
    //        decimal sum=num1 + num2;
    //        Console.WriteLine(sum);
    //   }
    //}

    //public class Program
    //{
    //    public static void Main()
    //    {
    //        Student S = new();
    //        S.num1 = 5;
    //        S.num2 = 10;
    //        S.Show();
    //    }
    //}

    //Interface !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    public  interface  Person
    {
        public static int num3 = 5;
        public void Sum();
        public void Multiply();
        public void Divide(int a,int b);
        public void Subtract();
    }
    public class Student : Person
    {
        private int num1 = 10;
        private int num2 = 20;
        public void Sum()
        {
            int add = num1 + num2+Person.num3;
            Console.WriteLine($"Addition is :-{add}");
        }
        public void Multiply()
        {
            Console.WriteLine($"Multiplication is :- {num1 * num2}");
        }
        public void Divide(int a, int b)
        {
            num1 = a;
            num2 = b;
            Console.WriteLine($"Divide is:- {num1/num2}");
        }
        public void Subtract()
        {
            Console.WriteLine($"Subtraction is :- {num2 - num1}");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Student S = new Student();
            Person.num3 = 20;
            S.Sum();
            S.Multiply();
            S.Divide(100,10);
        }
    }
}
