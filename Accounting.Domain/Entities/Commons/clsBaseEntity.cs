using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities.Commons
{
    public abstract class clsBaseEntity<TKey>
    {
        [Key]
        public TKey ID { get; set; }
        public DateTime InserDateTime { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public DateTime? RemoveDateTime { get; set; }
    }

    public abstract class clsBaseEntity : clsBaseEntity<Guid>
    {
        public clsBaseEntity()
        {
            ID=Guid.NewGuid();
        }
    }
}