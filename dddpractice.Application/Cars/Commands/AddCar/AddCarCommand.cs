using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddpractice.Application.Cars.Commands.AddCar
{
    public class AddCarCommand :IRequest<Dictionary<string,object>>
    {

        public string Name { get; set; }
    }
}
