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
        public int Score1;
        [Required]
        public int Score2;
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Location;
        public int Winner {  get; set; }
        public int Draw {  get; set; }
    }
}
