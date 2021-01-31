using Business.Abstract;
using Dataaccess.Abstract;
using Dataaccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Consrete
{
    public class CarManager : ICarService
    {
        ICarDal _ıCarDal;

        public CarManager(ICarDal ıCarDal)
        {
            _ıCarDal = ıCarDal;
        }

        public List<Car> GetAll()
        {
            return _ıCarDal.GetAll();
        }
    }
}
