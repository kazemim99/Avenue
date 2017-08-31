using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading;
using Avenue.Core;
using Avenue.Core.Common;

namespace Avenue.InfraStructure
{
    public interface IContext
    {
        IDbSet<WeddingVenues> AvenuDetailses { get; set; }
        IDbSet<Category> Categories { get; set; }
        IDbSet<WeddingVenuesFacilities> TypeFacilities { get; set; }

        IDbSet<City> Cities { get; set; }
        IDbSet<State> States { get; set; }
        IDbSet<Review> Reviews { get; set; }
        IDbSet<Score> Scores { get; set; }
        IDbSet<UserPhoto> UserPhotos { get; set; }
        IDbSet<Article> Articles { get; set; }
        IDbSet<ArticleComment> ArticleComments { get; set; }
        IDbSet<ServicePhoto> ServicePhotos { get; set; }
         IDbSet<MenuItems> MenuItemses { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
    }
    public class AvenueDbContext : DbContext, IContext
    {
        public static AvenueDbContext Create()
        {
            return new AvenueDbContext();
        }
        public AvenueDbContext() : base("aroosi24")
        {
            this.Configuration.ProxyCreationEnabled = false;

            this.Configuration.LazyLoadingEnabled = false;

            this.Configuration.AutoDetectChangesEnabled = false;

        }
        public IDbSet<WeddingVenues> AvenuDetailses { get; set; }
        public IDbSet<ServicePhoto> ServicePhotos { get; set; }
        public IDbSet<Category> Categories { get; set; }

        public IDbSet<WeddingVenuesFacilities> TypeFacilities { get; set; }
        public IDbSet<MenuItems> MenuItemses { get; set; }
        public IDbSet<City> Cities { get; set; }
        public IDbSet<State> States { get; set; }
        public IDbSet<Review> Reviews { get; set; }
        public IDbSet<Score> Scores { get; set; }
        public IDbSet<UserPhoto> UserPhotos { get; set; }
        public IDbSet<Article> Articles { get; set; }
        public IDbSet<ArticleComment> ArticleComments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            base.OnModelCreating(modelBuilder);


        }

        public override int SaveChanges()
        {

            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity
                            && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    string identityNme = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == EntityState.Added)
                    {

                        entity.CreateBy = identityNme;
                        entity.CreateDate = now;
                    }
                    else
                    {
                        Entry(entity).Property(x => x.CreateBy).IsModified = false;
                        Entry(entity).Property(x => x.CreateDate).IsModified = false;

                    }

                    entity.UpdateBy = identityNme;
                    entity.UpdateDate = now;
                }

            }

            return base.SaveChanges();
        }

    }
}
