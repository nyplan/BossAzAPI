using BossAzAPI.BLL.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BossAzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumValuesController : ControllerBase
    {
        private readonly IEnumValueService _service;
        public EnumValuesController(IEnumValueService service)
        {
            _service = service;
        }

        [HttpGet("{keyId}")]
        public IActionResult GetByKey([FromRoute]int keyId)
        {
            return Ok(_service.Get(keyId));
        }

    }
}
