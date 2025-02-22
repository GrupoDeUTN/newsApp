﻿using Microsoft.EntityFrameworkCore;
using newsApp.Temas;
using newsApp.Noticias;
using newsApp.Busquedas;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace newsApp.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class newsAppDbContext :
    AbpDbContext<newsAppDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    #region Entidades de dominio

    public DbSet<Tema> Temas { get; set; } 
    public DbSet<Noticia> Noticias { get; set; }
    public DbSet<Busqueda> Busquedas { get; set; }
    #endregion

    public newsAppDbContext(DbContextOptions<newsAppDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(newsAppConsts.DbTablePrefix + "YourEntities", newsAppConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});

        //Entidad tema
        builder.Entity<Tema>(b =>
        {
            b.ToTable(newsAppConsts.DbTablePrefix + "Temas", newsAppConsts.DbSchema);
            b.ConfigureByConvention();
            b.Property(x => x.Nombre).IsRequired().HasMaxLength(128);
        });

        //Entidad noticia
        builder.Entity<Noticia>(b =>
        {
            b.ToTable(newsAppConsts.DbTablePrefix + "Noticias", newsAppConsts.DbSchema);
            b.ConfigureByConvention();
            b.Property(x => x.Titulo).IsRequired().HasMaxLength(128);
            b.Property(x => x.Descripcion).IsRequired().HasMaxLength(500);
            b.Property(x => x.FechaPublicacion).IsRequired(); //formato
        });

        builder.Entity<Busqueda>(b =>
        {
            b.ToTable(newsAppConsts.DbTablePrefix + "Busquedas", newsAppConsts.DbSchema);
            b.ConfigureByConvention();
           // b.Property(x => x.Texto).IsRequired().HasMaxLength(500); 
        });
    }
}
