using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {

            CarTest();

            //BrandTest();

            //ColorTest();
        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();

            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    System.Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();

            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    System.Console.WriteLine(color.BrandName);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    System.Console.WriteLine(car.CarName);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
        }
    }
}
