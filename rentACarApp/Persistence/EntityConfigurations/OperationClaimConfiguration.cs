﻿using Freezone.Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
{
    public void Configure(EntityTypeBuilder<OperationClaim> builder)
    {
        builder.ToTable("OperationClaims");

        builder.Property(p => p.Id).HasColumnName("Id");
        builder.Property(p => p.Name).HasColumnName("Name");

        builder.HasIndex(indexExpression: p => p.Name, name: "UK_OperationClaims_Name").IsUnique();

        List<OperationClaim> seed = new();
        int id = 0;

        #region FeatureOperationClaims

        #endregion

        builder.HasData(seed);
    }
}