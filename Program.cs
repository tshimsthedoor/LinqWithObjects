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
                "Ida",
                "Shulamite",
                "Grace",
                "Megane"
            };
           // var query = names.Where(new Func<string, bool>(NameLongerThanFour));
           //var query = names.Where(NameLongerThanFour);
           var query = names.Where(name => name.Length > 4);
            foreach (string item in query)
            {
                WriteLine(item);
            }
        }

        static bool NameLongerThanFour(string name)
        {
            return name.Length > 4;
        }
        static void Main(string[] args)
        {
            WriteLine("Good people let call the list of name longer than 4 character");
            LinqWithArrayOfStrings();
        }
    }
}
