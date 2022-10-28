namespace SeeSensor.Services.Services
{
    public class ServiceSeaSensorStatus
    {
        
        public string Id { get; set; }
        public string MacAddress { get; set; }
        public float BatteryCharge { get; set; }
        public DateTime Timestamp { get; set; }
    }
}