using System.ComponentModel.DataAnnotations;

namespace OnlineVotingSystem.Models
{
    public class Election
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
