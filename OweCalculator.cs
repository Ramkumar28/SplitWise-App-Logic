using System;
using System.Collections.Generic;

namespace Expense_Sample
{
    public static class OweCalculator
    {
     public static void CalculateOwing(ExpenseList _ExpenseList)
     {
       foreach(var expense in _ExpenseList)
       {
          if(expense.spender !=null)
          {
             foreach(var participant in expense.Participants)
             {
                 var total = expense.EachShare;
                  CheckOneToOneRealtion(participant,expense.spender,expense.EachShare);
                 if(expense.spender.Owing.ContainsKey(participant))
                 {
                     expense.spender.Owing[participant] += total;
                 }
                 else
                 {
                     expense.spender.Owing.Add(participant, total);
                 }
             }
          }
       }
     }

     public static void CheckOneToOneRealtion(Person participant,Person spender,double eachShare)
     {
        if(participant.Owing.ContainsKey(spender))
        {
           participant.Owing[spender] -= eachShare;
        }
        else
        {
        participant.Owing.Add(spender,-eachShare);
        }
         
     }
    }
}