using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            BrandTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.Id);
            }
        }

        private static void BrandTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var cars in carManager.GetCarDetails())
            {
                Console.WriteLine(cars.CarName + "/" + cars.BrandName);
            }
        }

    }    
}
