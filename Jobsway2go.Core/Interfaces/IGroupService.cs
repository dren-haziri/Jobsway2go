using Jobsway2go.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Interfaces
{
    public interface IGroupService : IRepository<Group>
    {
        void Delete(int Id);
    }
}
