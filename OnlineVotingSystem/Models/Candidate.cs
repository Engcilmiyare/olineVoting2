using System.ComponentModel.DataAnnotations;

namespace OnlineVotingSystem.Models
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(15)]
        public string Tell { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Title { get; set; }
    }
}
