using System;

namespace Bai_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 40;
            p1.Name = "Amar";
            Console.WriteLine("Person deatails - Name = "+p1.Name+", Are = "+p1.Age);
            Console.WriteLine("Person deatails(After incrmenting age)- Name = "+p1.Name+",Age = "+(p1.Age+1));
        }
    }
}