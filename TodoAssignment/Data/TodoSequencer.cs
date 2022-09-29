using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAssignment.Models;


namespace TodoAssignment.Data
{
    public class TodoSequencer
    {

        public static int todoId;

        public static int NextTodoId()
        {
            return todoId++;
        }

        public static void Reset()
        {
            todoId = 0;
        }
    }
}
