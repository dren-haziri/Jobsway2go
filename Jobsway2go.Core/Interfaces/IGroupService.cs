using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Interfaces
{
    public interface IGroupService
    {
        void JoinGroup();
        void LeaveGroup();
        void Approve();
        void Reject();
        void Ban();
        void Unban();

    }
}
