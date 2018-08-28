using System;
using System.Collections.Generic;

namespace Expense_Sample
{
    public class Person
    {
        public Person()
        {
            Owing = new Dictionary<Person, double>();
        }
        private string _name;
        private Dictionary<Person, double> _owing;

        public string Name { get => _name; set => _name = value; }

        public Dictionary<Person, double> Owing { get => _owing; set => _owing = value; } 

        
    }
}