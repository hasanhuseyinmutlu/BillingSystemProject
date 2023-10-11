using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private IApartmentService _apartmentService;
        public ApartmentController(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _apartmentService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getCustomerApartment")]
        public IActionResult GetCustomerAparmentDetail()
        {
            var result = _apartmentService.GetCustomerAparmentDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getApartmentDue")]
        public IActionResult GetAparmentDuesDetail()
        {
            var result = _apartmentService.GetApartmentDuesDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("getAparmentBill")]
        public IActionResult GetApartmentBillDetail()
        {
            var result = _apartmentService.GetAparmentBillDetail();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet]
        [Route("getapartbillbyid/{id}")]
        public IActionResult GetApartmentBillById(int id)
        {
            var result = _apartmentService.GetApartmentBillById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [Route("getapartduebyid/{id}")]
        public IActionResult GetApartmentDueById(int id) 
        {
            var result = _apartmentService.GetApartmentDuesById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Apartment apartment) 
        {
            var result = _apartmentService.Add(apartment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("update")]
        public IActionResult Update(Apartment apartment) 
        {
            var result = _apartmentService.Update(apartment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Apartment apartment)
        {
            var result = _apartmentService.Delete(apartment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
