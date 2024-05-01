using AutoService.Application.Abstractions;
using AutoService.Domain.Entities.Models.AutoServiceModels;
using AutoService.Domain.Entities.Models.CarModels;
using AutoService.Domain.Entities.Models.UserModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutoService.Infrastracture.Persistance
{
    public class ServiceDbContext : IdentityDbContext<IdentityUser>, IAppDbConext
    {
        public ServiceDbContext(DbContextOptions<ServiceDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<CarModel> carModels { get; set; }
        public DbSet<UserQuestions> UserQuestions { get; set; }
        public DbSet<AutoServiceModel> autoServices { get; set; }

    }
}
