using AutoService.Application.AutoService.CarCases.Commands;
using AutoService.Domain.Entities.Models;
using MediatR;
using AutoService.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Application.AutoService.CarCases.Handlers
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, ResponceModel>
    {
        private readonly IAppDbConext _context;

        public CreateCarCommandHandler(IAppDbConext context)
        {
            _context = context;
        }

        public Task<ResponceModel> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
