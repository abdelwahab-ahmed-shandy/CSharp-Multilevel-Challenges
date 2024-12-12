/*

Problem_4 >> Write a program to ask the user to enter his/her Age and Driver license 
Then print "Hired" if his/her age is grater than 21 and s/he has a driver license, otherwise print "Rejected"
 */

namespace PracticalExample
{
    internal class Program
    {
        public class InfoPerson
        {
            public InfoPerson(string name = "Null", int age = 0, bool driverLicense = false)
            {
                Name = name;
                Age = age;
                DriverLicense = driverLicense;
            }

            public string Name { get; set; }
            public int Age { get; set; }
            public bool DriverLicense { get; set; }
        }
        public static InfoPerson ReadInfoPerson()
        {
            InfoPerson person = new InfoPerson();
            Console.WriteLine("Write a program to ask the user to enter his/her Age and Driver license Then print Hired if his/her age is grater than 21 and s/he has a driver license, otherwise print Rejected");
            Console.Write("Enter Your Name : ");
            person.Name = Console.ReadLine();

            Console.Write("How Old Are You : ");
            person.Age = int.Parse(Console.ReadLine());

            Console.Write("Do you have a driving license (Yes Enter true , No enter false) : ");
            person.DriverLicense = bool.Parse(Console.ReadLine());

            return person;
        }

        public static bool ChackInfoPerson(InfoPerson person)
        {
            if (person.Age > 21 && person.DriverLicense)
                return true;
            return false;
        }

        public static void PrintAccepetORNot(InfoPerson person)
        {
            if (ChackInfoPerson(person))
                Console.WriteLine("\nHello , Hired");
            else
                Console.WriteLine("\nSorry , Rejected");
        }

        static void Main(string[] args)
        {
            PrintAccepetORNot(ReadInfoPerson());
        }
    }
}