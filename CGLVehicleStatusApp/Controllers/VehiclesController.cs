using DataAccess;
using Domain.Query;
using Domain.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CGLVehicleStatusApp.Controllers
{
    public class VehiclesController : Controller
    {
        public ActionResult Index()
        {
            Factory factory = new Factory();
            IStore store = factory.GetStore(typeof(FileStore));
            // If you want to use the DatabaseStore uncomment the next line and run init.sql script
            // IStore store = factory.GetStore(typeof(DatabaseStore));
            VehicleQuery vehicleQuery = new VehicleQuery();
            List<IVehicleQueryDTO> vehicleQueryResults = new List<IVehicleQueryDTO>();
            string status = Request.Params.Get("StatusSearchField");
            string customerId = Request.Params.Get("CustomerIDSearchField");
            int parsedCustomerId = 0;
            if (!string.IsNullOrEmpty(status))
            {
                vehicleQueryResults.AddRange(vehicleQuery.ShowResultsForStatus(store,status));
            }
            else if (!string.IsNullOrEmpty(customerId))
            {
                if (int.TryParse(customerId, out parsedCustomerId))
                {
                    vehicleQueryResults.AddRange(vehicleQuery.ShowResultsForCustomer(store, parsedCustomerId));
                }
                else
                {
                    vehicleQueryResults.AddRange(vehicleQuery.ShowAllResults(store));
                }
            }
            else
            {
                vehicleQueryResults.AddRange(vehicleQuery.ShowAllResults(store));
            }
            
            return View(vehicleQueryResults);
        }
    }
}