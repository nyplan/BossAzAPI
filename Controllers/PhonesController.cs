using BossAzAPI.BLL.Abstract;
using BossAzAPI.DTOs.PhoneDTOs;
using Microsoft.AspNetCore.Mvc;

namespace BossAzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        private readonly IPhoneService _service;
        public PhonesController(IPhoneService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Post(PhoneToAddDto dto)
        {
            _service.Add(dto);
            return Ok(dto);
        }
    }
}
