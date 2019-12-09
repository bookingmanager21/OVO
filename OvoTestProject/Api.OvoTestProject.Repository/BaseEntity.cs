using System;

namespace Api.OvoTestProject.Repository
{
    public class BaseEntity
    {
        public bool IsDeleted { get; set; } = false;
        public int Index { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
