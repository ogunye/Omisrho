using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omisrho.Application.Contracts
{
    public interface ISoftDelete
    {
        DateTime? DeletedOn { get; set; }
        bool IsDeleted { get; set; }
        Guid? DeletedBy { get; set; }
    }
}
