using Project.Entity.Enum;
using Project.Entity.Interface;
using System;

namespace Project.Entity.Base
{
    public class BaseEntity : IEntity<Guid>
    {
        public BaseEntity()
        {
            IsActive = true;
            Status = Status.Inserted;
            CreatedDate = DateTime.Now;
        }
        public int Id { get ; set ; }
        public Guid MasterId { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public string CreatedComputerName { get ; set ; }
        public string CreatedIpAddress { get ; set ; }
        public DateTime UpdatedDate { get ; set ; }
        public string UpdatedComputerName { get ; set ; }
        public string UpdatedIpAddress { get ; set ; }
        public bool IsActive { get ; set ; }
        public Status Status { get; set; }
    }
}
