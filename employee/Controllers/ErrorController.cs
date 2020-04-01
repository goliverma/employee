using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace employee.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            this.logger=logger;
        }
        [Route("Error/{statusCode}")]
        public async Task<IActionResult> HttpStatusCodeHandler(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            await Task.Run(()=>{
                switch(statusCode)
                {
                    case 404:
                    ViewBag.ErrorMessage ="Sorry, the resource you request could not be found";
                    logger.LogWarning($"404 Error occured. Path ={statusCodeResult.OriginalPath}"+
                        $"and query string = {statusCodeResult.OriginalQueryString}");
                    break;
                }
            });
            return View("NotFound");
        }
        [Route("Error")]
        [AllowAnonymous]
        public async Task<IActionResult> Error()
        {
            var exceptionResult= HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            await Task.Run(() => {
                logger.LogError($"The path {exceptionResult.Path} threw an exception {exceptionResult.Error} ");
            });
            return View("Error");
        }
    }
}