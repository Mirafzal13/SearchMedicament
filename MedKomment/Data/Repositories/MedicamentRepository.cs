using MedKomment.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MedKomment.Data.Repositories
{
    public class MedicamentRepository : IMedicamentRepository
    {
        private readonly AppDbContext _context;
        public MedicamentRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Medicament> GetAll()
        {
            var allMedicaments = _context.Medicaments.ToList();
            return allMedicaments;
        }

        public List<Medicament> GetByIngredients(string ingredients)
        {
            var medicamentsByIngredients = _context.Medicaments.Where(p => EF.Functions.Like(p.Ingredients, "%" + ingredients + "%")).ToList();
            return medicamentsByIngredients;
        }

        public List<Medicament> GetByName(string name)
        {
            var medicaments = _context.Medicaments.Where(p => EF.Functions.Like(p.Name, "%" + name + "%")).ToList();
            return medicaments;
        }
    }
}
