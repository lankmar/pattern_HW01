namespace HomeWork_1._06
{
    public class Employee : IExpenseConfirmatoin
    {
        public string Name { get; private set; }
        private double _approvalLimit;

        public Employee(string name, double approvalLimit)
        {
            Name = name;
            _approvalLimit = approvalLimit;
        }

        public AnswerApproval Expense(IExpenseRequest expenseReport)
        {
            if (expenseReport.Total > _approvalLimit)
            {
                return AnswerApproval.BeyondApprovalLimit;
            }
            return   AnswerApproval.Approve;
        }
    }
}