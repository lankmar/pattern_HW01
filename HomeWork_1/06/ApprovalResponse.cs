using System;

namespace HomeWork_1._06
{
    public class AnswerApproval 
    {
        public AnswerApproval nextApprovalResponse;

        public static AnswerApproval BeyondApprovalLimit { get; set; }
        public static AnswerApproval Approve { get; set; }

        internal static AnswerApproval Denied;

        public AnswerApproval(IExpenseRequest expense)
        { 
        
        } 
        public AnswerApproval()
        {
        }

         public AnswerApproval ApprovalExpense(IExpenseRequest expenseReport)
        {
            throw new NotImplementedException();
        }
    }

 
}