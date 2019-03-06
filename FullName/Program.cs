using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Ask the user for their first name and then their last name.
            // TODO: Call a method called FullName that returns their full name.
            // TODO: Output their full name.

            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            // FullName(firstName, lastName);
             FullName(firstName, lastName);
            //Console.Write(String.Format("{0} {1}", firstName, lastName));
            Console.ReadLine();
        }

        //public static string FullName(string fName, string lName)
        public static string FullName(string fName, string lName)
        {
           Console.WriteLine(fName + " " + lName);
           return String.Concat(fName, lName);
        }
        


            // TODO: Create a method call FullName that takes the firstName and lastName as parameters.
        

        
    }
}
