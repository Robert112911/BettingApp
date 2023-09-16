using System.ComponentModel.DataAnnotations;

namespace BettingApp.Models
{
    public class Match
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name1 { get; set; }
        [Required]
        public string Name2 { get; set; }
        [Required]
        public decimal Cota1 { get; set; }
        public decimal? CotaX { get; set; }
        [Required]
        public decimal Cota2 { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        public string Sport { get; set; }
        public int? Score1 { get; set; } = null;
        public int? Score2 { get; set; } = null;
        public int? Winner { get; set; } = null;
        public int? Draw { get; set; } = null;
    }
}
