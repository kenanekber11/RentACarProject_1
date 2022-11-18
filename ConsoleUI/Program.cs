using Business.Concrete;
using Business.Abstract;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //InMemoryCarDal carDal = new InMemoryCarDal();
            //var removeCar = carDal.GetAll().Find(x => x.ID == 3);
            //// carDal.Delete(removeCar);
            //carDal.Add(new Car { ID = 2, BrandID = 1, ModelYear = 1996, ColorID = 1, DailyPrice = 2000, Description = "BMW X7" });

            //removeCar.DailyPrice = 5000;
            //removeCar.Description = "Mitsibushi";
            //carDal.Update(removeCar);
            //foreach (var item in carDal.GetAll())
            //{
            //    Console.WriteLine(item.Description);
            //}

            CarManagement carManagement = new CarManagement(new EFCarDal());
          
            /* var result = carManagement.GetCarDetail();

              if (result.Success==true)
              {
                  foreach (var car in result.Data)
                  {
                      Console.WriteLine(car.BrandName + "/" + car.ColorName+ "/" + car.CarName);
                  }
              }
              else
              {
                  Console.WriteLine(result.Message);
              }
   */
            

        }
    }
}
