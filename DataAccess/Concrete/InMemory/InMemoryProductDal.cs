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
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {

               new Car { Id = 1, BrandId = 1, CarName = "Opel", ModelYear = 1997, DailyPrice = 150, Description =".." },
               new Car { Id = 2, BrandId = 2, CarName = "Ford", ModelYear = 1997, DailyPrice = 250, Description ="..." },
               new Car { Id = 3, BrandId = 3, CarName = "Hundai", ModelYear = 1997, DailyPrice = 350, Description ="...." },
               new Car { Id = 4, BrandId = 4, CarName = "TOGG", ModelYear = 2022, DailyPrice = 750, Description ="....." },

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {

            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
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

        public List<Car> GetAllById(int BrandId)
        {
            return _cars.Where(p => p.BrandId == BrandId).ToList();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            //Gönderilen ürün id'sine sahip listedeki ürünü bulmamızı sağlar.
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }

}
