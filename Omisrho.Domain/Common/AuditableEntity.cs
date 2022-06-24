using Omisrho.Application.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omisrho.Domain.Common
{
    public abstract class AuditableEntity : IAuditableEntity, ISoftDelete
    {
        [Key]
        public int Id { get; set; }
        public Guid CreatedBy { get ; set ; }
        public DateTime CreatedOn { get; set ; }
        public Guid LastModifiedBy { get ; set ; }
        public DateTime? LastModifiedOn { get ; set ; }
        public DateTime? DeletedOn { get ; set ; }
        public bool IsDeleted { get ; set ; }
        public Guid? DeletedBy { get ; set ; }

        ////protected AuditableEntity() 
        ////{
        ////    CreatedOn = DateTime.Now;
        ////    LastModifiedOn = DateTime.Now;
        ////}
    }

    
}
