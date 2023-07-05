using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookBorrowing.API.DTO
{
    public class ClientDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClient { get; set; }

        [Required]
        [StringLength(150)]
        public string ClientName { get; set; }

        [Required]
        [MinLength(14)]
        public string ClientCpf { get; set; }

        [Required]
        [StringLength(100)]
        public string Adress { get; set; }

        [Required]
        [StringLength(25)]
        public string City { get; set; }

        [Required]
        [StringLength(14)]
        public string CellNumber { get; set; }
    }
}
