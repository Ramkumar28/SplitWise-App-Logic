using System;

namespace Expense_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ramkumar = new Person(){Name = "Ramkumar"};
            Person Kumar = new Person(){Name = "Kumar"};
            Person Jim = new Person(){Name = "Jim"};
            Person Cook = new Person(){Name = "Cook"};
            Expense<Person> CarExpense = new Expense<Person>(Ramkumar,1000,Kumar,Jim,Cook);
            ExpenseList _expenseList = new ExpenseList();
            _expenseList.Add(CarExpense);
            Expense<Person> DinnerExpense = new Expense<Person>(Jim,500,Cook,Kumar);
            Expense<Person> TripExpense = new Expense<Person>(Cook,6000,Kumar,Ramkumar);
            _expenseList.Add(DinnerExpense);
            _expenseList.Add(TripExpense);
            OweCalculator.CalculateOwing(_expenseList);
        //     foreach(var owe in Ramkumar.Owing.Keys)
        //     {
        //         Console.WriteLine("****");
        //         Console.WriteLine(owe.Name + "Owes Rs." +Ramkumar.Owing[owe] + "to" + Ramkumar.Name);
        //         Console.WriteLine("*****");
        //     }
        //     foreach(var owe in Cook.Owing.Keys)
        //     {
        //         Console.WriteLine("****");
        //         Console.WriteLine(owe.Name + "Owes Rs." +Cook.Owing[owe] + "to" + Cook.Name);
        //         Console.WriteLine("*****");
        //     }
        //     foreach(var owe in Jim.Owing.Keys)
        //     {
        //         Console.WriteLine("****");
        //         Console.WriteLine(owe.Name + "Owes Rs." +Jim.Owing[owe] + "to" + Jim.Name);
        //         Console.WriteLine("*****");
        //     }
        //     foreach(var owe in Kumar.Owing.Keys)
        //     {
        //         Console.WriteLine("****");
        //         Console.WriteLine(owe.Name + "Owes Rs." +Kumar.Owing[owe] + "to" + Kumar.Name);
        //         Console.WriteLine("*****");
        //     }
        // }
    }
}
