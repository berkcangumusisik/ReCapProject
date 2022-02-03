using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
             {

                 new Car
                 {
                     ID = 1, BrandID = 1, ColorID = 1, DailyPrice = 500000, ModelYear = 2022,
                     Description = " Araç sıfırdır. "
                 },
                 new Car
                 {
                     ID = 2, BrandID = 1, ColorID = 2, DailyPrice = 200000, ModelYear = 2019,
                     Description = " Araç 2.eldir. Ama çok temiz kullanılmıştır."
                 },
                 new Car
                 {
                     ID = 3, BrandID = 2, ColorID = 2, DailyPrice = 100000, ModelYear = 2008,
                     Description = " Araç 2.eldir. Boya kaplama işlemi yapılmıştır."
                 },
                 new Car
                 {
                     ID = 4, BrandID = 3, ColorID = 3, DailyPrice = 400000, ModelYear = 2019,
                     Description = " Araç sıfırdır. "
                 },
                 new Car
                 {
                     ID = 5, BrandID = 3, ColorID = 4, DailyPrice = 180000, ModelYear = 2020,
                     Description = " Araç 2.eldir. Birkaç küçük kaza atlatmıştır. "
                 }

             };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.ID == car.ID);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.ID == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.ID == car.ID);

            carToUpdate.BrandID = car.BrandID;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
