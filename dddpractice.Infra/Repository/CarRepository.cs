using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using dddpractice.Domain;
using dddpractice.Domain.DTO;
using dddpractice.Domain.Entity;
using dddpractice.Domain.Repository;
using dddpractice.Infra.data;
using Microsoft.EntityFrameworkCore;

namespace dddpractice.Infra.Repository
{
    public class CarRepository : ICarRepository
    {

        private readonly AppDbContext _context;

        private readonly IMapper _mapper;

        public CarRepository(AppDbContext context,IMapper mapper)
        {
               _context = context;
            _mapper = mapper;
        }

        public async Task<Dictionary<string, object>> AddCar(string Name)
        {
           try
            {

                await _context.cars.AddAsync(new Car { Name = Name });

                await _context.SaveChangesAsync();

                return new Dictionary<string, object>
                {

                    {"status","success" },

                    {"message","added succesfully" }
                };

                
            }catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Dictionary<string, object>> getAllCars()
        {
            try
            {

                List<Car> cars = await _context.cars.ToListAsync();

                List<CarDto> carsDto=cars.Select(item=>_mapper.Map<CarDto>(item)).ToList();




                return new Dictionary<string, object> {

                    { "status", "success" },

                    { "message", carsDto }



                };
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
