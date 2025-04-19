

namespace Demo.DataAccess.Models
{
    public class Base_Entity
    {
        public int Id { get; set; } //Pk
        public int CreatedBy { get; set; } //User Id
        public DateTime CreatedOn { get; set; } //Current  Time
        public int LastModefiedBy { get; set; } //User Id
        public DateTime LastModifiedOn { get; set; } //Time of update
        public bool IsDeleted { get; set; } //flag for deel with database

    }
}
