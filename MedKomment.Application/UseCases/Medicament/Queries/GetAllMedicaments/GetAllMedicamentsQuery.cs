
using MediatR;
using System.Collections.Generic;

namespace MedKomment.Application.UseCases.Medicament.Queries.GetAllMedicaments
{
    public class GetAllMedicamentsQuery : IRequest<List<Domain.Entities.Medicament>>
    {
    }
}
