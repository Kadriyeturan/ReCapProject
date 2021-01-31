using Dataaccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dataaccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public int CarId { get; private set; }

        public InMemoryCarDal() 
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, CategoryId=1, BrandId=1, ColorId=2, ModelYear=2020, DailyPrice=600, Description="Mercedes Benz GLB 200 1.3 AMG"},
                new Car{CarId=2, CategoryId=2, BrandId=3, ColorId=3, ModelYear=2018, DailyPrice=320, Description="Mercedes Benz X 220D"},
                new Car{CarId=3, CategoryId=1, BrandId=2, ColorId=2, ModelYear=2015, DailyPrice=350, Description="Audi R8 4.2 FSI Quattro R-Tronic"},
                new Car{CarId=4, CategoryId=2, BrandId=1, ColorId=1, ModelYear=2015, DailyPrice=500, Description="Range Rover Sport 3.0 HSE Dynamic Hybrid"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById()
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate;

            carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUpdate.CarId = car.CarId;
            carToUpdate.CategoryId = car.CategoryId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
           return _cars.Where(c => c.CategoryId == categoryId).ToList();
        }

        public List<Car> GetById(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
