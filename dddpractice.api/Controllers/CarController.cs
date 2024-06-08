
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using dddpractice.Application;

using dddpractice.Application.Cars.Queries.GetCars;
using MediatR;
using dddpractice.Application.Cars.Commands.AddCar;

namespace dddpractice.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarController(IMediator mediator)
        {
            _mediator = mediator;
        }




        [HttpGet]
        public async Task<IActionResult> getAllCars()
        {



            try
            {

                Dictionary<string, object> result = await _mediator.Send(new GetCarsQuery());

                return Ok(result);



            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]

        public async Task<IActionResult> addCar([FromBody] AddCarRequest request)
        {

            try
            {


                if (!ModelState.IsValid)
                {

                    return BadRequest(ModelState);
                }

                Dictionary<string,object> result= await _mediator.Send(new AddCarCommand()
                {
                    Name = request.Name,
                });
                return Ok(result);


            }catch(Exception ex)
            {

                return BadRequest(500);
            }
        }
    }
}
