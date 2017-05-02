using DataAccess;
using Domain.ViewModel;
using System.Collections.Generic;

namespace Domain.Query
{
    public interface IVehicleQuery
    {
        IEnumerable<IVehicleQueryDTO> ShowAllResults(IStore store);
        IEnumerable<IVehicleQueryDTO> ShowResultsForCustomer(IStore store, int customerId);
        IEnumerable<IVehicleQueryDTO> ShowResultsForStatus(IStore store, string status);
    }
}
