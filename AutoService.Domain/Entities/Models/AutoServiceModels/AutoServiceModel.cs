using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Domain.Entities.Models.AutoServiceModels
{
    public class AutoServiceModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ServiceName { get; set; }
        public string City {  get; set; }
        public string WebSitePath { get; set; }
        public string OwnerName { get; set; }
        public string OwnerNumber { get; set; }
        public string OwnerEmail { get; set; }
    }
}
