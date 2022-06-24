using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Omisrho.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omisrho.Infrastrucutre.EntityFrameworkCore.Configuration
{
    public class FaultConfiguration : IEntityTypeConfiguration<Fault_Notification>
    {
        public void Configure(EntityTypeBuilder<Fault_Notification> builder)
        {
            builder.HasData
            (
                new Fault_Notification
                {
                    Id = 1,
                    PlazaName = "Admiralty Plaza",
                    LaneNumber = 7,
                    LaneDirection = "EB",
                    EqiupmentType = "Boom Barrier",
                    Fault_Description = "Boom Barrier not opening for user after classification and validation and traffic turn Green.",
                    FaultCategory = "Critical Error",
                    LaneStatus = "Lane Closed",
                    FaultStatusConfirmed = "Fault Status Pending.",
                    CreatedBy = new Guid(Guid.NewGuid().ToString()),
                    
                },
                new Fault_Notification
                {
                    Id = 2,
                    PlazaName = "Admiralty Plaza",
                    LaneNumber = 10,
                    LaneDirection = "EB",
                    EqiupmentType = "Traffic Ligth Green",
                    Fault_Description = "Traffic Light Greeen",
                    FaultCategory = "Major Error",
                    LaneStatus = "Lane Closed",
                    FaultStatusConfirmed = "Fault Status Pending.",
                    CreatedBy = new Guid(Guid.NewGuid().ToString())
                }
            );
        }
    }
}
