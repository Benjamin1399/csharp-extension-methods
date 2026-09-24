namespace ExtensionMethodsApp
{
    public static class PersonModelExtension
    {
        public static PersonModel SetDefaultAge(this PersonModel person)
        {
            person.Age = 18;
            return person;
        }

        public static string PrintInfo(this PersonModel person)
        {
            return $"{person.FirstName} {person.LastName} is {person.Age}";
        }
    }
}
