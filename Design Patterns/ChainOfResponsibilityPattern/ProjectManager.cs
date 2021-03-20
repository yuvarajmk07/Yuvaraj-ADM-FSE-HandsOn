using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class ProjectManager : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { get; set; }

        public void HandleRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays >= 3 && leaveRequest.LeaveDays <= 5)
            {
                Console.WriteLine("{0}'s leave for {1} approved by Project Manager", leaveRequest.Employee, leaveRequest.LeaveDays);
            }
            else
            {
                Console.WriteLine("Project Manager : Redirected to HR for Approval");
                nextHandler.HandleRequest(leaveRequest);
            }
        }
    }



}
