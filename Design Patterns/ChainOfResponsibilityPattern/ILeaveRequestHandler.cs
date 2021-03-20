using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public interface ILeaveRequestHandler
    {
        void HandleRequest(LeaveRequest request);
        ILeaveRequestHandler nextHandler { get; set; }
    }

}
