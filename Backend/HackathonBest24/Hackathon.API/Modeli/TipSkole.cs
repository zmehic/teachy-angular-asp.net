using System.ComponentModel.DataAnnotations;

namespace Hackathon.API.Modeli
{
    public class TipSkole
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; } //1 osnovna, 2 srednja
    }
}
