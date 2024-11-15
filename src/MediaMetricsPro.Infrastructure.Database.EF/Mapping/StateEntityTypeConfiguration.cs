﻿using MediaMetricsPro.Domain.Register;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediaMetricsPro.Infrastructure.Database.EF.Mapping;

internal class StateEntityTypeConfiguration : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name)
            .HasColumnName("Nome");
        builder.HasOne(x => x.Country);
        builder.ToTable("Estado");
    }
}
