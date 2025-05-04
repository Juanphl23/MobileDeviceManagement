using MobileDeviceManagement.Web.Enums;

namespace MobileDeviceManagement.Web.Models;

public class Device
{
    public int Id { get; set; }
    public string? Model { get; set; } // string? permite valores null
    public string? IMEI { get; set; }
    public DeviceStatus Status { get; set; }
    public DateTime LastMaintenanceDate { get; set; }
}
