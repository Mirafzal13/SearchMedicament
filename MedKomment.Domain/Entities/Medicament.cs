using System.ComponentModel.DataAnnotations;

namespace MedKomment.Domain.Entities
{
    public class Medicament
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Uses { get; set; }
        public string Warnings { get; set; }
        public string Establishment { get; set; }
    }
}
