using TodoAssignment.Data;
using TodoAssignment.Models;
using Xunit;

namespace TodoAssignment.Tests.Models
{
    public class PersonTests
    {
        [Theory]
        [InlineData("  ")]
        [InlineData("")]
        [InlineData(null)]

        public void FirstName_BadValue(string badFirstName)
        {

            //Arrange
            Person testperson = new Person("sirisha", "Tadepalli", PersonSequencer.NextPersonId());

            //Act
            ArgumentException exception = Assert.Throws<ArgumentException>(() => testperson.FirstName = badFirstName);


            //Assert
            Assert.Contains("Firstname", exception.Message);


        }
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void LastNameBadValueTest(string badLastName)
        {
            //Arrange
            Person testPerson = new Person("parnika", "chandra", PersonSequencer.NextPersonId());

            //Act
            var exception = Assert.Throws<ArgumentException>(() => testPerson.LastName = badLastName);

            //Assert
            Assert.Contains("Lastname", exception.Message);
        }
        [Fact]
        public void PersonClassTest()
        {
            // Arrange
            string firstName1 = "Sally";
            string lastName1 = "Corey";
            string firstName2 = "Mona";
            string lastName2 = "Carlesson";


            // Act
            Person testPerson1 = new Person(firstName1, lastName1, PersonSequencer.NextPersonId());
            Person testPerson2 = new Person(firstName2, lastName2, PersonSequencer.NextPersonId());

            // Assert        
            Assert.Equal(firstName1, testPerson1.FirstName);
            Assert.Equal(lastName1, testPerson1.LastName);
            Assert.Equal(firstName2, testPerson2.FirstName);
            Assert.Equal(lastName2, testPerson2.LastName);


        }

    }
}