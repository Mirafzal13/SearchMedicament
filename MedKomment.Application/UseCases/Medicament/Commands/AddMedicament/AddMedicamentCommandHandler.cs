using MediatR;
using MedKomment.Application.Abstractions;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MedKomment.Application.UseCases.Medicament.Commands.AddMedicament
{
    public class AddMedicamentCommandHandler : IRequestHandler<AddMedicamentCommand, bool>
    {
        private readonly IApplicationDbContext _context;
        public AddMedicamentCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(AddMedicamentCommand request, CancellationToken cancellationToken)
        {
            //var entity = new Domain.Entities.Medicament()
            //{
            //    Name = request.Medicament.Name,
            //    Ingredients = request.Medicament.Ingredients,
            //    Uses = request.Medicament.Uses,
            //    Warnings = request.Medicament.Warnings,
            //    Establishment = request.Medicament.Establishment
            //};

            await _context.MedicamentsNew.AddAsync(request.Medicament, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
