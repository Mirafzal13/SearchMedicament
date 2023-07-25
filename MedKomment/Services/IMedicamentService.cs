using MedKomment.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedKomment.Services
{
    public interface IMedicamentService
    {
        IEnumerable<MedicamentDTO> GetAll();
        IEnumerable<MedicamentDTO> GetByName(string name);
        IEnumerable<MedicamentDTO> GetByIngredients(string ingredients);
        Task<bool> AddNewMedicamentAsync(MedicamentDTO medicament);
        Task<List<MedicamentDTO>> GetAllMedicamentsAsync();
    }
}
