using System;
using System.Collections.Generic;

namespace Expense_Sample
{
    public class Expense<T> where T : Person
    {
        private T _spender;
        private List<T> _participantsList;
        private double _totalExpense;
        private double _eachShare;

        public T spender { get => _spender; set => _spender = value; }
        public List<T> Participants { get => _participantsList; set => _participantsList = value; }
        public double TotalExpense { get => _totalExpense; set => _totalExpense = value; }

        public double EachShare { get => _eachShare; set => _eachShare = value; }
        public Expense(T _Person, double _totalExpense, params T[] _participants)
        {
            _spender = _Person;
            TotalExpense = _totalExpense;
            if (Participants == null)
                Participants = new List<T>();
            foreach (var eachPerson in _participants)
            {
                Participants.Add(eachPerson);
            }
            CalculateEachShare();
        }

        public void CalculateEachShare()
        {
          EachShare = TotalExpense/(Participants.Count + 1);
        }

  }
}
