using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dddpractice.Domain.Repository
{
    public interface ICarRepository
    {

        Task<Dictionary<string, object>> getAllCars();

        Task<Dictionary<string, object>> AddCar(String Name);
    }
}
