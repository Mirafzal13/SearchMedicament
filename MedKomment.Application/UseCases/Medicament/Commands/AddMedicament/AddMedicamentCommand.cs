using MediatR;

namespace MedKomment.Application.UseCases.Medicament.Commands.AddMedicament
{
    public class AddMedicamentCommand : IRequest<bool>
    {
        public Domain.Entities.Medicament Medicament { get; set; }
    }
}
