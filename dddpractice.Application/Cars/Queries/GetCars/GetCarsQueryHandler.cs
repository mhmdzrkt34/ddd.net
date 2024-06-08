using dddpractice.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddpractice.Application.Cars.Queries.GetCars
{
    public class GetCarsQueryHandler : IRequestHandler<GetCarsQuery, Dictionary<string, object>>
    {

        private readonly ICarRepository _carRepository;



        public  GetCarsQueryHandler(ICarRepository carRepository)
        {
            _carRepository=carRepository;


        }
        public async Task<Dictionary<string, object>> Handle(GetCarsQuery request, CancellationToken cancellationToken)
        {
           try
            {

                Dictionary<string, object> result = await _carRepository.getAllCars();
                return result;


            }catch (Exception ex)
            {

                throw;
            }
        }
    }
}
