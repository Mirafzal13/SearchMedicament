using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedKomment.Models
{
    public class MedicamentDTO
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Uses { get; set; }
        public string Warnings { get; set; }
        public string Establishment { get; set; }
    }
}
