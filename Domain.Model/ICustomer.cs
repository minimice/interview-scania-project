using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    internal interface ICustomer
    {
        int ID { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        List<CustomerVehicle> Vehicles { get; set; }
    }
}
