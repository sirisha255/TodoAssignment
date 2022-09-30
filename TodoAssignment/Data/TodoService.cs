using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAssignment.Models;

namespace TodoAssignment.Data
{
    public class TodoService
    {
        //An array 
        private static Todo[] todoArray = new Todo[0];

        public Todo[] TodoArray
        {
            get
            {
                return todoArray;
            }
            set
            {
                todoArray = value;
            }
        }

        public int Size()
        {
            return todoArray.Length;
        }

        public Todo[] FindAll()
        {
            return todoArray;
        }
        public Todo? FindById(int todoId)
        {
            for (int i = 0; i < todoArray.Length; i++)
            {
                if (todoArray[i].TodoId == todoId)
                {
                    return todoArray[i];
                }
            }
            return null;
        }

        public Todo CreateNewTodo(string description)
        {
            Todo newTodo = new Todo(description, TodoSequencer.NextTodoId());
            Array.Resize<Todo>(ref todoArray, todoArray.Length + 1);
            todoArray[todoArray.Length - 1] = newTodo;
            return newTodo;
        }


        public Todo[]? FindByDoneStatus(bool doneStatus)
        {
            if (doneStatus.Equals(doneStatus))
            {
                return todoArray;
            }
            else
            {
                return null;
            }
        }

        public Todo[] FindByAssignee(int personId)
        {
            for (int i = 0; i < todoArray.Length; i++) 
            {
                Todo todo = todoArray[personId];    
            }
            return todoArray;    
        }

        
        public Todo[] FindByAssignee(Person assignee)
        {
            for (int i = 0; i < todoArray.Length; i++)  
            {
                if (todoArray[i].Assignee == assignee)   
                {
                    return todoArray;   
                }
            }
            return todoArray;
        }

        public Todo[] FindUnassignedTodoItems()
        {
            for (int i = 0; i < todoArray.Length; i++)
            {
                
                if (todoArray[i].TodoId != todoArray.Length)
                {
                    return todoArray;
                }
            }
            return todoArray.ToArray();
        }

        public bool RemoveTodoId(int personId)
        {
            for (int i = 0; i < todoArray.Length; i++)    
            {
                if (todoArray[i].TodoId == personId)
                {
                    todoArray[i] = todoArray[todoArray.Length - 1];   
                    Array.Resize<Todo>(ref todoArray, todoArray.Length);
                    return true;
                }
            }
            return false;
        }
        public void Clear()
        {
            todoArray = new Todo[0];
        }
    }
}
