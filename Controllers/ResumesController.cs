using BossAzAPI.BLL.Abstract;
using BossAzAPI.DTOs.JobDTOs;
using BossAzAPI.DTOs.ResumeDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BossAzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumesController : ControllerBase
    {
        private readonly IResumeService _service;
        public ResumesController(IResumeService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<ResumeToListDto> dtos = _service.Get();
            return Ok(dtos);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ResumeByIdDto dto = _service.Get(id);
            return Ok(dto);
        }
        [HttpPost]
        public IActionResult Add(ResumeToAddDto dto)
        {
            _service.Add(dto);
            return Ok(dto);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _service.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(ResumeToUpdateDto dto)
        {
            _service.Update(dto);
            return Ok(dto);
        }
    }
}
