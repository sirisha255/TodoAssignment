using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAssignment.Models;
using Xunit;

namespace TodoAssignment.Tests.Data
{
    public class People
    {
        [Fact]
        public void CreateNewPersonTests()
        {

            People testingPeople = new People();
            testingPeople.Clear();
            string firstName1 = "Johanna";
            string lastName1 = "Ljungberg";
            string firstName2 = "Mona-Lisa";
            string lastName2 = "Harddrive";


            //Act
            Person testPerson1 = testingPeople.CreateNewPerson(firstName1, lastName1);
            Person testPerson2 = testingPeople.CreateNewPerson(firstName2, lastName2);

            //Assert
            Assert.Equal(firstName1, testPerson1.FirstName);
            Assert.Equal(lastName1, testPerson1.LastName);

            Assert.Equal(firstName2, testPerson2.FirstName);
            Assert.Equal(lastName2, testPerson2.LastName);

        }


        [Fact]
        public void FindPersonByIdTest()
        {
            //Arrange
            People testingPeople = new People();
            Person testPerson1 = testingPeople.CreateNewPerson("Janne", "Lindberg");
            Person testPerson2 = testingPeople.CreateNewPerson("Anna", "Salin");
            Person testPerson3 = testingPeople.CreateNewPerson("Jonas", "Schmidth");
            int checkedPersonId = testPerson2.PersonId;

            //Act
            Person matchedPerson = testingPeople.FindById(checkedPersonId);

            //Assert
            Assert.NotEqual(matchedPerson, testPerson1);
            Assert.Equal(matchedPerson, testPerson2);
            Assert.NotEqual(matchedPerson, testPerson3);
        }

        private Person FindById(int checkedPersonId)
        {
            throw new NotImplementedException();
        }

        private Person CreateNewPerson(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void SizePersonTest()
        {
            //Assert
            People testingPeople = new People();
            testingPeople.CreateNewPerson("Johanna", "Ljung");
            testingPeople.CreateNewPerson("Mona-Lisa", "Larsson");

            int expectedSize = 2;

            //Act
            int actualSize = testingPeople.Size();

            //Assert
            Assert.Equal(expectedSize, actualSize);
        }

        private int Size()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void FindAllPeopleTest()
        {
            //Arrange            
            People testingPeople = new People();
            testingPeople.Clear();

            testingPeople.CreateNewPerson("Janne", "Lindberg");
            testingPeople.CreateNewPerson("Anna", "Salin");
            testingPeople.CreateNewPerson("Jonas", "Schmidth");
            int expectedSize = 3;
            //Act
            Person[] foundPersons = (Person[])testingPeople.FindAll();

            //Assert
            Assert.Equal(expectedSize, foundPersons.Length);
        }

        private void Clear()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void RemovePersonTest()
        {
            //Arrange
            People testingPeople = new People();

            Person testPerson1 = testingPeople.CreateNewPerson("Maja", "Ljung");
            Person testPerson2 = testingPeople.CreateNewPerson("Ludwig", "Hallberg");
            Person testPerson3 = testingPeople.CreateNewPerson("Anna", "Larsson");


            //Act
            testingPeople.RemovePerson(testPerson2.PersonId);

            //Assert
            Assert.Contains(testPerson1, testingPeople.FindAll());
            Assert.DoesNotContain(testPerson2, testingPeople.FindAll());
            Assert.Contains(testPerson3, testingPeople.FindAll());
        }

        private IEnumerable<Person> FindAll()
        {
            throw new NotImplementedException();
        }

        private void RemovePerson(int personId)
        {
            throw new NotImplementedException();
        }
    }
}
