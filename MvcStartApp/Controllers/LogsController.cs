using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Repositories;

namespace MvcStartApp.Controllers
{
    public class LogsController : Controller
    {
        private readonly ILogRepository _repo;

        public LogsController(ILogRepository repo)
        {
            _repo = repo;
        }
        public async Task<IActionResult> Index()
        {
            var logs = await _repo.GetLogs();
            return View(logs);
        }
    }
}
