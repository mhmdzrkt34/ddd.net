using AutoMapper;
using dddpractice.Domain.DTO;
using dddpractice.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddpractice.Application.Common.Mapping
{
    public class Mapping:Profile
    {

       public Mapping()
        {


            CreateMap<Car, CarDto>();
        }
    }
}
