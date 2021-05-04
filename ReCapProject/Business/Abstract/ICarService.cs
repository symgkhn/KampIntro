using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCars();
        List<Car> GetCarsById(int id);
        List<Car> GetCarsByDailyPrice(decimal min, decimal max);
        List<CarDetailDto> GetCarDetails();
        void Delete(Car car);
        void Add(Car car);
        void Update(Car car);
    }
}
