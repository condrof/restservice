using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RestBookService.DataContracts;

// a web service implemented using WCF (Windows Communication Foundation)
// service is hosted on ASP.Net development server
// service returns weather in specified city i.e. current temperature and a description of the
// weather e.g. sunny, rain or cloudy
// data contact defined for complex return type for service operation i.e. WeatherInfo
namespace RestBookService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "weatherService" in code, svc and config file together.
    public class bookService : IBookService
    {
        public BookInfo GetBook(double price)
        {
            // hard coded return values for simplicity...
            

            BookInfo w = new BookInfo();
            w.price = price;

            using (var a = new LottoService.bookDBEntities1())
            {
                var book = a.Books.FirstOrDefault().Price;
                w.price = (double) book;
            }
           
            return w;
        }


        public BookInfo UpdateBook(BookInfo info)
        {
            BookInfo b = new BookInfo();
            using (var a = new LottoService.bookDBEntities1())
            {
                //using first or default rather than search just as proof of principal
                var book = a.Books.FirstOrDefault();
                book.Price = (decimal)info.price;
                book.Pages = info.Pages;
                book.Paperback = info.paperback;
                a.SaveChanges();
                b.price = info.price;
                b.paperback = info.paperback;
                b.Pages = info.Pages;
                
            }
            return b;
        }
    }
}
