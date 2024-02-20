using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackEnd.Models.DataModels
{
    // Esta clase nos permitira establecer aquellos requisitos o campos que todas nuestras tablas queramos que tengan
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        //public int UserId { get; set; }
        //public virtual User CreatedBy { get; set; } = new User();
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        //public User UpateBy { get; set; } = new User();
        public string UpdateBy { get; set; } = string.Empty;
        public DateTime? UpdateAt { get; set; }
        //public User DeleteBy { get; set; } = new User();
        public string DeleteBy { get; set; } = string.Empty;
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
