using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddpractice.Application.Cars.Queries.GetCars
{
    public class GetCarsQuery:IRequest<Dictionary<string, object>>
    {
    }
}
