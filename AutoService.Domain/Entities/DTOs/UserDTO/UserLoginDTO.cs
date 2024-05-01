using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Domain.Entities.DTOs.UserDTO
{
    public class UserLoginDTO 
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
