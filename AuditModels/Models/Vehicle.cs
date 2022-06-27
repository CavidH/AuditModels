using System.ComponentModel.DataAnnotations;

namespace AuditModels.Models
{
    public class Vehicle : IAuditable
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        [StringLength(100)]
        public string Color { get; set; }

        [StringLength(100)]
        public string Model { get; set; }

        [StringLength(100)]
        public string Owner { get; set; }
    }

}
