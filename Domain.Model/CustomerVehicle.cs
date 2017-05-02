namespace Domain.Model
{
    internal class CustomerVehicle : ICustomerVehicle
    {
        public string VehicleId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Status { get; set; }
        public Customer Customer { get; set; }
    }
}
