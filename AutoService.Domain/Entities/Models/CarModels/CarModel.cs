using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Domain.Entities.Models.CarModels
{
    public class CarModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public string City { get; set; }
        public string CarYear { get; set; }
        public string VINcode { get; set; }
        public string CarNumber { get; set; }
        public string ChasisNumber { get; set; }
        public long Probeg {  get; set; }
        public string CarNumberPlate { get; set; }
        public string WheelBrand { get; set; }
        public int CarMass {  get; set; }
        public string FuelType { get; set; }
        public string BrakeType { get; set;}
        public string CarCategory {  get; set; }
        public string DocumentType { get; set; }
        public string Seria { get; set; }
    }
}
