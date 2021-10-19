using System;

namespace UDException
{
    //Working on User Defined Exception 
    class InvalidAgeException: Exception
    {
        public InvalidAgeException(string message) : base(message)
        {

        }
    }
    class Program
    {
        public static void Validate(int Age)
        {
            if (Age < 18)
            {
                throw new InvalidAgeException("Your Age is Not Valid");
            }

        }        
        static void Main(string[] args)
        {
            try
            {
                Validate(17);
            }
            catch(InvalidAgeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
