using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class HR : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { get; set; }

        public void HandleRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays > 5)
            {
                Console.WriteLine("{0}'s leave for {1} approved by HR", leaveRequest.Employee, leaveRequest.LeaveDays);
            }
            else
            {
                nextHandler.HandleRequest(leaveRequest);
            }
        }
    }
}
