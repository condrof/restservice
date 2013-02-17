using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using JohnsRestWeatherService.DataContracts;

namespace JohnsRestWeatherService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the 
    // interface name "IWeatherService" in both code and config file together.
    [ServiceContract(Namespace = "http://johnwalsh.com")]
    public interface IRestWeatherService
    {
        // value and ref types all passed by value unless ref keyword used on parameter

        [OperationContract]                                 
        [WebGet(UriTemplate = "/Weather/{city}")]  
        WeatherInfo GetWeather(string city);                

        [OperationContract]
        [WebInvoke(UriTemplate = "/Weather", Method="POST")]                        
        string UpdateWeather(WeatherInfo info);             
    }

}
