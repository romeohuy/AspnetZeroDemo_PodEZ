using PodEZ.PodEZTemplate.PodEz;
using PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo;
using Abp.IdentityServer4;
using Abp.Organizations;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PodEZ.PodEZTemplate.Authorization.Delegation;
using PodEZ.PodEZTemplate.Authorization.Roles;
using PodEZ.PodEZTemplate.Authorization.Users;
using PodEZ.PodEZTemplate.Chat;
using PodEZ.PodEZTemplate.Editions;
using PodEZ.PodEZTemplate.Friendships;
using PodEZ.PodEZTemplate.MultiTenancy;
using PodEZ.PodEZTemplate.MultiTenancy.Accounting;
using PodEZ.PodEZTemplate.MultiTenancy.Payments;
using PodEZ.PodEZTemplate.Storage;

namespace PodEZ.PodEZTemplate.EntityFrameworkCore
{
    public class PodEZTemplateDbContext : AbpZeroDbContext<Tenant, Role, User, PodEZTemplateDbContext>, IAbpPersistedGrantDbContext
    {
        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<PodEZ.Entity.PozOrderDemo.PozOrderDemo> PozOrderDemo { get; set; }

        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual DbSet<Friendship> Friendships { get; set; }

        public virtual DbSet<ChatMessage> ChatMessages { get; set; }

        public virtual DbSet<SubscribableEdition> SubscribableEditions { get; set; }

        public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        public virtual DbSet<SubscriptionPaymentExtensionData> SubscriptionPaymentExtensionDatas { get; set; }

        public virtual DbSet<UserDelegation> UserDelegations { get; set; }

        public PodEZTemplateDbContext(DbContextOptions<PodEZTemplateDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<PozOrderDemo>();

            modelBuilder.Entity<ChatMessage>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState });
            });

            modelBuilder.Entity<Friendship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId });
                b.HasIndex(e => new { e.TenantId, e.FriendUserId });
                b.HasIndex(e => new { e.FriendTenantId, e.UserId });
                b.HasIndex(e => new { e.FriendTenantId, e.FriendUserId });
            });

            modelBuilder.Entity<Tenant>(b =>
            {
                b.HasIndex(e => new { e.SubscriptionEndDateUtc });
                b.HasIndex(e => new { e.CreationTime });
            });

            modelBuilder.Entity<SubscriptionPayment>(b =>
            {
                b.HasIndex(e => new { e.Status, e.CreationTime });
                b.HasIndex(e => new { PaymentId = e.ExternalPaymentId, e.Gateway });
            });

            modelBuilder.Entity<SubscriptionPaymentExtensionData>(b =>
            {
                b.HasQueryFilter(m => !m.IsDeleted)
                    .HasIndex(e => new { e.SubscriptionPaymentId, e.Key, e.IsDeleted })
                    .IsUnique();
            });

            modelBuilder.Entity<UserDelegation>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.SourceUserId });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId });
            });

            // Remove when https://github.com/aspnetboilerplate/aspnetboilerplate/issues/5457 is fixed
            modelBuilder.Entity<OrganizationUnit>().HasIndex(e => new { e.TenantId, e.Code }).IsUnique(false);

            modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}
