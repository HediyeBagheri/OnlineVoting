using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVoting.Model;
using System.Data;

public class AdviserEntityConfiguration : IEntityTypeConfiguration<Adviser>
{
    public void Configure(EntityTypeBuilder<Adviser> builder)
    {
        builder.Property(x => x.Id);
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasColumnType<string>(nameof(SqlDbType.NVarChar))
            .HasMaxLength(128)
            .IsRequired();

        builder.Property(x => x.LastName)
            .HasColumnType<string>(nameof(SqlDbType.NVarChar))
            .HasMaxLength(128)
            .IsRequired();

    }
}
