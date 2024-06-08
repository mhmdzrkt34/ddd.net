using dddpractice.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddpractice.Application.Cars.Commands.AddCar
{
    public class AddCarCommandHandler : IRequestHandler<AddCarCommand, Dictionary<string, object>>
    {
        private readonly ICarRepository _carRepository;


        public AddCarCommandHandler(ICarRepository carRepository)
        {

            _carRepository = carRepository;
        }


        public async Task<Dictionary<string, object>> Handle(AddCarCommand request, CancellationToken cancellationToken)
        {
           try
            {

                Dictionary<string, object> result = await _carRepository.AddCar(request.Name);
                return result;


            }catch(Exception ex)
            {

                throw ex;
            }
        }
    }
}
