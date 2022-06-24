using Omisrho.Application.Contracts;
using Omisrho.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omisrho.Infrastrucutre.EntityFrameworkCore.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IFaultNotification> _faultNotification;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _faultNotification = new Lazy<IFaultNotification>(()=> new 
            FaultNotificationRepository(repositoryContext));
        }

        public IFaultNotification FaultNotification => _faultNotification.Value;

        public void Save() => _repositoryContext.SaveChanges();
    }
}
