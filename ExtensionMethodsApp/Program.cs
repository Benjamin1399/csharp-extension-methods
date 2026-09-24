using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "Benjamin";
            person.LastName = "Naidoo";

            person.SetDefaultAge().PrintInfo();

            Console.ReadLine();
        }
    }
}
