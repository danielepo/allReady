using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using PrepOps.Models;

namespace PrepOps.Migrations
{
    [ContextType(typeof(PrepOpsContext))]
    partial class SecurityModelCHanges2
    {
        public override string Id
        {
            get { return "20150714204936_SecurityModelCHanges2"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta5-13549"; }
        }
        
        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("SqlServer:ValueGeneration", "Identity");
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .GenerateValueOnAdd();
                    
                    b.Property<string>("ConcurrencyStamp")
                        .ConcurrencyToken();
                    
                    b.Property<string>("Name");
                    
                    b.Property<string>("NormalizedName");
                    
                    b.Key("Id");
                    
                    b.Annotation("Relational:TableName", "AspNetRoles");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("ClaimType");
                    
                    b.Property<string>("ClaimValue");
                    
                    b.Property<string>("RoleId");
                    
                    b.Key("Id");
                    
                    b.Annotation("Relational:TableName", "AspNetRoleClaims");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("ClaimType");
                    
                    b.Property<string>("ClaimValue");
                    
                    b.Property<string>("UserId");
                    
                    b.Key("Id");
                    
                    b.Annotation("Relational:TableName", "AspNetUserClaims");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .GenerateValueOnAdd();
                    
                    b.Property<string>("ProviderKey")
                        .GenerateValueOnAdd();
                    
                    b.Property<string>("ProviderDisplayName");
                    
                    b.Property<string>("UserId");
                    
                    b.Key("LoginProvider", "ProviderKey");
                    
                    b.Annotation("Relational:TableName", "AspNetUserLogins");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");
                    
                    b.Property<string>("RoleId");
                    
                    b.Key("UserId", "RoleId");
                    
                    b.Annotation("Relational:TableName", "AspNetUserRoles");
                });
            
