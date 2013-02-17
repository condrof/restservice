using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace JohnsRestWeatherService.DataContracts
{
    // a description of the current weather conditions
    enum WeatherDescription
    {
        Sunny, Rain, Cloudy
    }

    [DataContract(Namespace = "http://johnwalsh.com")]
    public class WeatherInfo
    {
        public WeatherInfo()
        {
            Temperature = 0f;
            windInfo = new WindInfo();
            notSentInfo = "";
        }
        // datamembers can be fields, properties, or events
        // datamembers will be serialized

        [DataMember]
        public string city  {get; set;} 

        [DataMember]
        private WeatherDescription weather;     //eventhough its private it will still be serialized

        [DataMember]                                // opt in, property                             
        public float Temperature    {get; set;}
        
        [DataMember]  
        public WindInfo windInfo    {get; set;}

         //This property will not be send or recieved by servcie as it does not have [DataMember]  attribute
         public string notSentInfo  {get; set;}

    }

    [DataContract(Namespace = "http://johnwalsh.com")]
    public class WindInfo
    {        
        [DataMember]
        public float windSpeed_KM  { get; set;}

        [DataMember]                                                      
        public float AvgWindSpeed_KM {get; set; }

        public override string ToString()
        {
            return " WindSpeed is " + windSpeed_KM.ToString() +
                   " AvgWindSpeed is " + AvgWindSpeed_KM.ToString();
        }
    }
    
}