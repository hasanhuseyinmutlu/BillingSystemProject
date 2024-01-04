using Business.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPaymentController : Controller
    {
        private readonly IUserCardService _userCardService;
        private readonly IPaymentService _paymentService;

        public UserPaymentController(IPaymentService paymentService, IUserCardService userCardService)
        {
            _paymentService = paymentService;
            _userCardService = userCardService;
        }

        [HttpPost("addcart")]
        public IActionResult AddCard(UserCard cart)
        {
            var result = _userCardService.Add(cart);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult EditCard(UserCard cart)
        {
            var result = _userCardService.Update(cart);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult DeleteCard(UserCard cart)
        {
            var result = _userCardService.Delete(cart);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getusercard")]
        public IActionResult GetUserCard()
        {
            var result = _userCardService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet]
        [Route("getcustomercard/{id}")]
        public IActionResult GetCustomerCard(int id)
        {
            var result = _userCardService.GetCustomerCard(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("payment")]
        public IActionResult PaymentAdd(Payment payment)
        {
            var paymentResult = _paymentService.Payment(payment);

            if (paymentResult.Success)
            {
                return Ok(paymentResult);
            }
         
            return BadRequest(paymentResult);
            
        }
        [HttpGet]
        public IActionResult ListPayment()
        {
            var result = _paymentService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
