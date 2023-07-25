using MediatR;
using MedKomment.Application.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MedKomment.Application.UseCases.Medicament.Queries.GetAllMedicaments
{
    public class GetAllMedicamentsQueryHandler : IRequestHandler<GetAllMedicamentsQuery, List<Domain.Entities.Medicament>>
    {
        private readonly IApplicationDbContext _context;
        public GetAllMedicamentsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Domain.Entities.Medicament>> Handle(GetAllMedicamentsQuery request, CancellationToken cancellationToken)
        {
            return await _context.MedicamentsNew.ToListAsync();
        }
    }
}
