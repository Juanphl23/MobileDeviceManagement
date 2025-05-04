using Microsoft.AspNetCore.Mvc;
using MobileDeviceManagement.Web.Data;
using MobileDeviceManagement.Web.Models;

namespace MobileDeviceManagement.Web.Controllers;

public class DeviceController : Controller
{
    private readonly AppDbContext _context;

    public DeviceController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var devices = _context.Devices.ToList();
        return View(devices);
    }
}
