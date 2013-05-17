using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.AspNet.SignalR.Hubs
{
    public class HubMethodResult
    {
        public HubMethodResult(object value, bool isError)
        {
            this.Value = value;
            this.IsError = isError;
        }


        public object Value
        {
            get;
            private set;
        }

        public bool IsError
        {
            get;
            private set;
        }


        public static HubMethodResult Error(object error)
        {
            return new HubMethodResult(error, true);
        }

        public static HubMethodResult Result(object result)
        {
            return new HubMethodResult(result, false);
        }
    }
}
