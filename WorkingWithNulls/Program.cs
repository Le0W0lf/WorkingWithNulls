using System;

namespace WorkingWithNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]
            {
                new Person(){Name = "Sarah"},
                new Person(),
                null
            };
            //int b = (int)person.Lvl;
            //Person[] person=null;
            var t1 = person?[0]?.Name;
            var t2 = person?[1]?.Name;
            var t3 = person?[2]?.Name;
            var t4 = person[0]?.Name;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            //Console.WriteLine(person.B.GetValueOrDefault());
        }
    }
}
