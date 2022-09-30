using TodoAssignment.Data;
using TodoAssignment.Models;

namespace TodoAssignment.Tests
{
    public class PeopleTests
    {
        [Theory]
        [InlineData("  ")]
        [InlineData("")]
        [InlineData(null)]

        public void FirstName_BadValue(string badFirstName)
        {

            //Arrange
            Person testperson = new Person("sirisha","Tadepalli",PersonSequencer.NextPersonId());

            //Act
            ArgumentException exception = Assert.Throws<ArgumentException>(() => testperson.FirstName = badFirstName);


            //Assert
            Assert.Contains("Firstname", exception.Message);


        }
        
    }
}