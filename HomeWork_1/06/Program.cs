using System;
using System.Collections.Generic;
//1. Используя шаблон «Цепочка обязанностей», реализовать следующую задачу: 
//сотрудник компании желает получить одобрение на получение некоторой суммы денег.
//Для получения одобрения сотрудник обращается к непосредственному руководителю.
//Руководитель не имеет полномочий одобрить выделение такой суммы денег (может одобрить меньшую сумму) и 
//обращается к своему руководителю(директору компании). 
//Директор компании может одобрить или отклонить запрос и отправить ответ сотруднику.

namespace HomeWork_1._06
{
    class Programm
    {
        static void Main(string[] args)
        {
            Request max = new Request(new Employee("Макс, сотрудник", 0));
            Request anna = new Request(new Employee("Анна, менеджер", 1000));
            Request leo = new Request(new Employee("Лев, начальник отдела", 5000));
            Request serg = new Request(new Employee("Сергей, директор", 10000));

            max.RegisterNext(anna);
            anna.RegisterNext(leo);
            leo.RegisterNext(serg);

            if (Int32.TryParse(Console.ReadLine(), out int expenseReportAmount))
            {
                IExpenseRequest expense = new ExpenseReport(expenseReportAmount);
                AnswerApproval response = max.Approve(expense);
                Console.WriteLine( $"Запрос  {response}" );
            }
            Console.ReadLine();
        }
    }
}
