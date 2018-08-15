using System;

namespace names
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your first name!");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name!");
            string lastname = Console.ReadLine();

            string fullnames = Combine(firstname, lastname);

            Console.WriteLine(fullnames);

        }
        private static string combine(string firstname, string lastname);


    
        
   {
         string fullnames = string firstname + string lastname;
          return fullnames;
    }

        
    

