using AutoService.Domain.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Application.AutoService.AutoServiceCases.Commands
{
    public class CreateAutoServiceCommand:IRequest<ResponceModel>
    {
        public string ServiceName { get; set; }
        public string City { get; set; }
        public string WebSitePath { get; set; }
        public string OwnerName { get; set; }
        public string OwnerNumber { get; set; }
        public string OwnerEmail { get; set; }
    }
}
