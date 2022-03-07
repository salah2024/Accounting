using Accounting.Application.Interface.Context;
using Accounting.Domain.Entities.LanguageManager;
using Accounting.Domain.Entities.UserManager;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Persistence.Context
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<clsUserInfo> UserInfos { get; set; }
        public DbSet<clsRole> Roles { get; set; }
        public DbSet<clsTask> Tasks  { get; set; }
        public DbSet<clsUserInRole> UserInRoles { get; set; }
        public DbSet<clsRoleTask> RoleTasks { get; set; }
        public DbSet<clsRoleTaskDate> RoleTaskDates { get; set; }
        public DbSet<clsLanguage> Languages { get; set; }
        public DbSet<clsLanguageKeyValue> LanguageKeyValues { get; set; }
        public DbSet<clsLanguage_LanguageKeyValue> Language_LanguageKeyValues { get; set; }
        public DbSet<clsUserIdentity> UserIdentities { get; set; }
        public DbSet<clsUserLogin> UserLogins { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedDate(modelBuilder);
            ApplyQueryFilter(modelBuilder);
        }
        private void ApplyQueryFilter(ModelBuilder modelBuilder)
        {
        }
        private void SeedDate(ModelBuilder modelBuilder)
        {
        }
    }
}
