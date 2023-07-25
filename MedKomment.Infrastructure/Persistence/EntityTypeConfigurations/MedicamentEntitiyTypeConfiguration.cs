using MedKomment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedKomment.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class MedicamentEntitiyTypeConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Name)
                .HasMaxLength(500)
                .IsRequired();
        }
    }
}
