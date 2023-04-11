using BossAzAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BossAzAPI.DAL
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region EnumKey Seeds

            modelBuilder.Entity<EnumKey>().HasData(
                new EnumKey()
                {
                    Id = 1,
                    Key = "gender"
                },
                new EnumKey()
                {
                    Id = 2,
                    Key = "city"
                },
                new EnumKey()
                {
                    Id = 3,
                    Key = "category"
                },
                new EnumKey()
                {
                    Id = 4,
                    Key = "experience"
                },
                new EnumKey()
                {
                    Id = 5,
                    Key = "education"
                });

            #endregion
            #region EnumValue Seeds

            modelBuilder.Entity<EnumValue>().HasData(
                new EnumValue()
                {
                    Id = 1,
                    Value = "Under 1 year",
                    KeyId = 4
                },
                new EnumValue()
                {
                    Id = 2,
                    Value = "1 to 3 years",
                    KeyId = 4
                },
                new EnumValue()
                {
                    Id = 3,
                    Value = "3 to 5 years",
                    KeyId = 4
                },
                new EnumValue()
                {
                    Id = 4,
                    Value = "More than 5 years",
                    KeyId = 4
                });

            #endregion
        }
        public DbSet<EnumKey> EnumKeys { get; set; }
        public DbSet<EnumValue> EnumValues { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Resume> Resumes { get; set; }
    }
}
