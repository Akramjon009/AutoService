using AutoService.Domain.Entities.DTOs.UserDTO;
using AutoService.Domain.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Application.AutoService.CarCases.Commands
{
    public class DeleteCarCommand : IRequest<ResponceModel>
    {
        public virtual UserLoginDTO UserLogin { get; set; }
    }
}
