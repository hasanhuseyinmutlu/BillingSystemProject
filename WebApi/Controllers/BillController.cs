using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private IBillService _billService;

        public BillController(IBillService billService)
        {
            _billService = billService;
        }

        [HttpGet("getall")]
        public IActionResult Getall()
        {
            var result = _billService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Bill bill)
        {
            var result = _billService.Add(bill);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Bill bill)
        {
            var result = _billService.Update(bill);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete ("delete")]
        public IActionResult Delete(Bill bill)
        {
            var result = _billService.Delete(bill);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
