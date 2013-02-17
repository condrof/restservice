using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace RestBookService.DataContracts
{
    [DataContract(Namespace = "http://johnwalsh.com")]
    public class BookInfo
    {
        public BookInfo()
        {
            name = "book name";
            notSentInfo = "";
        }
        // datamembers can be fields, properties, or events
        // datamembers will be serialized

        [DataMember]
        public string name  {get; set;} 

        [DataMember]                                // opt in, property                             
        public int Pages    {get; set;}
        
        [DataMember]  
        public double price    {get; set;}

        [DataMember]
        public Boolean paperback { get; set; }

         //This property will not be send or recieved by servcie as it does not have [DataMember]  attribute
         public string notSentInfo  {get; set;}

    }
   
}