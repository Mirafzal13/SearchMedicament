using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedKomment.Data.Entities
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
