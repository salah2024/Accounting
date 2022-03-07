using Accounting.Domain.Entities.LanguageManager;
using Accounting.Domain.Entities.UserManager;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.Context
{
    public interface IDataBaseContext
    {
        DbSet<clsUserInfo> UserInfos { get; set; }
        DbSet<clsRole> Roles { get; set;}
        DbSet<clsTask> Tasks { get; set; }
        DbSet<clsUserInRole> UserInRoles { get; set; }
        DbSet<clsRoleTask> RoleTasks { get; set; }
        DbSet<clsRoleTaskDate> RoleTaskDates { get; set; }
        DbSet<clsLanguage> Languages { get; set; }
        DbSet<clsLanguageKeyValue> LanguageKeyValues { get; set; }
        DbSet<clsLanguage_LanguageKeyValue> Language_LanguageKeyValues { get; set; }
        DbSet<clsUserIdentity> UserIdentities { get; set; }
        DbSet<clsUserLogin> UserLogins { get; set; }

        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
