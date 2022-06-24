using Omisrho.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omisrho.Application.Contracts
{
    public interface IRepositoryManager
    {
        IFaultNotification FaultNotification { get; }
        void Save();
    }
}
