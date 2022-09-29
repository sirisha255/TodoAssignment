using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAssignment.Models;

namespace TodoAssignment.Data
{
        public class PeopleService
    { 
        private static Person[] personArray = new Person[0];

    public Person[] PersonArray
    {
        get
        {
            return personArray;
        }
        set
        {
            personArray = value;
        }
    }

    public int Size()
    {
        return personArray.Length;
    }

    
    public Person[] FindAll()
    {
        return personArray;
    }

    public Person? FindById(int personId)
    {
        for (int i = 0; i < personArray.Length; i++)
        {
            if (personArray[i].PersonId == personId)
            {
                return personArray[i];
            }
        }
        return null;
    }


    public Person CreateNewPerson(string firstName, string lastName)
    {
        
        Person newPerson = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
        Array.Resize<Person>(ref personArray, personArray.Length + 1);
        personArray[personArray.Length - 1] = newPerson;
        return newPerson;
    }

    public bool RemovePersonId(int personId)
    {
        for (int i = 0; i < personArray.Length; i++)    
        {
            if (personArray[i].PersonId == personId) 
            {
                personArray[i] = personArray[personArray.Length - 1];    
                Array.Resize<Person>(ref personArray, personArray.Length - 1);
                return true;
            }
        }
        return false;
    }

    public void Clear()
    {
        personArray = new Person[0];
    }
}
}
