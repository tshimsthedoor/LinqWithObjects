using System;
using System.Linq;
using static System.Console;

namespace LinqWithObjects
{
    class Program
    {

        static void LinqWithArrayOfStrings()
        {
            var names = new string[]
            {
                "Michael",
                "Pam",
                "Jim",
                "Dwight",
                "Angela",
                "Pengani",
                "Ida",
                "Shulamite",
                "Grace",
                "Megane"
            };
            // var query = names.Where(new Func<string, bool>(NameLongerThanFour));
            //var query = names.Where(NameLongerThanFour);
            var query = names.Where(name => name.Length > 4)
                             .OrderBy(name => name.Length)
                             .ThenBy(name => name);
            foreach (string item in query)
            {
                WriteLine(item);
            }
        }

        static void LinqWithArrayOfExceptions()
        {
            var errors = new Exception[]
            {
                new ArgumentException(),
                new SystemException(),
                new IndexOutOfRangeException(),
                new InvalidCastException(),
                new NullReferenceException(),
                new InvalidCastException(),
                new OverflowException(),
                new DivideByZeroException(),
                new ApplicationException()
            };

            var numberErrors = errors.OfType<ArithmeticException>();
            foreach (var error in numberErrors)
            {
                WriteLine(error);
            }

        }

        static bool NameLongerThanFour(string name)
        {
            return name.Length > 4;
        }
        static void Main(string[] args)
        {
            WriteLine("Good people let call the list of name longer than 4 character");
            //LinqWithArrayOfStrings();
            LinqWithArrayOfExceptions();
        }
    }
}
