using CinemaTicket.InfraStructure.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineVoting.InfraSturacture.IRepositories;
using OnlineVoting.Model;
using OnlineVoting.Model.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVoting.InfraSturacture.Context
{
    public class OnlineVotingContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>,
        ApplicationUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public OnlineVotingContext(DbContextOptions<OnlineVotingContext> option) : base(option) { }
        public DbSet<Condidate> Condidate { get; set; }
        public DbSet<Adviser> Adviser { get; set; }
        public DbSet<Vote> Vote { get; set; }
        public DbSet<Voting> Voting { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CondidateEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AdviserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new VoteEntityConfiguration());
            modelBuilder.ApplyConfiguration(new VotingEntityConfiguration());

            modelBuilder.Entity<ApplicationUser>().HasKey(x => x.Id);
            modelBuilder.Entity<ApplicationUser>().HasMany(x => x.ApplicationUserRoles)
                        .WithOne(x => x.User).HasForeignKey(x => x.UserId);

            modelBuilder.Entity<ApplicationRole>().ToTable("AspNetRoles");
            modelBuilder.Entity<ApplicationRole>().HasKey(x => x.Id);
            modelBuilder.Entity<ApplicationRole>().HasMany(x => x.ApplicationUserRoles)
                        .WithOne(x => x.Role).HasForeignKey(x => x.RoleId);

            modelBuilder.Entity<ApplicationUserRole>().HasOne(x => x.User);
            modelBuilder.Entity<ApplicationUserRole>().HasOne(x => x.Role);


            modelBuilder.Ignore<IdentityUserClaim<string>>();
            modelBuilder.Ignore<IdentityRoleClaim<string>>();
            modelBuilder.Ignore<IdentityUserToken<string>>();

            GenerateRoleData(modelBuilder);

        }

        private static void GenerateRoleData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationRole>().HasData(
            new ApplicationRole
            {
                Id = RoleSeedData.RoleId,
                Name = RoleSeedData.Name,
                NormalizedName = RoleSeedData.NormalizedName,
                ConcurrencyStamp = RoleSeedData.ConcurrencyStamp
            },
            new ApplicationRole
            {
                Id = RoleSeedData.SupportRoleId,
                Name = RoleSeedData.SupportName,
                NormalizedName = RoleSeedData.SupportNormalizedName,
                ConcurrencyStamp = RoleSeedData.SupportConcurrencyStamp
            });
        }
    }
}
