using AutoMapper;
using MediatR;
using MedKomment.Application.UseCases.Medicament.Commands.AddMedicament;
using MedKomment.Application.UseCases.Medicament.Queries.GetAllMedicaments;
using MedKomment.Data.Repositories;
using MedKomment.Domain.Entities;
using MedKomment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedKomment.Services
{
    public class MedicamentService : IMedicamentService
    {
        private readonly IMediator _mediator;
        protected readonly IMedicamentRepository _repository;
        protected readonly IMapper _mapper;
        public MedicamentService(IMedicamentRepository repository, IMapper mapper, IMediator mediator)
        {
            _mediator = mediator;
            _repository = repository;
            _mapper = mapper;
        }

        #region old methods
        public IEnumerable<MedicamentDTO> GetAll()
        {
            var medicaments = _repository.GetAll();
            return medicaments.Select(x => _mapper.Map<MedicamentDTO>(x));
        }

        public IEnumerable<MedicamentDTO> GetByIngredients(string ingredients)
        {
            var medicaments = _repository.GetByIngredients(ingredients);
            return medicaments.Select(x => _mapper.Map<MedicamentDTO>(x));
        }

        public IEnumerable<MedicamentDTO> GetByName(string name)
        {
            var medicaments = _repository.GetByName(name);
            return medicaments.Select(x => _mapper.Map<MedicamentDTO>(x));
        }

        #endregion


        #region new methods (using CQRS)
        public async Task<bool> AddNewMedicamentAsync(MedicamentDTO medicament)
        {
            var success = false;
            try
            {
                success = await _mediator.Send(new AddMedicamentCommand
                {
                    Medicament = _mapper.Map<Medicament>(medicament)
                });
            }
            catch(Exception ex)
            {
                success = false;
            }

            return success;
        }

        public async Task<List<MedicamentDTO>> GetAllMedicamentsAsync()
        {
            try
            {
                var medicaments = await _mediator.Send(new GetAllMedicamentsQuery());
                return medicaments.Select(x => _mapper.Map<MedicamentDTO>(x)).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion
    }
}
