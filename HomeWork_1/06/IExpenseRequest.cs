namespace HomeWork_1._06
{
    public interface IExpenseRequest
    {
        public double Total { get; }
    }

    public interface IExpenseConfirmatoin
    {
        AnswerApproval Expense(IExpenseRequest expenseReport);
    }

    public interface IRequest
    {
        AnswerApproval Approve(IExpenseRequest expenseReport);
        void RegisterNext(IRequest next);
    }
}