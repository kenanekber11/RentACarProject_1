using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EFEntityRepositoryBase<Car, RentCarDbContext>, ICarDal
    {
        public List<CarDetail> GetCarDetail()
        {
            using (RentCarDbContext context = new RentCarDbContext())
            {
                var result1 = from car in context.Cars
                              join clr in context.Colors
                              on car.ColorID equals clr.Id
                              join b in context.Brands
                              on car.BrandID equals b.Id
                              select new CarDetail
                              {
                                  CarName = car.Description,
                                  BrandName = b.Name,
                                  ColorName = clr.Name,
                                  DailyPrice = car.DailyPrice
                              };
                            
                return result1.ToList();
            }
        }
    }
}
