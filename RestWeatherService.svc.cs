using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using JohnsRestWeatherService.DataContracts;

// a web service implemented using WCF (Windows Communication Foundation)
// service is hosted on ASP.Net development server
// service returns weather in specified city i.e. current temperature and a description of the
// weather e.g. sunny, rain or cloudy
// data contact defined for complex return type for service operation i.e. WeatherInfo
namespace JohnsRestWeatherService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "weatherService" in code, svc and config file together.
    public class weatherService : IRestWeatherService
    {
        public WeatherInfo GetWeather(string city)
        {
            // hard coded return values for simplicity...

            WeatherInfo w = new WeatherInfo();
            w.Temperature = 25.0F;

            using (var a = new LottoService.bookDBEntities1())
            {
                var book = a.Books.FirstOrDefault().Pages;
                w.city = book.ToString();
            }
           
            return w;
        }


        public string UpdateWeather(WeatherInfo info)
        {
            string ret = "";

            //In areal world situation we would be writing the Passed in weatherinfo into a database
            //Not showing this just to keep it simple

            ret = "Weather for " + info.city + " has been updated.";
            ret += "Temp= " + info.Temperature.ToString() + ".";
            ret += "windspeed info = " + info.windInfo.ToString() + ".";

            return ret;
        }
    }
}
