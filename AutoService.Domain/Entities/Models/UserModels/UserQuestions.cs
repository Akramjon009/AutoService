using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Domain.Entities.Models.UserModels
{
    public class UserQuestions
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string questionComment { get; set; }
    }
}
