using AutoService.Domain.Entities.Models.CarModels;
using AutoService.Domain.Entities.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace AutoService.Application.Abstractions
{
    public class IAppDbConext
    {
        public DbSet<CarModel> carModels { get; set; }
        public DbSet<UserQuestions> UserQuestions { get; set; }
    }
}
