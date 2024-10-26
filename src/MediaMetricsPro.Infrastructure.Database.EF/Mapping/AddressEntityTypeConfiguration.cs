using MediaMetricsPro.Domain.Register;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediaMetricsPro.Infrastructure.Database.EF.Mapping;
internal class SellerEntityTypeConfiguration : IEntityTypeConfiguration<Seller>
{
    public void Configure(EntityTypeBuilder<Seller> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name)
            .HasMaxLength(200)
            .HasColumnName("Nome");
        builder.HasOne(x => x.Address);
        builder.ToTable("Vendedor");
    }
}

internal class AddressEntityTypeConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Street)
            .HasMaxLength(200)
            .HasColumnName("Logradouro")
            .IsRequired();
        builder.Property(x => x.Number)
            .HasColumnName("Numero")
            .IsRequired();
        builder.Property(x => x.District)
            .HasColumnName("Bairro")
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(x => x.City)
            .HasColumnName("Cidade")
            .HasMaxLength(150)
            .IsRequired();
        builder.HasOne(x => x.State);

        // builder.HasOne(x => x.Country);
        builder.ToTable("Endereco");
    }
}
