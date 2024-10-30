using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineVotingSystem.Models;

namespace AspnetCoreMvcFull.Controllers;

public class DashboardsController : Controller
{
  public IActionResult Index() => View();
}
