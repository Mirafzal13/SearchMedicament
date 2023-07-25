using AutoMapper;
using MedKomment.Application.UseCases.Medicament.Commands.AddMedicament;
using MedKomment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedKomment.Models
{
    public class MappingProfiler : Profile
    {
        public MappingProfiler()
        {
            CreateMap<Medicament, MedicamentDTO>();
            CreateMap<MedicamentDTO, Medicament>();
            CreateMap<MedicamentDTO, Domain.Entities.Medicament>();
            CreateMap<Domain.Entities.Medicament, MedicamentDTO>();
        }
    }
}
