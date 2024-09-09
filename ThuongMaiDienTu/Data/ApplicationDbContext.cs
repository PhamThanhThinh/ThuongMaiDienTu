using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using ThuongMaiDienTu.Models;

namespace ThuongMaiDienTu.Data
{
  public class ApplicationDbContext : IdentityDbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Group>().HasData(
        new Group()
        {
          Id = Guid.Parse("554595ca-e17a-483f-8466-59698ad61960"),
          Name = "Quản trị viên"
        }
      );
      builder.Entity<Member>().HasData(
        new Member()
        {
          Id = Guid.Parse("1cb0d3c8-5748-49c0-a1d7-e7f5de4ce950"),
          Name = "Phạm Thanh Thịnh",
          Picture = "img/users/photo4.jpg",
          LoginName = "codingwiththinh",
          Password = "40bd001563085fc35165329ea1ff5c5ecbdbbeef",
          Email = "codingwiththinh@gmail.com",
          CreatedOn = DateTime.Now,
          GroupId = Guid.Parse("554595ca-e17a-483f-8466-59698ad61960")
        }  
      );
      builder.Entity<Category>().HasData(
        new Category()
        {
          Id = Guid.Parse("e0ecd868-ffd1-47ca-8bc1-3add00c63d77"),
          Name = "Root",
          CreatedBy = Guid.Parse("1cb0d3c8-5748-49c0-a1d7-e7f5de4ce950"),
          CreatedOn = DateTime.Now
        },
        new Category()
        {
          Id = Guid.Parse("bbd71d8c-50b1-4653-bab3-9c68b152d534"),
          Name = "Authorized",
          CreatedBy = Guid.Parse("1cb0d3c8-5748-49c0-a1d7-e7f5de4ce950"),
          CreatedOn = DateTime.Now,
          ParentId = Guid.Parse("e0ecd868-ffd1-47ca-8bc1-3add00c63d77")
        },
        new Category()
        {
          Id = Guid.Parse("9804ecab-6e5d-41d5-9313-410c1544b593"),
          Name = "Nhóm quyền",
          CreatedBy = Guid.Parse("1cb0d3c8-5748-49c0-a1d7-e7f5de4ce950"),
          CreatedOn = DateTime.Now,
          ParentId = Guid.Parse("bbd71d8c-50b1-4653-bab3-9c68b152d534")
        },
        new Category()
        {
          Id = Guid.Parse("a1b18e0a-1765-456e-91d9-54f90b2f0124"),
          Name = "Article",
          CreatedBy = Guid.Parse("1cb0d3c8-5748-49c0-a1d7-e7f5de4ce950"),
          CreatedOn = DateTime.Now,
          ParentId = Guid.Parse("e0ecd868-ffd1-47ca-8bc1-3add00c63d77")
        },
        new Category()
        {
          Id = Guid.Parse("7602f27f-eff6-4791-b28d-476f4de8b578"),
          Name = "Product",
          CreatedBy = Guid.Parse("1cb0d3c8-5748-49c0-a1d7-e7f5de4ce950"),
          CreatedOn = DateTime.Now,
          ParentId = Guid.Parse("e0ecd868-ffd1-47ca-8bc1-3add00c63d77")
        }
      );
      builder.Entity<Role>().HasData(
        
      );

      //builder.Entity<Authorized>().HasData(
      //  new Authorized()
      //  {
      //    Id = Guid.NewGuid(),
      //    GroupId = Guid.Parse(),
      //    RoleId = Guid.Parse()
      //  }
      //);

    }

    public DbSet<Article> Articles { get; set; }
    public DbSet<Authorized> Authorizeds { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Role> Roles { get; set; }
  }
}