            builder.Entity("PrepOps.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<int>("CampaignId");
                    
                    b.Property<string>("Description");
                    
                    b.Property<DateTime>("EndDateTimeUtc");
                    
                    b.Property<int?>("LocationId");
                    
                    b.Property<string>("Name");
                    
                    b.Property<string>("OrganizerId");
                    
                    b.Property<DateTime>("StartDateTimeUtc");
                    
                    b.Property<int>("TenantId");
                    
                    b.Key("Id");
                });
            
            builder.Entity("PrepOps.Models.ActivitySignup", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<int?>("ActivityId");
                    
                    b.Property<DateTime?>("CheckinDateTime");
                    
                    b.Property<DateTime>("SignupDateTime");
                    
                    b.Property<string>("UserId");
                    
                    b.Key("Id");
                });
            
            builder.Entity("PrepOps.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .GenerateValueOnAdd();
                    
                    b.Property<int>("AccessFailedCount");
                    
                    b.Property<int?>("AssociatedTenantId");
                    
                    b.Property<string>("ConcurrencyStamp")
                        .ConcurrencyToken();
                    
                    b.Property<string>("Email");
                    
                    b.Property<bool>("EmailConfirmed");
                    
                    b.Property<bool>("LockoutEnabled");
                    
                    b.Property<DateTimeOffset?>("LockoutEnd");
                    
                    b.Property<string>("NormalizedEmail");
                    
                    b.Property<string>("NormalizedUserName");
                    
                    b.Property<string>("PasswordHash");
                    
                    b.Property<string>("PhoneNumber");
                    
                    b.Property<bool>("PhoneNumberConfirmed");
                    
                    b.Property<string>("SecurityStamp");
                    
                    b.Property<bool>("TwoFactorEnabled");
                    
                    b.Property<string>("UserName");
                    
                    b.Key("Id");
                    
                    b.Annotation("Relational:TableName", "AspNetUsers");
                });
            
            builder.Entity("PrepOps.Models.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("Description");
                    
                    b.Property<DateTime>("EndDateTimeUtc");
                    
                    b.Property<string>("ImageUrl");
                    
                    b.Property<int>("ManagingTenantId");
                    
                    b.Property<string>("Name");
                    
                    b.Property<string>("OrganizerId");
                    
                    b.Property<DateTime>("StartDateTimeUtc");
                    
                    b.Key("Id");
                });
            
            builder.Entity("PrepOps.Models.CampaignSponsors", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<int?>("CampaignId");
                    
                    b.Property<int?>("TenantId");
                    
                    b.Key("Id");
                });
            
            builder.Entity("PrepOps.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("Address1");
                    
                    b.Property<string>("Address2");
                    
                    b.Property<string>("City");
                    
                    b.Property<string>("Country");
                    
                    b.Property<string>("Name");
                    
                    b.Property<string>("PhoneNumber");
                    
                    b.Property<string>("PostalCodePostalCode");
                    
                    b.Property<string>("State");
                    
                    b.Key("Id");
                });
            
            builder.Entity("PrepOps.Models.PostalCodeGeo", b =>
                {
                    b.Property<string>("PostalCode")
                        .GenerateValueOnAdd();
                    
                    b.Property<string>("City");
                    
                    b.Property<string>("State");
                    
                    b.Key("PostalCode");
                });
            
            builder.Entity("PrepOps.Models.PrepOpsTask", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<int?>("ActivityId");
                    
                    b.Property<string>("Description");
                    
                    b.Property<DateTime?>("EndDateTimeUtc");
                    
                    b.Property<string>("Name");
                    
                    b.Property<DateTime?>("StartDateTimeUtc");
                    
                    b.Property<int?>("TenantId");
                    
                    b.Key("Id");
                });
            
            builder.Entity("PrepOps.Models.TaskUsers", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("Status");
                    
                    b.Property<DateTime>("StatusDateTimeUtc");
                    
                    b.Property<string>("StatusDescription");
                    
                    b.Property<int?>("TaskId");
                    
                    b.Property<string>("UserId");
                    
                    b.Key("Id");
                });
            
            builder.Entity("PrepOps.Models.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("LogoUrl");
                    
                    b.Property<string>("Name");
                    
                    b.Property<string>("WebUrl");
                    
                    b.Key("Id");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Reference("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .InverseCollection()
                        .ForeignKey("RoleId");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Reference("PrepOps.Models.ApplicationUser")
                        .InverseCollection()
                        .ForeignKey("UserId");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Reference("PrepOps.Models.ApplicationUser")
                        .InverseCollection()
                        .ForeignKey("UserId");
                });
            
            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Reference("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .InverseCollection()
                        .ForeignKey("RoleId");
                    
                    b.Reference("PrepOps.Models.ApplicationUser")
                        .InverseCollection()
                        .ForeignKey("UserId");
                });
            
            builder.Entity("PrepOps.Models.Activity", b =>
                {
                    b.Reference("PrepOps.Models.Campaign")
                        .InverseCollection()
                        .ForeignKey("CampaignId");
                    
                    b.Reference("PrepOps.Models.Location")
                        .InverseCollection()
                        .ForeignKey("LocationId");
                    
                    b.Reference("PrepOps.Models.ApplicationUser")
                        .InverseCollection()
                        .ForeignKey("OrganizerId");
                    
                    b.Reference("PrepOps.Models.Tenant")
                        .InverseCollection()
                        .ForeignKey("TenantId");
                });
            
            builder.Entity("PrepOps.Models.ActivitySignup", b =>
                {
                    b.Reference("PrepOps.Models.Activity")
                        .InverseCollection()
                        .ForeignKey("ActivityId");
                    
                    b.Reference("PrepOps.Models.ApplicationUser")
                        .InverseCollection()
                        .ForeignKey("UserId");
                });
            
            builder.Entity("PrepOps.Models.ApplicationUser", b =>
                {
                    b.Reference("PrepOps.Models.Tenant")
                        .InverseCollection()
                        .ForeignKey("AssociatedTenantId");
                });
            
            builder.Entity("PrepOps.Models.Campaign", b =>
                {
                    b.Reference("PrepOps.Models.Tenant")
                        .InverseCollection()
                        .ForeignKey("ManagingTenantId");
                    
                    b.Reference("PrepOps.Models.ApplicationUser")
                        .InverseCollection()
                        .ForeignKey("OrganizerId");
                });
            
            builder.Entity("PrepOps.Models.CampaignSponsors", b =>
                {
                    b.Reference("PrepOps.Models.Campaign")
                        .InverseCollection()
                        .ForeignKey("CampaignId");
                    
                    b.Reference("PrepOps.Models.Tenant")
                        .InverseCollection()
                        .ForeignKey("TenantId");
                });
            
            builder.Entity("PrepOps.Models.Location", b =>
                {
                    b.Reference("PrepOps.Models.PostalCodeGeo")
                        .InverseCollection()
                        .ForeignKey("PostalCodePostalCode");
                });
            
            builder.Entity("PrepOps.Models.PrepOpsTask", b =>
                {
                    b.Reference("PrepOps.Models.Activity")
                        .InverseCollection()
                        .ForeignKey("ActivityId");
                    
                    b.Reference("PrepOps.Models.Tenant")
                        .InverseCollection()
                        .ForeignKey("TenantId");
                });
            
            builder.Entity("PrepOps.Models.TaskUsers", b =>
                {
                    b.Reference("PrepOps.Models.PrepOpsTask")
                        .InverseCollection()
                        .ForeignKey("TaskId");
                    
                    b.Reference("PrepOps.Models.ApplicationUser")
                        .InverseCollection()
                        .ForeignKey("UserId");
                });
        }
    }
}
