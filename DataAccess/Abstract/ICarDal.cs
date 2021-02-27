using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal   //Car dosyasıyla alakalı yapacağımız veritabanı komutlarımızı buraya yazarız 
    {
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car );
        void Delete(Car car);
        List<Car> GetAllByBrand(int brandId);
        
    }
}
