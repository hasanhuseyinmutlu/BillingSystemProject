using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuesController : ControllerBase
    {
        IDuesService _duesService;

        public DuesController(IDuesService duesService)
        {
            _duesService = duesService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _duesService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Dues dues)
        {
             var result = _duesService.Add(dues);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Dues dues)
        {
            var result = _duesService.Update(dues);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Dues dues)
        {
            var result = _duesService.Delete(dues);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
