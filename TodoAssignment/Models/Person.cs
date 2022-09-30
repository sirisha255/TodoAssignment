using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAssignment.Data;

namespace TodoAssignment.Models
{
    public class Person
    {
        private readonly int personId;
        private string? firstName;
        private string? lastName;

        public Person(string? firstName, string? lastName, int personId)
        {
            this.personId = personId;
            FirstName = firstName;
            LastName = lastName;
        }

        public int PersonId
        {
            get
            {
                return personId;
            }
        }
        public string? FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Firstname can´t be null or empty!");
                }
                else
                {
                    firstName = value;
                }
            }
        }
        public string? LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Lastname can´t be null or empty!");
                }
                else
                {
                    lastName = value;
                }
            }
        }

    }
}