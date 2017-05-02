using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerVehicle
    {
        [Key]
        public string VehicleId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Status { get; set; }
        public Customer Customer { get; set; }
    }
}
