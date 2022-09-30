using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAssignment.Data;
using Xunit;

namespace TodoAssignment.Tests.Data
{
    public class TodoSequencerTests
    {
        [Fact]
        public void ResetTodoIdTest()
        {
            //Arrange
            int expected = 0;
            TodoSequencer.todoId = 4;

            //Act
            TodoSequencer.Reset();


            //Assert
            Assert.Equal(expected, TodoSequencer.todoId);

        }

        [Fact]

        public void NextTodoIdTest()
        {

            //Arrange
            int expectedId1 = 1;
            int expectedId2 = 0;
            int id1;
            int id2;

            //Act
            id1 = TodoSequencer.NextTodoId();
            id2 = TodoSequencer.NextTodoId();


            //Assert
            Assert.Equal(expectedId1, id1);
            Assert.Equal(expectedId2, id2);
        }

    }
}
