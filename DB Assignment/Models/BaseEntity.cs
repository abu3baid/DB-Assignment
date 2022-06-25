using System;

namespace DB_Assignment.Models
{
    public class BaseEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDelete { get; set; }
        public BaseEntity()
        {
            IsDelete = false;
            CreatedAt = DateTime.Now;
        }
    }
}
