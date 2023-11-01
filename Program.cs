using System.Net.Http.Headers;

namespace SchoolRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int numberInput;
            string firstNameInput;
            string lastNameInput;
            string roleInput;
            string subjectInput;
            string courseInput;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Tryck 1 för att lägga till en lärare. \nTryck 2 för att lägga till en elev. \nTryck 3 för att skriva ut. \nTryck 0 för att avsluta.");
                int.TryParse(Console.ReadLine(), out int userInput);
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Förnamn: ");
                        firstNameInput = Console.ReadLine();
                        Console.WriteLine("Efternamn: ");
                        lastNameInput = Console.ReadLine();
                        Console.WriteLine("Kön?: ");
                        roleInput = Console.ReadLine();
                        Console.WriteLine("Personnummer: ");
                        int.TryParse(Console.ReadLine(), out numberInput);
                        Console.WriteLine("Ämne: ");
                        subjectInput = Console.ReadLine();

                        people.Add(new Teacher(subjectInput, firstNameInput, lastNameInput, roleInput, numberInput));
                        break;

                    case 2:
                        Console.WriteLine("Förnamn: ");
                        firstNameInput = Console.ReadLine();
                        Console.WriteLine("Efternamn: ");
                        lastNameInput = Console.ReadLine();
                        Console.WriteLine("Kön?: ");
                        roleInput = Console.ReadLine();
                        Console.WriteLine("Personnummer: ");
                        int.TryParse(Console.ReadLine(), out numberInput);
                        Console.WriteLine("Klass: ");
                        courseInput = Console.ReadLine();

                        people.Add(new Student(courseInput, firstNameInput, lastNameInput, roleInput, numberInput));
                        break;

                    case 3:
                        foreach (var person in people)
                        {
                            person.PrintInfo();
                        }
                        Console.ReadKey();
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}