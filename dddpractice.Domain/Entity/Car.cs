using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddpractice.Domain.Entity
{
    public class Car
    {
        [Key]
        public String Id { get; set; }

        public string Name { get; set; }



        public Car()
        {

            Id = Guid.NewGuid().ToString();
        }
    }
}
