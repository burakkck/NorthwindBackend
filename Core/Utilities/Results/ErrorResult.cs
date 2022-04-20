using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(success:true)
        {
        }

        public ErrorResult(string message) : base(success:true, message)
        {
        }
    }
}
