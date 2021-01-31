using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dataaccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById(int carId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
       
    }
}
