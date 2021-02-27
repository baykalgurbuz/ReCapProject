using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150, Description="Sanrooflu Arac",ModelYear=2007},
                new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=350, Description="Otomatik Arac",ModelYear=2005},
                new Car{Id=3,BrandId=3,ColorId=1,DailyPrice=250, Description="Düz Vites Arac",ModelYear=2016},
                new Car{Id=4,BrandId=1,ColorId=1,DailyPrice=550, Description="7 ileri 1 geri Arac",ModelYear=2009},
                new Car{Id=5,BrandId=2,ColorId=1,DailyPrice=50, Description="Güzel Araç",ModelYear=2017},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
           return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
