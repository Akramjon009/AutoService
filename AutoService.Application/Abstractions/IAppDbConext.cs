using AutoService.Domain.Entities.Models.AutoServiceModels;
using AutoService.Domain.Entities.Models.CarModels;
using AutoService.Domain.Entities.Models.UserModels;
using System.Data.Entity;

namespace AutoService.Application.Abstractions
{
    public class IAppDbConext
    {
        public DbSet<CarModel> carModels { get; set; }
        public DbSet<UserQuestions> UserQuestions { get; set; }
        public DbSet<AutoServiceModel> autoServices { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
