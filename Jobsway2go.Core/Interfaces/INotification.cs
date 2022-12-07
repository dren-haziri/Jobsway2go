using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Interfaces
{
    public interface INotification /*:IRepository<Notification>*/
    {
        public void SendNotification();
        public void ShowNotification();
        public void NotificationList();
    }
}
