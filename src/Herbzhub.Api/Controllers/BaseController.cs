using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Herbzhub.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
    }
}
