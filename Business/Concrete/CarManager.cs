﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        

        public void Add(Car car)
        {
            _carDal.Add(car);
            Console.WriteLine("Araba Başarılı Bir Şekilde Eklendi");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba Başarılı Bir Şekilde Silindi");
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Araba Başarılı Bir Şekilde Güncellendi.");
        }
    }
}
