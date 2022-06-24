using Omisrho.Application.Interfaces;
using Omisrho.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omisrho.Infrastrucutre.EntityFrameworkCore.Repositories
{
    public class FaultNotificationRepository : GenericRepositoryBase<Fault_Notification>, IFaultNotification
    {
        public FaultNotificationRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
