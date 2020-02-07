namespace HomeWork_1._06
{
    public class Request : IRequest
    {
        private readonly IExpenseConfirmatoin approver;
        private IRequest next;

        public Request(IExpenseConfirmatoin expenseApprover)
        {
            approver = expenseApprover;
            next = ChainRequest.Instance;
        }
        
        public AnswerApproval Approve(IExpenseRequest expenseReport)
        {
            AnswerApproval response = approver.Expense(expenseReport);
            if (response == AnswerApproval.BeyondApprovalLimit)
            {
                return next.Approve(expenseReport);
            }
            return response;
        }

        public void RegisterNext(IRequest next)
        {
            this.next = next;
        }
    }
}