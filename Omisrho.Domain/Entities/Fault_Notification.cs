using Omisrho.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omisrho.Domain.Entities
{
    public class Fault_Notification : AuditableEntity
    {
        public string PlazaName { get; set; } = String.Empty;
        public int LaneNumber { get; set; } 
        public string LaneDirection { get; set; } = String.Empty;
        public string EqiupmentType { get; set; } = String.Empty;
        public string Fault_Description { get; set; } = String.Empty;
        public string FaultCategory { get; set; } = String.Empty;
        public string LaneStatus { get; set; } = String.Empty;
        public string FaultStatusConfirmed { get; set; } = String.Empty;
    }
}
