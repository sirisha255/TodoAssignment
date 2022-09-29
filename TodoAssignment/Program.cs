using TodoAssignment.Data;
using TodoAssignment.Models;

namespace TodoAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //Create a instance of the class
                Person person = new Person(0, "Rosita", "Axelsson");
                //Prints the person
                Console.WriteLine(person.PersonId + " " + person.FirstName + " " + person.LastName);
                PersonSequencer personSequencer = new PersonSequencer();
                PeopleService peopleService = new PeopleService();

                //Console.WriteLine(peopleService.CreateNewPerson());
            }
        }
    }
}