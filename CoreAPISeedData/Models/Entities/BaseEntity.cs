using CoreAPISeedData.Models.Enums;

namespace CoreAPISeedData.Models.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }

        public int ID { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifedDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public DataStatus Status { get; set; }
    }
}

