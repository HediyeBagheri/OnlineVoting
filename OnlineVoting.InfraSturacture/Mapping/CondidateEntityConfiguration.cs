using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineVoting.Model;
using System.Data;
using System.IO.Compression;
using System.Text;

namespace CinemaTicket.InfraStructure.Mapping
{
    public class CondidateEntityConfiguration : IEntityTypeConfiguration<Condidate>
    {
        public void Configure(EntityTypeBuilder<Condidate> builder)
        {
            builder.Property(x => x.Id);
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasColumnType<string>(nameof(SqlDbType.NVarChar))
                .HasMaxLength(64)
                .IsRequired();

            builder.Property(x => x.LastName)
                .HasColumnType<string>(nameof(SqlDbType.NVarChar))
                .HasMaxLength(128)
                .IsRequired();

            builder.Property(x => x.City)
                .HasColumnType<string>(nameof(SqlDbType.NVarChar))
                .HasMaxLength(128)
                .IsRequired();

            builder.Property(e => e.CompressName)
                .HasColumnType<string>(nameof(SqlDbType.NVarChar))
                .HasMaxLength(64)
                .HasConversion(
                v => Zip(v),
                v => Unzip(v));


        }
        public static void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        public static byte[] Zip(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        public static string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }




    }
}
