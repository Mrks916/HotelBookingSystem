using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transaction.Api.src.Dto.Request
{
    public class ResetPasswordRequest
    {
        public string UserName { get; set; }
		public string FirstQuestionAns { get; set; }
		public string SecondQuestionAns { get; set; }
    }
}