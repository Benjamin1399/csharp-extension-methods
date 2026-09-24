using System;

namespace ExtensionMethodsApp
{
    public static class PersonModelExtension
    {
        public static PersonModel SetDefaultAge(this PersonModel person, int age)
        {
            person.Age = age;
            return person;
        }

        public static void PrintInfo(this PersonModel person)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age}");
        }
    }
}
