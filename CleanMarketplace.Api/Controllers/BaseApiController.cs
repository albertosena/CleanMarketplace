using CleanMarketplace.Api.Fillter;
using Microsoft.AspNetCore.Mvc;

namespace CleanMarketplace.Api.Controllers { 
    [Route("api/[controller]")]
    [TypeFilter(typeof(AuthorizationFilterAttribute))]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
    }
}
