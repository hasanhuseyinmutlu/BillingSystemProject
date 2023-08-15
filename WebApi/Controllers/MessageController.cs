using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _messageService.GetAll();
            if(result.Success)
                return Ok(result.Data);
            return BadRequest();
        }
        [HttpPost("add")]
        public IActionResult Add(Message message)
        {
            var result = _messageService.Add(message);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest();
        }

        [HttpPut("update")]
        public IActionResult Update(Message message) 
        {
            var result = _messageService.Update(message);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest();
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Message message) 
        {
            var result = _messageService.Delete(message);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest();
        }
            
    }
}
