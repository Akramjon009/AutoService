using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Domain.Entities.Models.UserModels
{
    public class UserModel : IdentityUser
    {
        public required string Name { get; set; }
        public required string Role { get; set; }
        public required string CarBrand { get; set; }
        public required string CarModel { get; set; }
    }
}
