using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_1._06
{
    class ExpenseReport : IExpenseRequest
    {
        public double Total { get; private set; }

        public ExpenseReport(int total) { Total = total; }
    }
}
