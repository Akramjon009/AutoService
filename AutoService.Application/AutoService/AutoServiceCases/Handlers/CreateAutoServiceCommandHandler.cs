using AutoService.Application.Abstractions;
using AutoService.Application.AutoService.AutoServiceCases.Commands;
using AutoService.Domain.Entities.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Application.AutoService.AutoServiceCases.Handlers
{
    public class CreateAutoServiceCommandHandler : IRequestHandler<CreateAutoServiceCommand, ResponceModel>
    {
        private readonly IAppDbConext _context;

        public CreateAutoServiceCommandHandler(IAppDbConext context)
        {
            _context = context;
        }

        public async Task<ResponceModel> Handle(CreateAutoServiceCommand request, CancellationToken cancellationToken)
        {
            var autoservice = await _context.autoServices.FirstOrDefaultAsync(x => x.OwnerEmail == request.OwnerEmail);
            if (autoservice == null)
            {
                await _context.autoServices.AddAsync(autoservice);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponceModel
                {
                    Message = "Your autoservice succesfully registered",
                    StatusCode = 200,
                };
            }

            return new ResponceModel
            {
                Message = "This autoservice already exists",
                StatusCode = 409
            };
        }
    }
}
