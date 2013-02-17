using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RestBookService.DataContracts;

namespace RestBookService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the 
    // interface name "IWeatherService" in both code and config file together.
    [ServiceContract(Namespace = "http://johnwalsh.com")]
    public interface IBookService
    {
        // value and ref types all passed by value unless ref keyword used on parameter

        [OperationContract]                                 
        [WebGet(UriTemplate = "/Book/{price}")]  
        BookInfo GetBook(double price);                

        [OperationContract]
        [WebInvoke(UriTemplate = "/Book", Method="POST")]                        
        BookInfo UpdateBook(BookInfo info);             
    }

}
