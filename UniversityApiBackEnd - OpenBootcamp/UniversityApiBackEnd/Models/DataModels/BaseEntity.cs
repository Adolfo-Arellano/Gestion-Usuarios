using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackEnd.Models.DataModels
{
    // Esta clase nos permitira establecer aquellos requisitos o campos que todas nuestras tablas queramos que tengan
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UpateBy { get; set; } = string.Empty;
        public DateTime? UpdateAt { get; set; }
        public string DeleteBy { get; set; } = string.Empty;
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
