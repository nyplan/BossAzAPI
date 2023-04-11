using BossAzAPI.BLL.Abstract;
using BossAzAPI.DTOs.JobDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BossAzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobService _jobService;
        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<JobToListDto> dtos = _jobService.Get();
            return Ok(dtos);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            JobByIdDto dto = _jobService.Get(id);
            return Ok(dto);
        }
        [HttpPost]
        public IActionResult Add(JobToAddDto dto)
        {
            _jobService.Add(dto);
            return Ok(dto);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _jobService.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(JobToUpdateDto dto)
        {
            _jobService.Update(dto);
            return Ok(dto);
        }
    }
}
