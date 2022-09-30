using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAssignment.Data;
using TodoAssignment.Models;
using Xunit;

namespace TodoAssignment.Tests.Models
{
    public class TodoTests
    {
        [Fact]
        public void TodoClassTest()
        {
            //Arrange
            string description1 = "Finish assignment";
            string description2 = "Go for walk";

            //Act
            Todo testTodo1 = new Todo(description1, TodoSequencer.NextTodoId());
            Todo testTodo2 = new Todo(description2, TodoSequencer.NextTodoId());

            //Assert

            Assert.Equal(description1, testTodo1.Description);
            Assert.Equal(description2, testTodo2.Description);


        }
    }
}
