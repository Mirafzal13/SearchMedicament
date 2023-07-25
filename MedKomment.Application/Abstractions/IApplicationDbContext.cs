using MedKomment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedKomment.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        DbSet<Medicament> MedicamentsNew { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
