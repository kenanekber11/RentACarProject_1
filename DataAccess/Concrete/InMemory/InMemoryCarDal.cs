using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
        
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars= new List<Car> {
            new Car { ID = 1, BrandID = 1, ModelYear = 1996, ColorID = 1, DailyPrice = 3000, Description = "BMW 7i" },
            new Car { ID = 2, BrandID = 1, ModelYear = 1996, ColorID = 1, DailyPrice = 2000, Description = "BMW 5i" } ,
            new Car { ID = 3, BrandID = 1, ModelYear = 1996, ColorID = 1, DailyPrice = 4000, Description = "BMW X6" }
        };
    }
       
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var CarToDelete = _cars.SingleOrDefault(c => c.ID == car.ID);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetail> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public List<CarDetail> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var CarToUpdate = _cars.SingleOrDefault(c => c.ID == car.ID);
            CarToUpdate.BrandID = car.BrandID;
            CarToUpdate.ColorID = car.ColorID;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
