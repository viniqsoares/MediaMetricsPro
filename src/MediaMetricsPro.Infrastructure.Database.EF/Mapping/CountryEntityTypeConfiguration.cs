using MediaMetricsPro.Domain.Register;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediaMetricsPro.Infrastructure.Database.EF.Mapping;

internal class CountryEntityTypeConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedNever();
        builder.Property(x => x.Name)
            .HasColumnName("Nome")
            .HasMaxLength(200)
            .IsRequired();

        builder.ToTable("Pais");
    }
}