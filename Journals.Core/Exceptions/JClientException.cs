using System;
using System.Collections.Generic;
using System.Text;

namespace Journals.Core.Exceptions
{
    public class JClientException : Exception
    {
        public int FaultCode { get; private set; }
        public string FaultString { get; private set; }

        public JClientException(int FaultCode, string FaultString)
            : base()
        {
            this.FaultCode = FaultCode;
            this.FaultString = FaultString;
        }
    }
}
