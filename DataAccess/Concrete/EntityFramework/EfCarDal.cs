using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from cars in context.Cars
                             join brands in context.Brands
                             on cars.BrandId equals brands.BrandId

                             join colors in context.Colors
                             on cars.ColorId equals colors.ColorId
                             select new CarDetailDto
                             {
                                 CarId = cars.CarId,
                                 CarName = cars.CarName,
                                 Description = cars.Descriptions,
                                 BrandId = brands.BrandId,
                                 BrandName = brands.BrandName,
                                 ColorId = colors.ColorId,
                                 ColorName = colors.ColorName,
                                 DailyPrice = cars.DailyPrice,
                                 ModelYear = cars.ModelYear
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
