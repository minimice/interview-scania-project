using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Query
{
    interface IVehicleQuery
    {
        IEnumerable<IViewResult> ShowAllResults();
        IEnumerable<IViewResult> ShowResultsForCustomer(string customerId);
        IEnumerable<IViewResult> ShowResultsForStatus(string status);
    }
}
