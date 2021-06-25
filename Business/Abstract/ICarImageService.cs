﻿
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<CarImage> GetById(int carImageId);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetImagesByCarId(int carId);

        IResult Add(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
    }
}
