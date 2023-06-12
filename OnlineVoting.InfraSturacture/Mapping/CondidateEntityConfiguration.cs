using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVoting.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.InfraStructure.Mapping
{
    public class CondidateEntityConfiguration : IEntityTypeConfiguration<Condidate>
    {
        public void Configure(EntityTypeBuilder<Condidate> builder)
        {
            builder.Property(x => x.Id);
            builder.HasKey(x => x.Id);

            builder.Property(x=> x.Name)
                .HasColumnType<string>(nameof(SqlDbType.NVarChar))
                .HasMaxLength(128)
                .IsRequired();

            builder.Property(x => x.LastName)
                .HasColumnType<string>(nameof(SqlDbType.NVarChar))
                .HasMaxLength(128)
                .IsRequired();

            builder.Property(x => x.City)
                .HasColumnType<string>(nameof(SqlDbType.NVarChar))
                .HasMaxLength(128)
                .IsRequired();

        }
    }
}
