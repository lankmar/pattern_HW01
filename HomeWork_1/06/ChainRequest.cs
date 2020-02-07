using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_1._06
{
    class ChainRequest : IRequest
    {
        private ChainRequest() { }
        private static readonly ChainRequest _instance = new ChainRequest();

        public static ChainRequest Instance => _instance;

        public AnswerApproval Approve(IExpenseRequest expenseReport) => AnswerApproval.Denied;

        public void RegisterNext(IRequest next)
        {
            throw new NotImplementedException();
        }
    }
}
