using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.AspNet.SignalR.Hubs
{
    public class HubMethodResult
    {
        public HubMethodResult(object result, bool isError)
        {
            this.Result = result;
            this.IsError = isError;
        }


        public object Result
        {
            get;
            private set;
        }

        public bool IsError
        {
            get;
            private set;
        }
    }
}
