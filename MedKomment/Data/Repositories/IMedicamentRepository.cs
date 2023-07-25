using MedKomment.Data.Entities;
using System;
using System.Collections.Generic;

namespace MedKomment.Data.Repositories
{
    public interface IMedicamentRepository
    {
        List<Medicament> GetAll();
        List<Medicament> GetByName(string name);
        List<Medicament> GetByIngredients(string ingredients);
    }
}
