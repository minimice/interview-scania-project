using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Query
{
    public class VehicleQuery : IVehicleQuery
    {
        public IEnumerable<IViewResult> ShowAllResults()
        {
            return new List<IViewResult>();
        }

        public IEnumerable<IViewResult> ShowResultsForCustomer(string customerId)
        {
            return new List<IViewResult>();
        }

        public IEnumerable<IViewResult> ShowResultsForStatus(string status)
        {
            return new List<IViewResult>();
        }
    }
}
